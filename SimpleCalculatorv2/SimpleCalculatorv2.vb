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
        Dim quitChoice As Boolean
        Dim promptUser As Boolean

        promptUser = True
        quitChoice = True

        Do While quitChoice = True

            'Beginning Data
            Console.WriteLine("Simple Calculator V2. Please enter your first number.")
            Do While promptUser = True
                Try
                    numOne = CInt(Console.ReadLine())
                    promptUser = False
                Catch ex As Exception
                    Console.WriteLine("You entered: " + CStr(numOne) + "Please enter a whole number.")
                    promptUser = True
                End Try
            Loop

            promptUser = True

            Console.WriteLine("Please enter your second number.")
            Do While promptUser = True
                Try
                    numTwo = CInt(Console.ReadLine())
                    promptUser = False
                Catch ex As Exception
                    Console.WriteLine("Error. Please try again.")
                    promptUser = True
                End Try
            Loop

            promptUser = True

            'Action Selection
            Do While promptUser = True
                Console.WriteLine("Would you like to Multiply or Add?")
                Console.WriteLine("Type + for addition.")
                Console.WriteLine("Type * for multiplication.")
                selectAction = Console.ReadLine()
                If selectAction = "+" Then
                    'Try
                    Console.WriteLine(numOne & " + " & numTwo & " = " & numOne + numTwo)
                    'Catch ex As Exception
                    '    Console.WriteLine("Error. Please try again.")
                    'End Try
                    promptUser = False
                ElseIf selectAction = "*" Then
                    'Try
                    Console.WriteLine(numOne & " * " & numTwo & " = " & numOne * numTwo)
                    'Catch ex As Exception
                    '    Console.WriteLine("Error. Please try again.")
                    'End Try
                    promptUser = False
                Else
                    Console.WriteLine("Error. Please try again.")
                    promptUser = True
                End If
            Loop
            Console.WriteLine("Press any key to try again. Press Q to quit.")
                If Console.ReadLine() = "Q" Then
                    quitChoice = False
                Else
                    quitChoice = True
                End If
                Console.Clear()
            Loop

    End Sub

End Module
