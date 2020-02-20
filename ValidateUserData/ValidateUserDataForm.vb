Public Class ValidateUserDataForm
    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        Dim userMessage As String

        Console.WriteLine(UserResponse(TextBox1.Text, "Enter Text in 1", False))

        'If IsStringEmpty(TextBox3.Text) = True Then
        '    userMessage &= "Missing Text 3" & vbNewLine
        '    TextBox3.Select()
        'End If

        'If IsStringEmpty(TextBox2.Text) = True Then
        '    userMessage &= "Missing Text 2" & vbNewLine
        '    TextBox2.Select()
        'End If

        'If IsStringEmpty(TextBox1.Text) = True Then
        '    userMessage &= "Missing Text 1" & vbNewLine
        '    TextBox1.Select()
        'End If

        'If userMessage <> "" Then
        '    MsgBox(userMessage)
        'End If

    End Sub



    Function IsStringEmpty(stringTest As String) As Boolean
        Dim status As Boolean
        If stringTest = "" Then
            status = True
        Else
            status = False
        End If
        Return status
    End Function

    Function RunningTotal(currentValue As Integer, clearTotal As Boolean) As Integer
        Static total As Integer
        If clearTotal <> True Then
            total += currentValue
        Else
            total = 0
        End If

        Return total
    End Function

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim tempNumber As Integer
        Const VALUE As Integer = 5

        For i = 1 To 10
            tempNumber = RunningTotal(VALUE, False)
        Next

        Console.WriteLine(tempNumber)
    End Sub

    Function UserResponse(stringTest As String, uniqueMessage As String, clearMessage As Boolean)
        Static runningMessage As String = ""

        If clearMessage <> True Then
            runningMessage &= uniqueMessage & vbNewLine
        Else
            runningMessage = ""
        End If
        Return runningMessage

    End Function
End Class
