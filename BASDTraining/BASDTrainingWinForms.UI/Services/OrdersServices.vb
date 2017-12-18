Imports BASD.Helper

Public Class OrdersServices

    Public Sub New()

        _cryptography = New BaseCrypto(BASDCryptoProvider.Trides)
        _orderRepository = New OrderRepository()

    End Sub

    Private _cryptography As BaseCrypto
    Private _orderRepository As OrderRepository


    Private _orderList As List(Of PizzaOrders)
    Public Property OrderList() As List(Of PizzaOrders)
        Get
            Return _orderList
        End Get
        Private Set(ByVal value As List(Of PizzaOrders))
            _orderList = value
        End Set
    End Property


    Private _isEdit As Boolean
    Public Property IsEdit() As Boolean
        Get
            Return _isEdit
        End Get
        Set(ByVal value As Boolean)
            _isEdit = value
        End Set
    End Property


    Public Sub GetOrderList()
        _orderList = _orderRepository.GetListData()
    End Sub

    Public Function SelectOrderFromList(ByVal orderId As Integer) As PizzaOrders
        'Dim _tempPizzaOrderEntity As New PizzaOrders

        'For Each info As System.Reflection.PropertyInfo In _tempPizzaOrderEntity.GetType().GetProperties()
        '    If Not info.PropertyType = GetType(String) Then
        '        _tempPizzaOrderEntity _
        '            .GetType _
        '            .GetProperty(info.Name) _
        '            .SetValue(_tempPizzaOrderEntity, Convert.ChangeType(selectedRow.Cells(info.Name).Value, info.PropertyType), Nothing)

        '    Else
        '        _tempPizzaOrderEntity _
        '            .GetType _
        '            .GetProperty(info.Name) _
        '            .SetValue(_tempPizzaOrderEntity, selectedRow.Cells(info.Name).Value.ToString, Nothing)

        '        '.SetValue(CType(_tempPizzaOrderEntity, Object))

        '    End If
        'Next

        Return _orderRepository.GetData(New PizzaOrders() With {.Id = orderId})

    End Function

End Class
