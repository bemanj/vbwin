Public Class Orders
    Dim _listOfOrders As List(Of PizzaOrders)

    Private _selectedPizzaOrder As PizzaOrders
    Public Property SelectedPizzaOrder() As PizzaOrders
        Get
            Return _selectedPizzaOrder
        End Get
        Set(ByVal value As PizzaOrders)
            _selectedPizzaOrder = value
        End Set
    End Property


    Private _selectedOrder As String
    Public Property SelectedOrder() As String
        Get
            Return _selectedOrder
        End Get
        Private Set(ByVal value As String)
            _selectedOrder = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.OrderDataGridView.AutoGenerateColumns = False
        ' Add any initialization after the InitializeComponent() call.
        _listOfOrders = New List(Of PizzaOrders)
        _listOfOrders.Add(New PizzaOrders() With { _
                          .OrderNumber = 1, _
                          .CustomerName = "Rainier", _
                          .DeliveryAddress = "CG1", _
                          .PizzaSize = "Party", _
                        .CustomerContact = "09097654321", _
                          .OrderStatus = "Pending"})

        _listOfOrders.Add(New PizzaOrders() With { _
                          .OrderNumber = 2, _
                          .CustomerName = "Robert", _
                          .DeliveryAddress = "CG1", _
                          .PizzaSize = "Solo", _
                          .CustomerContact = "09091234567", _
                          .OrderStatus = "Done"})

    End Sub

    Private Sub Orders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.OrderDataGridView.Columns.Add(New DataGridViewColumn() With {.Name = "Customer Name", .DataPropertyName = "CustomerName"})
        'Me.OrderDataGridView.Columns.Add(New DataGridViewColumn() With {.Name = "Delivery Address", .DataPropertyName = "DeliveryAddress"})
        'Me.OrderDataGridView.Columns.Add(New DataGridViewColumn() With {.Name = "Pizza Size", .DataPropertyName = "PizzaSize"})
        Me.OrderDataGridView.DataSource = _listOfOrders
        'Me.OrderDataGridView.

        'Me.OrderDataGridView
    End Sub

    Private Sub AddOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOrderToolStripMenuItem.Click
        PizzaOrder.ShowDialog(Me)
    End Sub

    Private Sub OrderDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderDataGridView.SelectionChanged
        Dim gridView As DataGridView = CType(sender, DataGridView)
        Dim selectedRow = gridView.SelectedRows(0)
        Me.CustomerNameTextBox.Text = selectedRow.Cells("CustomerName").Value.ToString
        Me.CustomerContactTextBox.Text = selectedRow.Cells("CustomerContact").Value.ToString
        Me.OrderStatusTextBox.Text = selectedRow.Cells("Status").Value.ToString

    End Sub

    Private Sub OpenOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOrderButton.Click
        SelectedPizzaOrder = New PizzaOrders()
        SelectedPizzaOrder.OrderNumber = 10

        '= 'CType(Me.OrderDataGridView.SelectedRows(0).Cells("OrderNumber").Value, Integer)
        PizzaOrder.ShowDialog(Me)
    End Sub
End Class