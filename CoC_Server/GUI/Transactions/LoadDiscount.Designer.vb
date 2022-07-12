<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadDiscount
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.t_DscAmt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 42)
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(111, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apply Discount"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Teal
        Me.Label18.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(27, 123)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(240, 2)
        Me.Label18.TabIndex = 221
        Me.Label18.Text = "Label18"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_DscAmt
        '
        Me.t_DscAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t_DscAmt.BackColor = System.Drawing.Color.Gainsboro
        Me.t_DscAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_DscAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.t_DscAmt.Font = New System.Drawing.Font("Consolas", 14.0!)
        Me.t_DscAmt.Location = New System.Drawing.Point(27, 98)
        Me.t_DscAmt.MaxLength = 3
        Me.t_DscAmt.Name = "t_DscAmt"
        Me.t_DscAmt.Size = New System.Drawing.Size(240, 22)
        Me.t_DscAmt.TabIndex = 220
        Me.t_DscAmt.Text = "0"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Gainsboro
        Me.Label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label19.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 73)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 19)
        Me.Label19.TabIndex = 219
        Me.Label19.Text = "Enter Discount [%]"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 222
        Me.Label2.Text = "Final Amount"
        '
        'l_Total
        '
        Me.l_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_Total.AutoSize = True
        Me.l_Total.BackColor = System.Drawing.Color.Transparent
        Me.l_Total.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Consolas", 34.0!)
        Me.l_Total.ForeColor = System.Drawing.Color.Black
        Me.l_Total.Location = New System.Drawing.Point(26, 174)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(123, 54)
        Me.l_Total.TabIndex = 223
        Me.l_Total.Tag = "0.00"
        Me.l_Total.Text = "0.00"
        Me.l_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LoadDiscount
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.l_Total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.t_DscAmt)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadDiscount"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CyPOS"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents t_DscAmt As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents l_Total As Label
End Class
