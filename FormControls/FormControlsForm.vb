'Nathan Comstock
'RCET0265
'Spring 2020
'FormControlsForm
'https://github.com/comsnath/NC-VS-S20

Public Class FormControlsForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim displayName As String

        displayName = NameTextBox.Text & StreetTextBox.Text & StateTextBox.Text
        DisplayLabel.Text = displayName
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click

    End Sub

    Private Sub FormControlsForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        RadioButton1.Checked = True
    End Sub
End Class
