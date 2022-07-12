<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceFinder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSelectDate = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Label()
        Me.dg_List = New MetroFramework.Controls.MetroGrid()
        Me.t_InvCode = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectDate
        '
        Me.btnSelectDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSelectDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelectDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectDate.Font = New System.Drawing.Font("Segoe UI Light", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnSelectDate.ForeColor = System.Drawing.Color.White
        Me.btnSelectDate.Location = New System.Drawing.Point(505, 22)
        Me.btnSelectDate.Name = "btnSelectDate"
        Me.btnSelectDate.Size = New System.Drawing.Size(137, 28)
        Me.btnSelectDate.TabIndex = 3
        Me.btnSelectDate.Text = "SELECT DATE [F4]"
        Me.btnSelectDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSelectDate.UseCompatibleTextRendering = True
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Segoe UI Light", 10.5!, System.Drawing.FontStyle.Bold)
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(648, 22)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(111, 28)
        Me.btnProceed.TabIndex = 2
        Me.btnProceed.Text = "PROCEED [F2]"
        Me.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnProceed.UseCompatibleTextRendering = True
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_List.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dg_List.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg_List.Location = New System.Drawing.Point(13, 61)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.ReadOnly = True
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
        Me.dg_List.Size = New System.Drawing.Size(774, 378)
        Me.dg_List.TabIndex = 152
        '
        't_InvCode
        '
        '
        '
        '
        Me.t_InvCode.CustomButton.Image = Nothing
        Me.t_InvCode.CustomButton.Location = New System.Drawing.Point(247, 1)
        Me.t_InvCode.CustomButton.Name = ""
        Me.t_InvCode.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.t_InvCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.t_InvCode.CustomButton.TabIndex = 1
        Me.t_InvCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_InvCode.CustomButton.UseSelectable = True
        Me.t_InvCode.CustomButton.Visible = False
        Me.t_InvCode.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.t_InvCode.Lines = New String(-1) {}
        Me.t_InvCode.Location = New System.Drawing.Point(184, 26)
        Me.t_InvCode.MaxLength = 128
        Me.t_InvCode.Name = "t_InvCode"
        Me.t_InvCode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.t_InvCode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.t_InvCode.SelectedText = ""
        Me.t_InvCode.SelectionLength = 0
        Me.t_InvCode.SelectionStart = 0
        Me.t_InvCode.ShowClearButton = True
        Me.t_InvCode.Size = New System.Drawing.Size(269, 23)
        Me.t_InvCode.Style = MetroFramework.MetroColorStyle.Blue
        Me.t_InvCode.TabIndex = 153
        Me.t_InvCode.Theme = MetroFramework.MetroThemeStyle.Light
        Me.t_InvCode.UseSelectable = True
        Me.t_InvCode.UseStyleColors = True
        Me.t_InvCode.WaterMark = "-enter invoice code to search-"
        Me.t_InvCode.WaterMarkColor = System.Drawing.Color.Teal
        Me.t_InvCode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        '
        'InvoiceFinder
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.t_InvCode)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.btnSelectDate)
        Me.Controls.Add(Me.btnProceed)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InvoiceFinder"
        Me.Padding = New System.Windows.Forms.Padding(13, 61, 13, 41)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Find Invoice"
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProceed As Label
    Friend WithEvents btnSelectDate As Label
    Friend WithEvents dg_List As MetroFramework.Controls.MetroGrid
    Friend WithEvents t_InvCode As MetroFramework.Controls.MetroTextBox
End Class
