'Nathan Comstock
'RCET0265
'Spring 2020
'BetterCalculator
'https://github.com/comsnath/NC-VS-S20

Option Strict On
Option Explicit On

Module BetterCalculator

    Sub Main()
        'Variables
        Dim numOne As String
        Dim numTwo As String
        Dim selectAction As String
        Dim quitChoice As Boolean
        Dim promptUser As Boolean

        promptUser = True
        quitChoice = True

        Do While quitChoice = True

            'Beginning Data
            Do While promptUser = True
                Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
                Console.Write("Choose a Number: ")
                numOne = Console.ReadLine()
                If numOne = "q" Then
                    Exit Sub
                ElseIf numOne = "Q" Then
                    Exit Sub
                Else
                    Try
                        numOne = String
                    Catch ex As Exception
                        Console.WriteLine("You entered " + numOne + ", please enter a whole number.")
                        promptUser = True
                    End Try
                End If


                'Try
                '    Console.Write("Choose a Number: ")
                '    numOne = Console.Read()
                '    promptUser = False
                'Catch ex As Exception

                '    promptUser = True
                'End Try
            Loop

            promptUser = True

            Console.WriteLine("Please enter your second number.")
            Do While promptUser = True
                Try
                    'numTwo = CInt(Console.ReadLine())
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
                    'Console.WriteLine(numOne & " * " & numTwo & " = " & numOne * numTwo)
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
