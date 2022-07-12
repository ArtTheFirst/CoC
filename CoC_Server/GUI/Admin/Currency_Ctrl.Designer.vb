<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Currency_Ctrl
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c_Currency = New System.Windows.Forms.ComboBox()
        Me.t_Unit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(171, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Currency"
        '
        'c_Currency
        '
        Me.c_Currency.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.c_Currency.FormattingEnabled = True
        Me.c_Currency.Location = New System.Drawing.Point(32, 76)
        Me.c_Currency.Name = "c_Currency"
        Me.c_Currency.Size = New System.Drawing.Size(240, 26)
        Me.c_Currency.TabIndex = 44
        '
        't_Unit
        '
        Me.t_Unit.BackColor = System.Drawing.Color.Silver
        Me.t_Unit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Unit.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.t_Unit.Location = New System.Drawing.Point(32, 134)
        Me.t_Unit.Name = "t_Unit"
        Me.t_Unit.Size = New System.Drawing.Size(240, 21)
        Me.t_Unit.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Currency Unit"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Currency"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.AutoSize = True
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.btnDelete.ForeColor = System.Drawing.Color.Blue
        Me.btnDelete.Location = New System.Drawing.Point(228, 44)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(52, 19)
        Me.btnDelete.TabIndex = 46
        Me.btnDelete.Text = "delete"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.AutoSize = True
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.btnCreate.ForeColor = System.Drawing.Color.Blue
        Me.btnCreate.Location = New System.Drawing.Point(186, 44)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(38, 19)
        Me.btnCreate.TabIndex = 45
        Me.btnCreate.Text = "save"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(32, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 1)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Currency_Ctrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(284, 171)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.c_Currency)
        Me.Controls.Add(Me.t_Unit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Currency_Ctrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency_Ctrl"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents c_Currency As ComboBox
    Friend WithEvents t_Unit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As Label
    Friend WithEvents btnCreate As Label
    Friend WithEvents Label9 As Label
End Class
