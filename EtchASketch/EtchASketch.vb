'Nathan Comstock
'RCET0265
'Spring 2020
'EtchASketch
'https://github.com/comsnath/NC-VS-S20


Public Class EtchASketch

    'Create Variables
    Dim color As Color
    Dim drawingTool As New Pen(Color.Blue)
    Dim oX As Integer
    Dim oY As Integer
    Dim graph As Graphics


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles SketchArea.MouseMove
        'Changes Form Title to X, Y, and Mouse Click
        Me.Text = "X: " & e.X & " Y: " & e.Y & " Mouse Button: " & e.Button.ToString


        'Create Graph
        graph = SketchArea.CreateGraphics

        'Draw Line
        If e.Button.ToString <> "None" Then
            graph.DrawLine(drawingTool, oX, oY, e.X, e.Y)
        End If

        'Allows for drawing, moves the center point of the line.
        oX = e.X
        oY = e.Y
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click
        'Prevents it from going off-screen
        Dim buffer = Me.Top

        'Shake the screen
        For i = 1 To 4
            For j = 1 To 2000000
                If j < 1000000 Then
                    Me.Top = buffer - 80
                Else
                    Me.Top = buffer
                End If
            Next
        Next

        '
        graph.Clear(BackColor)
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        'Show Color Wheel
        ColorDialog.ShowDialog()

        'Change Pen Color
        color = ColorDialog.Color
        drawingTool.Color = color
    End Sub

    Private Sub DrawButton_Click(sender As Object, e As EventArgs) Handles DrawButton.Click
        MsgBox("Unsupported Feature.")
    End Sub
End Class
