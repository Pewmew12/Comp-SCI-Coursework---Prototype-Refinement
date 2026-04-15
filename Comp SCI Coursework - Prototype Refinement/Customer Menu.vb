Public Class Customer_Menu

    Dim OnlySlime As Boolean = False
    Dim OnlyActivator As Boolean = False
    Dim OrderBoth As Boolean = False


    Private Sub Customer_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'entering slime names and amount from text document - hard coded for now
        comSlimeType.Items.Add("Smiley Smile Slime")
        comSlimeType.Items.Add("Rainbow Cloud Slime")
        comSlimeType.Items.Add("The Girl From K-Pop Demon Hunters Slime")

        comSlimeAmount.Items.Add("1")
        comSlimeAmount.Items.Add("2")
        comSlimeAmount.Items.Add("3")
        comSlimeAmount.Items.Add("4")
        comSlimeAmount.Items.Add("5")

        comActivatorAmount.Items.Add("1")
        comActivatorAmount.Items.Add("2")
        comActivatorAmount.Items.Add("3")
        comActivatorAmount.Items.Add("4")
        comActivatorAmount.Items.Add("5")

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

        'presence check for all boxes
        If comSlimeType.Text = "" Then
            MsgBox("Please enter a type of slime", 48)
        End If

        'checking if thing in combo box is one from the list
        If comSlimeType.Text <> "Smiley Smile Slime" Or comSlimeType.Text <> "Rainbow Cloud Slime" Or comSlimeType.Text <> "The Girl From K-Pop Demon Hunters Slime" Then
            MsgBox("Please enter a valid Slime", 48)
            Exit Sub
        End If


        'stuff for saving later
        If OnlySlime = True Then
            MsgBox("ordering slime")
        ElseIf OrderBoth = True Then
            MsgBox("ordering both")
            Exit Sub
        End If

        If OnlyActivator = True Then
            MsgBox("ordering activator")
        ElseIf OrderBoth = True Then
            MsgBox("ordering both")
            Exit Sub
        End If

    End Sub
End Class