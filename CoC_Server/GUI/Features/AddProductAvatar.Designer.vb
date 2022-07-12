<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddItemAvatar
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
        Me.btn_AvatarSelect = New System.Windows.Forms.Label()
        Me.usrAvatar = New System.Windows.Forms.PictureBox()
        Me.t_ItemName = New MetroFramework.Controls.MetroTextBox()
        Me.itemId = New System.Windows.Forms.Label()
        Me.itemCode = New System.Windows.Forms.Label()
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_AvatarSelect
        '
        Me.btn_AvatarSelect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_AvatarSelect.AutoSize = True
        Me.btn_AvatarSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_AvatarSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AvatarSelect.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.btn_AvatarSelect.Location = New System.Drawing.Point(102, 333)
        Me.btn_AvatarSelect.Name = "btn_AvatarSelect"
        Me.btn_AvatarSelect.Size = New System.Drawing.Size(105, 14)
        Me.btn_AvatarSelect.TabIndex = 176
        Me.btn_AvatarSelect.Text = "click to select image"
        '
        'usrAvatar
        '
        Me.usrAvatar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usrAvatar.BackColor = System.Drawing.Color.White
        Me.usrAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.usrAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrAvatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usrAvatar.Location = New System.Drawing.Point(92, 170)
        Me.usrAvatar.MaximumSize = New System.Drawing.Size(120, 160)
        Me.usrAvatar.MinimumSize = New System.Drawing.Size(120, 160)
        Me.usrAvatar.Name = "usrAvatar"
        Me.usrAvatar.Size = New System.Drawing.Size(120, 160)
        Me.usrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usrAvatar.TabIndex = 175
        Me.usrAvatar.TabStop = False
        Me.usrAvatar.WaitOnLoad = True
        '
        't_ItemName
        '
        Me.t_ItemName.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.t_ItemName.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.t_ItemName.CustomButton.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.t_ItemName.CustomButton.Image = Nothing
        Me.t_ItemName.CustomButton.Location = New System.Drawing.Point(250, 1)
        Me.t_ItemName.CustomButton.Name = ""
        Me.t_ItemName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.t_ItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.t_ItemName.CustomButton.TabIndex = 1
        Me.t_ItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_ItemName.CustomButton.UseSelectable = True
        Me.t_ItemName.CustomButton.Visible = False
        Me.t_ItemName.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.t_ItemName.Lines = New String(-1) {}
        Me.t_ItemName.Location = New System.Drawing.Point(19, 69)
        Me.t_ItemName.MaxLength = 256
        Me.t_ItemName.Name = "t_ItemName"
        Me.t_ItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.t_ItemName.ReadOnly = True
        Me.t_ItemName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.t_ItemName.SelectedText = ""
        Me.t_ItemName.SelectionLength = 0
        Me.t_ItemName.SelectionStart = 0
        Me.t_ItemName.ShowClearButton = True
        Me.t_ItemName.Size = New System.Drawing.Size(272, 23)
        Me.t_ItemName.Style = MetroFramework.MetroColorStyle.Teal
        Me.t_ItemName.TabIndex = 235
        Me.t_ItemName.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_ItemName.UseCustomBackColor = True
        Me.t_ItemName.UseCustomForeColor = True
        Me.t_ItemName.UseSelectable = True
        Me.t_ItemName.UseStyleColors = True
        Me.t_ItemName.WaterMark = "enter to choose Item"
        Me.t_ItemName.WaterMarkColor = System.Drawing.Color.Teal
        Me.t_ItemName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'itemId
        '
        Me.itemId.BackColor = System.Drawing.Color.Silver
        Me.itemId.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemId.Font = New System.Drawing.Font("Corbel", 11.3!)
        Me.itemId.ForeColor = System.Drawing.Color.Black
        Me.itemId.Location = New System.Drawing.Point(19, 99)
        Me.itemId.Name = "itemId"
        Me.itemId.Size = New System.Drawing.Size(272, 23)
        Me.itemId.TabIndex = 236
        Me.itemId.Tag = "Item Id: "
        Me.itemId.Text = "Item Id: "
        '
        'itemCode
        '
        Me.itemCode.BackColor = System.Drawing.Color.Silver
        Me.itemCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.itemCode.Font = New System.Drawing.Font("Corbel", 11.3!)
        Me.itemCode.ForeColor = System.Drawing.Color.Black
        Me.itemCode.Location = New System.Drawing.Point(19, 126)
        Me.itemCode.Name = "itemCode"
        Me.itemCode.Size = New System.Drawing.Size(272, 23)
        Me.itemCode.TabIndex = 237
        Me.itemCode.Tag = "Barcode: "
        Me.itemCode.Text = "Barcode: "
        '
        'AddItemAvatar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(300, 360)
        Me.Controls.Add(Me.itemCode)
        Me.Controls.Add(Me.itemId)
        Me.Controls.Add(Me.t_ItemName)
        Me.Controls.Add(Me.btn_AvatarSelect)
        Me.Controls.Add(Me.usrAvatar)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddItemAvatar"
        Me.Padding = New System.Windows.Forms.Padding(11, 61, 11, 23)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Choose Image"
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_AvatarSelect As Label
    Friend WithEvents usrAvatar As PictureBox
    Friend WithEvents t_ItemName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents itemId As Label
    Friend WithEvents itemCode As Label
End Class
