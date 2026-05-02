Imports System.Windows.Forms.AxHost

Public Class Admin_Menu
    Private Sub butEmployeeMenu_Click(sender As Object, e As EventArgs) Handles butEmployeeMenu.Click

        Employee_Menu.Show()

    End Sub

    Private Sub Admin_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'displayes current information in text files
        rtbCurrentEmployees.LoadFile(Dir$("EmployeeInfo.txt"), RichTextBoxStreamType.PlainText)

        rtbEmployeePayroll.LoadFile(Dir$("EmployeePayroll.txt"), RichTextBoxStreamType.PlainText)

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

        txtFName.Text = ""
        txtSName.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""

        're-loads the employee info into the rich textbox after saving without having to reopen form
        rtbCurrentEmployees.LoadFile(Dir$("EmployeeInfo.txt"), RichTextBoxStreamType.PlainText)

    End Sub

    Private Sub butSearchEmployee_Click(sender As Object, e As EventArgs) Handles butSearchEmployee.Click

        Dim input As String
        Dim correct As Boolean = False
        Dim fullmessage As String

        Dim file As System.IO.StreamReader
        Dim parts(0 To 5) As String
        Dim line As String

        Dim payfile As System.IO.StreamReader
        Dim payparts(0 To 5) As String
        Dim payline As String

        input = InputBox("To search for an employee, input their EmployeeID or Employee surname:")

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeeInfo.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = input Or parts(2) = input Then
                correct = True

                fullmessage = fullmessage + line + vbCrLf

            End If

        Loop Until (file.EndOfStream)

        file.Close()

        payfile = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeePayroll.txt"))

        Do
            payline = payfile.ReadLine()
            payparts = payline.Split(",")

            If payparts(0) = input Or payparts(2) = input Then
                correct = True

                fullmessage = fullmessage + payline + vbCrLf

            End If

        Loop Until (payfile.EndOfStream)

        If correct = False Then
            MsgBox("EmployeeID incorrect or Not Found")
            Exit Sub
        End If

        MsgBox(fullmessage)

    End Sub

    Private Sub butSavePay_Click(sender As Object, e As EventArgs) Handles butSavePay.Click

        'declaring variables
        Dim EmployeeID As String = txtEmployeeID.Text
        Dim Bank As String = txtBank.Text
        Dim Amount As String = txtPayAmount.Text
        Dim Frequency As String = txtPayFrequency.Text

        Dim file As System.IO.StreamReader
        Dim parts(0 To 5) As String
        Dim line As String
        Dim correct As Boolean = False

        If txtEmployeeID.Text = "" Then
            MsgBox("Please enter Employee's ID", 48)
            Exit Sub
        ElseIf txtBank.Text = "" Then
            MsgBox("Please enter Employee's bike", 48)
            Exit Sub
        ElseIf txtPayAmount.Text = "" Then
            MsgBox("Please enter Payroll amount", 48)
            Exit Sub
        ElseIf txtPayFrequency.Text = "" Then
            MsgBox("Please enter Payroll frequency", 48)
            Exit Sub
        End If

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeeInfo.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = txtEmployeeID.Text Then
                correct = True
            End If

        Loop Until (file.EndOfStream)

        If correct = False Then
            MsgBox("EmployeeID incorrect or Not Found")
            Exit Sub
        End If

        file.Close()

        Dim EmployeeInfo As System.IO.StreamWriter

        EmployeeInfo = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeePayroll.txt"), True)
        EmployeeInfo.WriteLine(EmployeeID & "," & Bank & "," & Amount & "," & Frequency)
        EmployeeInfo.Close()

        MsgBox("Employee Payroll saved!")

        txtEmployeeID.Text = ""
        txtBank.Text = ""
        txtPayAmount.Text = ""
        txtPayFrequency.Text = ""

        rtbEmployeePayroll.LoadFile(Dir$("EmployeePayroll.txt"), RichTextBoxStreamType.PlainText)

    End Sub
End Class