Imports WinForms.Logic

Public Class MainForm
    Private _mainService As Main
    Private _employeeList = New List(Of EmployeeBase)
    Private _employee As EmployeeBase
    'Private _gridDataTable As New DataTable
    'Private _grid2DataTable As New DataTable
    'Private _gridDataSet As New DataSet

    Public ReadOnly Property MainService() As Main
        Get
            Return _mainService
        End Get
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _mainService = New Main()
        'Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.DepartmentComboBox.DataSource = _mainService.DepartmentList
        Me.DepartmentComboBox.DisplayMember = "Name"
        Me.DepartmentComboBox.ValueMember = "Id"

        '_gridDataTable.Columns.Add(New DataColumn("Firstname", GetType(String)))
        '_gridDataTable.Columns.Add(New DataColumn("Lastname", GetType(String)))
        '_gridDataTable.Columns.Add(New DataColumn("Contractual", GetType(Boolean)))
        '_gridDataTable.TableName = "MyFirstTable"

        '_grid2DataTable.Columns.Add(New DataColumn("Firstname", GetType(String)))
        '_grid2DataTable.TableName = "MySecondTable"

        'Dim _newRow1 = _gridDataTable.NewRow()
        '_newRow1("Firstname") = "Rainier"
        '_newRow1("Lastname") = "Bacareza"
        '_newRow1("Contractual") = False
        '_gridDataTable.Rows.Add(_newRow1)

        'Dim _newRow2 = _gridDataTable.NewRow()
        '_newRow2("Firstname") = "Robert"
        '_newRow2("Lastname") = "Millano"
        '_newRow2("Contractual") = True
        '_gridDataTable.Rows.Add(_newRow2)

        'Dim _newRow3 = _grid2DataTable.NewRow()
        '_newRow3("Firstname") = "Rainier"
        '_grid2DataTable.Rows.Add(_newRow3)

        'Dim _newRow4 = _grid2DataTable.NewRow()
        '_newRow4("Firstname") = "Robert"
        '_grid2DataTable.Rows.Add(_newRow4)

        'Me._gridDataSet.Tables.Add(_gridDataTable)
        'Me._gridDataSet.Tables.Add(_grid2DataTable)

        'Me.EmployeeDataGridView.DataSource = _gridDataSet.Tables("MySecondTable")

    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Application.Exit()
    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitButton.Click
        Try

            Dim _selectedDepartment As DropDownBase = Me.DepartmentComboBox.SelectedItem
            Dim _selectedGender = Me.GetSelectedRadio("GenderPanel")
            Dim _selectedStatus = Me.GetSelectedRadio("StatusPanel")

            If _selectedStatus = "Contractual" Then
                _employee = New Contractual()
                _employee.Status = _selectedStatus
            ElseIf _selectedStatus = "Regular" Then
                _employee = New Regular()
                _employee.Status = _selectedStatus
            Else
                _employee = Nothing
            End If

            _employee.Firstname = Me.FirstnameTextBox.Text
            _employee.Lastname = Me.LastnameTextBox.Text
            _employee.Age = Me.AgeMaskedTextBox.Text
            _employee.Gender = _selectedGender
            _employee.DateHire = DateHireDateTimePicker.Value.ToString
            _employee.Rate = Convert.ToDecimal(Me.RateMaskedTextBox.Text)
            If Not _selectedDepartment Is Nothing Then
                _employee.Department = _selectedDepartment.Name
            End If

            _employeeList.Add(_employee)
            _employee = Nothing
            Me.EmployeeDataGridView.DataSource = Nothing
            Me.EmployeeDataGridView.DataSource = _employeeList

            '_mainService.EmployeeStatus = _selectedStatus

            '_mainService.Employee.Firstname = Me.FirstnameTextBox.Text
            '_mainService.Employee.Lastname = Me.LastnameTextBox.Text
            '_mainService.Employee.Age = Me.AgeMaskedTextBox.Text
            '_mainService.Employee.Gender = _selectedGender
            '_mainService.Employee.DateHire = DateHireDateTimePicker.Value.ToString
            '_mainService.Employee.Rate = Convert.ToDecimal(Me.RateMaskedTextBox.Text)
            'If Not _selectedDepartment Is Nothing Then
            '    _mainService.Employee.Department = _selectedDepartment.Name
            'End If

            '_mainService.SaveData()
            'Me.EmployeeDataGridView.DataSource = Nothing
            'Me.EmployeeDataGridView.DataSource = _mainService.EmployeeList
            'Me.EmployeeDataGridView.Update()

            'MessageBox.Show(_mainService.GetEmployeeDetails())

            Me.ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
    '    Me.TextBox1.Text = e.Start.ToString
    '    Me.TextBox2.Text = e.End.ToString
    'End Sub

    Private Sub EmployeeDataGridView_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDataGridView.SelectionChanged

    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CurrentUserLabel.Text = "Current user: " & _mainService.CurrentUser
        '"Current user: " & CurrentUser
    End Sub

    Private Sub OpenFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileButton.Click
        Dim _fileDialog = New OpenFileDialog()
        _fileDialog.Filter = "Text files (*.txt)|*.txt"
        _fileDialog.InitialDirectory = "C:\Users\RB004259604\Desktop\"
        _fileDialog.Multiselect = False
        _fileDialog.ShowDialog()

        Dim _path = _fileDialog.FileName
        MessageBox.Show(_path)

    End Sub
End Class
