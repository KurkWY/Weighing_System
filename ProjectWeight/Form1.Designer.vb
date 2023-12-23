Imports System.Data.SqlClient
Imports System.Threading

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()

        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.DtrEnable = True
        Me.SerialPort1.PortName = "COM7"
        Me.SerialPort1.RtsEnable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(232, 874)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Magenta
        Me.Button2.Location = New System.Drawing.Point(0, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(232, 54)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Magenta
        Me.Button1.Location = New System.Drawing.Point(0, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 54)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Overview"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Location = New System.Drawing.Point(12, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(209, 44)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "DashBoard"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 2)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(238, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(981, 874)
        Me.Panel3.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Location = New System.Drawing.Point(1, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(980, 100)
        Me.Panel6.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProjectWeight.My.Resources.Resources.Zodiak_5
        Me.PictureBox1.Location = New System.Drawing.Point(29, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.NavajoWhite
        Me.Label22.Location = New System.Drawing.Point(194, 26)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(657, 48)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Welcome to Weighing Software"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.BlueViolet
        Me.Panel4.Controls.Add(Me.GroupBox9)
        Me.Panel4.Controls.Add(Me.GroupBox8)
        Me.Panel4.Controls.Add(Me.GroupBox7)
        Me.Panel4.Controls.Add(Me.GroupBox6)
        Me.Panel4.Controls.Add(Me.GroupBox5)
        Me.Panel4.Controls.Add(Me.GroupBox4)
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Location = New System.Drawing.Point(3, 110)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(978, 764)
        Me.Panel4.TabIndex = 0
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.Button27)
        Me.GroupBox9.Controls.Add(Me.Button28)
        Me.GroupBox9.Controls.Add(Me.Button29)
        Me.GroupBox9.Location = New System.Drawing.Point(665, 527)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(292, 197)
        Me.GroupBox9.TabIndex = 32
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Weigher 9"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 24)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Set"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 24)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Weight"
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.Red
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button27.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Location = New System.Drawing.Point(211, 147)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(75, 37)
        Me.Button27.TabIndex = 4
        Me.Button27.Text = "Stop"
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.LimeGreen
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Location = New System.Drawing.Point(109, 147)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(75, 37)
        Me.Button28.TabIndex = 3
        Me.Button28.Text = "Start"
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.Yellow
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Location = New System.Drawing.Point(6, 147)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(75, 37)
        Me.Button29.TabIndex = 2
        Me.Button29.Text = "Set"
        Me.Button29.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox8.Controls.Add(Me.Label16)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Button24)
        Me.GroupBox8.Controls.Add(Me.Button25)
        Me.GroupBox8.Controls.Add(Me.Button26)
        Me.GroupBox8.Location = New System.Drawing.Point(341, 527)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(292, 197)
        Me.GroupBox8.TabIndex = 32
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Weigher 8"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 24)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Set"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 24)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Weight"
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.Red
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button24.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Location = New System.Drawing.Point(211, 147)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(75, 37)
        Me.Button24.TabIndex = 4
        Me.Button24.Text = "Stop"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.LimeGreen
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button25.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Location = New System.Drawing.Point(109, 147)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(75, 37)
        Me.Button25.TabIndex = 3
        Me.Button25.Text = "Start"
        Me.Button25.UseVisualStyleBackColor = False
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.Yellow
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.Location = New System.Drawing.Point(6, 147)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(75, 37)
        Me.Button26.TabIndex = 2
        Me.Button26.Text = "Set"
        Me.Button26.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Button21)
        Me.GroupBox7.Controls.Add(Me.Button22)
        Me.GroupBox7.Controls.Add(Me.Button23)
        Me.GroupBox7.Location = New System.Drawing.Point(18, 523)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(292, 201)
        Me.GroupBox7.TabIndex = 31
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Weigher 7"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(18, 96)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 24)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Set"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 24)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Weight"
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.Red
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(211, 147)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(75, 37)
        Me.Button21.TabIndex = 4
        Me.Button21.Text = "Stop"
        Me.Button21.UseVisualStyleBackColor = False
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.LimeGreen
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(109, 147)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(75, 37)
        Me.Button22.TabIndex = 3
        Me.Button22.Text = "Start"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.Yellow
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button23.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(6, 147)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(75, 37)
        Me.Button23.TabIndex = 2
        Me.Button23.Text = "Set"
        Me.Button23.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Label23)
        Me.GroupBox6.Controls.Add(Me.Button18)
        Me.GroupBox6.Controls.Add(Me.Button19)
        Me.GroupBox6.Controls.Add(Me.Button20)
        Me.GroupBox6.Location = New System.Drawing.Point(341, 296)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(292, 201)
        Me.GroupBox6.TabIndex = 30
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Weigher 5"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(18, 99)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(43, 24)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Set"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(18, 39)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 24)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Weight"
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Red
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(211, 147)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(75, 37)
        Me.Button18.TabIndex = 4
        Me.Button18.Text = "Stop"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.LimeGreen
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(109, 147)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(75, 37)
        Me.Button19.TabIndex = 3
        Me.Button19.Text = "Start"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Yellow
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(6, 147)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 37)
        Me.Button20.TabIndex = 2
        Me.Button20.Text = "Set"
        Me.Button20.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Button15)
        Me.GroupBox5.Controls.Add(Me.Button16)
        Me.GroupBox5.Controls.Add(Me.Button17)
        Me.GroupBox5.Location = New System.Drawing.Point(665, 296)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(292, 201)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Weigher 6"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(19, 99)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(43, 24)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Set"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Weight"
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Red
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(211, 147)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(75, 37)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "Stop"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.LimeGreen
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(109, 147)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(75, 37)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "Start"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Yellow
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(6, 147)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(75, 37)
        Me.Button17.TabIndex = 2
        Me.Button17.Text = "Set"
        Me.Button17.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Button12)
        Me.GroupBox4.Controls.Add(Me.Button13)
        Me.GroupBox4.Controls.Add(Me.Button14)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 296)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(292, 201)
        Me.GroupBox4.TabIndex = 31
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Weigher 4"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(18, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(43, 24)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Set"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(18, 39)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 24)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Weight"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Red
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(211, 147)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 37)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = "Stop"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.LimeGreen
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(109, 147)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 37)
        Me.Button13.TabIndex = 3
        Me.Button13.Text = "Start"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Yellow
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(6, 147)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(75, 37)
        Me.Button14.TabIndex = 2
        Me.Button14.Text = "Set"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Button11)
        Me.GroupBox3.Location = New System.Drawing.Point(665, 65)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(292, 201)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Weigher 3"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(19, 100)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 24)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "Set"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(19, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 24)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Weight"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Red
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(211, 147)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 37)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Stop"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LimeGreen
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(109, 147)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 37)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "Start"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Yellow
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(6, 147)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 37)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "Set"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Turquoise
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 201)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weigher 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Set"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(211, 147)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 37)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(109, 147)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Start"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Yellow
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(6, 147)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 37)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Set"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Weight"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(292, 201)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weigher 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Set"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Red
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(211, 147)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 37)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Stop"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LimeGreen
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(109, 147)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 37)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Start"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Yellow
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(6, 147)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 37)
        Me.Button8.TabIndex = 2
        Me.Button8.Text = "Set"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Weight"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.Control
        Me.Label20.Location = New System.Drawing.Point(12, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(202, 32)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Weigher Detail"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 846)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button24 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label4 As Label


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Weigher2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Report.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Weigher1Set.Show()
    End Sub

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label21 As Label


End Class
