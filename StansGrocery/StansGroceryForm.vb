'Nathan Comstock
'RCET0265
'Spring 2020
'StansGrochery
'https://github.com/comsnath/NC-VS-S20

Public Class StansGroceryForm
    'Array is created with 15 slots
    Dim systemArray(2, 4) As String

    'Selector is created.
    Dim x As Integer = 0
    Dim y As Integer = 0

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim array1(5, 5) As String

        'File is located and read as string.
        Dim file As String = "..\..\test.txt"

        'Open File
        FileOpen(1, file, OpenMode.Input)

        'While there is data, this loops.
        Do While Not EOF(1)
            systemArray(x, y) = LineInput(1)
            ComboBox1.Items.Add(systemArray(x, y))
            If y < 4 Then
                y = y + 1
            ElseIf y = 4 Then
                y = 0
                x = x + 1
            ElseIf x > 4 Then
                MsgBox("Overflow Detected.")
                Me.Close()
            Else
                MsgBox("System Error.")
                Me.Close()
            End If

        Loop
        FileClose()

    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        MsgBox("GUI: Tim Rossitor" & vbNewLine & "Program: Nathan Comstock" & vbNewLine & "Version: 0.1")
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim stopper As Boolean

        'Prepare to search the array
        stopper = True
        x = 0
        y = 0
        DisplayListBox.Items.Clear()

        'Search the array
        Do While stopper = True
            If ComboBox1.Text = systemArray(x, y) Then
                stopper = False
                DisplayListBox.Items.Add("You will find " & systemArray(x, y) & " on asile #" & (x + 1) & ", item #" & (y + 1))
            ElseIf y < 4 Then
                y = y + 1
            ElseIf y = 4 Then
                y = 0
                x = x + 1
            ElseIf x > 4 Then
                stopper = False
                MsgBox("Item not found!")
            End If
        Loop

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Lock the dropdown if text is entered.
        If TextBox1.Text = "" Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim stopper As Boolean

        'Prepare to search the array
        stopper = True
        x = 0
        y = 0
        DisplayListBox.Items.Clear()

        'Search the array
        Do While stopper = True
            Try
                If TextBox1.Text = "" Then
                    stopper = False
                    MsgBox("Please enter a search or select from the dropdown.")
                ElseIf LCase(TextBox1.Text) = "zzz" Then
                    stopper = False
                    Me.Close()
                ElseIf LCase(TextBox1.Text) = LCase(systemArray(x, y)) Then
                    stopper = False
                    DisplayListBox.Items.Add("You will find " & systemArray(x, y) & " on asile #" & (x + 1) & ", item #" & (y + 1))
                ElseIf y < 4 Then
                    y = y + 1
                ElseIf y = 4 Then
                    y = 0
                    x = x + 1
                ElseIf x > 4 Then
                    stopper = False
                    MsgBox("Item not found!")
                End If
            Catch ex As Exception
                stopper = False
                MsgBox("Item not found!")
                TextBox1.Text = ""
            End Try

        Loop
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
