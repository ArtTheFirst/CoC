<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReUpload
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkAppend = New System.Windows.Forms.CheckBox()
        Me.rdUploadClients = New System.Windows.Forms.RadioButton()
        Me.rdUploadSuppliers = New System.Windows.Forms.RadioButton()
        Me.btnBeginUpload = New System.Windows.Forms.Label()
        Me.rdUploadStock = New System.Windows.Forms.RadioButton()
        Me.btnProceed = New System.Windows.Forms.Label()
        Me.l_SelectedExploit = New System.Windows.Forms.Label()
        Me.l_RecordsCount = New System.Windows.Forms.Label()
        Me.l_DataSize = New System.Windows.Forms.Label()
        Me.l_DataFormat = New System.Windows.Forms.Label()
        Me.l_DataDate = New System.Windows.Forms.Label()
        Me.l_LastModifiedDate = New System.Windows.Forms.Label()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 42)
        Me.Panel4.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Corbel", 18.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(558, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Re-Format Database"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.Panel1.Controls.Add(Me.chkAppend)
        Me.Panel1.Controls.Add(Me.rdUploadClients)
        Me.Panel1.Controls.Add(Me.rdUploadSuppliers)
        Me.Panel1.Controls.Add(Me.btnBeginUpload)
        Me.Panel1.Controls.Add(Me.rdUploadStock)
        Me.Panel1.Controls.Add(Me.btnProceed)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(484, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 399)
        Me.Panel1.TabIndex = 13
        '
        'chkAppend
        '
        Me.chkAppend.AutoSize = True
        Me.chkAppend.Location = New System.Drawing.Point(33, 339)
        Me.chkAppend.Name = "chkAppend"
        Me.chkAppend.Size = New System.Drawing.Size(146, 22)
        Me.chkAppend.TabIndex = 168
        Me.chkAppend.Text = "Append To Records"
        Me.chkAppend.UseVisualStyleBackColor = True
        '
        'rdUploadClients
        '
        Me.rdUploadClients.AutoSize = True
        Me.rdUploadClients.BackColor = System.Drawing.Color.Transparent
        Me.rdUploadClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdUploadClients.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdUploadClients.Location = New System.Drawing.Point(28, 186)
        Me.rdUploadClients.Name = "rdUploadClients"
        Me.rdUploadClients.Size = New System.Drawing.Size(203, 25)
        Me.rdUploadClients.TabIndex = 162
        Me.rdUploadClients.TabStop = True
        Me.rdUploadClients.Text = "CLIENTS / MERCHANTS"
        Me.rdUploadClients.UseVisualStyleBackColor = False
        '
        'rdUploadSuppliers
        '
        Me.rdUploadSuppliers.AutoSize = True
        Me.rdUploadSuppliers.BackColor = System.Drawing.Color.Transparent
        Me.rdUploadSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdUploadSuppliers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdUploadSuppliers.Location = New System.Drawing.Point(28, 147)
        Me.rdUploadSuppliers.Name = "rdUploadSuppliers"
        Me.rdUploadSuppliers.Size = New System.Drawing.Size(109, 25)
        Me.rdUploadSuppliers.TabIndex = 161
        Me.rdUploadSuppliers.TabStop = True
        Me.rdUploadSuppliers.Text = "SUPPLIERS"
        Me.rdUploadSuppliers.UseVisualStyleBackColor = False
        '
        'btnBeginUpload
        '
        Me.btnBeginUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBeginUpload.BackColor = System.Drawing.Color.Blue
        Me.btnBeginUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeginUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeginUpload.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBeginUpload.ForeColor = System.Drawing.Color.White
        Me.btnBeginUpload.Location = New System.Drawing.Point(30, 369)
        Me.btnBeginUpload.Name = "btnBeginUpload"
        Me.btnBeginUpload.Size = New System.Drawing.Size(244, 21)
        Me.btnBeginUpload.TabIndex = 166
        Me.btnBeginUpload.Text = "BEGIN UPLOAD"
        Me.btnBeginUpload.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rdUploadStock
        '
        Me.rdUploadStock.AutoSize = True
        Me.rdUploadStock.BackColor = System.Drawing.Color.Transparent
        Me.rdUploadStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdUploadStock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.rdUploadStock.Location = New System.Drawing.Point(28, 106)
        Me.rdUploadStock.Name = "rdUploadStock"
        Me.rdUploadStock.Size = New System.Drawing.Size(76, 25)
        Me.rdUploadStock.TabIndex = 160
        Me.rdUploadStock.TabStop = True
        Me.rdUploadStock.Text = "STOCK"
        Me.rdUploadStock.UseVisualStyleBackColor = False
        '
        'btnProceed
        '
        Me.btnProceed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProceed.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnProceed.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(8, 0)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(282, 21)
        Me.btnProceed.TabIndex = 159
        Me.btnProceed.Text = "CHOOSE DATA TO UPLOAD"
        Me.btnProceed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_SelectedExploit
        '
        Me.l_SelectedExploit.BackColor = System.Drawing.Color.Teal
        Me.l_SelectedExploit.Cursor = System.Windows.Forms.Cursors.Default
        Me.l_SelectedExploit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_SelectedExploit.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.l_SelectedExploit.ForeColor = System.Drawing.Color.White
        Me.l_SelectedExploit.Location = New System.Drawing.Point(23, 123)
        Me.l_SelectedExploit.Name = "l_SelectedExploit"
        Me.l_SelectedExploit.Size = New System.Drawing.Size(270, 21)
        Me.l_SelectedExploit.TabIndex = 161
        Me.l_SelectedExploit.Text = "SELECTED []"
        Me.l_SelectedExploit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'l_RecordsCount
        '
        Me.l_RecordsCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_RecordsCount.AutoSize = True
        Me.l_RecordsCount.BackColor = System.Drawing.Color.Transparent
        Me.l_RecordsCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_RecordsCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RecordsCount.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.l_RecordsCount.ForeColor = System.Drawing.Color.Red
        Me.l_RecordsCount.Location = New System.Drawing.Point(23, 162)
        Me.l_RecordsCount.Name = "l_RecordsCount"
        Me.l_RecordsCount.Size = New System.Drawing.Size(111, 18)
        Me.l_RecordsCount.TabIndex = 162
        Me.l_RecordsCount.Text = "[] Records found"
        Me.l_RecordsCount.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_DataSize
        '
        Me.l_DataSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_DataSize.AutoSize = True
        Me.l_DataSize.BackColor = System.Drawing.Color.Transparent
        Me.l_DataSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_DataSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_DataSize.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.l_DataSize.ForeColor = System.Drawing.Color.Red
        Me.l_DataSize.Location = New System.Drawing.Point(23, 189)
        Me.l_DataSize.Name = "l_DataSize"
        Me.l_DataSize.Size = New System.Drawing.Size(81, 18)
        Me.l_DataSize.TabIndex = 163
        Me.l_DataSize.Text = "Data Size []"
        Me.l_DataSize.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_DataFormat
        '
        Me.l_DataFormat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_DataFormat.AutoSize = True
        Me.l_DataFormat.BackColor = System.Drawing.Color.Transparent
        Me.l_DataFormat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_DataFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_DataFormat.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.l_DataFormat.ForeColor = System.Drawing.Color.Red
        Me.l_DataFormat.Location = New System.Drawing.Point(23, 218)
        Me.l_DataFormat.Name = "l_DataFormat"
        Me.l_DataFormat.Size = New System.Drawing.Size(94, 18)
        Me.l_DataFormat.TabIndex = 164
        Me.l_DataFormat.Text = "File Format []"
        Me.l_DataFormat.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_DataDate
        '
        Me.l_DataDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_DataDate.AutoSize = True
        Me.l_DataDate.BackColor = System.Drawing.Color.Transparent
        Me.l_DataDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_DataDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_DataDate.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.l_DataDate.ForeColor = System.Drawing.Color.Red
        Me.l_DataDate.Location = New System.Drawing.Point(24, 246)
        Me.l_DataDate.Name = "l_DataDate"
        Me.l_DataDate.Size = New System.Drawing.Size(78, 18)
        Me.l_DataDate.TabIndex = 165
        Me.l_DataDate.Text = "File Date []"
        Me.l_DataDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'l_LastModifiedDate
        '
        Me.l_LastModifiedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_LastModifiedDate.AutoSize = True
        Me.l_LastModifiedDate.BackColor = System.Drawing.Color.Transparent
        Me.l_LastModifiedDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_LastModifiedDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_LastModifiedDate.Font = New System.Drawing.Font("Corbel", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.l_LastModifiedDate.ForeColor = System.Drawing.Color.Red
        Me.l_LastModifiedDate.Location = New System.Drawing.Point(23, 274)
        Me.l_LastModifiedDate.Name = "l_LastModifiedDate"
        Me.l_LastModifiedDate.Size = New System.Drawing.Size(129, 18)
        Me.l_LastModifiedDate.TabIndex = 166
        Me.l_LastModifiedDate.Text = "Last Modified On []"
        Me.l_LastModifiedDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReUpload
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.LightGray
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(784, 441)
        Me.Controls.Add(Me.l_LastModifiedDate)
        Me.Controls.Add(Me.l_DataDate)
        Me.Controls.Add(Me.l_DataFormat)
        Me.Controls.Add(Me.l_DataSize)
        Me.Controls.Add(Me.l_RecordsCount)
        Me.Controls.Add(Me.l_SelectedExploit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProceed As Label
    Friend WithEvents l_SelectedExploit As Label
    Friend WithEvents l_RecordsCount As Label
    Friend WithEvents l_DataSize As Label
    Friend WithEvents l_DataFormat As Label
    Friend WithEvents l_DataDate As Label
    Friend WithEvents rdUploadStock As RadioButton
    Friend WithEvents rdUploadClients As RadioButton
    Friend WithEvents rdUploadSuppliers As RadioButton
    Friend WithEvents btnBeginUpload As Label
    Friend WithEvents chkAppend As CheckBox
    Friend WithEvents l_LastModifiedDate As Label
End Class
