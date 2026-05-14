Public Class Log_In
    Private Sub lblNotMem_Click(sender As Object, e As EventArgs) Handles lblNotMem.Click

        'shows the user the customer sign up form and closes the log in form
        Customer_Sign_Up.Show()
        Me.Close()

    End Sub

    Private Sub butBack_Click(sender As Object, e As EventArgs) Handles butBack.Click

        'will use the module for returning/closing the current once functioning
        Me.Close()

    End Sub

    Private Sub butLogin_Click(sender As Object, e As EventArgs) Handles butLogin.Click

        'declaring variables
        Dim SearchFName As String = txtFName.Text
        Dim SearchSName As String = txtSName.Text
        Dim SearchID As String = txtID.Text
        Dim SearchPass As String = txtPassword.Text

        'presence check for all text boxes
        If txtFName.Text = "" Then
            MsgBox("Please enter your First Name")
            Exit Sub
        ElseIf txtSName.Text = "" Then
            MsgBox("Please enter your Surname")
            Exit Sub
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please enter your Password")
            Exit Sub
        ElseIf txtID.Text = "" Then
            MsgBox("Please enter your ID")
            Exit Sub
        End If

        'Searching function for customers
        Dim file As System.IO.StreamReader
        Dim parts(0 To 6) As String
        Dim line As String

        Dim CorrectID As Boolean = False
        Dim CorrectFName As Boolean = False
        Dim CorrectSName As Boolean = False
        Dim CorrectPass As Boolean = False

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerInfo.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = SearchID And parts(1) = SearchFName And parts(2) = SearchSName And parts(6) = SearchPass Then
                CorrectID = True
                CorrectFName = True
                CorrectSName = True
                CorrectPass = True
            End If

        Loop Until (file.EndOfStream)

        file.Close()

        'Searching function for ADMIN
        Dim AdminFile As System.IO.StreamReader
        Dim Adminparts(0 To 6) As String
        Dim Adminline As String

        Dim AdminCorrectID As Boolean = False
        Dim AdminCorrectFName As Boolean = False
        Dim AdminCorrectSName As Boolean = False
        Dim AdminCorrectPass As Boolean = False

        AdminFile = My.Computer.FileSystem.OpenTextFileReader(Dir("AdminInfo.txt"))

        Do
            Adminline = AdminFile.ReadLine()
            Adminparts = Adminline.Split(",")

            If Adminparts(0) = SearchID And Adminparts(1) = SearchFName And Adminparts(2) = SearchSName And Adminparts(6) = SearchPass Then
                AdminCorrectID = True
                AdminCorrectFName = True
                AdminCorrectSName = True
                AdminCorrectPass = True
            End If

        Loop Until (Adminfile.EndOfStream)

        AdminFile.Close()

        'search function for employee
        Dim EmployeeFile As System.IO.StreamReader
        Dim Employeeparts(0 To 6) As String
        Dim Employeeline As String

        Dim EmployeeCorrectID As Boolean = False
        Dim EmployeeCorrectFName As Boolean = False
        Dim EmployeeCorrectSName As Boolean = False
        Dim EmployeeCorrectPass As Boolean = False

        EmployeeFile = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeeInfo.txt"))

        Do
            Employeeline = EmployeeFile.ReadLine()
            Employeeparts = Employeeline.Split(",")

            If Employeeparts(0) = SearchID And Employeeparts(1) = SearchFName And Employeeparts(2) = SearchSName And Employeeparts(6) = SearchPass Then
                EmployeeCorrectID = True
                EmployeeCorrectFName = True
                EmployeeCorrectSName = True
                EmployeeCorrectPass = True
            End If

        Loop Until (EmployeeFile.EndOfStream)

        EmployeeFile.Close()

        'Dim CorrectAllCustomer As Boolean = (CorrectID = True And CorrectFName = True And CorrectSName = True)
        Dim CorrectAllAdmin As Boolean = (AdminCorrectID = True And AdminCorrectFName = True And AdminCorrectSName = True And AdminCorrectPass = True)
        Dim CorrectAllEmployee As Boolean = (EmployeeCorrectID = True And EmployeeCorrectFName = True And EmployeeCorrectSName = True And EmployeeCorrectPass = True)
        Dim CorrectAllCustomer As Boolean = (CorrectID = True And CorrectFName = True And CorrectSName = True And CorrectPass = True)

        If CorrectAllCustomer = True Then
            MsgBox("Log In Sucessful:" & vbCrLf & "Welcome to Angel Slimes!")
            txtFName.Text = ""
            txtSName.Text = ""
            txtID.Text = ""
            txtPassword.Text = ""
            Customer_Menu.Show()
            Me.Close()
            Exit Sub
        ElseIf CorrectAllAdmin = True Then
            MsgBox("Log In Sucessful:" & vbCrLf & "Hello Admin!")
            txtFName.Text = ""
            txtSName.Text = ""
            txtID.Text = ""
            txtPassword.Text = ""
            Admin_Menu.Show()
            Me.Close()
            Exit Sub
        ElseIf CorrectAllEmployee = True Then
            MsgBox("Log In Sucessful:" & vbCrLf & "Hello Employee!")
            txtFName.Text = ""
            txtSName.Text = ""
            txtID.Text = ""
            txtPassword.Text = ""
            Employee_Menu.Show()
            Me.Close()
            Exit Sub
        ElseIf CorrectAllCustomer = False Or CorrectAllAdmin = False Or CorrectAllEmployee = False Then
            MsgBox("Incorrect Name/Surname/Password/ID" & vbCrLf & "Please try again", 48)
        End If

    End Sub

    Private Sub lblForgotID_Click(sender As Object, e As EventArgs) Handles lblForgotID.Click

        'temporary code for now
        MsgBox("bro")

    End Sub
End Class