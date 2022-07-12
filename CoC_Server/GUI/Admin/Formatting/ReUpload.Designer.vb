<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReUpload
    Inherits MetroFramework.Forms.MetroForm

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
        Me.chkRecordMode = New System.Windows.Forms.CheckBox()
        Me.chkAppend = New System.Windows.Forms.CheckBox()
        Me.rdUploadClients = New System.Windows.Forms.RadioButton()
        Me.rdUploadSuppliers = New System.Windows.Forms.RadioButton()
        Me.btnBeginUpload = New System.Windows.Forms.Label()
        Me.rdUploadStock = New System.Windows.Forms.RadioButton()
        Me.l_RecordsCount = New System.Windows.Forms.Label()
        Me.l_DataSize = New System.Windows.Forms.Label()
        Me.l_DataFormat = New System.Windows.Forms.Label()
        Me.l_DataDate = New System.Windows.Forms.Label()
        Me.l_LastModifiedDate = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkRecordMode
        '
        Me.chkRecordMode.AutoSize = True
        Me.chkRecordMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkRecordMode.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.chkRecordMode.ForeColor = System.Drawing.Color.Black
        Me.chkRecordMode.Location = New System.Drawing.Point(57, 317)
        Me.chkRecordMode.Name = "chkRecordMode"
        Me.chkRecordMode.Size = New System.Drawing.Size(227, 22)
        Me.chkRecordMode.TabIndex = 169
        Me.chkRecordMode.Text = "Upload Records From Database"
        Me.chkRecordMode.UseVisualStyleBackColor = True
        '
        'chkAppend
        '
        Me.chkAppend.AutoSize = True
        Me.chkAppend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkAppend.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.chkAppend.ForeColor = System.Drawing.Color.Black
        Me.chkAppend.Location = New System.Drawing.Point(57, 348)
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
        Me.rdUploadClients.ForeColor = System.Drawing.Color.Teal
        Me.rdUploadClients.Location = New System.Drawing.Point(57, 225)
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
        Me.rdUploadSuppliers.ForeColor = System.Drawing.Color.Teal
        Me.rdUploadSuppliers.Location = New System.Drawing.Point(57, 186)
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
        Me.btnBeginUpload.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnBeginUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeginUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeginUpload.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBeginUpload.ForeColor = System.Drawing.Color.White
        Me.btnBeginUpload.Location = New System.Drawing.Point(53, 387)
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
        Me.rdUploadStock.ForeColor = System.Drawing.Color.Teal
        Me.rdUploadStock.Location = New System.Drawing.Point(57, 145)
        Me.rdUploadStock.Name = "rdUploadStock"
        Me.rdUploadStock.Size = New System.Drawing.Size(76, 25)
        Me.rdUploadStock.TabIndex = 160
        Me.rdUploadStock.TabStop = True
        Me.rdUploadStock.Text = "STOCK"
        Me.rdUploadStock.UseVisualStyleBackColor = False
        '
        'l_RecordsCount
        '
        Me.l_RecordsCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_RecordsCount.AutoSize = True
        Me.l_RecordsCount.BackColor = System.Drawing.Color.Transparent
        Me.l_RecordsCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.l_RecordsCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_RecordsCount.Font = New System.Drawing.Font("Segoe UI", 10.7!)
        Me.l_RecordsCount.ForeColor = System.Drawing.Color.Red
        Me.l_RecordsCount.Location = New System.Drawing.Point(414, 175)
        Me.l_RecordsCount.Name = "l_RecordsCount"
        Me.l_RecordsCount.Size = New System.Drawing.Size(119, 20)
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
        Me.l_DataSize.Font = New System.Drawing.Font("Segoe UI", 10.7!)
        Me.l_DataSize.ForeColor = System.Drawing.Color.Red
        Me.l_DataSize.Location = New System.Drawing.Point(414, 202)
        Me.l_DataSize.Name = "l_DataSize"
        Me.l_DataSize.Size = New System.Drawing.Size(86, 20)
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
        Me.l_DataFormat.Font = New System.Drawing.Font("Segoe UI", 10.7!)
        Me.l_DataFormat.ForeColor = System.Drawing.Color.Red
        Me.l_DataFormat.Location = New System.Drawing.Point(414, 231)
        Me.l_DataFormat.Name = "l_DataFormat"
        Me.l_DataFormat.Size = New System.Drawing.Size(97, 20)
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
        Me.l_DataDate.Font = New System.Drawing.Font("Segoe UI", 10.7!)
        Me.l_DataDate.ForeColor = System.Drawing.Color.Red
        Me.l_DataDate.Location = New System.Drawing.Point(415, 259)
        Me.l_DataDate.Name = "l_DataDate"
        Me.l_DataDate.Size = New System.Drawing.Size(82, 20)
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
        Me.l_LastModifiedDate.Font = New System.Drawing.Font("Segoe UI", 10.7!)
        Me.l_LastModifiedDate.ForeColor = System.Drawing.Color.Red
        Me.l_LastModifiedDate.Location = New System.Drawing.Point(414, 287)
        Me.l_LastModifiedDate.Name = "l_LastModifiedDate"
        Me.l_LastModifiedDate.Size = New System.Drawing.Size(137, 20)
        Me.l_LastModifiedDate.TabIndex = 166
        Me.l_LastModifiedDate.Text = "Last Modified On []"
        Me.l_LastModifiedDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.CoC_Server.My.Resources.Resources.logo_kindof
        Me.PictureBox1.Location = New System.Drawing.Point(660, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 170
        Me.PictureBox1.TabStop = False
        '
        'ReUpload
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(800, 480)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkRecordMode)
        Me.Controls.Add(Me.chkAppend)
        Me.Controls.Add(Me.l_LastModifiedDate)
        Me.Controls.Add(Me.rdUploadClients)
        Me.Controls.Add(Me.l_DataDate)
        Me.Controls.Add(Me.rdUploadSuppliers)
        Me.Controls.Add(Me.l_DataFormat)
        Me.Controls.Add(Me.btnBeginUpload)
        Me.Controls.Add(Me.rdUploadStock)
        Me.Controls.Add(Me.l_DataSize)
        Me.Controls.Add(Me.l_RecordsCount)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReUpload"
        Me.Padding = New System.Windows.Forms.Padding(11, 61, 11, 23)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reset Databases"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents chkRecordMode As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
