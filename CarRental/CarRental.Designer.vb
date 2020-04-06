<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarRental
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
        Me.components = New System.ComponentModel.Container()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.EndingOdometerReadingTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfDaysTextBox = New System.Windows.Forms.TextBox()
        Me.BeginningOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.EndingOdometerReadingLabel = New System.Windows.Forms.Label()
        Me.NumberOfDaysLabel = New System.Windows.Forms.Label()
        Me.MilesOrKilometersGroupBox = New System.Windows.Forms.GroupBox()
        Me.KilometersRadioButton = New System.Windows.Forms.RadioButton()
        Me.MilesRadioButton = New System.Windows.Forms.RadioButton()
        Me.DiscountsGroupBox = New System.Windows.Forms.GroupBox()
        Me.SeniorCheckBox = New System.Windows.Forms.CheckBox()
        Me.AAACheckBox = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DistanceLabel = New System.Windows.Forms.Label()
        Me.MileageChargeLabel = New System.Windows.Forms.Label()
        Me.DayChargeLabel = New System.Windows.Forms.Label()
        Me.MinusDiscountLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.DistanceTextBox = New System.Windows.Forms.TextBox()
        Me.MileageChargeTextBox = New System.Windows.Forms.TextBox()
        Me.DayChargeTextBox = New System.Windows.Forms.TextBox()
        Me.MinusDiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.MilesOrKilometersGroupBox.SuspendLayout()
        Me.DiscountsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(12, 16)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(82, 13)
        Me.CustomerNameLabel.TabIndex = 0
        Me.CustomerNameLabel.Text = "Customer Name"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 42)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 1
        Me.AddressLabel.Text = "Address"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(164, 13)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerNameTextBox.TabIndex = 1
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(164, 39)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 2
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(164, 65)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 3
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(164, 91)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StateTextBox.TabIndex = 4
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(12, 68)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 6
        Me.CityLabel.Text = "City"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(12, 94)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 7
        Me.StateLabel.Text = "State"
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.AutoSize = True
        Me.ZipCodeLabel.Location = New System.Drawing.Point(12, 120)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(50, 13)
        Me.ZipCodeLabel.TabIndex = 8
        Me.ZipCodeLabel.Text = "Zip Code"
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(164, 117)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZipCodeTextBox.TabIndex = 5
        '
        'BeginningOdometerReadingTextBox
        '
        Me.BeginningOdometerReadingTextBox.Location = New System.Drawing.Point(164, 143)
        Me.BeginningOdometerReadingTextBox.Name = "BeginningOdometerReadingTextBox"
        Me.BeginningOdometerReadingTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BeginningOdometerReadingTextBox.TabIndex = 6
        '
        'EndingOdometerReadingTextBox
        '
        Me.EndingOdometerReadingTextBox.Location = New System.Drawing.Point(164, 169)
        Me.EndingOdometerReadingTextBox.Name = "EndingOdometerReadingTextBox"
        Me.EndingOdometerReadingTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EndingOdometerReadingTextBox.TabIndex = 7
        '
        'NumberOfDaysTextBox
        '
        Me.NumberOfDaysTextBox.Location = New System.Drawing.Point(164, 195)
        Me.NumberOfDaysTextBox.Name = "NumberOfDaysTextBox"
        Me.NumberOfDaysTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberOfDaysTextBox.TabIndex = 8
        '
        'BeginningOdometerReadingLabel
        '
        Me.BeginningOdometerReadingLabel.AutoSize = True
        Me.BeginningOdometerReadingLabel.Location = New System.Drawing.Point(12, 146)
        Me.BeginningOdometerReadingLabel.Name = "BeginningOdometerReadingLabel"
        Me.BeginningOdometerReadingLabel.Size = New System.Drawing.Size(141, 13)
        Me.BeginningOdometerReadingLabel.TabIndex = 13
        Me.BeginningOdometerReadingLabel.Text = "Beginning Odometer in Miles"
        '
        'EndingOdometerReadingLabel
        '
        Me.EndingOdometerReadingLabel.AutoSize = True
        Me.EndingOdometerReadingLabel.Location = New System.Drawing.Point(12, 172)
        Me.EndingOdometerReadingLabel.Name = "EndingOdometerReadingLabel"
        Me.EndingOdometerReadingLabel.Size = New System.Drawing.Size(127, 13)
        Me.EndingOdometerReadingLabel.TabIndex = 14
        Me.EndingOdometerReadingLabel.Text = "Ending Odometer in Miles"
        '
        'NumberOfDaysLabel
        '
        Me.NumberOfDaysLabel.AutoSize = True
        Me.NumberOfDaysLabel.Location = New System.Drawing.Point(12, 198)
        Me.NumberOfDaysLabel.Name = "NumberOfDaysLabel"
        Me.NumberOfDaysLabel.Size = New System.Drawing.Size(85, 13)
        Me.NumberOfDaysLabel.TabIndex = 15
        Me.NumberOfDaysLabel.Text = "Number Of Days"
        '
        'MilesOrKilometersGroupBox
        '
        Me.MilesOrKilometersGroupBox.Controls.Add(Me.KilometersRadioButton)
        Me.MilesOrKilometersGroupBox.Controls.Add(Me.MilesRadioButton)
        Me.MilesOrKilometersGroupBox.Location = New System.Drawing.Point(15, 230)
        Me.MilesOrKilometersGroupBox.Name = "MilesOrKilometersGroupBox"
        Me.MilesOrKilometersGroupBox.Size = New System.Drawing.Size(217, 70)
        Me.MilesOrKilometersGroupBox.TabIndex = 16
        Me.MilesOrKilometersGroupBox.TabStop = False
        Me.MilesOrKilometersGroupBox.Text = "Miles Or Kilometers?"
        '
        'KilometersRadioButton
        '
        Me.KilometersRadioButton.AutoSize = True
        Me.KilometersRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.KilometersRadioButton.Name = "KilometersRadioButton"
        Me.KilometersRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.KilometersRadioButton.TabIndex = 10
        Me.KilometersRadioButton.TabStop = True
        Me.KilometersRadioButton.Text = "Kilometers"
        Me.KilometersRadioButton.UseVisualStyleBackColor = True
        '
        'MilesRadioButton
        '
        Me.MilesRadioButton.AutoSize = True
        Me.MilesRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.MilesRadioButton.Name = "MilesRadioButton"
        Me.MilesRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.MilesRadioButton.TabIndex = 9
        Me.MilesRadioButton.Text = "Miles"
        Me.MilesRadioButton.UseVisualStyleBackColor = True
        '
        'DiscountsGroupBox
        '
        Me.DiscountsGroupBox.Controls.Add(Me.SeniorCheckBox)
        Me.DiscountsGroupBox.Controls.Add(Me.AAACheckBox)
        Me.DiscountsGroupBox.Location = New System.Drawing.Point(300, 231)
        Me.DiscountsGroupBox.Name = "DiscountsGroupBox"
        Me.DiscountsGroupBox.Size = New System.Drawing.Size(219, 70)
        Me.DiscountsGroupBox.TabIndex = 17
        Me.DiscountsGroupBox.TabStop = False
        Me.DiscountsGroupBox.Text = "Discounts"
        '
        'SeniorCheckBox
        '
        Me.SeniorCheckBox.AutoSize = True
        Me.SeniorCheckBox.Location = New System.Drawing.Point(6, 42)
        Me.SeniorCheckBox.Name = "SeniorCheckBox"
        Me.SeniorCheckBox.Size = New System.Drawing.Size(101, 17)
        Me.SeniorCheckBox.TabIndex = 12
        Me.SeniorCheckBox.Text = "Senior Discount"
        Me.SeniorCheckBox.UseVisualStyleBackColor = True
        '
        'AAACheckBox
        '
        Me.AAACheckBox.AutoSize = True
        Me.AAACheckBox.Location = New System.Drawing.Point(6, 19)
        Me.AAACheckBox.Name = "AAACheckBox"
        Me.AAACheckBox.Size = New System.Drawing.Size(92, 17)
        Me.AAACheckBox.TabIndex = 11
        Me.AAACheckBox.Text = "AAA Discount"
        Me.AAACheckBox.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(12, 306)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 18
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(157, 307)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 19
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(300, 307)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 20
        Me.SummaryButton.Text = "Summary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(444, 307)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 21
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DistanceLabel
        '
        Me.DistanceLabel.AutoSize = True
        Me.DistanceLabel.Location = New System.Drawing.Point(303, 16)
        Me.DistanceLabel.Name = "DistanceLabel"
        Me.DistanceLabel.Size = New System.Drawing.Size(49, 13)
        Me.DistanceLabel.TabIndex = 22
        Me.DistanceLabel.Text = "Distance"
        '
        'MileageChargeLabel
        '
        Me.MileageChargeLabel.AutoSize = True
        Me.MileageChargeLabel.Location = New System.Drawing.Point(303, 42)
        Me.MileageChargeLabel.Name = "MileageChargeLabel"
        Me.MileageChargeLabel.Size = New System.Drawing.Size(81, 13)
        Me.MileageChargeLabel.TabIndex = 23
        Me.MileageChargeLabel.Text = "Mileage Charge"
        '
        'DayChargeLabel
        '
        Me.DayChargeLabel.AutoSize = True
        Me.DayChargeLabel.Location = New System.Drawing.Point(303, 68)
        Me.DayChargeLabel.Name = "DayChargeLabel"
        Me.DayChargeLabel.Size = New System.Drawing.Size(63, 13)
        Me.DayChargeLabel.TabIndex = 24
        Me.DayChargeLabel.Text = "Day Charge"
        '
        'MinusDiscountLabel
        '
        Me.MinusDiscountLabel.AutoSize = True
        Me.MinusDiscountLabel.Location = New System.Drawing.Point(303, 94)
        Me.MinusDiscountLabel.Name = "MinusDiscountLabel"
        Me.MinusDiscountLabel.Size = New System.Drawing.Size(80, 13)
        Me.MinusDiscountLabel.TabIndex = 25
        Me.MinusDiscountLabel.Text = "Minus Discount"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(303, 120)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.TotalLabel.TabIndex = 26
        Me.TotalLabel.Text = "Total"
        '
        'DistanceTextBox
        '
        Me.DistanceTextBox.Location = New System.Drawing.Point(388, 13)
        Me.DistanceTextBox.Name = "DistanceTextBox"
        Me.DistanceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DistanceTextBox.TabIndex = 27
        '
        'MileageChargeTextBox
        '
        Me.MileageChargeTextBox.Location = New System.Drawing.Point(388, 39)
        Me.MileageChargeTextBox.Name = "MileageChargeTextBox"
        Me.MileageChargeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MileageChargeTextBox.TabIndex = 28
        '
        'DayChargeTextBox
        '
        Me.DayChargeTextBox.Location = New System.Drawing.Point(388, 65)
        Me.DayChargeTextBox.Name = "DayChargeTextBox"
        Me.DayChargeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DayChargeTextBox.TabIndex = 29
        '
        'MinusDiscountTextBox
        '
        Me.MinusDiscountTextBox.Location = New System.Drawing.Point(388, 91)
        Me.MinusDiscountTextBox.Name = "MinusDiscountTextBox"
        Me.MinusDiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MinusDiscountTextBox.TabIndex = 30
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(388, 117)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 31
        '
        'CarRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 342)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.MinusDiscountTextBox)
        Me.Controls.Add(Me.DayChargeTextBox)
        Me.Controls.Add(Me.MileageChargeTextBox)
        Me.Controls.Add(Me.DistanceTextBox)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.MinusDiscountLabel)
        Me.Controls.Add(Me.DayChargeLabel)
        Me.Controls.Add(Me.MileageChargeLabel)
        Me.Controls.Add(Me.DistanceLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.DiscountsGroupBox)
        Me.Controls.Add(Me.MilesOrKilometersGroupBox)
        Me.Controls.Add(Me.NumberOfDaysLabel)
        Me.Controls.Add(Me.EndingOdometerReadingLabel)
        Me.Controls.Add(Me.BeginningOdometerReadingLabel)
        Me.Controls.Add(Me.NumberOfDaysTextBox)
        Me.Controls.Add(Me.EndingOdometerReadingTextBox)
        Me.Controls.Add(Me.BeginningOdometerReadingTextBox)
        Me.Controls.Add(Me.ZipCodeTextBox)
        Me.Controls.Add(Me.ZipCodeLabel)
        Me.Controls.Add(Me.StateLabel)
        Me.Controls.Add(Me.CityLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.CustomerNameLabel)
        Me.Name = "CarRental"
        Me.Text = "Rent A Car!"
        Me.MilesOrKilometersGroupBox.ResumeLayout(False)
        Me.MilesOrKilometersGroupBox.PerformLayout()
        Me.DiscountsGroupBox.ResumeLayout(False)
        Me.DiscountsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents BeginningOdometerReadingTextBox As TextBox
    Friend WithEvents EndingOdometerReadingTextBox As TextBox
    Friend WithEvents NumberOfDaysTextBox As TextBox
    Friend WithEvents BeginningOdometerReadingLabel As Label
    Friend WithEvents EndingOdometerReadingLabel As Label
    Friend WithEvents NumberOfDaysLabel As Label
    Friend WithEvents MilesOrKilometersGroupBox As GroupBox
    Friend WithEvents KilometersRadioButton As RadioButton
    Friend WithEvents MilesRadioButton As RadioButton
    Friend WithEvents DiscountsGroupBox As GroupBox
    Friend WithEvents SeniorCheckBox As CheckBox
    Friend WithEvents AAACheckBox As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DistanceLabel As Label
    Friend WithEvents MileageChargeLabel As Label
    Friend WithEvents DayChargeLabel As Label
    Friend WithEvents MinusDiscountLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents DistanceTextBox As TextBox
    Friend WithEvents MileageChargeTextBox As TextBox
    Friend WithEvents DayChargeTextBox As TextBox
    Friend WithEvents MinusDiscountTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
End Class
