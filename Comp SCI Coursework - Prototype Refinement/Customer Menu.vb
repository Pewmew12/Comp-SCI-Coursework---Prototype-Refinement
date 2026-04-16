Imports System.Windows.Forms.AxHost

Public Class Customer_Menu

    Dim OnlySlime As Boolean = False
    Dim OnlyActivator As Boolean = False
    Dim OrderBoth As Boolean = False


    Private Sub Customer_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'text file implementation
        Dim file As System.IO.StreamReader
        Dim line As String

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("Slimes.txt"))

        Do
            line = file.ReadLine()

            For index As Integer = 1 To 1
                comSlimeType.Items.Add(line)
            Next

        Loop Until (file.EndOfStream)

        'hard coded but now simplified number combo boxes - temporary (use public variable)
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

        'checking if thing in combo box is one from the list - hard coded for now
        If comSlimeType.Visible = True And comSlimeType.Text <> "Smiley Smile Slime" And comSlimeType.Text <> "Rainbow Cloud Slime" And comSlimeType.Text <> "The Girl From K-Pop Demon Hunters Slime" Then
            MsgBox("Please select a valid slime", 48)
            Exit Sub
        End If

        'change to match portential changing number based combo box (public variable)
        If comSlimeAmount.Visible = True And comSlimeAmount.Text <> "1" And comSlimeAmount.Text <> "2" And comSlimeAmount.Text <> "3" And comSlimeAmount.Text <> "4" And comSlimeAmount.Text <> "5" Then
            MsgBox("Please select a valid amount of slime", 48)
            Exit Sub
        End If

        If comActivatorAmount.Visible = True And comActivatorAmount.Text = "" Then
            MsgBox("Please enter an amount of activator", 48)
            Exit Sub
        End If

        'change to match portential changing number based combo box (public variable)
        If comActivatorAmount.Visible = True And comActivatorAmount.Text <> "1" And comActivatorAmount.Text <> "2" And comActivatorAmount.Text <> "3" And comActivatorAmount.Text <> "4" And comActivatorAmount.Text <> "5" Then
            MsgBox("Please select a valid amount of activator", 48)
            Exit Sub
        End If

        If txtCustomerID.Text = "" Then
            MsgBox("Please enter your CustomerID", 48)
            Exit Sub
        End If

        'searching for correct ID
        Dim SearchID As String = txtCustomerID.Text
        Dim CorrectID As Boolean = False
        Dim file As System.IO.StreamReader
        Dim parts(0 To 5) As String
        Dim line As String

        Dim OrderSlime As String = comSlimeType.Visible = True And comSlimeAmount.Visible = True And comActivatorAmount.Visible = False

        Dim OrderActivator As String = comActivatorAmount.Visible = True And comSlimeType.Visible = False And comSlimeAmount.Visible = False

        Dim Both As String = comSlimeType.Visible = True And comSlimeAmount.Visible = True And comActivatorAmount.Visible = True

        file = My.Computer.FileSystem.OpenTextFileReader(Dir("CustomerInfo.txt"))

        Do
            line = file.ReadLine()
            parts = line.Split(",")

            If parts(0) = SearchID Then
                CorrectID = True
            End If

        Loop Until (file.EndOfStream)

        'saving order if ID is correct
        Dim CustomerOrder As System.IO.StreamWriter

        If CorrectID = True Then
            If OrderSlime = True Then

                CustomerOrder = My.Computer.FileSystem.OpenTextFileWriter(Dir$("CustomerOrders.txt"), True)
                CustomerOrder.WriteLine(SearchID & "," & SlimeType & "," & SlimeAmount)
                CustomerOrder.Close()

            ElseIf OrderActivator = True Then

                CustomerOrder = My.Computer.FileSystem.OpenTextFileWriter(Dir$("CustomerOrders.txt"), True)
                CustomerOrder.WriteLine(SearchID & "," & ActivatorAmount)
                CustomerOrder.Close()

            ElseIf Both = True Then

                CustomerOrder = My.Computer.FileSystem.OpenTextFileWriter(Dir$("CustomerOrders.txt"), True)
                CustomerOrder.WriteLine(SearchID & "," & SlimeType & "," & SlimeAmount & "," & ActivatorAmount)
                CustomerOrder.Close()

            End If
            MsgBox("Order Placed:" & vbCrLf & "Thank you for purchasing!")
        ElseIf CorrectID = False Then
            MsgBox("Invalid ID" & vbCrLf & "Please try again", 48)
        End If

    End Sub
End Class