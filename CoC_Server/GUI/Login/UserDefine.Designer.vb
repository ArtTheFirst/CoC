<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDefine
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
        Me.t_Name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_Key1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_Key2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rdSubAdmin = New System.Windows.Forms.RadioButton()
        Me.rdCashier = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.l_Status = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(264, 42)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login; Define Account"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Black
        Me.Label16.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(28, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(210, 1)
        Me.Label16.TabIndex = 156
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Name
        '
        Me.t_Name.BackColor = System.Drawing.Color.Silver
        Me.t_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Name.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.t_Name.Location = New System.Drawing.Point(29, 36)
        Me.t_Name.Name = "t_Name"
        Me.t_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_Name.ReadOnly = True
        Me.t_Name.Size = New System.Drawing.Size(210, 18)
        Me.t_Name.TabIndex = 155
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(14, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 18)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Account Name"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(28, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 1)
        Me.Label2.TabIndex = 159
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Key1
        '
        Me.t_Key1.BackColor = System.Drawing.Color.Silver
        Me.t_Key1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Key1.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.t_Key1.Location = New System.Drawing.Point(29, 102)
        Me.t_Key1.MaxLength = 24
        Me.t_Key1.Name = "t_Key1"
        Me.t_Key1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_Key1.Size = New System.Drawing.Size(210, 18)
        Me.t_Key1.TabIndex = 158
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(14, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(28, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 1)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Key2
        '
        Me.t_Key2.BackColor = System.Drawing.Color.Silver
        Me.t_Key2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Key2.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.t_Key2.Location = New System.Drawing.Point(29, 168)
        Me.t_Key2.MaxLength = 24
        Me.t_Key2.Name = "t_Key2"
        Me.t_Key2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.t_Key2.Size = New System.Drawing.Size(210, 18)
        Me.t_Key2.TabIndex = 161
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(14, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 18)
        Me.Label5.TabIndex = 160
        Me.Label5.Text = "Re-Enter Password"
        '
        'rdSubAdmin
        '
        Me.rdSubAdmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdSubAdmin.BackColor = System.Drawing.Color.LightGray
        Me.rdSubAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdSubAdmin.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.rdSubAdmin.Location = New System.Drawing.Point(18, 286)
        Me.rdSubAdmin.Name = "rdSubAdmin"
        Me.rdSubAdmin.Size = New System.Drawing.Size(220, 20)
        Me.rdSubAdmin.TabIndex = 163
        Me.rdSubAdmin.TabStop = True
        Me.rdSubAdmin.Text = "Sub Admin Account"
        Me.rdSubAdmin.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdSubAdmin.UseVisualStyleBackColor = False
        '
        'rdCashier
        '
        Me.rdCashier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rdCashier.BackColor = System.Drawing.Color.DarkGray
        Me.rdCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdCashier.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.rdCashier.Location = New System.Drawing.Point(18, 318)
        Me.rdCashier.Name = "rdCashier"
        Me.rdCashier.Size = New System.Drawing.Size(220, 20)
        Me.rdCashier.TabIndex = 164
        Me.rdCashier.TabStop = True
        Me.rdCashier.Text = "Cashier Account"
        Me.rdCashier.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rdCashier.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.l_Status)
        Me.Panel1.Controls.Add(Me.t_Key1)
        Me.Panel1.Controls.Add(Me.rdCashier)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.rdSubAdmin)
        Me.Panel1.Controls.Add(Me.t_Name)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.t_Key2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(6, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(250, 353)
        Me.Panel1.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DimGray
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 21)
        Me.Label6.TabIndex = 167
        Me.Label6.Text = "Choose account type"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'l_Status
        '
        Me.l_Status.AutoSize = True
        Me.l_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Status.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.l_Status.ForeColor = System.Drawing.Color.Red
        Me.l_Status.Location = New System.Drawing.Point(98, 80)
        Me.l_Status.Name = "l_Status"
        Me.l_Status.Size = New System.Drawing.Size(114, 14)
        Me.l_Status.TabIndex = 165
        Me.l_Status.Text = "match status/strength"
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.Green
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGo.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Location = New System.Drawing.Point(7, 47)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(250, 21)
        Me.btnGo.TabIndex = 166
        Me.btnGo.Text = "Create Account"
        Me.btnGo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'UserDefine
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(264, 441)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserDefine"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserDefine"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents t_Name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t_Key1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents t_Key2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rdSubAdmin As RadioButton
    Friend WithEvents rdCashier As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents l_Status As Label
    Friend WithEvents btnGo As Label
    Friend WithEvents Label6 As Label
End Class
