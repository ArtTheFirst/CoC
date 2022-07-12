<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingsCtrl
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_Server = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.l_Server = New System.Windows.Forms.Label()
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
        Me.Panel2.Size = New System.Drawing.Size(284, 42)
        Me.Panel2.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set Server Ip"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkGray
        Me.Label4.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(22, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 2)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Server
        '
        Me.t_Server.BackColor = System.Drawing.Color.Silver
        Me.t_Server.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Server.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Server.Location = New System.Drawing.Point(23, 101)
        Me.t_Server.Name = "t_Server"
        Me.t_Server.Size = New System.Drawing.Size(250, 20)
        Me.t_Server.TabIndex = 143
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 18)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "Enter Server Ip Address"
        '
        'l_Server
        '
        Me.l_Server.AutoSize = True
        Me.l_Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Server.ForeColor = System.Drawing.Color.Blue
        Me.l_Server.Location = New System.Drawing.Point(12, 57)
        Me.l_Server.Name = "l_Server"
        Me.l_Server.Size = New System.Drawing.Size(81, 13)
        Me.l_Server.TabIndex = 145
        Me.l_Server.Text = "Server address:"
        '
        'SettingsCtrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(284, 171)
        Me.Controls.Add(Me.l_Server)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.t_Server)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsCtrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SettingsCtrl"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents t_Server As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents l_Server As Label
End Class
