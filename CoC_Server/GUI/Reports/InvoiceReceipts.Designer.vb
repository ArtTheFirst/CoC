<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceReceipts
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
        Me.l_User = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Label()
        Me.chkPurchases = New System.Windows.Forms.CheckBox()
        Me.chkMerchants = New System.Windows.Forms.CheckBox()
        Me.pnl_Filter = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnExtend = New System.Windows.Forms.Label()
        Me.dtp_Ext = New System.Windows.Forms.DateTimePicker()
        Me.dtp_Filter = New System.Windows.Forms.DateTimePicker()
        Me.l_SessionId = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_TotalDiscount = New System.Windows.Forms.Label()
        Me.l_AmtPaid = New System.Windows.Forms.Label()
        Me.l_AmtDue = New System.Windows.Forms.Label()
        Me.l_RecordCount = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lv_Invoices = New System.Windows.Forms.ListView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_Filter.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
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
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(602, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Invoice Receipts"
        '
        'l_User
        '
        Me.l_User.AutoSize = True
        Me.l_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_User.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.l_User.ForeColor = System.Drawing.Color.Blue
        Me.l_User.Location = New System.Drawing.Point(10, 5)
        Me.l_User.Name = "l_User"
        Me.l_User.Size = New System.Drawing.Size(89, 19)
        Me.l_User.TabIndex = 2
        Me.l_User.Text = "logged in as"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.l_RecordCount)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.chkPurchases)
        Me.Panel1.Controls.Add(Me.chkMerchants)
        Me.Panel1.Controls.Add(Me.pnl_Filter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(514, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 399)
        Me.Panel1.TabIndex = 13
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.Red
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(25, 377)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(221, 21)
        Me.btnNew.TabIndex = 219
        Me.btnNew.Text = "RESET"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkPurchases
        '
        Me.chkPurchases.AutoSize = True
        Me.chkPurchases.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkPurchases.Location = New System.Drawing.Point(29, 179)
        Me.chkPurchases.Name = "chkPurchases"
        Me.chkPurchases.Size = New System.Drawing.Size(204, 23)
        Me.chkPurchases.TabIndex = 19
        Me.chkPurchases.Text = "Include Purchase Invoices"
        Me.chkPurchases.UseVisualStyleBackColor = True
        '
        'chkMerchants
        '
        Me.chkMerchants.AutoSize = True
        Me.chkMerchants.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chkMerchants.Location = New System.Drawing.Point(29, 138)
        Me.chkMerchants.Name = "chkMerchants"
        Me.chkMerchants.Size = New System.Drawing.Size(213, 23)
        Me.chkMerchants.TabIndex = 18
        Me.chkMerchants.Text = "Include Merchants Invoices"
        Me.chkMerchants.UseVisualStyleBackColor = True
        '
        'pnl_Filter
        '
        Me.pnl_Filter.BackColor = System.Drawing.Color.DarkGray
        Me.pnl_Filter.Controls.Add(Me.Label16)
        Me.pnl_Filter.Controls.Add(Me.Label15)
        Me.pnl_Filter.Controls.Add(Me.btnExtend)
        Me.pnl_Filter.Controls.Add(Me.dtp_Ext)
        Me.pnl_Filter.Controls.Add(Me.dtp_Filter)
        Me.pnl_Filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Filter.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Filter.Name = "pnl_Filter"
        Me.pnl_Filter.Size = New System.Drawing.Size(270, 120)
        Me.pnl_Filter.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 69)
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
        Me.Label15.Location = New System.Drawing.Point(6, 14)
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
        Me.dtp_Ext.Location = New System.Drawing.Point(15, 91)
        Me.dtp_Ext.Name = "dtp_Ext"
        Me.dtp_Ext.Size = New System.Drawing.Size(250, 25)
        Me.dtp_Ext.TabIndex = 1
        '
        'dtp_Filter
        '
        Me.dtp_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Filter.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.dtp_Filter.Location = New System.Drawing.Point(15, 35)
        Me.dtp_Filter.Name = "dtp_Filter"
        Me.dtp_Filter.Size = New System.Drawing.Size(250, 25)
        Me.dtp_Filter.TabIndex = 0
        '
        'l_SessionId
        '
        Me.l_SessionId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SessionId.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.l_SessionId.ForeColor = System.Drawing.Color.Red
        Me.l_SessionId.Location = New System.Drawing.Point(280, 5)
        Me.l_SessionId.Name = "l_SessionId"
        Me.l_SessionId.Size = New System.Drawing.Size(228, 19)
        Me.l_SessionId.TabIndex = 4
        Me.l_SessionId.Text = "Session Id:"
        Me.l_SessionId.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.l_TotalDiscount)
        Me.Panel3.Controls.Add(Me.l_AmtPaid)
        Me.Panel3.Controls.Add(Me.l_AmtDue)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 387)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(514, 54)
        Me.Panel3.TabIndex = 14
        '
        'l_TotalDiscount
        '
        Me.l_TotalDiscount.AutoSize = True
        Me.l_TotalDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalDiscount.Font = New System.Drawing.Font("Consolas", 24.0!)
        Me.l_TotalDiscount.Location = New System.Drawing.Point(199, 9)
        Me.l_TotalDiscount.Name = "l_TotalDiscount"
        Me.l_TotalDiscount.Size = New System.Drawing.Size(89, 37)
        Me.l_TotalDiscount.TabIndex = 8
        Me.l_TotalDiscount.Tag = "0.00"
        Me.l_TotalDiscount.Text = "0.00"
        '
        'l_AmtPaid
        '
        Me.l_AmtPaid.AutoSize = True
        Me.l_AmtPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_AmtPaid.Font = New System.Drawing.Font("Consolas", 24.0!)
        Me.l_AmtPaid.Location = New System.Drawing.Point(104, 9)
        Me.l_AmtPaid.Name = "l_AmtPaid"
        Me.l_AmtPaid.Size = New System.Drawing.Size(89, 37)
        Me.l_AmtPaid.TabIndex = 7
        Me.l_AmtPaid.Tag = "0.00"
        Me.l_AmtPaid.Text = "0.00"
        '
        'l_AmtDue
        '
        Me.l_AmtDue.AutoSize = True
        Me.l_AmtDue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_AmtDue.Font = New System.Drawing.Font("Consolas", 24.0!)
        Me.l_AmtDue.Location = New System.Drawing.Point(9, 9)
        Me.l_AmtDue.Name = "l_AmtDue"
        Me.l_AmtDue.Size = New System.Drawing.Size(89, 37)
        Me.l_AmtDue.TabIndex = 6
        Me.l_AmtDue.Tag = "0.00"
        Me.l_AmtDue.Text = "0.00"
        '
        'l_RecordCount
        '
        Me.l_RecordCount.AutoSize = True
        Me.l_RecordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RecordCount.Font = New System.Drawing.Font("Consolas", 16.0!)
        Me.l_RecordCount.Location = New System.Drawing.Point(24, 319)
        Me.l_RecordCount.Name = "l_RecordCount"
        Me.l_RecordCount.Size = New System.Drawing.Size(144, 26)
        Me.l_RecordCount.TabIndex = 5
        Me.l_RecordCount.Tag = "0.0 Records"
        Me.l_RecordCount.Text = "0.0 Records"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.Controls.Add(Me.l_User)
        Me.Panel4.Controls.Add(Me.l_SessionId)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 42)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(514, 33)
        Me.Panel4.TabIndex = 15
        '
        'lv_Invoices
        '
        Me.lv_Invoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Invoices.FullRowSelect = True
        Me.lv_Invoices.GridLines = True
        Me.lv_Invoices.Location = New System.Drawing.Point(0, 75)
        Me.lv_Invoices.Name = "lv_Invoices"
        Me.lv_Invoices.Size = New System.Drawing.Size(514, 312)
        Me.lv_Invoices.TabIndex = 16
        Me.lv_Invoices.UseCompatibleStateImageBehavior = False
        Me.lv_Invoices.View = System.Windows.Forms.View.Details
        '
        'InvoiceReceipts
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.lv_Invoices)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.MinimizeBox = False
        Me.Name = "InvoiceReceipts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipts"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnl_Filter.ResumeLayout(False)
        Me.pnl_Filter.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents pnl_Filter As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnExtend As Label
    Friend WithEvents dtp_Ext As DateTimePicker
    Friend WithEvents dtp_Filter As DateTimePicker
    Friend WithEvents chkMerchants As CheckBox
    Friend WithEvents l_User As Label
    Friend WithEvents l_SessionId As Label
    Friend WithEvents l_RecordCount As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lv_Invoices As ListView
    Friend WithEvents l_TotalDiscount As Label
    Friend WithEvents l_AmtPaid As Label
    Friend WithEvents l_AmtDue As Label
    Friend WithEvents chkPurchases As CheckBox
    Friend WithEvents btnNew As Label
End Class
