<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Users
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
        Me.dg_Sales = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
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
        Me.Panel2.Size = New System.Drawing.Size(284, 42)
        Me.Panel2.TabIndex = 13
        '
        'HEADER
        '
        Me.HEADER.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HEADER.AutoSize = True
        Me.HEADER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HEADER.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.HEADER.ForeColor = System.Drawing.Color.White
        Me.HEADER.Location = New System.Drawing.Point(206, 5)
        Me.HEADER.Name = "HEADER"
        Me.HEADER.Size = New System.Drawing.Size(72, 32)
        Me.HEADER.TabIndex = 0
        Me.HEADER.Text = "Users"
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
        Me.dg_Sales.Location = New System.Drawing.Point(0, 42)
        Me.dg_Sales.Name = "dg_Sales"
        Me.dg_Sales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_Sales.RowHeadersVisible = False
        Me.dg_Sales.RowHeadersWidth = 45
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_Sales.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_Sales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_Sales.Size = New System.Drawing.Size(284, 219)
        Me.dg_Sales.TabIndex = 71
        '
        'Users
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.dg_Sales)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Users"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg_Sales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents HEADER As Label
    Friend WithEvents dg_Sales As DataGridView
End Class
