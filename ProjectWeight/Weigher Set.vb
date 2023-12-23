Imports System.IO.Ports
Imports System.Threading
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class Weigher2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Weigher2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user10\source\repos\ProjectWeight\ProjectWeight\DatabaseReport.mdf;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        Try
            SerialPort1.Open()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Weigher2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            SerialPort1.Close()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim input As Integer = TextBoxWeightSet.Text
        Dim hexInput As String = Hex(input)
        Dim exchange As String = hexInput.PadLeft(4, "0"c)

        Dim value1 As String
        Dim value2 As String

        value1 = exchange.Substring(0, 2)
        value2 = exchange.Substring(2, 2)

        Dim convert1, convert2 As Byte

        convert1 = Convert.ToByte(value1, 16)
        convert2 = Convert.ToByte(value2, 16)

        Dim chBuf(8) As Byte
        chBuf(0) = &H2
        chBuf(1) = &H10
        chBuf(2) = &H0
        chBuf(3) = &H50
        chBuf(4) = &H0
        chBuf(5) = &H1
        chBuf(6) = &H2
        chBuf(7) = convert1
        chBuf(8) = convert2

        Dim calculate As String = CRC(chBuf, 9)
        Dim hexValue As String = Hex(calculate)
        Dim exchange2 As String = hexValue.PadLeft(4, "0"c)

        Dim subst1 As String
        Dim subst2 As String

        subst1 = exchange2.Substring(0, 2)
        subst2 = exchange2.Substring(2, 2)

        Dim convert3, convert4 As Byte

        convert3 = Convert.ToByte(subst1, 16)
        convert4 = Convert.ToByte(subst2, 16)

        Dim frame(10) As Byte
        frame(0) = &H2
        frame(1) = &H10
        frame(2) = &H0
        frame(3) = &H50
        frame(4) = &H0
        frame(5) = &H1
        frame(6) = &H2
        frame(7) = convert1
        frame(8) = convert2
        frame(9) = convert4
        frame(10) = convert3

        Try
            SerialPort1.Write(frame, 0, frame.Length) ' Send frame to modbus slave.
            Thread.Sleep(150) 'Delay 150ms 'concatenate with \n
            If (SerialPort1.BytesToRead > 5) Then
                Dim buffRecei As Byte() = New Byte(SerialPort1.BytesToRead - 1) {}
                SerialPort1.Read(buffRecei, 0, buffRecei.Length) ' Read data from modbus slave.
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        LabelSetShow.Text = TextBoxWeightSet.Text

        Form1.Label1.Text = "Weight Set :" & TextBoxWeightSet.Text

    End Sub

    Private Function CRC(buf() As Byte, lbuf As Integer) As Integer
        '-------------------------------------------------
        ' returns the MODBUS CRC of the lbuf first bytes of "buf" buffer (buf is a global array of bytes)
        Dim CRC1, k As Integer

        CRC1 = &HFFFF ' init CRC
        For i = 0 To lbuf - 1 Step 1 ' for each byte
            CRC1 = CRC1 Xor buf(i)
            For j = 0 To 7 Step 1 ' for each bit
                k = CRC1 And 1 ' memo bit 0 state
                CRC1 = ((CRC1 And &HFFFE) / 2) And &H7FFF ' Shift right with 0 at left
                If k > 0 Then CRC1 = CRC1 Xor &HA001 ' Bocuse
            Next j
        Next i
        CRC = CRC1
    End Function

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        SerialPort1.ReadExisting()
    End Sub

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into Report values('" + Date.Now.ToString("dd/MM/yyyy") + "','" + TextBoxLot.Text + "','" + TextBoxPName.Text + "','" + TextBoxCName.Text + "','" + TextBoxWeightSet.Text + "','" + TextBoxWeightSet.Text + "')"
        cmd.ExecuteNonQuery()

        MessageBox.Show("Insert Successful!")
    End Sub

    ''----------------------------------Read Value---------------------------------------------'

    'Private Function ReadHolingRegisters(slaveAddress As Byte, functionCode As Byte, startAddress As UShort, numberOfPoints As UShort) As Byte()
    '    Dim frameRead As Byte() = New Byte(7) {} ' Total 8 Bytes
    '    frameRead(0) = slaveAddress ' Slave Address
    '    frameRead(1) = functionCode 'Function
    '    frameRead(2) = CByte(startAddress / 256) 'Starting Address Hi.
    '    frameRead(3) = CByte(startAddress Mod 256) 'Starting Address Lo.
    '    frameRead(4) = CByte(numberOfPoints / 256) ' Quantity of Registers Hi.
    '    frameRead(5) = CByte(numberOfPoints Mod 256) ' Quantity of Registers Lo.
    '    Dim crc As Byte() = Me.CRCRead(frameRead) ' Call CRC Calculate.
    '    frameRead(6) = crc(0) ' Error Check Lo
    '    frameRead(7) = crc(1) ' Error Check Hi
    '    Return frameRead '
    'End Function

    '' Modbus CRC calculation in VB (Tested with success).
    'Private Function CRCRead(data As Byte()) As Byte()
    '    Dim CRCFull As UShort = &HFFFF
    '    Dim CRCHigh As Byte = &HF, CRCLow As Byte = &HFF
    '    Dim CRCLSB As Char
    '    Dim result As Byte() = New Byte(1) {}
    '    For i As Integer = 0 To (data.Length) - 3
    '        CRCFull = CUShort(CRCFull Xor data(i))

    '        For j As Integer = 0 To 7
    '            CRCLSB = ChrW(CRCFull And &H1)
    '            CRCFull = CUShort((CRCFull >> 1) And &H7FFF)

    '            If Convert.ToInt32(CRCLSB) = 1 Then
    '                CRCFull = CUShort(CRCFull Xor &HA001)
    '            End If
    '        Next
    '    Next
    '    CRCHigh = CByte((CRCFull >> 8) And &HFF)
    '    CRCLow = CByte(CRCFull And &HFF)
    '    Return New Byte(1) {CRCLow, CRCHigh}
    'End Function

    ''Display frame.
    'Private Function DisplayValue(values As Byte()) As String
    '    Dim result As String = String.Empty
    '    For Each item As Byte In values
    '        result += String.Format("{0:X2} ", item)
    '    Next
    '    Return result
    'End Function

    'Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
    '    Try
    '        Dim slaveAddress As Byte = 2
    '        Dim functionCode As Byte = 3
    '        Dim startAddress As UShort = 86
    '        Dim numberOfPoints = 1 ' Read 4 Float.

    '        Dim frame2 As Byte() = Me.ReadHolingRegisters(slaveAddress, functionCode, startAddress, numberOfPoints)
    '        'txtSendMsg.Text = Me.DisplayValue(frame) ' Diplays frame: send.
    '        SerialPort1.Write(frame2, 0, frame2.Length) ' Send frame to modbus slave.

    '        Thread.Sleep(100) ' Delay 100ms.

    '        If SerialPort1.BytesToRead > 5 Then
    '            Dim buffRecei2 As Byte() = New Byte(SerialPort1.BytesToRead) {}
    '            SerialPort1.Read(buffRecei2, 0, buffRecei2.Length) ' Read data from modbus slave.
    '            'txtReceiMsg.Text = Me.DisplayValue(buffRecei) ' Display frame: received.

    '            Dim extract As String = DisplayValue(buffRecei2).Substring(9, 5)
    '            extract = extract.Replace(" ", String.Empty)
    '            Label7.Text = Val("&H" & extract)
    '            'Dim data As Byte() = New Byte(buffRecei.Length - 5) {}
    '            'Array.Copy(buffRecei, 3, data, 0, data.Length)

    '            '' Convert byte array to word array
    '            'Dim result As Single() = DataType.Real.ToArrayInverse(data) '

    '            ''Display Result
    '            'txtResult.Text = String.Empty
    '            'For Each item As Single In result
    '            '    txtResult.Text += String.Format("{0}/ ", item)
    '            'Next
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class