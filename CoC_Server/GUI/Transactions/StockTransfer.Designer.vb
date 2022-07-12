<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StockTransfer
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_InvoiceDate = New System.Windows.Forms.Label()
        Me.l_Qty = New System.Windows.Forms.Label()
        Me.l_Amt = New System.Windows.Forms.Label()
        Me.l_TransferFrom = New System.Windows.Forms.Label()
        Me.l_TransferTo = New System.Windows.Forms.Label()
        Me.l_sessionid = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.l_Outstanding = New System.Windows.Forms.Label()
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
        Me.Panel2.Controls.Add(Me.l_InvoiceDate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(824, 42)
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(662, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Transfer"
        '
        'l_InvoiceDate
        '
        Me.l_InvoiceDate.AutoSize = True
        Me.l_InvoiceDate.BackColor = System.Drawing.Color.Transparent
        Me.l_InvoiceDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_InvoiceDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_InvoiceDate.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_InvoiceDate.ForeColor = System.Drawing.Color.White
        Me.l_InvoiceDate.Location = New System.Drawing.Point(12, 9)
        Me.l_InvoiceDate.Name = "l_InvoiceDate"
        Me.l_InvoiceDate.Size = New System.Drawing.Size(94, 25)
        Me.l_InvoiceDate.TabIndex = 168
        Me.l_InvoiceDate.Text = "Invoice Date"
        Me.l_InvoiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.l_InvoiceDate.UseCompatibleTextRendering = True
        '
        'l_Qty
        '
        Me.l_Qty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.l_Qty.AutoSize = True
        Me.l_Qty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Qty.Font = New System.Drawing.Font("Consolas", 21.0!)
        Me.l_Qty.Location = New System.Drawing.Point(10, 17)
        Me.l_Qty.Name = "l_Qty"
        Me.l_Qty.Size = New System.Drawing.Size(26, 40)
        Me.l_Qty.TabIndex = 162
        Me.l_Qty.Text = "0"
        Me.l_Qty.UseCompatibleTextRendering = True
        '
        'l_Amt
        '
        Me.l_Amt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Amt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Amt.Font = New System.Drawing.Font("Consolas", 31.0!)
        Me.l_Amt.Location = New System.Drawing.Point(208, 8)
        Me.l_Amt.Name = "l_Amt"
        Me.l_Amt.Size = New System.Drawing.Size(609, 59)
        Me.l_Amt.TabIndex = 164
        Me.l_Amt.Text = "0.00"
        Me.l_Amt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_Amt.UseCompatibleTextRendering = True
        '
        'l_TransferFrom
        '
        Me.l_TransferFrom.BackColor = System.Drawing.Color.Transparent
        Me.l_TransferFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_TransferFrom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.l_TransferFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TransferFrom.Font = New System.Drawing.Font("Corbel", 12.37!, System.Drawing.FontStyle.Bold)
        Me.l_TransferFrom.Location = New System.Drawing.Point(0, 275)
        Me.l_TransferFrom.Name = "l_TransferFrom"
        Me.l_TransferFrom.Size = New System.Drawing.Size(824, 31)
        Me.l_TransferFrom.TabIndex = 165
        Me.l_TransferFrom.Tag = "Transfer From: "
        Me.l_TransferFrom.Text = "Transfer From: "
        Me.l_TransferFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_TransferFrom.UseCompatibleTextRendering = True
        '
        'l_TransferTo
        '
        Me.l_TransferTo.BackColor = System.Drawing.Color.Silver
        Me.l_TransferTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_TransferTo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.l_TransferTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TransferTo.Font = New System.Drawing.Font("Corbel", 12.37!, System.Drawing.FontStyle.Bold)
        Me.l_TransferTo.Location = New System.Drawing.Point(0, 306)
        Me.l_TransferTo.Name = "l_TransferTo"
        Me.l_TransferTo.Size = New System.Drawing.Size(824, 31)
        Me.l_TransferTo.TabIndex = 166
        Me.l_TransferTo.Tag = "Transfer To: "
        Me.l_TransferTo.Text = "Transfer To: "
        Me.l_TransferTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_TransferTo.UseCompatibleTextRendering = True
        '
        'l_sessionid
        '
        Me.l_sessionid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_sessionid.BackColor = System.Drawing.Color.Transparent
        Me.l_sessionid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_sessionid.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_sessionid.ForeColor = System.Drawing.Color.DarkGreen
        Me.l_sessionid.Location = New System.Drawing.Point(488, 6)
        Me.l_sessionid.Name = "l_sessionid"
        Me.l_sessionid.Size = New System.Drawing.Size(329, 24)
        Me.l_sessionid.TabIndex = 169
        Me.l_sessionid.Text = "session id"
        Me.l_sessionid.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.l_sessionid.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.l_sessionid)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 37)
        Me.Panel1.TabIndex = 175
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.LightGray
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnNew.FlatAppearance.BorderSize = 2
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(8, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(107, 30)
        Me.btnNew.TabIndex = 175
        Me.btnNew.Text = "Clear [F5]"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightGray
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(122, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 30)
        Me.btnSave.TabIndex = 174
        Me.btnSave.Text = "Save [F1]"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.l_Amt)
        Me.Panel3.Controls.Add(Me.l_Qty)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 366)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(824, 75)
        Me.Panel3.TabIndex = 176
        '
        'l_Outstanding
        '
        Me.l_Outstanding.BackColor = System.Drawing.Color.Silver
        Me.l_Outstanding.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.l_Outstanding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Outstanding.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.l_Outstanding.ForeColor = System.Drawing.Color.Black
        Me.l_Outstanding.Location = New System.Drawing.Point(0, 337)
        Me.l_Outstanding.Name = "l_Outstanding"
        Me.l_Outstanding.Size = New System.Drawing.Size(824, 29)
        Me.l_Outstanding.TabIndex = 177
        Me.l_Outstanding.Tag = "[outstanding balance] {outstanding balance}"
        Me.l_Outstanding.Text = "[outstanding balance] {outstanding balance}"
        Me.l_Outstanding.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.l_Outstanding.UseCompatibleTextRendering = True
        '
        'dg_List
        '
        Me.dg_List.AllowUserToResizeColumns = False
        Me.dg_List.AllowUserToResizeRows = False
        Me.dg_List.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dg_List.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Corbel", 11.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_List.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dg_List.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_List.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dg_List.EnableHeadersVisualStyles = False
        Me.dg_List.Location = New System.Drawing.Point(0, 79)
        Me.dg_List.Name = "dg_List"
        Me.dg_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dg_List.RowHeadersVisible = False
        Me.dg_List.RowHeadersWidth = 45
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dg_List.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_List.Size = New System.Drawing.Size(824, 196)
        Me.dg_List.TabIndex = 180
        '
        'StockTransfer
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(824, 441)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.l_TransferFrom)
        Me.Controls.Add(Me.l_TransferTo)
        Me.Controls.Add(Me.l_Outstanding)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "StockTransfer"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents l_InvoiceDate As Label
    Friend WithEvents l_Qty As Label
    Friend WithEvents l_Amt As Label
    Friend WithEvents l_TransferFrom As Label
    Friend WithEvents l_TransferTo As Label
    Friend WithEvents l_sessionid As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents l_Outstanding As Label
    Friend WithEvents dg_List As DataGridView
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
End Class
