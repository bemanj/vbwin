Public Class PizzaOrderServices

    Private _orderRepository As OrderRepository
    Private _pizzaOrder As PizzaOrders

    Public Sub New()

        _orderRepository = New OrderRepository()

    End Sub

    Public Property PizzaOrder() As PizzaOrders
        Get
            Return _pizzaOrder
        End Get
        Set(ByVal value As PizzaOrders)
            _pizzaOrder = value
        End Set
    End Property

    Public Sub PopulateFields(ByVal owner As PizzaOrderForm)
        'CType(owner.Controls.Find("FirstnameTextBox", True), TextBox).

        With owner
            .FirstnameTextBox.Text = PizzaOrder.CustomerName.Split(",")(1)
            .LastnameTextBox.Text = PizzaOrder.CustomerName.Split(",")(0)
            .AddressTextBox.Text = PizzaOrder.Address
            .ContactNumberTextBox.Text = PizzaOrder.ContactNumber
            .EmailTextBox.Text = PizzaOrder.EmailAddress
            .DeliveryAddressCheckBox.Checked = PizzaOrder.DeliverToAddress
            .DeliveryAddressTextBox.Text = IIf(PizzaOrder.DeliverToAddress, String.Empty, PizzaOrder.DeliveryAddress)
            .DeliveryDateDateTimePicker.Text = PizzaOrder.DeliveryDate.ToString("MM/dd/yyyy")
            .PizzaTypeComboBox.SelectedValue = PizzaOrder.PizzaType
            .CheeseCheckbox.Checked = PizzaOrder.ExtraCheese
            .PepperoniCheckBox.Checked = PizzaOrder.ExtraPepperoni
            .MushroomCheckBox.Checked = PizzaOrder.ExtraMushroom
            .ThinCrustRadioButton.Checked = PizzaOrder.CrustType = "THIN"
            .HandTossedRadioButton.Checked = PizzaOrder.CrustType = "HAND TOSSED"

            .SoloRadioButton.Checked = PizzaOrder.PizzaSize = "SOLO"
            .DuoRadioButton.Checked = PizzaOrder.PizzaSize = "DUO"
            .FamilyRadioButton.Checked = PizzaOrder.PizzaSize = "FAMILY"
            .PartyRadioButton.Checked = PizzaOrder.PizzaSize = "PARTY"

        End With


    End Sub


End Class
