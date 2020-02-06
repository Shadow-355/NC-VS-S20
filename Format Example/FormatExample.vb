'Nathan Comstock
'RCET0265
'Spring 2020
'FormatExample
'https://github.com/comsnath/NC-VS-S20

Module FormatExample

    Sub Main()
        'Dim valueInt As Decimal
        'valueInt = CDec(25.5)
        'valueInt.ToString("C")

        'Console.WriteLine(valueInt)
        'Console.WriteLine(valueInt.ToString("C"))
        'Console.ReadLine()

        'TooManySpaces()
        TimeTable()

    End Sub

    Sub TooManySpaces()
        Dim message As String
        message = "    Hello     "

        Console.WriteLine(Len(message))
        message = Trim(message)
        Console.WriteLine(Len(message))
        Console.ReadLine()
    End Sub

    Sub TimeTable()
        Dim result As Integer

        For i = 1 To 10

            For j = 1 To 10
                result = i * j
                Console.Write(result.ToString.PadLeft(5))
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
