'Public Class Form1
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        With SerialPort1 'Connection for my serial port

'            .Close()

'            .PortName = "COM7"

'            .BaudRate = 9600

'            .Parity = Parity.None

'            .DataBits = 8

'            .StopBits = StopBits.One

'            .DtrEnable = True

'            .RtsEnable = True

'            .ReceivedBytesThreshold = 1

'        End With

'        SerialPort1.Open()

'        Timer1.Interval = 1000

'        Timer1.Enabled = True

'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        ReadData()
'    End Sub

'    Private Sub ReadData()

'        Try

'            Dim strRead As String = SerialPort1.ReadExisting



'            Dim i As Integer = strRead.LastIndexOf("04") 'find the index of the last "ES" in the string



'            If i Is -1 Then "ES" was not found in the string

'            If i > -1 Then

'                strRead = strRead.Substring(i - 5, 5) 'get the substring of the leading space or leading "-" and the 4 numbers after it

'                Label1.Text = strRead 'set the text to the parsed string

'            End If

'        Catch ex As Exception

'            Timer1.Stop() 'stop the timer and alert the user of an error

'            MessageBox.Show("Error Reading and Parsing Received Data")

'        End Try

'    End Sub

'    Private Sub Button1_Click(sender As Object, e As EventArgs)
'        Timer1.Start()
'    End Sub


'End Class
