<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class popout_Box
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.popout_Text = New System.Windows.Forms.Label()
        Me.popout_btnCancel = New System.Windows.Forms.Label()
        Me.popout_btnOK = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.popout_btnOK)
        Me.Panel1.Controls.Add(Me.popout_btnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(11, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 41)
        Me.Panel1.TabIndex = 1
        '
        'popout_Text
        '
        Me.popout_Text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.popout_Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.popout_Text.Location = New System.Drawing.Point(11, 61)
        Me.popout_Text.Name = "popout_Text"
        Me.popout_Text.Size = New System.Drawing.Size(278, 55)
        Me.popout_Text.TabIndex = 2
        Me.popout_Text.Text = "Label1"
        '
        'popout_btnCancel
        '
        Me.popout_btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.popout_btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.popout_btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.popout_btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.popout_btnCancel.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.popout_btnCancel.ForeColor = System.Drawing.Color.White
        Me.popout_btnCancel.Location = New System.Drawing.Point(158, 9)
        Me.popout_btnCancel.Name = "popout_btnCancel"
        Me.popout_btnCancel.Size = New System.Drawing.Size(117, 23)
        Me.popout_btnCancel.TabIndex = 218
        Me.popout_btnCancel.Tag = ""
        Me.popout_btnCancel.Text = "[F9] Cancel"
        Me.popout_btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.popout_btnCancel.UseCompatibleTextRendering = True
        '
        'popout_btnOK
        '
        Me.popout_btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.popout_btnOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.popout_btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.popout_btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.popout_btnOK.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.popout_btnOK.ForeColor = System.Drawing.Color.White
        Me.popout_btnOK.Location = New System.Drawing.Point(35, 9)
        Me.popout_btnOK.Name = "popout_btnOK"
        Me.popout_btnOK.Size = New System.Drawing.Size(117, 23)
        Me.popout_btnOK.TabIndex = 219
        Me.popout_btnOK.Tag = ""
        Me.popout_btnOK.Text = "[F1] OK"
        Me.popout_btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.popout_btnOK.UseCompatibleTextRendering = True
        '
        'popout_Box
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(300, 180)
        Me.Controls.Add(Me.popout_Text)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "popout_Box"
        Me.Padding = New System.Windows.Forms.Padding(11, 61, 11, 23)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "[popout_dialog]"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents popout_Text As Label
    Friend WithEvents popout_btnCancel As Label
    Friend WithEvents popout_btnOK As Label
End Class
