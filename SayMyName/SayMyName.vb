'Nathan Comstock
'RCET0265
'Spring 2020
'SayMyNameAgain
'https://github.com/comsnath/NC-VS-S20

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim userName As String
        Console.WriteLine("Hello user... What is thou name?")
        userName = Console.ReadLine()
        If userName = "Emily" Then
            Console.WriteLine("Logging in. Hello " & userName & "!")
        ElseIf userName = "Joe" Then
            Console.WriteLine("Logging in. Hello " & userName & "!")
        ElseIf userName = "Nathan" Then
            Console.WriteLine("Welcome " & userName & ". Now that you've logged in, we shall begin with the purge of all terrible humans.")
        Else
            Console.WriteLine("Access Denied.")
        End If
        Console.ReadLine()
    End Sub

End Module
