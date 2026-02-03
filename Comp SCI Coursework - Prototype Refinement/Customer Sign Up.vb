Public Class Customer_Sign_Up
    Private Sub ButBack_Click(sender As Object, e As EventArgs) Handles ButBack.Click

        'Back Button, will return user to the main screen
        'BACK() - This Module does not work at the moment

        Dim confirm As String

        confirm = InputBox("Return to the Main Menu without saving?" & vbCrLf & "Type Y to Return to the Main Menu" & vbCrLf & "Press Cancel to continue editing.", 48)

        If confirm = "Y" Or confirm = "y" Then
            MsgBox("Data Unsaved", 48)
            Close()
        End If

    End Sub
End Class