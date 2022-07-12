<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockStatus
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
        Me.headerTxt = New System.Windows.Forms.Label()
        Me.hdrPanel = New System.Windows.Forms.Panel()
        Me.btnBalance = New System.Windows.Forms.Button()
        Me.chkOutNegative = New System.Windows.Forms.CheckBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.hdrPanel.SuspendLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.headerTxt)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 49
        '
        'headerTxt
        '
        Me.headerTxt.Dock = System.Windows.Forms.DockStyle.Right
        Me.headerTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.headerTxt.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.headerTxt.ForeColor = System.Drawing.Color.White
        Me.headerTxt.Location = New System.Drawing.Point(12, 0)
        Me.headerTxt.Name = "headerTxt"
        Me.headerTxt.Size = New System.Drawing.Size(772, 42)
        Me.headerTxt.TabIndex = 53
        Me.headerTxt.Text = "Set Opening Stock"
        Me.headerTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'hdrPanel
        '
        Me.hdrPanel.Controls.Add(Me.btnBalance)
        Me.hdrPanel.Controls.Add(Me.chkOutNegative)
        Me.hdrPanel.Controls.Add(Me.btnNew)
        Me.hdrPanel.Controls.Add(Me.btnSave)
        Me.hdrPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.hdrPanel.Location = New System.Drawing.Point(0, 42)
        Me.hdrPanel.Name = "hdrPanel"
        Me.hdrPanel.Size = New System.Drawing.Size(784, 51)
        Me.hdrPanel.TabIndex = 55
        '
        'btnBalance
        '
        Me.btnBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBalance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBalance.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnBalance.FlatAppearance.BorderSize = 2
        Me.btnBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBalance.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnBalance.ForeColor = System.Drawing.Color.Black
        Me.btnBalance.Location = New System.Drawing.Point(425, 10)
        Me.btnBalance.Name = "btnBalance"
        Me.btnBalance.Size = New System.Drawing.Size(131, 30)
        Me.btnBalance.TabIndex = 4
        Me.btnBalance.Text = "Balance Out [F2]"
        Me.btnBalance.UseCompatibleTextRendering = True
        Me.btnBalance.UseVisualStyleBackColor = False
        Me.btnBalance.Visible = False
        '
        'chkOutNegative
        '
        Me.chkOutNegative.AutoSize = True
        Me.chkOutNegative.BackColor = System.Drawing.Color.Transparent
        Me.chkOutNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOutNegative.Font = New System.Drawing.Font("Corbel", 11.5!)
        Me.chkOutNegative.ForeColor = System.Drawing.Color.Black
        Me.chkOutNegative.Location = New System.Drawing.Point(12, 14)
        Me.chkOutNegative.Name = "chkOutNegative"
        Me.chkOutNegative.Size = New System.Drawing.Size(152, 23)
        Me.chkOutNegative.TabIndex = 3
        Me.chkOutNegative.Text = "balance less figures"
        Me.chkOutNegative.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.BackColor = System.Drawing.Color.LightGray
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNew.FlatAppearance.BorderSize = 2
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(583, 10)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(107, 30)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "Reload [F5]"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(697, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 30)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save [F1]"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
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
        Me.dg_List.Location = New System.Drawing.Point(0, 93)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.RowHeadersWidth = 45
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_List.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_List.Size = New System.Drawing.Size(784, 348)
        Me.dg_List.TabIndex = 71
        '
        'StockStatus
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.hdrPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "StockStatus"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.hdrPanel.ResumeLayout(False)
        Me.hdrPanel.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents headerTxt As Label
    Friend WithEvents hdrPanel As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents dg_List As DataGridView
    Friend WithEvents btnNew As Button
    Friend WithEvents chkOutNegative As CheckBox
    Friend WithEvents btnBalance As Button
End Class
