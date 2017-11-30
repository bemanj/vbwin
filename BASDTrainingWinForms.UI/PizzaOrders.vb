Public Class PizzaOrders

    Private _customerName As String
    Public Property CustomerName() As String
        Get
            Return _customerName
        End Get
        Set(ByVal value As String)
            _customerName = value
        End Set
    End Property

    Private _pizzaSize As String
    Public Property PizzaSize() As String
        Get
            Return _pizzaSize
        End Get
        Set(ByVal value As String)
            _pizzaSize = value
        End Set
    End Property

    Private _deliveryAddress As String
    Public Property DeliveryAddress() As String
        Get
            Return _deliveryAddress
        End Get
        Set(ByVal value As String)
            _deliveryAddress = value
        End Set
    End Property


End Class
