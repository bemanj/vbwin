Module MainModule


    Private _currentUser As User
    Public Property CurrentUser() As User
        Get
            Return _currentUser
        End Get
        Set(ByVal value As User)
            _currentUser = value
        End Set
    End Property


    Private _appLibrary As LibraryAggregate
    Public Property AppLibrary() As LibraryAggregate
        Get
            Return _appLibrary
        End Get
        Set(ByVal value As LibraryAggregate)
            _appLibrary = value
        End Set
    End Property


End Module
