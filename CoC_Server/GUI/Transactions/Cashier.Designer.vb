<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cashier
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.l_SessionId = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_acct = New System.Windows.Forms.Label()
        Me.l_DiscountTotal = New System.Windows.Forms.Label()
        Me.l_CustomerId = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_ClientName = New System.Windows.Forms.Label()
        Me.btnReceiptModify = New System.Windows.Forms.Button()
        Me.btnDiscounts = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dg_TXNs = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sidepnl = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnOrderUpload = New System.Windows.Forms.Button()
        Me.btnReprint = New System.Windows.Forms.Button()
        Me.l_EditMode = New System.Windows.Forms.Label()
        Me.TXNpnl = New System.Windows.Forms.Panel()
        Me.l_TotalQty = New System.Windows.Forms.Label()
        Me.l_Change = New System.Windows.Forms.Label()
        Me.l_ToPay = New System.Windows.Forms.Label()
        Me.l_VAT = New System.Windows.Forms.Label()
        Me.l_SubTotal = New System.Windows.Forms.Label()
        Me.l_recordCount = New System.Windows.Forms.Label()
        Me.TheTime = New System.Windows.Forms.Label()
        Me.l_InvoiceCode = New System.Windows.Forms.Label()
        Me.l_InvoiceType = New System.Windows.Forms.Label()
        Me.bottompnl = New System.Windows.Forms.Panel()
        Me.amtpnl = New System.Windows.Forms.Panel()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidepnl.SuspendLayout()
        Me.TXNpnl.SuspendLayout()
        Me.bottompnl.SuspendLayout()
        Me.amtpnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.l_SessionId)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(864, 42)
        Me.Panel2.TabIndex = 48
        '
        'l_SessionId
        '
        Me.l_SessionId.AutoSize = True
        Me.l_SessionId.BackColor = System.Drawing.Color.Transparent
        Me.l_SessionId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_SessionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SessionId.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_SessionId.ForeColor = System.Drawing.Color.White
        Me.l_SessionId.Location = New System.Drawing.Point(10, 13)
        Me.l_SessionId.Name = "l_SessionId"
        Me.l_SessionId.Size = New System.Drawing.Size(79, 18)
        Me.l_SessionId.TabIndex = 61
        Me.l_SessionId.Tag = "Session Id: "
        Me.l_SessionId.Text = "Session Id: "
        Me.l_SessionId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(733, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 29)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "TXNs Entry"
        '
        'l_acct
        '
        Me.l_acct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_acct.BackColor = System.Drawing.Color.LightSteelBlue
        Me.l_acct.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_acct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_acct.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_acct.ForeColor = System.Drawing.Color.Black
        Me.l_acct.Location = New System.Drawing.Point(4, 32)
        Me.l_acct.Name = "l_acct"
        Me.l_acct.Size = New System.Drawing.Size(261, 27)
        Me.l_acct.TabIndex = 52
        Me.l_acct.Tag = "Account: "
        Me.l_acct.Text = "Account: "
        Me.l_acct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_DiscountTotal
        '
        Me.l_DiscountTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_DiscountTotal.BackColor = System.Drawing.Color.Orange
        Me.l_DiscountTotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_DiscountTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_DiscountTotal.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Bold)
        Me.l_DiscountTotal.ForeColor = System.Drawing.Color.Black
        Me.l_DiscountTotal.Location = New System.Drawing.Point(4, 274)
        Me.l_DiscountTotal.Name = "l_DiscountTotal"
        Me.l_DiscountTotal.Size = New System.Drawing.Size(261, 27)
        Me.l_DiscountTotal.TabIndex = 156
        Me.l_DiscountTotal.Tag = "Dsc: 0.00"
        Me.l_DiscountTotal.Text = "Dsc: 0.00"
        Me.l_DiscountTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_DiscountTotal.UseCompatibleTextRendering = True
        '
        'l_CustomerId
        '
        Me.l_CustomerId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_CustomerId.BackColor = System.Drawing.Color.LightGray
        Me.l_CustomerId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_CustomerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_CustomerId.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_CustomerId.ForeColor = System.Drawing.Color.Black
        Me.l_CustomerId.Location = New System.Drawing.Point(6, 6)
        Me.l_CustomerId.Name = "l_CustomerId"
        Me.l_CustomerId.Size = New System.Drawing.Size(122, 21)
        Me.l_CustomerId.TabIndex = 55
        Me.l_CustomerId.Tag = "Cust. Id"
        Me.l_CustomerId.Text = "Cust. Id"
        Me.l_CustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.l_ClientName)
        Me.Panel3.Controls.Add(Me.l_CustomerId)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 338)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(466, 32)
        Me.Panel3.TabIndex = 52
        '
        'l_ClientName
        '
        Me.l_ClientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_ClientName.BackColor = System.Drawing.Color.LightGray
        Me.l_ClientName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_ClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ClientName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_ClientName.ForeColor = System.Drawing.Color.Black
        Me.l_ClientName.Location = New System.Drawing.Point(134, 5)
        Me.l_ClientName.Name = "l_ClientName"
        Me.l_ClientName.Size = New System.Drawing.Size(325, 21)
        Me.l_ClientName.TabIndex = 56
        Me.l_ClientName.Tag = ""
        Me.l_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReceiptModify
        '
        Me.btnReceiptModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReceiptModify.BackColor = System.Drawing.Color.LightGray
        Me.btnReceiptModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceiptModify.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnReceiptModify.FlatAppearance.BorderSize = 2
        Me.btnReceiptModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceiptModify.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnReceiptModify.ForeColor = System.Drawing.Color.Black
        Me.btnReceiptModify.Location = New System.Drawing.Point(281, 70)
        Me.btnReceiptModify.Name = "btnReceiptModify"
        Me.btnReceiptModify.Size = New System.Drawing.Size(111, 30)
        Me.btnReceiptModify.TabIndex = 4
        Me.btnReceiptModify.Text = "Modify [F4]"
        Me.btnReceiptModify.UseVisualStyleBackColor = False
        '
        'btnDiscounts
        '
        Me.btnDiscounts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDiscounts.BackColor = System.Drawing.Color.LightGray
        Me.btnDiscounts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiscounts.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnDiscounts.FlatAppearance.BorderSize = 2
        Me.btnDiscounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiscounts.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnDiscounts.ForeColor = System.Drawing.Color.Black
        Me.btnDiscounts.Location = New System.Drawing.Point(281, 178)
        Me.btnDiscounts.Name = "btnDiscounts"
        Me.btnDiscounts.Size = New System.Drawing.Size(111, 30)
        Me.btnDiscounts.TabIndex = 3
        Me.btnDiscounts.Text = "Dsc [F6]"
        Me.btnDiscounts.UseVisualStyleBackColor = False
        '
        'btnCustomers
        '
        Me.btnCustomers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCustomers.BackColor = System.Drawing.Color.LightGray
        Me.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnCustomers.FlatAppearance.BorderSize = 2
        Me.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustomers.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnCustomers.ForeColor = System.Drawing.Color.Black
        Me.btnCustomers.Location = New System.Drawing.Point(281, 142)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(111, 30)
        Me.btnCustomers.TabIndex = 2
        Me.btnCustomers.Text = "Cust. [F3]"
        Me.btnCustomers.UseVisualStyleBackColor = False
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
        Me.btnNew.Location = New System.Drawing.Point(281, 31)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(111, 30)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New [F9]"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(281, 106)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 30)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save [F1]"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dg_TXNs
        '
        Me.dg_TXNs.AllowUserToResizeColumns = False
        Me.dg_TXNs.AllowUserToResizeRows = False
        Me.dg_TXNs.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg_TXNs.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 11.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_TXNs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_TXNs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_TXNs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dg_TXNs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_TXNs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_TXNs.EnableHeadersVisualStyles = False
        Me.dg_TXNs.Location = New System.Drawing.Point(0, 42)
        Me.dg_TXNs.Name = "dg_TXNs"
        Me.dg_TXNs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_TXNs.RowHeadersVisible = False
        Me.dg_TXNs.RowHeadersWidth = 45
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.dg_TXNs.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dg_TXNs.Size = New System.Drawing.Size(466, 296)
        Me.dg_TXNs.TabIndex = 66
        '
        'Column9
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column9.FillWeight = 74.66666!
        Me.Column9.HeaderText = "CODE"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'Column1
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.FillWeight = 74.66666!
        Me.Column1.HeaderText = "ITEM NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 330
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle4.Format = "n0"
        DataGridViewCellStyle4.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.FillWeight = 74.66666!
        Me.Column4.HeaderText = "QTY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.FillWeight = 74.66666!
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column6
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column6.FillWeight = 74.66666!
        Me.Column6.HeaderText = "DISCOUNT"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 120
        '
        'Column7
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column7.FillWeight = 74.66666!
        Me.Column7.HeaderText = "TOTAL"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'sidepnl
        '
        Me.sidepnl.BackColor = System.Drawing.Color.Gainsboro
        Me.sidepnl.Controls.Add(Me.Label2)
        Me.sidepnl.Controls.Add(Me.Button3)
        Me.sidepnl.Controls.Add(Me.btnOrderUpload)
        Me.sidepnl.Controls.Add(Me.btnReprint)
        Me.sidepnl.Controls.Add(Me.l_EditMode)
        Me.sidepnl.Controls.Add(Me.btnReceiptModify)
        Me.sidepnl.Controls.Add(Me.TXNpnl)
        Me.sidepnl.Controls.Add(Me.btnDiscounts)
        Me.sidepnl.Controls.Add(Me.btnSave)
        Me.sidepnl.Controls.Add(Me.btnNew)
        Me.sidepnl.Controls.Add(Me.btnCustomers)
        Me.sidepnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.sidepnl.Location = New System.Drawing.Point(466, 42)
        Me.sidepnl.Name = "sidepnl"
        Me.sidepnl.Size = New System.Drawing.Size(398, 399)
        Me.sidepnl.TabIndex = 49
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.LightGray
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(281, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 30)
        Me.Button3.TabIndex = 157
        Me.Button3.Text = " [F]"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnOrderUpload
        '
        Me.btnOrderUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOrderUpload.BackColor = System.Drawing.Color.LightGray
        Me.btnOrderUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrderUpload.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnOrderUpload.FlatAppearance.BorderSize = 2
        Me.btnOrderUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrderUpload.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrderUpload.ForeColor = System.Drawing.Color.Black
        Me.btnOrderUpload.Location = New System.Drawing.Point(281, 250)
        Me.btnOrderUpload.Name = "btnOrderUpload"
        Me.btnOrderUpload.Size = New System.Drawing.Size(111, 52)
        Me.btnOrderUpload.TabIndex = 156
        Me.btnOrderUpload.Text = "Upload From Order Inv. [F7]"
        Me.btnOrderUpload.UseVisualStyleBackColor = False
        '
        'btnReprint
        '
        Me.btnReprint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReprint.BackColor = System.Drawing.Color.LightGray
        Me.btnReprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReprint.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnReprint.FlatAppearance.BorderSize = 2
        Me.btnReprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReprint.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnReprint.ForeColor = System.Drawing.Color.Black
        Me.btnReprint.Location = New System.Drawing.Point(281, 308)
        Me.btnReprint.Name = "btnReprint"
        Me.btnReprint.Size = New System.Drawing.Size(111, 59)
        Me.btnReprint.TabIndex = 155
        Me.btnReprint.Text = "Reprint Last Inv. [F12]"
        Me.btnReprint.UseVisualStyleBackColor = False
        '
        'l_EditMode
        '
        Me.l_EditMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_EditMode.BackColor = System.Drawing.Color.Red
        Me.l_EditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_EditMode.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.l_EditMode.ForeColor = System.Drawing.Color.White
        Me.l_EditMode.Location = New System.Drawing.Point(8, 378)
        Me.l_EditMode.Name = "l_EditMode"
        Me.l_EditMode.Size = New System.Drawing.Size(385, 21)
        Me.l_EditMode.TabIndex = 154
        Me.l_EditMode.Text = "Bill Edit []"
        Me.l_EditMode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.l_EditMode.Visible = False
        '
        'TXNpnl
        '
        Me.TXNpnl.BackColor = System.Drawing.Color.Gainsboro
        Me.TXNpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.TXNpnl.Controls.Add(Me.l_TotalQty)
        Me.TXNpnl.Controls.Add(Me.l_Change)
        Me.TXNpnl.Controls.Add(Me.l_acct)
        Me.TXNpnl.Controls.Add(Me.l_DiscountTotal)
        Me.TXNpnl.Controls.Add(Me.l_ToPay)
        Me.TXNpnl.Controls.Add(Me.l_VAT)
        Me.TXNpnl.Controls.Add(Me.l_SubTotal)
        Me.TXNpnl.Controls.Add(Me.l_recordCount)
        Me.TXNpnl.Controls.Add(Me.TheTime)
        Me.TXNpnl.Controls.Add(Me.l_InvoiceCode)
        Me.TXNpnl.Controls.Add(Me.l_InvoiceType)
        Me.TXNpnl.Location = New System.Drawing.Point(5, 0)
        Me.TXNpnl.Name = "TXNpnl"
        Me.TXNpnl.Size = New System.Drawing.Size(271, 373)
        Me.TXNpnl.TabIndex = 153
        '
        'l_TotalQty
        '
        Me.l_TotalQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_TotalQty.BackColor = System.Drawing.Color.LightGray
        Me.l_TotalQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalQty.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_TotalQty.ForeColor = System.Drawing.Color.Black
        Me.l_TotalQty.Location = New System.Drawing.Point(4, 169)
        Me.l_TotalQty.Name = "l_TotalQty"
        Me.l_TotalQty.Size = New System.Drawing.Size(261, 27)
        Me.l_TotalQty.TabIndex = 60
        Me.l_TotalQty.Tag = "Total Qty []"
        Me.l_TotalQty.Text = "Total Qty []"
        Me.l_TotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_TotalQty.UseCompatibleTextRendering = True
        '
        'l_Change
        '
        Me.l_Change.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Change.BackColor = System.Drawing.Color.Teal
        Me.l_Change.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Change.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_Change.ForeColor = System.Drawing.Color.White
        Me.l_Change.Location = New System.Drawing.Point(4, 340)
        Me.l_Change.Name = "l_Change"
        Me.l_Change.Size = New System.Drawing.Size(261, 27)
        Me.l_Change.TabIndex = 59
        Me.l_Change.Tag = "Change []"
        Me.l_Change.Text = "Change []"
        Me.l_Change.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_ToPay
        '
        Me.l_ToPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_ToPay.BackColor = System.Drawing.Color.Teal
        Me.l_ToPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ToPay.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_ToPay.ForeColor = System.Drawing.Color.White
        Me.l_ToPay.Location = New System.Drawing.Point(4, 308)
        Me.l_ToPay.Name = "l_ToPay"
        Me.l_ToPay.Size = New System.Drawing.Size(261, 27)
        Me.l_ToPay.TabIndex = 58
        Me.l_ToPay.Tag = "Last Paid []"
        Me.l_ToPay.Text = "Last Paid []"
        Me.l_ToPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_VAT
        '
        Me.l_VAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_VAT.BackColor = System.Drawing.Color.LightGray
        Me.l_VAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_VAT.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_VAT.ForeColor = System.Drawing.Color.Black
        Me.l_VAT.Location = New System.Drawing.Point(4, 239)
        Me.l_VAT.Name = "l_VAT"
        Me.l_VAT.Size = New System.Drawing.Size(261, 27)
        Me.l_VAT.TabIndex = 57
        Me.l_VAT.Tag = "VAT []"
        Me.l_VAT.Text = "VAT []"
        Me.l_VAT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_VAT.UseCompatibleTextRendering = True
        '
        'l_SubTotal
        '
        Me.l_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_SubTotal.BackColor = System.Drawing.Color.LightGray
        Me.l_SubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SubTotal.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.l_SubTotal.Location = New System.Drawing.Point(4, 204)
        Me.l_SubTotal.Name = "l_SubTotal"
        Me.l_SubTotal.Size = New System.Drawing.Size(261, 27)
        Me.l_SubTotal.TabIndex = 56
        Me.l_SubTotal.Tag = "Sub-Total []"
        Me.l_SubTotal.Text = "Sub-Total []"
        Me.l_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_SubTotal.UseCompatibleTextRendering = True
        '
        'l_recordCount
        '
        Me.l_recordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_recordCount.BackColor = System.Drawing.Color.LightGray
        Me.l_recordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_recordCount.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_recordCount.ForeColor = System.Drawing.Color.Black
        Me.l_recordCount.Location = New System.Drawing.Point(4, 134)
        Me.l_recordCount.Name = "l_recordCount"
        Me.l_recordCount.Size = New System.Drawing.Size(261, 27)
        Me.l_recordCount.TabIndex = 55
        Me.l_recordCount.Tag = "[] records"
        Me.l_recordCount.Text = "[] records"
        Me.l_recordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_recordCount.UseCompatibleTextRendering = True
        '
        'TheTime
        '
        Me.TheTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheTime.BackColor = System.Drawing.Color.DodgerBlue
        Me.TheTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TheTime.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.TheTime.ForeColor = System.Drawing.Color.White
        Me.TheTime.Location = New System.Drawing.Point(4, -1)
        Me.TheTime.Name = "TheTime"
        Me.TheTime.Size = New System.Drawing.Size(261, 27)
        Me.TheTime.TabIndex = 4
        Me.TheTime.Text = "05/12/17; 20:43"
        Me.TheTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_InvoiceCode
        '
        Me.l_InvoiceCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_InvoiceCode.BackColor = System.Drawing.Color.LightGray
        Me.l_InvoiceCode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_InvoiceCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvoiceCode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.l_InvoiceCode.ForeColor = System.Drawing.Color.Black
        Me.l_InvoiceCode.Location = New System.Drawing.Point(4, 99)
        Me.l_InvoiceCode.Name = "l_InvoiceCode"
        Me.l_InvoiceCode.Size = New System.Drawing.Size(261, 27)
        Me.l_InvoiceCode.TabIndex = 54
        Me.l_InvoiceCode.Tag = "Invoice Code:"
        Me.l_InvoiceCode.Text = "Invoice Code:"
        Me.l_InvoiceCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_InvoiceCode.UseCompatibleTextRendering = True
        '
        'l_InvoiceType
        '
        Me.l_InvoiceType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_InvoiceType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.l_InvoiceType.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_InvoiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvoiceType.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_InvoiceType.ForeColor = System.Drawing.Color.Black
        Me.l_InvoiceType.Location = New System.Drawing.Point(4, 64)
        Me.l_InvoiceType.Name = "l_InvoiceType"
        Me.l_InvoiceType.Size = New System.Drawing.Size(261, 27)
        Me.l_InvoiceType.TabIndex = 53
        Me.l_InvoiceType.Tag = "Invoice Type"
        Me.l_InvoiceType.Text = "Invoice Type"
        Me.l_InvoiceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_InvoiceType.UseCompatibleTextRendering = True
        '
        'bottompnl
        '
        Me.bottompnl.BackColor = System.Drawing.Color.Silver
        Me.bottompnl.Controls.Add(Me.amtpnl)
        Me.bottompnl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bottompnl.Location = New System.Drawing.Point(0, 370)
        Me.bottompnl.Name = "bottompnl"
        Me.bottompnl.Size = New System.Drawing.Size(466, 71)
        Me.bottompnl.TabIndex = 51
        '
        'amtpnl
        '
        Me.amtpnl.BackColor = System.Drawing.Color.Transparent
        Me.amtpnl.Controls.Add(Me.l_Total)
        Me.amtpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.amtpnl.Location = New System.Drawing.Point(0, 0)
        Me.amtpnl.Name = "amtpnl"
        Me.amtpnl.Size = New System.Drawing.Size(466, 71)
        Me.amtpnl.TabIndex = 156
        '
        'l_Total
        '
        Me.l_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Total.BackColor = System.Drawing.Color.Transparent
        Me.l_Total.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Consolas", 37.0!)
        Me.l_Total.ForeColor = System.Drawing.Color.Black
        Me.l_Total.Location = New System.Drawing.Point(4, 4)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(456, 63)
        Me.l_Total.TabIndex = 155
        Me.l_Total.Tag = "0.00"
        Me.l_Total.Text = "0.00"
        Me.l_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(281, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 27)
        Me.Label2.TabIndex = 158
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cashier
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(864, 441)
        Me.Controls.Add(Me.dg_TXNs)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.bottompnl)
        Me.Controls.Add(Me.sidepnl)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "Cashier"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidepnl.ResumeLayout(False)
        Me.TXNpnl.ResumeLayout(False)
        Me.bottompnl.ResumeLayout(False)
        Me.amtpnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents l_acct As Label
    Friend WithEvents TheTime As Label
    Friend WithEvents sidepnl As Panel
    Friend WithEvents l_InvoiceCode As Label
    Friend WithEvents l_InvoiceType As Label
    Friend WithEvents l_DiscountTotal As Label
    Friend WithEvents l_CustomerId As Label
    Friend WithEvents TXNpnl As Panel
    Friend WithEvents l_recordCount As Label
    Friend WithEvents l_VAT As Label
    Friend WithEvents l_Change As Label
    Friend WithEvents l_ToPay As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dg_TXNs As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnDiscounts As Button
    Friend WithEvents l_SubTotal As Label
    Friend WithEvents l_TotalQty As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents l_EditMode As Label
    Friend WithEvents btnReceiptModify As Button
    Friend WithEvents l_SessionId As Label
    Friend WithEvents l_ClientName As Label
    Friend WithEvents bottompnl As Panel
    Friend WithEvents amtpnl As Panel
    Friend WithEvents l_Total As Label
    Friend WithEvents btnReprint As Button
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btnOrderUpload As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
End Class
