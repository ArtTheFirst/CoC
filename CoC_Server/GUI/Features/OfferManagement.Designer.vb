<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OfferManagement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtp_StartDate = New MetroFramework.Controls.MetroDateTime()
        Me.dtp_EndDate = New MetroFramework.Controls.MetroDateTime()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.l_PriceReal = New System.Windows.Forms.Label()
        Me.l_PriceAfter = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t_Discount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_Qty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.t_Name = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 42)
        Me.Panel2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(589, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Offer Management "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.dtp_StartDate)
        Me.Panel1.Controls.Add(Me.dtp_EndDate)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.l_PriceReal)
        Me.Panel1.Controls.Add(Me.l_PriceAfter)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.t_Discount)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.t_Qty)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.t_Name)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(524, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 399)
        Me.Panel1.TabIndex = 14
        '
        'dtp_StartDate
        '
        Me.dtp_StartDate.Location = New System.Drawing.Point(26, 259)
        Me.dtp_StartDate.MinDate = New Date(2020, 4, 19, 0, 0, 0, 0)
        Me.dtp_StartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_StartDate.Name = "dtp_StartDate"
        Me.dtp_StartDate.Size = New System.Drawing.Size(262, 29)
        Me.dtp_StartDate.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtp_StartDate.TabIndex = 178
        Me.dtp_StartDate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dtp_StartDate.UseCustomBackColor = True
        Me.dtp_StartDate.UseCustomForeColor = True
        Me.dtp_StartDate.UseStyleColors = True
        '
        'dtp_EndDate
        '
        Me.dtp_EndDate.Location = New System.Drawing.Point(26, 328)
        Me.dtp_EndDate.MinDate = New Date(2020, 4, 19, 0, 0, 0, 0)
        Me.dtp_EndDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_EndDate.Name = "dtp_EndDate"
        Me.dtp_EndDate.Size = New System.Drawing.Size(262, 29)
        Me.dtp_EndDate.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtp_EndDate.TabIndex = 177
        Me.dtp_EndDate.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dtp_EndDate.UseCustomBackColor = True
        Me.dtp_EndDate.UseCustomForeColor = True
        Me.dtp_EndDate.UseStyleColors = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(175, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(120, 21)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "SAVE [F1]"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.UseCompatibleTextRendering = True
        '
        'l_PriceReal
        '
        Me.l_PriceReal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_PriceReal.BackColor = System.Drawing.Color.Transparent
        Me.l_PriceReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_PriceReal.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.l_PriceReal.Location = New System.Drawing.Point(108, 102)
        Me.l_PriceReal.Name = "l_PriceReal"
        Me.l_PriceReal.Size = New System.Drawing.Size(180, 21)
        Me.l_PriceReal.TabIndex = 176
        Me.l_PriceReal.Tag = "[Price]"
        Me.l_PriceReal.Text = "[Price]"
        Me.l_PriceReal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'l_PriceAfter
        '
        Me.l_PriceAfter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_PriceAfter.BackColor = System.Drawing.Color.Transparent
        Me.l_PriceAfter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_PriceAfter.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.l_PriceAfter.Location = New System.Drawing.Point(112, 190)
        Me.l_PriceAfter.Name = "l_PriceAfter"
        Me.l_PriceAfter.Size = New System.Drawing.Size(176, 21)
        Me.l_PriceAfter.TabIndex = 175
        Me.l_PriceAfter.Tag = "[Price After]"
        Me.l_PriceAfter.Text = "[Price After]"
        Me.l_PriceAfter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(12, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 21)
        Me.Label7.TabIndex = 172
        Me.Label7.Text = "End Date"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(12, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Start Date"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 21)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Discount (%)"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 2)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Label5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Discount
        '
        Me.t_Discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_Discount.BackColor = System.Drawing.Color.Silver
        Me.t_Discount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Discount.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_Discount.Location = New System.Drawing.Point(26, 188)
        Me.t_Discount.MaxLength = 3
        Me.t_Discount.Name = "t_Discount"
        Me.t_Discount.Size = New System.Drawing.Size(72, 22)
        Me.t_Discount.TabIndex = 168
        Me.t_Discount.Text = "0"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Enter Qty"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(26, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 2)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Qty
        '
        Me.t_Qty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_Qty.BackColor = System.Drawing.Color.Silver
        Me.t_Qty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Qty.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_Qty.Location = New System.Drawing.Point(26, 126)
        Me.t_Qty.MaxLength = 6
        Me.t_Qty.Name = "t_Qty"
        Me.t_Qty.Size = New System.Drawing.Size(72, 22)
        Me.t_Qty.TabIndex = 165
        Me.t_Qty.Text = "1"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(12, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 21)
        Me.Label8.TabIndex = 161
        Me.Label8.Text = "Enter Item Name"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(26, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 2)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Name
        '
        Me.t_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_Name.BackColor = System.Drawing.Color.Silver
        Me.t_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Name.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Name.Location = New System.Drawing.Point(26, 69)
        Me.t_Name.MaxLength = 128
        Me.t_Name.Name = "t_Name"
        Me.t_Name.ReadOnly = True
        Me.t_Name.Size = New System.Drawing.Size(262, 20)
        Me.t_Name.TabIndex = 162
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.l_Total)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(524, 36)
        Me.Panel3.TabIndex = 15
        '
        'l_Total
        '
        Me.l_Total.AutoSize = True
        Me.l_Total.BackColor = System.Drawing.Color.Transparent
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.l_Total.Location = New System.Drawing.Point(12, 8)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(207, 21)
        Me.l_Total.TabIndex = 162
        Me.l_Total.Text = "[Total Items] / [Total Discount]"
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Location = New System.Drawing.Point(0, 78)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.RowHeadersWidth = 45
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_List.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_List.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dg_List.Size = New System.Drawing.Size(524, 363)
        Me.dg_List.TabIndex = 70
        '
        'OfferManagement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OfferManagement"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents t_Name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents t_Qty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents t_Discount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents l_Total As Label
    Friend WithEvents l_PriceReal As Label
    Friend WithEvents l_PriceAfter As Label
    Friend WithEvents btnSave As Label
    Friend WithEvents dg_List As DataGridView
    Friend WithEvents dtp_StartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtp_EndDate As MetroFramework.Controls.MetroDateTime
End Class
