Imports Cryption.Cryption

Public Class CryptoTool

    Private _cipher As Cryption.Cryption

    'Public Sub New()
    '    _cipher = New Cryption.Cryption()
    'End Sub


    Public Sub New(ByVal cipher As Cryption.Cryption)
        _cipher = cipher
    End Sub

    Public Function Encrypt(ByVal toEncrypt As String) As String
        Return _cipher.EncryptString(Cryption.Cryption.CryptographyProvider.TriDES, toEncrypt)
    End Function

    Public Function Decrypt(ByVal toDecrypt As String) As String
        Return _cipher.DecryptString(Cryption.Cryption.CryptographyProvider.TriDES, toDecrypt)
    End Function

End Class