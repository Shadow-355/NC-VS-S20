'Nathan Comstock
'RCET0265
'Spring 2020
'DiceRoller2000
'https://github.com/comsnath/NC-VS-S20

Public Class DiceRollerForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        'Create variables
        Dim firstDice As Single
        Dim secondDice As Single
        Dim sumDice As Single
        Dim diceArray(12) As Integer

        'Start Roller
        For roll = 1 To 1000
            'Randomize
            Randomize()
            firstDice = Int((6 * Rnd()) + 1)
            Randomize()
            secondDice = Int((6 * Rnd()) + 1)
            sumDice = firstDice + secondDice

            'Check Number and Insert Into Array
            Select Case sumDice
                Case sumDice
                    diceArray(sumDice) += 1
            End Select

        Next




        'Write out Array
        OutputListBox.Items.Add("2,   3,   4,   5,   6,   7,   8,   9,  10,  11,  12")
        OutputListBox.Items.Add(diceArray(2) & ", " & diceArray(3) & ", " & diceArray(4) & ", " & diceArray(5) _
                         & ", " & diceArray(6) & ", " & diceArray(7) & ", " & diceArray(8) & ", " & diceArray(9) _
                         & ", " & diceArray(10) & ", " & diceArray(11) & ", " & diceArray(12))
        OutputListBox.Items.Add(StrDup(55, "-"))
    End Sub


End Class
