Module ListExample

    Sub Main()
        Dim names As New List(Of String)
        Dim searchString As String

        names.Add("Tim")
        names.Add("Jeff")
        names.Add("Blimp")
        Console.WriteLine(names)

        names.Add(Console.ReadLine())



        If names.Contains(searchString) = True Then
            Console.WriteLine("Yes, " & searchString & " Is active.")
        Else
            Console.WriteLine("No, " & searchString & " is not found!")
        End If

        names.Contains("Tim")

        For Each name In names
            Console.WriteLine(names)
        Next
        Console.ReadLine()
    End Sub

End Module
