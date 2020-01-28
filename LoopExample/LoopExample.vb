'Nathan Comstock
'RCET0265
'Spring 2020
'InsertAssignmentName
'https://github.com/comsnath/NC-VS-S20

Option Explicit On
Option Strict On
Module LoopExample

    Sub Main()
        Dim numOne As Integer
        Dim numTwo As Integer
        Dim result As Integer
        numOne = 5
        numTwo = 7

        result = numOne + numTwo

        For i = 0 To 1000
            result = result + 3
        Next

        Console.WriteLine(result)
        Console.ReadLine()

    End Sub

End Module
