Public Class Employee_Menu
    Private Sub Employee_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rtbSales.LoadFile(Dir$("CustomerOrders.txt"), RichTextBoxStreamType.PlainText)

    End Sub
End Class