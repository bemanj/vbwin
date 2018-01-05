Public MustInherit Class EmployeeBase

    Public Overridable Function GetSalary() As Decimal
        Return Math.Round((Me.Rate * 12) / 26)
    End Function

    Private _lastname As String
    Public Property Lastname() As String
        Get
            Return _lastname
        End Get
        Set(ByVal value As String)
            _lastname = value
        End Set
    End Property

    Private _firstname As String
    Public Property Firstname() As String
        Get
            Return _firstname
        End Get
        Set(ByVal value As String)
            _firstname = value
        End Set
    End Property


    Private _age As Integer
    Public Property Age() As Integer
        Get
            Return _age
        End Get
        Set(ByVal value As Integer)
            _age = value
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


    Private _dateHire As String
    Public Property DateHire() As String
        Get
            Return _dateHire
        End Get
        Set(ByVal value As String)
            _dateHire = value
        End Set
    End Property


End Class
