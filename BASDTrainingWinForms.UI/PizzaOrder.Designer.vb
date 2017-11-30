<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CrustTypeGroubBox = New System.Windows.Forms.GroupBox()
        Me.ThinCrustRadioButton = New System.Windows.Forms.RadioButton()
        Me.HandTossedRadioButton = New System.Windows.Forms.RadioButton()
        Me.CIGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OIGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeliveryAddressCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DeliveryAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ContactNumberTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ExtraToppingGroupBox = New System.Windows.Forms.GroupBox()
        Me.CheeseCheckbox = New System.Windows.Forms.CheckBox()
        Me.PepperoniCheckBox = New System.Windows.Forms.CheckBox()
        Me.MushroomCheckBox = New System.Windows.Forms.CheckBox()
        Me.PizzaSizeGroupBox = New System.Windows.Forms.GroupBox()
        Me.DuoRadioButton = New System.Windows.Forms.RadioButton()
        Me.SoloRadioButton = New System.Windows.Forms.RadioButton()
        Me.FamilyRadioButton = New System.Windows.Forms.RadioButton()
        Me.PartyRadioButton = New System.Windows.Forms.RadioButton()
        Me.CrustTypeGroubBox.SuspendLayout()
        Me.CIGroupBox.SuspendLayout()
        Me.OIGroupBox.SuspendLayout()
        Me.ExtraToppingGroupBox.SuspendLayout()
        Me.PizzaSizeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(343, 390)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(424, 390)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CrustTypeGroubBox
        '
        Me.CrustTypeGroubBox.Controls.Add(Me.HandTossedRadioButton)
        Me.CrustTypeGroubBox.Controls.Add(Me.ThinCrustRadioButton)
        Me.CrustTypeGroubBox.Location = New System.Drawing.Point(362, 25)
        Me.CrustTypeGroubBox.Name = "CrustTypeGroubBox"
        Me.CrustTypeGroubBox.Size = New System.Drawing.Size(100, 65)
        Me.CrustTypeGroubBox.TabIndex = 2
        Me.CrustTypeGroubBox.TabStop = False
        Me.CrustTypeGroubBox.Text = "Crust Type"
        '
        'ThinCrustRadioButton
        '
        Me.ThinCrustRadioButton.AutoSize = True
        Me.ThinCrustRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.ThinCrustRadioButton.Name = "ThinCrustRadioButton"
        Me.ThinCrustRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.ThinCrustRadioButton.TabIndex = 0
        Me.ThinCrustRadioButton.TabStop = True
        Me.ThinCrustRadioButton.Text = "Thin Crust"
        Me.ThinCrustRadioButton.UseVisualStyleBackColor = True
        '
        'HandTossedRadioButton
        '
        Me.HandTossedRadioButton.AutoSize = True
        Me.HandTossedRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.HandTossedRadioButton.Name = "HandTossedRadioButton"
        Me.HandTossedRadioButton.Size = New System.Drawing.Size(89, 17)
        Me.HandTossedRadioButton.TabIndex = 1
        Me.HandTossedRadioButton.TabStop = True
        Me.HandTossedRadioButton.Text = "Hand Tossed"
        Me.HandTossedRadioButton.UseVisualStyleBackColor = True
        '
        'CIGroupBox
        '
        Me.CIGroupBox.Controls.Add(Me.EmailTextBox)
        Me.CIGroupBox.Controls.Add(Me.ContactNumberTextBox)
        Me.CIGroupBox.Controls.Add(Me.Label5)
        Me.CIGroupBox.Controls.Add(Me.Label4)
        Me.CIGroupBox.Controls.Add(Me.Label3)
        Me.CIGroupBox.Controls.Add(Me.AddressTextBox)
        Me.CIGroupBox.Controls.Add(Me.Label2)
        Me.CIGroupBox.Controls.Add(Me.LastnameTextBox)
        Me.CIGroupBox.Controls.Add(Me.FirstnameTextBox)
        Me.CIGroupBox.Controls.Add(Me.Label1)
        Me.CIGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.CIGroupBox.Name = "CIGroupBox"
        Me.CIGroupBox.Size = New System.Drawing.Size(486, 162)
        Me.CIGroupBox.TabIndex = 3
        Me.CIGroupBox.TabStop = False
        Me.CIGroupBox.Text = "Customer Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Contact Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(121, 75)
        Me.AddressTextBox.MaxLength = 255
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(108, 80)
        Me.AddressTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Lastname"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Location = New System.Drawing.Point(121, 48)
        Me.LastnameTextBox.MaxLength = 50
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(108, 20)
        Me.LastnameTextBox.TabIndex = 13
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(121, 22)
        Me.FirstnameTextBox.MaxLength = 50
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(108, 20)
        Me.FirstnameTextBox.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Firstname"
        '
        'OIGroupBox
        '
        Me.OIGroupBox.Controls.Add(Me.PizzaSizeGroupBox)
        Me.OIGroupBox.Controls.Add(Me.ExtraToppingGroupBox)
        Me.OIGroupBox.Controls.Add(Me.ComboBox1)
        Me.OIGroupBox.Controls.Add(Me.Label8)
        Me.OIGroupBox.Controls.Add(Me.DeliveryDateDateTimePicker)
        Me.OIGroupBox.Controls.Add(Me.Label7)
        Me.OIGroupBox.Controls.Add(Me.Label6)
        Me.OIGroupBox.Controls.Add(Me.DeliveryAddressCheckBox)
        Me.OIGroupBox.Controls.Add(Me.DeliveryAddressTextBox)
        Me.OIGroupBox.Controls.Add(Me.CrustTypeGroubBox)
        Me.OIGroupBox.Location = New System.Drawing.Point(13, 181)
        Me.OIGroupBox.Name = "OIGroupBox"
        Me.OIGroupBox.Size = New System.Drawing.Size(486, 203)
        Me.OIGroupBox.TabIndex = 4
        Me.OIGroupBox.TabStop = False
        Me.OIGroupBox.Text = "Order Information"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(270, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Email"
        '
        'DeliveryAddressCheckBox
        '
        Me.DeliveryAddressCheckBox.AutoSize = True
        Me.DeliveryAddressCheckBox.Location = New System.Drawing.Point(28, 19)
        Me.DeliveryAddressCheckBox.Name = "DeliveryAddressCheckBox"
        Me.DeliveryAddressCheckBox.Size = New System.Drawing.Size(179, 17)
        Me.DeliveryAddressCheckBox.TabIndex = 3
        Me.DeliveryAddressCheckBox.Text = "Delivery address same as above"
        Me.DeliveryAddressCheckBox.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Delivery address"
        '
        'DeliveryAddressTextBox
        '
        Me.DeliveryAddressTextBox.Location = New System.Drawing.Point(121, 42)
        Me.DeliveryAddressTextBox.MaxLength = 255
        Me.DeliveryAddressTextBox.Multiline = True
        Me.DeliveryAddressTextBox.Name = "DeliveryAddressTextBox"
        Me.DeliveryAddressTextBox.Size = New System.Drawing.Size(108, 80)
        Me.DeliveryAddressTextBox.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Delivery date"
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(362, 22)
        Me.ContactNumberTextBox.Mask = "0000-0000000"
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactNumberTextBox.TabIndex = 20
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(362, 48)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 21
        '
        'DeliveryDateDateTimePicker
        '
        Me.DeliveryDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DeliveryDateDateTimePicker.Location = New System.Drawing.Point(121, 135)
        Me.DeliveryDateDateTimePicker.Name = "DeliveryDateDateTimePicker"
        Me.DeliveryDateDateTimePicker.Size = New System.Drawing.Size(108, 20)
        Me.DeliveryDateDateTimePicker.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Pizza"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox1.TabIndex = 28
        '
        'ExtraToppingGroupBox
        '
        Me.ExtraToppingGroupBox.Controls.Add(Me.MushroomCheckBox)
        Me.ExtraToppingGroupBox.Controls.Add(Me.PepperoniCheckBox)
        Me.ExtraToppingGroupBox.Controls.Add(Me.CheeseCheckbox)
        Me.ExtraToppingGroupBox.Location = New System.Drawing.Point(267, 25)
        Me.ExtraToppingGroupBox.Name = "ExtraToppingGroupBox"
        Me.ExtraToppingGroupBox.Size = New System.Drawing.Size(89, 92)
        Me.ExtraToppingGroupBox.TabIndex = 29
        Me.ExtraToppingGroupBox.TabStop = False
        Me.ExtraToppingGroupBox.Text = "Extra Topping"
        '
        'CheeseCheckbox
        '
        Me.CheeseCheckbox.AutoSize = True
        Me.CheeseCheckbox.Location = New System.Drawing.Point(7, 20)
        Me.CheeseCheckbox.Name = "CheeseCheckbox"
        Me.CheeseCheckbox.Size = New System.Drawing.Size(62, 17)
        Me.CheeseCheckbox.TabIndex = 0
        Me.CheeseCheckbox.Text = "Cheese"
        Me.CheeseCheckbox.UseVisualStyleBackColor = True
        '
        'PepperoniCheckBox
        '
        Me.PepperoniCheckBox.AutoSize = True
        Me.PepperoniCheckBox.Location = New System.Drawing.Point(7, 43)
        Me.PepperoniCheckBox.Name = "PepperoniCheckBox"
        Me.PepperoniCheckBox.Size = New System.Drawing.Size(74, 17)
        Me.PepperoniCheckBox.TabIndex = 1
        Me.PepperoniCheckBox.Text = "Pepperoni"
        Me.PepperoniCheckBox.UseVisualStyleBackColor = True
        '
        'MushroomCheckBox
        '
        Me.MushroomCheckBox.AutoSize = True
        Me.MushroomCheckBox.Location = New System.Drawing.Point(7, 66)
        Me.MushroomCheckBox.Name = "MushroomCheckBox"
        Me.MushroomCheckBox.Size = New System.Drawing.Size(75, 17)
        Me.MushroomCheckBox.TabIndex = 2
        Me.MushroomCheckBox.Text = "Mushroom"
        Me.MushroomCheckBox.UseVisualStyleBackColor = True
        '
        'PizzaSizeGroupBox
        '
        Me.PizzaSizeGroupBox.Controls.Add(Me.PartyRadioButton)
        Me.PizzaSizeGroupBox.Controls.Add(Me.FamilyRadioButton)
        Me.PizzaSizeGroupBox.Controls.Add(Me.DuoRadioButton)
        Me.PizzaSizeGroupBox.Controls.Add(Me.SoloRadioButton)
        Me.PizzaSizeGroupBox.Location = New System.Drawing.Point(267, 123)
        Me.PizzaSizeGroupBox.Name = "PizzaSizeGroupBox"
        Me.PizzaSizeGroupBox.Size = New System.Drawing.Size(195, 65)
        Me.PizzaSizeGroupBox.TabIndex = 3
        Me.PizzaSizeGroupBox.TabStop = False
        Me.PizzaSizeGroupBox.Text = "Pizza Size"
        '
        'DuoRadioButton
        '
        Me.DuoRadioButton.AutoSize = True
        Me.DuoRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.DuoRadioButton.Name = "DuoRadioButton"
        Me.DuoRadioButton.Size = New System.Drawing.Size(45, 17)
        Me.DuoRadioButton.TabIndex = 1
        Me.DuoRadioButton.TabStop = True
        Me.DuoRadioButton.Text = "Duo"
        Me.DuoRadioButton.UseVisualStyleBackColor = True
        '
        'SoloRadioButton
        '
        Me.SoloRadioButton.AutoSize = True
        Me.SoloRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.SoloRadioButton.Name = "SoloRadioButton"
        Me.SoloRadioButton.Size = New System.Drawing.Size(46, 17)
        Me.SoloRadioButton.TabIndex = 0
        Me.SoloRadioButton.TabStop = True
        Me.SoloRadioButton.Text = "Solo"
        Me.SoloRadioButton.UseVisualStyleBackColor = True
        '
        'FamilyRadioButton
        '
        Me.FamilyRadioButton.AutoSize = True
        Me.FamilyRadioButton.Location = New System.Drawing.Point(101, 17)
        Me.FamilyRadioButton.Name = "FamilyRadioButton"
        Me.FamilyRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.FamilyRadioButton.TabIndex = 2
        Me.FamilyRadioButton.TabStop = True
        Me.FamilyRadioButton.Text = "Family"
        Me.FamilyRadioButton.UseVisualStyleBackColor = True
        '
        'PartyRadioButton
        '
        Me.PartyRadioButton.AutoSize = True
        Me.PartyRadioButton.Location = New System.Drawing.Point(101, 40)
        Me.PartyRadioButton.Name = "PartyRadioButton"
        Me.PartyRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.PartyRadioButton.TabIndex = 3
        Me.PartyRadioButton.TabStop = True
        Me.PartyRadioButton.Text = "Party"
        Me.PartyRadioButton.UseVisualStyleBackColor = True
        '
        'PizzaOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 422)
        Me.Controls.Add(Me.OIGroupBox)
        Me.Controls.Add(Me.CIGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "PizzaOrder"
        Me.Text = "Pizza Order"
        Me.CrustTypeGroubBox.ResumeLayout(False)
        Me.CrustTypeGroubBox.PerformLayout()
        Me.CIGroupBox.ResumeLayout(False)
        Me.CIGroupBox.PerformLayout()
        Me.OIGroupBox.ResumeLayout(False)
        Me.OIGroupBox.PerformLayout()
        Me.ExtraToppingGroupBox.ResumeLayout(False)
        Me.ExtraToppingGroupBox.PerformLayout()
        Me.PizzaSizeGroupBox.ResumeLayout(False)
        Me.PizzaSizeGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents CrustTypeGroubBox As System.Windows.Forms.GroupBox
    Friend WithEvents HandTossedRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ThinCrustRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CIGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OIGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DeliveryAddressCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DeliveryAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveryDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ExtraToppingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MushroomCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PepperoniCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CheeseCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents PizzaSizeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DuoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SoloRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PartyRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FamilyRadioButton As System.Windows.Forms.RadioButton
End Class
