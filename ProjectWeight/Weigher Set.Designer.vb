<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Weigher2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxLot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxPName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelSetShow = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBoxWeightSet = New System.Windows.Forms.TextBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxCName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBoxLot)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxPName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.LabelSetShow)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.TextBoxWeightSet)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 436)
        Me.Panel1.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(47, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Weight Set:"
        '
        'TextBoxCName
        '
        Me.TextBoxCName.Location = New System.Drawing.Point(340, 227)
        Me.TextBoxCName.Multiline = True
        Me.TextBoxCName.Name = "TextBoxCName"
        Me.TextBoxCName.Size = New System.Drawing.Size(224, 28)
        Me.TextBoxCName.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DarkCyan
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(335, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 25)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Chemical Name"
        '
        'TextBoxLot
        '
        Me.TextBoxLot.Location = New System.Drawing.Point(52, 115)
        Me.TextBoxLot.Multiline = True
        Me.TextBoxLot.Name = "TextBoxLot"
        Me.TextBoxLot.Size = New System.Drawing.Size(104, 28)
        Me.TextBoxLot.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DarkCyan
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(47, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Lot No"
        '
        'TextBoxPName
        '
        Me.TextBoxPName.Location = New System.Drawing.Point(340, 115)
        Me.TextBoxPName.Multiline = True
        Me.TextBoxPName.Name = "TextBoxPName"
        Me.TextBoxPName.Size = New System.Drawing.Size(224, 28)
        Me.TextBoxPName.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkCyan
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(335, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Product Name"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(507, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 30)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Save to Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelSetShow
        '
        Me.LabelSetShow.AutoSize = True
        Me.LabelSetShow.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSetShow.ForeColor = System.Drawing.Color.Red
        Me.LabelSetShow.Location = New System.Drawing.Point(197, 316)
        Me.LabelSetShow.Name = "LabelSetShow"
        Me.LabelSetShow.Size = New System.Drawing.Size(39, 24)
        Me.LabelSetShow.TabIndex = 55
        Me.LabelSetShow.Text = "Set"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Brown
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 54)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Back to Menu"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label23.Location = New System.Drawing.Point(52, 184)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 25)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "Weight"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(201, 221)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 35)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "Set"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBoxWeightSet
        '
        Me.TextBoxWeightSet.Location = New System.Drawing.Point(57, 227)
        Me.TextBoxWeightSet.Multiline = True
        Me.TextBoxWeightSet.Name = "TextBoxWeightSet"
        Me.TextBoxWeightSet.Size = New System.Drawing.Size(104, 28)
        Me.TextBoxWeightSet.TabIndex = 47
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM7"
        '
        'Weigher2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 428)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Weigher2"
        Me.Text = "Weigher2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label23 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBoxWeightSet As TextBox
    Public WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents LabelSetShow As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxCName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxLot As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
