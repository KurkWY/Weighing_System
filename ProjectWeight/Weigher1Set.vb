Imports System.IO.Ports
Imports System.Threading
Imports System.Data.DataTable
Imports System.Data.SqlClient

Public Class Weigher1Set

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
        chBuf(0) = &H1
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
        frame(0) = &H1
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
        MessageBox.Show("Setting Succesful")

        Form1.Label2.Text = "Weight Set :" & TextBoxWeightSet.Text & "kg"

    End Sub

    Public Function CRC(buf() As Byte, lbuf As Integer) As Integer
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
End Class