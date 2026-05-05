Public Class Overview
    Private Sub Overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'displays all files of information on one form
        rtbActivatorLimit.LoadFile(Dir$("ActivatorLimit.txt"), RichTextBoxStreamType.PlainText)

        rtbCustomerInfo.LoadFile(Dir$("CustomerInfo.txt"), RichTextBoxStreamType.PlainText)

        rtbCustomerMailDetail.LoadFile(Dir$("CustomerMailDetail.txt"), RichTextBoxStreamType.PlainText)

        rtbCustomerOrders.LoadFile(Dir$("CustomerOrders.txt"), RichTextBoxStreamType.PlainText)

        rtbDeliveries.LoadFile(Dir$("Deliveries.txt"), RichTextBoxStreamType.PlainText)

        rtbEmployeePayroll.LoadFile(Dir$("EmployeePayroll.txt"), RichTextBoxStreamType.PlainText)

        rtbEmployeInfo.LoadFile(Dir$("EmployeeInfo.txt"), RichTextBoxStreamType.PlainText)

        rtbSimeRecipies.LoadFile(Dir$("SlimeRecipies.txt"), RichTextBoxStreamType.PlainText)

        rtbSlimeLimit.LoadFile(Dir$("SlimeLimit.txt"), RichTextBoxStreamType.PlainText)

        rtbSlimes.LoadFile(Dir$("Slimes.txt"), RichTextBoxStreamType.PlainText)

        rtbStock.LoadFile(Dir$("Stock.txt"), RichTextBoxStreamType.PlainText)

    End Sub

    Private Sub butBack_Click(sender As Object, e As EventArgs) Handles butBack.Click

        Admin_Menu.Show()
        Me.Close()

    End Sub
End Class