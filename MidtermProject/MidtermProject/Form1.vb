Option Strict On

Public Class MidtermProject

    'declare variables
    Dim strName As String
    Dim dblHourlyWage As Double
    Dim intHoursWorked As Integer
    Dim intWithholdingExemptions As Integer
    Dim blnMarried As Boolean
    Dim dblPreviousYearToDateEarnings As Double

    Dim dblGrossEarnings As Double
    Dim dblFicaTax As Double
    Dim dblFederalIncomeTaxWithheld As Double
    Dim dblNetEarnings As Double
    Dim dblUpdatedYearToDateEarnings As Double

    Dim dblAdjustedGrossIncome As Double
    Dim dblSSTax As Double
    Dim dblMedicareTax As Double

    'payroll summary variables
    Dim dblTotalGrossEarnings As Double
    Dim dblTotalFicaTax As Double
    Dim dblTotalFederalIncomeTaxPaid As Double

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try

            'set variables
            strName = txtName.Text
            dblHourlyWage = CDbl(txtHourlyWage.Text)
            intHoursWorked = CInt(txtHoursWorked.Text)
            intWithholdingExemptions = CInt(txtExemptions.Text)
            blnMarried = False
            dblPreviousYearToDateEarnings = CDbl(txtPreviousEarnings.Text)

            'make sure fields contain valid info
            If strName = "" Then
                MsgBox("Please enter a name.")
                Exit Sub
            ElseIf dblHourlyWage <= 0 Or IsNumeric(dblHourlyWage) = False Then
                MsgBox("Please enter a valid hourly wage.")
                Exit Sub
            ElseIf intHoursWorked <= 0 Or IsNumeric(intHoursWorked) = False Then
                MsgBox("Please enter a valid amount for hours worked.")
                Exit Sub
            ElseIf intWithholdingExemptions < 0 Or intWithholdingExemptions > 10 Or IsNumeric(intWithholdingExemptions) = False Then
                MsgBox("Please enter a valid number for withholding exemptions between 0 and 10.")
                Exit Sub
            ElseIf radMarried.Checked Then
                blnMarried = True
            ElseIf dblPreviousYearToDateEarnings < 0 Or IsNumeric(dblPreviousYearToDateEarnings) = False Then
                MsgBox("Please enter a valid amount for previous year to date earnings.")
                Exit Sub
            Else
            End If

            'gross earnings
            If intHoursWorked <= 40 Then
                dblGrossEarnings = dblHourlyWage * intHoursWorked
            ElseIf intHoursWorked > 40 Then
                dblGrossEarnings = dblHourlyWage * 40 + dblHourlyWage * ((intHoursWorked - 40) * 1.5)
            End If

            'updated year to date earnings
            dblUpdatedYearToDateEarnings = dblPreviousYearToDateEarnings + dblGrossEarnings

            'social security tax for calculating fica tax
            If dblGrossEarnings <= 84000 Then
                dblSSTax = 0.062 * dblGrossEarnings
            ElseIf dblGrossEarnings > 84000 Then
                dblSSTax = 0.062 * 84000
            End If

            'medicare tax for calculating fica tax
            dblMedicareTax = 0.0145 * dblGrossEarnings

            'fica tax
            dblFicaTax = dblSSTax + dblMedicareTax

            'Adjusted Gross Income for calculating Federal Income Tax Withheld
            dblAdjustedGrossIncome = 55.77 * intWithholdingExemptions

            If dblAdjustedGrossIncome >= 0 And dblAdjustedGrossIncome <= 50 Then
                dblFederalIncomeTaxWithheld = 0

            ElseIf dblAdjustedGrossIncome > 50 And dblAdjustedGrossIncome <= 500 And blnMarried = False Then
                dblFederalIncomeTaxWithheld = (dblAdjustedGrossIncome - 51) * 0.1

            ElseIf dblAdjustedGrossIncome > 50 And dblAdjustedGrossIncome <= 500 And blnMarried = True Then
                dblFederalIncomeTaxWithheld = (dblAdjustedGrossIncome - 51) * 0.05

            ElseIf dblAdjustedGrossIncome > 500 And dblAdjustedGrossIncome <= 2500 And blnMarried = False Then
                dblFederalIncomeTaxWithheld = 45 + (dblAdjustedGrossIncome - 500) * 0.15

            ElseIf dblAdjustedGrossIncome > 500 And dblAdjustedGrossIncome <= 2500 And blnMarried = True Then
                dblFederalIncomeTaxWithheld = 22.5 + (dblAdjustedGrossIncome - 500) * 0.1

            ElseIf dblAdjustedGrossIncome > 2500 And dblAdjustedGrossIncome <= 5000 And blnMarried = False Then
                dblFederalIncomeTaxWithheld = 345 + (dblAdjustedGrossIncome - 2500) * 0.2

            ElseIf dblAdjustedGrossIncome > 2500 And dblAdjustedGrossIncome <= 5000 And blnMarried = True Then
                dblFederalIncomeTaxWithheld = 225.5 + (dblAdjustedGrossIncome - 2500) * 0.15

            ElseIf dblAdjustedGrossIncome > 5000 And blnMarried = False Then
                dblFederalIncomeTaxWithheld = 845 + (dblAdjustedGrossIncome - 5000) * 0.25

            ElseIf dblAdjustedGrossIncome > 5000 And blnMarried = True Then
                dblFederalIncomeTaxWithheld = 600.5 + (dblAdjustedGrossIncome - 5000) * 0.2
            End If

            'net earnings
            dblNetEarnings = dblGrossEarnings - dblFicaTax - dblFederalIncomeTaxWithheld

            lblGrossEarningsResult.Text = FormatCurrency(dblGrossEarnings)
            lblFicaTaxResult.Text = FormatCurrency(dblFicaTax)
            lblFederalIncomeTaxWithheldResult.Text = FormatCurrency(dblFederalIncomeTaxWithheld)
            lblNetEarningsResult.Text = FormatCurrency(dblNetEarnings)
            lblUpdatedYearToDateEarningsResult.Text = FormatCurrency(dblUpdatedYearToDateEarnings)

            dblTotalGrossEarnings = dblTotalGrossEarnings + dblGrossEarnings
            dblTotalFicaTax = dblTotalFicaTax + dblFicaTax
            dblTotalFederalIncomeTaxPaid = dblTotalFederalIncomeTaxPaid + dblFederalIncomeTaxWithheld

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click

        MsgBox("Total Gross Earnings: " + FormatCurrency(dblTotalGrossEarnings) + vbNewLine +
               " Total FICA Tax Paid: " + FormatCurrency(dblTotalFicaTax) + vbNewLine +
               " Total Federal Income Tax Paid: " + FormatCurrency(dblTotalFederalIncomeTaxPaid))

    End Sub

    Private Sub btnNextEmployee_Click(sender As Object, e As EventArgs) Handles btnNextEmployee.Click

        'clears all text boxes and labels

        txtName.Text = ""
        txtExemptions.Text = ""
        txtPreviousEarnings.Text = ""
        txtHourlyWage.Text = ""
        txtHoursWorked.Text = ""

        blnMarried = False
        radSingle.Checked = True

        lblFederalIncomeTaxWithheldResult.Text = ""
        lblNetEarningsResult.Text = ""
        lblUpdatedYearToDateEarningsResult.Text = ""
        lblFicaTaxResult.Text = ""
        lblGrossEarningsResult.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'closes the application
        Close()

    End Sub
End Class
