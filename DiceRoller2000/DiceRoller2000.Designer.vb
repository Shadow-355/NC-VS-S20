<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiceRollerForm
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
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OutputListBox
        '
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.Location = New System.Drawing.Point(13, 13)
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.Size = New System.Drawing.Size(417, 186)
        Me.OutputListBox.TabIndex = 0
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(13, 205)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(417, 23)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "Roll!"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'DiceRollerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 242)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.OutputListBox)
        Me.Name = "DiceRollerForm"
        Me.Text = "Roll The Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents RollButton As Button
End Class
