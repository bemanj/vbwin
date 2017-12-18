Public Class EmployeeType
    Inherits BASD.Helper.Entity

    Private _employeeType As String
    Public Property EmployeeType() As String
        Get
            Return _employeeType
        End Get
        Set(ByVal value As String)
            _employeeType = value
        End Set
    End Property

End Class
