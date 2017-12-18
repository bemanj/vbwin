Imports BASD.Helper

Public Class LoginServices

    Private _cryptography As BaseCrypto
    Private _loginRepository As LoginRepository
    Private _libraryRepository As LibraryRepository
    Private _user As User

    Public Sub New()
        _cryptography = New BaseCrypto(BASDCryptoProvider.Trides)
        _loginRepository = New LoginRepository()
        _libraryRepository = New LibraryRepository()
        _user = New User()
    End Sub

    Public Function HasLogin(ByVal username As String, ByVal password As String) As Boolean
        _user.Username = username
        _user.Password = password

        Return Not _user.Username.Trim = "" And Not _user.Password.Trim = ""
    End Function

    Public Function LoginUser() As User
        Dim _tempUser = CType(_loginRepository.GetData(_user), User)
        If _user.Password = _cryptography.DecryptString(_tempUser.Password) Then
            _tempUser.Password = String.Empty
            Return _tempUser
        Else
            Return Nothing
        End If
    End Function

    Public Sub LoginApplication(ByVal user As User)
        If user IsNot Nothing Then
            CurrentUser = user
            AppLibrary = _libraryRepository.GetAggregate()
            LoginForm.Hide()
            OrdersForm.Show()
        Else
            MessageBox.Show("Invalid username/password.")
        End If
    End Sub

End Class
