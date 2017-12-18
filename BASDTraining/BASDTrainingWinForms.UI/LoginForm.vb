
Public Class LoginForm

    Private _loginServices As LoginServices

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _loginServices = New LoginServices()

    End Sub

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        If _loginServices.HasLogin(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text) Then
            _loginServices.LoginApplication(_loginServices.LoginUser())
        Else
            MessageBox.Show("Please enter credentials", _
                            "Security", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.UsernameTextBox.Focus()
    End Sub

    Private Sub Login_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Me.UsernameTextBox.Focus()
    End Sub
End Class