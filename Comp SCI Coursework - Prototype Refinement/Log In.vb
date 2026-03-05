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

        'Searching function
        Dim file As System.IO.StreamReader
        Dim parts(0 To 5) As String
        Dim line As String

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerInfo.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = SearchID Then
                MsgBox("customer id correct")
                CorrectID = True
            End If

            If parts(1) = SearchFName Then
                MsgBox("customer fname correct")
                CorrectFName = True
            End If

            If parts(2) = SearchSName Then
                MsgBox("customer sname correct")
                CorrectSName = True
            End If

        Loop Until (file.EndOfStream)

        If CorrectID = True And CorrectFName = True And CorrectSName = True Then
            MsgBox("log in yaaaay")
        End If

    End Sub
End Class