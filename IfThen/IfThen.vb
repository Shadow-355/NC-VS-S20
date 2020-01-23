'Nathan Comstock
'RCET0265
'Spring 2020
'IfThen
'https://github.com/comsnath/NC-VS-S20

Module IfThen

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 3
        secondNumber = 3


        If firstNumber > secondNumber Then
            Console.WriteLine("First Number is bigger.")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("First Number is smaller.")
        ElseIf firstNumber <= secondNumber Then
            Console.WriteLine("First number is smaller or equal to.")
        ElseIf firstNumber >= secondNumber Then
            Console.WriteLine("First number is bigger or equal to.")
        ElseIf firstNumber <> secondNumber Then
            Console.WriteLine("The numbers are not equal.")
        Else
            Console.WriteLine("False")
        End If
        Console.ReadLine()

    End Sub

End Module
