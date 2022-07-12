<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tokens
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
        Me.pnl_Tokens = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t_Acct = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.pnl_Tokens.SuspendLayout()
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
        Me.Panel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(193, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tokens"
        '
        'pnl_Tokens
        '
        Me.pnl_Tokens.Controls.Add(Me.CheckBox2)
        Me.pnl_Tokens.Controls.Add(Me.Label2)
        Me.pnl_Tokens.Controls.Add(Me.TextBox1)
        Me.pnl_Tokens.Controls.Add(Me.Label3)
        Me.pnl_Tokens.Controls.Add(Me.Label7)
        Me.pnl_Tokens.Controls.Add(Me.t_Acct)
        Me.pnl_Tokens.Controls.Add(Me.Label16)
        Me.pnl_Tokens.Controls.Add(Me.CheckBox1)
        Me.pnl_Tokens.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Tokens.Location = New System.Drawing.Point(0, 42)
        Me.pnl_Tokens.Name = "pnl_Tokens"
        Me.pnl_Tokens.Size = New System.Drawing.Size(284, 219)
        Me.pnl_Tokens.TabIndex = 9
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(12, 183)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(224, 23)
        Me.CheckBox2.TabIndex = 171
        Me.CheckBox2.Text = "Allow Sub Admin Grant Token"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(10, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 18)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "Maximum Tokens Per Exploit Exception"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.TextBox1.Location = New System.Drawing.Point(25, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(250, 18)
        Me.TextBox1.TabIndex = 169
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 2)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(10, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 18)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "Maximum Tokens Per Exploit"
        '
        't_Acct
        '
        Me.t_Acct.BackColor = System.Drawing.Color.Silver
        Me.t_Acct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Acct.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.t_Acct.Location = New System.Drawing.Point(25, 77)
        Me.t_Acct.Name = "t_Acct"
        Me.t_Acct.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_Acct.Size = New System.Drawing.Size(250, 18)
        Me.t_Acct.TabIndex = 166
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Gray
        Me.Label16.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(24, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(250, 2)
        Me.Label16.TabIndex = 167
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 23)
        Me.CheckBox1.TabIndex = 164
        Me.CheckBox1.Text = "Use Tokens"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Tokens
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pnl_Tokens)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tokens"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tokens"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl_Tokens.ResumeLayout(False)
        Me.pnl_Tokens.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_Tokens As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents t_Acct As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents CheckBox1 As CheckBox
End Class
