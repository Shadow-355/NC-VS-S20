<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchASketch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SketchArea = New System.Windows.Forms.PictureBox()
        Me.DrawButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        CType(Me.SketchArea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SketchArea
        '
        Me.SketchArea.Location = New System.Drawing.Point(0, 0)
        Me.SketchArea.Name = "SketchArea"
        Me.SketchArea.Size = New System.Drawing.Size(799, 446)
        Me.SketchArea.TabIndex = 0
        Me.SketchArea.TabStop = False
        '
        'DrawButton
        '
        Me.DrawButton.Location = New System.Drawing.Point(12, 455)
        Me.DrawButton.Name = "DrawButton"
        Me.DrawButton.Size = New System.Drawing.Size(108, 23)
        Me.DrawButton.TabIndex = 1
        Me.DrawButton.Text = "Draw"
        Me.DrawButton.UseVisualStyleBackColor = True
        '
        'EraseButton
        '
        Me.EraseButton.Location = New System.Drawing.Point(240, 455)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(108, 23)
        Me.EraseButton.TabIndex = 2
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(680, 455)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(108, 23)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'ColorButton
        '
        Me.ColorButton.Location = New System.Drawing.Point(126, 455)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(108, 23)
        Me.ColorButton.TabIndex = 4
        Me.ColorButton.Text = "Change Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'EtchASketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 490)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.DrawButton)
        Me.Controls.Add(Me.SketchArea)
        Me.Name = "EtchASketch"
        Me.Text = "Etch-A-Sketch"
        CType(Me.SketchArea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SketchArea As PictureBox
    Friend WithEvents DrawButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ColorButton As Button
    Friend WithEvents ColorDialog As ColorDialog
End Class
