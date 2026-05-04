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
        rtbRecipies = New RichTextBox()
        butSearchStock = New Button()
        butUpdateStock = New Button()
        Label2 = New Label()
        rtbStock = New RichTextBox()
        GroupBox3 = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        txtSupply = New TextBox()
        dtpDateDelivered = New DateTimePicker()
        butUpdateDelivery = New Button()
        txtEmployeeID = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(butSearchSales)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(rtbSales)
        GroupBox1.Location = New Point(12, 305)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(523, 268)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sales"
        ' 
        ' butSearchSales
        ' 
        butSearchSales.Location = New Point(184, 230)
        butSearchSales.Name = "butSearchSales"
        butSearchSales.Size = New Size(155, 29)
        butSearchSales.TabIndex = 4
        butSearchSales.Text = "Search Sales"
        butSearchSales.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 3
        Label1.Text = "Current Orders:"
        ' 
        ' rtbSales
        ' 
        rtbSales.Location = New Point(6, 45)
        rtbSales.Name = "rtbSales"
        rtbSales.Size = New Size(507, 179)
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
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(890, 279)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Stock"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(rtbRecipies)
        GroupBox4.Location = New Point(515, 93)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(358, 168)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Slime Recipies"
        ' 
        ' rtbRecipies
        ' 
        rtbRecipies.Location = New Point(18, 26)
        rtbRecipies.Name = "rtbRecipies"
        rtbRecipies.Size = New Size(323, 120)
        rtbRecipies.TabIndex = 0
        rtbRecipies.Text = ""
        ' 
        ' butSearchStock
        ' 
        butSearchStock.Location = New Point(724, 46)
        butSearchStock.Name = "butSearchStock"
        butSearchStock.Size = New Size(149, 29)
        butSearchStock.TabIndex = 4
        butSearchStock.Text = "Search Stock"
        butSearchStock.UseVisualStyleBackColor = True
        ' 
        ' butUpdateStock
        ' 
        butUpdateStock.Location = New Point(533, 46)
        butUpdateStock.Name = "butUpdateStock"
        butUpdateStock.Size = New Size(149, 29)
        butUpdateStock.TabIndex = 3
        butUpdateStock.Text = "Update Stock"
        butUpdateStock.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 1
        Label2.Text = "Current Stock"
        ' 
        ' rtbStock
        ' 
        rtbStock.Location = New Point(17, 47)
        rtbStock.Name = "rtbStock"
        rtbStock.Size = New Size(492, 214)
        rtbStock.TabIndex = 0
        rtbStock.Text = ""
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(txtSupply)
        GroupBox3.Controls.Add(dtpDateDelivered)
        GroupBox3.Controls.Add(butUpdateDelivery)
        GroupBox3.Controls.Add(txtEmployeeID)
        GroupBox3.Location = New Point(559, 305)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(343, 268)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "Deliveries"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(35, 184)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 20)
        Label6.TabIndex = 7
        Label6.Text = "(EmployeeID)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(33, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 20)
        Label5.TabIndex = 6
        Label5.Text = "Confirmed by:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(26, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 20)
        Label4.TabIndex = 5
        Label4.Text = "Date Delivered"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 56)
        Label3.Name = "Label3"
        Label3.Size = New Size(112, 20)
        Label3.TabIndex = 4
        Label3.Text = "Supply Delivery"
        ' 
        ' txtSupply
        ' 
        txtSupply.Location = New Point(141, 53)
        txtSupply.Name = "txtSupply"
        txtSupply.Size = New Size(185, 27)
        txtSupply.TabIndex = 3
        ' 
        ' dtpDateDelivered
        ' 
        dtpDateDelivered.Location = New Point(141, 109)
        dtpDateDelivered.Name = "dtpDateDelivered"
        dtpDateDelivered.Size = New Size(185, 27)
        dtpDateDelivered.TabIndex = 2
        ' 
        ' butUpdateDelivery
        ' 
        butUpdateDelivery.Location = New Point(95, 224)
        butUpdateDelivery.Name = "butUpdateDelivery"
        butUpdateDelivery.Size = New Size(155, 29)
        butUpdateDelivery.TabIndex = 1
        butUpdateDelivery.Text = "Update Delivery"
        butUpdateDelivery.UseVisualStyleBackColor = True
        ' 
        ' txtEmployeeID
        ' 
        txtEmployeeID.Location = New Point(141, 173)
        txtEmployeeID.Name = "txtEmployeeID"
        txtEmployeeID.Size = New Size(185, 27)
        txtEmployeeID.TabIndex = 0
        ' 
        ' Employee_Menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
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
End Class
