<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Currency_Ctrl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_Unit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New MetroFramework.Controls.MetroLabel()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.t_Unit)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.t_Name)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(11, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 120)
        Me.Panel1.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DarkGray
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(18, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 2)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Unit
        '
        Me.t_Unit.BackColor = System.Drawing.SystemColors.Window
        Me.t_Unit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Unit.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.t_Unit.Location = New System.Drawing.Point(18, 91)
        Me.t_Unit.Name = "t_Unit"
        Me.t_Unit.Size = New System.Drawing.Size(240, 21)
        Me.t_Unit.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(5, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 19)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Unit"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(18, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(240, 2)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Name
        '
        Me.t_Name.BackColor = System.Drawing.SystemColors.Window
        Me.t_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Name.Font = New System.Drawing.Font("Corbel", 12.5!)
        Me.t_Name.Location = New System.Drawing.Point(18, 34)
        Me.t_Name.Name = "t_Name"
        Me.t_Name.Size = New System.Drawing.Size(240, 21)
        Me.t_Name.TabIndex = 150
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Name"
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_List.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column1, Me.Column2})
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.Location = New System.Drawing.Point(11, 181)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.Size = New System.Drawing.Size(262, 117)
        Me.dg_List.TabIndex = 16
        '
        'Column3
        '
        Me.Column3.HeaderText = "ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Unit Code"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Unit Name"
        Me.Column2.MaxInputLength = 16
        Me.Column2.Name = "Column2"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.FontSize = MetroFramework.MetroLabelSize.Small
        Me.btnSave.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.btnSave.ForeColor = System.Drawing.Color.Green
        Me.btnSave.Location = New System.Drawing.Point(6, 301)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(272, 15)
        Me.btnSave.TabIndex = 155
        Me.btnSave.Text = "[F1] to save new values [Enter]x2 to update values"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseCustomForeColor = True
        '
        'Currency_Ctrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(284, 321)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Currency_Ctrl"
        Me.Padding = New System.Windows.Forms.Padding(11, 61, 11, 23)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Currency"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents t_Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dg_List As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents t_Unit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As MetroFramework.Controls.MetroLabel
End Class
