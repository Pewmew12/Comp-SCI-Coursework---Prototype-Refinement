Public Class Employee_Menu
    Private Sub Employee_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'loads in sale information
        rtbSales.LoadFile(Dir$("CustomerOrders.txt"), RichTextBoxStreamType.PlainText)

    End Sub
End Class