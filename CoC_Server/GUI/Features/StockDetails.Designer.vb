<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockDetails
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l_RecordsToUpload = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Label()
        Me.btnBeginUpload = New System.Windows.Forms.Label()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(630, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Details"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.l_RecordsToUpload)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnBeginUpload)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 411)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 30)
        Me.Panel1.TabIndex = 17
        '
        'l_RecordsToUpload
        '
        Me.l_RecordsToUpload.AutoSize = True
        Me.l_RecordsToUpload.Location = New System.Drawing.Point(6, 6)
        Me.l_RecordsToUpload.Name = "l_RecordsToUpload"
        Me.l_RecordsToUpload.Size = New System.Drawing.Size(138, 18)
        Me.l_RecordsToUpload.TabIndex = 170
        Me.l_RecordsToUpload.Text = "[] record(s) to upload"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.AutoSize = True
        Me.btnClear.BackColor = System.Drawing.Color.DarkGray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.Red
        Me.btnClear.Location = New System.Drawing.Point(357, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 19)
        Me.btnClear.TabIndex = 169
        Me.btnClear.Text = "CLEAR [F9]"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.BackColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Location = New System.Drawing.Point(455, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(104, 19)
        Me.btnRefresh.TabIndex = 168
        Me.btnRefresh.Text = "REFRESH [F5]"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBeginUpload
        '
        Me.btnBeginUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBeginUpload.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBeginUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeginUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeginUpload.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBeginUpload.ForeColor = System.Drawing.Color.White
        Me.btnBeginUpload.Location = New System.Drawing.Point(569, 4)
        Me.btnBeginUpload.Name = "btnBeginUpload"
        Me.btnBeginUpload.Size = New System.Drawing.Size(210, 21)
        Me.btnBeginUpload.TabIndex = 167
        Me.btnBeginUpload.Text = "UPLOAD [F1]"
        Me.btnBeginUpload.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToOrderColumns = True
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Location = New System.Drawing.Point(0, 42)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.RowHeadersWidth = 45
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_List.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_List.Size = New System.Drawing.Size(784, 369)
        Me.dg_List.TabIndex = 69
        '
        'StockDetails
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "StockDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBeginUpload As Label
    Friend WithEvents btnRefresh As Label
    Friend WithEvents btnClear As Label
    Friend WithEvents l_RecordsToUpload As Label
    Friend WithEvents dg_List As DataGridView
End Class
