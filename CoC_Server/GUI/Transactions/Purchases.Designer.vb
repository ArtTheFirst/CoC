<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Purchases
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_InvoiceDate = New MetroFramework.Controls.MetroDateTime()
        Me.l_CompanyName = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t_SupplierName = New System.Windows.Forms.TextBox()
        Me.l_Inv = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.l_BillDate = New System.Windows.Forms.Label()
        Me.l_OrderDate = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSavePrintSession = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSaveSession = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.l_Outstanding = New System.Windows.Forms.Label()
        Me.l_ItemsTotal = New System.Windows.Forms.Label()
        Me.dg_TXNs = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELTTL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.l_Discounts = New System.Windows.Forms.Label()
        Me.l_FreeTotal = New System.Windows.Forms.Label()
        Me.l_Qty = New System.Windows.Forms.Label()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.Panel2.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(648, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Entry"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.l_Inv)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(539, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 399)
        Me.Panel1.TabIndex = 49
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.dtp_InvoiceDate)
        Me.Panel7.Controls.Add(Me.l_CompanyName)
        Me.Panel7.Controls.Add(Me.Label21)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.t_SupplierName)
        Me.Panel7.Location = New System.Drawing.Point(7, 93)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(270, 301)
        Me.Panel7.TabIndex = 219
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.LightGray
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 27)
        Me.Label2.TabIndex = 231
        Me.Label2.Tag = ""
        Me.Label2.Text = "Company Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtp_InvoiceDate
        '
        Me.dtp_InvoiceDate.Location = New System.Drawing.Point(10, 264)
        Me.dtp_InvoiceDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_InvoiceDate.Name = "dtp_InvoiceDate"
        Me.dtp_InvoiceDate.Size = New System.Drawing.Size(250, 29)
        Me.dtp_InvoiceDate.TabIndex = 230
        '
        'l_CompanyName
        '
        Me.l_CompanyName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_CompanyName.BackColor = System.Drawing.Color.Gainsboro
        Me.l_CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_CompanyName.Font = New System.Drawing.Font("Corbel", 12.3!)
        Me.l_CompanyName.ForeColor = System.Drawing.Color.Black
        Me.l_CompanyName.Location = New System.Drawing.Point(10, 100)
        Me.l_CompanyName.Name = "l_CompanyName"
        Me.l_CompanyName.Size = New System.Drawing.Size(249, 106)
        Me.l_CompanyName.TabIndex = 229
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
        Me.Label21.Location = New System.Drawing.Point(10, 238)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(248, 23)
        Me.Label21.TabIndex = 228
        Me.Label21.Text = "Invoice Date"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 19)
        Me.Label8.TabIndex = 225
        Me.Label8.Text = "*Enter Supplier Name"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(22, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 2)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_SupplierName
        '
        Me.t_SupplierName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_SupplierName.BackColor = System.Drawing.Color.Gainsboro
        Me.t_SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_SupplierName.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.t_SupplierName.Location = New System.Drawing.Point(22, 32)
        Me.t_SupplierName.MaxLength = 128
        Me.t_SupplierName.Name = "t_SupplierName"
        Me.t_SupplierName.ReadOnly = True
        Me.t_SupplierName.Size = New System.Drawing.Size(240, 21)
        Me.t_SupplierName.TabIndex = 226
        '
        'l_Inv
        '
        Me.l_Inv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Inv.BackColor = System.Drawing.Color.Teal
        Me.l_Inv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Inv.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_Inv.ForeColor = System.Drawing.Color.White
        Me.l_Inv.Location = New System.Drawing.Point(7, 65)
        Me.l_Inv.Name = "l_Inv"
        Me.l_Inv.Size = New System.Drawing.Size(269, 21)
        Me.l_Inv.TabIndex = 218
        Me.l_Inv.Tag = "Invoice No.:"
        Me.l_Inv.Text = "Invoice No.:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel6.Controls.Add(Me.l_BillDate)
        Me.Panel6.Controls.Add(Me.l_OrderDate)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(285, 60)
        Me.Panel6.TabIndex = 212
        '
        'l_BillDate
        '
        Me.l_BillDate.BackColor = System.Drawing.Color.DodgerBlue
        Me.l_BillDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_BillDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_BillDate.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_BillDate.ForeColor = System.Drawing.Color.White
        Me.l_BillDate.Location = New System.Drawing.Point(11, 27)
        Me.l_BillDate.Name = "l_BillDate"
        Me.l_BillDate.Size = New System.Drawing.Size(265, 24)
        Me.l_BillDate.TabIndex = 212
        Me.l_BillDate.Text = "Bill Date []"
        Me.l_BillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_OrderDate
        '
        Me.l_OrderDate.BackColor = System.Drawing.Color.DodgerBlue
        Me.l_OrderDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_OrderDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_OrderDate.Font = New System.Drawing.Font("Segoe UI Light", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_OrderDate.ForeColor = System.Drawing.Color.White
        Me.l_OrderDate.Location = New System.Drawing.Point(11, 0)
        Me.l_OrderDate.Name = "l_OrderDate"
        Me.l_OrderDate.Size = New System.Drawing.Size(265, 24)
        Me.l_OrderDate.TabIndex = 211
        Me.l_OrderDate.Text = "Order Date []"
        Me.l_OrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnSavePrintSession)
        Me.Panel3.Controls.Add(Me.btnNew)
        Me.Panel3.Controls.Add(Me.btnSaveSession)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(539, 43)
        Me.Panel3.TabIndex = 50
        '
        'btnSavePrintSession
        '
        Me.btnSavePrintSession.BackColor = System.Drawing.Color.LightGray
        Me.btnSavePrintSession.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSavePrintSession.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSavePrintSession.FlatAppearance.BorderSize = 2
        Me.btnSavePrintSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePrintSession.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSavePrintSession.ForeColor = System.Drawing.Color.Black
        Me.btnSavePrintSession.Location = New System.Drawing.Point(95, 6)
        Me.btnSavePrintSession.Name = "btnSavePrintSession"
        Me.btnSavePrintSession.Size = New System.Drawing.Size(123, 30)
        Me.btnSavePrintSession.TabIndex = 215
        Me.btnSavePrintSession.Text = "Save/Print [F2]"
        Me.btnSavePrintSession.UseVisualStyleBackColor = False
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
        Me.btnNew.Location = New System.Drawing.Point(452, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(81, 30)
        Me.btnNew.TabIndex = 214
        Me.btnNew.Text = "New [F5]"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSaveSession
        '
        Me.btnSaveSession.BackColor = System.Drawing.Color.LightGray
        Me.btnSaveSession.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSession.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSaveSession.FlatAppearance.BorderSize = 2
        Me.btnSaveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSession.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveSession.ForeColor = System.Drawing.Color.Black
        Me.btnSaveSession.Location = New System.Drawing.Point(8, 6)
        Me.btnSaveSession.Name = "btnSaveSession"
        Me.btnSaveSession.Size = New System.Drawing.Size(81, 30)
        Me.btnSaveSession.TabIndex = 213
        Me.btnSaveSession.Text = "Save [F1]"
        Me.btnSaveSession.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.l_Outstanding)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(539, 41)
        Me.Panel4.TabIndex = 51
        '
        'l_Outstanding
        '
        Me.l_Outstanding.AutoSize = True
        Me.l_Outstanding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Outstanding.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_Outstanding.ForeColor = System.Drawing.Color.Red
        Me.l_Outstanding.Location = New System.Drawing.Point(9, 10)
        Me.l_Outstanding.Name = "l_Outstanding"
        Me.l_Outstanding.Size = New System.Drawing.Size(186, 21)
        Me.l_Outstanding.TabIndex = 153
        Me.l_Outstanding.Text = "Outstanding Balance []"
        '
        'l_ItemsTotal
        '
        Me.l_ItemsTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.l_ItemsTotal.AutoSize = True
        Me.l_ItemsTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ItemsTotal.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_ItemsTotal.Location = New System.Drawing.Point(7, 9)
        Me.l_ItemsTotal.Name = "l_ItemsTotal"
        Me.l_ItemsTotal.Size = New System.Drawing.Size(101, 21)
        Me.l_ItemsTotal.TabIndex = 1
        Me.l_ItemsTotal.Tag = "Total Items: "
        Me.l_ItemsTotal.Text = "Total Items: "
        '
        'dg_TXNs
        '
        Me.dg_TXNs.AllowUserToResizeColumns = False
        Me.dg_TXNs.AllowUserToResizeRows = False
        Me.dg_TXNs.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dg_TXNs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_TXNs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_TXNs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_TXNs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_TXNs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column4, Me.Column8, Me.MA, Me.Column7, Me.Column5, Me.Column2, Me.Column6, Me.Column9, Me.SELTTL})
        Me.dg_TXNs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_TXNs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_TXNs.EnableHeadersVisualStyles = False
        Me.dg_TXNs.Location = New System.Drawing.Point(0, 126)
        Me.dg_TXNs.Name = "dg_TXNs"
        Me.dg_TXNs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_TXNs.RowHeadersVisible = False
        Me.dg_TXNs.RowHeadersWidth = 45
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        Me.dg_TXNs.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dg_TXNs.Size = New System.Drawing.Size(539, 178)
        Me.dg_TXNs.TabIndex = 67
        '
        'Column3
        '
        Me.Column3.HeaderText = "CODE"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 130
        '
        'Column1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.FillWeight = 74.66666!
        Me.Column1.HeaderText = "ITEM NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 360
        '
        'Column4
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.FillWeight = 74.66666!
        Me.Column4.HeaderText = "QTY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 120
        '
        'Column8
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column8.HeaderText = "FREE"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 120
        '
        'MA
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        Me.MA.DefaultCellStyle = DataGridViewCellStyle5
        Me.MA.HeaderText = "MARGIN (%)"
        Me.MA.Name = "MA"
        Me.MA.Width = 120
        '
        'Column7
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column7.FillWeight = 74.66666!
        Me.Column7.HeaderText = "PURCHASE RATE"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 210
        '
        'Column5
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.HeaderText = "SELLING RATE"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 210
        '
        'Column2
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = "0"
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column2.HeaderText = "DISCOUNT (%)"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 120
        '
        'Column6
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column6.FillWeight = 74.66666!
        Me.Column6.HeaderText = "VAT (5%)"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 120
        '
        'Column9
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle10.Format = "n2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column9.HeaderText = "MRP"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 210
        '
        'SELTTL
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle11.Format = "N0"
        DataGridViewCellStyle11.NullValue = "0"
        Me.SELTTL.DefaultCellStyle = DataGridViewCellStyle11
        Me.SELTTL.HeaderText = "TOTAL"
        Me.SELTTL.Name = "SELTTL"
        Me.SELTTL.Width = 300
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.l_Discounts)
        Me.Panel5.Controls.Add(Me.l_FreeTotal)
        Me.Panel5.Controls.Add(Me.l_Qty)
        Me.Panel5.Controls.Add(Me.l_Total)
        Me.Panel5.Controls.Add(Me.l_ItemsTotal)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 304)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(539, 137)
        Me.Panel5.TabIndex = 52
        '
        'l_Discounts
        '
        Me.l_Discounts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Discounts.AutoSize = True
        Me.l_Discounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Discounts.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_Discounts.Location = New System.Drawing.Point(255, 41)
        Me.l_Discounts.Name = "l_Discounts"
        Me.l_Discounts.Size = New System.Drawing.Size(127, 21)
        Me.l_Discounts.TabIndex = 215
        Me.l_Discounts.Tag = "Total Discount: "
        Me.l_Discounts.Text = "Total Discount: "
        '
        'l_FreeTotal
        '
        Me.l_FreeTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_FreeTotal.AutoSize = True
        Me.l_FreeTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_FreeTotal.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_FreeTotal.Location = New System.Drawing.Point(255, 9)
        Me.l_FreeTotal.Name = "l_FreeTotal"
        Me.l_FreeTotal.Size = New System.Drawing.Size(92, 21)
        Me.l_FreeTotal.TabIndex = 214
        Me.l_FreeTotal.Tag = "Total Free: "
        Me.l_FreeTotal.Text = "Total Free: "
        '
        'l_Qty
        '
        Me.l_Qty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.l_Qty.AutoSize = True
        Me.l_Qty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Qty.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_Qty.Location = New System.Drawing.Point(12, 41)
        Me.l_Qty.Name = "l_Qty"
        Me.l_Qty.Size = New System.Drawing.Size(90, 21)
        Me.l_Qty.TabIndex = 213
        Me.l_Qty.Tag = "Total Qty.: "
        Me.l_Qty.Text = "Total Qty.: "
        '
        'l_Total
        '
        Me.l_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.l_Total.AutoSize = True
        Me.l_Total.BackColor = System.Drawing.Color.Transparent
        Me.l_Total.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Consolas", 30.0!)
        Me.l_Total.ForeColor = System.Drawing.Color.Black
        Me.l_Total.Location = New System.Drawing.Point(11, 77)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(104, 55)
        Me.l_Total.TabIndex = 212
        Me.l_Total.Text = "0.00"
        Me.l_Total.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.l_Total.UseCompatibleTextRendering = True
        '
        'Purchases
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.dg_TXNs)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "Purchases"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents l_ItemsTotal As Label
    Friend WithEvents l_Outstanding As Label
    Friend WithEvents dg_TXNs As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents l_OrderDate As Label
    Friend WithEvents l_BillDate As Label
    Friend WithEvents l_Inv As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents l_Total As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents MA As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents SELTTL As DataGridViewTextBoxColumn
    Friend WithEvents l_Qty As Label
    Friend WithEvents l_FreeTotal As Label
    Friend WithEvents l_Discounts As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents t_SupplierName As TextBox
    Friend WithEvents btnSavePrintSession As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSaveSession As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_InvoiceDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents l_CompanyName As Label
    Friend WithEvents Label21 As Label
End Class
