Option Strict On
Option Explicit On


Module Module1

    Sub Main()
        Dim firstDice As Single
        Dim secondDice As Single
        Dim sumDice As Single
        Dim diceArray(12) As Integer

        For roll = 1 To 1000
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

        Console.WriteLine(diceArray(2))
        Console.WriteLine(diceArray(3))
        Console.WriteLine(diceArray(4))
        Console.WriteLine(diceArray(5))
        Console.WriteLine(diceArray(6))
        Console.WriteLine(diceArray(7))
        Console.WriteLine(diceArray(8))
        Console.WriteLine(diceArray(9))
        Console.WriteLine(diceArray(10))
        Console.WriteLine(diceArray(11))
        Console.WriteLine(diceArray(12))
        Console.ReadLine()


    End Sub

End Module
