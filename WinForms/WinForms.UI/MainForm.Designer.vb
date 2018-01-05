<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderPanel = New System.Windows.Forms.Panel()
        Me.SecretRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.StatusPanel = New System.Windows.Forms.Panel()
        Me.RegularRadioButton = New System.Windows.Forms.RadioButton()
        Me.ContractualRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AgeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DepartmentListBox = New System.Windows.Forms.ListBox()
        Me.GenderPanel.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(161, 6)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(317, 31)
        Me.NameTextBox.TabIndex = 4
        '
        'GenderPanel
        '
        Me.GenderPanel.Controls.Add(Me.SecretRadioButton)
        Me.GenderPanel.Controls.Add(Me.FemaleRadioButton)
        Me.GenderPanel.Controls.Add(Me.MaleRadioButton)
        Me.GenderPanel.Location = New System.Drawing.Point(161, 80)
        Me.GenderPanel.Name = "GenderPanel"
        Me.GenderPanel.Size = New System.Drawing.Size(317, 37)
        Me.GenderPanel.TabIndex = 6
        '
        'SecretRadioButton
        '
        Me.SecretRadioButton.AutoSize = True
        Me.SecretRadioButton.Location = New System.Drawing.Point(213, 5)
        Me.SecretRadioButton.Name = "SecretRadioButton"
        Me.SecretRadioButton.Size = New System.Drawing.Size(92, 29)
        Me.SecretRadioButton.TabIndex = 2
        Me.SecretRadioButton.TabStop = True
        Me.SecretRadioButton.Text = "Secret"
        Me.SecretRadioButton.UseVisualStyleBackColor = True
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.Location = New System.Drawing.Point(96, 5)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(101, 29)
        Me.FemaleRadioButton.TabIndex = 1
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.Location = New System.Drawing.Point(3, 5)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(77, 29)
        Me.MaleRadioButton.TabIndex = 0
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'StatusPanel
        '
        Me.StatusPanel.Controls.Add(Me.RegularRadioButton)
        Me.StatusPanel.Controls.Add(Me.ContractualRadioButton)
        Me.StatusPanel.Location = New System.Drawing.Point(161, 123)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(317, 37)
        Me.StatusPanel.TabIndex = 7
        '
        'RegularRadioButton
        '
        Me.RegularRadioButton.AutoSize = True
        Me.RegularRadioButton.Location = New System.Drawing.Point(146, 5)
        Me.RegularRadioButton.Name = "RegularRadioButton"
        Me.RegularRadioButton.Size = New System.Drawing.Size(105, 29)
        Me.RegularRadioButton.TabIndex = 1
        Me.RegularRadioButton.TabStop = True
        Me.RegularRadioButton.Text = "Regular"
        Me.RegularRadioButton.UseVisualStyleBackColor = True
        '
        'ContractualRadioButton
        '
        Me.ContractualRadioButton.AutoSize = True
        Me.ContractualRadioButton.Location = New System.Drawing.Point(3, 5)
        Me.ContractualRadioButton.Name = "ContractualRadioButton"
        Me.ContractualRadioButton.Size = New System.Drawing.Size(140, 29)
        Me.ContractualRadioButton.TabIndex = 0
        Me.ContractualRadioButton.TabStop = True
        Me.ContractualRadioButton.Text = "Contractual"
        Me.ContractualRadioButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.AutoSize = True
        Me.SubmitButton.Location = New System.Drawing.Point(280, 226)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(96, 35)
        Me.SubmitButton.TabIndex = 8
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.AutoSize = True
        Me.CancelButton.Location = New System.Drawing.Point(382, 226)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(96, 35)
        Me.CancelButton.TabIndex = 9
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AgeMaskedTextBox
        '
        Me.AgeMaskedTextBox.Location = New System.Drawing.Point(161, 43)
        Me.AgeMaskedTextBox.Mask = "00"
        Me.AgeMaskedTextBox.Name = "AgeMaskedTextBox"
        Me.AgeMaskedTextBox.Size = New System.Drawing.Size(40, 31)
        Me.AgeMaskedTextBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Department"
        '
        'DepartmentListBox
        '
        Me.DepartmentListBox.FormattingEnabled = True
        Me.DepartmentListBox.ItemHeight = 25
        Me.DepartmentListBox.Location = New System.Drawing.Point(161, 166)
        Me.DepartmentListBox.Name = "DepartmentListBox"
        Me.DepartmentListBox.Size = New System.Drawing.Size(317, 54)
        Me.DepartmentListBox.TabIndex = 13
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 280)
        Me.Controls.Add(Me.DepartmentListBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AgeMaskedTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.StatusPanel)
        Me.Controls.Add(Me.GenderPanel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MainForm"
        Me.Text = "Main form"
        Me.GenderPanel.ResumeLayout(False)
        Me.GenderPanel.PerformLayout()
        Me.StatusPanel.ResumeLayout(False)
        Me.StatusPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderPanel As System.Windows.Forms.Panel
    Friend WithEvents MaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StatusPanel As System.Windows.Forms.Panel
    Friend WithEvents RegularRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ContractualRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents SecretRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents AgeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DepartmentListBox As System.Windows.Forms.ListBox

End Class
