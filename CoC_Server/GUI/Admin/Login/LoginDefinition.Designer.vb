<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginDefinition
    Inherits MetroFramework.Forms.MetroForm

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
        Me.c_AAL = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_Fullname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tUsr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tKey = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnProceed = New MetroFramework.Controls.MetroButton()
        Me.btnClear = New MetroFramework.Controls.MetroButton()
        Me.lUsrId = New System.Windows.Forms.Label()
        Me.l_Notice = New MetroFramework.Controls.MetroLabel()
        Me.l_KeyNotice = New MetroFramework.Controls.MetroLabel()
        Me.chkCanLogin = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'c_AAL
        '
        Me.c_AAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c_AAL.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.c_AAL.FormattingEnabled = True
        Me.c_AAL.ItemHeight = 19
        Me.c_AAL.Items.AddRange(New Object() {"", "Admin", "Manager", "Cashier"})
        Me.c_AAL.Location = New System.Drawing.Point(69, 346)
        Me.c_AAL.Name = "c_AAL"
        Me.c_AAL.Size = New System.Drawing.Size(271, 25)
        Me.c_AAL.Style = MetroFramework.MetroColorStyle.Teal
        Me.c_AAL.TabIndex = 4
        Me.c_AAL.Theme = MetroFramework.MetroThemeStyle.Light
        Me.c_AAL.UseCustomBackColor = True
        Me.c_AAL.UseCustomForeColor = True
        Me.c_AAL.UseSelectable = True
        Me.c_AAL.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(51, 316)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(180, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "*Account Authentication Level"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(69, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 2)
        Me.Label3.TabIndex = 210
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Fullname
        '
        Me.t_Fullname.BackColor = System.Drawing.Color.White
        Me.t_Fullname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Fullname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.t_Fullname.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.t_Fullname.Location = New System.Drawing.Point(69, 141)
        Me.t_Fullname.MaxLength = 128
        Me.t_Fullname.Name = "t_Fullname"
        Me.t_Fullname.Size = New System.Drawing.Size(271, 22)
        Me.t_Fullname.TabIndex = 209
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(47, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 208
        Me.Label4.Text = "*Fullname"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(69, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 2)
        Me.Label1.TabIndex = 213
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tUsr
        '
        Me.tUsr.BackColor = System.Drawing.Color.White
        Me.tUsr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tUsr.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.tUsr.Location = New System.Drawing.Point(69, 212)
        Me.tUsr.MaxLength = 128
        Me.tUsr.Name = "tUsr"
        Me.tUsr.Size = New System.Drawing.Size(271, 22)
        Me.tUsr.TabIndex = 212
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "*Username"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DarkGray
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(69, 292)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(271, 2)
        Me.Label5.TabIndex = 216
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tKey
        '
        Me.tKey.BackColor = System.Drawing.Color.White
        Me.tKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tKey.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.tKey.Location = New System.Drawing.Point(69, 271)
        Me.tKey.MaxLength = 32
        Me.tKey.Name = "tKey"
        Me.tKey.Size = New System.Drawing.Size(271, 19)
        Me.tKey.TabIndex = 215
        Me.tKey.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(47, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 19)
        Me.Label6.TabIndex = 214
        Me.Label6.Text = "*Password"
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProceed.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnProceed.ForeColor = System.Drawing.SystemColors.Window
        Me.btnProceed.Location = New System.Drawing.Point(57, 391)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(131, 23)
        Me.btnProceed.Style = MetroFramework.MetroColorStyle.White
        Me.btnProceed.TabIndex = 217
        Me.btnProceed.Text = "PROCEED [F1]"
        Me.btnProceed.UseCustomBackColor = True
        Me.btnProceed.UseCustomForeColor = True
        Me.btnProceed.UseSelectable = True
        Me.btnProceed.UseStyleColors = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnClear.ForeColor = System.Drawing.Color.Teal
        Me.btnClear.Location = New System.Drawing.Point(209, 391)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 23)
        Me.btnClear.Style = MetroFramework.MetroColorStyle.White
        Me.btnClear.TabIndex = 218
        Me.btnClear.Text = "CLEAR [F5]"
        Me.btnClear.UseCustomBackColor = True
        Me.btnClear.UseCustomForeColor = True
        Me.btnClear.UseSelectable = True
        Me.btnClear.UseStyleColors = True
        '
        'lUsrId
        '
        Me.lUsrId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lUsrId.BackColor = System.Drawing.Color.Transparent
        Me.lUsrId.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lUsrId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lUsrId.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lUsrId.ForeColor = System.Drawing.Color.Green
        Me.lUsrId.Location = New System.Drawing.Point(181, 72)
        Me.lUsrId.Name = "lUsrId"
        Me.lUsrId.Size = New System.Drawing.Size(159, 23)
        Me.lUsrId.TabIndex = 219
        Me.lUsrId.Tag = "user id: "
        Me.lUsrId.Text = "user id: "
        Me.lUsrId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lUsrId.UseCompatibleTextRendering = True
        Me.lUsrId.Visible = False
        '
        'l_Notice
        '
        Me.l_Notice.AutoSize = True
        Me.l_Notice.FontSize = MetroFramework.MetroLabelSize.Small
        Me.l_Notice.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.l_Notice.ForeColor = System.Drawing.Color.Red
        Me.l_Notice.Location = New System.Drawing.Point(34, 440)
        Me.l_Notice.Name = "l_Notice"
        Me.l_Notice.Size = New System.Drawing.Size(330, 15)
        Me.l_Notice.TabIndex = 220
        Me.l_Notice.Text = "all fields marked asterisk(*) are important and should be filled"
        Me.l_Notice.UseCustomBackColor = True
        Me.l_Notice.UseCustomForeColor = True
        Me.l_Notice.UseStyleColors = True
        '
        'l_KeyNotice
        '
        Me.l_KeyNotice.AutoSize = True
        Me.l_KeyNotice.FontSize = MetroFramework.MetroLabelSize.Small
        Me.l_KeyNotice.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.l_KeyNotice.ForeColor = System.Drawing.Color.Red
        Me.l_KeyNotice.Location = New System.Drawing.Point(137, 248)
        Me.l_KeyNotice.Name = "l_KeyNotice"
        Me.l_KeyNotice.Size = New System.Drawing.Size(209, 15)
        Me.l_KeyNotice.TabIndex = 221
        Me.l_KeyNotice.Text = "clear if you are not updating password"
        Me.l_KeyNotice.UseCustomBackColor = True
        Me.l_KeyNotice.UseCustomForeColor = True
        Me.l_KeyNotice.UseStyleColors = True
        Me.l_KeyNotice.Visible = False
        '
        'chkCanLogin
        '
        Me.chkCanLogin.AutoSize = True
        Me.chkCanLogin.BackColor = System.Drawing.SystemColors.Window
        Me.chkCanLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCanLogin.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.chkCanLogin.ForeColor = System.Drawing.Color.Black
        Me.chkCanLogin.Location = New System.Drawing.Point(51, 72)
        Me.chkCanLogin.Name = "chkCanLogin"
        Me.chkCanLogin.Size = New System.Drawing.Size(130, 23)
        Me.chkCanLogin.TabIndex = 244
        Me.chkCanLogin.Text = "Account Is Active"
        Me.chkCanLogin.UseVisualStyleBackColor = False
        '
        'LoginDefinition
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(400, 480)
        Me.Controls.Add(Me.chkCanLogin)
        Me.Controls.Add(Me.l_KeyNotice)
        Me.Controls.Add(Me.l_Notice)
        Me.Controls.Add(Me.lUsrId)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tKey)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tUsr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t_Fullname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.c_AAL)
        Me.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginDefinition"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Tag = "Login User Definition"
        Me.Text = "Login User Definition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents c_AAL As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents t_Fullname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tUsr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tKey As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnProceed As MetroFramework.Controls.MetroButton
    Friend WithEvents btnClear As MetroFramework.Controls.MetroButton
    Friend WithEvents lUsrId As Label
    Friend WithEvents l_Notice As MetroFramework.Controls.MetroLabel
    Friend WithEvents l_KeyNotice As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkCanLogin As CheckBox
End Class
