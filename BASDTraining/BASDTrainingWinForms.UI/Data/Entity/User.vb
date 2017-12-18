
Public Class User
    Inherits BASD.Helper.Entity

    Private _username As String
    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(ByVal value As String)
            _username = value
        End Set
    End Property

    Private _password As String
    Public Property Password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property


    Private _role As String
    Public Property Role() As String
        Get
            Return _role
        End Get
        Set(ByVal value As String)
            _role = value
        End Set
    End Property


End Class
