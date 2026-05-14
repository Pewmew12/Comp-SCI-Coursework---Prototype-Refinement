Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Admin_Menu

    'Public Structure EmployeeDetails

    'Public DELemployeeID As String
    'Public DELfname As String
    'Public DELsname As String
    'Public DELdob As String
    'Public DELemail As String
    'Public DELphonenum As String

    'End Structure

    'Public allEmployees(0 To 99) As EmployeeDetails
    'Public NumEmployee As Integer = 0

    Public NewLimit As Integer
    Public NewLimitActi As Integer

    Private Sub butEmployeeMenu_Click(sender As Object, e As EventArgs) Handles butEmployeeMenu.Click

        Employee_Menu.Show()

    End Sub

    Private Sub Admin_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'displayes current information in text files
        rtbCurrentEmployees.LoadFile(Dir$("EmployeeInfo.txt"), RichTextBoxStreamType.PlainText)

        rtbEmployeePayroll.LoadFile(Dir$("EmployeePayroll.txt"), RichTextBoxStreamType.PlainText)

        rtbViewSlimes.Visible = False
        rtbViewSlimeRecipies.Visible = False

        rtbViewSlimes.LoadFile(Dir$("Slimes.txt"), RichTextBoxStreamType.PlainText)
        rtbViewSlimeRecipies.LoadFile(Dir$("SlimeRecipies.txt"), RichTextBoxStreamType.PlainText)

        'Employee ID's for comboBox - part of old deleting attempt
        'Dim ComboFile As System.IO.StreamReader
        'Dim ComboLine As String
        'Dim ComboParts(0 To 1) As String

        'ComboFile = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeeInfo.txt"))

        'Do
        'ComboLine = ComboFile.ReadLine()
        'ComboParts = ComboLine.Split(",")

        'For index As Integer = 1 To 1
        'comEmployeeID.Items.Add(ComboParts(0))
        'Next

        'Loop Until (ComboFile.EndOfStream)

        'ComboFile.Close()

    End Sub

    Private Sub butAddEmployee_Click(sender As Object, e As EventArgs) Handles butAddEmployee.Click

        'declaring variables
        Dim FName As String = txtFName.Text
        Dim SName As String = txtSName.Text
        Dim DoB As String = dtpDoB.Text
        Dim Email As String = txtEmail.Text
        Dim PhoneNumber As String = txtPhoneNumber.Text
        Dim Password As String = txtPassword.Text

        'presence checking
        If txtFName.Text = "" Then
            MsgBox("Please enter Employee's first name", 48)
            Exit Sub
        ElseIf txtSName.Text = "" Then
            MsgBox("Please enter Employee's surname", 48)
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please enter Employee's password", 48)
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
        EmployeeInfo.WriteLine(EmployeeID & "," & FName & "," & SName & "," & DoB & "," & Email & "," & PhoneNumber & "," & Password)
        EmployeeInfo.Close()

        MsgBox("Employee Added!")

        txtFName.Text = ""
        txtSName.Text = ""
        txtEmail.Text = ""
        txtPhoneNumber.Text = ""
        txtPassword.Text = ""

        're-loads the employee info into the rich textbox after saving without having to reopen form & for combo box
        rtbCurrentEmployees.LoadFile(Dir$("EmployeeInfo.txt"), RichTextBoxStreamType.PlainText)

        'still part of old deleting attempt
        'Dim ComboFile As System.IO.StreamReader
        'Dim ComboLine As String
        'Dim ComboParts(0 To 1) As String

        'ComboFile = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeeInfo.txt"))

        'Do
        'ComboLine = ComboFile.ReadLine()
        'ComboParts = ComboLine.Split(",")

        'For index As Integer = 1 To 1
        'comEmployeeID.Items.Add(ComboParts(0))
        'Next

        'Loop Until (ComboFile.EndOfStream)

        'ComboFile.Close()


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
            MsgBox("Please enter Employee's bank", 48)
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
            MsgBox("EmployeeID incorrect or Not Found", 48)
            Exit Sub
        End If

        file.Close()

        Dim EmployeeBank As System.IO.StreamWriter

        EmployeeBank = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeePayroll.txt"), True)
        EmployeeBank.WriteLine(EmployeeID & "," & Bank & "," & Amount & "," & Frequency)
        EmployeeBank.Close()

        MsgBox("Employee Payroll saved!")

        txtEmployeeID.Text = ""
        txtBank.Text = ""
        txtPayAmount.Text = ""
        txtPayFrequency.Text = ""

        rtbEmployeePayroll.LoadFile(Dir$("EmployeePayroll.txt"), RichTextBoxStreamType.PlainText)

    End Sub

    Private Sub butEditDeleteEmployee_Click(sender As Object, e As EventArgs) Handles butDeleteEmployee.Click

        'come back to delete functions

        'Dim input As String
        'Dim correct As Boolean = False

        'Dim file As System.IO.StreamReader
        'Dim parts(0 To 5) As String
        'Dim line As String

        'Input = InputBox("Enter EmployeeID to delete", 48)

        'file = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeeInfo.txt"))

        'Do
        'line = file.ReadLine()
        'parts = line.Split(",")

        'If parts(0) = input Then
        'correct = True
        'End If

        'Loop Until (file.EndOfStream)

        'file.Close()

        'If correct = False Then
        'MsgBox("EmployeeID incorrect or Not Found", 48)
        'Exit Sub
        'End If



        'deleting a file with combo box
        'deletes entire file currently (bruh)
        'Dim SelectedCustomerID As String = comEmployeeID.Text

        ' For x = 0 To NumEmployee - 1
        'If SelectedCustomerID = allEmployees(x).DELemployeeID Then
        'For y = x To NumEmployee - 1
        'allEmployees(y).DELemployeeID = allEmployees(y + 1).DELemployeeID
        'allEmployees(y).DELfname = allEmployees(y + 1).DELfname
        'allEmployees(y).DELsname = allEmployees(y + 1).DELsname
        'allEmployees(y).DELdob = allEmployees(y + 1).DELdob
        'allEmployees(y).DELemail = allEmployees(y + 1).DELemail
        'allEmployees(y).DELphonenum = allEmployees(y + 1).DELphonenum
        'Next
        'NumEmployee = NumEmployee - 1
        'ElseIf SelectedCustomerID <> allEmployees(x).DELemployeeID Then
        'MsgBox("EmployeeID incorrect or Not Found", 48)
        'Exit Sub
        'End If
        'Next

        'Dim delete As System.IO.StreamWriter
        'delete = My.Computer.FileSystem.OpenTextFileWriter(Dir("EmployeeInfo.txt"), False)

        'For y = 0 To (NumEmployee - 1)
        'delete.WriteLine(allEmployees(y).DELemployeeID & "," & allEmployees(y).DELfname & "," & allEmployees(y).DELsname & "," & allEmployees(y).DELdob & "," & allEmployees(y).DELemail & "," & allEmployees(y).DELphonenum)
        'Next y
        'delete.Close()

        'rtbCurrentEmployees.LoadFile(Dir$("EmployeeInfo.txt"), RichTextBoxStreamType.PlainText)

        'maybe edit the textbox first and then make it save like the edit stock function in the employee menu
        'asks if info has already been editied via rich textbox

        Dim ask As String
        ask = InputBox("To edit current Employees, edit text through the textbox:" & vbCrLf & "Have you already edited via textbox and wish to save?" & vbCrLf & "Enter Y to confirm", 48)

        If ask = "Y" Or ask = "y" Then

            'declaring variables
            Dim UpdateEmployee As IO.StreamWriter
            Dim NewEmployee = rtbCurrentEmployees.Text
            Dim UpdateEmployee2 As IO.StreamWriter

            'saving into stock updater place - way to save whole array without appending onto pre-existing stock (replace saving code)
            UpdateEmployee = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeeUpdater.txt"), True)
            UpdateEmployee.WriteLine(NewEmployee)
            UpdateEmployee.Close()

            'deleting whats in current stock
            Dim DeletePrev As IO.StreamWriter

            DeletePrev = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeeInfo.txt"), False)
            DeletePrev.WriteLine()
            DeletePrev.Close()

            'now saving what is help in stock updater into main stock file
            rtbCurrentEmployees.LoadFile(Dir$("EmployeeUpdater.txt"), RichTextBoxStreamType.PlainText)

            UpdateEmployee2 = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeeInfo.txt"), True)
            UpdateEmployee2.WriteLine(NewEmployee)
            UpdateEmployee2.Close()

            'clearing stock update file now that info is in main stock file
            Dim DeletePrev2 As IO.StreamWriter

            DeletePrev2 = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeeUpdater.txt"), False)
            DeletePrev2.WriteLine()
            DeletePrev2.Close()

            MsgBox("Employee Updated/Deleted!")
            Exit Sub

        ElseIf ask <> "Y" Or ask <> "y" Then
            MsgBox("Employees Unedited", 48)
            Exit Sub
        End If


    End Sub

    Private Sub butNewSlime_Click(sender As Object, e As EventArgs) Handles butNewSlime.Click

        'declaring variables
        Dim SlimeInput As String
        Dim SlimeRecipie As String
        Dim NewSlime As System.IO.StreamWriter
        Dim NewRecipie As System.IO.StreamWriter
        Dim SlimeID As Integer = 1

        'inputting New Slime name
        SlimeInput = InputBox("Insert the Name of the New Slime:")
        If SlimeInput = "" Then
            MsgBox("Enter a Slime Name")
            Exit Sub
        End If

        SlimeRecipie = InputBox("Insert what and how much materials" & vbCrLf & "are needed for the New Slime")
        If SlimeRecipie = "" Then
            MsgBox("Enter what is needed for the Slime")
            Exit Sub
        End If

        Dim Checker As String
        Checker = InputBox("Is this Information Correct?" & vbCrLf & "Slime Name: " & SlimeInput & vbCrLf & "Slime Ingredients: " & SlimeRecipie & vbCrLf & "Type Y to Confirm.")

        If Checker = "Y" Or Checker = "y" Then
            'slimeID
            Dim file As System.IO.StreamReader
            Dim line As String

            file = My.Computer.FileSystem.OpenTextFileReader(Dir("Slimes.txt"))

            Do
                line = file.ReadLine()
                SlimeID = SlimeID + 1
            Loop Until (file.EndOfStream)

            file.Close()

            'saving Slime details
            'Slime Name
            NewSlime = My.Computer.FileSystem.OpenTextFileWriter(Dir$("Slimes.txt"), True)
            NewSlime.WriteLine(SlimeInput & "," & "Slime" & SlimeID)
            NewSlime.Close()

            'Slime Recipie
            NewRecipie = My.Computer.FileSystem.OpenTextFileWriter(Dir$("SlimeRecipies.txt"), True)
            NewRecipie.WriteLine("Slime" & SlimeID & "," & SlimeRecipie)
            NewRecipie.Close()

            rtbViewSlimes.LoadFile(Dir$("Slimes.txt"), RichTextBoxStreamType.PlainText)
            rtbViewSlimeRecipies.LoadFile(Dir$("SlimeRecipies.txt"), RichTextBoxStreamType.PlainText)

            MsgBox("Slime Added!")
            Exit Sub
        ElseIf Checker <> "Y" Or Checker <> "y" Then
            MsgBox("Slime Unsaved", 48)
        End If

    End Sub

    Private Sub butSlimeLimit_Click(sender As Object, e As EventArgs) Handles butSlimeLimit.Click

        'asking for a new limit for amount slimes purchasable in one order
        Try
            NewLimit = InputBox("Enter a New Limit for amount of Slimes purchasable in one order:")
        Catch
            MsgBox("Input entered is not a Number")
            Exit Sub
        End Try

        Dim SlimeLimit As System.IO.StreamWriter
        Dim DeletePrev As System.IO.StreamWriter

        'deleting previous contents of file
        DeletePrev = My.Computer.FileSystem.OpenTextFileWriter(Dir$("SlimeLimit.txt"), False)
        DeletePrev.WriteLine()
        DeletePrev.Close()

        'saving new limit for slimes
        SlimeLimit = My.Computer.FileSystem.OpenTextFileWriter(Dir$("SlimeLimit.txt"), True)

        For index As Integer = 1 To NewLimit
            SlimeLimit.WriteLine(index)
        Next

        SlimeLimit.Close()
        MsgBox("New Slime Limit Set!")
        lblSlimeLimit.Text = "Current Slime Limit: " & NewLimit

    End Sub

    Private Sub butActivatorLimit_Click(sender As Object, e As EventArgs) Handles butActivatorLimit.Click

        Try
            NewLimitActi = InputBox("Enter a New Limit for amount of Slimes purchasable in one order:")
        Catch
            MsgBox("Input entered is not a Number")
            Exit Sub
        End Try

        Dim Actiimit As System.IO.StreamWriter
        Dim DeletePrev As System.IO.StreamWriter

        'deleting previous contents of file
        DeletePrev = My.Computer.FileSystem.OpenTextFileWriter(Dir$("ActivatorLimit.txt"), False)
        DeletePrev.WriteLine()
        DeletePrev.Close()

        'saving new limit for slimes
        Actiimit = My.Computer.FileSystem.OpenTextFileWriter(Dir$("ActivatorLimit.txt"), True)

        For index As Integer = 1 To NewLimit
            Actiimit.WriteLine(index)
        Next

        Actiimit.Close()
        MsgBox("New Activator Limit Set!")
        lblActivatorLimit.Text = "Current Activator Limit: " & NewLimitActi

    End Sub

    Private Sub butViewSlimes_Click(sender As Object, e As EventArgs) Handles butViewSlimes.Click

        MsgBox("Heres the Current Slimes:" & vbCrLf & rtbViewSlimes.Text & vbCrLf & "And their Ingredients:" & vbCrLf & rtbViewSlimeRecipies.Text)

    End Sub

    Private Sub butOverview_Click(sender As Object, e As EventArgs) Handles butOverview.Click

        Overview.Show()
        Me.Close()

    End Sub

    Private Sub butDeletePayroll_Click(sender As Object, e As EventArgs) Handles butDeletePayroll.Click

        'saves edited text in rich text box to edit/delete payroll
        Dim ask As String
        ask = InputBox("To edit current Employees, edit text through the textbox:" & vbCrLf & "Have you already edited via textbox and wish to save?" & vbCrLf & "Enter Y to confirm", 48)

        If ask = "Y" Or ask = "y" Then

            'declaring variables
            Dim UpdatePayroll As IO.StreamWriter
            Dim NewPayroll = rtbEmployeePayroll.Text
            Dim UpdatePayroll2 As IO.StreamWriter

            'saving into stock updater place - way to save whole array without appending onto pre-existing stock (replace saving code)
            UpdatePayroll = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeeUpdater.txt"), True)
            UpdatePayroll.WriteLine(NewPayroll)
            UpdatePayroll.Close()

            'deleting whats in current stock
            Dim DeletePrev As IO.StreamWriter

            DeletePrev = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeePayroll.txt"), False)
            DeletePrev.WriteLine()
            DeletePrev.Close()

            'now saving what is help in stock updater into main stock file
            rtbCurrentEmployees.LoadFile(Dir$("EmployeeUpdater.txt"), RichTextBoxStreamType.PlainText)

            UpdatePayroll2 = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeePayroll.txt"), True)
            UpdatePayroll2.WriteLine(NewPayroll)
            UpdatePayroll2.Close()

            'clearing stock update file now that info is in main stock file
            Dim DeletePrev2 As IO.StreamWriter

            DeletePrev2 = My.Computer.FileSystem.OpenTextFileWriter(Dir$("EmployeeUpdater.txt"), False)
            DeletePrev2.WriteLine()
            DeletePrev2.Close()

            MsgBox("Employee Updated/Deleted!")
            Exit Sub

        ElseIf ask <> "Y" Or ask <> "y" Then
            MsgBox("Employees Unedited", 48)
            Exit Sub
        End If

    End Sub
End Class