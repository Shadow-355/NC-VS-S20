'Nathan Comstock
'RCET0265
'Spring 2020
'Diner Menu Program
'https://github.com/comsnath/NC-VS-S20


Public Class DinerMenuForm
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        'Display Text and Picture in proper areas.
        DisplaySpecialLabel.Text = """Ah, our soup special today is Moon Rabbit Stew!""" & vbNewLine & vbNewLine & """Moon Rabbit stew has a tender yet delicious taste. It's a favorite!"""
        PictureBox.Image = DinerMenu.My.Resources.Resources.Rabbit
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        'Display Text and Picture in proper areas.
        DisplaySpecialLabel.Text = """Ah, our salad today is Cloud Starling Salad!""" & vbNewLine & vbNewLine & """Cloud Starling is made from plants that are only found on the clouds near the mountains. It has a bit of an acquired taste."""
        PictureBox.Image = DinerMenu.My.Resources.Resources.Mushroom
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        'Display Text and Picture in proper areas.
        DisplaySpecialLabel.Text = """Ah, our fish today is Deep-Fried Star Clam!""" & vbNewLine & vbNewLine & """Deep-Fried Star Clam is a local sea animal that can only be found around these parts. It's personally one of my favorites."""
        PictureBox.Image = DinerMenu.My.Resources.Resources.Clam
    End Sub

    Private Sub SpecialButton_Click(sender As Object, e As EventArgs) Handles SpecialButton.Click
        'Display Text and Picture in proper areas.
        DisplaySpecialLabel.Text = """Ah, our special today is Daccetato Bombe!""" & vbNewLine & vbNewLine & """Daccetato Bombe is wolf meat wrapped in Serpent Bush which is a small plant that grows only around these parts of the ocean, it has a screaming cow butter and vegetable glaze."""
        PictureBox.Image = DinerMenu.My.Resources.Resources.Wolf
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit the program.
        MsgBox("Thank you, come again!" & vbNewLine & "~Isabel Morris")
        Close()
    End Sub
End Class
