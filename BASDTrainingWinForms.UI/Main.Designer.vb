<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.threadingBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ThreadSampleOneButton = New System.Windows.Forms.Button()
        Me.ThreadSampleTwoButton = New System.Windows.Forms.Button()
        Me.ThreadingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'threadingBackgroundWorker
        '
        '
        'ThreadSampleOneButton
        '
        Me.ThreadSampleOneButton.Location = New System.Drawing.Point(136, 61)
        Me.ThreadSampleOneButton.Name = "ThreadSampleOneButton"
        Me.ThreadSampleOneButton.Size = New System.Drawing.Size(75, 23)
        Me.ThreadSampleOneButton.TabIndex = 0
        Me.ThreadSampleOneButton.Text = "Thread"
        Me.ThreadSampleOneButton.UseVisualStyleBackColor = True
        '
        'ThreadSampleTwoButton
        '
        Me.ThreadSampleTwoButton.Location = New System.Drawing.Point(217, 61)
        Me.ThreadSampleTwoButton.Name = "ThreadSampleTwoButton"
        Me.ThreadSampleTwoButton.Size = New System.Drawing.Size(75, 23)
        Me.ThreadSampleTwoButton.TabIndex = 1
        Me.ThreadSampleTwoButton.Text = "No Thread"
        Me.ThreadSampleTwoButton.UseVisualStyleBackColor = True
        '
        'ThreadingProgressBar
        '
        Me.ThreadingProgressBar.Location = New System.Drawing.Point(6, 19)
        Me.ThreadingProgressBar.Name = "ThreadingProgressBar"
        Me.ThreadingProgressBar.Size = New System.Drawing.Size(286, 23)
        Me.ThreadingProgressBar.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ThreadingProgressBar)
        Me.GroupBox1.Controls.Add(Me.ThreadSampleOneButton)
        Me.GroupBox1.Controls.Add(Me.ThreadSampleTwoButton)
        Me.GroupBox1.Location = New System.Drawing.Point(363, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 94)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Threading"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 283)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Main"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents threadingBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ThreadSampleOneButton As System.Windows.Forms.Button
    Friend WithEvents ThreadSampleTwoButton As System.Windows.Forms.Button
    Friend WithEvents ThreadingProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
