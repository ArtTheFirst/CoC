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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.t_Pass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_User = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkCanLogin = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.l_ClientName = New System.Windows.Forms.Label()
        Me.l_ClientId = New System.Windows.Forms.Label()
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
        Me.Panel2.Size = New System.Drawing.Size(584, 42)
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(403, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modify Cashiers"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Teal
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(25, 230)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(270, 2)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Pass
        '
        Me.t_Pass.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Pass.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.t_Pass.Location = New System.Drawing.Point(25, 205)
        Me.t_Pass.Name = "t_Pass"
        Me.t_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_Pass.Size = New System.Drawing.Size(270, 23)
        Me.t_Pass.TabIndex = 157
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.Label7.Location = New System.Drawing.Point(11, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Password"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(25, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 2)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_User
        '
        Me.t_User.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_User.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_User.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.t_User.Location = New System.Drawing.Point(25, 140)
        Me.t_User.MaxLength = 16
        Me.t_User.Name = "t_User"
        Me.t_User.ReadOnly = True
        Me.t_User.Size = New System.Drawing.Size(270, 23)
        Me.t_User.TabIndex = 161
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.Label3.Location = New System.Drawing.Point(11, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(382, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 43)
        Me.Label4.TabIndex = 244
        Me.Label4.Text = "*tick to change account login status"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkCanLogin
        '
        Me.chkCanLogin.AutoSize = True
        Me.chkCanLogin.BackColor = System.Drawing.Color.Transparent
        Me.chkCanLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanLogin.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.chkCanLogin.ForeColor = System.Drawing.Color.Black
        Me.chkCanLogin.Location = New System.Drawing.Point(434, 148)
        Me.chkCanLogin.Name = "chkCanLogin"
        Me.chkCanLogin.Size = New System.Drawing.Size(135, 22)
        Me.chkCanLogin.TabIndex = 243
        Me.chkCanLogin.Text = "Account Is Active"
        Me.chkCanLogin.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.Teal
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(392, 46)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(180, 24)
        Me.btnSave.TabIndex = 245
        Me.btnSave.Text = "SAVE [f1]"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_ClientName
        '
        Me.l_ClientName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_ClientName.BackColor = System.Drawing.Color.Transparent
        Me.l_ClientName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ClientName.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_ClientName.ForeColor = System.Drawing.Color.Blue
        Me.l_ClientName.Location = New System.Drawing.Point(15, 63)
        Me.l_ClientName.Name = "l_ClientName"
        Me.l_ClientName.Size = New System.Drawing.Size(280, 21)
        Me.l_ClientName.TabIndex = 247
        Me.l_ClientName.Tag = "client name"
        Me.l_ClientName.Text = "client name"
        Me.l_ClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l_ClientId
        '
        Me.l_ClientId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_ClientId.BackColor = System.Drawing.Color.Transparent
        Me.l_ClientId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ClientId.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_ClientId.ForeColor = System.Drawing.Color.Blue
        Me.l_ClientId.Location = New System.Drawing.Point(119, 98)
        Me.l_ClientId.Name = "l_ClientId"
        Me.l_ClientId.Size = New System.Drawing.Size(176, 21)
        Me.l_ClientId.TabIndex = 246
        Me.l_ClientId.Tag = "client id"
        Me.l_ClientId.Text = "client id"
        Me.l_ClientId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UserModify_Ctrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(584, 321)
        Me.Controls.Add(Me.l_ClientName)
        Me.Controls.Add(Me.l_ClientId)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkCanLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t_User)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.t_Pass)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserModify_Ctrl"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents t_Pass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t_User As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents chkCanLogin As CheckBox
    Friend WithEvents btnSave As Label
    Friend WithEvents l_ClientName As Label
    Friend WithEvents l_ClientId As Label
End Class
