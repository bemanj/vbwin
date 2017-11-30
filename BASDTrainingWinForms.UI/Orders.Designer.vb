<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerContactTextBox = New System.Windows.Forms.TextBox()
        Me.OrderStatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenOrderButton = New System.Windows.Forms.Button()
        Me.CloseOrderButton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddOrderToolStripMenuItem, Me.SetupToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddOrderToolStripMenuItem
        '
        Me.AddOrderToolStripMenuItem.Name = "AddOrderToolStripMenuItem"
        Me.AddOrderToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.AddOrderToolStripMenuItem.Text = "Add Order"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.OrderDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(12, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 328)
        Me.Panel1.TabIndex = 1
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OrderDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.Size = New System.Drawing.Size(562, 328)
        Me.OrderDataGridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer name"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(119, 31)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.ReadOnly = True
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(374, 20)
        Me.CustomerNameTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer Contact"
        '
        'CustomerContactTextBox
        '
        Me.CustomerContactTextBox.Location = New System.Drawing.Point(119, 57)
        Me.CustomerContactTextBox.Name = "CustomerContactTextBox"
        Me.CustomerContactTextBox.ReadOnly = True
        Me.CustomerContactTextBox.Size = New System.Drawing.Size(94, 20)
        Me.CustomerContactTextBox.TabIndex = 5
        '
        'OrderStatusTextBox
        '
        Me.OrderStatusTextBox.Location = New System.Drawing.Point(372, 57)
        Me.OrderStatusTextBox.Name = "OrderStatusTextBox"
        Me.OrderStatusTextBox.ReadOnly = True
        Me.OrderStatusTextBox.Size = New System.Drawing.Size(121, 20)
        Me.OrderStatusTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Order status"
        '
        'OpenOrderButton
        '
        Me.OpenOrderButton.Location = New System.Drawing.Point(499, 29)
        Me.OpenOrderButton.Name = "OpenOrderButton"
        Me.OpenOrderButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenOrderButton.TabIndex = 8
        Me.OpenOrderButton.Text = "Open Order"
        Me.OpenOrderButton.UseVisualStyleBackColor = True
        '
        'CloseOrderButton
        '
        Me.CloseOrderButton.Location = New System.Drawing.Point(499, 58)
        Me.CloseOrderButton.Name = "CloseOrderButton"
        Me.CloseOrderButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseOrderButton.TabIndex = 9
        Me.CloseOrderButton.Text = "Close Order"
        Me.CloseOrderButton.UseVisualStyleBackColor = True
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 441)
        Me.Controls.Add(Me.CloseOrderButton)
        Me.Controls.Add(Me.OpenOrderButton)
        Me.Controls.Add(Me.OrderStatusTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CustomerContactTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Orders"
        Me.Text = "Orders"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustomerContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OpenOrderButton As System.Windows.Forms.Button
    Friend WithEvents CloseOrderButton As System.Windows.Forms.Button
    Friend WithEvents OrderDataGridView As System.Windows.Forms.DataGridView
End Class
