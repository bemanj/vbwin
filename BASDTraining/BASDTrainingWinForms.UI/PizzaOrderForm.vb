Public Class PizzaOrderForm


    'Private _pizzaOrderService As PizzaOrderServices
    Private _isEdit As Boolean
    Public Property IsEdit() As Boolean
        Get
            Return _isEdit
        End Get
        Set(ByVal value As Boolean)
            _isEdit = value
        End Set
    End Property

    Private _pizzaOrderService As PizzaOrderServices
    Public Property PizzaOrderService() As PizzaOrderServices
        Get
            Return _pizzaOrderService
        End Get
        Set(ByVal value As PizzaOrderServices)
            _pizzaOrderService = value
        End Set
    End Property


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _pizzaOrderService = New PizzaOrderServices()

    End Sub

    'Public Sub New(ByVal isEdit As Boolean, Optional ByVal pizzaOrder As PizzaOrders = Nothing)

    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    _pizzaOrderService = New PizzaOrderServices()
    'End Sub


    Private Sub PizzaOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PizzaTypeComboBox.DataSource = AppLibrary.PizzaTypeLibrary
        With PizzaTypeComboBox
            .DataSource = AppLibrary.PizzaTypeLibrary
            .ValueMember = "Id"
            .DisplayMember = "PizzaTypeDesc"
        End With
        If _isEdit Then
            _pizzaOrderService.PopulateFields(Me)
        End If


    End Sub
End Class