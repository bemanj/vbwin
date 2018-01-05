Public Class MainForm
    Public DepartmentList As List(Of Department)
    Public EmployeeList As New DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        DepartmentList = New List(Of Department)
        DepartmentList.Add(New Department() With {.Id = 1, .Name = "IT"})
        DepartmentList.Add(New Department() With {.Id = 2, .Name = "HR"})
        DepartmentList.Add(New Department() With {.Id = 3, .Name = "Admin"})

        Me.DepartmentListBox.DataSource = DepartmentList
        Me.DepartmentListBox.DisplayMember = "Name"
        Me.DepartmentListBox.ValueMember = "Id"

        'EmployeeList.Columns.Add(New DataColumn("Name", GetType(String)))
        'EmployeeList.Columns.Add(New DataColumn("Age", GetType(Integer)))
        'EmployeeList.Columns.Add(New DataColumn("Gender", GetType(String)))
        'EmployeeList.Columns.Add(New DataColumn("Name", GetType(String)))
        'Me.DepartmentComboBox.DataSource = DepartmentList

        'Me.DepartmentComboBox.ValueMember = "Id"
        'Me.DepartmentComboBox.DisplayMember = "Name"
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Application.Exit()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Try
            'Dim _selectedDepartment As Department = Me.DepartmentComboBox.SelectedItem
            Dim _selectedDepartment = Me.DepartmentListBox.SelectedItem
            Dim _selectedGender = GetSelectedRadio("GenderPanel")
            Dim _selectedStatus = GetSelectedRadio("StatusPanel")
            Dim _tempData As String = ""

            _tempData += "Name is " & Me.NameTextBox.Text & "." & vbCrLf
            _tempData += "Age is " & Me.AgeMaskedTextBox.Text & "." & vbCrLf
            If _selectedGender = String.Empty Then
                _tempData += "Gender is not selected." & vbCrLf
            Else
                _tempData += "Gender is " & _selectedGender & "." & vbCrLf
            End If

            If _selectedStatus = String.Empty Then
                _tempData += "Status is not selected." & vbCrLf
            Else
                _tempData += "Status is " & _selectedStatus & "." & vbCrLf
            End If
            If Not _selectedDepartment Is Nothing Then

                _tempData += "Department is " & _selectedDepartment.Name & "." & vbCrLf
            End If
            'MessageBox.Show(_tempData)

            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ClearFields()
        For Each _control In Me.Controls
            If _control.GetType() = GetType(TextBox) Then
                CType(_control, TextBox).Clear()
            ElseIf _control.GetType() = GetType(MaskedTextBox) Then
                CType(_control, MaskedTextBox).Clear()
            ElseIf _control.GetType() = GetType(ListBox) Then
                CType(_control, ListBox).SelectedItem = Nothing

            End If
            If _control.GetType() = GetType(Panel) Then
                For Each _panelControl In CType(_control, Panel).Controls

                    If _panelControl.GetType() = GetType(RadioButton) Then
                        CType(_panelControl, RadioButton).Checked = False
                    End If
                Next
            End If
        Next
    End Sub
    'How to use
    'Dim _selectedGender = GetSelectedRadio("GenderPanel")
    'Dim _selectedStatus = GetSelectedRadio("StatusPanel")
    Private Function GetSelectedRadio(ByVal containerName As String) As String
        Dim _iAmPanel As System.Windows.Forms.ScrollableControl = Me.Controls.Item(containerName)
        Dim _tempResult = ""
        For Each radio In _iAmPanel.Controls
            If radio.GetType() = GetType(RadioButton) Then
                If CType(radio, RadioButton).Checked Then
                    _tempResult = CType(radio, RadioButton).Text
                End If
            End If
        Next
        Return _tempResult
    End Function
End Class
