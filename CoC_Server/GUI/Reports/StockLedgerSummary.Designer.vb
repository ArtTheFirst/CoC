<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockLedgerSummary
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
        Me.headerText = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModifyDate = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Label()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.headerText)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(784, 42)
        Me.Panel2.TabIndex = 16
        '
        'headerText
        '
        Me.headerText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headerText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.headerText.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.headerText.ForeColor = System.Drawing.Color.White
        Me.headerText.Location = New System.Drawing.Point(0, 0)
        Me.headerText.Name = "headerText"
        Me.headerText.Size = New System.Drawing.Size(784, 42)
        Me.headerText.TabIndex = 0
        Me.headerText.Text = "Stock Ledger - Summary"
        Me.headerText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.headerText.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnModifyDate)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 414)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 27)
        Me.Panel1.TabIndex = 17
        '
        'btnModifyDate
        '
        Me.btnModifyDate.BackColor = System.Drawing.Color.Teal
        Me.btnModifyDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifyDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyDate.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnModifyDate.ForeColor = System.Drawing.Color.White
        Me.btnModifyDate.Location = New System.Drawing.Point(162, 0)
        Me.btnModifyDate.Name = "btnModifyDate"
        Me.btnModifyDate.Size = New System.Drawing.Size(150, 21)
        Me.btnModifyDate.TabIndex = 4
        Me.btnModifyDate.Text = "Modify Date [F4]"
        Me.btnModifyDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModifyDate.UseCompatibleTextRendering = True
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Teal
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Light", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(36, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(120, 21)
        Me.btnPrint.TabIndex = 3
        Me.btnPrint.Text = "Print [F10]"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.UseCompatibleTextRendering = True
        '
        'dg_List
        '
        Me.dg_List.AllowUserToAddRows = False
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.Color.Silver
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
        Me.dg_List.Location = New System.Drawing.Point(0, 42)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.RowHeadersWidth = 45
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_List.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_List.Size = New System.Drawing.Size(784, 372)
        Me.dg_List.TabIndex = 71
        '
        'StockLedgerSummary
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
        Me.Name = "StockLedgerSummary"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents headerText As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnModifyDate As Label
    Friend WithEvents btnPrint As Label
    Friend WithEvents dg_List As DataGridView
End Class
