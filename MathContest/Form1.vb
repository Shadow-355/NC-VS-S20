'Nathan Comstock
'RCET0265
'Spring 2020
'MathContest
'https://github.com/comsnath/NC-VS-S20


Public Class MathContestForm
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'On Load Disable Summary

        SummaryButton.Enabled = False
        SubmitButton.Enabled = True
        FirstNumberTextBox.Enabled = True
        SecondNumberTextBox.Enabled = True
        AddRadioButton.Checked = True
    End Sub


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub


    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        'Validate for Number
        Dim age As String

        If AgeTextBox.Text <> "" Then
            Try
                age = CInt(AgeTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Alert. Please enter a valid age.")
                AgeTextBox.Text = ""
            End Try
        End If
    End Sub

    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        'Validate for Number
        Dim grade As String

        If GradeTextBox.Text <> "" Then
            Try
                grade = CInt(GradeTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Alert. Please enter a valid grade.")
                GradeTextBox.Text = ""
            End Try
        End If
    End Sub

    Private Sub FirstNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNumberTextBox.TextChanged
        'Validate for Number
        Dim firstNum As String

        If FirstNumberTextBox.Text <> "" Then
            Try
                firstNum = CInt(FirstNumberTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Alert. Please enter a valid number.")
                FirstNumberTextBox.Text = ""
            End Try
        End If
    End Sub

    Private Sub SecondNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles SecondNumberTextBox.TextChanged
        'Validate for Number
        Dim secondNum As String

        If SecondNumberTextBox.Text <> "" Then
            Try
                secondNum = CInt(SecondNumberTextBox.Text)
            Catch ex As Exception
                MessageBox.Show("Alert. Please enter a valid number.")
                SecondNumberTextBox.Text = ""
            End Try
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'Create Variables for Vaildation Check
        Dim validateMessage As String
        Dim overrideMessage As String


        'Check for Validation Issues
        If NameTextBox.Text = "" Then
            validateMessage &= "Please enter a valid name." & vbNewLine
            NameTextBox.Select()
        End If

        If AgeTextBox.Text = "" Then
            validateMessage &= "Please enter a valid age." & vbNewLine
            AgeTextBox.Select()
        ElseIf AgeTextBox.Text <> "" Then
            Dim age As String
            age = CInt(AgeTextBox.Text)
            If age < 7 Then
                overrideMessage &= "This student is too young to partipate." & vbNewLine
            ElseIf age > 11 Then
                overrideMessage &= "This student is too old to partipate." & vbNewLine
            End If
        End If

        If GradeTextBox.Text = "" Then
            validateMessage &= "Please enter a valid grade." & vbNewLine
            GradeTextBox.Select()
        ElseIf GradeTextBox.Text <> "" Then
            Dim grade As String
            grade = CInt(GradeTextBox.Text)
            If grade < 1 Then
                overrideMessage &= "This student's grade is too low to participate." & vbNewLine
            ElseIf grade > 4 Then
                overrideMessage &= "This student's grade is too high to participate." & vbNewLine
            End If
        End If

        If FirstNumberTextBox.Text = "" Then
            validateMessage &= "Please enter a valid first number." & vbNewLine
            FirstNumberTextBox.Select()
        End If

        If SecondNumberTextBox.Text = "" Then
            validateMessage &= "Please enter a valid first number." & vbNewLine
            SecondNumberTextBox.Select()
        End If

        If overrideMessage <> "" Then
            MessageBox.Show(overrideMessage)
        ElseIf validateMessage <> "" Then
            Dim validateTemp As String
            validateTemp = validateMessage
            validateMessage = "Please address the following errors:" & vbNewLine
            validateMessage &= validateTemp
            MessageBox.Show(validateMessage)
        ElseIf validateMessage = "" Then
            SummaryButton.Enabled = True
            SubmitButton.Enabled = False
            FirstNumberTextBox.Enabled = False
            SecondNumberTextBox.Enabled = False
            NameTextBox.Enabled = False
            AgeTextBox.Enabled = False
            GradeTextBox.Enabled = False
            ProblemTypeGroupBox.Enabled = False
            CheckButton.Enabled = True
        End If

    End Sub


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SummaryButton.Enabled = False
        SubmitButton.Enabled = True
        FirstNumberTextBox.Enabled = True
        SecondNumberTextBox.Enabled = True
        NameTextBox.Enabled = True
        AgeTextBox.Enabled = True
        GradeTextBox.Enabled = True
        ProblemTypeGroupBox.Enabled = True
        CheckButton.Enabled = False

        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
    End Sub

    Private Sub CheckButton_Click(sender As Object, e As EventArgs) Handles CheckButton.Click
        Dim numOne As Integer
        Dim numTwo As Integer
        Dim addResult As String
        Dim subtractResult As String
        Dim multiplyResult As String
        Dim divideResult As String
        Dim submittedResult As String


        Try
            submittedResult = CInt(StudentAnswerTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Please enter a valid answer.")
            StudentAnswerTextBox.Text = ""
        End Try


        Try
            numOne = CInt(FirstNumberTextBox.Text)
            numTwo = CInt(SecondNumberTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Something went wrong. Please Try Again")
            FirstNumberTextBox.Text = ""
            SecondNumberTextBox.Text = ""
        End Try

        If AddRadioButton.Checked = True Then
            addResult = numOne + numTwo
            If addResult = submittedResult Then
                MessageBox.Show("Congragulations! You are correct!")
            ElseIf addResult <> submittedResult Then
                MessageBox.Show("Oops! That's not quite right. The answer is: " & addResult)
            End If

        End If

        If SubtractRadioButton.Checked = True Then
            subtractResult = numOne - numTwo
            If subtractResult = submittedResult Then
                MessageBox.Show("Congragulations! You are correct!")
            ElseIf subtractResult <> submittedResult Then
                MessageBox.Show("Oops! That's not quite right. The answer is: " & subtractResult)
            End If

        End If

        If MultiplyRadioButton.Checked = True Then
            multiplyResult = numOne * numTwo
            If multiplyResult = submittedResult Then
                MessageBox.Show("Congragulations! You are correct!")
            ElseIf multiplyResult <> submittedResult Then
                MessageBox.Show("Oops! That's not quite right. The answer is: " & multiplyResult)
            End If

        End If

        If DivideRadioButton.Checked = True Then
            divideResult = numOne / numTwo
            If divideResult = submittedResult Then
                MessageBox.Show("Congragulations! You are correct!")
            ElseIf divideResult <> submittedResult Then
                MessageBox.Show("Oops! That's not quite right. The answer is: " & divideResult)
            End If

        End If
    End Sub
End Class
