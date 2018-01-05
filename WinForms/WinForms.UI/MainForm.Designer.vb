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
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.GenderPanel = New System.Windows.Forms.Panel()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.StatusPanel = New System.Windows.Forms.Panel()
        Me.RegularRadioButton = New System.Windows.Forms.RadioButton()
        Me.ContractualRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AgeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DepartmentComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LastnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RateMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateHireDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contractual = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.CurrentUserLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.OpenFileButton = New System.Windows.Forms.Button()
        Me.GenderPanel.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Status"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(161, 6)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(266, 31)
        Me.FirstnameTextBox.TabIndex = 1
        '
        'GenderPanel
        '
        Me.GenderPanel.Controls.Add(Me.FemaleRadioButton)
        Me.GenderPanel.Controls.Add(Me.MaleRadioButton)
        Me.GenderPanel.Location = New System.Drawing.Point(161, 117)
        Me.GenderPanel.Name = "GenderPanel"
        Me.GenderPanel.Size = New System.Drawing.Size(266, 37)
        Me.GenderPanel.TabIndex = 7
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
        Me.StatusPanel.Location = New System.Drawing.Point(161, 273)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(266, 37)
        Me.StatusPanel.TabIndex = 15
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
        Me.SubmitButton.Location = New System.Drawing.Point(229, 316)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(96, 35)
        Me.SubmitButton.TabIndex = 16
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.AutoSize = True
        Me.CancelButton.Location = New System.Drawing.Point(331, 316)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(96, 35)
        Me.CancelButton.TabIndex = 17
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AgeMaskedTextBox
        '
        Me.AgeMaskedTextBox.Location = New System.Drawing.Point(161, 80)
        Me.AgeMaskedTextBox.Mask = "00"
        Me.AgeMaskedTextBox.Name = "AgeMaskedTextBox"
        Me.AgeMaskedTextBox.Size = New System.Drawing.Size(40, 31)
        Me.AgeMaskedTextBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Department"
        '
        'DepartmentComboBox
        '
        Me.DepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DepartmentComboBox.FormattingEnabled = True
        Me.DepartmentComboBox.Location = New System.Drawing.Point(161, 160)
        Me.DepartmentComboBox.Name = "DepartmentComboBox"
        Me.DepartmentComboBox.Size = New System.Drawing.Size(266, 33)
        Me.DepartmentComboBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Hire date"
        '
        'LastnameTextBox
        '
        Me.LastnameTextBox.Location = New System.Drawing.Point(162, 43)
        Me.LastnameTextBox.Name = "LastnameTextBox"
        Me.LastnameTextBox.Size = New System.Drawing.Size(266, 31)
        Me.LastnameTextBox.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Lastname"
        '
        'RateMaskedTextBox
        '
        Me.RateMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.RateMaskedTextBox.Location = New System.Drawing.Point(161, 199)
        Me.RateMaskedTextBox.Mask = "0000000"
        Me.RateMaskedTextBox.Name = "RateMaskedTextBox"
        Me.RateMaskedTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.RateMaskedTextBox.Size = New System.Drawing.Size(143, 31)
        Me.RateMaskedTextBox.TabIndex = 11
        Me.RateMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Rate"
        '
        'DateHireDateTimePicker
        '
        Me.DateHireDateTimePicker.CustomFormat = "MM/dd/yyyy"
        Me.DateHireDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateHireDateTimePicker.Location = New System.Drawing.Point(161, 236)
        Me.DateHireDateTimePicker.Name = "DateHireDateTimePicker"
        Me.DateHireDateTimePicker.Size = New System.Drawing.Size(267, 31)
        Me.DateHireDateTimePicker.TabIndex = 18
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Firstname, Me.Lastname, Me.Contractual})
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(434, 6)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(512, 345)
        Me.EmployeeDataGridView.TabIndex = 19
        '
        'Firstname
        '
        Me.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Firstname.DataPropertyName = "Firstname"
        Me.Firstname.HeaderText = "Firstname"
        Me.Firstname.Name = "Firstname"
        Me.Firstname.ReadOnly = True
        Me.Firstname.Width = 132
        '
        'Lastname
        '
        Me.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Lastname.DataPropertyName = "Lastname"
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        Me.Lastname.Width = 131
        '
        'Contractual
        '
        Me.Contractual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Contractual.DataPropertyName = "Contractual"
        Me.Contractual.HeaderText = "Contractual"
        Me.Contractual.Name = "Contractual"
        Me.Contractual.ReadOnly = True
        Me.Contractual.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Contractual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Contractual.Width = 147
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrentUserLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 397)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(958, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'CurrentUserLabel
        '
        Me.CurrentUserLabel.Name = "CurrentUserLabel"
        Me.CurrentUserLabel.Size = New System.Drawing.Size(78, 17)
        Me.CurrentUserLabel.Text = "Current user: "
        '
        'OpenFileButton
        '
        Me.OpenFileButton.AutoSize = True
        Me.OpenFileButton.Location = New System.Drawing.Point(831, 357)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(115, 35)
        Me.OpenFileButton.TabIndex = 21
        Me.OpenFileButton.Text = "Open File"
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 419)
        Me.Controls.Add(Me.OpenFileButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Controls.Add(Me.DateHireDateTimePicker)
        Me.Controls.Add(Me.RateMaskedTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LastnameTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DepartmentComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AgeMaskedTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.StatusPanel)
        Me.Controls.Add(Me.GenderPanel)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MainForm"
        Me.Text = "Main Form"
        Me.GenderPanel.ResumeLayout(False)
        Me.GenderPanel.PerformLayout()
        Me.StatusPanel.ResumeLayout(False)
        Me.StatusPanel.PerformLayout()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderPanel As System.Windows.Forms.Panel
    Friend WithEvents MaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StatusPanel As System.Windows.Forms.Panel
    Friend WithEvents RegularRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ContractualRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SubmitButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents AgeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DepartmentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LastnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RateMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateHireDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contractual As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents CurrentUserLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents OpenFileButton As System.Windows.Forms.Button

End Class
