<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_Menu))
        lblSlimeType = New Label()
        butOrder = New Button()
        txtCustomerID = New TextBox()
        comSlimeType = New ComboBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox1 = New GroupBox()
        butorderorwhatdgfdf = New Button()
        rbOrderBoth = New RadioButton()
        rbOnlyActivator = New RadioButton()
        rbOnlySlime = New RadioButton()
        lblDisclaimer = New Label()
        Label4 = New Label()
        lblActivatorAmount = New Label()
        lblSlimeAmount = New Label()
        comActivatorAmount = New ComboBox()
        comSlimeAmount = New ComboBox()
        butSearchOrder = New Button()
        lblForgotID = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblSlimeType
        ' 
        lblSlimeType.AutoSize = True
        lblSlimeType.Location = New Point(94, 76)
        lblSlimeType.Name = "lblSlimeType"
        lblSlimeType.Size = New Size(64, 15)
        lblSlimeType.TabIndex = 0
        lblSlimeType.Text = "Slime Type"
        ' 
        ' butOrder
        ' 
        butOrder.Location = New Point(37, 226)
        butOrder.Name = "butOrder"
        butOrder.Size = New Size(121, 23)
        butOrder.TabIndex = 1
        butOrder.Text = "Place Order"
        butOrder.UseVisualStyleBackColor = True
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Location = New Point(164, 179)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(242, 23)
        txtCustomerID.TabIndex = 2
        ' 
        ' comSlimeType
        ' 
        comSlimeType.FormattingEnabled = True
        comSlimeType.Location = New Point(164, 73)
        comSlimeType.Name = "comSlimeType"
        comSlimeType.Size = New Size(242, 23)
        comSlimeType.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(457, 69)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(475, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(315, 370)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(butorderorwhatdgfdf)
        GroupBox1.Controls.Add(rbOrderBoth)
        GroupBox1.Controls.Add(rbOnlyActivator)
        GroupBox1.Controls.Add(rbOnlySlime)
        GroupBox1.Controls.Add(lblDisclaimer)
        GroupBox1.Controls.Add(butOrder)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(lblActivatorAmount)
        GroupBox1.Controls.Add(lblSlimeAmount)
        GroupBox1.Controls.Add(comActivatorAmount)
        GroupBox1.Controls.Add(comSlimeAmount)
        GroupBox1.Controls.Add(comSlimeType)
        GroupBox1.Controls.Add(lblSlimeType)
        GroupBox1.Controls.Add(txtCustomerID)
        GroupBox1.Location = New Point(12, 87)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(457, 255)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Place An Order!"
        ' 
        ' butorderorwhatdgfdf
        ' 
        butorderorwhatdgfdf.Location = New Point(216, 226)
        butorderorwhatdgfdf.Name = "butorderorwhatdgfdf"
        butorderorwhatdgfdf.Size = New Size(214, 23)
        butorderorwhatdgfdf.TabIndex = 17
        butorderorwhatdgfdf.Text = "Place Order vfcvcxv"
        butorderorwhatdgfdf.UseVisualStyleBackColor = True
        ' 
        ' rbOrderBoth
        ' 
        rbOrderBoth.AutoSize = True
        rbOrderBoth.Location = New Point(323, 35)
        rbOrderBoth.Name = "rbOrderBoth"
        rbOrderBoth.Size = New Size(83, 19)
        rbOrderBoth.TabIndex = 16
        rbOrderBoth.TabStop = True
        rbOrderBoth.Text = "Order Both"
        rbOrderBoth.UseVisualStyleBackColor = True
        ' 
        ' rbOnlyActivator
        ' 
        rbOnlyActivator.AutoSize = True
        rbOnlyActivator.Location = New Point(183, 35)
        rbOnlyActivator.Name = "rbOnlyActivator"
        rbOnlyActivator.Size = New Size(134, 19)
        rbOnlyActivator.TabIndex = 15
        rbOnlyActivator.TabStop = True
        rbOnlyActivator.Text = "Order Only Activator"
        rbOnlyActivator.UseVisualStyleBackColor = True
        ' 
        ' rbOnlySlime
        ' 
        rbOnlySlime.AutoSize = True
        rbOnlySlime.Location = New Point(62, 35)
        rbOnlySlime.Name = "rbOnlySlime"
        rbOnlySlime.Size = New Size(115, 19)
        rbOnlySlime.TabIndex = 14
        rbOnlySlime.TabStop = True
        rbOnlySlime.Text = "Order Only Slime"
        rbOnlySlime.UseVisualStyleBackColor = True
        ' 
        ' lblDisclaimer
        ' 
        lblDisclaimer.AutoSize = True
        lblDisclaimer.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblDisclaimer.Location = New Point(37, 108)
        lblDisclaimer.Name = "lblDisclaimer"
        lblDisclaimer.Size = New Size(393, 17)
        lblDisclaimer.TabIndex = 13
        lblDisclaimer.Text = "Select what you would like to order at the top to see specifics!"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 8
        Label4.Text = "Your Customer ID"
        ' 
        ' lblActivatorAmount
        ' 
        lblActivatorAmount.AutoSize = True
        lblActivatorAmount.Location = New Point(56, 153)
        lblActivatorAmount.Name = "lblActivatorAmount"
        lblActivatorAmount.Size = New Size(102, 15)
        lblActivatorAmount.TabIndex = 7
        lblActivatorAmount.Text = "Activator Amount"
        ' 
        ' lblSlimeAmount
        ' 
        lblSlimeAmount.AutoSize = True
        lblSlimeAmount.Location = New Point(61, 105)
        lblSlimeAmount.Name = "lblSlimeAmount"
        lblSlimeAmount.Size = New Size(97, 15)
        lblSlimeAmount.TabIndex = 6
        lblSlimeAmount.Text = "Amount of Slime"
        ' 
        ' comActivatorAmount
        ' 
        comActivatorAmount.FormattingEnabled = True
        comActivatorAmount.Location = New Point(164, 150)
        comActivatorAmount.Name = "comActivatorAmount"
        comActivatorAmount.Size = New Size(242, 23)
        comActivatorAmount.TabIndex = 5
        ' 
        ' comSlimeAmount
        ' 
        comSlimeAmount.FormattingEnabled = True
        comSlimeAmount.Location = New Point(164, 102)
        comSlimeAmount.Name = "comSlimeAmount"
        comSlimeAmount.Size = New Size(242, 23)
        comSlimeAmount.TabIndex = 4
        ' 
        ' butSearchOrder
        ' 
        butSearchOrder.Location = New Point(311, 348)
        butSearchOrder.Name = "butSearchOrder"
        butSearchOrder.Size = New Size(158, 34)
        butSearchOrder.TabIndex = 7
        butSearchOrder.Text = "Search Your Order"
        butSearchOrder.UseVisualStyleBackColor = True
        ' 
        ' lblForgotID
        ' 
        lblForgotID.Font = New Font("Segoe UI", 8.25F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblForgotID.ForeColor = SystemColors.Highlight
        lblForgotID.Location = New Point(12, 350)
        lblForgotID.Name = "lblForgotID"
        lblForgotID.Size = New Size(293, 34)
        lblForgotID.TabIndex = 8
        lblForgotID.Text = "Your Customer ID will automatically link your shipping details! (Click Here if you dont remember your ID!)"
        ' 
        ' Customer_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 393)
        Controls.Add(lblForgotID)
        Controls.Add(butSearchOrder)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Customer_Menu"
        Text = "Customer_Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblSlimeType As Label
    Friend WithEvents butOrder As Button
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents comSlimeType As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblActivatorAmount As Label
    Friend WithEvents lblSlimeAmount As Label
    Friend WithEvents comActivatorAmount As ComboBox
    Friend WithEvents comSlimeAmount As ComboBox
    Friend WithEvents butSearchOrder As Button
    Friend WithEvents lblForgotID As Label
    Friend WithEvents lblDisclaimer As Label
    Friend WithEvents rbOnlySlime As RadioButton
    Friend WithEvents rbOrderBoth As RadioButton
    Friend WithEvents rbOnlyActivator As RadioButton
    Friend WithEvents butorderorwhatdgfdf As Button
End Class
