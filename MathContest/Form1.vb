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
        Dim validateMessage As String
        Dim overrideMessage As String

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

        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        GradeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
    End Sub
End Class
