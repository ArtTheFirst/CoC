<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Countries
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.l_RecordCount = New System.Windows.Forms.Label()
        Me.dg_List = New MetroFramework.Controls.MetroGrid()
        Me.t_CountryId = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddNew = New System.Windows.Forms.Label()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'l_RecordCount
        '
        Me.l_RecordCount.AutoSize = True
        Me.l_RecordCount.BackColor = System.Drawing.Color.Transparent
        Me.l_RecordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RecordCount.Font = New System.Drawing.Font("Corbel", 10.3!, System.Drawing.FontStyle.Bold)
        Me.l_RecordCount.ForeColor = System.Drawing.Color.Red
        Me.l_RecordCount.Location = New System.Drawing.Point(23, 454)
        Me.l_RecordCount.Name = "l_RecordCount"
        Me.l_RecordCount.Size = New System.Drawing.Size(107, 22)
        Me.l_RecordCount.TabIndex = 154
        Me.l_RecordCount.Text = "[] Records Found"
        Me.l_RecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l_RecordCount.UseCompatibleTextRendering = True
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_List.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg_List.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg_List.Location = New System.Drawing.Point(11, 61)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_List.Size = New System.Drawing.Size(778, 396)
        Me.dg_List.TabIndex = 158
        '
        't_CountryId
        '
        '
        '
        '
        Me.t_CountryId.CustomButton.Image = Nothing
        Me.t_CountryId.CustomButton.Location = New System.Drawing.Point(289, 1)
        Me.t_CountryId.CustomButton.Name = ""
        Me.t_CountryId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.t_CountryId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.t_CountryId.CustomButton.TabIndex = 1
        Me.t_CountryId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_CountryId.CustomButton.UseSelectable = True
        Me.t_CountryId.CustomButton.Visible = False
        Me.t_CountryId.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.t_CountryId.Lines = New String(-1) {}
        Me.t_CountryId.Location = New System.Drawing.Point(169, 27)
        Me.t_CountryId.MaxLength = 128
        Me.t_CountryId.Name = "t_CountryId"
        Me.t_CountryId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.t_CountryId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.t_CountryId.SelectedText = ""
        Me.t_CountryId.SelectionLength = 0
        Me.t_CountryId.SelectionStart = 0
        Me.t_CountryId.ShowClearButton = True
        Me.t_CountryId.Size = New System.Drawing.Size(311, 23)
        Me.t_CountryId.Style = MetroFramework.MetroColorStyle.Teal
        Me.t_CountryId.TabIndex = 159
        Me.t_CountryId.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_CountryId.UseSelectable = True
        Me.t_CountryId.UseStyleColors = True
        Me.t_CountryId.WaterMark = "-enter country name to search-"
        Me.t_CountryId.WaterMarkColor = System.Drawing.Color.Teal
        Me.t_CountryId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.Teal
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Corbel", 10.4!, System.Drawing.FontStyle.Bold)
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(532, 27)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(120, 23)
        Me.btnAddNew.TabIndex = 160
        Me.btnAddNew.Text = "ADD NEW [F2]"
        Me.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddNew.UseCompatibleTextRendering = True
        '
        'Countries
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.t_CountryId)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.l_RecordCount)
        Me.KeyPreview = True
        Me.Name = "Countries"
        Me.Padding = New System.Windows.Forms.Padding(11, 61, 11, 23)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Countries"
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents l_RecordCount As Label
    Friend WithEvents dg_List As MetroFramework.Controls.MetroGrid
    Friend WithEvents t_CountryId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAddNew As Label
End Class
