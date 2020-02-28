Public Class ListBoxForm

    Private Sub ListBoxForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Preloaded Data
        FirstNameTextBox.Text = "Joe"
        LastNameTextBox.Text = "Smith"




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

    Private Sub OutputListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OutputListBox.SelectedIndexChanged
        Dim indexNum As Integer

        Me.Text = OutputListBox.SelectedIndex.ToString
        indexNum = InStr(OutputListBox.SelectedItem.ToString, " ")

        FirstNameTextBox.Text = Trim(Strings.Left(OutputListBox.SelectedItem.ToString, indexNum))
        LastNameTextBox.Text = Trim(Strings.Mid(OutputListBox.SelectedItem.ToString, indexNum))
    End Sub
    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String

        'your code here

        Return formattedMessages

    End Function
End Class
