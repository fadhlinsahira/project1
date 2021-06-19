Public Class Register
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        'this is for mandotory field 
        If txtName.Text = "" Then
            MessageBox.Show("You have not entered your name. This is a mandatory field.")
            txtName.Focus()
        ElseIf numAge.Text = "" Then
            MessageBox.Show("You have not entered your Age. This is a mandatory field.")
            numAge.Focus()
        ElseIf txtLicence.Text = "" Then
            MessageBox.Show("You not anwser the question. This is a mandatory field.")
            txtLicence.Focus()
        ElseIf txtPhone.Text = "" Then
            MessageBox.Show("You not anwser the question. This is a mandatory field.")
            txtPhone.Focus()
        ElseIf txtMotor.Text = "" Then
            MessageBox.Show("You not anwser the question. This is a mandatory field.")
            txtMotor.Focus()
        ElseIf txtExpert.Text = "" Then
            MessageBox.Show("You not anwser the question. This is a mandatory field.")
            txtExpert.Focus()

            ' this for conditon 
        ElseIf (numAge.Text) < "18" Then
            AgeNot.Show()
            Me.Show()
        ElseIf (txtLicence.Text) = "NO" Then
            LicenceNot.Show()
            Me.Show()
        ElseIf (txtPhone.Text) = "NO" Then
            PhoneNot.Show()
            Me.Show()
        ElseIf (txtMotor.Text) = "NO" Then
            MotorNot.Show()
            Me.Show()
        ElseIf (txtExpert.Text) = "NO" Then
            ExpertNot.Show()
            Me.Show()
        Else
            Eligible.Show()
            Me.Show()
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to Exit?", "Food Run Job System",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = vbYes) Then
            Application.Exit()

        End If
    End Sub
End Class