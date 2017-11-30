Public Class PizzaOrders


    Private _orderNumber As Integer
    Public Property OrderNumber() As Integer
        Get
            Return _orderNumber
        End Get
        Set(ByVal value As Integer)
            _orderNumber = value
        End Set
    End Property


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


    Private _orderStatus As String
    Public Property OrderStatus() As String
        Get
            Return _orderStatus
        End Get
        Set(ByVal value As String)
            _orderStatus = value
        End Set
    End Property


    Private _customerContact As String
    Public Property CustomerContact() As String
        Get
            Return _customerContact
        End Get
        Set(ByVal value As String)
            _customerContact = value
        End Set
    End Property

End Class
