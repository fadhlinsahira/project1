<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.BtnCondition = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCondition
        '
        Me.BtnCondition.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.BtnCondition.Location = New System.Drawing.Point(60, 103)
        Me.BtnCondition.Name = "BtnCondition"
        Me.BtnCondition.Size = New System.Drawing.Size(90, 41)
        Me.BtnCondition.TabIndex = 0
        Me.BtnCondition.Text = "Condition?"
        Me.BtnCondition.UseVisualStyleBackColor = False
        '
        'BtnRegister
        '
        Me.BtnRegister.BackColor = System.Drawing.Color.DarkKhaki
        Me.BtnRegister.Location = New System.Drawing.Point(166, 104)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(90, 40)
        Me.BtnRegister.TabIndex = 1
        Me.BtnRegister.Text = "Register!"
        Me.BtnRegister.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome to Food Run Application"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnExit.Location = New System.Drawing.Point(278, 104)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(90, 40)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(425, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.BtnCondition)
        Me.Name = "Form1"
        Me.Text = "Food Run Job System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCondition As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnExit As Button
End Class
