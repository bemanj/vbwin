Imports System.Linq



Public Class Main
    Dim _gender As String
    Dim _list As List(Of City)

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        _list = New List(Of City)
        _list.Add(New City() With {.Name = "Manila", .Code = "MNL"})
        _list.Add(New City() With {.Name = "Cavite", .Code = "CAV"})

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ListBox1.DataSource = _list
        Me.ListBox1.ValueMember = "Code"
        Me.ListBox1.DisplayMember = "Name"
        Me.ListBox1.SelectedItem = Nothing

    End Sub

    Private Sub ThreadSampleOneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreadSampleOneButton.Click
        Me.ThreadSampleOneButton.Enabled = False
        Me.threadingBackgroundWorker.WorkerReportsProgress = True
        Me.threadingBackgroundWorker.RunWorkerAsync("asdkjaskd")

    End Sub

    Private Sub threadingBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles threadingBackgroundWorker.DoWork
        Try
            'e.Argument
            Dim counter As Integer
            counter = 0
            Do
                counter += 1
                Me.threadingBackgroundWorker.ReportProgress(counter)
                System.Threading.Thread.Sleep(200)
            Loop While counter < 100
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub threadingBackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles threadingBackgroundWorker.RunWorkerCompleted
        Try
            MessageBox.Show("Threading Complete.")
            Me.ThreadSampleOneButton.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub threadingBackgroundWorker_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles threadingBackgroundWorker.ProgressChanged
        Try
            Me.ThreadingProgressBar.Value = e.ProgressPercentage
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ThreadSampleTwoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreadSampleTwoButton.Click
        Try
            Dim counter As Integer
            counter = 0
            Do
                counter += 1
                Me.ThreadingProgressBar.Value = counter
                System.Threading.Thread.Sleep(200)
            Loop While counter < 100
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SubmitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged, RadioButton.CheckedChanged
        Dim radio = CType(sender, RadioButton)
        If radio.Checked Then
            MessageBox.Show(radio.Text)
            _gender = radio.Text
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'SELECTING RADIO BUTTON VALUE WITH BUTTON CLICK
        'Dim genderRadios = Panel1.Controls
        'For Each genderRadio As RadioButton In genderRadios
        '    If genderRadio.Checked Then
        '        MessageBox.Show(genderRadio.Text)
        '    End If
        'Next

        'SELECTING SELECTED ITEMS ON LISTITEM
        'Dim arrSelectedItems = ListBox1.SelectedItems.OfType(Of String)()
        'Dim selectedItems = String.Join(",", arrSelectedItems.ToArray())


        Dim answerCheckBoxes = Panel2.Controls
        For Each answerCheckBox As CheckBox In answerCheckBoxes

            Select Case answerCheckBox.CheckState
                Case CheckState.Checked
                    MessageBox.Show(answerCheckBox.Text & " is Checked")

                Case CheckState.Unchecked
                    MessageBox.Show(answerCheckBox.Text & " is Unchecked")

                Case CheckState.Indeterminate
                    MessageBox.Show(answerCheckBox.Text & " is Indeterminate")

            End Select

        Next

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Me.TextBox3.Text = CType(sender, TextBox).Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        
    End Sub
End Class