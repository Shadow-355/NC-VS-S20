Public Class ValidateUserDataForm
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Enter Text")
            TextBox1.Select()
        End If

    End Sub
End Class
