<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.SpecialButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Vladimir Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(264, 9)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(286, 58)
        Me.DinerNameLabel.TabIndex = 0
        Me.DinerNameLabel.Text = "Fiery Fox Inn"
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(12, 350)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(154, 88)
        Me.SoupButton.TabIndex = 1
        Me.SoupButton.Text = "Today's Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(172, 350)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(154, 88)
        Me.SaladButton.TabIndex = 2
        Me.SaladButton.Text = "Today's Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(332, 350)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(154, 88)
        Me.FishButton.TabIndex = 3
        Me.FishButton.Text = "Today's Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'SpecialButton
        '
        Me.SpecialButton.Location = New System.Drawing.Point(492, 350)
        Me.SpecialButton.Name = "SpecialButton"
        Me.SpecialButton.Size = New System.Drawing.Size(154, 88)
        Me.SpecialButton.TabIndex = 4
        Me.SpecialButton.Text = "Today's Delicacy"
        Me.SpecialButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(652, 350)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(154, 88)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit Menu"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Ink Free", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(12, 84)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(794, 263)
        Me.DisplaySpecialLabel.TabIndex = 6
        Me.DisplaySpecialLabel.Text = "~As you open the door to the inn, a familiar voice calls out to you.~" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Welcome" &
    " back adventurer! What will you be having?""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "~Isabel Morris" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox
        '
        Me.PictureBox.Image = Global.DinerMenu.My.Resources.Resources.Inn
        Me.PictureBox.InitialImage = Nothing
        Me.PictureBox.Location = New System.Drawing.Point(810, 12)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(384, 424)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 7
        Me.PictureBox.TabStop = False
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 448)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SpecialButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Name = "DinerMenuForm"
        Me.Text = "DinerMenuForm"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents SpecialButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplaySpecialLabel As Label
    Friend WithEvents PictureBox As PictureBox
End Class
