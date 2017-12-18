Imports BASD.Helper

Public Class CryptographyFormServices

    Private _baseCrypto As BaseCrypto

    Public Sub New()
        _baseCrypto = New BaseCrypto(BASDCryptoProvider.Trides)
    End Sub

    Public Function EncryptInput(ByVal inputString As String) As String
        Try
             Return _baseCrypto.EncryptString(inputString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return String.Empty
    End Function

    Public Function DecryptInput(ByVal inputString As String) As String
        Try
            Return _baseCrypto.DecryptString(inputString)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return String.Empty
    End Function

    Public Sub DisplayOutput(ByVal targetControl As TextBox, ByVal outputString As String)
        targetControl.Text = outputString
    End Sub

End Class
