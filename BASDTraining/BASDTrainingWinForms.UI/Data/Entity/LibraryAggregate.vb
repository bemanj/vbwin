Public Class LibraryAggregate


    Private _pizzaTypeLibrary As List(Of PizzaType)
    Public Property PizzaTypeLibrary() As List(Of PizzaType)
        Get
            Return _pizzaTypeLibrary
        End Get
        Set(ByVal value As List(Of PizzaType))
            _pizzaTypeLibrary = value
        End Set
    End Property


End Class