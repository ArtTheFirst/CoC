<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyStockStatus
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.btnLoadAll = New System.Windows.Forms.Label()
        Me.dg_OOSL = New System.Windows.Forms.DataGridView()
        Me.hcProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hdrClQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_OOSL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(565, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modify Stock Status"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.l_Total)
        Me.Panel1.Controls.Add(Me.btnLoadAll)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 39)
        Me.Panel1.TabIndex = 8
        '
        'l_Total
        '
        Me.l_Total.AutoSize = True
        Me.l_Total.Location = New System.Drawing.Point(13, 11)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(197, 18)
        Me.l_Total.TabIndex = 4
        Me.l_Total.Text = "[] products in total out of stock"
        '
        'btnLoadAll
        '
        Me.btnLoadAll.BackColor = System.Drawing.Color.Green
        Me.btnLoadAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadAll.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.btnLoadAll.ForeColor = System.Drawing.Color.White
        Me.btnLoadAll.Location = New System.Drawing.Point(634, 8)
        Me.btnLoadAll.Name = "btnLoadAll"
        Me.btnLoadAll.Size = New System.Drawing.Size(142, 20)
        Me.btnLoadAll.TabIndex = 3
        Me.btnLoadAll.Text = "SAVE"
        Me.btnLoadAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg_OOSL
        '
        Me.dg_OOSL.AllowUserToAddRows = False
        Me.dg_OOSL.AllowUserToResizeColumns = False
        Me.dg_OOSL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_OOSL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dg_OOSL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_OOSL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.hcProdName, Me.clmCategory, Me.hdrClQty})
        Me.dg_OOSL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_OOSL.Location = New System.Drawing.Point(0, 81)
        Me.dg_OOSL.Name = "dg_OOSL"
        Me.dg_OOSL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg_OOSL.Size = New System.Drawing.Size(784, 360)
        Me.dg_OOSL.StandardTab = True
        Me.dg_OOSL.TabIndex = 9
        '
        'hcProdName
        '
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.hcProdName.DefaultCellStyle = DataGridViewCellStyle13
        Me.hcProdName.HeaderText = "Product Name"
        Me.hcProdName.Name = "hcProdName"
        Me.hcProdName.ReadOnly = True
        Me.hcProdName.Width = 380
        '
        'clmCategory
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.clmCategory.DefaultCellStyle = DataGridViewCellStyle14
        Me.clmCategory.HeaderText = "Category"
        Me.clmCategory.Name = "clmCategory"
        Me.clmCategory.ReadOnly = True
        Me.clmCategory.Width = 280
        '
        'hdrClQty
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Corbel", 12.0!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle15.Format = "N2"
        DataGridViewCellStyle15.NullValue = "0"
        Me.hdrClQty.DefaultCellStyle = DataGridViewCellStyle15
        Me.hdrClQty.HeaderText = "Qty"
        Me.hdrClQty.MaxInputLength = 5
        Me.hdrClQty.Name = "hdrClQty"
        Me.hdrClQty.Width = 90
        '
        'ModifyStockStatus
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.dg_OOSL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ModifyStockStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModifyStockStatus"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_OOSL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLoadAll As Label
    Friend WithEvents l_Total As Label
    Friend WithEvents dg_OOSL As DataGridView
    Friend WithEvents hcProdName As DataGridViewTextBoxColumn
    Friend WithEvents clmCategory As DataGridViewTextBoxColumn
    Friend WithEvents hdrClQty As DataGridViewTextBoxColumn
End Class
