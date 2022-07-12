<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Clients
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
        Me.HEADER = New System.Windows.Forms.Label()
        Me.t_ClientId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.l_RecordCount = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Label()
        Me.pnl_Side = New System.Windows.Forms.Panel()
        Me.dg_Sales = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.pnl_Side.SuspendLayout()
        CType(Me.dg_Sales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.HEADER)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 12
        '
        'HEADER
        '
        Me.HEADER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HEADER.AutoSize = True
        Me.HEADER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HEADER.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.HEADER.ForeColor = System.Drawing.Color.White
        Me.HEADER.Location = New System.Drawing.Point(651, 5)
        Me.HEADER.Name = "HEADER"
        Me.HEADER.Size = New System.Drawing.Size(127, 32)
        Me.HEADER.TabIndex = 0
        Me.HEADER.Text = "Merchants"
        '
        't_ClientId
        '
        Me.t_ClientId.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_ClientId.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_ClientId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_ClientId.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.t_ClientId.Location = New System.Drawing.Point(292, 42)
        Me.t_ClientId.MaxLength = 128
        Me.t_ClientId.Name = "t_ClientId"
        Me.t_ClientId.Size = New System.Drawing.Size(480, 23)
        Me.t_ClientId.TabIndex = 147
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(292, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(480, 2)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Label9"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(278, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 19)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Search Client Name"
        '
        'l_RecordCount
        '
        Me.l_RecordCount.AutoSize = True
        Me.l_RecordCount.BackColor = System.Drawing.Color.Transparent
        Me.l_RecordCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RecordCount.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.l_RecordCount.ForeColor = System.Drawing.Color.Red
        Me.l_RecordCount.Location = New System.Drawing.Point(462, 3)
        Me.l_RecordCount.Name = "l_RecordCount"
        Me.l_RecordCount.Size = New System.Drawing.Size(120, 19)
        Me.l_RecordCount.TabIndex = 153
        Me.l_RecordCount.Text = "[] Records Found"
        Me.l_RecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNew.BackColor = System.Drawing.Color.Teal
        Me.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNew.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddNew.ForeColor = System.Drawing.Color.White
        Me.btnAddNew.Location = New System.Drawing.Point(661, 3)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(120, 21)
        Me.btnAddNew.TabIndex = 155
        Me.btnAddNew.Text = "ADD NEW [F2]"
        Me.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Side
        '
        Me.pnl_Side.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Side.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.pnl_Side.Controls.Add(Me.l_RecordCount)
        Me.pnl_Side.Controls.Add(Me.t_ClientId)
        Me.pnl_Side.Controls.Add(Me.btnAddNew)
        Me.pnl_Side.Controls.Add(Me.Label9)
        Me.pnl_Side.Controls.Add(Me.Label8)
        Me.pnl_Side.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Side.Location = New System.Drawing.Point(0, 42)
        Me.pnl_Side.Name = "pnl_Side"
        Me.pnl_Side.Size = New System.Drawing.Size(784, 72)
        Me.pnl_Side.TabIndex = 17
        '
        'dg_Sales
        '
        Me.dg_Sales.AllowUserToResizeColumns = False
        Me.dg_Sales.AllowUserToResizeRows = False
        Me.dg_Sales.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg_Sales.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_Sales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_Sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_Sales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_Sales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_Sales.EnableHeadersVisualStyles = False
        Me.dg_Sales.Location = New System.Drawing.Point(0, 114)
        Me.dg_Sales.Name = "dg_Sales"
        Me.dg_Sales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_Sales.RowHeadersVisible = False
        Me.dg_Sales.RowHeadersWidth = 45
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_Sales.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_Sales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_Sales.Size = New System.Drawing.Size(784, 447)
        Me.dg_Sales.TabIndex = 70
        '
        'Clients
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.dg_Sales)
        Me.Controls.Add(Me.pnl_Side)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Clients"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl_Side.ResumeLayout(False)
        Me.pnl_Side.PerformLayout()
        CType(Me.dg_Sales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents HEADER As Label
    Friend WithEvents t_ClientId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents l_RecordCount As Label
    Friend WithEvents btnAddNew As Label
    Friend WithEvents pnl_Side As Panel
    Friend WithEvents dg_Sales As DataGridView
End Class
