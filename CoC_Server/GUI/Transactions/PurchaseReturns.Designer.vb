<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PurchaseReturns
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l_PaymentType = New System.Windows.Forms.Label()
        Me.l_BillDate = New System.Windows.Forms.Label()
        Me.l_OrderDate = New System.Windows.Forms.Label()
        Me.l_SupplierName = New System.Windows.Forms.Label()
        Me.l_InvoiceCode = New System.Windows.Forms.Label()
        Me.l_SessionId = New System.Windows.Forms.Label()
        Me.btnFindInvoice = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_RtnQty = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSaveSession = New System.Windows.Forms.Button()
        Me.l_Qty = New System.Windows.Forms.Label()
        Me.l_QtyAmt = New System.Windows.Forms.Label()
        Me.l_Usr = New System.Windows.Forms.Label()
        Me.dg_TXNs = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(621, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Returns"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.l_RtnQty)
        Me.Panel1.Controls.Add(Me.btnSaveSession)
        Me.Panel1.Controls.Add(Me.l_PaymentType)
        Me.Panel1.Controls.Add(Me.l_Qty)
        Me.Panel1.Controls.Add(Me.l_BillDate)
        Me.Panel1.Controls.Add(Me.l_OrderDate)
        Me.Panel1.Controls.Add(Me.l_SupplierName)
        Me.Panel1.Controls.Add(Me.l_InvoiceCode)
        Me.Panel1.Controls.Add(Me.l_SessionId)
        Me.Panel1.Controls.Add(Me.btnFindInvoice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(543, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 399)
        Me.Panel1.TabIndex = 13
        '
        'l_PaymentType
        '
        Me.l_PaymentType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_PaymentType.BackColor = System.Drawing.Color.LightGray
        Me.l_PaymentType.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_PaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_PaymentType.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_PaymentType.ForeColor = System.Drawing.Color.Blue
        Me.l_PaymentType.Location = New System.Drawing.Point(11, 117)
        Me.l_PaymentType.Name = "l_PaymentType"
        Me.l_PaymentType.Size = New System.Drawing.Size(261, 31)
        Me.l_PaymentType.TabIndex = 219
        Me.l_PaymentType.Text = "[Payment Type] Entry"
        Me.l_PaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_PaymentType.UseCompatibleTextRendering = True
        '
        'l_BillDate
        '
        Me.l_BillDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_BillDate.BackColor = System.Drawing.Color.LightGray
        Me.l_BillDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_BillDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_BillDate.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_BillDate.ForeColor = System.Drawing.Color.Black
        Me.l_BillDate.Location = New System.Drawing.Point(11, 78)
        Me.l_BillDate.Name = "l_BillDate"
        Me.l_BillDate.Size = New System.Drawing.Size(261, 31)
        Me.l_BillDate.TabIndex = 218
        Me.l_BillDate.Text = "Bill Date []"
        Me.l_BillDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_BillDate.UseCompatibleTextRendering = True
        '
        'l_OrderDate
        '
        Me.l_OrderDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_OrderDate.BackColor = System.Drawing.Color.Gainsboro
        Me.l_OrderDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_OrderDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_OrderDate.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_OrderDate.ForeColor = System.Drawing.Color.Black
        Me.l_OrderDate.Location = New System.Drawing.Point(11, 40)
        Me.l_OrderDate.Name = "l_OrderDate"
        Me.l_OrderDate.Size = New System.Drawing.Size(261, 31)
        Me.l_OrderDate.TabIndex = 217
        Me.l_OrderDate.Text = "Order Date []"
        Me.l_OrderDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_OrderDate.UseCompatibleTextRendering = True
        '
        'l_SupplierName
        '
        Me.l_SupplierName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_SupplierName.BackColor = System.Drawing.Color.LightGray
        Me.l_SupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SupplierName.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_SupplierName.Location = New System.Drawing.Point(11, 235)
        Me.l_SupplierName.Name = "l_SupplierName"
        Me.l_SupplierName.Size = New System.Drawing.Size(261, 31)
        Me.l_SupplierName.TabIndex = 216
        Me.l_SupplierName.Text = "Supplier Name:"
        Me.l_SupplierName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_SupplierName.UseCompatibleTextRendering = True
        '
        'l_InvoiceCode
        '
        Me.l_InvoiceCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_InvoiceCode.BackColor = System.Drawing.Color.LightGray
        Me.l_InvoiceCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvoiceCode.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_InvoiceCode.Location = New System.Drawing.Point(11, 196)
        Me.l_InvoiceCode.Name = "l_InvoiceCode"
        Me.l_InvoiceCode.Size = New System.Drawing.Size(261, 31)
        Me.l_InvoiceCode.TabIndex = 58
        Me.l_InvoiceCode.Text = "Invoice No.: []"
        Me.l_InvoiceCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_InvoiceCode.UseCompatibleTextRendering = True
        '
        'l_SessionId
        '
        Me.l_SessionId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_SessionId.BackColor = System.Drawing.Color.LightGray
        Me.l_SessionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SessionId.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_SessionId.Location = New System.Drawing.Point(11, 156)
        Me.l_SessionId.Name = "l_SessionId"
        Me.l_SessionId.Size = New System.Drawing.Size(261, 31)
        Me.l_SessionId.TabIndex = 57
        Me.l_SessionId.Text = "Session Id []"
        Me.l_SessionId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_SessionId.UseCompatibleTextRendering = True
        '
        'btnFindInvoice
        '
        Me.btnFindInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFindInvoice.BackColor = System.Drawing.Color.Teal
        Me.btnFindInvoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFindInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindInvoice.Font = New System.Drawing.Font("Segoe UI Light", 10.7!, System.Drawing.FontStyle.Bold)
        Me.btnFindInvoice.ForeColor = System.Drawing.Color.White
        Me.btnFindInvoice.Location = New System.Drawing.Point(130, 8)
        Me.btnFindInvoice.Name = "btnFindInvoice"
        Me.btnFindInvoice.Size = New System.Drawing.Size(143, 23)
        Me.btnFindInvoice.TabIndex = 56
        Me.btnFindInvoice.Tag = "Find Invoice"
        Me.btnFindInvoice.Text = "Find Invoice [f4]"
        Me.btnFindInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnFindInvoice.UseCompatibleTextRendering = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.l_QtyAmt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 380)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(543, 61)
        Me.Panel3.TabIndex = 14
        '
        'l_RtnQty
        '
        Me.l_RtnQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_RtnQty.BackColor = System.Drawing.Color.Gainsboro
        Me.l_RtnQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RtnQty.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_RtnQty.Location = New System.Drawing.Point(11, 315)
        Me.l_RtnQty.Name = "l_RtnQty"
        Me.l_RtnQty.Size = New System.Drawing.Size(261, 31)
        Me.l_RtnQty.TabIndex = 218
        Me.l_RtnQty.Text = "[Qty]"
        Me.l_RtnQty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_RtnQty.UseCompatibleTextRendering = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.LightGray
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNew.FlatAppearance.BorderSize = 2
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(162, 356)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(111, 31)
        Me.btnNew.TabIndex = 217
        Me.btnNew.Text = "New [F5]"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSaveSession
        '
        Me.btnSaveSession.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveSession.BackColor = System.Drawing.Color.LightGray
        Me.btnSaveSession.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSession.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSaveSession.FlatAppearance.BorderSize = 2
        Me.btnSaveSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveSession.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveSession.ForeColor = System.Drawing.Color.Black
        Me.btnSaveSession.Location = New System.Drawing.Point(15, 356)
        Me.btnSaveSession.Name = "btnSaveSession"
        Me.btnSaveSession.Size = New System.Drawing.Size(111, 31)
        Me.btnSaveSession.TabIndex = 216
        Me.btnSaveSession.Text = "Save [F1]"
        Me.btnSaveSession.UseVisualStyleBackColor = False
        '
        'l_Qty
        '
        Me.l_Qty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Qty.BackColor = System.Drawing.Color.Gainsboro
        Me.l_Qty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Qty.Font = New System.Drawing.Font("Segoe UI Light", 10.4!, System.Drawing.FontStyle.Bold)
        Me.l_Qty.Location = New System.Drawing.Point(11, 275)
        Me.l_Qty.Name = "l_Qty"
        Me.l_Qty.Size = New System.Drawing.Size(261, 31)
        Me.l_Qty.TabIndex = 61
        Me.l_Qty.Text = "[Qty]"
        Me.l_Qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_Qty.UseCompatibleTextRendering = True
        '
        'l_QtyAmt
        '
        Me.l_QtyAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_QtyAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_QtyAmt.Font = New System.Drawing.Font("Consolas", 31.0!)
        Me.l_QtyAmt.Location = New System.Drawing.Point(9, 5)
        Me.l_QtyAmt.Name = "l_QtyAmt"
        Me.l_QtyAmt.Size = New System.Drawing.Size(527, 51)
        Me.l_QtyAmt.TabIndex = 59
        Me.l_QtyAmt.Text = "[Amount]"
        Me.l_QtyAmt.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.l_QtyAmt.UseCompatibleTextRendering = True
        '
        'l_Usr
        '
        Me.l_Usr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.l_Usr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Usr.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_Usr.Location = New System.Drawing.Point(0, 359)
        Me.l_Usr.Name = "l_Usr"
        Me.l_Usr.Size = New System.Drawing.Size(543, 21)
        Me.l_Usr.TabIndex = 15
        Me.l_Usr.Text = "Initiated by:"
        Me.l_Usr.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.l_Usr.UseCompatibleTextRendering = True
        '
        'dg_TXNs
        '
        Me.dg_TXNs.AllowUserToAddRows = False
        Me.dg_TXNs.AllowUserToResizeColumns = False
        Me.dg_TXNs.AllowUserToResizeRows = False
        Me.dg_TXNs.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg_TXNs.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_TXNs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_TXNs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_TXNs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_TXNs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_TXNs.EnableHeadersVisualStyles = False
        Me.dg_TXNs.Location = New System.Drawing.Point(0, 42)
        Me.dg_TXNs.Name = "dg_TXNs"
        Me.dg_TXNs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_TXNs.RowHeadersVisible = False
        Me.dg_TXNs.RowHeadersWidth = 45
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_TXNs.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_TXNs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_TXNs.Size = New System.Drawing.Size(543, 317)
        Me.dg_TXNs.TabIndex = 70
        '
        'PurchaseReturns
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.dg_TXNs)
        Me.Controls.Add(Me.l_Usr)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "PurchaseReturns"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dg_TXNs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFindInvoice As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents l_SessionId As Label
    Friend WithEvents l_InvoiceCode As Label
    Friend WithEvents l_QtyAmt As Label
    Friend WithEvents l_SupplierName As Label
    Friend WithEvents l_BillDate As Label
    Friend WithEvents l_OrderDate As Label
    Friend WithEvents l_Usr As Label
    Friend WithEvents dg_TXNs As DataGridView
    Friend WithEvents l_Qty As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSaveSession As Button
    Friend WithEvents l_PaymentType As Label
    Friend WithEvents l_RtnQty As Label
End Class
