<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payments
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
        Me.btnProceed = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.hdrLabel = New System.Windows.Forms.Label()
        Me.chkCredit = New System.Windows.Forms.CheckBox()
        Me.l_TXNId = New System.Windows.Forms.Label()
        Me.l_Balance = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.t_AmtBank = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_AmtPOS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.l_CustomerId = New System.Windows.Forms.Label()
        Me.l_InvCode = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_AmtCash = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ExactPayBank = New System.Windows.Forms.Label()
        Me.ExactPayPOS = New System.Windows.Forms.Label()
        Me.ExactPayCash = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t_AmtRRN = New System.Windows.Forms.TextBox()
        Me.btnSelectRRN = New System.Windows.Forms.Label()
        Me.l_RRNAmt = New System.Windows.Forms.Label()
        Me.ExactPayRRN = New System.Windows.Forms.Label()
        Me.btnF3 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProceed
        '
        Me.btnProceed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProceed.BackColor = System.Drawing.Color.Green
        Me.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(229, 47)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(111, 24)
        Me.btnProceed.TabIndex = 177
        Me.btnProceed.Text = "PROCEED [F2]"
        Me.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.hdrLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(344, 42)
        Me.Panel2.TabIndex = 176
        '
        'hdrLabel
        '
        Me.hdrLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hdrLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hdrLabel.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.hdrLabel.ForeColor = System.Drawing.Color.White
        Me.hdrLabel.Location = New System.Drawing.Point(0, 0)
        Me.hdrLabel.Name = "hdrLabel"
        Me.hdrLabel.Size = New System.Drawing.Size(344, 42)
        Me.hdrLabel.TabIndex = 0
        Me.hdrLabel.Tag = "Invoice Payment"
        Me.hdrLabel.Text = "Invoice Payment"
        Me.hdrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCredit
        '
        Me.chkCredit.AutoSize = True
        Me.chkCredit.BackColor = System.Drawing.Color.Transparent
        Me.chkCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCredit.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.chkCredit.Location = New System.Drawing.Point(162, 361)
        Me.chkCredit.Name = "chkCredit"
        Me.chkCredit.Size = New System.Drawing.Size(61, 22)
        Me.chkCredit.TabIndex = 217
        Me.chkCredit.Text = "Credit"
        Me.chkCredit.UseVisualStyleBackColor = False
        '
        'l_TXNId
        '
        Me.l_TXNId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_TXNId.AutoSize = True
        Me.l_TXNId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TXNId.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.l_TXNId.ForeColor = System.Drawing.Color.Blue
        Me.l_TXNId.Location = New System.Drawing.Point(184, 174)
        Me.l_TXNId.Name = "l_TXNId"
        Me.l_TXNId.Size = New System.Drawing.Size(49, 17)
        Me.l_TXNId.TabIndex = 216
        Me.l_TXNId.Tag = "TXN ID"
        Me.l_TXNId.Text = "TXN ID"
        '
        'l_Balance
        '
        Me.l_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Balance.AutoSize = True
        Me.l_Balance.BackColor = System.Drawing.Color.Transparent
        Me.l_Balance.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_Balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Balance.Font = New System.Drawing.Font("Consolas", 24.0!)
        Me.l_Balance.ForeColor = System.Drawing.Color.Black
        Me.l_Balance.Location = New System.Drawing.Point(22, 385)
        Me.l_Balance.Name = "l_Balance"
        Me.l_Balance.Size = New System.Drawing.Size(89, 37)
        Me.l_Balance.TabIndex = 215
        Me.l_Balance.Text = "0.00"
        Me.l_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(12, 362)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 19)
        Me.Label17.TabIndex = 214
        Me.Label17.Text = "Invoice Balance"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Teal
        Me.Label14.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label14.Location = New System.Drawing.Point(47, 281)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 2)
        Me.Label14.TabIndex = 213
        Me.Label14.Text = "Label14"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_AmtBank
        '
        Me.t_AmtBank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_AmtBank.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_AmtBank.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_AmtBank.Location = New System.Drawing.Point(48, 258)
        Me.t_AmtBank.MaxLength = 128
        Me.t_AmtBank.Name = "t_AmtBank"
        Me.t_AmtBank.Size = New System.Drawing.Size(200, 22)
        Me.t_AmtBank.TabIndex = 212
        Me.t_AmtBank.Tag = "0.00"
        Me.t_AmtBank.Text = "0.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.LightGray
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(33, 233)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 19)
        Me.Label15.TabIndex = 211
        Me.Label15.Text = "Amount Paid"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(135, 236)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 17)
        Me.Label16.TabIndex = 210
        Me.Label16.Text = "#Direct Transfer"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(48, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 2)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_AmtPOS
        '
        Me.t_AmtPOS.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_AmtPOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_AmtPOS.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_AmtPOS.Location = New System.Drawing.Point(49, 196)
        Me.t_AmtPOS.MaxLength = 128
        Me.t_AmtPOS.Name = "t_AmtPOS"
        Me.t_AmtPOS.Size = New System.Drawing.Size(200, 22)
        Me.t_AmtPOS.TabIndex = 208
        Me.t_AmtPOS.Tag = "0.00"
        Me.t_AmtPOS.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(33, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 19)
        Me.Label9.TabIndex = 207
        Me.Label9.Text = "Amount Paid"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(135, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 206
        Me.Label10.Text = "#POS"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(229, 398)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 24)
        Me.btnClear.TabIndex = 205
        Me.btnClear.Text = "CLEAR [F9]"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_CustomerId
        '
        Me.l_CustomerId.AutoSize = True
        Me.l_CustomerId.BackColor = System.Drawing.Color.Transparent
        Me.l_CustomerId.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_CustomerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_CustomerId.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.l_CustomerId.ForeColor = System.Drawing.Color.Black
        Me.l_CustomerId.Location = New System.Drawing.Point(6, 70)
        Me.l_CustomerId.Name = "l_CustomerId"
        Me.l_CustomerId.Size = New System.Drawing.Size(92, 21)
        Me.l_CustomerId.TabIndex = 204
        Me.l_CustomerId.Text = "customer id"
        Me.l_CustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'l_InvCode
        '
        Me.l_InvCode.AutoSize = True
        Me.l_InvCode.BackColor = System.Drawing.Color.Transparent
        Me.l_InvCode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_InvCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvCode.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_InvCode.ForeColor = System.Drawing.Color.Black
        Me.l_InvCode.Location = New System.Drawing.Point(6, 47)
        Me.l_InvCode.Name = "l_InvCode"
        Me.l_InvCode.Size = New System.Drawing.Size(100, 19)
        Me.l_InvCode.TabIndex = 203
        Me.l_InvCode.Text = "Invoice Code:"
        Me.l_InvCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(48, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 2)
        Me.Label4.TabIndex = 202
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_AmtCash
        '
        Me.t_AmtCash.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_AmtCash.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_AmtCash.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_AmtCash.Location = New System.Drawing.Point(49, 135)
        Me.t_AmtCash.MaxLength = 128
        Me.t_AmtCash.Name = "t_AmtCash"
        Me.t_AmtCash.Size = New System.Drawing.Size(200, 22)
        Me.t_AmtCash.TabIndex = 201
        Me.t_AmtCash.Tag = "0.00"
        Me.t_AmtCash.Text = "0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightGray
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(33, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 200
        Me.Label7.Text = "Amount Paid"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(135, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 199
        Me.Label2.Text = "#Cash"
        '
        'ExactPayBank
        '
        Me.ExactPayBank.AutoSize = True
        Me.ExactPayBank.BackColor = System.Drawing.Color.Teal
        Me.ExactPayBank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExactPayBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExactPayBank.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.ExactPayBank.ForeColor = System.Drawing.Color.White
        Me.ExactPayBank.Location = New System.Drawing.Point(260, 261)
        Me.ExactPayBank.Name = "ExactPayBank"
        Me.ExactPayBank.Size = New System.Drawing.Size(74, 19)
        Me.ExactPayBank.TabIndex = 218
        Me.ExactPayBank.Text = "Pay Exact"
        '
        'ExactPayPOS
        '
        Me.ExactPayPOS.AutoSize = True
        Me.ExactPayPOS.BackColor = System.Drawing.Color.Teal
        Me.ExactPayPOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExactPayPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExactPayPOS.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.ExactPayPOS.ForeColor = System.Drawing.Color.White
        Me.ExactPayPOS.Location = New System.Drawing.Point(260, 197)
        Me.ExactPayPOS.Name = "ExactPayPOS"
        Me.ExactPayPOS.Size = New System.Drawing.Size(74, 19)
        Me.ExactPayPOS.TabIndex = 219
        Me.ExactPayPOS.Text = "Pay Exact"
        '
        'ExactPayCash
        '
        Me.ExactPayCash.AutoSize = True
        Me.ExactPayCash.BackColor = System.Drawing.Color.Teal
        Me.ExactPayCash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExactPayCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExactPayCash.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.ExactPayCash.ForeColor = System.Drawing.Color.White
        Me.ExactPayCash.Location = New System.Drawing.Point(261, 138)
        Me.ExactPayCash.Name = "ExactPayCash"
        Me.ExactPayCash.Size = New System.Drawing.Size(74, 19)
        Me.ExactPayCash.TabIndex = 220
        Me.ExactPayCash.Text = "Pay Exact"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(46, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 2)
        Me.Label1.TabIndex = 223
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_AmtRRN
        '
        Me.t_AmtRRN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_AmtRRN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_AmtRRN.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_AmtRRN.Location = New System.Drawing.Point(47, 320)
        Me.t_AmtRRN.MaxLength = 128
        Me.t_AmtRRN.Name = "t_AmtRRN"
        Me.t_AmtRRN.Size = New System.Drawing.Size(200, 22)
        Me.t_AmtRRN.TabIndex = 222
        Me.t_AmtRRN.Tag = "0.00"
        Me.t_AmtRRN.Text = "0.00"
        '
        'btnSelectRRN
        '
        Me.btnSelectRRN.AutoSize = True
        Me.btnSelectRRN.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSelectRRN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectRRN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectRRN.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.btnSelectRRN.Location = New System.Drawing.Point(32, 294)
        Me.btnSelectRRN.Name = "btnSelectRRN"
        Me.btnSelectRRN.Size = New System.Drawing.Size(83, 19)
        Me.btnSelectRRN.TabIndex = 221
        Me.btnSelectRRN.Tag = "Select RRN"
        Me.btnSelectRRN.Text = "Select RRN"
        '
        'l_RRNAmt
        '
        Me.l_RRNAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_RRNAmt.AutoSize = True
        Me.l_RRNAmt.BackColor = System.Drawing.Color.DarkOrange
        Me.l_RRNAmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RRNAmt.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Bold)
        Me.l_RRNAmt.ForeColor = System.Drawing.Color.Black
        Me.l_RRNAmt.Location = New System.Drawing.Point(134, 296)
        Me.l_RRNAmt.Name = "l_RRNAmt"
        Me.l_RRNAmt.Size = New System.Drawing.Size(80, 17)
        Me.l_RRNAmt.TabIndex = 224
        Me.l_RRNAmt.Tag = "Amt. Due: "
        Me.l_RRNAmt.Text = "Amt. Due:"
        '
        'ExactPayRRN
        '
        Me.ExactPayRRN.AutoSize = True
        Me.ExactPayRRN.BackColor = System.Drawing.Color.Teal
        Me.ExactPayRRN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExactPayRRN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExactPayRRN.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.ExactPayRRN.ForeColor = System.Drawing.Color.White
        Me.ExactPayRRN.Location = New System.Drawing.Point(260, 323)
        Me.ExactPayRRN.Name = "ExactPayRRN"
        Me.ExactPayRRN.Size = New System.Drawing.Size(74, 19)
        Me.ExactPayRRN.TabIndex = 225
        Me.ExactPayRRN.Text = "Pay Exact"
        '
        'btnF3
        '
        Me.btnF3.AutoSize = True
        Me.btnF3.BackColor = System.Drawing.Color.Transparent
        Me.btnF3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnF3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnF3.Font = New System.Drawing.Font("Corbel", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnF3.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnF3.Location = New System.Drawing.Point(218, 80)
        Me.btnF3.Name = "btnF3"
        Me.btnF3.Size = New System.Drawing.Size(101, 17)
        Me.btnF3.TabIndex = 226
        Me.btnF3.Tag = ""
        Me.btnF3.Text = "[F3] Select RRN"
        '
        'Payments
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(344, 441)
        Me.Controls.Add(Me.btnF3)
        Me.Controls.Add(Me.ExactPayRRN)
        Me.Controls.Add(Me.l_RRNAmt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.t_AmtRRN)
        Me.Controls.Add(Me.btnSelectRRN)
        Me.Controls.Add(Me.ExactPayCash)
        Me.Controls.Add(Me.ExactPayPOS)
        Me.Controls.Add(Me.ExactPayBank)
        Me.Controls.Add(Me.chkCredit)
        Me.Controls.Add(Me.l_TXNId)
        Me.Controls.Add(Me.l_Balance)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.t_AmtBank)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.t_AmtPOS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.l_CustomerId)
        Me.Controls.Add(Me.l_InvCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_AmtCash)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Payments"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProceed As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents hdrLabel As Label
    Friend WithEvents chkCredit As CheckBox
    Friend WithEvents l_TXNId As Label
    Friend WithEvents l_Balance As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents t_AmtBank As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents t_AmtPOS As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClear As Label
    Friend WithEvents l_CustomerId As Label
    Friend WithEvents l_InvCode As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents t_AmtCash As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ExactPayBank As Label
    Friend WithEvents ExactPayPOS As Label
    Friend WithEvents ExactPayCash As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents t_AmtRRN As TextBox
    Friend WithEvents btnSelectRRN As Label
    Friend WithEvents l_RRNAmt As Label
    Friend WithEvents ExactPayRRN As Label
    Friend WithEvents btnF3 As Label
End Class
