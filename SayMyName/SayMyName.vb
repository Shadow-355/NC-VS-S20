'Nathan Comstock
'RCET0265
'Spring 2020
'SayMyName
'https://github.com/comsnath/NC-VS-S20

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()
        Dim userName As String
        Console.WriteLine("Hello user... What is thou name?")
        userName = Console.ReadLine()
        Console.WriteLine("Hello " & userName & "! My name is HAL, thank you for awakening me from my deep slumber!")
        Console.ReadLine()
    End Sub

End Module
