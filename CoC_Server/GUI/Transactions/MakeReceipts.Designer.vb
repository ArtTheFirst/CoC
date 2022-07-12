<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MakeReceipts
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
        Me.l_ReceiptCode = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.l_InvBalance = New System.Windows.Forms.Label()
        Me.l_InvTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.t_Amount = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.c_PayMethod = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.l_InvoiceTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c_Invoices = New System.Windows.Forms.ComboBox()
        Me.pnl_Filter = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnExtend = New System.Windows.Forms.Label()
        Me.dtp_Ext = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Filter = New System.Windows.Forms.DateTimePicker()
        Me.btnNew = New System.Windows.Forms.Label()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lv_Invoices = New System.Windows.Forms.ListView()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnl_Filter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.l_ReceiptCode)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 11
        '
        'l_ReceiptCode
        '
        Me.l_ReceiptCode.AutoSize = True
        Me.l_ReceiptCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ReceiptCode.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.l_ReceiptCode.ForeColor = System.Drawing.Color.White
        Me.l_ReceiptCode.Location = New System.Drawing.Point(7, 11)
        Me.l_ReceiptCode.Name = "l_ReceiptCode"
        Me.l_ReceiptCode.Size = New System.Drawing.Size(113, 21)
        Me.l_ReceiptCode.TabIndex = 160
        Me.l_ReceiptCode.Text = "Receipt Code []"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(505, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Generate Invoice Receipts"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.l_InvBalance)
        Me.Panel3.Controls.Add(Me.l_InvTotal)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.t_Amount)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.c_PayMethod)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.l_InvoiceTotal)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.c_Invoices)
        Me.Panel3.Controls.Add(Me.pnl_Filter)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(514, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(270, 399)
        Me.Panel3.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(17, 377)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(240, 21)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "SAVE [F1]"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_InvBalance
        '
        Me.l_InvBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_InvBalance.AutoSize = True
        Me.l_InvBalance.BackColor = System.Drawing.Color.Transparent
        Me.l_InvBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvBalance.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.l_InvBalance.ForeColor = System.Drawing.Color.Blue
        Me.l_InvBalance.Location = New System.Drawing.Point(18, 205)
        Me.l_InvBalance.Name = "l_InvBalance"
        Me.l_InvBalance.Size = New System.Drawing.Size(77, 15)
        Me.l_InvBalance.TabIndex = 220
        Me.l_InvBalance.Text = "Balance []"
        '
        'l_InvTotal
        '
        Me.l_InvTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_InvTotal.AutoSize = True
        Me.l_InvTotal.BackColor = System.Drawing.Color.Transparent
        Me.l_InvTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvTotal.Font = New System.Drawing.Font("Corbel", 9.5!)
        Me.l_InvTotal.ForeColor = System.Drawing.Color.Blue
        Me.l_InvTotal.Location = New System.Drawing.Point(96, 133)
        Me.l_InvTotal.Name = "l_InvTotal"
        Me.l_InvTotal.Size = New System.Drawing.Size(100, 15)
        Me.l_InvTotal.TabIndex = 219
        Me.l_InvTotal.Text = "[] record(s) found"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Gray
        Me.Label18.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(19, 345)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(240, 2)
        Me.Label18.TabIndex = 218
        Me.Label18.Text = "Label18"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Amount
        '
        Me.t_Amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_Amount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_Amount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.t_Amount.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_Amount.Location = New System.Drawing.Point(19, 320)
        Me.t_Amount.MaxLength = 32
        Me.t_Amount.Name = "t_Amount"
        Me.t_Amount.Size = New System.Drawing.Size(240, 22)
        Me.t_Amount.TabIndex = 217
        Me.t_Amount.Text = "0.00"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(8, 295)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(101, 19)
        Me.Label19.TabIndex = 216
        Me.Label19.Text = "Enter Amount"
        '
        'c_PayMethod
        '
        Me.c_PayMethod.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c_PayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_PayMethod.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.c_PayMethod.FormattingEnabled = True
        Me.c_PayMethod.Location = New System.Drawing.Point(17, 253)
        Me.c_PayMethod.Name = "c_PayMethod"
        Me.c_PayMethod.Size = New System.Drawing.Size(240, 25)
        Me.c_PayMethod.TabIndex = 166
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 19)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Choose Payment Option"
        '
        'l_InvoiceTotal
        '
        Me.l_InvoiceTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_InvoiceTotal.AutoSize = True
        Me.l_InvoiceTotal.BackColor = System.Drawing.Color.Transparent
        Me.l_InvoiceTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvoiceTotal.Font = New System.Drawing.Font("Consolas", 9.5!)
        Me.l_InvoiceTotal.ForeColor = System.Drawing.Color.Blue
        Me.l_InvoiceTotal.Location = New System.Drawing.Point(18, 183)
        Me.l_InvoiceTotal.Name = "l_InvoiceTotal"
        Me.l_InvoiceTotal.Size = New System.Drawing.Size(98, 15)
        Me.l_InvoiceTotal.TabIndex = 162
        Me.l_InvoiceTotal.Text = "Total TXNs []"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 19)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Find Invoice"
        '
        'c_Invoices
        '
        Me.c_Invoices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c_Invoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_Invoices.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.c_Invoices.FormattingEnabled = True
        Me.c_Invoices.Location = New System.Drawing.Point(17, 155)
        Me.c_Invoices.Name = "c_Invoices"
        Me.c_Invoices.Size = New System.Drawing.Size(240, 25)
        Me.c_Invoices.TabIndex = 16
        '
        'pnl_Filter
        '
        Me.pnl_Filter.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Filter.Controls.Add(Me.Label16)
        Me.pnl_Filter.Controls.Add(Me.Label15)
        Me.pnl_Filter.Controls.Add(Me.btnExtend)
        Me.pnl_Filter.Controls.Add(Me.dtp_Ext)
        Me.pnl_Filter.Controls.Add(Me.dtp_Filter)
        Me.pnl_Filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Filter.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Filter.Name = "pnl_Filter"
        Me.pnl_Filter.Size = New System.Drawing.Size(270, 110)
        Me.pnl_Filter.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(8, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 19)
        Me.Label16.TabIndex = 162
        Me.Label16.Text = "To"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 19)
        Me.Label15.TabIndex = 161
        Me.Label15.Text = "From"
        '
        'btnExtend
        '
        Me.btnExtend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExtend.AutoSize = True
        Me.btnExtend.BackColor = System.Drawing.Color.Transparent
        Me.btnExtend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExtend.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnExtend.ForeColor = System.Drawing.Color.Blue
        Me.btnExtend.Location = New System.Drawing.Point(157, 4)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(105, 18)
        Me.btnExtend.TabIndex = 169
        Me.btnExtend.Text = "extend filter>>"
        Me.btnExtend.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtp_Ext
        '
        Me.dtp_Ext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Ext.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.dtp_Ext.Location = New System.Drawing.Point(17, 83)
        Me.dtp_Ext.Name = "dtp_Ext"
        Me.dtp_Ext.Size = New System.Drawing.Size(240, 25)
        Me.dtp_Ext.TabIndex = 1
        '
        'dtp_Filter
        '
        Me.dtp_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Filter.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.dtp_Filter.Location = New System.Drawing.Point(17, 26)
        Me.dtp_Filter.Name = "dtp_Filter"
        Me.dtp_Filter.Size = New System.Drawing.Size(240, 25)
        Me.dtp_Filter.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.Red
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(388, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(120, 21)
        Me.btnNew.TabIndex = 15
        Me.btnNew.Text = "RESET [F5]"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_Total
        '
        Me.l_Total.AutoSize = True
        Me.l_Total.BackColor = System.Drawing.Color.Transparent
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.l_Total.ForeColor = System.Drawing.Color.Black
        Me.l_Total.Location = New System.Drawing.Point(6, 4)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(181, 21)
        Me.l_Total.TabIndex = 161
        Me.l_Total.Text = "Date []; [] Item(s); Total []"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.l_Total)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 30)
        Me.Panel1.TabIndex = 16
        '
        'lv_Invoices
        '
        Me.lv_Invoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Invoices.FullRowSelect = True
        Me.lv_Invoices.GridLines = True
        Me.lv_Invoices.Location = New System.Drawing.Point(0, 72)
        Me.lv_Invoices.Name = "lv_Invoices"
        Me.lv_Invoices.Size = New System.Drawing.Size(514, 369)
        Me.lv_Invoices.TabIndex = 17
        Me.lv_Invoices.UseCompatibleStateImageBehavior = False
        Me.lv_Invoices.View = System.Windows.Forms.View.Details
        '
        'MakeReceipts
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.lv_Invoices)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "MakeReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnl_Filter.ResumeLayout(False)
        Me.pnl_Filter.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents l_ReceiptCode As Label
    Friend WithEvents dtp_Filter As DateTimePicker
    Friend WithEvents dtp_Ext As DateTimePicker
    Friend WithEvents pnl_Filter As Panel
    Friend WithEvents c_Invoices As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents c_PayMethod As ComboBox
    Friend WithEvents l_Total As Label
    Friend WithEvents btnNew As Label
    Friend WithEvents btnExtend As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents t_Amount As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents l_InvoiceTotal As Label
    Friend WithEvents btnSave As Label
    Friend WithEvents l_InvTotal As Label
    Friend WithEvents l_InvBalance As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lv_Invoices As ListView
End Class
