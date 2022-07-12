<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MerchantDebt
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_outstanding = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.c_Merchants = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_Paid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.l_Id = New System.Windows.Forms.Label()
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
        Me.Panel2.Size = New System.Drawing.Size(284, 42)
        Me.Panel2.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Merchant Outstanding"
        '
        'l_outstanding
        '
        Me.l_outstanding.AutoSize = True
        Me.l_outstanding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_outstanding.Font = New System.Drawing.Font("Corbel", 9.25!)
        Me.l_outstanding.ForeColor = System.Drawing.Color.Red
        Me.l_outstanding.Location = New System.Drawing.Point(28, 115)
        Me.l_outstanding.Name = "l_outstanding"
        Me.l_outstanding.Size = New System.Drawing.Size(121, 15)
        Me.l_outstanding.TabIndex = 161
        Me.l_outstanding.Text = "Outstanding Balance"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(14, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "Merchant"
        '
        'c_Merchants
        '
        Me.c_Merchants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.c_Merchants.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.c_Merchants.FormattingEnabled = True
        Me.c_Merchants.Location = New System.Drawing.Point(27, 70)
        Me.c_Merchants.Name = "c_Merchants"
        Me.c_Merchants.Size = New System.Drawing.Size(230, 23)
        Me.c_Merchants.TabIndex = 159
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(27, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 1)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Paid
        '
        Me.t_Paid.BackColor = System.Drawing.Color.Silver
        Me.t_Paid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Paid.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Paid.Location = New System.Drawing.Point(28, 160)
        Me.t_Paid.Name = "t_Paid"
        Me.t_Paid.Size = New System.Drawing.Size(230, 20)
        Me.t_Paid.TabIndex = 163
        Me.t_Paid.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 19)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Settlement Amount"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(27, 213)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(230, 21)
        Me.btnSave.TabIndex = 165
        Me.btnSave.Text = "CONFIRM PAYMENT"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_Id
        '
        Me.l_Id.AutoSize = True
        Me.l_Id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Id.Font = New System.Drawing.Font("Corbel", 9.25!)
        Me.l_Id.ForeColor = System.Drawing.Color.Red
        Me.l_Id.Location = New System.Drawing.Point(28, 95)
        Me.l_Id.Name = "l_Id"
        Me.l_Id.Size = New System.Drawing.Size(72, 15)
        Me.l_Id.TabIndex = 166
        Me.l_Id.Text = "Merchant Id"
        '
        'MerchantDebt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.l_Id)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.t_Paid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.l_outstanding)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.c_Merchants)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MerchantDebt"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MerchantDebt"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents l_outstanding As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents c_Merchants As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents t_Paid As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Label
    Friend WithEvents l_Id As Label
End Class
