<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_Sign_Up
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
        ButBack = New Button()
        ButSave = New Button()
        GroupBox2 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        GroupBox3 = New GroupBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        txtPostcode = New TextBox()
        txtStreet = New TextBox()
        txtTown = New TextBox()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        dtpDoB = New DateTimePicker()
        txtFName = New TextBox()
        txtSName = New TextBox()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButBack
        ' 
        ButBack.Location = New Point(341, 494)
        ButBack.Name = "ButBack"
        ButBack.Size = New Size(75, 23)
        ButBack.TabIndex = 16
        ButBack.Text = "Back"
        ButBack.UseVisualStyleBackColor = True
        ' 
        ' ButSave
        ' 
        ButSave.Location = New Point(12, 476)
        ButSave.Name = "ButSave"
        ButSave.Size = New Size(164, 41)
        ButSave.TabIndex = 15
        ButSave.Text = "Save and Sign Up!"
        ButSave.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(txtEmail)
        GroupBox2.Controls.Add(txtPhoneNum)
        GroupBox2.Location = New Point(12, 167)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(404, 132)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Text = "Contact Information"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(62, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 15)
        Label5.TabIndex = 14
        Label5.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 13
        Label4.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(166, 42)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 23)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(166, 71)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(200, 23)
        txtPhoneNum.TabIndex = 4
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(txtPostcode)
        GroupBox3.Controls.Add(txtStreet)
        GroupBox3.Controls.Add(txtTown)
        GroupBox3.Location = New Point(12, 305)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(404, 153)
        GroupBox3.TabIndex = 14
        GroupBox3.TabStop = False
        GroupBox3.Text = "Mailing Details"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(62, 101)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 15)
        Label8.TabIndex = 17
        Label8.Text = "Postcode"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(62, 72)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 16
        Label7.Text = "Town"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(62, 43)
        Label6.Name = "Label6"
        Label6.Size = New Size(37, 15)
        Label6.TabIndex = 15
        Label6.Text = "Street"
        ' 
        ' txtPostcode
        ' 
        txtPostcode.Location = New Point(166, 98)
        txtPostcode.Name = "txtPostcode"
        txtPostcode.Size = New Size(200, 23)
        txtPostcode.TabIndex = 3
        ' 
        ' txtStreet
        ' 
        txtStreet.Location = New Point(166, 40)
        txtStreet.Name = "txtStreet"
        txtStreet.Size = New Size(200, 23)
        txtStreet.TabIndex = 2
        ' 
        ' txtTown
        ' 
        txtTown.Location = New Point(166, 69)
        txtTown.Name = "txtTown"
        txtTown.Size = New Size(200, 23)
        txtTown.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(dtpDoB)
        GroupBox1.Controls.Add(txtFName)
        GroupBox1.Controls.Add(txtSName)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(404, 149)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Personal Information"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(62, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 12
        Label3.Text = "Date Of Birth"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 66)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 11
        Label2.Text = "Surname"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 10
        Label1.Text = "First Name"
        ' 
        ' dtpDoB
        ' 
        dtpDoB.Location = New Point(166, 92)
        dtpDoB.Name = "dtpDoB"
        dtpDoB.Size = New Size(200, 23)
        dtpDoB.TabIndex = 9
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(166, 34)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(200, 23)
        txtFName.TabIndex = 7
        ' 
        ' txtSName
        ' 
        txtSName.Location = New Point(166, 63)
        txtSName.Name = "txtSName"
        txtSName.Size = New Size(200, 23)
        txtSName.TabIndex = 6
        ' 
        ' Customer_Sign_Up
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(433, 525)
        Controls.Add(ButBack)
        Controls.Add(ButSave)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Name = "Customer_Sign_Up"
        Text = "Customer_Sign_Up"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButBack As Button
    Friend WithEvents ButSave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPostcode As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents txtTown As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDoB As DateTimePicker
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtSName As TextBox
End Class
