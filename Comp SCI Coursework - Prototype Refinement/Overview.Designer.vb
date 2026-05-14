<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Overview
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
        rtbEmployeInfo = New RichTextBox()
        rtbSimeRecipies = New RichTextBox()
        rtbSlimes = New RichTextBox()
        rtbStock = New RichTextBox()
        rtbSlimeLimit = New RichTextBox()
        rtbActivatorLimit = New RichTextBox()
        rtbCustomerOrders = New RichTextBox()
        rtbCustomerMailDetail = New RichTextBox()
        rtbCustomerInfo = New RichTextBox()
        rtbEmployeePayroll = New RichTextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        rtbDeliveries = New RichTextBox()
        butBack = New Button()
        SuspendLayout()
        ' 
        ' rtbEmployeInfo
        ' 
        rtbEmployeInfo.Location = New Point(12, 24)
        rtbEmployeInfo.Name = "rtbEmployeInfo"
        rtbEmployeInfo.Size = New Size(364, 96)
        rtbEmployeInfo.TabIndex = 0
        rtbEmployeInfo.Text = ""
        ' 
        ' rtbSimeRecipies
        ' 
        rtbSimeRecipies.Location = New Point(424, 491)
        rtbSimeRecipies.Name = "rtbSimeRecipies"
        rtbSimeRecipies.Size = New Size(364, 96)
        rtbSimeRecipies.TabIndex = 1
        rtbSimeRecipies.Text = ""
        ' 
        ' rtbSlimes
        ' 
        rtbSlimes.Location = New Point(12, 491)
        rtbSlimes.Name = "rtbSlimes"
        rtbSlimes.Size = New Size(364, 96)
        rtbSlimes.TabIndex = 2
        rtbSlimes.Text = ""
        ' 
        ' rtbStock
        ' 
        rtbStock.Location = New Point(424, 375)
        rtbStock.Name = "rtbStock"
        rtbStock.Size = New Size(364, 96)
        rtbStock.TabIndex = 3
        rtbStock.Text = ""
        ' 
        ' rtbSlimeLimit
        ' 
        rtbSlimeLimit.Location = New Point(12, 375)
        rtbSlimeLimit.Name = "rtbSlimeLimit"
        rtbSlimeLimit.Size = New Size(364, 96)
        rtbSlimeLimit.TabIndex = 4
        rtbSlimeLimit.Text = ""
        ' 
        ' rtbActivatorLimit
        ' 
        rtbActivatorLimit.Location = New Point(424, 258)
        rtbActivatorLimit.Name = "rtbActivatorLimit"
        rtbActivatorLimit.Size = New Size(364, 96)
        rtbActivatorLimit.TabIndex = 5
        rtbActivatorLimit.Text = ""
        ' 
        ' rtbCustomerOrders
        ' 
        rtbCustomerOrders.Location = New Point(12, 258)
        rtbCustomerOrders.Name = "rtbCustomerOrders"
        rtbCustomerOrders.Size = New Size(364, 96)
        rtbCustomerOrders.TabIndex = 6
        rtbCustomerOrders.Text = ""
        ' 
        ' rtbCustomerMailDetail
        ' 
        rtbCustomerMailDetail.Location = New Point(424, 141)
        rtbCustomerMailDetail.Name = "rtbCustomerMailDetail"
        rtbCustomerMailDetail.Size = New Size(364, 96)
        rtbCustomerMailDetail.TabIndex = 7
        rtbCustomerMailDetail.Text = ""
        ' 
        ' rtbCustomerInfo
        ' 
        rtbCustomerInfo.Location = New Point(12, 141)
        rtbCustomerInfo.Name = "rtbCustomerInfo"
        rtbCustomerInfo.Size = New Size(364, 96)
        rtbCustomerInfo.TabIndex = 8
        rtbCustomerInfo.Text = ""
        ' 
        ' rtbEmployeePayroll
        ' 
        rtbEmployeePayroll.Location = New Point(424, 24)
        rtbEmployeePayroll.Name = "rtbEmployeePayroll"
        rtbEmployeePayroll.Size = New Size(364, 96)
        rtbEmployeePayroll.TabIndex = 9
        rtbEmployeePayroll.Text = ""
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(424, 240)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 15)
        Label1.TabIndex = 10
        Label1.Text = "ActivatorLimit"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 474)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 11
        Label2.Text = "Slimes"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(424, 474)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 15)
        Label3.TabIndex = 12
        Label3.Text = "SlimeRecipies"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 357)
        Label4.Name = "Label4"
        Label4.Size = New Size(63, 15)
        Label4.TabIndex = 13
        Label4.Text = "SlimeLimit"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(424, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 15)
        Label5.TabIndex = 14
        Label5.Text = "EmployeePayroll"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 590)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 15
        Label6.Text = "Deliveries"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(94, 15)
        Label7.TabIndex = 16
        Label7.Text = "CustomerOrders"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(424, 123)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 15)
        Label8.TabIndex = 17
        Label8.Text = "CustomerMailDetail"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 123)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 15)
        Label9.TabIndex = 18
        Label9.Text = "CustomerInfo"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 6)
        Label10.Name = "Label10"
        Label10.Size = New Size(80, 15)
        Label10.TabIndex = 19
        Label10.Text = "EmployeeInfo"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(424, 357)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 15)
        Label11.TabIndex = 20
        Label11.Text = "Stock"
        ' 
        ' rtbDeliveries
        ' 
        rtbDeliveries.Location = New Point(12, 608)
        rtbDeliveries.Name = "rtbDeliveries"
        rtbDeliveries.Size = New Size(364, 96)
        rtbDeliveries.TabIndex = 21
        rtbDeliveries.Text = ""
        ' 
        ' butBack
        ' 
        butBack.Location = New Point(629, 642)
        butBack.Name = "butBack"
        butBack.Size = New Size(159, 61)
        butBack.TabIndex = 22
        butBack.Text = "Back"
        butBack.UseVisualStyleBackColor = True
        ' 
        ' Overview
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(800, 715)
        Controls.Add(butBack)
        Controls.Add(rtbDeliveries)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(rtbEmployeePayroll)
        Controls.Add(rtbCustomerInfo)
        Controls.Add(rtbCustomerMailDetail)
        Controls.Add(rtbCustomerOrders)
        Controls.Add(rtbActivatorLimit)
        Controls.Add(rtbSlimeLimit)
        Controls.Add(rtbStock)
        Controls.Add(rtbSlimes)
        Controls.Add(rtbSimeRecipies)
        Controls.Add(rtbEmployeInfo)
        Name = "Overview"
        Text = "Overview"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rtbEmployeInfo As RichTextBox
    Friend WithEvents rtbSimeRecipies As RichTextBox
    Friend WithEvents rtbSlimes As RichTextBox
    Friend WithEvents rtbStock As RichTextBox
    Friend WithEvents rtbSlimeLimit As RichTextBox
    Friend WithEvents rtbActivatorLimit As RichTextBox
    Friend WithEvents rtbCustomerOrders As RichTextBox
    Friend WithEvents rtbCustomerMailDetail As RichTextBox
    Friend WithEvents rtbCustomerInfo As RichTextBox
    Friend WithEvents rtbEmployeePayroll As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents rtbDeliveries As RichTextBox
    Friend WithEvents butBack As Button
End Class
