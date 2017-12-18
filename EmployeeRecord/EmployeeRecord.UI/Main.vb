Public Class Main

    Private _employeeRepository As EmployeeRepository
    Private _selectedEmployeeRecord As Employee

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _employeeRepository = New EmployeeRepository()

    End Sub
    Public Property SelectedEmployeeRecord() As Employee
        Get
            Return _selectedEmployeeRecord
        End Get
        Set(ByVal value As Employee)
            _selectedEmployeeRecord = value
        End Set
    End Property

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub AddEmployeeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmployeeButton.Click

        Me.SelectedEmployeeRecord = New Employee()
        Me.SelectedEmployeeRecord.Id = 0

        EmployeeRecord.Show(Me)

    End Sub

    Public Sub LoadGrid()
        Dim _tempEmployeeList = _employeeRepository.GetListData()

        Me.EmployeeDataGridView.DataSource = _tempEmployeeList
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub EmployeeDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeDataGridView.DoubleClick
        Try

            Dim _tempSelectedRow = Me.EmployeeDataGridView.SelectedRows(0)
            SelectedEmployeeRecord = New Employee()
            SelectedEmployeeRecord.Id = _tempSelectedRow.Cells("Id").Value
            SelectedEmployeeRecord = _employeeRepository.GetData(SelectedEmployeeRecord)

            EmployeeRecord.ShowDialog(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EmployeeRecord.Dispose()
            EmployeeRecord.Close()
        End Try

    End Sub
End Class
