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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddEmployeeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EmployeeDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 441)
        Me.Panel1.TabIndex = 0
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Firstname, Me.Lastname, Me.Rate, Me.Id, Me.EmployeeType})
        Me.EmployeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeDataGridView.MultiSelect = False
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(705, 441)
        Me.EmployeeDataGridView.TabIndex = 0
        '
        'Firstname
        '
        Me.Firstname.DataPropertyName = "Firstname"
        Me.Firstname.HeaderText = "Firstname"
        Me.Firstname.Name = "Firstname"
        Me.Firstname.ReadOnly = True
        '
        'Lastname
        '
        Me.Lastname.DataPropertyName = "Lastname"
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Rate"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle2
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'Id
        '
        Me.Id.DataPropertyName = "Id"
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'EmployeeType
        '
        Me.EmployeeType.DataPropertyName = "EmployeeType"
        Me.EmployeeType.HeaderText = "EmployeeType"
        Me.EmployeeType.Name = "EmployeeType"
        Me.EmployeeType.ReadOnly = True
        Me.EmployeeType.Visible = False
        '
        'AddEmployeeButton
        '
        Me.AddEmployeeButton.Location = New System.Drawing.Point(561, 12)
        Me.AddEmployeeButton.Name = "AddEmployeeButton"
        Me.AddEmployeeButton.Size = New System.Drawing.Size(75, 23)
        Me.AddEmployeeButton.TabIndex = 1
        Me.AddEmployeeButton.Text = "Add Record"
        Me.AddEmployeeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(642, 12)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 494)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.AddEmployeeButton)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee List"
        Me.Panel1.ResumeLayout(False)
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddEmployeeButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeType As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
