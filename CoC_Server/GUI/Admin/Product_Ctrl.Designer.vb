<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product_Ctrl
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Label()
        Me.l_outOfStock = New System.Windows.Forms.Label()
        Me.l_TotalSales = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnXFltr = New System.Windows.Forms.Label()
        Me.pnl_Filter = New System.Windows.Forms.Panel()
        Me.l_goingOutOfStock = New System.Windows.Forms.Label()
        Me.l_TotalDst = New System.Windows.Forms.Label()
        Me.l_TotalSCat = New System.Windows.Forms.Label()
        Me.l_TotalPCat = New System.Windows.Forms.Label()
        Me.c_Distributors = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c_CategorySales = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c_Category = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnClearAll = New System.Windows.Forms.Label()
        Me.btnLoadAll = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.l_SearchFilter = New System.Windows.Forms.Label()
        Me.lv_Products = New System.Windows.Forms.ListView()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnl_Filter.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Panel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(675, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Products"
        '
        'l_Total
        '
        Me.l_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Total.BackColor = System.Drawing.Color.DarkGray
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.l_Total.ForeColor = System.Drawing.Color.Black
        Me.l_Total.Location = New System.Drawing.Point(305, 1)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(210, 24)
        Me.l_Total.TabIndex = 2
        Me.l_Total.Text = "total products []"
        Me.l_Total.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.btnRefresh)
        Me.Panel3.Controls.Add(Me.l_outOfStock)
        Me.Panel3.Controls.Add(Me.l_TotalSales)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 33)
        Me.Panel3.TabIndex = 12
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnRefresh.Location = New System.Drawing.Point(492, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(49, 17)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_outOfStock
        '
        Me.l_outOfStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_outOfStock.BackColor = System.Drawing.Color.Gainsboro
        Me.l_outOfStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_outOfStock.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.l_outOfStock.ForeColor = System.Drawing.Color.Red
        Me.l_outOfStock.Location = New System.Drawing.Point(547, 7)
        Me.l_outOfStock.Name = "l_outOfStock"
        Me.l_outOfStock.Size = New System.Drawing.Size(207, 18)
        Me.l_outOfStock.TabIndex = 4
        Me.l_outOfStock.Text = "[] items out of stock!"
        Me.l_outOfStock.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_TotalSales
        '
        Me.l_TotalSales.AutoSize = True
        Me.l_TotalSales.BackColor = System.Drawing.Color.Transparent
        Me.l_TotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalSales.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_TotalSales.ForeColor = System.Drawing.Color.Blue
        Me.l_TotalSales.Location = New System.Drawing.Point(10, 7)
        Me.l_TotalSales.Name = "l_TotalSales"
        Me.l_TotalSales.Size = New System.Drawing.Size(244, 18)
        Me.l_TotalSales.TabIndex = 3
        Me.l_TotalSales.Text = "Total Value On All Products; Sales; Cost"
        Me.l_TotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.btnXFltr)
        Me.Panel1.Controls.Add(Me.pnl_Filter)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(514, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 366)
        Me.Panel1.TabIndex = 13
        '
        'btnXFltr
        '
        Me.btnXFltr.BackColor = System.Drawing.Color.DarkGray
        Me.btnXFltr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXFltr.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnXFltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXFltr.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnXFltr.ForeColor = System.Drawing.Color.Blue
        Me.btnXFltr.Location = New System.Drawing.Point(0, 330)
        Me.btnXFltr.Name = "btnXFltr"
        Me.btnXFltr.Size = New System.Drawing.Size(270, 24)
        Me.btnXFltr.TabIndex = 4
        Me.btnXFltr.Text = "Extend Filter >>"
        Me.btnXFltr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Filter
        '
        Me.pnl_Filter.Controls.Add(Me.l_goingOutOfStock)
        Me.pnl_Filter.Controls.Add(Me.l_TotalDst)
        Me.pnl_Filter.Controls.Add(Me.l_TotalSCat)
        Me.pnl_Filter.Controls.Add(Me.l_TotalPCat)
        Me.pnl_Filter.Controls.Add(Me.c_Distributors)
        Me.pnl_Filter.Controls.Add(Me.Label7)
        Me.pnl_Filter.Controls.Add(Me.c_CategorySales)
        Me.pnl_Filter.Controls.Add(Me.Label6)
        Me.pnl_Filter.Controls.Add(Me.c_Category)
        Me.pnl_Filter.Controls.Add(Me.Label5)
        Me.pnl_Filter.Controls.Add(Me.btnClearAll)
        Me.pnl_Filter.Controls.Add(Me.btnLoadAll)
        Me.pnl_Filter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Filter.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Filter.Name = "pnl_Filter"
        Me.pnl_Filter.Size = New System.Drawing.Size(270, 330)
        Me.pnl_Filter.TabIndex = 0
        '
        'l_goingOutOfStock
        '
        Me.l_goingOutOfStock.BackColor = System.Drawing.Color.Silver
        Me.l_goingOutOfStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_goingOutOfStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_goingOutOfStock.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.l_goingOutOfStock.ForeColor = System.Drawing.Color.Red
        Me.l_goingOutOfStock.Location = New System.Drawing.Point(33, 0)
        Me.l_goingOutOfStock.Name = "l_goingOutOfStock"
        Me.l_goingOutOfStock.Size = New System.Drawing.Size(207, 18)
        Me.l_goingOutOfStock.TabIndex = 19
        Me.l_goingOutOfStock.Text = "[] items going out of stock!"
        Me.l_goingOutOfStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_TotalDst
        '
        Me.l_TotalDst.AutoSize = True
        Me.l_TotalDst.BackColor = System.Drawing.Color.Transparent
        Me.l_TotalDst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalDst.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.l_TotalDst.ForeColor = System.Drawing.Color.Blue
        Me.l_TotalDst.Location = New System.Drawing.Point(37, 304)
        Me.l_TotalDst.Name = "l_TotalDst"
        Me.l_TotalDst.Size = New System.Drawing.Size(74, 14)
        Me.l_TotalDst.TabIndex = 18
        Me.l_TotalDst.Text = "total products"
        Me.l_TotalDst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_TotalSCat
        '
        Me.l_TotalSCat.AutoSize = True
        Me.l_TotalSCat.BackColor = System.Drawing.Color.Transparent
        Me.l_TotalSCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalSCat.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.l_TotalSCat.ForeColor = System.Drawing.Color.Blue
        Me.l_TotalSCat.Location = New System.Drawing.Point(37, 230)
        Me.l_TotalSCat.Name = "l_TotalSCat"
        Me.l_TotalSCat.Size = New System.Drawing.Size(74, 14)
        Me.l_TotalSCat.TabIndex = 17
        Me.l_TotalSCat.Text = "total products"
        Me.l_TotalSCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'l_TotalPCat
        '
        Me.l_TotalPCat.AutoSize = True
        Me.l_TotalPCat.BackColor = System.Drawing.Color.Transparent
        Me.l_TotalPCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_TotalPCat.Font = New System.Drawing.Font("Corbel", 9.0!)
        Me.l_TotalPCat.ForeColor = System.Drawing.Color.Blue
        Me.l_TotalPCat.Location = New System.Drawing.Point(37, 157)
        Me.l_TotalPCat.Name = "l_TotalPCat"
        Me.l_TotalPCat.Size = New System.Drawing.Size(74, 14)
        Me.l_TotalPCat.TabIndex = 16
        Me.l_TotalPCat.Text = "total products"
        Me.l_TotalPCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'c_Distributors
        '
        Me.c_Distributors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c_Distributors.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.c_Distributors.FormattingEnabled = True
        Me.c_Distributors.Location = New System.Drawing.Point(36, 276)
        Me.c_Distributors.Name = "c_Distributors"
        Me.c_Distributors.Size = New System.Drawing.Size(206, 25)
        Me.c_Distributors.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(32, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Distributor"
        '
        'c_CategorySales
        '
        Me.c_CategorySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c_CategorySales.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.c_CategorySales.FormattingEnabled = True
        Me.c_CategorySales.Location = New System.Drawing.Point(36, 202)
        Me.c_CategorySales.Name = "c_CategorySales"
        Me.c_CategorySales.Size = New System.Drawing.Size(206, 25)
        Me.c_CategorySales.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(32, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Sales Category"
        '
        'c_Category
        '
        Me.c_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c_Category.Font = New System.Drawing.Font("Corbel", 10.5!)
        Me.c_Category.FormattingEnabled = True
        Me.c_Category.Location = New System.Drawing.Point(36, 126)
        Me.c_Category.Name = "c_Category"
        Me.c_Category.Size = New System.Drawing.Size(206, 25)
        Me.c_Category.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(32, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Product Category"
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.Red
        Me.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAll.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.btnClearAll.ForeColor = System.Drawing.Color.White
        Me.btnClearAll.Location = New System.Drawing.Point(62, 61)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(142, 20)
        Me.btnClearAll.TabIndex = 3
        Me.btnClearAll.Text = "Clear Records"
        Me.btnClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLoadAll
        '
        Me.btnLoadAll.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnLoadAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadAll.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.btnLoadAll.ForeColor = System.Drawing.Color.White
        Me.btnLoadAll.Location = New System.Drawing.Point(62, 37)
        Me.btnLoadAll.Name = "btnLoadAll"
        Me.btnLoadAll.Size = New System.Drawing.Size(142, 20)
        Me.btnLoadAll.TabIndex = 2
        Me.btnLoadAll.Text = "Load All Products"
        Me.btnLoadAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.l_SearchFilter)
        Me.Panel5.Controls.Add(Me.l_Total)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 75)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(514, 39)
        Me.Panel5.TabIndex = 14
        '
        'l_SearchFilter
        '
        Me.l_SearchFilter.AutoSize = True
        Me.l_SearchFilter.BackColor = System.Drawing.Color.Transparent
        Me.l_SearchFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SearchFilter.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.l_SearchFilter.ForeColor = System.Drawing.Color.Blue
        Me.l_SearchFilter.Location = New System.Drawing.Point(9, 8)
        Me.l_SearchFilter.Name = "l_SearchFilter"
        Me.l_SearchFilter.Size = New System.Drawing.Size(134, 18)
        Me.l_SearchFilter.TabIndex = 4
        Me.l_SearchFilter.Text = "Applied Search Filter"
        Me.l_SearchFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lv_Products
        '
        Me.lv_Products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv_Products.FullRowSelect = True
        Me.lv_Products.GridLines = True
        Me.lv_Products.Location = New System.Drawing.Point(0, 114)
        Me.lv_Products.Name = "lv_Products"
        Me.lv_Products.Size = New System.Drawing.Size(514, 327)
        Me.lv_Products.TabIndex = 15
        Me.lv_Products.UseCompatibleStateImageBehavior = False
        Me.lv_Products.View = System.Windows.Forms.View.Details
        '
        'Product_Ctrl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.lv_Products)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MinimizeBox = False
        Me.Name = "Product_Ctrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product_Ctrl"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnl_Filter.ResumeLayout(False)
        Me.pnl_Filter.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnl_Filter As Panel
    Friend WithEvents btnClearAll As Label
    Friend WithEvents btnLoadAll As Label
    Friend WithEvents btnXFltr As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents c_Category As ComboBox
    Friend WithEvents c_CategorySales As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents c_Distributors As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents l_TotalSales As Label
    Friend WithEvents l_TotalPCat As Label
    Friend WithEvents l_TotalDst As Label
    Friend WithEvents l_TotalSCat As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents l_SearchFilter As Label
    Friend WithEvents l_outOfStock As Label
    Friend WithEvents l_goingOutOfStock As Label
    Private WithEvents l_Total As Label
    Friend WithEvents lv_Products As ListView
    Friend WithEvents btnRefresh As Label
End Class
