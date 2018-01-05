Public Class Main

    Public Sub New()
        DepartmentList = New List(Of DropDownBase)
        EmployeeList = New List(Of EmployeeBase)
        DepartmentList.Add(New DropDownBase() With {.Id = 1, .Name = "IT"})
        DepartmentList.Add(New DropDownBase() With {.Id = 2, .Name = "HR"})
        DepartmentList.Add(New DropDownBase() With {.Id = 3, .Name = "Admin"})
    End Sub

    Public Property CurrentUser As String

    Private _employeeList As List(Of EmployeeBase)
    Public Property EmployeeList() As List(Of EmployeeBase)
        Get
            Return _employeeList
        End Get
        Set(ByVal value As List(Of EmployeeBase))
            _employeeList = value
        End Set
    End Property

    Private _departmentList As List(Of DropDownBase)
    Public Property DepartmentList() As List(Of DropDownBase)
        Get
            Return _departmentList
        End Get
        Set(ByVal value As List(Of DropDownBase))
            _departmentList = value
        End Set
    End Property



    Private _employee As EmployeeBase
    Public Property Employee() As EmployeeBase
        Get
            Return _employee
        End Get
        Set(ByVal value As EmployeeBase)
            _employee = value
        End Set
    End Property


    Private _employeeStatus As String
    Public Property EmployeeStatus() As String
        Get
            Return _employeeStatus
        End Get
        Set(ByVal value As String)
            _employeeStatus = value
            If _employeeStatus.Equals("Contractual") Then
                Employee = New Contractual()
                Employee.Status = _employeeStatus
            ElseIf _employeeStatus.Equals("Regular") Then
                Employee = New Regular()
                Employee.Status = _employeeStatus
            Else
                Employee = Nothing
            End If
        End Set
    End Property

    Public Function GetEmployeeDetails() As String

        Dim _tempData As String = ""

        _tempData += "Name is " & Employee.Lastname & ", " & Employee.Firstname & "." & vbCrLf
        _tempData += "Age is " & Me.Employee.Age & "." & vbCrLf
        If Employee.Gender = String.Empty Then
            _tempData += "Gender is not selected." & vbCrLf
        Else
            _tempData += "Gender is " & Employee.Gender & "." & vbCrLf
        End If
        _tempData += "Department is " & Employee.Department & "." & vbCrLf
        _tempData += "Salary is " & Employee.GetSalary().ToString("#.00") & "." & vbCrLf
        _tempData += "Date hire is " & String.Format(Employee.DateHire, "{0:mm/dd/yyyy}") & "." & vbCrLf

        If Employee.Status = String.Empty Then
            _tempData += "Status is not selected." & vbCrLf
        Else
            _tempData += "Status is " & Employee.Status & "." & vbCrLf
        End If

        Return _tempData
    End Function

    Public Sub SaveData()
        EmployeeList.Add(Employee)
        If _employeeStatus.Equals("Contractual") Then
            Employee = New Contractual()
            Employee.Status = _employeeStatus
        ElseIf _employeeStatus.Equals("Regular") Then
            Employee = New Regular()
            Employee.Status = _employeeStatus
        Else
            Employee = Nothing
        End If
    End Sub

End Class
