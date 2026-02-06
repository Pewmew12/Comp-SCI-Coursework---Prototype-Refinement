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
End Class