'Nathan Comstock
'RCET0265
'Spring 2020
'SubFunctionExample
'https://github.com/comsnath/NC-VS-S20

Option Strict On
Option Explicit On

Module SubFunction

    Sub Main()
        Dim myNumber As Integer
        myNumber = 7
        Console.WriteLine("In Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Sub2(myNumber)
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

End Module
