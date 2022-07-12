<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserModify_Ctrl
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
        Me.c_Accts = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_Pass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.l_usr = New System.Windows.Forms.Label()
        Me.l_Server = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.l_Login = New System.Windows.Forms.Label()
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
        Me.Panel2.Size = New System.Drawing.Size(456, 42)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login; Edit Users - Cashiers"
        '
        'c_Accts
        '
        Me.c_Accts.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.c_Accts.FormattingEnabled = True
        Me.c_Accts.Location = New System.Drawing.Point(24, 71)
        Me.c_Accts.Name = "c_Accts"
        Me.c_Accts.Size = New System.Drawing.Size(210, 23)
        Me.c_Accts.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "User Name"
        '
        't_Pass
        '
        Me.t_Pass.BackColor = System.Drawing.Color.Silver
        Me.t_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Pass.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.t_Pass.Location = New System.Drawing.Point(24, 127)
        Me.t_Pass.Name = "t_Pass"
        Me.t_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_Pass.Size = New System.Drawing.Size(210, 19)
        Me.t_Pass.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(9, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Password"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 12.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(243, 43)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(212, 21)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_usr
        '
        Me.l_usr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_usr.BackColor = System.Drawing.Color.LightGray
        Me.l_usr.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_usr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_usr.Font = New System.Drawing.Font("Corbel", 9.5!)
        Me.l_usr.ForeColor = System.Drawing.Color.Blue
        Me.l_usr.Location = New System.Drawing.Point(243, 159)
        Me.l_usr.Name = "l_usr"
        Me.l_usr.Size = New System.Drawing.Size(212, 18)
        Me.l_usr.TabIndex = 42
        Me.l_usr.Text = "logged in user"
        Me.l_usr.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l_Server
        '
        Me.l_Server.BackColor = System.Drawing.Color.LightGray
        Me.l_Server.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_Server.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.l_Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Server.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.l_Server.ForeColor = System.Drawing.Color.Blue
        Me.l_Server.Location = New System.Drawing.Point(0, 181)
        Me.l_Server.Name = "l_Server"
        Me.l_Server.Size = New System.Drawing.Size(456, 21)
        Me.l_Server.TabIndex = 44
        Me.l_Server.Text = "server address"
        Me.l_Server.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(23, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(210, 1)
        Me.Label16.TabIndex = 153
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_Login
        '
        Me.l_Login.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Login.BackColor = System.Drawing.Color.Transparent
        Me.l_Login.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Login.Font = New System.Drawing.Font("Corbel", 9.5!)
        Me.l_Login.ForeColor = System.Drawing.Color.Blue
        Me.l_Login.Location = New System.Drawing.Point(239, 67)
        Me.l_Login.Name = "l_Login"
        Me.l_Login.Size = New System.Drawing.Size(212, 88)
        Me.l_Login.TabIndex = 154
        Me.l_Login.Text = "User details"
        Me.l_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserModify_Ctrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(456, 202)
        Me.Controls.Add(Me.l_Login)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.l_Server)
        Me.Controls.Add(Me.l_usr)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.t_Pass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.c_Accts)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserModify_Ctrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserModify_Ctrl"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents c_Accts As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents t_Pass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Label
    Friend WithEvents l_usr As Label
    Friend WithEvents l_Server As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents l_Login As Label
End Class
