<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtExpert = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMotor = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLicence = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numAge = New System.Windows.Forms.NumericUpDown()
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnSubmit.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnSubmit.Location = New System.Drawing.Point(82, 403)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(109, 43)
        Me.BtnSubmit.TabIndex = 0
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnExit.Location = New System.Drawing.Point(206, 403)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(98, 43)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 34)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "REGISTER FORM"
        '
        'txtExpert
        '
        Me.txtExpert.Location = New System.Drawing.Point(164, 332)
        Me.txtExpert.Margin = New System.Windows.Forms.Padding(2)
        Me.txtExpert.Name = "txtExpert"
        Me.txtExpert.Size = New System.Drawing.Size(53, 20)
        Me.txtExpert.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 332)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 26)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "HAVE EXPERIENCE? : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( YES / NO )"
        '
        'txtMotor
        '
        Me.txtMotor.Location = New System.Drawing.Point(164, 285)
        Me.txtMotor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMotor.Name = "txtMotor"
        Me.txtMotor.Size = New System.Drawing.Size(53, 20)
        Me.txtMotor.TabIndex = 29
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(164, 238)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(53, 20)
        Me.txtPhone.TabIndex = 28
        '
        'txtLicence
        '
        Me.txtLicence.Location = New System.Drawing.Point(164, 191)
        Me.txtLicence.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLicence.Name = "txtLicence"
        Me.txtLicence.Size = New System.Drawing.Size(53, 20)
        Me.txtLicence.TabIndex = 27
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(164, 106)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(150, 20)
        Me.txtEmail.TabIndex = 25
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 68)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 20)
        Me.txtName.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 285)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 26)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = " HAVE MOTORCYCLE? : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( YES / NO )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 26)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "HAVE SMARTPHONE?  : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( YES / NO )"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 191)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 26)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "MOTORCYCLE LICENCE? : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( YES / NO )"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "AGE : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(109, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "EMAIL :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "NAME : "
        '
        'numAge
        '
        Me.numAge.Location = New System.Drawing.Point(164, 153)
        Me.numAge.Name = "numAge"
        Me.numAge.Size = New System.Drawing.Size(57, 20)
        Me.numAge.TabIndex = 32
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(408, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.numAge)
        Me.Controls.Add(Me.txtExpert)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMotor)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLicence)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Name = "Register"
        Me.Text = "Food Run Job System"
        CType(Me.numAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtExpert As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMotor As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLicence As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numAge As NumericUpDown
End Class
