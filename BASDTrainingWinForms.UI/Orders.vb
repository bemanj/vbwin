Imports BASDTraining.Entity

Public Class Orders
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim orderList = New OrderRepository().GetListData()

        If orderList.Count() > 0 Then
            Me.OrderDataGridView.DataSource = orderList
            Me.OrderDataGridView.AutoGenerateColumns = True
        End If

    End Sub

    Private Sub Orders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        'SelectedPizzaOrder = New PizzaOrders()
        'SelectedPizzaOrder.OrderNumber = 10

        '= 'CType(Me.OrderDataGridView.SelectedRows(0).Cells("OrderNumber").Value, Integer)
        PizzaOrder.ShowDialog(Me)
    End Sub
End Class