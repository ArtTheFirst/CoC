<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseOrder
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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.l_SessionId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_InvoiceDate = New MetroFramework.Controls.MetroDateTime()
        Me.l_CompanyName = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.l_Inv = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t_SupplierName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.l_TotalAll = New System.Windows.Forms.Label()
        Me.l_qtyTotal = New System.Windows.Forms.Label()
        Me.l_CostTotal = New System.Windows.Forms.Label()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(824, 42)
        Me.Panel2.TabIndex = 49
        '
        'l_SessionId
        '
        Me.l_SessionId.AutoSize = True
        Me.l_SessionId.BackColor = System.Drawing.Color.Transparent
        Me.l_SessionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SessionId.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.l_SessionId.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.l_SessionId.Location = New System.Drawing.Point(12, 13)
        Me.l_SessionId.Name = "l_SessionId"
        Me.l_SessionId.Size = New System.Drawing.Size(76, 17)
        Me.l_SessionId.TabIndex = 213
        Me.l_SessionId.Tag = "Session Id: "
        Me.l_SessionId.Text = "Session Id: "
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(640, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Order"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtp_InvoiceDate)
        Me.Panel1.Controls.Add(Me.l_CompanyName)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.l_Inv)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.t_SupplierName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(554, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 399)
        Me.Panel1.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 27)
        Me.Label2.TabIndex = 217
        Me.Label2.Tag = ""
        Me.Label2.Text = "Company Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_InvoiceDate
        '
        Me.dtp_InvoiceDate.Location = New System.Drawing.Point(12, 304)
        Me.dtp_InvoiceDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_InvoiceDate.Name = "dtp_InvoiceDate"
        Me.dtp_InvoiceDate.Size = New System.Drawing.Size(250, 29)
        Me.dtp_InvoiceDate.TabIndex = 216
        '
        'l_CompanyName
        '
        Me.l_CompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_CompanyName.BackColor = System.Drawing.Color.Silver
        Me.l_CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_CompanyName.Font = New System.Drawing.Font("Corbel", 12.3!)
        Me.l_CompanyName.ForeColor = System.Drawing.Color.Black
        Me.l_CompanyName.Location = New System.Drawing.Point(12, 140)
        Me.l_CompanyName.Name = "l_CompanyName"
        Me.l_CompanyName.Size = New System.Drawing.Size(249, 106)
        Me.l_CompanyName.TabIndex = 211
        Me.l_CompanyName.Tag = "[Company Name]"
        Me.l_CompanyName.Text = "[Company Name]"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(12, 278)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(248, 23)
        Me.Label21.TabIndex = 163
        Me.Label21.Text = "Invoice Date"
        '
        'l_Inv
        '
        Me.l_Inv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Inv.BackColor = System.Drawing.Color.Teal
        Me.l_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Inv.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_Inv.ForeColor = System.Drawing.Color.White
        Me.l_Inv.Location = New System.Drawing.Point(10, 4)
        Me.l_Inv.Name = "l_Inv"
        Me.l_Inv.Size = New System.Drawing.Size(252, 21)
        Me.l_Inv.TabIndex = 149
        Me.l_Inv.Tag = "Invoice No.:"
        Me.l_Inv.Text = "Invoice No.:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.Label8.Location = New System.Drawing.Point(8, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 21)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "*Enter Supplier Name"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(22, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 2)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_SupplierName
        '
        Me.t_SupplierName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_SupplierName.BackColor = System.Drawing.Color.Silver
        Me.t_SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_SupplierName.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_SupplierName.Location = New System.Drawing.Point(22, 65)
        Me.t_SupplierName.MaxLength = 128
        Me.t_SupplierName.Name = "t_SupplierName"
        Me.t_SupplierName.ReadOnly = True
        Me.t_SupplierName.Size = New System.Drawing.Size(240, 20)
        Me.t_SupplierName.TabIndex = 147
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Controls.Add(Me.l_SessionId)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 41)
        Me.Panel3.TabIndex = 51
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(6, 363)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(258, 30)
        Me.btnSave.TabIndex = 216
        Me.btnSave.Text = "CONFIRM PURCHASE ENTRY [F1]"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.LightGray
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNew.FlatAppearance.BorderSize = 2
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(467, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(81, 30)
        Me.btnNew.TabIndex = 215
        Me.btnNew.Text = "New [F5]"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.l_TotalAll)
        Me.Panel5.Controls.Add(Me.l_qtyTotal)
        Me.Panel5.Controls.Add(Me.l_CostTotal)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 393)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(554, 48)
        Me.Panel5.TabIndex = 53
        '
        'l_TotalAll
        '
        Me.l_TotalAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_TotalAll.AutoSize = True
        Me.l_TotalAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalAll.Font = New System.Drawing.Font("Consolas", 23.0!)
        Me.l_TotalAll.Location = New System.Drawing.Point(460, 5)
        Me.l_TotalAll.Name = "l_TotalAll"
        Me.l_TotalAll.Size = New System.Drawing.Size(85, 37)
        Me.l_TotalAll.TabIndex = 162
        Me.l_TotalAll.Text = "0.00"
        '
        'l_qtyTotal
        '
        Me.l_qtyTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_qtyTotal.AutoSize = True
        Me.l_qtyTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_qtyTotal.Font = New System.Drawing.Font("Consolas", 23.0!)
        Me.l_qtyTotal.Location = New System.Drawing.Point(278, 5)
        Me.l_qtyTotal.Name = "l_qtyTotal"
        Me.l_qtyTotal.Size = New System.Drawing.Size(85, 37)
        Me.l_qtyTotal.TabIndex = 160
        Me.l_qtyTotal.Text = "0.00"
        '
        'l_CostTotal
        '
        Me.l_CostTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_CostTotal.AutoSize = True
        Me.l_CostTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_CostTotal.Font = New System.Drawing.Font("Consolas", 23.0!)
        Me.l_CostTotal.Location = New System.Drawing.Point(369, 5)
        Me.l_CostTotal.Name = "l_CostTotal"
        Me.l_CostTotal.Size = New System.Drawing.Size(85, 37)
        Me.l_CostTotal.TabIndex = 155
        Me.l_CostTotal.Text = "0.00"
        '
        'dg_List
        '
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column4, Me.Column5, Me.Column2})
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Location = New System.Drawing.Point(0, 83)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.RowHeadersWidth = 45
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.White
        Me.dg_List.RowsDefaultCellStyle = DataGridViewCellStyle24
        Me.dg_List.Size = New System.Drawing.Size(554, 310)
        Me.dg_List.TabIndex = 70
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column1.FillWeight = 74.66666!
        Me.Column1.HeaderText = "ITEM NAME"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle21
        Me.Column4.FillWeight = 74.66666!
        Me.Column4.HeaderText = "QTY."
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 110
        '
        'Column5
        '
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = "0"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column5.FillWeight = 74.66666!
        Me.Column5.HeaderText = "RATE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 180
        '
        'Column2
        '
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle23.Format = "N2"
        DataGridViewCellStyle23.NullValue = "0"
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle23
        Me.Column2.HeaderText = "TOTAL"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 300
        '
        'PurchaseOrder
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "PurchaseOrder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents l_Inv As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents t_SupplierName As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents l_SessionId As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents l_TotalAll As Label
    Friend WithEvents l_qtyTotal As Label
    Friend WithEvents l_CostTotal As Label
    Friend WithEvents l_CompanyName As Label
    Friend WithEvents dg_List As DataGridView
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtp_InvoiceDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
