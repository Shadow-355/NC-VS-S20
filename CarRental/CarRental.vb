Public Class CarRental

    'Class Variables, storing summary information
    Dim customerNum As Integer
    Dim finalDistance As Double
    Dim sumCost As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Disable textboxes and default Miles Radio Button
        DistanceTextBox.Enabled = False
        MileageChargeTextBox.Enabled = False
        DayChargeTextBox.Enabled = False
        MinusDiscountTextBox.Enabled = False
        TotalTextBox.Enabled = False
        MilesRadioButton.Checked = True

        BeginningOdometerReadingTextBox.Text = "0"
        BeginningOdometerReadingTextBox.Enabled = False
        SummaryButton.Enabled = False
        ClearButton.Enabled = True
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Validate All Data
        Dim errorLog As String

        If CustomerNameTextBox.Text = "" Then
            errorLog &= "Please enter a valid Name." & vbNewLine
            CustomerNameTextBox.Text = ""
            CustomerNameTextBox.Focus()
        End If

        If AddressTextBox.Text = "" Then
            errorLog &= "Please enter a valid Address." & vbNewLine
            AddressTextBox.Text = ""
            AddressTextBox.Focus()
        End If

        If CityTextBox.Text = "" Then
            errorLog &= "Please enter a valid City." & vbNewLine
            CityTextBox.Text = ""
            CityTextBox.Focus()
        End If

        If StateTextBox.Text = "" Then
            errorLog &= "Please enter a valid State." & vbNewLine
            StateTextBox.Text = ""
            StateTextBox.Focus()
        End If

        If ZipCodeTextBox.Text = "" Then
            errorLog &= "Please enter a valid Zip Code." & vbNewLine
            ZipCodeTextBox.Text = ""
            ZipCodeTextBox.Focus()
        End If

        Try
            If EndingOdometerReadingTextBox.Text = "" Then
                errorLog &= "Please enter a valid Ending Number." & vbNewLine
                EndingOdometerReadingTextBox.Text = ""
                EndingOdometerReadingTextBox.Focus()
            ElseIf CInt(EndingOdometerReadingTextBox.Text) <= 0 Then
                errorLog &= "Please enter a valid Ending Number." & vbNewLine
                EndingOdometerReadingTextBox.Text = ""
                EndingOdometerReadingTextBox.Focus()
            End If
        Catch ex As Exception
            errorLog &= "Please enter a valid Ending Number." & vbNewLine
            EndingOdometerReadingTextBox.Text = ""
            EndingOdometerReadingTextBox.Focus()
        End Try

        Try
            If CInt(NumberOfDaysTextBox.Text) <= 0 Then
                errorLog &= "Please enter a valid Days Number." & vbNewLine
                NumberOfDaysTextBox.Text = ""
                NumberOfDaysTextBox.Focus()
            ElseIf CInt(NumberOfDaysTextBox.Text) >= 45 Then
                errorLog &= "Please enter a valid Days Number." & vbNewLine
                NumberOfDaysTextBox.Text = ""
                NumberOfDaysTextBox.Focus()
            End If
        Catch ex As Exception
            errorLog &= "Please enter a valid Days Number." & vbNewLine
            NumberOfDaysTextBox.Text = ""
            NumberOfDaysTextBox.Focus()
        End Try

        'Display Errors or Proceed
        If errorLog <> "" Then
            MsgBox(errorLog)
        Else
            Calculation()
        End If

    End Sub

    Sub Calculation()
        Dim distanceSum As Double
        Dim mileageCost As Double
        Dim dayCost As Integer
        Dim aaaDiscount As Double
        Dim seniorDiscount As Double
        Dim totalCost As Double
        Dim finalCost As Double

        'Show Distance
        If MilesRadioButton.Checked = True Then
            DistanceLabel.Text = "Distance (mi)"
            DistanceTextBox.Text = EndingOdometerReadingTextBox.Text
        ElseIf KilometersRadioButton.Checked = True Then
            '1 Mile is approximatly equal to 1.61 Kilometer
            DistanceLabel.Text = "Distance (km)"
            DistanceTextBox.Text = (CDbl(EndingOdometerReadingTextBox.Text) * 1.61)
        End If

        'Save Distance Amount
        distanceSum = CDbl(DistanceTextBox.Text)

        'Calculate Mileage Charge
        If CInt(EndingOdometerReadingTextBox.Text) < 200 Then
            mileageCost = 0
            MileageChargeTextBox.Text = FormatCurrency(0)
        ElseIf CInt(EndingOdometerReadingTextBox.Text) < 500 Then
            mileageCost = (CDbl(EndingOdometerReadingTextBox.Text) - 200) * 0.12
            MileageChargeTextBox.Text = FormatCurrency(mileageCost)
        ElseIf CInt(EndingOdometerReadingTextBox.Text) > 500 Then
            mileageCost = ((CDbl(EndingOdometerReadingTextBox.Text) - 500) * 0.1) + 35.88
            MileageChargeTextBox.Text = FormatCurrency(mileageCost)
        End If

        'Day Charge
        dayCost = CInt(NumberOfDaysTextBox.Text) * 15
        DayChargeTextBox.Text = FormatCurrency(dayCost)

        'Create Total Variable
        totalCost = mileageCost + dayCost

        'Check for Discounts
        If AAACheckBox.Checked Then
            aaaDiscount = totalCost * 0.05
        Else
            aaaDiscount = 0
        End If

        If SeniorCheckBox.Checked Then
            seniorDiscount = totalCost * 0.03
        Else
            seniorDiscount = 0
        End If

        'Final Calculation and Display
        finalCost = totalCost - (seniorDiscount + aaaDiscount)
        MinusDiscountTextBox.Text = FormatCurrency(aaaDiscount + seniorDiscount)
        TotalTextBox.Text = FormatCurrency(finalCost)

        'Disable Calculate Button
        CalculateButton.Enabled = False
        ClearButton.Enabled = True

        'Log to Summary
        SummaryButton.Enabled = True
        Summary(distanceSum, finalCost)
    End Sub
    Sub Summary(distanceSum As Double, finalCost As Double)
        'Add one number to customer count.
        customerNum = customerNum + 1

        'Add distance to total.
        finalDistance = finalDistance + distanceSum

        'Add cost to total.
        sumCost = sumCost + finalCost
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Exit Message Prompt
        Dim Msg, Style, Title, Response
        Msg = "Are you sure you want to exit?"    ' Define message.
        Style = vbYesNo + vbDefaultButton2    ' Define buttons.
        Title = "Exit Prompt"    ' Define title.

        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' User chose Yes.
            Me.Close()
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'Reset All
        CustomerNameTextBox.Text = ""
        AddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipCodeTextBox.Text = ""
        EndingOdometerReadingTextBox.Text = ""
        NumberOfDaysTextBox.Text = ""

        DistanceTextBox.Text = ""
        MileageChargeTextBox.Text = ""
        DayChargeTextBox.Text = ""
        MinusDiscountTextBox.Text = ""
        TotalTextBox.Text = ""

        AAACheckBox.Checked = False
        SeniorCheckBox.Checked = False

        MilesRadioButton.Checked = True
        KilometersRadioButton.Checked = False

        CalculateButton.Enabled = True
        ClearButton.Enabled = False
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        ClearButton.PerformClick()
        MsgBox("Total Customers: " & customerNum & vbNewLine & "Total Distance: (mi) " & finalDistance & vbNewLine & "Total Cost: " & FormatCurrency(sumCost))
    End Sub
End Class
