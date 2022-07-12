<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.t_Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_User = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t_PasskeyIterate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Panel2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login - Admin"
        '
        't_Pass
        '
        Me.t_Pass.BackColor = System.Drawing.Color.Silver
        Me.t_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Pass.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.t_Pass.Location = New System.Drawing.Point(25, 140)
        Me.t_Pass.MaxLength = 24
        Me.t_Pass.Name = "t_Pass"
        Me.t_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_Pass.Size = New System.Drawing.Size(250, 19)
        Me.t_Pass.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.Label3.Location = New System.Drawing.Point(8, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "login key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "login name"
        '
        't_User
        '
        Me.t_User.BackColor = System.Drawing.Color.Silver
        Me.t_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_User.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.t_User.ForeColor = System.Drawing.Color.Black
        Me.t_User.Location = New System.Drawing.Point(25, 74)
        Me.t_User.MaxLength = 8
        Me.t_User.Name = "t_User"
        Me.t_User.Size = New System.Drawing.Size(250, 19)
        Me.t_User.TabIndex = 24
        Me.t_User.Text = "Admin"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Black
        Me.Label15.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(26, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(250, 1)
        Me.Label15.TabIndex = 152
        Me.Label15.Text = "Label15"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 1)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(27, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 1)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_PasskeyIterate
        '
        Me.t_PasskeyIterate.BackColor = System.Drawing.Color.Silver
        Me.t_PasskeyIterate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_PasskeyIterate.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.t_PasskeyIterate.Location = New System.Drawing.Point(26, 200)
        Me.t_PasskeyIterate.MaxLength = 24
        Me.t_PasskeyIterate.Name = "t_PasskeyIterate"
        Me.t_PasskeyIterate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_PasskeyIterate.Size = New System.Drawing.Size(250, 19)
        Me.t_PasskeyIterate.TabIndex = 156
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.Label7.Location = New System.Drawing.Point(9, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 19)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "repeat login key"
        '
        'login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(284, 231)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.t_PasskeyIterate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.t_User)
        Me.Controls.Add(Me.t_Pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents t_Pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t_User As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents t_PasskeyIterate As TextBox
    Friend WithEvents Label7 As Label
End Class
