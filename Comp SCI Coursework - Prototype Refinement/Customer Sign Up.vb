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

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click

        'declaring all info boxes as variables
        Dim FName As String = txtFName.Text
        Dim SName As String = txtSName.Text
        Dim DoB As Date = dtpDoB.Text

        Dim Email As String = txtEmail.Text
        Dim PhoneNum As String = txtPhoneNum.Text 'due to the 0

        Dim Street As String = txtStreet.Text
        Dim Town As String = txtTown.Text
        Dim Postcode As String = txtPostcode.Text

        'presence check for Personal Details
        If txtFName.Text = "" Then
            MsgBox("Please enter missing info within Personal Details", 48)
        ElseIf txtSName.Text = "" Then
            MsgBox("Please enter missing info within Personal Details", 48)
        End If
        'DoB does not need a presence check as it cannot be empty (ive tried lol)

        If txtEmail.Text = "" Then
            MsgBox("Please enter missing info within Contact Details", 48)
        ElseIf txtPhoneNum.Text = "" Then
            MsgBox("Please enter missing info within Contact Details", 48)
        End If

        If txtStreet.Text = "" Then
            MsgBox("Please enter missing info within Mailing Details", 48)
            Exit Sub
        ElseIf txtTown.text = "" Then
            MsgBox("Please enter missing info within Mailing Details", 48)
            Exit Sub
        ElseIf txtPostcode.Text = "" Then
            MsgBox("Please enter missing info within Mailing Details", 48)
            Exit Sub
        End If

        'specific checks for different info boxes
        'format check for email
        Dim correct As Boolean = Email Like "*@*.*"
        If correct = False Then
            MsgBox("Please enter a valid email", 48)
            Exit Sub
        End If

        'length check for phone number
        If Len(PhoneNum) <> 11 Then
            MsgBox("Please enter a valid phone number", 48)
            Exit Sub
        End If

        'length check for postcode
        If Len(Postcode) <> 7 Then
            MsgBox("", 48)
        End If

    End Sub
End Class