Public Class CryptographyForm

    Private _cryptographyFormServices As CryptographyFormServices

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _cryptographyFormServices = New CryptographyFormServices()
    End Sub


    Private Sub encryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles encryptButton.Click
        Dim _tmpOutput = _cryptographyFormServices.EncryptInput(Me.inputStringTextBox.Text)
        _cryptographyFormServices.DisplayOutput(Me.outputStringTextBox, _tmpOutput)
    End Sub

    Private Sub decryptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decryptButton.Click
        Dim _tmpOutput = _cryptographyFormServices.DecryptInput(Me.inputStringTextBox.Text)
        _cryptographyFormServices.DisplayOutput(Me.outputStringTextBox, _tmpOutput)
    End Sub

    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Application.Exit()
    End Sub
End Class
