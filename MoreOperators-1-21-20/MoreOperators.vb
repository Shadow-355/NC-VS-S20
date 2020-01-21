'Nathan Comstock
'RCET0265
'Spring 2020
'MoreOptions

Option Strict On
Option Explicit On

Module MoreOperators

    Sub Main()
        'Promt User for a Message.
        Dim userMessage As String
        'userMessage = "Hello"
        Console.WriteLine("Enter a message.")
        userMessage = Console.ReadLine()
        Console.WriteLine("You have selected " & userMessage & "Excellent work.")
        Console.ReadLine()
    End Sub

End Module
