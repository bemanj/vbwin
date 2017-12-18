Public Class Employee
    Inherits BASD.Helper.Entity


    Private _firstname As String
    Public Property Firstname() As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
        End Set
    End Property


    Private _lastname As String
    Public Property Lastname() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property



    Private _rate As Decimal
    Public Property Rate() As Decimal
        Get
            Return _rate
        End Get
        Set(ByVal value As Decimal)
            _rate = value
        End Set
    End Property


    Private _employeeType As Integer
    Public Property EmployeeType() As Integer
        Get
            Return _employeeType
        End Get
        Set(ByVal value As Integer)
            _employeeType = value
        End Set
    End Property


End Class
