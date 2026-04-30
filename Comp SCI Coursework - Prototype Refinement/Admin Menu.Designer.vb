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
        butEditDeleteEmployee = New Button()
        butNewSlime = New Button()
        butEmployeeMenu = New Button()
        butOverview = New Button()
        GroupBox3 = New GroupBox()
        GroupBox4 = New GroupBox()
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
        GroupBox1.Location = New Point(12, 13)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(369, 259)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Add Employee"
        ' 
        ' butAddEmployee
        ' 
        butAddEmployee.Location = New Point(96, 215)
        butAddEmployee.Name = "butAddEmployee"
        butAddEmployee.Size = New Size(181, 23)
        butAddEmployee.TabIndex = 9
        butAddEmployee.Text = "Save and Add Employee"
        butAddEmployee.UseVisualStyleBackColor = True
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(127, 146)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 23)
        txtEmail.TabIndex = 9
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(127, 40)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(200, 23)
        txtFName.TabIndex = 10
        ' 
        ' txtSName
        ' 
        txtSName.Location = New Point(127, 69)
        txtSName.Name = "txtSName"
        txtSName.Size = New Size(200, 23)
        txtSName.TabIndex = 11
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(127, 175)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(200, 23)
        txtPhoneNumber.TabIndex = 12
        ' 
        ' dtpDoB
        ' 
        dtpDoB.Location = New Point(127, 98)
        dtpDoB.Name = "dtpDoB"
        dtpDoB.Size = New Size(200, 23)
        dtpDoB.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(85, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 104)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 11
        Label5.Text = "Date of Birth"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(33, 178)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 15)
        Label6.TabIndex = 12
        Label6.Text = "Phone Number"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(67, 72)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 15)
        Label7.TabIndex = 13
        Label7.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(57, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 15)
        Label3.TabIndex = 9
        Label3.Text = "First Name"
        ' 
        ' rtbCurrentEmployees
        ' 
        rtbCurrentEmployees.Location = New Point(387, 27)
        rtbCurrentEmployees.Name = "rtbCurrentEmployees"
        rtbCurrentEmployees.Size = New Size(369, 245)
        rtbCurrentEmployees.TabIndex = 1
        rtbCurrentEmployees.Text = ""
        ' 
        ' txtPayFrequency
        ' 
        txtPayFrequency.Location = New Point(127, 137)
        txtPayFrequency.Name = "txtPayFrequency"
        txtPayFrequency.Size = New Size(200, 23)
        txtPayFrequency.TabIndex = 2
        ' 
        ' butDeleteSlime
        ' 
        butDeleteSlime.Location = New Point(95, 51)
        butDeleteSlime.Name = "butDeleteSlime"
        butDeleteSlime.Size = New Size(181, 23)
        butDeleteSlime.TabIndex = 3
        butDeleteSlime.Text = "Delete Slime"
        butDeleteSlime.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(387, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 15)
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
        GroupBox2.Location = New Point(12, 278)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(369, 214)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Edit/Add Payroll"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(20, 140)
        Label11.Name = "Label11"
        Label11.Size = New Size(101, 15)
        Label11.TabIndex = 14
        Label11.Text = "Payroll Frequency"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(31, 111)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 15)
        Label10.TabIndex = 13
        Label10.Text = "Payroll Amount"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(85, 66)
        Label9.Name = "Label9"
        Label9.Size = New Size(36, 15)
        Label9.TabIndex = 12
        Label9.Tag = ""
        Label9.Text = "Bank:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(51, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 15)
        Label8.TabIndex = 9
        Label8.Text = "EmployeeID"
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(127, 34)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(200, 23)
        txtEmployeeID.TabIndex = 9
        ' 
        ' butSavePay
        ' 
        butSavePay.Location = New Point(96, 175)
        butSavePay.Name = "butSavePay"
        butSavePay.Size = New Size(181, 23)
        butSavePay.TabIndex = 9
        butSavePay.Text = "Save Payroll Details"
        butSavePay.UseVisualStyleBackColor = True
        ' 
        ' txtBank
        ' 
        txtBank.Location = New Point(127, 63)
        txtBank.Name = "txtBank"
        txtBank.Size = New Size(200, 23)
        txtBank.TabIndex = 10
        ' 
        ' txtPayAmount
        ' 
        txtPayAmount.Location = New Point(127, 108)
        txtPayAmount.Name = "txtPayAmount"
        txtPayAmount.Size = New Size(200, 23)
        txtPayAmount.TabIndex = 11
        ' 
        ' butSearchEmployee
        ' 
        butSearchEmployee.Location = New Point(575, 278)
        butSearchEmployee.Name = "butSearchEmployee"
        butSearchEmployee.Size = New Size(181, 23)
        butSearchEmployee.TabIndex = 7
        butSearchEmployee.Text = "Search Employees"
        butSearchEmployee.UseVisualStyleBackColor = True
        ' 
        ' butEditDeleteEmployee
        ' 
        butEditDeleteEmployee.Location = New Point(387, 278)
        butEditDeleteEmployee.Name = "butEditDeleteEmployee"
        butEditDeleteEmployee.Size = New Size(182, 23)
        butEditDeleteEmployee.TabIndex = 8
        butEditDeleteEmployee.Text = "Edit/Delete Employees"
        butEditDeleteEmployee.UseVisualStyleBackColor = True
        ' 
        ' butNewSlime
        ' 
        butNewSlime.Location = New Point(95, 22)
        butNewSlime.Name = "butNewSlime"
        butNewSlime.Size = New Size(182, 23)
        butNewSlime.TabIndex = 9
        butNewSlime.Text = "Enter New Slime"
        butNewSlime.UseVisualStyleBackColor = True
        ' 
        ' butEmployeeMenu
        ' 
        butEmployeeMenu.Location = New Point(96, 51)
        butEmployeeMenu.Name = "butEmployeeMenu"
        butEmployeeMenu.Size = New Size(181, 23)
        butEmployeeMenu.TabIndex = 10
        butEmployeeMenu.Text = "Enter Employee Menu"
        butEmployeeMenu.UseVisualStyleBackColor = True
        ' 
        ' butOverview
        ' 
        butOverview.Location = New Point(95, 22)
        butOverview.Name = "butOverview"
        butOverview.Size = New Size(182, 23)
        butOverview.TabIndex = 11
        butOverview.Text = "Overview All"
        butOverview.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(butOverview)
        GroupBox3.Controls.Add(butEmployeeMenu)
        GroupBox3.Location = New Point(387, 312)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(369, 87)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Overview"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(butNewSlime)
        GroupBox4.Controls.Add(butDeleteSlime)
        GroupBox4.Location = New Point(387, 405)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(369, 87)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        GroupBox4.Text = "Slimes"
        ' 
        ' Admin_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(768, 503)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(butEditDeleteEmployee)
        Controls.Add(butSearchEmployee)
        Controls.Add(GroupBox2)
        Controls.Add(Label2)
        Controls.Add(rtbCurrentEmployees)
        Controls.Add(GroupBox1)
        Name = "Admin_Menu"
        Text = "Admin_Menu"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
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
    Friend WithEvents butEditDeleteEmployee As Button
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
End Class
