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

        Dim CorrectID As Boolean = False
        Dim CorrectFName As Boolean = False
        Dim CorrectSName As Boolean = False

        'presence check for all text boxes
        If txtFName.Text = "" Then
            MsgBox("Please enter your First Name")
            Exit Sub
        ElseIf txtSName.Text = "" Then
            MsgBox("Please enter your Surname")
            Exit Sub
        ElseIf txtID.Text = "" Then
            MsgBox("Please enter your ID")
            Exit Sub
        End If

        'Searching function for customers
        Dim file As System.IO.StreamReader
        Dim parts(0 To 5) As String
        Dim line As String

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerInfo.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = SearchID Then
                CorrectID = True
            End If

            If parts(1) = SearchFName Then
                CorrectFName = True
            End If

            If parts(2) = SearchSName Then
                CorrectSName = True
            End If

        Loop Until (file.EndOfStream)

        file.Close()

        'Searching function for ADMIN
        Dim AdminFile As System.IO.StreamReader
        Dim Adminparts(0 To 5) As String
        Dim Adminline As String

        Dim AdminCorrectID As Boolean = False
        Dim AdminCorrectFName As Boolean = False
        Dim AdminCorrectSName As Boolean = False

        AdminFile = My.Computer.FileSystem.OpenTextFileReader(Dir("AdminInfo.txt"))

        Do
            Adminline = AdminFile.ReadLine()
            Adminparts = Adminline.Split(",")

            If Adminparts(0) = SearchID Then
                AdminCorrectID = True
            End If

            If Adminparts(1) = SearchFName Then
                AdminCorrectFName = True
            End If

            If Adminparts(2) = SearchSName Then
                AdminCorrectSName = True
            End If

        Loop Until (Adminfile.EndOfStream)

        Dim CorrectAllCustomer As Boolean = (CorrectID = True And CorrectFName = True And CorrectSName = True)
        Dim CorrectAllAdmin As Boolean = (AdminCorrectID = True And AdminCorrectFName = True And AdminCorrectSName = True)


        If CorrectAllCustomer = True Then
            MsgBox("Log In Sucessful:" & vbCrLf & "Welcome to Angel Slimes!")
            txtFName.Text = ""
            txtSName.Text = ""
            txtID.Text = ""
            Customer_Menu.Show()
            Me.Close()
            Exit Sub
        ElseIf CorrectAllAdmin = True Then
            MsgBox("Log In Sucessful:" & vbCrLf & "Hello Admin!")
            txtFName.Text = ""
            txtSName.Text = ""
            txtID.Text = ""
            Admin_Menu.Show()
            Me.Close()
            Exit Sub
        ElseIf CorrectAllCustomer = False Or CorrectAllAdmin = False Then
            MsgBox("Incorrect Name/Surname/ID" & vbCrLf & "Please try again", 48)
        End If

    End Sub

    Private Sub lblForgotID_Click(sender As Object, e As EventArgs) Handles lblForgotID.Click

        'temporary code for now
        MsgBox("lol sucks to suck")

    End Sub
End Class