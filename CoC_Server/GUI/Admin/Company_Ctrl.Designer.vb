<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Company_Ctrl
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
        Me.t_Company = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usrAvatar = New System.Windows.Forms.PictureBox()
        Me.modifyAvatar = New System.Windows.Forms.Label()
        Me.t_Address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_Email = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.t_Phone1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_OrganisationType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkHQs = New System.Windows.Forms.CheckBox()
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_Company
        '
        Me.t_Company.BackColor = System.Drawing.SystemColors.Window
        Me.t_Company.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Company.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Company.Location = New System.Drawing.Point(45, 110)
        Me.t_Company.Name = "t_Company"
        Me.t_Company.Size = New System.Drawing.Size(450, 20)
        Me.t_Company.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(29, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 19)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "*Company Name"
        '
        'usrAvatar
        '
        Me.usrAvatar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.usrAvatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usrAvatar.Location = New System.Drawing.Point(612, 57)
        Me.usrAvatar.Name = "usrAvatar"
        Me.usrAvatar.Size = New System.Drawing.Size(160, 240)
        Me.usrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usrAvatar.TabIndex = 46
        Me.usrAvatar.TabStop = False
        '
        'modifyAvatar
        '
        Me.modifyAvatar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.modifyAvatar.BackColor = System.Drawing.Color.Silver
        Me.modifyAvatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.modifyAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifyAvatar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.modifyAvatar.ForeColor = System.Drawing.Color.DimGray
        Me.modifyAvatar.Location = New System.Drawing.Point(617, 278)
        Me.modifyAvatar.Name = "modifyAvatar"
        Me.modifyAvatar.Size = New System.Drawing.Size(151, 15)
        Me.modifyAvatar.TabIndex = 47
        Me.modifyAvatar.Text = "change logo"
        Me.modifyAvatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        't_Address
        '
        Me.t_Address.BackColor = System.Drawing.SystemColors.Window
        Me.t_Address.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Address.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Address.Location = New System.Drawing.Point(45, 178)
        Me.t_Address.Name = "t_Address"
        Me.t_Address.Size = New System.Drawing.Size(450, 20)
        Me.t_Address.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(29, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 19)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Address"
        '
        't_Email
        '
        Me.t_Email.BackColor = System.Drawing.SystemColors.Window
        Me.t_Email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Email.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Email.ForeColor = System.Drawing.Color.Black
        Me.t_Email.Location = New System.Drawing.Point(45, 362)
        Me.t_Email.Name = "t_Email"
        Me.t_Email.Size = New System.Drawing.Size(450, 20)
        Me.t_Email.TabIndex = 59
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(632, 374)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 27)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "SAVE [F1]"
        Me.btnSave.UseCompatibleTextRendering = True
        Me.btnSave.UseVisualStyleBackColor = False
        Me.btnSave.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(30, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Email"
        '
        't_Phone1
        '
        Me.t_Phone1.BackColor = System.Drawing.SystemColors.Window
        Me.t_Phone1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Phone1.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Phone1.Location = New System.Drawing.Point(45, 300)
        Me.t_Phone1.Name = "t_Phone1"
        Me.t_Phone1.Size = New System.Drawing.Size(210, 20)
        Me.t_Phone1.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(29, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Line 1"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(45, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(450, 2)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Label8"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(45, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(450, 2)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightGray
        Me.Label10.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(45, 321)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 2)
        Me.Label10.TabIndex = 148
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.LightGray
        Me.Label13.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(45, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(450, 2)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Label13"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightGray
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(45, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 2)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_OrganisationType
        '
        Me.t_OrganisationType.BackColor = System.Drawing.SystemColors.Window
        Me.t_OrganisationType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_OrganisationType.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_OrganisationType.Location = New System.Drawing.Point(45, 239)
        Me.t_OrganisationType.Name = "t_OrganisationType"
        Me.t_OrganisationType.Size = New System.Drawing.Size(210, 20)
        Me.t_OrganisationType.TabIndex = 158
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 19)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Organization Type"
        '
        'chkHQs
        '
        Me.chkHQs.AutoSize = True
        Me.chkHQs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkHQs.Location = New System.Drawing.Point(447, 83)
        Me.chkHQs.Name = "chkHQs"
        Me.chkHQs.Size = New System.Drawing.Size(45, 22)
        Me.chkHQs.TabIndex = 161
        Me.chkHQs.Text = "HQ"
        Me.chkHQs.UseVisualStyleBackColor = True
        '
        'Company_Ctrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.chkHQs)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.t_OrganisationType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.t_Phone1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.t_Email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.t_Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.modifyAvatar)
        Me.Controls.Add(Me.usrAvatar)
        Me.Controls.Add(Me.t_Company)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Company_Ctrl"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Company / Branch Details"
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t_Company As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents usrAvatar As PictureBox
    Friend WithEvents modifyAvatar As Label
    Friend WithEvents t_Address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents t_Email As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents t_Phone1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents t_OrganisationType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkHQs As CheckBox
End Class
