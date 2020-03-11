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

        'Set Array to 0
        diceArray(2) = 0
        diceArray(3) = 0
        diceArray(4) = 0
        diceArray(5) = 0
        diceArray(6) = 0
        diceArray(7) = 0
        diceArray(8) = 0
        diceArray(9) = 0
        diceArray(10) = 0
        diceArray(11) = 0
        diceArray(12) = 0

        'Start Roller
        For roll = 1 To 1000
            'Randomize
            Randomize()
            firstDice = Int((6 * Rnd()) + 1)
            Randomize()
            secondDice = Int((6 * Rnd()) + 1)
            sumDice = firstDice + secondDice

            'Check Number
            If sumDice = 2 Then
                diceArray(2) += 1
            ElseIf sumDice = 3 Then
                diceArray(3) += 1
            ElseIf sumDice = 4 Then
                diceArray(4) += 1
            ElseIf sumDice = 5 Then
                diceArray(5) += 1
            ElseIf sumDice = 6 Then
                diceArray(6) += 1
            ElseIf sumDice = 7 Then
                diceArray(7) += 1
            ElseIf sumDice = 8 Then
                diceArray(8) += 1
            ElseIf sumDice = 9 Then
                diceArray(9) += 1
            ElseIf sumDice = 10 Then
                diceArray(10) += 1
            ElseIf sumDice = 12 Then
                diceArray(11) += 1
            ElseIf sumDice = 11 Then
                diceArray(12) += 1
            End If
        Next

        'Write out Array

        OutputListBox.Text = "2,  3,  4,  5,   6,  7,   8,   9,  10,  11,  12" & vbNewLine
        OutputListBox.Text &= diceArray(2) & ", " & diceArray(3) & ", " & diceArray(4) & ", " & diceArray(5) _
                         & ", " & diceArray(6) & ", " & diceArray(7) & ", " & diceArray(8) & ", " & diceArray(9) _
                         & ", " & diceArray(10) & ", " & diceArray(11) & ", " & diceArray(12)



        Console.WriteLine(Space(19) & Roll)
        For i = LBound(temp) To UBound(temp)
            Console.Write(CStr(temp(i)).PadLeft(4) & "|")
        Next
        Console.WriteLine(StrDup(55, "-"))









    End Sub


End Class
