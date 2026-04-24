Imports System.Windows.Forms.AxHost

Public Class Customer_Menu

    Dim OnlySlime As Boolean = False
    Dim OnlyActivator As Boolean = False
    Dim OrderBoth As Boolean = False


    Private Sub Customer_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'text file implementation - adds name of slimes
        Dim file As System.IO.StreamReader
        Dim line As String
        Dim parts(0 To 1) As String

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("Slimes.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            For index As Integer = 1 To 1
                comSlimeType.Items.Add(parts(0))
            Next

        Loop Until (file.EndOfStream)

        'hard coded but now simplified number combo boxes - temporary (use public variable or file)
        For index As Integer = 1 To 5
            comSlimeAmount.Items.Add(index)
        Next

        For index As Integer = 1 To 5
            comActivatorAmount.Items.Add(index)
        Next

        comSlimeType.Visible = False
        comSlimeAmount.Visible = False
        lblSlimeType.Visible = False
        lblSlimeAmount.Visible = False

        comActivatorAmount.Visible = False
        lblActivatorAmount.Visible = False

    End Sub

    Private Sub rbOnlySlime_CheckedChanged(sender As Object, e As EventArgs) Handles rbOnlySlime.CheckedChanged

        OnlySlime = True
        OnlyActivator = False
        OrderBoth = False

        lblDisclaimer.Visible = False

        'will only show info boxes (text and combo boxes) to order slime
        comSlimeType.Visible = True
        comSlimeAmount.Visible = True
        lblSlimeType.Visible = True
        lblSlimeAmount.Visible = True

        'makes other options invisible
        comActivatorAmount.Visible = False
        lblActivatorAmount.Visible = False

    End Sub

    Private Sub rbOnlyActivator_CheckedChanged(sender As Object, e As EventArgs) Handles rbOnlyActivator.CheckedChanged

        OnlySlime = False
        OnlyActivator = True
        OrderBoth = False

        lblDisclaimer.Visible = False

        comActivatorAmount.Visible = True
        lblActivatorAmount.Visible = True

        'makes other options invisible
        comSlimeType.Visible = False
        comSlimeAmount.Visible = False
        lblSlimeType.Visible = False
        lblSlimeAmount.Visible = False

    End Sub

    Private Sub rbOrderBoth_CheckedChanged(sender As Object, e As EventArgs) Handles rbOrderBoth.CheckedChanged

        OnlySlime = False
        OnlyActivator = False
        OrderBoth = True

        lblDisclaimer.Visible = False

        comSlimeType.Visible = True
        comSlimeAmount.Visible = True
        lblSlimeType.Visible = True
        lblSlimeAmount.Visible = True

        comActivatorAmount.Visible = True
        lblActivatorAmount.Visible = True

    End Sub

    Private Sub butOrder_Click(sender As Object, e As EventArgs) Handles butOrder.Click

        'declaring variables
        Dim SlimeType As String = comSlimeType.Text
        Dim SlimeAmount As String = comSlimeAmount.Text

        Dim ActivatorAmount As String = comActivatorAmount.Text

        Dim slimes As System.IO.StreamReader
        Dim line As String

        'if no radio buttons are selected
        If OnlySlime = False And OnlyActivator = False And OrderBoth = False Then
            MsgBox("Please select what you would like to order", 48)
            Exit Sub
        End If

        'presence check for all boxes
        If comSlimeType.Visible = True And comSlimeType.Text = "" Then
            MsgBox("Please enter a type of slime", 48)
            Exit Sub
        ElseIf comSlimeAmount.Visible = True And comSlimeAmount.Text = "" Then
            MsgBox("Please enter an amount of slime", 48)
            Exit Sub
        End If

        'combo box checking
        slimes = My.Computer.FileSystem.OpenTextFileReader(Dir("Slimes.txt"))
        Dim found As Boolean = False
        Dim slimepart(0 To 1) As String


        Do
            line = slimes.ReadLine()
            slimepart = line.Split(",")

            If comSlimeType.Text = slimepart(0) Then
                found = True
            End If

        Loop Until (slimes.EndOfStream)

        slimes.Close()

        If comSlimeType.Visible = True And found = False Then
            MsgBox("Please select a valid slime", 48)
            Exit Sub
        End If

        'change to match portential changing number based combo box (public variable or file)
        If comSlimeAmount.Visible = True And comSlimeAmount.Text <> "1" And comSlimeAmount.Text <> "2" And comSlimeAmount.Text <> "3" And comSlimeAmount.Text <> "4" And comSlimeAmount.Text <> "5" Then
            MsgBox("Please select a valid amount of slime", 48)
            Exit Sub
        End If

        If comActivatorAmount.Visible = True And comActivatorAmount.Text = "" Then
            MsgBox("Please enter an amount of activator", 48)
            Exit Sub
        End If

        'change to match portential changing number based combo box (public variable or file)
        If comActivatorAmount.Visible = True And comActivatorAmount.Text <> "1" And comActivatorAmount.Text <> "2" And comActivatorAmount.Text <> "3" And comActivatorAmount.Text <> "4" And comActivatorAmount.Text <> "5" Then
            MsgBox("Please select a valid amount of activator", 48)
            Exit Sub
        End If

        If txtCustomerID.Text = "" Then
            MsgBox("Please enter your CustomerID", 48)
            Exit Sub
        End If

        'declaring variables for types of order (only slime, only activator, both)
        Dim OrderSlime As String = comSlimeType.Visible = True And comSlimeAmount.Visible = True And comActivatorAmount.Visible = False

        Dim OrderActivator As String = comActivatorAmount.Visible = True And comSlimeType.Visible = False And comSlimeAmount.Visible = False

        Dim Both As String = comSlimeType.Visible = True And comSlimeAmount.Visible = True And comActivatorAmount.Visible = True

        'searching for correct ID
        Dim SearchCorrectID As System.IO.StreamReader
        Dim CustomerParts(0 To 5) As String
        Dim SearchID As String = txtCustomerID.Text
        Dim CorrectID As Boolean = False

        SearchCorrectID = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerInfo.txt"))

        Do
            line = SearchCorrectID.ReadLine()
            CustomerParts = line.Split(",")

            If CustomerParts(0) = SearchID Then
                CorrectID = True
            End If

        Loop Until (SearchCorrectID.EndOfStream)

        'saving order if ID is correct - add order id?
        Dim CustomerOrder As System.IO.StreamWriter
        Dim OrderNumber As Integer = 1
        Dim readCustomerOrder As System.IO.StreamReader

        'maybe when ordering show shipping details to check if person ordering ships to correct place - safety issue? only person should know the id but if someone guesses or knows then they can see their shipping details.
        'or just add shipping details in when saving? - customer id already links it

        If CorrectID = True Then
            'if all checks are met and id is correct it saves depending on what the customer selected (visible)
            If OrderSlime = True Then
                'if customer selected only slime
                readCustomerOrder = My.Computer.FileSystem.OpenTextFileReader(Dir$("CustomerOrders.txt"))

                'makes incremented number for order numbers
                Do
                    line = readCustomerOrder.ReadLine()
                    OrderNumber = OrderNumber + 1
                Loop Until (readCustomerOrder.EndOfStream)

                readCustomerOrder.Close()

                'saving order based off what was selected (visible)
                CustomerOrder = My.Computer.FileSystem.OpenTextFileWriter(Dir$("CustomerOrders.txt"), True)

                CustomerOrder.WriteLine(SearchID & "," & OrderNumber & "," & SlimeType & "," & SlimeAmount)
                CustomerOrder.Close()

            ElseIf OrderActivator = True Then
                'if customer selected only activator
                readCustomerOrder = My.Computer.FileSystem.OpenTextFileReader(Dir$("CustomerOrders.txt"))

                Do
                    line = readCustomerOrder.ReadLine()
                    OrderNumber = OrderNumber + 1
                Loop Until (readCustomerOrder.EndOfStream)

                readCustomerOrder.Close()

                CustomerOrder = My.Computer.FileSystem.OpenTextFileWriter(Dir$("CustomerOrders.txt"), True)

                CustomerOrder.WriteLine(SearchID & "," & OrderNumber & "," & ActivatorAmount)
                CustomerOrder.Close()

            ElseIf Both = True Then
                'if customer selected both
                readCustomerOrder = My.Computer.FileSystem.OpenTextFileReader(Dir$("CustomerOrders.txt"))

                Do
                    line = readCustomerOrder.ReadLine()
                    OrderNumber = OrderNumber + 1
                Loop Until (readCustomerOrder.EndOfStream)

                readCustomerOrder.Close()

                CustomerOrder = My.Computer.FileSystem.OpenTextFileWriter(Dir$("CustomerOrders.txt"), True)

                CustomerOrder.WriteLine(SearchID & "," & OrderNumber & "," & SlimeType & "," & SlimeAmount & "," & ActivatorAmount)
                CustomerOrder.Close()

            End If
            MsgBox("Order Placed:" & vbCrLf & "Thank you for purchasing!")

            'clearing all boxes
            comSlimeType.Text = ""
            comSlimeAmount.Text = ""
            comActivatorAmount.Text = ""
            txtCustomerID.Text = ""

        ElseIf CorrectID = False Then
            MsgBox("Invalid ID" & vbCrLf & "Please try again", 48)
        End If

    End Sub

    Private Sub lblForgotID_Click(sender As Object, e As EventArgs) Handles lblForgotID.Click

        'temporary code for now
        MsgBox("lol sucks to suck")

    End Sub

    Private Sub butSearchOrder_Click(sender As Object, e As EventArgs) Handles butSearchOrder.Click

        Dim input As String
        Dim correctInput As Boolean = False
        Dim FullMessage As String

        Dim file As System.IO.StreamReader
        Dim parts(0 To 1) As String
        Dim line As String

        input = InputBox("To search for your order you must input your CustomerID:")

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerOrders.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = input Then
                correctInput = True

                FullMessage = FullMessage + line + vbCrLf

            End If

        Loop Until (file.EndOfStream)

        If correctInput = False Then
            MsgBox("CustomerID incorrect or No Orders Found", 48)
            Exit Sub
        End If

        MsgBox(FullMessage)

    End Sub
End Class