Public Class ListBoxForm

    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        OutputListBox.Items.Add(FirstNameTextBox.Text & LastNameTextBox.Text)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        OutputListBox.Items.Clear()
    End Sub
End Class
