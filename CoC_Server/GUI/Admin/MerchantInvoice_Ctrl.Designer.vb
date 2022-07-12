<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MerchantInvoice_Ctrl
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c_Product = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_ProductQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_Paid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.l_InvoiceCode = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c_PayMethod = New System.Windows.Forms.ComboBox()
        Me.t_Discount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_Price = New System.Windows.Forms.Label()
        Me.l_PurchasingPower = New System.Windows.Forms.Label()
        Me.l_outstanding = New System.Windows.Forms.Label()
        Me.btnLoadInvoices = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.c_Merchants = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.lv_Invoices = New System.Windows.Forms.ListView()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel2.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(580, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Merchant Invoice"
        '
        'c_Product
        '
        Me.c_Product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_Product.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.c_Product.FormattingEnabled = True
        Me.c_Product.Location = New System.Drawing.Point(22, 140)
        Me.c_Product.Name = "c_Product"
        Me.c_Product.Size = New System.Drawing.Size(270, 23)
        Me.c_Product.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Product"
        '
        't_ProductQty
        '
        Me.t_ProductQty.BackColor = System.Drawing.Color.Silver
        Me.t_ProductQty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_ProductQty.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_ProductQty.Location = New System.Drawing.Point(22, 190)
        Me.t_ProductQty.Name = "t_ProductQty"
        Me.t_ProductQty.Size = New System.Drawing.Size(270, 20)
        Me.t_ProductQty.TabIndex = 47
        Me.t_ProductQty.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Product Qty."
        '
        't_Paid
        '
        Me.t_Paid.BackColor = System.Drawing.Color.Silver
        Me.t_Paid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Paid.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Paid.Location = New System.Drawing.Point(22, 269)
        Me.t_Paid.Name = "t_Paid"
        Me.t_Paid.Size = New System.Drawing.Size(270, 20)
        Me.t_Paid.TabIndex = 51
        Me.t_Paid.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 19)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Amount Paid"
        '
        'l_InvoiceCode
        '
        Me.l_InvoiceCode.BackColor = System.Drawing.Color.DodgerBlue
        Me.l_InvoiceCode.Dock = System.Windows.Forms.DockStyle.Top
        Me.l_InvoiceCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvoiceCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.l_InvoiceCode.ForeColor = System.Drawing.Color.White
        Me.l_InvoiceCode.Location = New System.Drawing.Point(0, 0)
        Me.l_InvoiceCode.Name = "l_InvoiceCode"
        Me.l_InvoiceCode.Size = New System.Drawing.Size(300, 20)
        Me.l_InvoiceCode.TabIndex = 54
        Me.l_InvoiceCode.Text = "Invoice Code"
        Me.l_InvoiceCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Paid By"
        '
        'c_PayMethod
        '
        Me.c_PayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_PayMethod.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.c_PayMethod.FormattingEnabled = True
        Me.c_PayMethod.Location = New System.Drawing.Point(22, 371)
        Me.c_PayMethod.Name = "c_PayMethod"
        Me.c_PayMethod.Size = New System.Drawing.Size(270, 23)
        Me.c_PayMethod.TabIndex = 55
        '
        't_Discount
        '
        Me.t_Discount.BackColor = System.Drawing.Color.Silver
        Me.t_Discount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Discount.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Discount.Location = New System.Drawing.Point(22, 320)
        Me.t_Discount.Name = "t_Discount"
        Me.t_Discount.Size = New System.Drawing.Size(270, 20)
        Me.t_Discount.TabIndex = 61
        Me.t_Discount.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 298)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(228, 19)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "Discount (*calculated with price)"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.l_Price)
        Me.Panel3.Controls.Add(Me.l_PurchasingPower)
        Me.Panel3.Controls.Add(Me.l_outstanding)
        Me.Panel3.Controls.Add(Me.btnLoadInvoices)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.c_Merchants)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.l_InvoiceCode)
        Me.Panel3.Controls.Add(Me.c_PayMethod)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.t_Discount)
        Me.Panel3.Controls.Add(Me.c_Product)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.t_ProductQty)
        Me.Panel3.Controls.Add(Me.t_Paid)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(484, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 399)
        Me.Panel3.TabIndex = 65
        '
        'l_Price
        '
        Me.l_Price.AutoSize = True
        Me.l_Price.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Price.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.l_Price.ForeColor = System.Drawing.Color.Blue
        Me.l_Price.Location = New System.Drawing.Point(21, 217)
        Me.l_Price.Name = "l_Price"
        Me.l_Price.Size = New System.Drawing.Size(45, 21)
        Me.l_Price.TabIndex = 160
        Me.l_Price.Text = "Price"
        '
        'l_PurchasingPower
        '
        Me.l_PurchasingPower.AutoSize = True
        Me.l_PurchasingPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_PurchasingPower.Font = New System.Drawing.Font("Corbel", 9.25!)
        Me.l_PurchasingPower.ForeColor = System.Drawing.Color.Blue
        Me.l_PurchasingPower.Location = New System.Drawing.Point(22, 95)
        Me.l_PurchasingPower.Name = "l_PurchasingPower"
        Me.l_PurchasingPower.Size = New System.Drawing.Size(101, 15)
        Me.l_PurchasingPower.TabIndex = 159
        Me.l_PurchasingPower.Text = "Purchasing Power"
        '
        'l_outstanding
        '
        Me.l_outstanding.AutoSize = True
        Me.l_outstanding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_outstanding.Font = New System.Drawing.Font("Corbel", 9.25!)
        Me.l_outstanding.ForeColor = System.Drawing.Color.Blue
        Me.l_outstanding.Location = New System.Drawing.Point(22, 73)
        Me.l_outstanding.Name = "l_outstanding"
        Me.l_outstanding.Size = New System.Drawing.Size(121, 15)
        Me.l_outstanding.TabIndex = 158
        Me.l_outstanding.Text = "Outstanding Balance"
        '
        'btnLoadInvoices
        '
        Me.btnLoadInvoices.AutoSize = True
        Me.btnLoadInvoices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadInvoices.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.btnLoadInvoices.ForeColor = System.Drawing.Color.Blue
        Me.btnLoadInvoices.Location = New System.Drawing.Point(197, 25)
        Me.btnLoadInvoices.Name = "btnLoadInvoices"
        Me.btnLoadInvoices.Size = New System.Drawing.Size(97, 17)
        Me.btnLoadInvoices.TabIndex = 156
        Me.btnLoadInvoices.Text = "refresh invoices"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 155
        Me.Label11.Text = "Merchant"
        '
        'c_Merchants
        '
        Me.c_Merchants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_Merchants.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.c_Merchants.FormattingEnabled = True
        Me.c_Merchants.Location = New System.Drawing.Point(21, 47)
        Me.c_Merchants.Name = "c_Merchants"
        Me.c_Merchants.Size = New System.Drawing.Size(270, 23)
        Me.c_Merchants.TabIndex = 154
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(21, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(270, 1)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(21, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 1)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(22, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(270, 1)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 33)
        Me.Panel1.TabIndex = 66
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(8, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 17)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "session initiated by;"
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(233, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(120, 21)
        Me.btnNew.TabIndex = 61
        Me.btnNew.Text = "NEW"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(358, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 21)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "SAVE / PRINT"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lv_Invoices
        '
        Me.lv_Invoices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv_Invoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Invoices.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.lv_Invoices.FullRowSelect = True
        Me.lv_Invoices.GridLines = True
        Me.lv_Invoices.Location = New System.Drawing.Point(0, 75)
        Me.lv_Invoices.Name = "lv_Invoices"
        Me.lv_Invoices.Size = New System.Drawing.Size(484, 366)
        Me.lv_Invoices.TabIndex = 67
        Me.lv_Invoices.UseCompatibleStateImageBehavior = False
        Me.lv_Invoices.View = System.Windows.Forms.View.Details
        '
        'MerchantInvoice_Ctrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.lv_Invoices)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.MinimizeBox = False
        Me.Name = "MerchantInvoice_Ctrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MerchantInvoice_Ctrl"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents c_Product As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents t_ProductQty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents t_Paid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents l_InvoiceCode As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents c_PayMethod As ComboBox
    Friend WithEvents t_Discount As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNew As Label
    Friend WithEvents btnSave As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lv_Invoices As ListView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents c_Merchants As ComboBox
    Friend WithEvents btnLoadInvoices As Label
    Friend WithEvents l_PurchasingPower As Label
    Friend WithEvents l_outstanding As Label
    Friend WithEvents l_Price As Label
End Class
