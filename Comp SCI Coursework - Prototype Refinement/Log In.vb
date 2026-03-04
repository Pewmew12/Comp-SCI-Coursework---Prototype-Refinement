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

    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'declaring variables
        Dim FName As String = txtFName.Text
        Dim SName As String = txtSName.Text
        Dim ID As String = txtID.Text

        'Searching function
        Dim file As System.IO.StreamReader
        Dim parts(0 To 5) As String
        Dim line As String

        Dim SearchID As String
        SearchID = txtID.Text

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerInfo.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = SearchID Then
                MsgBox("id correct")
            End If

        Loop Until (file.EndOfStream)

    End Sub
End Class