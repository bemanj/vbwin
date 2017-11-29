Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ThreadSampleOneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThreadSampleOneButton.Click
        Me.ThreadSampleOneButton.Enabled = False
        Me.threadingBackgroundWorker.WorkerReportsProgress = True
        Me.threadingBackgroundWorker.RunWorkerAsync()

    End Sub

    Private Sub threadingBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles threadingBackgroundWorker.DoWork
        Try

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

End Class