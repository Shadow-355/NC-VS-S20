Module Module1

    Sub Main()
        Dim array(3) As Integer

        array(1) = 5

        array = {1, 2, 3, 4}

        array(0) = 5
        ReDim Preserve array(15)

        Console.ReadLine()

    End Sub

End Module
