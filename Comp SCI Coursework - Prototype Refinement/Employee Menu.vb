Imports System.Windows.Forms.AxHost

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
            Dim UpdateDelivery As System.IO.StreamWriter

            UpdateDelivery = My.Computer.FileSystem.OpenTextFileWriter(Dir$("Deliveries.txt"), True)
            UpdateDelivery.WriteLine(DateDelivered & "," & EmployeeID & "," & SupplyDelivery)
            UpdateDelivery.Close()

            Dim AddToStock As System.IO.StreamWriter

            AddToStock = My.Computer.FileSystem.OpenTextFileWriter(Dir$("Stock.txt"), True)
            AddToStock.WriteLine(SupplyDelivery)
            AddToStock.Close()

            txtSupply.Text = ""
            txtEmployeeID.Text = ""

            're-loading files so they appear after being added
            rtbDeliveries.LoadFile(Dir$("Deliveries.txt"), RichTextBoxStreamType.PlainText)

            rtbStock.LoadFile(Dir$("Stock.txt"), RichTextBoxStreamType.PlainText)

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
        Dim parts(0 To 2) As String
        Dim line As String

        input = InputBox("To search for a delivery, input date delivered or EmployeeID:")

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("Deliveries.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = input Or parts(1) = input Then
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

    Private Sub butSearchSales_Click(sender As Object, e As EventArgs) Handles butSearchSales.Click

        Dim input As String
        Dim correctInput As Boolean = False
        Dim FullMessage As String

        Dim file As System.IO.StreamReader
        Dim parts(0 To 1) As String
        Dim line As String

        input = InputBox("To search sales, input Order Number:")

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerOrders.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(1) = input Then
                correctInput = True

                FullMessage = FullMessage + line + vbCrLf

            End If

        Loop Until (file.EndOfStream)

        If correctInput = False Then
            MsgBox("Order Number incorrect or No Orders Found", 48)
            Exit Sub
        End If

        MsgBox(FullMessage)

    End Sub

    Private Sub butSearchSlime_Click(sender As Object, e As EventArgs) Handles butSearchSlime.Click

        Dim input As String
        Dim correctInput As Boolean = False
        Dim FullMessage As String

        Dim file As System.IO.StreamReader
        Dim parts(0 To 1) As String
        Dim line As String

        input = InputBox("To search Slimes, input Slime Number:")

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("SlimeRecipies.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = input Then
                correctInput = True

                FullMessage = FullMessage + line + vbCrLf

            End If

        Loop Until (file.EndOfStream)

        If correctInput = False Then
            MsgBox("Slime Number incorrect or Not Found", 48)
            Exit Sub
        End If

        MsgBox(FullMessage)

    End Sub

    Private Sub butUpdateStock_Click(sender As Object, e As EventArgs) Handles butUpdateStock.Click

        'asks if info has already been editied via rich textbox
        Dim ask As String
        ask = InputBox("To edit current stock, edit text through the textbox:" & vbCrLf & "Have you already edited via textbox and wish to save?" & vbCrLf & "Enter Y to confirm", 48)

        If ask = "Y" Or ask = "y" Then

            'declaring variables
            Dim UpdateStock As System.IO.StreamWriter
            Dim NewStock As String = rtbStock.Text
            Dim UpdateStock2 As System.IO.StreamWriter

            'saving into stock updater place - way to save whole array without appending onto pre-existing stock (replace saving code)
            UpdateStock = My.Computer.FileSystem.OpenTextFileWriter(Dir$("StockUpdater.txt"), True)
            UpdateStock.WriteLine(NewStock)
            UpdateStock.Close()

            'deleting whats in current stock
            Dim DeletePrev As System.IO.StreamWriter

            DeletePrev = My.Computer.FileSystem.OpenTextFileWriter(Dir$("Stock.txt"), False)
            DeletePrev.WriteLine()
            DeletePrev.Close()

            'now saving what is help in stock updater into main stock file
            rtbStock.LoadFile(Dir$("StockUpdater.txt"), RichTextBoxStreamType.PlainText)

            UpdateStock2 = My.Computer.FileSystem.OpenTextFileWriter(Dir$("Stock.txt"), True)
            UpdateStock2.WriteLine(NewStock)
            UpdateStock2.Close()

            'clearing stock update file now that info is in main stock file
            Dim DeletePrev2 As System.IO.StreamWriter

            DeletePrev2 = My.Computer.FileSystem.OpenTextFileWriter(Dir$("StockUpdater.txt"), False)
            DeletePrev2.WriteLine()
            DeletePrev2.Close()

            MsgBox("Stock Updated!")
            Exit Sub

        ElseIf ask <> "Y" Or ask <> "y" Then
            MsgBox("Stock Unedited", 48)
            Exit Sub
        End If

    End Sub

    Private Sub butSearchStock_Click(sender As Object, e As EventArgs) Handles butSearchStock.Click

        Dim input As String
        Dim correctInput As Boolean = False
        Dim FullMessage As String

        Dim file As System.IO.StreamReader
        Dim parts(0 To 4) As String
        Dim line As String

        input = InputBox("What do you want to search for:")

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("Stock.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = input Then
                correctInput = True

                FullMessage = FullMessage + parts(0) + vbCrLf
            End If

            Try
                If parts(1) = input Then
                    correctInput = True

                    FullMessage = FullMessage + parts(1) + vbCrLf
                End If
            Catch
                'not slot
            End Try

            Try
                If parts(2) = input Then
                    correctInput = True

                    FullMessage = FullMessage + parts(2) + vbCrLf
                End If
            Catch
                'not slot
            End Try

            Try
                If parts(3) = input Then
                    correctInput = True

                    FullMessage = FullMessage + parts(3) + vbCrLf
                End If
            Catch
                'not slot
            End Try

            Try
                If parts(4) = input Then
                    correctInput = True

                    FullMessage = FullMessage + parts(4) + vbCrLf
                End If
            Catch
                'not slot
            End Try

        Loop Until (file.EndOfStream)

        If correctInput = False Then
            MsgBox("Not Found", 48)
            Exit Sub
        End If

        MsgBox("Heres how many there is of this Item:" & vbCrLf & FullMessage)

    End Sub
End Class