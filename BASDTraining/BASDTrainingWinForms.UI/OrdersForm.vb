Imports BASDTraining.Entity
Imports BASD.Helper

Public Class OrdersForm

    Private _ordersServices As OrdersServices

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        _ordersServices = New OrdersServices()

    End Sub

    Private Sub Orders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _ordersServices.GetOrderList()

        Me.OrderDataGridView.DataSource = _ordersServices.OrderList
        Me.OrderDataGridView.AutoGenerateColumns = True
    End Sub

    Private Sub AddOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOrderToolStripMenuItem.Click
        PizzaOrderForm.ShowDialog(Me)
    End Sub

    Private Sub OrderDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderDataGridView.SelectionChanged
        Dim gridView As DataGridView = CType(sender, DataGridView)
        Dim selectedRow = gridView.SelectedRows(0)
        Me.CustomerNameTextBox.Text = selectedRow.Cells("CustomerName").Value.ToString
        Me.CustomerContactTextBox.Text = selectedRow.Cells("CustomerContact").Value.ToString
        Me.OrderStatusTextBox.Text = selectedRow.Cells("Status").Value.ToString

    End Sub

    Private Sub OpenOrderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenOrderButton.Click

        Try
            Dim _tempSelectedRow = Me._ordersServices.SelectOrderFromList(CInt(Me.OrderDataGridView.SelectedRows(0).Cells("Id").Value))
            'Dim _tempPizzaOrderForm As PizzaOrderForm
            PizzaOrderForm.IsEdit = True
            PizzaOrderForm.PizzaOrderService.PizzaOrder = _tempSelectedRow
            PizzaOrderForm.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '


        '_pizzaOrderForm = New PizzaOrderForm(True, _tempSelectedData)
        '_pizzaOrderForm.ShowDialog(Me)
        'With PizzaOrderForm

        '    .PizzaOrderService.PizzaOrder =
        '    .IsEdit = True
        'End With

        'PizzaOrderForm.ShowDialog(Me)

    End Sub
End Class