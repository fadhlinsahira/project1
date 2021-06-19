Public Class Form1
    Private Sub BtnCondition_Click(sender As Object, e As EventArgs) Handles BtnCondition.Click
        Condition.Show()
        Me.Show()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to Exit?", "Food Run Job System",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (result = vbYes) Then
            Application.Exit()

        End If
    End Sub
End Class
