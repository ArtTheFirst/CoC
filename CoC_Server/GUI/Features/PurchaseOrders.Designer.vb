<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrders
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.filterDate = New System.Windows.Forms.Label()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(660, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Order List"
        '
        'filterDate
        '
        Me.filterDate.BackColor = System.Drawing.Color.LightGray
        Me.filterDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.filterDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.filterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filterDate.Location = New System.Drawing.Point(0, 42)
        Me.filterDate.Name = "filterDate"
        Me.filterDate.Size = New System.Drawing.Size(784, 27)
        Me.filterDate.TabIndex = 51
        Me.filterDate.Text = "date filter []"
        Me.filterDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column3, Me.Column1, Me.Column2, Me.Column4})
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Location = New System.Drawing.Point(0, 69)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.RowHeadersWidth = 45
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        Me.dg_List.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dg_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_List.Size = New System.Drawing.Size(784, 372)
        Me.dg_List.TabIndex = 69
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column8.HeaderText = "SN"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 50
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle18
        Me.Column3.FillWeight = 74.66666!
        Me.Column3.HeaderText = "INVOICE NO."
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column1
        '
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle19
        Me.Column1.FillWeight = 74.66666!
        Me.Column1.HeaderText = "SUPPLIER"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 270
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "INVOICE DATE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "INVOICE AMOUNT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'PurchaseOrders
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.filterDate)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PurchaseOrders"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents filterDate As Label
    Friend WithEvents dg_List As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
