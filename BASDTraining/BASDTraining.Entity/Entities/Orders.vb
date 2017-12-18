Public Class Orders
    Inherits BASD.Helper.Entity


    'Private _orderId As Integer
    'Public Property OrderId() As Integer
    '    Get
    '        Return _orderId
    '    End Get
    '    Set(ByVal value As Integer)
    '        _orderId = value
    '    End Set
    'End Property


    Private _customerName As String
    Public Property CustomerName() As String
        Get
            Return _customerName
        End Get
        Set(ByVal value As String)
            _customerName = value
        End Set
    End Property


    Private _address As String
    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(ByVal value As String)
            _address = value
        End Set
    End Property


    Private _emailAddress As String
    Public Property EmailAddress() As String
        Get
            Return _emailAddress
        End Get
        Set(ByVal value As String)
            _emailAddress = value
        End Set
    End Property


    Private _deliveryToAddress As Boolean
    Public Property DeliverToAddress() As Boolean
        Get
            Return _deliveryToAddress
        End Get
        Set(ByVal value As Boolean)
            _deliveryToAddress = value
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


    Private _deliveryDate As DateTime
    Public Property DeliveryDate() As DateTime
        Get
            Return _deliveryDate
        End Get
        Set(ByVal value As DateTime)
            _deliveryDate = value
        End Set
    End Property


    Private _pizzaType As Integer
    Public Property PizzaType() As Integer
        Get
            Return _pizzaType
        End Get
        Set(ByVal value As Integer)
            _pizzaType = value
        End Set
    End Property


    Private _crustType As String
    Public Property CrustType() As String
        Get
            Return _crustType
        End Get
        Set(ByVal value As String)
            _crustType = value
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


    Private _extraCheese As Boolean
    Public Property ExtraCheese() As Boolean
        Get
            Return _extraCheese
        End Get
        Set(ByVal value As Boolean)
            _extraCheese = value
        End Set
    End Property


    Private _extraPepperoni As Boolean
    Public Property ExtraPepperoni() As Boolean
        Get
            Return _extraPepperoni
        End Get
        Set(ByVal value As Boolean)
            _extraPepperoni = value
        End Set
    End Property


    Private _extraMushroom As Boolean
    Public Property ExtraMushroom() As Boolean
        Get
            Return _extraMushroom
        End Get
        Set(ByVal value As Boolean)
            _extraMushroom = value
        End Set
    End Property

End Class
