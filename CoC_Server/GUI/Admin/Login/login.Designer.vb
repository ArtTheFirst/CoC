<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tKeyRpt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tUsr = New MetroFramework.Controls.MetroTextBox()
        Me.l_ErrorTxt = New MetroFramework.Controls.MetroLabel()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.Label3.Location = New System.Drawing.Point(21, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "login key"
        '
        'tKey
        '
        Me.tKey.BackColor = System.Drawing.Color.White
        Me.tKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tKey.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.tKey.ForeColor = System.Drawing.Color.Black
        Me.tKey.Location = New System.Drawing.Point(25, 161)
        Me.tKey.MaxLength = 128
        Me.tKey.Name = "tKey"
        Me.tKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tKey.Size = New System.Drawing.Size(250, 20)
        Me.tKey.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 2)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(27, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 2)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tKeyRpt
        '
        Me.tKeyRpt.BackColor = System.Drawing.Color.White
        Me.tKeyRpt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tKeyRpt.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.tKeyRpt.Location = New System.Drawing.Point(26, 238)
        Me.tKeyRpt.MaxLength = 128
        Me.tKeyRpt.Name = "tKeyRpt"
        Me.tKeyRpt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tKeyRpt.Size = New System.Drawing.Size(249, 20)
        Me.tKeyRpt.TabIndex = 156
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.Label7.Location = New System.Drawing.Point(22, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 19)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "repeat login key"
        '
        'tUsr
        '
        '
        '
        '
        Me.tUsr.CustomButton.Image = Nothing
        Me.tUsr.CustomButton.Location = New System.Drawing.Point(221, 1)
        Me.tUsr.CustomButton.Name = ""
        Me.tUsr.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tUsr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tUsr.CustomButton.TabIndex = 1
        Me.tUsr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tUsr.CustomButton.UseSelectable = True
        Me.tUsr.CustomButton.Visible = False
        Me.tUsr.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tUsr.Lines = New String(-1) {}
        Me.tUsr.Location = New System.Drawing.Point(26, 84)
        Me.tUsr.MaxLength = 32
        Me.tUsr.Name = "tUsr"
        Me.tUsr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tUsr.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tUsr.SelectedText = ""
        Me.tUsr.SelectionLength = 0
        Me.tUsr.SelectionStart = 0
        Me.tUsr.ShowClearButton = True
        Me.tUsr.Size = New System.Drawing.Size(249, 29)
        Me.tUsr.TabIndex = 158
        Me.tUsr.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tUsr.UseCustomBackColor = True
        Me.tUsr.UseCustomForeColor = True
        Me.tUsr.UseSelectable = True
        Me.tUsr.UseStyleColors = True
        Me.tUsr.WaterMark = "-enter login name-"
        Me.tUsr.WaterMarkColor = System.Drawing.Color.Teal
        Me.tUsr.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'l_ErrorTxt
        '
        Me.l_ErrorTxt.AutoSize = True
        Me.l_ErrorTxt.BackColor = System.Drawing.Color.Red
        Me.l_ErrorTxt.FontSize = MetroFramework.MetroLabelSize.Small
        Me.l_ErrorTxt.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.l_ErrorTxt.ForeColor = System.Drawing.Color.White
        Me.l_ErrorTxt.Location = New System.Drawing.Point(166, 60)
        Me.l_ErrorTxt.Name = "l_ErrorTxt"
        Me.l_ErrorTxt.Size = New System.Drawing.Size(109, 15)
        Me.l_ErrorTxt.TabIndex = 159
        Me.l_ErrorTxt.Text = "Error Encountered"
        Me.l_ErrorTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l_ErrorTxt.Theme = MetroFramework.MetroThemeStyle.Light
        Me.l_ErrorTxt.UseCustomBackColor = True
        Me.l_ErrorTxt.UseCustomForeColor = True
        Me.l_ErrorTxt.UseStyleColors = True
        Me.l_ErrorTxt.Visible = False
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnClose.ForeColor = System.Drawing.Color.Silver
        Me.btnClose.Location = New System.Drawing.Point(268, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 28)
        Me.btnClose.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnClose.TabIndex = 160
        Me.btnClose.Text = "X"
        Me.btnClose.UseCustomBackColor = True
        Me.btnClose.UseCustomForeColor = True
        Me.btnClose.UseSelectable = True
        Me.btnClose.UseStyleColors = True
        '
        'login
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(300, 271)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.l_ErrorTxt)
        Me.Controls.Add(Me.tUsr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tKeyRpt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tKey)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "login"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Cy POS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents tKey As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tKeyRpt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tUsr As MetroFramework.Controls.MetroTextBox
    Friend WithEvents l_ErrorTxt As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
End Class
