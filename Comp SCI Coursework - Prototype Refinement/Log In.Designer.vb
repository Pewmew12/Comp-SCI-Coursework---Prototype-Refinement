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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        butBack = New Button()
        Label4 = New Label()
        lblNotMem = New Label()
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(228, 78)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(238, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(228, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(238, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(228, 167)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(238, 23)
        TextBox3.TabIndex = 4
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
        Label3.Size = New Size(130, 15)
        Label3.TabIndex = 6
        Label3.Text = "Customer/Employee ID"
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
        lblNotMem.Location = New Point(12, 268)
        lblNotMem.Name = "lblNotMem"
        lblNotMem.Size = New Size(217, 15)
        lblNotMem.TabIndex = 9
        lblNotMem.Text = "Not a Member? Create an account here!"
        ' 
        ' Log_In
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(567, 292)
        Controls.Add(lblNotMem)
        Controls.Add(Label4)
        Controls.Add(butBack)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(butLogin)
        Controls.Add(Label1)
        Name = "Log_In"
        Text = "Log_In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents butLogin As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents butBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNotMem As Label
End Class
