<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Merchant
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
        Me.t_PurchasePower = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNewRecord = New System.Windows.Forms.Label()
        Me.l_MerchantId = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c_PreferredCurrency = New System.Windows.Forms.ComboBox()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Label()
        Me.c_Merchants = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c_PreferredPayment = New System.Windows.Forms.ComboBox()
        Me.t_Address = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_Company = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(651, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Merchants"
        '
        't_PurchasePower
        '
        Me.t_PurchasePower.BackColor = System.Drawing.Color.Silver
        Me.t_PurchasePower.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_PurchasePower.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_PurchasePower.Location = New System.Drawing.Point(44, 382)
        Me.t_PurchasePower.MaxLength = 128
        Me.t_PurchasePower.Name = "t_PurchasePower"
        Me.t_PurchasePower.Size = New System.Drawing.Size(540, 20)
        Me.t_PurchasePower.TabIndex = 82
        Me.t_PurchasePower.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(26, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 19)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Purchasing Power"
        '
        'btnNewRecord
        '
        Me.btnNewRecord.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnNewRecord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewRecord.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.btnNewRecord.ForeColor = System.Drawing.Color.White
        Me.btnNewRecord.Location = New System.Drawing.Point(598, 210)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(180, 24)
        Me.btnNewRecord.TabIndex = 80
        Me.btnNewRecord.Text = "NEW RECORD"
        Me.btnNewRecord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_MerchantId
        '
        Me.l_MerchantId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_MerchantId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_MerchantId.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_MerchantId.ForeColor = System.Drawing.Color.Blue
        Me.l_MerchantId.Location = New System.Drawing.Point(314, 51)
        Me.l_MerchantId.Name = "l_MerchantId"
        Me.l_MerchantId.Size = New System.Drawing.Size(270, 21)
        Me.l_MerchantId.TabIndex = 79
        Me.l_MerchantId.Text = "merchant id"
        Me.l_MerchantId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(26, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(131, 19)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Preferred Currency"
        '
        'c_PreferredCurrency
        '
        Me.c_PreferredCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_PreferredCurrency.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.c_PreferredCurrency.FormattingEnabled = True
        Me.c_PreferredCurrency.Location = New System.Drawing.Point(44, 321)
        Me.c_PreferredCurrency.Name = "c_PreferredCurrency"
        Me.c_PreferredCurrency.Size = New System.Drawing.Size(540, 27)
        Me.c_PreferredCurrency.TabIndex = 77
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(598, 274)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(180, 24)
        Me.btnDelete.TabIndex = 76
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(598, 242)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(180, 24)
        Me.btnCreate.TabIndex = 75
        Me.btnCreate.Text = "SAVE"
        Me.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'c_Merchants
        '
        Me.c_Merchants.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.c_Merchants.FormattingEnabled = True
        Me.c_Merchants.Location = New System.Drawing.Point(44, 77)
        Me.c_Merchants.Name = "c_Merchants"
        Me.c_Merchants.Size = New System.Drawing.Size(540, 27)
        Me.c_Merchants.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 19)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Preferred Payment"
        '
        'c_PreferredPayment
        '
        Me.c_PreferredPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_PreferredPayment.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.c_PreferredPayment.FormattingEnabled = True
        Me.c_PreferredPayment.Location = New System.Drawing.Point(44, 264)
        Me.c_PreferredPayment.Name = "c_PreferredPayment"
        Me.c_PreferredPayment.Size = New System.Drawing.Size(540, 27)
        Me.c_PreferredPayment.TabIndex = 72
        '
        't_Address
        '
        Me.t_Address.BackColor = System.Drawing.Color.Silver
        Me.t_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Address.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Address.Location = New System.Drawing.Point(44, 205)
        Me.t_Address.MaxLength = 128
        Me.t_Address.Name = "t_Address"
        Me.t_Address.Size = New System.Drawing.Size(540, 20)
        Me.t_Address.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(26, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Address"
        '
        't_Company
        '
        Me.t_Company.BackColor = System.Drawing.Color.Silver
        Me.t_Company.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Company.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Company.Location = New System.Drawing.Point(44, 140)
        Me.t_Company.MaxLength = 64
        Me.t_Company.Name = "t_Company"
        Me.t_Company.Size = New System.Drawing.Size(540, 20)
        Me.t_Company.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Company"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(26, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Merchant"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(44, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(540, 1)
        Me.Label9.TabIndex = 149
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(44, 233)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(540, 1)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(44, 410)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(540, 1)
        Me.Label11.TabIndex = 151
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Merchant
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.t_PurchasePower)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnNewRecord)
        Me.Controls.Add(Me.l_MerchantId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.c_PreferredCurrency)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.c_Merchants)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.c_PreferredPayment)
        Me.Controls.Add(Me.t_Address)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t_Company)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Merchant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Merchant"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents t_PurchasePower As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNewRecord As Label
    Friend WithEvents l_MerchantId As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents c_PreferredCurrency As ComboBox
    Friend WithEvents btnDelete As Label
    Friend WithEvents btnCreate As Label
    Friend WithEvents c_Merchants As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents c_PreferredPayment As ComboBox
    Friend WithEvents t_Address As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents t_Company As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
