Module Module1

    Sub Main()

        Dim messageOne As String
        Dim messageTwo As String
        Dim messageThree As String



        Console.WriteLine("Enter your first string:")
        messageOne = Console.ReadLine()
        Console.WriteLine("Enter your second string:")
        messageTwo = Console.ReadLine()
        Console.WriteLine("Enter your third string:")
        messageThree = Console.ReadLine()
        Console.WriteLine("Processing...")

        UserMessages(True, messageOne, False)
        UserMessages(True, messageTwo, False)
        UserMessages(True, messageThree, False)

        Console.ReadLine()
    End Sub
    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String
        Static formattedMessages As String

        formattedMessages &= message & vbNewLine


        Console.WriteLine(message)
        Return formattedMessages

    End Function
End Module
