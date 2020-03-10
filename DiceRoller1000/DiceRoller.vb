'Nathan Comstock
'RCET0265
'Spring 2020
'DiceRoller1000
'https://github.com/comsnath/NC-VS-S20

Option Strict On
Option Explicit On


Module DiceRoller

    Sub Main()

        Dim firstDice As Single
        Dim secondDice As Single
        Dim sumDice As Single
        Dim diceArray(12) As Integer
        Dim restart As String
        restart = "Y"

        Do While restart = "Y"



            For roll = 1 To 1000
                Randomize()
                firstDice = Int((6 * Rnd()) + 1)
                secondDice = Int((6 * Rnd()) + 1)
                sumDice = firstDice + secondDice

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

            Console.WriteLine("2,  3,  4,  5,   6,  7,   8,   9,  10,  11,  12")
            Console.WriteLine(diceArray(2) & ", " & diceArray(3) & ", " & diceArray(4) & ", " & diceArray(5) _
                         & ", " & diceArray(6) & ", " & diceArray(7) & ", " & diceArray(8) & ", " & diceArray(9) _
                         & ", " & diceArray(10) & ", " & diceArray(11) & ", " & diceArray(12))
            Console.WriteLine("*******************************************************")
            Console.WriteLine("Run again? Y/N")

            restart = Console.ReadLine()
            If restart = "Y" Then
            Else
                Exit Sub
            End If
        Loop




    End Sub

End Module
