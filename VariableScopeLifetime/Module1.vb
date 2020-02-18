Module Module1
    Dim aName As String
    'aName = "Chucks"


    Sub Main()
        Dim aNumber As Integer
        aNumber = 5
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        aName = "Chucky"

        MySub()
        'Console.WriteLine(aNumber)
        Console.WriteLine(aName)
        Console.ReadLine()
    End Sub

    Sub MySub()
        Dim aNumber As Integer
        aNumber = 5

        aName = "Billy"
    End Sub

End Module
