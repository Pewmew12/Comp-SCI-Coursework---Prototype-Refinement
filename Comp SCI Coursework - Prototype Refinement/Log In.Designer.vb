<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log_In
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
        Label1 = New Label()
        butLogin = New Button()
        txtFName = New TextBox()
        txtSName = New TextBox()
        txtID = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        butBack = New Button()
        Label4 = New Label()
        lblNotMem = New Label()
        lblForgotID = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(92, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 15)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' butLogin
        ' 
        butLogin.Location = New Point(92, 218)
        butLogin.Name = "butLogin"
        butLogin.Size = New Size(137, 23)
        butLogin.TabIndex = 1
        butLogin.Text = "Log In"
        butLogin.UseVisualStyleBackColor = True
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(228, 78)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(238, 23)
        txtFName.TabIndex = 2
        ' 
        ' txtSName
        ' 
        txtSName.Location = New Point(228, 107)
        txtSName.Name = "txtSName"
        txtSName.Size = New Size(238, 23)
        txtSName.TabIndex = 3
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(228, 167)
        txtID.Name = "txtID"
        txtID.Size = New Size(238, 23)
        txtID.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(92, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 5
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(92, 170)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 6
        Label3.Text = "Your ID"
        ' 
        ' butBack
        ' 
        butBack.Location = New Point(391, 218)
        butBack.Name = "butBack"
        butBack.Size = New Size(75, 23)
        butBack.TabIndex = 7
        butBack.Text = "Back"
        butBack.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Snap ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(121, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(318, 27)
        Label4.TabIndex = 8
        Label4.Text = "Welcome to Angel Slimes!"
        ' 
        ' lblNotMem
        ' 
        lblNotMem.AutoSize = True
        lblNotMem.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblNotMem.ForeColor = SystemColors.Highlight
        lblNotMem.Location = New Point(12, 268)
        lblNotMem.Name = "lblNotMem"
        lblNotMem.Size = New Size(217, 15)
        lblNotMem.TabIndex = 9
        lblNotMem.Text = "Not a Member? Create an account here!"
        ' 
        ' lblForgotID
        ' 
        lblForgotID.AutoSize = True
        lblForgotID.Font = New Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblForgotID.ForeColor = SystemColors.Highlight
        lblForgotID.Location = New Point(479, 268)
        lblForgotID.Name = "lblForgotID"
        lblForgotID.Size = New Size(76, 15)
        lblForgotID.TabIndex = 10
        lblForgotID.Text = "Forgot my ID"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(472, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 15)
        Label5.TabIndex = 11
        Label5.Text = "John"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(472, 110)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 12
        Label6.Text = "Examiner"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(472, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(40, 15)
        Label7.TabIndex = 13
        Label7.Text = "Jeex71"
        ' 
        ' Log_In
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(567, 292)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(lblForgotID)
        Controls.Add(lblNotMem)
        Controls.Add(Label4)
        Controls.Add(butBack)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtID)
        Controls.Add(txtSName)
        Controls.Add(txtFName)
        Controls.Add(butLogin)
        Controls.Add(Label1)
        Name = "Log_In"
        Text = "Log_In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents butLogin As Button
    Friend WithEvents txtFName As TextBox
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents butBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNotMem As Label
    Friend WithEvents lblForgotID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
