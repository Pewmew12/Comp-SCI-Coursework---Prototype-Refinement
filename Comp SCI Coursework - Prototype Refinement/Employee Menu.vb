Public Class Employee_Menu
    Private Sub Employee_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'loads in file information
        rtbSales.LoadFile(Dir$("CustomerOrders.txt"), RichTextBoxStreamType.PlainText)

        rtbStock.LoadFile(Dir$("Stock.txt"), RichTextBoxStreamType.PlainText)

        rtbRecipies.LoadFile(Dir$("SlimeRecipies.txt"), RichTextBoxStreamType.PlainText)

        rtbDeliveries.LoadFile(Dir$("Deliveries.txt"), RichTextBoxStreamType.PlainText)

    End Sub

    Private Sub butUpdateDelivery_Click(sender As Object, e As EventArgs) Handles butUpdateDelivery.Click

        Dim SupplyDelivery As String = txtSupply.Text
        Dim DateDelivered As String = dtpDateDelivered.Text
        Dim EmployeeID As String = txtEmployeeID.Text

        'presence check
        If txtSupply.Text = "" Then
            MsgBox("Enter what was Supplied", 48)
            Exit Sub
        ElseIf txtEmployeeID.Text = "" Then
            MsgBox("Enter EmployeeID to confirm", 48)
            Exit Sub
        End If

        'checking EmployeeID
        Dim EmployeeFile As System.IO.StreamReader
        Dim Employeeparts(0 To 5) As String
        Dim Employeeline As String
        Dim SearchID As String = txtEmployeeID.Text

        Dim EmployeeCorrectID As Boolean = False

        EmployeeFile = My.Computer.FileSystem.OpenTextFileReader(Dir("EmployeeInfo.txt"))

        Do
            Employeeline = EmployeeFile.ReadLine()
            Employeeparts = Employeeline.Split(",")

            If Employeeparts(0) = SearchID Then
                EmployeeCorrectID = True
            End If

        Loop Until (EmployeeFile.EndOfStream)

        EmployeeFile.Close()

        If EmployeeCorrectID = True Then
            'save txt supply
            MsgBox("Delivery Confirmed!")
            Exit Sub
        ElseIf EmployeeCorrectID = False Then
            MsgBox("EmployeeID Incorrect or Not Found", 48)
            Exit Sub
        End If

    End Sub

    Private Sub butSearchDelivery_Click(sender As Object, e As EventArgs) Handles butSearchDelivery.Click

        Dim input As String
        Dim correct As Boolean = False
        Dim fullmessage As String

        Dim file As System.IO.StreamReader
        Dim parts(0 To 5) As String
        Dim line As String

        input = InputBox("To search for a delivery, input date delivered:")

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("Deliveries.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(1) = input Then
                correct = True

                fullmessage = fullmessage + line + vbCrLf

            End If

        Loop Until (file.EndOfStream)

        file.Close()

        If correct = False Then
            MsgBox("Delivery date incorrect or Not Found")
            Exit Sub
        End If

        MsgBox(fullmessage)

    End Sub
End Class