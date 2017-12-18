<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptographyForm
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
        Me.inputStringTextBox = New System.Windows.Forms.TextBox()
        Me.outputStringTextBox = New System.Windows.Forms.TextBox()
        Me.inputStringLabel = New System.Windows.Forms.Label()
        Me.outputStringLabel = New System.Windows.Forms.Label()
        Me.encryptButton = New System.Windows.Forms.Button()
        Me.decryptButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'inputStringTextBox
        '
        Me.inputStringTextBox.Location = New System.Drawing.Point(95, 6)
        Me.inputStringTextBox.Name = "inputStringTextBox"
        Me.inputStringTextBox.Size = New System.Drawing.Size(325, 20)
        Me.inputStringTextBox.TabIndex = 0
        '
        'outputStringTextBox
        '
        Me.outputStringTextBox.Location = New System.Drawing.Point(95, 32)
        Me.outputStringTextBox.Name = "outputStringTextBox"
        Me.outputStringTextBox.Size = New System.Drawing.Size(325, 20)
        Me.outputStringTextBox.TabIndex = 1
        '
        'inputStringLabel
        '
        Me.inputStringLabel.AutoSize = True
        Me.inputStringLabel.Location = New System.Drawing.Point(12, 9)
        Me.inputStringLabel.Name = "inputStringLabel"
        Me.inputStringLabel.Size = New System.Drawing.Size(59, 13)
        Me.inputStringLabel.TabIndex = 2
        Me.inputStringLabel.Text = "Input string"
        '
        'outputStringLabel
        '
        Me.outputStringLabel.AutoSize = True
        Me.outputStringLabel.Location = New System.Drawing.Point(12, 35)
        Me.outputStringLabel.Name = "outputStringLabel"
        Me.outputStringLabel.Size = New System.Drawing.Size(67, 13)
        Me.outputStringLabel.TabIndex = 3
        Me.outputStringLabel.Text = "Output string"
        '
        'encryptButton
        '
        Me.encryptButton.Location = New System.Drawing.Point(183, 59)
        Me.encryptButton.Name = "encryptButton"
        Me.encryptButton.Size = New System.Drawing.Size(75, 23)
        Me.encryptButton.TabIndex = 4
        Me.encryptButton.Text = "Encrypt"
        Me.encryptButton.UseVisualStyleBackColor = True
        '
        'decryptButton
        '
        Me.decryptButton.Location = New System.Drawing.Point(264, 59)
        Me.decryptButton.Name = "decryptButton"
        Me.decryptButton.Size = New System.Drawing.Size(75, 23)
        Me.decryptButton.TabIndex = 5
        Me.decryptButton.Text = "Decrypt"
        Me.decryptButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(345, 58)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'CryptographyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 91)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.decryptButton)
        Me.Controls.Add(Me.encryptButton)
        Me.Controls.Add(Me.outputStringLabel)
        Me.Controls.Add(Me.inputStringLabel)
        Me.Controls.Add(Me.outputStringTextBox)
        Me.Controls.Add(Me.inputStringTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CryptographyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cryptography"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputStringTextBox As System.Windows.Forms.TextBox
    Friend WithEvents outputStringTextBox As System.Windows.Forms.TextBox
    Friend WithEvents inputStringLabel As System.Windows.Forms.Label
    Friend WithEvents outputStringLabel As System.Windows.Forms.Label
    Friend WithEvents encryptButton As System.Windows.Forms.Button
    Friend WithEvents decryptButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
