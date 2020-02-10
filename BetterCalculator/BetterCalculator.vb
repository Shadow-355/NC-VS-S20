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
        Dim numOneConverted As Integer
        Dim numTwo As String
        Dim numTwoConverted As Integer
        Dim selectAction As String
        Dim quitChoice As Boolean
        Dim promptUser As Boolean
        promptUser = True

        'Start Program
        Do While promptUser = True

            'First Number Prompt
            promptUser = True
            Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
            Do While promptUser = True
                Console.Write("Choose a Number: ")
                numOne = Console.ReadLine()
                Try
                    numOneConverted = CInt(numOne)
                    promptUser = False
                Catch ex As Exception
                    If numOne = "q" Then
                        Console.WriteLine("You entered """ + numOne + """")
                        Console.WriteLine("Have a nice day.")
                        Console.WriteLine("Press enter to close this window.")
                        Console.ReadLine()
                        Exit Sub
                    ElseIf numOne = "Q" Then
                        Console.WriteLine("You entered """ + numOne + """")
                        Console.WriteLine("Have a nice day.")
                        Console.WriteLine("Press enter to close this window.")
                        Console.ReadLine()
                        Exit Sub
                    Else
                        Console.WriteLine("You entered """ + numOne + """, please enter a whole number.")
                        promptUser = True
                    End If
                End Try
            Loop
            Console.WriteLine("You entered """ + numOne + """")

            'Second Number Prompt
            promptUser = True
            Do While promptUser = True
                Console.Write("Choose a Number: ")
                numTwo = Console.ReadLine()
                Try
                    numTwoConverted = CInt(numTwo)
                    promptUser = False
                Catch ex As Exception
                    If numTwo = "q" Then
                        Console.WriteLine("You entered """ + numTwo + """")
                        Console.WriteLine("Have a nice day.")
                        Console.WriteLine("Press enter to close this window.")
                        Console.ReadLine()
                        Exit Sub
                    ElseIf numTwo = "Q" Then
                        Console.WriteLine("You entered """ + numTwo + """")
                        Console.WriteLine("Have a nice day.")
                        Console.WriteLine("Press enter to close this window.")
                        Console.ReadLine()
                        Exit Sub
                    Else
                        Console.WriteLine("You entered """ + numTwo + """, please enter a whole number.")
                        promptUser = True
                    End If
                End Try
            Loop
            Console.WriteLine("You entered """ + numTwo + """")

            'Action Selection
            promptUser = True
            Do While promptUser = True
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                selectAction = Console.ReadLine()
                If selectAction = "q" Then
                    Console.WriteLine("You entered """ + selectAction + """")
                    Console.WriteLine("Have a nice day.")
                    Console.WriteLine("Press enter to close this window.")
                    Console.ReadLine()
                    Exit Sub
                ElseIf selectAction = "Q" Then
                    Console.WriteLine("You entered """ + selectAction + """")
                    Console.WriteLine("Have a nice day.")
                    Console.WriteLine("Press enter to close this window.")
                    Console.ReadLine()
                    Exit Sub
                ElseIf selectAction = "1" Then
                    Console.WriteLine("You entered """ + selectAction + """")
                    Console.WriteLine(numOne & " + " & numTwo & " = " & numOneConverted + numTwoConverted)
                    promptUser = False
                ElseIf selectAction = "2" Then
                    Console.WriteLine("You entered """ + selectAction + """")
                    Console.WriteLine(numOne & " - " & numTwo & " = " & numOneConverted - numTwoConverted)
                    promptUser = False
                ElseIf selectAction = "3" Then
                    Console.WriteLine("You entered """ + selectAction + """")
                    Console.WriteLine(numOne & " * " & numTwo & " = " & numOneConverted * numTwoConverted)
                    promptUser = False
                ElseIf selectAction = "4" Then
                    Console.WriteLine("You entered """ + selectAction + """")
                    Console.WriteLine(numOne & " / " & numTwo & " = " & numOneConverted / numTwoConverted)
                    promptUser = False
                Else
                    Console.WriteLine("You entered """ + selectAction + """")
                    promptUser = True
                End If

            Loop
            promptUser = True
        Loop




    End Sub

End Module
