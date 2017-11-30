Public Class Orders
    Dim _listOfOrders As List(Of PizzaOrders)
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _listOfOrders = New List(Of PizzaOrders)
        _listOfOrders.Add(New PizzaOrders() With { _
                          .CustomerName = "Rainier", _
                          .DeliveryAddress = "CG1", _
                          .PizzaSize = "Party"})
        _listOfOrders.Add(New PizzaOrders() With { _
                          .CustomerName = "Robert", _
                          .DeliveryAddress = "CG1", _
                          .PizzaSize = "Solo"})

    End Sub

    Private Sub Orders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OrderDataGridView.DataSource = _listOfOrders
        'Me.Or()
        'Me.OrderDataGridView
    End Sub

    Private Sub AddOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOrderToolStripMenuItem.Click
        PizzaOrder.ShowDialog(Me)
    End Sub

End Class