Public Class Admin_Menu
    Private Sub butEmployeeMenu_Click(sender As Object, e As EventArgs) Handles butEmployeeMenu.Click

        Employee_Menu.Show()

    End Sub

    Private Sub Admin_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtbCurrentEmployees.LoadFile(Dir$("EmployeeInfo.txt"), RichTextBoxStreamType.PlainText)

    End Sub

    Private Sub butAddEmployee_Click(sender As Object, e As EventArgs) Handles butAddEmployee.Click

        'declaring variables
        Dim FName As String = txtFName.Text
        Dim SName As String = txtSName.Text
        Dim DoB As String = dtpDoB.Text
        Dim Email As String = txtEmail.Text
        Dim PhoneNumber As String = txtPhoneNumber.Text

        'presence checking
        If txtFName.Text = "" Then
            MsgBox("Please enter Employee's first name", 48)
            Exit Sub
        ElseIf txtSName.Text = "" Then
            MsgBox("Please enter Employee's surname", 48)
            Exit Sub
        ElseIf txtEmail.Text = "" Then
            MsgBox("Please enter Employee's Email", 48)
            Exit Sub
        ElseIf txtPhoneNumber.Text = "" Then
            MsgBox("Please enter Employee's phone number", 48)
            Exit Sub
        End If

        'format check for email
        Dim correctemail As Boolean = Email Like "*@*.*"
        If correctemail = False Then
            MsgBox("Please enter a valid Email", 48)
            Exit Sub
        End If

        'length check for phone number
        If Len(txtPhoneNumber.Text) <> 11 Then
            MsgBox("Please enter a valid Phone Number", 48)
            Exit Sub
        End If

        'create EmployeeID
        Dim EmployeeID As String
        Dim RNumber As Integer

        'randomizer may have the same issue with it presenting the same number every time the program is booted up.
        RNumber = Math.Ceiling(Rnd() * 150)

        EmployeeID = txtPhoneNumber.Text.Substring(0, 2) & txtEmail.Text.Substring(0, 2).ToUpper & txtSName.Text.Substring(0, 1).ToLower & txtFName.Text.Substring(0, 1).ToUpper & RNumber

        'saving Employee info
        Dim EmployeeInfo As System.IO.StreamWriter

        EmployeeInfo = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeeInfo.txt"), True)
        EmployeeInfo.WriteLine(EmployeeID & "," & FName & "," & SName & "," & DoB & "," & Email & "," & PhoneNumber)
        EmployeeInfo.Close()

        MsgBox("Employee Added!")


    End Sub
End Class