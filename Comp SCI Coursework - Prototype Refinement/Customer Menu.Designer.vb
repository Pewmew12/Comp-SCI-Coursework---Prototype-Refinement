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
        Label1 = New Label()
        butOrder = New Button()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox1 = New GroupBox()
        clbOrderWhat = New CheckedListBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        ComboBox3 = New ComboBox()
        ComboBox2 = New ComboBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "Slime Type"
        ' 
        ' butOrder
        ' 
        butOrder.Location = New Point(164, 252)
        butOrder.Name = "butOrder"
        butOrder.Size = New Size(121, 23)
        butOrder.TabIndex = 1
        butOrder.Text = "Place Order"
        butOrder.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(164, 212)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(242, 23)
        TextBox1.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(164, 106)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(242, 23)
        ComboBox1.TabIndex = 3
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
        PictureBox2.Location = New Point(475, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(315, 370)
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(clbOrderWhat)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(butOrder)
        GroupBox1.Location = New Point(12, 87)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(457, 295)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "Place An Order!"
        ' 
        ' clbOrderWhat
        ' 
        clbOrderWhat.FormattingEnabled = True
        clbOrderWhat.Items.AddRange(New Object() {"Order Only Slime", "Order Only Activator", "Order Both"})
        clbOrderWhat.Location = New Point(16, 31)
        clbOrderWhat.Name = "clbOrderWhat"
        clbOrderWhat.Size = New Size(142, 58)
        clbOrderWhat.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(58, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 15)
        Label4.TabIndex = 8
        Label4.Text = "Your Customer ID"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(56, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 15)
        Label3.TabIndex = 7
        Label3.Text = "Activator Amount"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 6
        Label2.Text = "Amount of Slime"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(164, 183)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(242, 23)
        ComboBox3.TabIndex = 5
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(164, 135)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(242, 23)
        ComboBox2.TabIndex = 4
        ' 
        ' Customer_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 393)
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

    Friend WithEvents Label1 As Label
    Friend WithEvents butOrder As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clbOrderWhat As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
