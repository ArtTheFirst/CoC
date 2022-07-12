<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _checker
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
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblBarCode = New System.Windows.Forms.Label()
        Me.txtReceivedData = New System.Windows.Forms.TextBox()
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblProductName
        '
        Me.lblProductName.BackColor = System.Drawing.Color.Silver
        Me.lblProductName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductName.Font = New System.Drawing.Font("Segoe UI", 32.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductName.Location = New System.Drawing.Point(0, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(704, 64)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "PRODUCT NAME"
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBarCode
        '
        Me.lblBarCode.BackColor = System.Drawing.Color.Silver
        Me.lblBarCode.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBarCode.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblBarCode.Location = New System.Drawing.Point(0, 377)
        Me.lblBarCode.Name = "lblBarCode"
        Me.lblBarCode.Size = New System.Drawing.Size(704, 64)
        Me.lblBarCode.TabIndex = 5
        Me.lblBarCode.Text = "BAR CODE:"
        Me.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReceivedData
        '
        Me.txtReceivedData.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReceivedData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReceivedData.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtReceivedData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtReceivedData.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtReceivedData.ForeColor = System.Drawing.Color.White
        Me.txtReceivedData.Location = New System.Drawing.Point(0, 359)
        Me.txtReceivedData.MaxLength = 64
        Me.txtReceivedData.Name = "txtReceivedData"
        Me.txtReceivedData.Size = New System.Drawing.Size(704, 18)
        Me.txtReceivedData.TabIndex = 10
        Me.txtReceivedData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCurrency
        '
        Me.lblCurrency.BackColor = System.Drawing.Color.Red
        Me.lblCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCurrency.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblCurrency.ForeColor = System.Drawing.Color.White
        Me.lblCurrency.Location = New System.Drawing.Point(220, 110)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(249, 45)
        Me.lblCurrency.TabIndex = 12
        Me.lblCurrency.Text = "=N="
        Me.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrice
        '
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPrice.Font = New System.Drawing.Font("Consolas", 100.0!)
        Me.lblPrice.ForeColor = System.Drawing.Color.Red
        Me.lblPrice.Location = New System.Drawing.Point(33, 175)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(639, 155)
        Me.lblPrice.TabIndex = 11
        Me.lblPrice.Text = "0.00"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_checker
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.lblCurrency)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.txtReceivedData)
        Me.Controls.Add(Me.lblBarCode)
        Me.Controls.Add(Me.lblProductName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "_checker"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Price Checker"
        Me.Text = "Price Checker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProductName As Label
    Friend WithEvents lblBarCode As Label
    Friend WithEvents txtReceivedData As TextBox
    Friend WithEvents lblCurrency As Label
    Friend WithEvents lblPrice As Label
End Class
