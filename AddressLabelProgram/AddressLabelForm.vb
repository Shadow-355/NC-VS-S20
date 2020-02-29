'Nathan Comstock
'RCET0265
'Spring 2020
'AddressLabelProgram
'https://github.com/comsnath/NC-VS-S20


Public Class AddressLabelForm
    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Tooltips for all textboxes.
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(Me.FirstNameTextBox, "Please enter your first name.")
        toolTip1.SetToolTip(Me.LastNameTextBox, "Please enter your last name.")
        toolTip1.SetToolTip(Me.StreetAddressTextBox, "Please enter your street address.")
        toolTip1.SetToolTip(Me.CityTextBox, "Please enter your city.")
        toolTip1.SetToolTip(Me.StateTextBox, "Please enter your state.")
        toolTip1.SetToolTip(Me.ZipTextBox, "Please enter your zip code.")

        'Default Information.
        FirstNameTextBox.Text = "Joe"
        LastNameTextBox.Text = "Smith"
        StreetAddressTextBox.Text = "123 Cherry Lane"
        CityTextBox.Text = "Random City"
        StateTextBox.Text = "Idaho"
        ZipTextBox.Text = "40404"

    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text _
            & vbNewLine & StreetAddressTextBox.Text & vbNewLine &
            CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub
End Class
