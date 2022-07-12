<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompanyList
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.l_RecordCount = New System.Windows.Forms.Label()
        Me.t_Company = New MetroFramework.Controls.MetroTextBox()
        Me.dg_List = New MetroFramework.Controls.MetroGrid()
        Me.btnAddNew = New System.Windows.Forms.Label()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l_RecordCount
        '
        Me.l_RecordCount.AutoSize = True
        Me.l_RecordCount.BackColor = System.Drawing.SystemColors.Window
        Me.l_RecordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RecordCount.Font = New System.Drawing.Font("Corbel", 10.3!, System.Drawing.FontStyle.Bold)
        Me.l_RecordCount.ForeColor = System.Drawing.Color.Red
        Me.l_RecordCount.Location = New System.Drawing.Point(23, 449)
        Me.l_RecordCount.Name = "l_RecordCount"
        Me.l_RecordCount.Size = New System.Drawing.Size(107, 22)
        Me.l_RecordCount.TabIndex = 154
        Me.l_RecordCount.Text = "[] Records Found"
        Me.l_RecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.l_RecordCount.UseCompatibleTextRendering = True
        '
        't_Company
        '
        '
        '
        '
        Me.t_Company.CustomButton.Image = Nothing
        Me.t_Company.CustomButton.Location = New System.Drawing.Point(289, 1)
        Me.t_Company.CustomButton.Name = ""
        Me.t_Company.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.t_Company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.t_Company.CustomButton.TabIndex = 1
        Me.t_Company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_Company.CustomButton.UseSelectable = True
        Me.t_Company.CustomButton.Visible = False
        Me.t_Company.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.t_Company.Lines = New String(-1) {}
        Me.t_Company.Location = New System.Drawing.Point(171, 26)
        Me.t_Company.MaxLength = 128
        Me.t_Company.Name = "t_Company"
        Me.t_Company.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.t_Company.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.t_Company.SelectedText = ""
        Me.t_Company.SelectionLength = 0
        Me.t_Company.SelectionStart = 0
        Me.t_Company.ShowClearButton = True
        Me.t_Company.Size = New System.Drawing.Size(311, 23)
        Me.t_Company.Style = MetroFramework.MetroColorStyle.Teal
        Me.t_Company.TabIndex = 156
        Me.t_Company.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_Company.UseSelectable = True
        Me.t_Company.UseStyleColors = True
        Me.t_Company.WaterMark = "-enter company name to search-"
        Me.t_Company.WaterMarkColor = System.Drawing.Color.Teal
        Me.t_Company.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_List.DefaultCellStyle = DataGridViewCellStyle8
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg_List.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg_List.Location = New System.Drawing.Point(19, 61)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dg_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_List.Size = New System.Drawing.Size(762, 376)
        Me.dg_List.TabIndex = 157
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.Teal
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Corbel", 10.4!, System.Drawing.FontStyle.Bold)
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(534, 26)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(120, 23)
        Me.btnAddNew.TabIndex = 158
        Me.btnAddNew.Text = "ADD NEW [F2]"
        Me.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddNew.UseCompatibleTextRendering = True
        '
        'CompanyList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.t_Company)
        Me.Controls.Add(Me.l_RecordCount)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CompanyList"
        Me.Padding = New System.Windows.Forms.Padding(19, 61, 19, 43)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Find Branch"
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l_RecordCount As Label
    Friend WithEvents t_Company As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dg_List As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnAddNew As Label
End Class
