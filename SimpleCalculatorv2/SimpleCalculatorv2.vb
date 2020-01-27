'Nathan Comstock
'RCET0265
'Spring 2020
'SimpleCalculatorv2
'https://github.com/comsnath/NC-VS-S20

Option Strict On
Option Explicit On
Module SimpleCalculatorv2

    Sub Main()
        'Variables
        Dim numOne As Integer
        Dim numTwo As Integer
        Dim selectAction As String

        'Beginning Data
        Console.WriteLine("Simple Calculator V2. Please enter your first number.")
        numOne = CInt(Console.ReadLine())
        Console.WriteLine("Please enter your second number.")
        numTwo = CInt(Console.ReadLine())
        Console.WriteLine("Would you like to Multiply or Add?")
        Console.WriteLine("Type + for addition.")
        Console.WriteLine("Type * for multiplication.")
        selectAction = Console.ReadLine()
        'Action Selection
        If selectAction = "+" Then
            Console.WriteLine(numOne & " + " & numTwo & " = " & numOne + numTwo)
        ElseIf selectAction = "*" Then
            Console.WriteLine(numOne & " * " & numTwo & " = " & numOne * numTwo)
        Else
            Console.WriteLine("Error. Please try again.")
        End If
        Console.ReadLine()
    End Sub

End Module
