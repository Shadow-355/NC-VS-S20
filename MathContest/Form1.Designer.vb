<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentMathGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.ProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CurrentMathGroupBox.SuspendLayout()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.ProblemTypeGroupBox.SuspendLayout()
        Me.ButtonGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 16)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(9, 30)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'CurrentMathGroupBox
        '
        Me.CurrentMathGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathGroupBox.Location = New System.Drawing.Point(12, 81)
        Me.CurrentMathGroupBox.Name = "CurrentMathGroupBox"
        Me.CurrentMathGroupBox.Size = New System.Drawing.Size(119, 147)
        Me.CurrentMathGroupBox.TabIndex = 2
        Me.CurrentMathGroupBox.TabStop = False
        Me.CurrentMathGroupBox.Text = "Current Problem"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(9, 110)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentAnswerTextBox.TabIndex = 7
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(6, 94)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(82, 13)
        Me.StudentAnswerLabel.TabIndex = 6
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(9, 71)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondNumberTextBox.TabIndex = 5
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(6, 55)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(84, 13)
        Me.SecondNumberLabel.TabIndex = 4
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(9, 32)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNumberTextBox.TabIndex = 3
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(6, 16)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(66, 13)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "First Number"
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(253, 63)
        Me.StudentInfoGroupBox.TabIndex = 3
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(204, 30)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(36, 20)
        Me.GradeTextBox.TabIndex = 5
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(201, 16)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.GradeLabel.TabIndex = 4
        Me.GradeLabel.Text = "Grade"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(141, 30)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(36, 20)
        Me.AgeTextBox.TabIndex = 3
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(138, 16)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 2
        Me.AgeLabel.Text = "Age"
        '
        'ProblemTypeGroupBox
        '
        Me.ProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.ProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.ProblemTypeGroupBox.Location = New System.Drawing.Point(137, 81)
        Me.ProblemTypeGroupBox.Name = "ProblemTypeGroupBox"
        Me.ProblemTypeGroupBox.Size = New System.Drawing.Size(128, 147)
        Me.ProblemTypeGroupBox.TabIndex = 4
        Me.ProblemTypeGroupBox.TabStop = False
        Me.ProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(16, 104)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(16, 81)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(16, 58)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(65, 17)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.TabStop = True
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(16, 35)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(271, 12)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(150, 216)
        Me.ButtonGroupBox.TabIndex = 5
        Me.ButtonGroupBox.TabStop = False
        Me.ButtonGroupBox.Text = "Action Buttons"
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(7, 167)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(137, 43)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Enabled = False
        Me.SummaryButton.Location = New System.Drawing.Point(7, 118)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(137, 43)
        Me.SummaryButton.TabIndex = 2
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(7, 69)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(137, 43)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Enabled = False
        Me.SubmitButton.Location = New System.Drawing.Point(7, 20)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(137, 43)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'MathContestForm
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(430, 241)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.ProblemTypeGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Controls.Add(Me.CurrentMathGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.CurrentMathGroupBox.ResumeLayout(False)
        Me.CurrentMathGroupBox.PerformLayout()
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.ProblemTypeGroupBox.ResumeLayout(False)
        Me.ProblemTypeGroupBox.PerformLayout()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CurrentMathGroupBox As GroupBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents ProblemTypeGroupBox As GroupBox
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SubmitButton As Button
End Class
