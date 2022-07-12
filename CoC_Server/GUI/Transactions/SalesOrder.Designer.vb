<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TXNsOrder
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
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.l_usr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sidepnl = New System.Windows.Forms.Panel()
        Me.l_EditMode = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l_SessionId = New System.Windows.Forms.Label()
        Me.l_TotalQty = New System.Windows.Forms.Label()
        Me.l_SubTotal = New System.Windows.Forms.Label()
        Me.l_recordCount = New System.Windows.Forms.Label()
        Me.TheTime = New System.Windows.Forms.Label()
        Me.l_InvoiceCode = New System.Windows.Forms.Label()
        Me.l_InvoiceType = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_ClientName = New System.Windows.Forms.Label()
        Me.btnReceiptModify = New System.Windows.Forms.Button()
        Me.l_CustomerId = New System.Windows.Forms.Label()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.dg_TXNs = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.sidepnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.l_usr)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 9
        '
        'l_usr
        '
        Me.l_usr.AutoSize = True
        Me.l_usr.BackColor = System.Drawing.Color.Transparent
        Me.l_usr.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_usr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_usr.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.l_usr.ForeColor = System.Drawing.Color.White
        Me.l_usr.Location = New System.Drawing.Point(12, 13)
        Me.l_usr.Name = "l_usr"
        Me.l_usr.Size = New System.Drawing.Size(46, 21)
        Me.l_usr.TabIndex = 53
        Me.l_usr.Tag = "User:"
        Me.l_usr.Text = "User:"
        Me.l_usr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(649, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Order"
        '
        'sidepnl
        '
        Me.sidepnl.BackColor = System.Drawing.Color.Silver
        Me.sidepnl.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.sidepnl.Controls.Add(Me.l_EditMode)
        Me.sidepnl.Controls.Add(Me.Panel1)
        Me.sidepnl.Dock = System.Windows.Forms.DockStyle.Right
        Me.sidepnl.Location = New System.Drawing.Point(493, 42)
        Me.sidepnl.Name = "sidepnl"
        Me.sidepnl.Size = New System.Drawing.Size(291, 399)
        Me.sidepnl.TabIndex = 50
        '
        'l_EditMode
        '
        Me.l_EditMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_EditMode.BackColor = System.Drawing.Color.Red
        Me.l_EditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_EditMode.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.l_EditMode.ForeColor = System.Drawing.Color.White
        Me.l_EditMode.Location = New System.Drawing.Point(10, 378)
        Me.l_EditMode.Name = "l_EditMode"
        Me.l_EditMode.Size = New System.Drawing.Size(270, 21)
        Me.l_EditMode.TabIndex = 154
        Me.l_EditMode.Text = "Bill Edit []"
        Me.l_EditMode.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.l_EditMode.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.l_SessionId)
        Me.Panel1.Controls.Add(Me.btnReceiptModify)
        Me.Panel1.Controls.Add(Me.btnConfirm)
        Me.Panel1.Controls.Add(Me.btnCustomers)
        Me.Panel1.Controls.Add(Me.l_TotalQty)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.l_SubTotal)
        Me.Panel1.Controls.Add(Me.l_recordCount)
        Me.Panel1.Controls.Add(Me.TheTime)
        Me.Panel1.Controls.Add(Me.l_InvoiceCode)
        Me.Panel1.Controls.Add(Me.l_InvoiceType)
        Me.Panel1.Location = New System.Drawing.Point(10, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 330)
        Me.Panel1.TabIndex = 153
        '
        'l_SessionId
        '
        Me.l_SessionId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_SessionId.BackColor = System.Drawing.Color.LightSteelBlue
        Me.l_SessionId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_SessionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SessionId.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_SessionId.ForeColor = System.Drawing.Color.Black
        Me.l_SessionId.Location = New System.Drawing.Point(11, 34)
        Me.l_SessionId.Name = "l_SessionId"
        Me.l_SessionId.Size = New System.Drawing.Size(255, 27)
        Me.l_SessionId.TabIndex = 61
        Me.l_SessionId.Tag = "Session Id: "
        Me.l_SessionId.Text = "Session Id: "
        Me.l_SessionId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_TotalQty
        '
        Me.l_TotalQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_TotalQty.BackColor = System.Drawing.Color.LightGray
        Me.l_TotalQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalQty.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_TotalQty.ForeColor = System.Drawing.Color.Black
        Me.l_TotalQty.Location = New System.Drawing.Point(11, 178)
        Me.l_TotalQty.Name = "l_TotalQty"
        Me.l_TotalQty.Size = New System.Drawing.Size(255, 27)
        Me.l_TotalQty.TabIndex = 60
        Me.l_TotalQty.Tag = "Total Qty []"
        Me.l_TotalQty.Text = "Total Qty []"
        Me.l_TotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_SubTotal
        '
        Me.l_SubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_SubTotal.BackColor = System.Drawing.Color.LightGray
        Me.l_SubTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SubTotal.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.l_SubTotal.Location = New System.Drawing.Point(11, 214)
        Me.l_SubTotal.Name = "l_SubTotal"
        Me.l_SubTotal.Size = New System.Drawing.Size(255, 27)
        Me.l_SubTotal.TabIndex = 56
        Me.l_SubTotal.Tag = "Sub-Total []"
        Me.l_SubTotal.Text = "Sub-Total []"
        Me.l_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_recordCount
        '
        Me.l_recordCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_recordCount.BackColor = System.Drawing.Color.LightGray
        Me.l_recordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_recordCount.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.l_recordCount.ForeColor = System.Drawing.Color.Black
        Me.l_recordCount.Location = New System.Drawing.Point(11, 141)
        Me.l_recordCount.Name = "l_recordCount"
        Me.l_recordCount.Size = New System.Drawing.Size(255, 27)
        Me.l_recordCount.TabIndex = 55
        Me.l_recordCount.Tag = "[] records"
        Me.l_recordCount.Text = "[] records"
        Me.l_recordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TheTime
        '
        Me.TheTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheTime.BackColor = System.Drawing.Color.DodgerBlue
        Me.TheTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TheTime.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.TheTime.ForeColor = System.Drawing.Color.White
        Me.TheTime.Location = New System.Drawing.Point(11, -1)
        Me.TheTime.Name = "TheTime"
        Me.TheTime.Size = New System.Drawing.Size(255, 29)
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
        Me.l_InvoiceCode.Location = New System.Drawing.Point(11, 105)
        Me.l_InvoiceCode.Name = "l_InvoiceCode"
        Me.l_InvoiceCode.Size = New System.Drawing.Size(255, 27)
        Me.l_InvoiceCode.TabIndex = 54
        Me.l_InvoiceCode.Tag = "Invoice Code:"
        Me.l_InvoiceCode.Text = "Invoice Code:"
        Me.l_InvoiceCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_InvoiceType
        '
        Me.l_InvoiceType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_InvoiceType.BackColor = System.Drawing.Color.LightSteelBlue
        Me.l_InvoiceType.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_InvoiceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvoiceType.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_InvoiceType.ForeColor = System.Drawing.Color.Black
        Me.l_InvoiceType.Location = New System.Drawing.Point(11, 69)
        Me.l_InvoiceType.Name = "l_InvoiceType"
        Me.l_InvoiceType.Size = New System.Drawing.Size(255, 27)
        Me.l_InvoiceType.TabIndex = 53
        Me.l_InvoiceType.Tag = "Invoice Type"
        Me.l_InvoiceType.Text = "Invoice Type"
        Me.l_InvoiceType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.l_Total)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 369)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(493, 72)
        Me.Panel4.TabIndex = 52
        '
        'l_Total
        '
        Me.l_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Total.BackColor = System.Drawing.Color.Transparent
        Me.l_Total.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Consolas", 34.0!)
        Me.l_Total.ForeColor = System.Drawing.Color.Black
        Me.l_Total.Location = New System.Drawing.Point(25, 10)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(462, 54)
        Me.l_Total.TabIndex = 155
        Me.l_Total.Tag = "0.00"
        Me.l_Total.Text = "0.00"
        Me.l_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.l_ClientName)
        Me.Panel3.Controls.Add(Me.l_CustomerId)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 333)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(493, 36)
        Me.Panel3.TabIndex = 53
        '
        'l_ClientName
        '
        Me.l_ClientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_ClientName.BackColor = System.Drawing.Color.LightGray
        Me.l_ClientName.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_ClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ClientName.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_ClientName.ForeColor = System.Drawing.Color.Black
        Me.l_ClientName.Location = New System.Drawing.Point(186, 8)
        Me.l_ClientName.Name = "l_ClientName"
        Me.l_ClientName.Size = New System.Drawing.Size(300, 21)
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
        Me.btnReceiptModify.Location = New System.Drawing.Point(185, 294)
        Me.btnReceiptModify.Name = "btnReceiptModify"
        Me.btnReceiptModify.Size = New System.Drawing.Size(81, 30)
        Me.btnReceiptModify.TabIndex = 4
        Me.btnReceiptModify.Text = "Edit [F4]"
        Me.btnReceiptModify.UseVisualStyleBackColor = False
        '
        'l_CustomerId
        '
        Me.l_CustomerId.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_CustomerId.BackColor = System.Drawing.Color.LightGray
        Me.l_CustomerId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_CustomerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_CustomerId.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_CustomerId.ForeColor = System.Drawing.Color.Black
        Me.l_CustomerId.Location = New System.Drawing.Point(47, 8)
        Me.l_CustomerId.Name = "l_CustomerId"
        Me.l_CustomerId.Size = New System.Drawing.Size(133, 21)
        Me.l_CustomerId.TabIndex = 55
        Me.l_CustomerId.Tag = "Cust. Id"
        Me.l_CustomerId.Text = "Cust. Id"
        Me.l_CustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnCustomers.Location = New System.Drawing.Point(98, 294)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(81, 30)
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
        Me.btnNew.Location = New System.Drawing.Point(185, 258)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(81, 30)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New [F9]"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnConfirm
        '
        Me.btnConfirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfirm.BackColor = System.Drawing.Color.LightGray
        Me.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnConfirm.FlatAppearance.BorderSize = 2
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnConfirm.ForeColor = System.Drawing.Color.Black
        Me.btnConfirm.Location = New System.Drawing.Point(11, 294)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(81, 30)
        Me.btnConfirm.TabIndex = 0
        Me.btnConfirm.Text = "Save [F1]"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'dg_TXNs
        '
        Me.dg_TXNs.AllowUserToResizeColumns = False
        Me.dg_TXNs.AllowUserToResizeRows = False
        Me.dg_TXNs.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg_TXNs.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Corbel", 11.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_TXNs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dg_TXNs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_TXNs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column4, Me.Column5, Me.Column7})
        Me.dg_TXNs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_TXNs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_TXNs.EnableHeadersVisualStyles = False
        Me.dg_TXNs.Location = New System.Drawing.Point(0, 42)
        Me.dg_TXNs.Name = "dg_TXNs"
        Me.dg_TXNs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_TXNs.RowHeadersVisible = False
        Me.dg_TXNs.RowHeadersWidth = 45
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.dg_TXNs.RowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dg_TXNs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_TXNs.Size = New System.Drawing.Size(493, 291)
        Me.dg_TXNs.TabIndex = 67
        '
        'Column9
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle16.Format = "N0"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle16
        Me.Column9.FillWeight = 74.66666!
        Me.Column9.HeaderText = "CODE"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 80
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle17
        Me.Column1.FillWeight = 74.66666!
        Me.Column1.HeaderText = "ITEM NAME"
        Me.Column1.Name = "Column1"
        '
        'Column4
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Consolas", 12.0!)
        DataGridViewCellStyle18.Format = "n0"
        DataGridViewCellStyle18.NullValue = "0"
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle18
        Me.Column4.FillWeight = 74.66666!
        Me.Column4.HeaderText = "QTY"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 60
        '
        'Column5
        '
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle19
        Me.Column5.FillWeight = 74.66666!
        Me.Column5.HeaderText = "PRICE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 120
        '
        'Column7
        '
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column7.FillWeight = 74.66666!
        Me.Column7.HeaderText = "TOTAL"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.5!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 27)
        Me.Label2.TabIndex = 62
        Me.Label2.Tag = ""
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXNsOrder
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.dg_TXNs)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.sidepnl)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "TXNsOrder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.sidepnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents sidepnl As Panel
    Friend WithEvents l_EditMode As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents l_SessionId As Label
    Friend WithEvents l_TotalQty As Label
    Friend WithEvents l_SubTotal As Label
    Friend WithEvents l_recordCount As Label
    Friend WithEvents TheTime As Label
    Friend WithEvents l_InvoiceCode As Label
    Friend WithEvents l_InvoiceType As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents l_Total As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents l_ClientName As Label
    Friend WithEvents btnReceiptModify As Button
    Friend WithEvents l_CustomerId As Label
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents dg_TXNs As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents l_usr As Label
    Friend WithEvents Label2 As Label
End Class
