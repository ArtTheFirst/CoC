﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BarcodeSearch
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
        Me.pnl_Container = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_Code = New System.Windows.Forms.TextBox()
        Me.dg_List = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.pnl_Container.SuspendLayout()
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
        Me.Panel2.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(608, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode Search"
        '
        'pnl_Container
        '
        Me.pnl_Container.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Container.Controls.Add(Me.Label3)
        Me.pnl_Container.Controls.Add(Me.t_Code)
        Me.pnl_Container.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_Container.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.pnl_Container.Location = New System.Drawing.Point(0, 42)
        Me.pnl_Container.Name = "pnl_Container"
        Me.pnl_Container.Size = New System.Drawing.Size(784, 51)
        Me.pnl_Container.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(292, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 2)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_Code
        '
        Me.t_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_Code.BackColor = System.Drawing.Color.WhiteSmoke
        Me.t_Code.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Code.Font = New System.Drawing.Font("Corbel", 14.0!)
        Me.t_Code.Location = New System.Drawing.Point(292, 13)
        Me.t_Code.MaxLength = 128
        Me.t_Code.Name = "t_Code"
        Me.t_Code.Size = New System.Drawing.Size(480, 23)
        Me.t_Code.TabIndex = 160
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
        Me.dg_List.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dg_List.Size = New System.Drawing.Size(784, 468)
        Me.dg_List.TabIndex = 69
        '
        'BarcodeSearch
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.dg_List)
        Me.Controls.Add(Me.pnl_Container)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BarcodeSearch"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnl_Container.ResumeLayout(False)
        Me.pnl_Container.PerformLayout()
        CType(Me.dg_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnl_Container As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents t_Code As TextBox
    Friend WithEvents dg_List As DataGridView
End Class
