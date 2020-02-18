Public Class ValidateUserDataForm
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        If TextBox1.Text = "" Then
            MsgBox("Please Enter Text" & vbNewLine)
            TextBox1.Select()
        End If

        If TextBox2.Text = "" Then
            MsgBox("Please Enter Text" & vbNewLine)
            TextBox2.Select()
        End If

        If TextBox3.Text = "" Then
            MsgBox("Please Enter Text" & vbNewLine)
            TextBox3.Select()
        End If

    End Sub
End Class
