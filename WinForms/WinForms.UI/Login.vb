Public Class Login

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click
        'CurrentUser = Me.UsernameTextBox.Text
        MainForm.MainService.CurrentUser = Me.UsernameTextBox.Text
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        MessageBox.Show("asodkaoskd")
        Application.Exit()
    End Sub
End Class