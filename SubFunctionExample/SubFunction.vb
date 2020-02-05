'Nathan Comstock
'RCET0265
'Spring 2020
'SubFunctionExample
'https://github.com/comsnath/NC-VS-S20

Option Strict On
Option Explicit On

Module SubFunction

    Sub Main()
        'Dim myNumber As Integer
        'myNumber = 7
        'Console.WriteLine("In Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()
        'Sub2(myNumber)
        'DoMath(7, 5, "+")
        For i = 1 To 100
            ShowPattern(i, ">")
        Next



    End Sub

    Sub Sub2(myNumber As Integer)
        'Dim myNumber As Integer
        'myNumber = 7
        Console.WriteLine("In Sub2")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Function Function1() As Integer
        Dim number As Integer
        number = 7
        Console.WriteLine("In Function1")
        Console.WriteLine(number)
        Return 0

    End Function

    Sub DoMath(firstNumber As Integer, secondNumber As Integer, operatorchoice As String)
        'Insert Code Here
        'Dim result As Decimal

        'If operatorchoice = "+" Then
        '    result = firstNumber + secondNumber
        'ElseIf operatorchoice = "*" Then
        '    result = firstNumber * secondNumber
        'ElseIf operatorchoice = "/" Then
        '    result = firstNumber / secondNumber
        'End If
        'Console.ReadLine(result)

    End Sub
    Sub ShowPattern(length As Integer, character As String)

        Dim pattern As String

        For index = 1 To length
            pattern &= character
            Console.WriteLine(pattern)

        Next


        For index = length - 1 To 1 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)

        Next
        Console.ReadLine()
    End Sub
End Module
