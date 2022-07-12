<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Configurations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configurations))
        Me.admTab = New MetroFramework.Controls.MetroTabControl()
        Me.tInfoLicense = New MetroFramework.Controls.MetroTabPage()
        Me.l_ClientNo = New System.Windows.Forms.Label()
        Me.l_LicenseKey = New System.Windows.Forms.Label()
        Me.l_LicenseStatus = New System.Windows.Forms.Label()
        Me.l_AppName = New System.Windows.Forms.Label()
        Me.imgAvatar = New System.Windows.Forms.PictureBox()
        Me.tInfoBackup = New MetroFramework.Controls.MetroTabPage()
        Me.chkTakeBackup = New MetroFramework.Controls.MetroToggle()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBackup = New MetroFramework.Controls.MetroButton()
        Me.tInfoAdmin = New MetroFramework.Controls.MetroTabPage()
        Me.btnLoadLogs = New MetroFramework.Controls.MetroButton()
        Me.btnFormat = New MetroFramework.Controls.MetroButton()
        Me.btnModifyAccount = New MetroFramework.Controls.MetroButton()
        Me.btnCreateAccount = New MetroFramework.Controls.MetroButton()
        Me.btnChoosePrinter = New MetroFramework.Controls.MetroButton()
        Me.btnLoadSubAdmin = New MetroFramework.Controls.MetroButton()
        Me.btnCreateBranch = New MetroFramework.Controls.MetroButton()
        Me.btnModifyAdminLogin = New MetroFramework.Controls.MetroButton()
        Me.btnLoadCompany = New MetroFramework.Controls.MetroButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLicense = New System.Windows.Forms.Label()
        Me.admTab.SuspendLayout()
        Me.tInfoLicense.SuspendLayout()
        CType(Me.imgAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tInfoBackup.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tInfoAdmin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'admTab
        '
        Me.admTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.admTab.Controls.Add(Me.tInfoLicense)
        Me.admTab.Controls.Add(Me.tInfoAdmin)
        Me.admTab.Controls.Add(Me.tInfoBackup)
        Me.admTab.Cursor = System.Windows.Forms.Cursors.Default
        Me.admTab.Location = New System.Drawing.Point(14, 79)
        Me.admTab.Name = "admTab"
        Me.admTab.SelectedIndex = 2
        Me.admTab.ShowToolTips = True
        Me.admTab.Size = New System.Drawing.Size(812, 375)
        Me.admTab.Style = MetroFramework.MetroColorStyle.Blue
        Me.admTab.TabIndex = 0
        Me.admTab.Theme = MetroFramework.MetroThemeStyle.Light
        Me.admTab.UseSelectable = True
        Me.admTab.UseStyleColors = True
        '
        'tInfoLicense
        '
        Me.tInfoLicense.Controls.Add(Me.l_ClientNo)
        Me.tInfoLicense.Controls.Add(Me.l_LicenseKey)
        Me.tInfoLicense.Controls.Add(Me.l_LicenseStatus)
        Me.tInfoLicense.Controls.Add(Me.l_AppName)
        Me.tInfoLicense.Controls.Add(Me.imgAvatar)
        Me.tInfoLicense.HorizontalScrollbarBarColor = True
        Me.tInfoLicense.HorizontalScrollbarHighlightOnWheel = False
        Me.tInfoLicense.HorizontalScrollbarSize = 10
        Me.tInfoLicense.Location = New System.Drawing.Point(4, 41)
        Me.tInfoLicense.Name = "tInfoLicense"
        Me.tInfoLicense.Size = New System.Drawing.Size(804, 330)
        Me.tInfoLicense.TabIndex = 0
        Me.tInfoLicense.Text = "License Information"
        Me.tInfoLicense.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tInfoLicense.UseStyleColors = True
        Me.tInfoLicense.UseVisualStyleBackColor = True
        Me.tInfoLicense.VerticalScrollbarBarColor = True
        Me.tInfoLicense.VerticalScrollbarHighlightOnWheel = False
        Me.tInfoLicense.VerticalScrollbarSize = 10
        '
        'l_ClientNo
        '
        Me.l_ClientNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_ClientNo.BackColor = System.Drawing.Color.Transparent
        Me.l_ClientNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ClientNo.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_ClientNo.ForeColor = System.Drawing.Color.Teal
        Me.l_ClientNo.Location = New System.Drawing.Point(158, 196)
        Me.l_ClientNo.Name = "l_ClientNo"
        Me.l_ClientNo.Size = New System.Drawing.Size(243, 18)
        Me.l_ClientNo.TabIndex = 248
        Me.l_ClientNo.Text = "No. Of Clients: []"
        Me.l_ClientNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_ClientNo.UseCompatibleTextRendering = True
        '
        'l_LicenseKey
        '
        Me.l_LicenseKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_LicenseKey.BackColor = System.Drawing.Color.Transparent
        Me.l_LicenseKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_LicenseKey.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_LicenseKey.ForeColor = System.Drawing.Color.Teal
        Me.l_LicenseKey.Location = New System.Drawing.Point(158, 169)
        Me.l_LicenseKey.Name = "l_LicenseKey"
        Me.l_LicenseKey.Size = New System.Drawing.Size(243, 18)
        Me.l_LicenseKey.TabIndex = 247
        Me.l_LicenseKey.Text = "License Key: []"
        Me.l_LicenseKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_LicenseKey.UseCompatibleTextRendering = True
        '
        'l_LicenseStatus
        '
        Me.l_LicenseStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_LicenseStatus.BackColor = System.Drawing.Color.Transparent
        Me.l_LicenseStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_LicenseStatus.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_LicenseStatus.ForeColor = System.Drawing.Color.Teal
        Me.l_LicenseStatus.Location = New System.Drawing.Point(158, 104)
        Me.l_LicenseStatus.Name = "l_LicenseStatus"
        Me.l_LicenseStatus.Size = New System.Drawing.Size(243, 63)
        Me.l_LicenseStatus.TabIndex = 246
        Me.l_LicenseStatus.Text = "License Status: []"
        Me.l_LicenseStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_LicenseStatus.UseCompatibleTextRendering = True
        '
        'l_AppName
        '
        Me.l_AppName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_AppName.BackColor = System.Drawing.Color.Transparent
        Me.l_AppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_AppName.Font = New System.Drawing.Font("Segoe UI Light", 11.5!, System.Drawing.FontStyle.Bold)
        Me.l_AppName.ForeColor = System.Drawing.Color.Teal
        Me.l_AppName.Location = New System.Drawing.Point(158, 75)
        Me.l_AppName.Name = "l_AppName"
        Me.l_AppName.Size = New System.Drawing.Size(243, 18)
        Me.l_AppName.TabIndex = 245
        Me.l_AppName.Text = "App Name: []"
        Me.l_AppName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_AppName.UseCompatibleTextRendering = True
        '
        'imgAvatar
        '
        Me.imgAvatar.BackColor = System.Drawing.Color.White
        Me.imgAvatar.Image = Global.CoC_Server.My.Resources.Resources.logo_kindof
        Me.imgAvatar.Location = New System.Drawing.Point(452, 3)
        Me.imgAvatar.Name = "imgAvatar"
        Me.imgAvatar.Size = New System.Drawing.Size(349, 324)
        Me.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgAvatar.TabIndex = 2
        Me.imgAvatar.TabStop = False
        '
        'tInfoBackup
        '
        Me.tInfoBackup.Controls.Add(Me.chkTakeBackup)
        Me.tInfoBackup.Controls.Add(Me.PictureBox2)
        Me.tInfoBackup.Controls.Add(Me.btnBackup)
        Me.tInfoBackup.HorizontalScrollbarBarColor = True
        Me.tInfoBackup.HorizontalScrollbarHighlightOnWheel = False
        Me.tInfoBackup.HorizontalScrollbarSize = 10
        Me.tInfoBackup.Location = New System.Drawing.Point(4, 41)
        Me.tInfoBackup.Name = "tInfoBackup"
        Me.tInfoBackup.Size = New System.Drawing.Size(804, 330)
        Me.tInfoBackup.TabIndex = 2
        Me.tInfoBackup.Text = "Backup"
        Me.tInfoBackup.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tInfoBackup.VerticalScrollbarBarColor = True
        Me.tInfoBackup.VerticalScrollbarHighlightOnWheel = False
        Me.tInfoBackup.VerticalScrollbarSize = 10
        '
        'chkTakeBackup
        '
        Me.chkTakeBackup.AutoSize = True
        Me.chkTakeBackup.Location = New System.Drawing.Point(192, 21)
        Me.chkTakeBackup.Name = "chkTakeBackup"
        Me.chkTakeBackup.Size = New System.Drawing.Size(80, 24)
        Me.chkTakeBackup.TabIndex = 9
        Me.chkTakeBackup.Text = "Off"
        Me.chkTakeBackup.UseSelectable = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Image = Global.CoC_Server.My.Resources.Resources.logo_kindof
        Me.PictureBox2.Location = New System.Drawing.Point(452, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(349, 324)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'btnBackup
        '
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.ForeColor = System.Drawing.Color.Blue
        Me.btnBackup.Location = New System.Drawing.Point(278, 21)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(168, 24)
        Me.btnBackup.TabIndex = 7
        Me.btnBackup.Text = "Backup Now"
        Me.btnBackup.UseSelectable = True
        '
        'tInfoAdmin
        '
        Me.tInfoAdmin.Controls.Add(Me.btnLoadLogs)
        Me.tInfoAdmin.Controls.Add(Me.btnFormat)
        Me.tInfoAdmin.Controls.Add(Me.btnModifyAccount)
        Me.tInfoAdmin.Controls.Add(Me.btnCreateAccount)
        Me.tInfoAdmin.Controls.Add(Me.btnChoosePrinter)
        Me.tInfoAdmin.Controls.Add(Me.btnLoadSubAdmin)
        Me.tInfoAdmin.Controls.Add(Me.btnCreateBranch)
        Me.tInfoAdmin.Controls.Add(Me.btnModifyAdminLogin)
        Me.tInfoAdmin.Controls.Add(Me.btnLoadCompany)
        Me.tInfoAdmin.Controls.Add(Me.PictureBox1)
        Me.tInfoAdmin.HorizontalScrollbarBarColor = True
        Me.tInfoAdmin.HorizontalScrollbarHighlightOnWheel = False
        Me.tInfoAdmin.HorizontalScrollbarSize = 10
        Me.tInfoAdmin.Location = New System.Drawing.Point(4, 41)
        Me.tInfoAdmin.Name = "tInfoAdmin"
        Me.tInfoAdmin.Size = New System.Drawing.Size(804, 330)
        Me.tInfoAdmin.TabIndex = 1
        Me.tInfoAdmin.Text = "Admin"
        Me.tInfoAdmin.VerticalScrollbarBarColor = True
        Me.tInfoAdmin.VerticalScrollbarHighlightOnWheel = False
        Me.tInfoAdmin.VerticalScrollbarSize = 10
        '
        'btnLoadLogs
        '
        Me.btnLoadLogs.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnLoadLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadLogs.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLoadLogs.Location = New System.Drawing.Point(132, 254)
        Me.btnLoadLogs.Name = "btnLoadLogs"
        Me.btnLoadLogs.Size = New System.Drawing.Size(243, 24)
        Me.btnLoadLogs.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnLoadLogs.TabIndex = 16
        Me.btnLoadLogs.Text = "VIEW USER LOGS"
        Me.btnLoadLogs.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLoadLogs.UseCustomBackColor = True
        Me.btnLoadLogs.UseCustomForeColor = True
        Me.btnLoadLogs.UseSelectable = True
        Me.btnLoadLogs.UseStyleColors = True
        '
        'btnFormat
        '
        Me.btnFormat.BackColor = System.Drawing.Color.Red
        Me.btnFormat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormat.ForeColor = System.Drawing.Color.White
        Me.btnFormat.Location = New System.Drawing.Point(132, 296)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(243, 24)
        Me.btnFormat.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnFormat.TabIndex = 15
        Me.btnFormat.Text = "RE-FORMAT DATABASES"
        Me.btnFormat.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnFormat.UseCustomBackColor = True
        Me.btnFormat.UseCustomForeColor = True
        Me.btnFormat.UseSelectable = True
        Me.btnFormat.UseStyleColors = True
        '
        'btnModifyAccount
        '
        Me.btnModifyAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyAccount.ForeColor = System.Drawing.Color.Teal
        Me.btnModifyAccount.Location = New System.Drawing.Point(132, 213)
        Me.btnModifyAccount.Name = "btnModifyAccount"
        Me.btnModifyAccount.Size = New System.Drawing.Size(243, 24)
        Me.btnModifyAccount.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnModifyAccount.TabIndex = 14
        Me.btnModifyAccount.Text = "MODIFY LOGIN"
        Me.btnModifyAccount.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModifyAccount.UseCustomBackColor = True
        Me.btnModifyAccount.UseCustomForeColor = True
        Me.btnModifyAccount.UseSelectable = True
        Me.btnModifyAccount.UseStyleColors = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.Teal
        Me.btnCreateAccount.Location = New System.Drawing.Point(132, 183)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(243, 24)
        Me.btnCreateAccount.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCreateAccount.TabIndex = 13
        Me.btnCreateAccount.Text = "CREATE LOGIN"
        Me.btnCreateAccount.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCreateAccount.UseCustomBackColor = True
        Me.btnCreateAccount.UseCustomForeColor = True
        Me.btnCreateAccount.UseSelectable = True
        Me.btnCreateAccount.UseStyleColors = True
        '
        'btnChoosePrinter
        '
        Me.btnChoosePrinter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChoosePrinter.ForeColor = System.Drawing.Color.Teal
        Me.btnChoosePrinter.Location = New System.Drawing.Point(132, 153)
        Me.btnChoosePrinter.Name = "btnChoosePrinter"
        Me.btnChoosePrinter.Size = New System.Drawing.Size(243, 24)
        Me.btnChoosePrinter.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnChoosePrinter.TabIndex = 12
        Me.btnChoosePrinter.Text = "SELECT DEFAULT PRINTER"
        Me.btnChoosePrinter.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnChoosePrinter.UseCustomBackColor = True
        Me.btnChoosePrinter.UseCustomForeColor = True
        Me.btnChoosePrinter.UseSelectable = True
        Me.btnChoosePrinter.UseStyleColors = True
        '
        'btnLoadSubAdmin
        '
        Me.btnLoadSubAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadSubAdmin.ForeColor = System.Drawing.Color.Teal
        Me.btnLoadSubAdmin.Location = New System.Drawing.Point(132, 123)
        Me.btnLoadSubAdmin.Name = "btnLoadSubAdmin"
        Me.btnLoadSubAdmin.Size = New System.Drawing.Size(243, 24)
        Me.btnLoadSubAdmin.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnLoadSubAdmin.TabIndex = 11
        Me.btnLoadSubAdmin.Text = "MODIFY SUB-ADMIN RULES"
        Me.btnLoadSubAdmin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLoadSubAdmin.UseCustomBackColor = True
        Me.btnLoadSubAdmin.UseCustomForeColor = True
        Me.btnLoadSubAdmin.UseSelectable = True
        Me.btnLoadSubAdmin.UseStyleColors = True
        '
        'btnCreateBranch
        '
        Me.btnCreateBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateBranch.ForeColor = System.Drawing.Color.Teal
        Me.btnCreateBranch.Location = New System.Drawing.Point(132, 93)
        Me.btnCreateBranch.Name = "btnCreateBranch"
        Me.btnCreateBranch.Size = New System.Drawing.Size(243, 24)
        Me.btnCreateBranch.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnCreateBranch.TabIndex = 10
        Me.btnCreateBranch.Text = "ADD NEW BRANCH"
        Me.btnCreateBranch.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCreateBranch.UseCustomBackColor = True
        Me.btnCreateBranch.UseCustomForeColor = True
        Me.btnCreateBranch.UseSelectable = True
        Me.btnCreateBranch.UseStyleColors = True
        '
        'btnModifyAdminLogin
        '
        Me.btnModifyAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyAdminLogin.ForeColor = System.Drawing.Color.Teal
        Me.btnModifyAdminLogin.Location = New System.Drawing.Point(132, 63)
        Me.btnModifyAdminLogin.Name = "btnModifyAdminLogin"
        Me.btnModifyAdminLogin.Size = New System.Drawing.Size(243, 24)
        Me.btnModifyAdminLogin.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnModifyAdminLogin.TabIndex = 9
        Me.btnModifyAdminLogin.Text = "MODIFY ADMIN LOGIN"
        Me.btnModifyAdminLogin.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModifyAdminLogin.UseCustomBackColor = True
        Me.btnModifyAdminLogin.UseCustomForeColor = True
        Me.btnModifyAdminLogin.UseSelectable = True
        Me.btnModifyAdminLogin.UseStyleColors = True
        '
        'btnLoadCompany
        '
        Me.btnLoadCompany.BackColor = System.Drawing.Color.Teal
        Me.btnLoadCompany.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadCompany.ForeColor = System.Drawing.Color.White
        Me.btnLoadCompany.Location = New System.Drawing.Point(132, 33)
        Me.btnLoadCompany.Name = "btnLoadCompany"
        Me.btnLoadCompany.Size = New System.Drawing.Size(243, 24)
        Me.btnLoadCompany.Style = MetroFramework.MetroColorStyle.Blue
        Me.btnLoadCompany.TabIndex = 8
        Me.btnLoadCompany.Text = "DEFINE COMPANY DETAILS (HQ)"
        Me.btnLoadCompany.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLoadCompany.UseCustomBackColor = True
        Me.btnLoadCompany.UseCustomForeColor = True
        Me.btnLoadCompany.UseSelectable = True
        Me.btnLoadCompany.UseStyleColors = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.CoC_Server.My.Resources.Resources.logo_kindof
        Me.PictureBox1.Location = New System.Drawing.Point(452, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 324)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnLicense
        '
        Me.btnLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLicense.AutoSize = True
        Me.btnLicense.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLicense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLicense.Enabled = False
        Me.btnLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLicense.Font = New System.Drawing.Font("Segoe UI Light", 11.5!)
        Me.btnLicense.ForeColor = System.Drawing.Color.Black
        Me.btnLicense.Location = New System.Drawing.Point(688, 50)
        Me.btnLicense.Name = "btnLicense"
        Me.btnLicense.Size = New System.Drawing.Size(134, 26)
        Me.btnLicense.TabIndex = 249
        Me.btnLicense.Text = "License Information"
        Me.btnLicense.UseCompatibleTextRendering = True
        Me.btnLicense.Visible = False
        '
        'Configurations
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(840, 480)
        Me.Controls.Add(Me.btnLicense)
        Me.Controls.Add(Me.admTab)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Configurations"
        Me.Padding = New System.Windows.Forms.Padding(11, 61, 11, 23)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Configurations"
        Me.admTab.ResumeLayout(False)
        Me.tInfoLicense.ResumeLayout(False)
        CType(Me.imgAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tInfoBackup.ResumeLayout(False)
        Me.tInfoBackup.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tInfoAdmin.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents admTab As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tInfoLicense As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tInfoAdmin As MetroFramework.Controls.MetroTabPage
    Friend WithEvents imgAvatar As PictureBox
    Friend WithEvents btnLicense As Label
    Friend WithEvents l_ClientNo As Label
    Friend WithEvents l_LicenseKey As Label
    Friend WithEvents l_LicenseStatus As Label
    Friend WithEvents l_AppName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tInfoBackup As MetroFramework.Controls.MetroTabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBackup As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLoadCompany As MetroFramework.Controls.MetroButton
    Friend WithEvents btnFormat As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModifyAccount As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCreateAccount As MetroFramework.Controls.MetroButton
    Friend WithEvents btnChoosePrinter As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLoadSubAdmin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCreateBranch As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModifyAdminLogin As MetroFramework.Controls.MetroButton
    Friend WithEvents btnLoadLogs As MetroFramework.Controls.MetroButton
    Friend WithEvents chkTakeBackup As MetroFramework.Controls.MetroToggle
End Class
