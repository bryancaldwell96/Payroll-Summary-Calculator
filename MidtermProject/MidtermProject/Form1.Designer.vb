<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MidtermProject
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblHourlyWage = New System.Windows.Forms.Label()
        Me.txtHourlyWage = New System.Windows.Forms.TextBox()
        Me.txtHoursWorked = New System.Windows.Forms.TextBox()
        Me.lblHoursWorked = New System.Windows.Forms.Label()
        Me.lblExemptions = New System.Windows.Forms.Label()
        Me.txtExemptions = New System.Windows.Forms.TextBox()
        Me.lblMaritalStatus = New System.Windows.Forms.Label()
        Me.lblPreviousEarnings = New System.Windows.Forms.Label()
        Me.txtPreviousEarnings = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblGrossEarnings = New System.Windows.Forms.Label()
        Me.lblFicaTax = New System.Windows.Forms.Label()
        Me.lblFederalIncomeTaxWithheld = New System.Windows.Forms.Label()
        Me.lblNetEarnings = New System.Windows.Forms.Label()
        Me.lblUpdatedYearToDateEarnings = New System.Windows.Forms.Label()
        Me.btnNextEmployee = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.radMarried = New System.Windows.Forms.RadioButton()
        Me.lblGrossEarningsResult = New System.Windows.Forms.Label()
        Me.lblFicaTaxResult = New System.Windows.Forms.Label()
        Me.lblFederalIncomeTaxWithheldResult = New System.Windows.Forms.Label()
        Me.lblNetEarningsResult = New System.Windows.Forms.Label()
        Me.lblUpdatedYearToDateEarningsResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(192, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(148, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        '
        'lblHourlyWage
        '
        Me.lblHourlyWage.AutoSize = True
        Me.lblHourlyWage.Location = New System.Drawing.Point(114, 57)
        Me.lblHourlyWage.Name = "lblHourlyWage"
        Me.lblHourlyWage.Size = New System.Drawing.Size(72, 13)
        Me.lblHourlyWage.TabIndex = 2
        Me.lblHourlyWage.Text = "Hourly Wage:"
        '
        'txtHourlyWage
        '
        Me.txtHourlyWage.Location = New System.Drawing.Point(192, 54)
        Me.txtHourlyWage.Name = "txtHourlyWage"
        Me.txtHourlyWage.Size = New System.Drawing.Size(100, 20)
        Me.txtHourlyWage.TabIndex = 3
        '
        'txtHoursWorked
        '
        Me.txtHoursWorked.Location = New System.Drawing.Point(192, 80)
        Me.txtHoursWorked.Name = "txtHoursWorked"
        Me.txtHoursWorked.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursWorked.TabIndex = 4
        '
        'lblHoursWorked
        '
        Me.lblHoursWorked.AutoSize = True
        Me.lblHoursWorked.Location = New System.Drawing.Point(107, 83)
        Me.lblHoursWorked.Name = "lblHoursWorked"
        Me.lblHoursWorked.Size = New System.Drawing.Size(79, 13)
        Me.lblHoursWorked.TabIndex = 5
        Me.lblHoursWorked.Text = "Hours Worked:"
        '
        'lblExemptions
        '
        Me.lblExemptions.AutoSize = True
        Me.lblExemptions.Location = New System.Drawing.Point(63, 109)
        Me.lblExemptions.Name = "lblExemptions"
        Me.lblExemptions.Size = New System.Drawing.Size(123, 13)
        Me.lblExemptions.TabIndex = 6
        Me.lblExemptions.Text = "Withholding Exemptions:"
        '
        'txtExemptions
        '
        Me.txtExemptions.Location = New System.Drawing.Point(192, 106)
        Me.txtExemptions.Name = "txtExemptions"
        Me.txtExemptions.Size = New System.Drawing.Size(100, 20)
        Me.txtExemptions.TabIndex = 7
        '
        'lblMaritalStatus
        '
        Me.lblMaritalStatus.AutoSize = True
        Me.lblMaritalStatus.Location = New System.Drawing.Point(112, 136)
        Me.lblMaritalStatus.Name = "lblMaritalStatus"
        Me.lblMaritalStatus.Size = New System.Drawing.Size(74, 13)
        Me.lblMaritalStatus.TabIndex = 8
        Me.lblMaritalStatus.Text = "Marital Status:"
        '
        'lblPreviousEarnings
        '
        Me.lblPreviousEarnings.AutoSize = True
        Me.lblPreviousEarnings.Location = New System.Drawing.Point(30, 164)
        Me.lblPreviousEarnings.Name = "lblPreviousEarnings"
        Me.lblPreviousEarnings.Size = New System.Drawing.Size(156, 13)
        Me.lblPreviousEarnings.TabIndex = 10
        Me.lblPreviousEarnings.Text = "Previous Year-to-date Earnings:"
        '
        'txtPreviousEarnings
        '
        Me.txtPreviousEarnings.Location = New System.Drawing.Point(192, 161)
        Me.txtPreviousEarnings.Name = "txtPreviousEarnings"
        Me.txtPreviousEarnings.Size = New System.Drawing.Size(100, 20)
        Me.txtPreviousEarnings.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 372)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(82, 29)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblGrossEarnings
        '
        Me.lblGrossEarnings.AutoSize = True
        Me.lblGrossEarnings.Location = New System.Drawing.Point(100, 220)
        Me.lblGrossEarnings.Name = "lblGrossEarnings"
        Me.lblGrossEarnings.Size = New System.Drawing.Size(81, 13)
        Me.lblGrossEarnings.TabIndex = 13
        Me.lblGrossEarnings.Text = "Gross Earnings:"
        '
        'lblFicaTax
        '
        Me.lblFicaTax.AutoSize = True
        Me.lblFicaTax.Location = New System.Drawing.Point(127, 247)
        Me.lblFicaTax.Name = "lblFicaTax"
        Me.lblFicaTax.Size = New System.Drawing.Size(54, 13)
        Me.lblFicaTax.TabIndex = 16
        Me.lblFicaTax.Text = "FICA Tax:"
        '
        'lblFederalIncomeTaxWithheld
        '
        Me.lblFederalIncomeTaxWithheld.AutoSize = True
        Me.lblFederalIncomeTaxWithheld.Location = New System.Drawing.Point(30, 273)
        Me.lblFederalIncomeTaxWithheld.Name = "lblFederalIncomeTaxWithheld"
        Me.lblFederalIncomeTaxWithheld.Size = New System.Drawing.Size(149, 13)
        Me.lblFederalIncomeTaxWithheld.TabIndex = 17
        Me.lblFederalIncomeTaxWithheld.Text = "Federal Income Tax Withheld:"
        '
        'lblNetEarnings
        '
        Me.lblNetEarnings.AutoSize = True
        Me.lblNetEarnings.Location = New System.Drawing.Point(110, 299)
        Me.lblNetEarnings.Name = "lblNetEarnings"
        Me.lblNetEarnings.Size = New System.Drawing.Size(71, 13)
        Me.lblNetEarnings.TabIndex = 19
        Me.lblNetEarnings.Text = "Net Earnings:"
        '
        'lblUpdatedYearToDateEarnings
        '
        Me.lblUpdatedYearToDateEarnings.AutoSize = True
        Me.lblUpdatedYearToDateEarnings.Location = New System.Drawing.Point(25, 325)
        Me.lblUpdatedYearToDateEarnings.Name = "lblUpdatedYearToDateEarnings"
        Me.lblUpdatedYearToDateEarnings.Size = New System.Drawing.Size(156, 13)
        Me.lblUpdatedYearToDateEarnings.TabIndex = 21
        Me.lblUpdatedYearToDateEarnings.Text = "Updated Year-to-date Earnings:"
        '
        'btnNextEmployee
        '
        Me.btnNextEmployee.Location = New System.Drawing.Point(103, 372)
        Me.btnNextEmployee.Name = "btnNextEmployee"
        Me.btnNextEmployee.Size = New System.Drawing.Size(89, 29)
        Me.btnNextEmployee.TabIndex = 31
        Me.btnNextEmployee.Text = "Next Employee"
        Me.btnNextEmployee.UseVisualStyleBackColor = True
        '
        'btnPayroll
        '
        Me.btnPayroll.Location = New System.Drawing.Point(207, 372)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(94, 29)
        Me.btnPayroll.TabIndex = 32
        Me.btnPayroll.Text = "Payroll Summary"
        Me.btnPayroll.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(307, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 29)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Checked = True
        Me.radSingle.Location = New System.Drawing.Point(198, 136)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(54, 17)
        Me.radSingle.TabIndex = 34
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'radMarried
        '
        Me.radMarried.AutoSize = True
        Me.radMarried.Location = New System.Drawing.Point(259, 136)
        Me.radMarried.Name = "radMarried"
        Me.radMarried.Size = New System.Drawing.Size(60, 17)
        Me.radMarried.TabIndex = 35
        Me.radMarried.Text = "Married"
        Me.radMarried.UseVisualStyleBackColor = True
        '
        'lblGrossEarningsResult
        '
        Me.lblGrossEarningsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossEarningsResult.Location = New System.Drawing.Point(192, 219)
        Me.lblGrossEarningsResult.Name = "lblGrossEarningsResult"
        Me.lblGrossEarningsResult.Size = New System.Drawing.Size(100, 21)
        Me.lblGrossEarningsResult.TabIndex = 36
        '
        'lblFicaTaxResult
        '
        Me.lblFicaTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFicaTaxResult.Location = New System.Drawing.Point(192, 246)
        Me.lblFicaTaxResult.Name = "lblFicaTaxResult"
        Me.lblFicaTaxResult.Size = New System.Drawing.Size(100, 21)
        Me.lblFicaTaxResult.TabIndex = 37
        '
        'lblFederalIncomeTaxWithheldResult
        '
        Me.lblFederalIncomeTaxWithheldResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFederalIncomeTaxWithheldResult.Location = New System.Drawing.Point(192, 272)
        Me.lblFederalIncomeTaxWithheldResult.Name = "lblFederalIncomeTaxWithheldResult"
        Me.lblFederalIncomeTaxWithheldResult.Size = New System.Drawing.Size(100, 22)
        Me.lblFederalIncomeTaxWithheldResult.TabIndex = 38
        '
        'lblNetEarningsResult
        '
        Me.lblNetEarningsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetEarningsResult.Location = New System.Drawing.Point(192, 298)
        Me.lblNetEarningsResult.Name = "lblNetEarningsResult"
        Me.lblNetEarningsResult.Size = New System.Drawing.Size(100, 21)
        Me.lblNetEarningsResult.TabIndex = 39
        '
        'lblUpdatedYearToDateEarningsResult
        '
        Me.lblUpdatedYearToDateEarningsResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUpdatedYearToDateEarningsResult.Location = New System.Drawing.Point(192, 324)
        Me.lblUpdatedYearToDateEarningsResult.Name = "lblUpdatedYearToDateEarningsResult"
        Me.lblUpdatedYearToDateEarningsResult.Size = New System.Drawing.Size(100, 21)
        Me.lblUpdatedYearToDateEarningsResult.TabIndex = 40
        '
        'MidtermProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 413)
        Me.Controls.Add(Me.lblUpdatedYearToDateEarningsResult)
        Me.Controls.Add(Me.lblNetEarningsResult)
        Me.Controls.Add(Me.lblFederalIncomeTaxWithheldResult)
        Me.Controls.Add(Me.lblFicaTaxResult)
        Me.Controls.Add(Me.lblGrossEarningsResult)
        Me.Controls.Add(Me.radMarried)
        Me.Controls.Add(Me.radSingle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPayroll)
        Me.Controls.Add(Me.btnNextEmployee)
        Me.Controls.Add(Me.lblUpdatedYearToDateEarnings)
        Me.Controls.Add(Me.lblNetEarnings)
        Me.Controls.Add(Me.lblFederalIncomeTaxWithheld)
        Me.Controls.Add(Me.lblFicaTax)
        Me.Controls.Add(Me.lblGrossEarnings)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPreviousEarnings)
        Me.Controls.Add(Me.lblPreviousEarnings)
        Me.Controls.Add(Me.lblMaritalStatus)
        Me.Controls.Add(Me.txtExemptions)
        Me.Controls.Add(Me.lblExemptions)
        Me.Controls.Add(Me.lblHoursWorked)
        Me.Controls.Add(Me.txtHoursWorked)
        Me.Controls.Add(Me.txtHourlyWage)
        Me.Controls.Add(Me.lblHourlyWage)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Name = "MidtermProject"
        Me.Text = "Midterm Project"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblHourlyWage As System.Windows.Forms.Label
    Friend WithEvents txtHourlyWage As System.Windows.Forms.TextBox
    Friend WithEvents txtHoursWorked As System.Windows.Forms.TextBox
    Friend WithEvents lblHoursWorked As System.Windows.Forms.Label
    Friend WithEvents lblExemptions As System.Windows.Forms.Label
    Friend WithEvents txtExemptions As System.Windows.Forms.TextBox
    Friend WithEvents lblMaritalStatus As System.Windows.Forms.Label
    Friend WithEvents lblPreviousEarnings As System.Windows.Forms.Label
    Friend WithEvents txtPreviousEarnings As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblGrossEarnings As System.Windows.Forms.Label
    Friend WithEvents lblFicaTax As System.Windows.Forms.Label
    Friend WithEvents lblFederalIncomeTaxWithheld As System.Windows.Forms.Label
    Friend WithEvents lblNetEarnings As System.Windows.Forms.Label
    Friend WithEvents lblUpdatedYearToDateEarnings As System.Windows.Forms.Label
    Friend WithEvents btnNextEmployee As System.Windows.Forms.Button
    Friend WithEvents btnPayroll As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents radMarried As RadioButton
    Friend WithEvents lblGrossEarningsResult As Label
    Friend WithEvents lblFicaTaxResult As Label
    Friend WithEvents lblFederalIncomeTaxWithheldResult As Label
    Friend WithEvents lblNetEarningsResult As Label
    Friend WithEvents lblUpdatedYearToDateEarningsResult As Label
End Class
