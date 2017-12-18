Public Class EmployeeRecord

    Private _employeeTypes As List(Of EmployeeType)
    Private _employeeRepository As EmployeeRepository
    Private _selectedEmployeeRecord As Employee

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _employeeTypes = New List(Of EmployeeType)
        _employeeTypes.Add(New EmployeeType() With {.Id = 1, .EmployeeType = "Regular"})
        _employeeTypes.Add(New EmployeeType() With {.Id = 2, .EmployeeType = "Contractual"})

        Me.EmployeeTypeComboBox.DataSource = _employeeTypes
        Me.EmployeeTypeComboBox.ValueMember = "Id"
        Me.EmployeeTypeComboBox.DisplayMember = "EmployeeType"

        _employeeRepository = New EmployeeRepository()

        Me._selectedEmployeeRecord = Main.SelectedEmployeeRecord
        If Me._selectedEmployeeRecord.Id = 0 Then
            DeleteButton.Enabled = False
        Else
            Me.Text = "Employee Record (" & _selectedEmployeeRecord.Id.ToString & ")"
            FirstnameTextBox.Text = _selectedEmployeeRecord.Firstname
            LastnameTextBox.Text = _selectedEmployeeRecord.Lastname
            RateTextBox.Text = _selectedEmployeeRecord.Rate.ToString
            EmployeeTypeComboBox.SelectedValue = _selectedEmployeeRecord.EmployeeType
        End If
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If (ValidateFields()) Then
            _selectedEmployeeRecord.Firstname = FirstnameTextBox.Text
            _selectedEmployeeRecord.Lastname = LastnameTextBox.Text
            _selectedEmployeeRecord.Rate = Convert.ToDecimal(RateTextBox.Text)
            _selectedEmployeeRecord.EmployeeType = EmployeeTypeComboBox.SelectedValue
            Dim _tempResult = _employeeRepository.InsertData(_selectedEmployeeRecord)

            If _tempResult > 0 Then
                MessageBox.Show("Successfully Saved.", "Employee", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Main.LoadGrid()
                Me.Dispose()
                Me.Close()
            End If
        End If
    End Sub


    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If _selectedEmployeeRecord.Id = 0 Then
            MessageBox.Show("Record does not exists.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            _employeeRepository.DeleteData(_selectedEmployeeRecord)
            Main.LoadGrid()
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Public Function ValidateFields() As Boolean
        Try
            For Each formControls In Me.Controls()
                If formControls.GetType() = GetType(TextBox) Then
                    Dim _textBox = CType(formControls, TextBox)

                    If _textBox.Text.Trim = "" Or _textBox.Text.Trim = Nothing Then
                        MessageBox.Show(_textBox.Tag & ValidationSuffix, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        _textBox.Focus()
                        Return False
                    End If
                ElseIf formControls.GetType() = GetType(MaskedTextBox) Then

                    Dim _maskedTextBox = CType(formControls, MaskedTextBox)

                    If _maskedTextBox.Text.Trim = "" Or _maskedTextBox.Text.Trim = Nothing Then
                        MessageBox.Show(_maskedTextBox.Tag & ValidationSuffix, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        _maskedTextBox.Focus()
                        Return False
                    End If
                ElseIf formControls.GetType() = GetType(ComboBox) Then
                    Dim _comboBox = CType(formControls, ComboBox)
                    If _comboBox.Text.Trim = "" Or _comboBox.Text.Trim = Nothing Then

                        MessageBox.Show(_comboBox.Tag & ValidationSuffix, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        _comboBox.Focus()
                        Return False
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return True
    End Function

    Public Sub ClearFields()
        Try
            For Each formControls In Me.Controls()
                If formControls.GetType() = GetType(TextBox) Then
                    Dim _textBox = CType(formControls, TextBox)

                    _textBox.Clear()
                ElseIf formControls.GetType() = GetType(MaskedTextBox) Then

                    Dim _maskedTextBox = CType(formControls, MaskedTextBox)

                    _maskedTextBox.Clear()
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RateTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RateTextBox.KeyPress
        Dim _textBox As TextBox = DirectCast(sender, TextBox)
        If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or (e.KeyChar = "." And _textBox.Text.IndexOf(".") < 0) Or (e.KeyChar = "-" And _textBox.Text.Length = 0)) Then
            e.Handled = True
        End If

    End Sub
End Class