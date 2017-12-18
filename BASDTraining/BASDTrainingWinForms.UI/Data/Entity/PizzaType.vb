Imports BASD.Helper

Public Class PizzaType
    Inherits Entity


    Private _pizzaTypeCode As String
    Public Property PizzaTypeCode() As String
        Get
            Return _pizzaTypeCode
        End Get
        Set(ByVal value As String)
            _pizzaTypeCode = value
        End Set
    End Property


    Private _pizzaTypeValue As String
    Public Property PizzaTypeValue() As String
        Get
            Return _pizzaTypeValue
        End Get
        Set(ByVal value As String)
            _pizzaTypeValue = value
        End Set
    End Property


    Private _pizzaTypeDesc As String
    Public Property PizzaTypeDesc() As String
        Get
            Return _pizzaTypeDesc
        End Get
        Set(ByVal value As String)
            _pizzaTypeDesc = value
        End Set
    End Property


End Class
