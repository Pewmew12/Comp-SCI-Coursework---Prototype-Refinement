<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Menu
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
        GroupBox1 = New GroupBox()
        butAddEmployee = New Button()
        txtEmail = New TextBox()
        txtFName = New TextBox()
        txtSName = New TextBox()
        txtPhoneNumber = New TextBox()
        dtpDoB = New DateTimePicker()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label3 = New Label()
        rtbCurrentEmployees = New RichTextBox()
        txtPayFrequency = New TextBox()
        butDeleteSlime = New Button()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        txtEmployeeID = New TextBox()
        butSavePay = New Button()
        txtBank = New TextBox()
        txtPayAmount = New TextBox()
        butSearchEmployee = New Button()
        butDeleteEmployee = New Button()
        butNewSlime = New Button()
        butEmployeeMenu = New Button()
        butOverview = New Button()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
        lblActivatorLimit = New Label()
        lblSlimeLimit = New Label()
        butViewSlimes = New Button()
        butSlimeLimit = New Button()
        butActivatorLimit = New Button()
        rtbEmployeePayroll = New RichTextBox()
        Label1 = New Label()
        comEmployeeID = New ComboBox()
        Label12 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(butAddEmployee)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtFName)
        GroupBox1.Controls.Add(txtSName)
        GroupBox1.Controls.Add(txtPhoneNumber)
        GroupBox1.Controls.Add(dtpDoB)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(14, 17)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(422, 345)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Employee"
        ' 
        ' butAddEmployee
        ' 
        butAddEmployee.Location = New Point(110, 287)
        butAddEmployee.Margin = New Padding(3, 4, 3, 4)
        butAddEmployee.Name = "butAddEmployee"
        butAddEmployee.Size = New Size(207, 31)
        butAddEmployee.TabIndex = 9
        butAddEmployee.Text = "Save and Add Employee"
        butAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(145, 195)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(228, 27)
        txtEmail.TabIndex = 9
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(145, 53)
        txtFName.Margin = New Padding(3, 4, 3, 4)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(228, 27)
        txtFName.TabIndex = 10
        ' 
        ' txtSName
        ' 
        txtSName.Location = New Point(145, 92)
        txtSName.Margin = New Padding(3, 4, 3, 4)
        txtSName.Name = "txtSName"
        txtSName.Size = New Size(228, 27)
        txtSName.TabIndex = 11
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(145, 233)
        txtPhoneNumber.Margin = New Padding(3, 4, 3, 4)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(228, 27)
        txtPhoneNumber.TabIndex = 12
        ' 
        ' dtpDoB
        ' 
        dtpDoB.Location = New Point(145, 131)
        dtpDoB.Margin = New Padding(3, 4, 3, 4)
        dtpDoB.Name = "dtpDoB"
        dtpDoB.Size = New Size(228, 27)
        dtpDoB.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 199)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(55, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 20)
        Label5.TabIndex = 11
        Label5.Text = "Date of Birth"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(38, 237)
        Label6.Name = "Label6"
        Label6.Size = New Size(108, 20)
        Label6.TabIndex = 12
        Label6.Text = "Phone Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(77, 96)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 20)
        Label7.TabIndex = 13
        Label7.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 9
        Label3.Text = "First Name"
        ' 
        ' rtbCurrentEmployees
        ' 
        rtbCurrentEmployees.Location = New Point(442, 36)
        rtbCurrentEmployees.Margin = New Padding(3, 4, 3, 4)
        rtbCurrentEmployees.Name = "rtbCurrentEmployees"
        rtbCurrentEmployees.Size = New Size(748, 148)
        rtbCurrentEmployees.TabIndex = 1
        rtbCurrentEmployees.Text = ""
        ' 
        ' txtPayFrequency
        ' 
        txtPayFrequency.Location = New Point(145, 183)
        txtPayFrequency.Margin = New Padding(3, 4, 3, 4)
        txtPayFrequency.Name = "txtPayFrequency"
        txtPayFrequency.Size = New Size(228, 27)
        txtPayFrequency.TabIndex = 2
        ' 
        ' butDeleteSlime
        ' 
        butDeleteSlime.Location = New Point(31, 62)
        butDeleteSlime.Margin = New Padding(3, 4, 3, 4)
        butDeleteSlime.Name = "butDeleteSlime"
        butDeleteSlime.Size = New Size(207, 31)
        butDeleteSlime.TabIndex = 3
        butDeleteSlime.Text = "Delete Slime"
        butDeleteSlime.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(442, 12)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 20)
        Label2.TabIndex = 5
        Label2.Text = "Current Employees:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtEmployeeID)
        GroupBox2.Controls.Add(butSavePay)
        GroupBox2.Controls.Add(txtBank)
        GroupBox2.Controls.Add(txtPayFrequency)
        GroupBox2.Controls.Add(txtPayAmount)
        GroupBox2.Location = New Point(14, 371)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(422, 285)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Edit/Add Payroll"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(23, 187)
        Label11.Name = "Label11"
        Label11.Size = New Size(124, 20)
        Label11.TabIndex = 14
        Label11.Text = "Payroll Frequency"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(35, 148)
        Label10.Name = "Label10"
        Label10.Size = New Size(110, 20)
        Label10.TabIndex = 13
        Label10.Text = "Payroll Amount"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(97, 88)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 20)
        Label9.TabIndex = 12
        Label9.Tag = ""
        Label9.Text = "Bank:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(58, 49)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 20)
        Label8.TabIndex = 9
        Label8.Text = "EmployeeID"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(145, 45)
        txtEmployeeID.Margin = New Padding(3, 4, 3, 4)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(228, 27)
        txtEmployeeID.TabIndex = 9
        ' 
        ' butSavePay
        ' 
        butSavePay.Location = New Point(110, 233)
        butSavePay.Margin = New Padding(3, 4, 3, 4)
        butSavePay.Name = "butSavePay"
        butSavePay.Size = New Size(207, 31)
        butSavePay.TabIndex = 9
        butSavePay.Text = "Save Payroll Details"
        butSavePay.UseVisualStyleBackColor = True
        ' 
        ' txtBank
        ' 
        txtBank.Location = New Point(145, 84)
        txtBank.Margin = New Padding(3, 4, 3, 4)
        txtBank.Name = "txtBank"
        txtBank.Size = New Size(228, 27)
        txtBank.TabIndex = 10
        ' 
        ' txtPayAmount
        ' 
        txtPayAmount.Location = New Point(145, 144)
        txtPayAmount.Margin = New Padding(3, 4, 3, 4)
        txtPayAmount.Name = "txtPayAmount"
        txtPayAmount.Size = New Size(228, 27)
        txtPayAmount.TabIndex = 11
        ' 
        ' butSearchEmployee
        ' 
        butSearchEmployee.Location = New Point(983, 363)
        butSearchEmployee.Margin = New Padding(3, 4, 3, 4)
        butSearchEmployee.Name = "butSearchEmployee"
        butSearchEmployee.Size = New Size(207, 31)
        butSearchEmployee.TabIndex = 7
        butSearchEmployee.Text = "Search Employees/Payrolls"
        butSearchEmployee.UseVisualStyleBackColor = True
        ' 
        ' butDeleteEmployee
        ' 
        butDeleteEmployee.Location = New Point(735, 363)
        butDeleteEmployee.Margin = New Padding(3, 4, 3, 4)
        butDeleteEmployee.Name = "butDeleteEmployee"
        butDeleteEmployee.Size = New Size(206, 31)
        butDeleteEmployee.TabIndex = 8
        butDeleteEmployee.Text = "Delete Employees/Payroll"
        butDeleteEmployee.UseVisualStyleBackColor = True
        ' 
        ' butNewSlime
        ' 
        butNewSlime.Location = New Point(30, 24)
        butNewSlime.Margin = New Padding(3, 4, 3, 4)
        butNewSlime.Name = "butNewSlime"
        butNewSlime.Size = New Size(208, 31)
        butNewSlime.TabIndex = 9
        butNewSlime.Text = "Enter New Slime"
        butNewSlime.UseVisualStyleBackColor = True
        ' 
        ' butEmployeeMenu
        ' 
        butEmployeeMenu.Location = New Point(23, 67)
        butEmployeeMenu.Margin = New Padding(3, 4, 3, 4)
        butEmployeeMenu.Name = "butEmployeeMenu"
        butEmployeeMenu.Size = New Size(207, 31)
        butEmployeeMenu.TabIndex = 10
        butEmployeeMenu.Text = "Enter Employee Menu"
        butEmployeeMenu.UseVisualStyleBackColor = True
        ' 
        ' butOverview
        ' 
        butOverview.Location = New Point(22, 28)
        butOverview.Margin = New Padding(3, 4, 3, 4)
        butOverview.Name = "butOverview"
        butOverview.Size = New Size(208, 31)
        butOverview.TabIndex = 11
        butOverview.Text = "Overview All"
        butOverview.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(butOverview)
        GroupBox3.Controls.Add(butEmployeeMenu)
        GroupBox3.Location = New Point(442, 482)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(252, 116)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Overview"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(lblActivatorLimit)
        GroupBox4.Controls.Add(lblSlimeLimit)
        GroupBox4.Controls.Add(butViewSlimes)
        GroupBox4.Controls.Add(butSlimeLimit)
        GroupBox4.Controls.Add(butActivatorLimit)
        GroupBox4.Controls.Add(butNewSlime)
        GroupBox4.Controls.Add(butDeleteSlime)
        GroupBox4.Location = New Point(700, 420)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.Size = New Size(490, 236)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        GroupBox4.Text = "Slimes"
        ' 
        ' lblActivatorLimit
        ' 
        lblActivatorLimit.AutoSize = True
        lblActivatorLimit.Location = New Point(264, 181)
        lblActivatorLimit.Name = "lblActivatorLimit"
        lblActivatorLimit.Size = New Size(173, 20)
        lblActivatorLimit.TabIndex = 14
        lblActivatorLimit.Text = "Current Activator Limit: 0"
        ' 
        ' lblSlimeLimit
        ' 
        lblSlimeLimit.AutoSize = True
        lblSlimeLimit.Location = New Point(264, 142)
        lblSlimeLimit.Name = "lblSlimeLimit"
        lblSlimeLimit.Size = New Size(150, 20)
        lblSlimeLimit.TabIndex = 13
        lblSlimeLimit.Text = "Current Slime Limit: 0"
        ' 
        ' butViewSlimes
        ' 
        butViewSlimes.Location = New Point(264, 25)
        butViewSlimes.Name = "butViewSlimes"
        butViewSlimes.Size = New Size(207, 29)
        butViewSlimes.TabIndex = 12
        butViewSlimes.Text = "View Current Slimes"
        butViewSlimes.UseVisualStyleBackColor = True
        ' 
        ' butSlimeLimit
        ' 
        butSlimeLimit.Location = New Point(31, 138)
        butSlimeLimit.Name = "butSlimeLimit"
        butSlimeLimit.Size = New Size(207, 29)
        butSlimeLimit.TabIndex = 11
        butSlimeLimit.Text = "Change Slime Buying Limit"
        butSlimeLimit.UseVisualStyleBackColor = True
        ' 
        ' butActivatorLimit
        ' 
        butActivatorLimit.Location = New Point(21, 177)
        butActivatorLimit.Name = "butActivatorLimit"
        butActivatorLimit.Size = New Size(228, 29)
        butActivatorLimit.TabIndex = 10
        butActivatorLimit.Text = "Change Activator Buying Limit"
        butActivatorLimit.UseVisualStyleBackColor = True
        ' 
        ' rtbEmployeePayroll
        ' 
        rtbEmployeePayroll.Location = New Point(442, 212)
        rtbEmployeePayroll.Margin = New Padding(3, 4, 3, 4)
        rtbEmployeePayroll.Name = "rtbEmployeePayroll"
        rtbEmployeePayroll.Size = New Size(748, 144)
        rtbEmployeePayroll.TabIndex = 14
        rtbEmployeePayroll.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(442, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 20)
        Label1.TabIndex = 15
        Label1.Text = "Employee Payroll:"
        ' 
        ' comEmployeeID
        ' 
        comEmployeeID.FormattingEnabled = True
        comEmployeeID.Location = New Point(578, 365)
        comEmployeeID.Name = "comEmployeeID"
        comEmployeeID.Size = New Size(151, 28)
        comEmployeeID.TabIndex = 16
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(442, 366)
        Label12.Name = "Label12"
        Label12.Size = New Size(135, 20)
        Label12.TabIndex = 17
        Label12.Text = "Select ID to delete:"
        ' 
        ' Admin_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1202, 671)
        Controls.Add(Label12)
        Controls.Add(comEmployeeID)
        Controls.Add(Label1)
        Controls.Add(rtbEmployeePayroll)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(butDeleteEmployee)
        Controls.Add(butSearchEmployee)
        Controls.Add(GroupBox2)
        Controls.Add(Label2)
        Controls.Add(rtbCurrentEmployees)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Admin_Menu"
        Text = "Admin_Menu"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtbCurrentEmployees As RichTextBox
    Friend WithEvents txtPayFrequency As TextBox
    Friend WithEvents butDeleteSlime As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents butSearchEmployee As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents dtpDoB As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents butDeleteEmployee As Button
    Friend WithEvents butAddEmployee As Button
    Friend WithEvents butSavePay As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents txtBank As TextBox
    Friend WithEvents txtPayAmount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents butNewSlime As Button
    Friend WithEvents butEmployeeMenu As Button
    Friend WithEvents butOverview As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rtbEmployeePayroll As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comEmployeeID As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents butSlimeLimit As Button
    Friend WithEvents butActivatorLimit As Button
    Friend WithEvents lblActivatorLimit As Label
    Friend WithEvents lblSlimeLimit As Label
    Friend WithEvents butViewSlimes As Button
End Class
