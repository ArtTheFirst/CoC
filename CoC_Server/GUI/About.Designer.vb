<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class About
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
        Me.header = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.InfoText = New System.Windows.Forms.Label()
        Me.CompanyText = New System.Windows.Forms.Label()
        Me.avatar = New System.Windows.Forms.PictureBox()
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.AutoSize = True
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.header.Font = New System.Drawing.Font("Corbel", 47.0!, System.Drawing.FontStyle.Bold)
        Me.header.ForeColor = System.Drawing.Color.Teal
        Me.header.Location = New System.Drawing.Point(35, 48)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(582, 77)
        Me.header.TabIndex = 0
        Me.header.Tag = "Cy POS (Server) "
        Me.header.Text = "Cy POS (Server) 3.02"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Version.Font = New System.Drawing.Font("Corbel", 36.0!)
        Me.Version.ForeColor = System.Drawing.Color.DarkCyan
        Me.Version.Location = New System.Drawing.Point(81, 159)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(104, 59)
        Me.Version.TabIndex = 1
        Me.Version.Text = "V. []"
        '
        'InfoText
        '
        Me.InfoText.BackColor = System.Drawing.Color.Transparent
        Me.InfoText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InfoText.Font = New System.Drawing.Font("Corbel", 21.0!)
        Me.InfoText.ForeColor = System.Drawing.Color.Teal
        Me.InfoText.Location = New System.Drawing.Point(105, 222)
        Me.InfoText.Name = "InfoText"
        Me.InfoText.Size = New System.Drawing.Size(274, 83)
        Me.InfoText.TabIndex = 2
        Me.InfoText.Text = "Retail Point Of TXN Software"
        '
        'CompanyText
        '
        Me.CompanyText.AutoSize = True
        Me.CompanyText.BackColor = System.Drawing.Color.Transparent
        Me.CompanyText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CompanyText.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold)
        Me.CompanyText.ForeColor = System.Drawing.Color.Teal
        Me.CompanyText.Location = New System.Drawing.Point(43, 383)
        Me.CompanyText.Name = "CompanyText"
        Me.CompanyText.Size = New System.Drawing.Size(167, 27)
        Me.CompanyText.TabIndex = 3
        Me.CompanyText.Text = "Cy Tech Systems"
        '
        'avatar
        '
        Me.avatar.Image = Global.CoC_Server.My.Resources.Resources.logo_kindof
        Me.avatar.Location = New System.Drawing.Point(405, 143)
        Me.avatar.Name = "avatar"
        Me.avatar.Size = New System.Drawing.Size(343, 321)
        Me.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.avatar.TabIndex = 4
        Me.avatar.TabStop = False
        '
        'About
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(798, 478)
        Me.Controls.Add(Me.avatar)
        Me.Controls.Add(Me.CompanyText)
        Me.Controls.Add(Me.InfoText)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.header)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = " "
        CType(Me.avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As Label
    Friend WithEvents Version As Label
    Friend WithEvents InfoText As Label
    Friend WithEvents CompanyText As Label
    Friend WithEvents avatar As PictureBox
End Class
