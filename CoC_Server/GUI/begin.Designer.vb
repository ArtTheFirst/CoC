<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class begin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(begin))
        Me.begin_strip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.begin_strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'begin_strip
        '
        Me.begin_strip.BackColor = System.Drawing.Color.LightGray
        Me.begin_strip.Font = New System.Drawing.Font("Segoe UI", 9.25!)
        Me.begin_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TransactToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.begin_strip.Location = New System.Drawing.Point(0, 0)
        Me.begin_strip.Name = "begin_strip"
        Me.begin_strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.begin_strip.Size = New System.Drawing.Size(824, 25)
        Me.begin_strip.TabIndex = 0
        Me.begin_strip.Text = " "
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(53, 21)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'TransactToolStripMenuItem
        '
        Me.TransactToolStripMenuItem.Name = "TransactToolStripMenuItem"
        Me.TransactToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.TransactToolStripMenuItem.Text = "Transact"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'begin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.begin_strip)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.begin_strip
        Me.Name = "begin"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.begin_strip.ResumeLayout(False)
        Me.begin_strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents begin_strip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
