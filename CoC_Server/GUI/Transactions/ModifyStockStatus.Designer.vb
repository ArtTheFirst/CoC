<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModifyStockStatus
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.btnLoadAll = New System.Windows.Forms.Label()
        Me.dg_OOSL = New System.Windows.Forms.DataGridView()
        Me.hcProdName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hdrClQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_OOSL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(565, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modify Stock Status"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.l_Total)
        Me.Panel1.Controls.Add(Me.btnLoadAll)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 27)
        Me.Panel1.TabIndex = 8
        '
        'l_Total
        '
        Me.l_Total.AutoSize = True
        Me.l_Total.Location = New System.Drawing.Point(13, 6)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(197, 18)
        Me.l_Total.TabIndex = 4
        Me.l_Total.Text = "[] products in total out of stock"
        '
        'btnLoadAll
        '
        Me.btnLoadAll.BackColor = System.Drawing.Color.Green
        Me.btnLoadAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadAll.FlatStyle = S
        Me.t_Address.Location = New System.Drawing.Point(24, 203)
        Me.t_Address.MaxLength = 128
        Me.t_Address.Name = "t_Address"
        Me.t_Address.Size = New System.Drawing.Size(420, 20)
        Me.t_Address.TabIndex = 258
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Gray
        Me.Label13.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(501, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(270, 2)
        Me.Label13.TabIndex = 268
        Me.Label13.Text = "Label13"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label15.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(489, 219)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 19)
        Me.Label15.TabIndex = 266
        Me.Label15.Text = "Fax"
        '
        't_Fax
        '
        Me.t_Fax.BackColor = System.Drawing.Color.Silver
        Me.t_Fax.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Fax.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Fax.Location = New System.Drawing.Point(502, 241)
        Me.t_Fax.MaxLength = 128
        Me.t_Fax.Name = "t_Fax"
        Me.t_Fax.Size = New System.Drawing.Size(270, 20)
        Me.t_Fax.TabIndex = 267
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Gray
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(501, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 2)
        Me.Label1.TabIndex = 265
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(489, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "Phone"
        '
        't_Phone2
        '
        Me.t_Phone2.BackColor = System.Drawing.Color.Silver
        Me.t_Phone2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Phone2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Phone2.Location = New System.Drawing.Point(502, 181)
        Me.t_Phone2.MaxLength = 128
        Me.t_Phone2.Name = "t_Phone2"
        Me.t_Phone2.Size = New System.Drawing.Size(270, 20)
        Me.t_Phone2.TabIndex = 264
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(501, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(270, 2)
        Me.Label7.TabIndex = 262
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label8.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(489, 104)
        Me.