<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Menu
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
        butSearchSales = New Button()
        Label1 = New Label()
        rtbSales = New RichTextBox()
        GroupBox2 = New GroupBox()
        GroupBox4 = New GroupBox()
        butSearchSlime = New Button()
        rtbRecipies = New RichTextBox()
        butSearchStock = New Button()
        butUpdateStock = New Button()
        Label2 = New Label()
        rtbStock = New RichTextBox()
        GroupBox3 = New GroupBox()
        butSearchDelivery = New Button()
        Label7 = New Label()
        rtbDeliveries = New RichTextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtSupply = New TextBox()
        dtpDateDelivered = New DateTimePicker()
        butUpdateDelivery = New Button()
        txtEmployeeID = New TextBox()
        butConfirmOrder = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(butConfirmOrder)
        GroupBox1.Controls.Add(butSearchSales)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(rtbSales)
        GroupBox1.Location = New Point(10, 229)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(458, 201)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sales"
        ' 
        ' butSearchSales
        ' 
        butSearchSales.Location = New Point(42, 173)
        butSearchSales.Margin = New Padding(3, 2, 3, 2)
        butSearchSales.Name = "butSearchSales"
        butSearchSales.Size = New Size(136, 22)
        butSearchSales.TabIndex = 4
        butSearchSales.Text = "Search Sales"
        butSearchSales.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(5, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 15)
        Label1.TabIndex = 3
        Label1.Text = "Current Orders:"
        ' 
        ' rtbSales
        ' 
        rtbSales.Location = New Point(5, 34)
        rtbSales.Margin = New Padding(3, 2, 3, 2)
        rtbSales.Name = "rtbSales"
        rtbSales.Size = New Size(444, 135)
        rtbSales.TabIndex = 2
        rtbSales.Text = ""
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox4)
        GroupBox2.Controls.Add(butSearchStock)
        GroupBox2.Controls.Add(butUpdateStock)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(rtbStock)
        GroupBox2.Location = New Point(10, 9)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(1026, 209)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Stock"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(butSearchSlime)
        GroupBox4.Controls.Add(rtbRecipies)
        GroupBox4.Location = New Point(557, 70)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(453, 126)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Slime Recipies"
        ' 
        ' butSearchSlime
        ' 
        butSearchSlime.Location = New Point(303, 55)
        butSearchSlime.Margin = New Padding(3, 2, 3, 2)
        butSearchSlime.Name = "butSearchSlime"
        butSearchSlime.Size = New Size(145, 22)
        butSearchSlime.TabIndex = 1
        butSearchSlime.Text = "Search Slime Recipies"
        butSearchSlime.UseVisualStyleBackColor = True
        ' 
        ' rtbRecipies
        ' 
        rtbRecipies.Location = New Point(16, 20)
        rtbRecipies.Margin = New Padding(3, 2, 3, 2)
        rtbRecipies.Name = "rtbRecipies"
        rtbRecipies.Size = New Size(283, 96)
        rtbRecipies.TabIndex = 0
        rtbRecipies.Text = ""
        ' 
        ' butSearchStock
        ' 
        butSearchStock.Location = New Point(799, 34)
        butSearchStock.Margin = New Padding(3, 2, 3, 2)
        butSearchStock.Name = "butSearchStock"
        butSearchStock.Size = New Size(212, 22)
        butSearchStock.TabIndex = 4
        butSearchStock.Text = "Search Stock"
        butSearchStock.UseVisualStyleBackColor = True
        ' 
        ' butUpdateStock
        ' 
        butUpdateStock.Location = New Point(573, 35)
        butUpdateStock.Margin = New Padding(3, 2, 3, 2)
        butUpdateStock.Name = "butUpdateStock"
        butUpdateStock.Size = New Size(212, 22)
        butUpdateStock.TabIndex = 3
        butUpdateStock.Text = "Update Stock"
        butUpdateStock.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 15)
        Label2.TabIndex = 1
        Label2.Text = "Current Stock"
        ' 
        ' rtbStock
        ' 
        rtbStock.Location = New Point(15, 35)
        rtbStock.Margin = New Padding(3, 2, 3, 2)
        rtbStock.Name = "rtbStock"
        rtbStock.Size = New Size(538, 162)
        rtbStock.TabIndex = 0
        rtbStock.Text = ""
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(butSearchDelivery)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(rtbDeliveries)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(txtSupply)
        GroupBox3.Controls.Add(dtpDateDelivered)
        GroupBox3.Controls.Add(butUpdateDelivery)
        GroupBox3.Controls.Add(txtEmployeeID)
        GroupBox3.Location = New Point(489, 229)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(548, 201)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Deliveries"
        ' 
        ' butSearchDelivery
        ' 
        butSearchDelivery.Location = New Point(161, 168)
        butSearchDelivery.Margin = New Padding(3, 2, 3, 2)
        butSearchDelivery.Name = "butSearchDelivery"
        butSearchDelivery.Size = New Size(124, 22)
        butSearchDelivery.TabIndex = 10
        butSearchDelivery.Text = "Search Delivery"
        butSearchDelivery.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(312, 16)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 15)
        Label7.TabIndex = 9
        Label7.Text = "Deliveries:"
        ' 
        ' rtbDeliveries
        ' 
        rtbDeliveries.Location = New Point(312, 34)
        rtbDeliveries.Margin = New Padding(3, 2, 3, 2)
        rtbDeliveries.Name = "rtbDeliveries"
        rtbDeliveries.Size = New Size(220, 157)
        rtbDeliveries.TabIndex = 8
        rtbDeliveries.Text = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 138)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 15)
        Label6.TabIndex = 7
        Label6.Text = "(EmployeeID)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 6
        Label5.Text = "Confirmed by:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 15)
        Label4.TabIndex = 5
        Label4.Text = "Date Delivered"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 15)
        Label3.TabIndex = 4
        Label3.Text = "Supply Delivery"
        ' 
        ' txtSupply
        ' 
        txtSupply.Location = New Point(123, 40)
        txtSupply.Margin = New Padding(3, 2, 3, 2)
        txtSupply.Name = "txtSupply"
        txtSupply.Size = New Size(162, 23)
        txtSupply.TabIndex = 3
        ' 
        ' dtpDateDelivered
        ' 
        dtpDateDelivered.Location = New Point(123, 82)
        dtpDateDelivered.Margin = New Padding(3, 2, 3, 2)
        dtpDateDelivered.Name = "dtpDateDelivered"
        dtpDateDelivered.Size = New Size(162, 23)
        dtpDateDelivered.TabIndex = 2
        ' 
        ' butUpdateDelivery
        ' 
        butUpdateDelivery.Location = New Point(20, 168)
        butUpdateDelivery.Margin = New Padding(3, 2, 3, 2)
        butUpdateDelivery.Name = "butUpdateDelivery"
        butUpdateDelivery.Size = New Size(124, 22)
        butUpdateDelivery.TabIndex = 1
        butUpdateDelivery.Text = "Update Delivery"
        butUpdateDelivery.UseVisualStyleBackColor = True
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(123, 130)
        txtEmployeeID.Margin = New Padding(3, 2, 3, 2)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(162, 23)
        txtEmployeeID.TabIndex = 0
        ' 
        ' butConfirmOrder
        ' 
        butConfirmOrder.Location = New Point(272, 172)
        butConfirmOrder.Name = "butConfirmOrder"
        butConfirmOrder.Size = New Size(136, 23)
        butConfirmOrder.TabIndex = 5
        butConfirmOrder.Text = "Confirm Order"
        butConfirmOrder.UseVisualStyleBackColor = True
        ' 
        ' Employee_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1047, 450)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Name = "Employee_Menu"
        Text = "Employee_Menu"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rtbSales As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDateDelivered As DateTimePicker
    Friend WithEvents butUpdateDelivery As Button
    Friend WithEvents txtEmployeeID As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rtbRecipies As RichTextBox
    Friend WithEvents butSearchStock As Button
    Friend WithEvents butUpdateStock As Button
    Friend WithEvents txtSupply As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rtbStock As RichTextBox
    Friend WithEvents butSearchSales As Button
    Friend WithEvents butSearchSlime As Button
    Friend WithEvents butSearchDelivery As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents rtbDeliveries As RichTextBox
    Friend WithEvents butConfirmOrder As Button
End Class
