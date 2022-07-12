<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clients
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.l_RecordCount = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Label()
        Me.t_ClientId = New MetroFramework.Controls.MetroTextBox()
        Me.dg_List = New MetroFramework.Controls.MetroGrid()
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
        Me.l_RecordCount.Location = New System.Drawing.Point(23, 449)
        Me.l_RecordCount.Name = "l_RecordCount"
        Me.l_RecordCount.Size = New System.Drawing.Size(107, 22)
        Me.l_RecordCount.TabIndex = 153
        Me.l_RecordCount.Text = "[] Records Found"
        Me.l_RecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l_RecordCount.UseCompatibleTextRendering = True
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
        Me.btnAddNew.TabIndex = 155
        Me.btnAddNew.Text = "ADD NEW [F2]"
        Me.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddNew.UseCompatibleTextRendering = True
        '
        't_ClientId
        '
        '
        '
        '
        Me.t_ClientId.CustomButton.Image = Nothing
        Me.t_ClientId.CustomButton.Location = New System.Drawing.Point(289, 1)
        Me.t_ClientId.CustomButton.Name = ""
        Me.t_ClientId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.t_ClientId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.t_ClientId.CustomButton.TabIndex = 1
        Me.t_ClientId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_ClientId.CustomButton.UseSelectable = True
        Me.t_ClientId.CustomButton.Visible = False
        Me.t_ClientId.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.t_ClientId.Lines = New String(-1) {}
        Me.t_ClientId.Location = New System.Drawing.Point(171, 26)
        Me.t_ClientId.MaxLength = 128
        Me.t_ClientId.Name = "t_ClientId"
        Me.t_ClientId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.t_ClientId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.t_ClientId.SelectedText = ""
        Me.t_ClientId.SelectionLength = 0
        Me.t_ClientId.SelectionStart = 0
        Me.t_ClientId.ShowClearButton = True
        Me.t_ClientId.Size = New System.Drawing.Size(311, 23)
        Me.t_ClientId.Style = MetroFramework.MetroColorStyle.Teal
        Me.t_ClientId.TabIndex = 71
        Me.t_ClientId.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_ClientId.UseSelectable = True
        Me.t_ClientId.UseStyleColors = True
        Me.t_ClientId.WaterMark = "-enter client name to search-"
        Me.t_ClientId.WaterMarkColor = System.Drawing.Color.Teal
        Me.t_ClientId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_List.DefaultCellStyle = DataGridViewCellStyle17
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg_List.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg_List.Location = New System.Drawing.Point(19, 61)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dg_List.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dg_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_List.Size = New System.Drawing.Size(762, 378)
        Me.dg_List.TabIndex = 156
        '
        'Clients
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.l_RecordCount)
        Me.Controls.Add(Me.t_ClientId)
        Me.Controls.Add(Me.btnAddNew)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clients"
        Me.Padding = New System.Windows.Forms.Padding(19, 61, 19, 41)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Merchants"
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents l_RecordCount As Label
    Friend WithEvents btnAddNew As Label
    Friend WithEvents t_ClientId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dg_List As MetroFramework.Controls.MetroGrid
End Class
