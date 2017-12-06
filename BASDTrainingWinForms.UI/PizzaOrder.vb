Public Class PizzaOrder



    Private Sub PizzaOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim orders = CType(Me.Owner, Orders)

        'MessageBox.Show("Selected order is: " & orders.SelectedPizzaOrder.OrderNumber.ToString)

    End Sub
End Class