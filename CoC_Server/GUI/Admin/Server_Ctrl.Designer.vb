<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _server
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.l_CompanyDetails = New System.Windows.Forms.ToolStripStatusLabel()
        Me.usrAvatar = New System.Windows.Forms.PictureBox()
        Me.TheTime = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_App = New System.Windows.Forms.Label()
        Me.l_usr = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DodgerBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripSplitButton1, Me.l_CompanyDetails})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 419)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(784, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(98, 17)
        Me.ToolStripStatusLabel1.Text = "Cy Technologies"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = Global.CoC_Server.My.Resources.Resources.home_user_icon
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'l_CompanyDetails
        '
        Me.l_CompanyDetails.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.l_CompanyDetails.ForeColor = System.Drawing.Color.White
        Me.l_CompanyDetails.Name = "l_CompanyDetails"
        Me.l_CompanyDetails.Size = New System.Drawing.Size(106, 17)
        Me.l_CompanyDetails.Text = "Company Details"
        '
        'usrAvatar
        '
        Me.usrAvatar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usrAvatar.Location = New System.Drawing.Point(661, 253)
        Me.usrAvatar.Name = "usrAvatar"
        Me.usrAvatar.Size = New System.Drawing.Size(120, 120)
        Me.usrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.usrAvatar.TabIndex = 4
        Me.usrAvatar.TabStop = False
        '
        'TheTime
        '
        Me.TheTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TheTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TheTime.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.TheTime.ForeColor = System.Drawing.Color.Black
        Me.TheTime.Location = New System.Drawing.Point(538, 71)
        Me.TheTime.Name = "TheTime"
        Me.TheTime.Size = New System.Drawing.Size(240, 30)
        Me.TheTime.TabIndex = 3
        Me.TheTime.Text = "05/12/17; 20:43"
        Me.TheTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(636, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Panel"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.l_App)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 377)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 42)
        Me.Panel3.TabIndex = 3
        '
        'l_App
        '
        Me.l_App.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_App.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_App.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_App.ForeColor = System.Drawing.Color.Blue
        Me.l_App.Location = New System.Drawing.Point(186, 6)
        Me.l_App.Name = "l_App"
        Me.l_App.Size = New System.Drawing.Size(592, 30)
        Me.l_App.TabIndex = 0
        Me.l_App.Text = "App details"
        Me.l_App.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l_usr
        '
        Me.l_usr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_usr.BackColor = System.Drawing.Color.LightGray
        Me.l_usr.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_usr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_usr.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_usr.ForeColor = System.Drawing.Color.Blue
        Me.l_usr.Location = New System.Drawing.Point(476, 48)
        Me.l_usr.Name = "l_usr"
        Me.l_usr.Size = New System.Drawing.Size(248, 18)
        Me.l_usr.TabIndex = 44
        Me.l_usr.Text = "signed in as"
        Me.l_usr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.AutoSize = True
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(730, 48)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(48, 18)
        Me.btnLogout.TabIndex = 43
        Me.btnLogout.Text = "logout"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(7, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 326)
        Me.Panel1.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "List Menu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_server
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.l_usr)
        Me.Controls.Add(Me.TheTime)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.usrAvatar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.MaximizeBox = False
        Me.Name = "_server"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Server Settings"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents l_App As Label
    Friend WithEvents TheTime As Label
    Friend WithEvents usrAvatar As PictureBox
    Friend WithEvents l_usr As Label
    Friend WithEvents btnLogout As Label
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents l_CompanyDetails As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
