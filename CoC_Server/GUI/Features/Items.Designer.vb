<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Items
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
        Me.t_Cost = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.t_Discount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.t_Price = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.l_Selling = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_Barcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_Item = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cautionary = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.dtp_Expire = New System.Windows.Forms.DateTimePicker()
        Me.l_ItemCode = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.t_VAT = New System.Windows.Forms.TextBox()
        Me.l_VAT = New System.Windows.Forms.Label()
        Me.chkTaxInclusive = New System.Windows.Forms.CheckBox()
        Me.chkIsWeighable = New System.Windows.Forms.CheckBox()
        Me.usrAvatar = New System.Windows.Forms.PictureBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.l_Discount = New System.Windows.Forms.Label()
        Me.btnClose = New MetroFramework.Controls.MetroButton()
        Me.c_Currency = New MetroFramework.Controls.MetroComboBox()
        Me.c_Supplier = New MetroFramework.Controls.MetroComboBox()
        Me.c_Category = New MetroFramework.Controls.MetroComboBox()
        Me.c_P_Category = New MetroFramework.Controls.MetroComboBox()
        Me.btnAddUnits = New System.Windows.Forms.Label()
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        't_Cost
        '
        Me.t_Cost.BackColor = System.Drawing.Color.White
        Me.t_Cost.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Cost.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.t_Cost.Location = New System.Drawing.Point(45, 367)
        Me.t_Cost.Name = "t_Cost"
        Me.t_Cost.Size = New System.Drawing.Size(380, 19)
        Me.t_Cost.TabIndex = 72
        Me.t_Cost.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(24, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 19)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Cost Price"
        '
        't_Discount
        '
        Me.t_Discount.BackColor = System.Drawing.Color.White
        Me.t_Discount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Discount.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.t_Discount.Location = New System.Drawing.Point(45, 247)
        Me.t_Discount.MaxLength = 3
        Me.t_Discount.Name = "t_Discount"
        Me.t_Discount.Size = New System.Drawing.Size(380, 19)
        Me.t_Discount.TabIndex = 68
        Me.t_Discount.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Discount [%]"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(24, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 19)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Currency"
        '
        't_Price
        '
        Me.t_Price.BackColor = System.Drawing.Color.White
        Me.t_Price.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Price.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.t_Price.Location = New System.Drawing.Point(45, 190)
        Me.t_Price.Name = "t_Price"
        Me.t_Price.Size = New System.Drawing.Size(380, 19)
        Me.t_Price.TabIndex = 63
        Me.t_Price.Text = "0"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(547, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 19)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Supplier"
        '
        'l_Selling
        '
        Me.l_Selling.AutoSize = True
        Me.l_Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Selling.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.l_Selling.ForeColor = System.Drawing.Color.Black
        Me.l_Selling.Location = New System.Drawing.Point(24, 165)
        Me.l_Selling.Name = "l_Selling"
        Me.l_Selling.Size = New System.Drawing.Size(100, 19)
        Me.l_Selling.TabIndex = 59
        Me.l_Selling.Text = "*Selling Price"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(547, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Purchase Category"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(546, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Item Category"
        '
        't_Barcode
        '
        Me.t_Barcode.BackColor = System.Drawing.Color.White
        Me.t_Barcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Barcode.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Barcode.Location = New System.Drawing.Point(565, 72)
        Me.t_Barcode.Name = "t_Barcode"
        Me.t_Barcode.Size = New System.Drawing.Size(240, 20)
        Me.t_Barcode.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(551, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "*Barcode"
        '
        't_Item
        '
        Me.t_Item.BackColor = System.Drawing.Color.White
        Me.t_Item.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_Item.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.t_Item.Location = New System.Drawing.Point(45, 135)
        Me.t_Item.Name = "t_Item"
        Me.t_Item.Size = New System.Drawing.Size(380, 20)
        Me.t_Item.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "*ITEM NAME"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(566, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(240, 2)
        Me.Label14.TabIndex = 151
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DarkGray
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label15.Location = New System.Drawing.Point(45, 157)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(380, 2)
        Me.Label15.TabIndex = 151
        Me.Label15.Text = "Label15"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DarkGray
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label16.Location = New System.Drawing.Point(45, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(380, 2)
        Me.Label16.TabIndex = 152
        Me.Label16.Text = "Label16"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.DarkGray
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label17.Location = New System.Drawing.Point(45, 269)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(380, 2)
        Me.Label17.TabIndex = 153
        Me.Label17.Text = "Label17"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.DarkGray
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label18.Location = New System.Drawing.Point(45, 389)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(380, 2)
        Me.Label18.TabIndex = 154
        Me.Label18.Text = "Label18"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cautionary
        '
        Me.cautionary.AutoSize = True
        Me.cautionary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cautionary.Font = New System.Drawing.Font("Corbel", 10.0!)
        Me.cautionary.ForeColor = System.Drawing.Color.Red
        Me.cautionary.Location = New System.Drawing.Point(25, 82)
        Me.cautionary.Name = "cautionary"
        Me.cautionary.Size = New System.Drawing.Size(265, 17)
        Me.cautionary.TabIndex = 160
        Me.cautionary.Text = "fields marked with asterisk(*) are important"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label21.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(547, 346)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(121, 19)
        Me.Label21.TabIndex = 161
        Me.Label21.Text = "Item Expiry Date"
        '
        'dtp_Expire
        '
        Me.dtp_Expire.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Expire.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.dtp_Expire.Location = New System.Drawing.Point(565, 372)
        Me.dtp_Expire.Name = "dtp_Expire"
        Me.dtp_Expire.Size = New System.Drawing.Size(241, 25)
        Me.dtp_Expire.TabIndex = 162
        '
        'l_ItemCode
        '
        Me.l_ItemCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.l_ItemCode.AutoSize = True
        Me.l_ItemCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_ItemCode.Font = New System.Drawing.Font("Segoe UI Light", 11.0!)
        Me.l_ItemCode.ForeColor = System.Drawing.Color.Black
        Me.l_ItemCode.Location = New System.Drawing.Point(557, 23)
        Me.l_ItemCode.Name = "l_ItemCode"
        Me.l_ItemCode.Size = New System.Drawing.Size(73, 20)
        Me.l_ItemCode.TabIndex = 164
        Me.l_ItemCode.Text = "Item Code"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Teal
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(45, 448)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(380, 2)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Label6"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_VAT
        '
        Me.t_VAT.BackColor = System.Drawing.Color.White
        Me.t_VAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_VAT.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.t_VAT.Location = New System.Drawing.Point(45, 426)
        Me.t_VAT.MaxLength = 3
        Me.t_VAT.Name = "t_VAT"
        Me.t_VAT.ReadOnly = True
        Me.t_VAT.Size = New System.Drawing.Size(380, 19)
        Me.t_VAT.TabIndex = 169
        Me.t_VAT.Text = "0"
        '
        'l_VAT
        '
        Me.l_VAT.AutoSize = True
        Me.l_VAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_VAT.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.l_VAT.ForeColor = System.Drawing.Color.Black
        Me.l_VAT.Location = New System.Drawing.Point(24, 401)
        Me.l_VAT.Name = "l_VAT"
        Me.l_VAT.Size = New System.Drawing.Size(70, 19)
        Me.l_VAT.TabIndex = 168
        Me.l_VAT.Text = "VAT [5%]"
        '
        'chkTaxInclusive
        '
        Me.chkTaxInclusive.AutoSize = True
        Me.chkTaxInclusive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTaxInclusive.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTaxInclusive.Location = New System.Drawing.Point(314, 396)
        Me.chkTaxInclusive.Name = "chkTaxInclusive"
        Me.chkTaxInclusive.Size = New System.Drawing.Size(111, 23)
        Me.chkTaxInclusive.TabIndex = 171
        Me.chkTaxInclusive.Text = "TAX Inclusive"
        Me.chkTaxInclusive.UseVisualStyleBackColor = True
        '
        'chkIsWeighable
        '
        Me.chkIsWeighable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIsWeighable.AutoSize = True
        Me.chkIsWeighable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkIsWeighable.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIsWeighable.Location = New System.Drawing.Point(565, 307)
        Me.chkIsWeighable.Name = "chkIsWeighable"
        Me.chkIsWeighable.Size = New System.Drawing.Size(109, 26)
        Me.chkIsWeighable.TabIndex = 172
        Me.chkIsWeighable.Text = "Is Weighable"
        Me.chkIsWeighable.UseCompatibleTextRendering = True
        Me.chkIsWeighable.UseVisualStyleBackColor = True
        '
        'usrAvatar
        '
        Me.usrAvatar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usrAvatar.BackColor = System.Drawing.SystemColors.Window
        Me.usrAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.usrAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.usrAvatar.Cursor = System.Windows.Forms.Cursors.Default
        Me.usrAvatar.Location = New System.Drawing.Point(325, 18)
        Me.usrAvatar.MaximumSize = New System.Drawing.Size(100, 100)
        Me.usrAvatar.MinimumSize = New System.Drawing.Size(100, 100)
        Me.usrAvatar.Name = "usrAvatar"
        Me.usrAvatar.Size = New System.Drawing.Size(100, 100)
        Me.usrAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usrAvatar.TabIndex = 173
        Me.usrAvatar.TabStop = False
        Me.usrAvatar.WaitOnLoad = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnReset.FlatAppearance.BorderSize = 2
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnReset.ForeColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(551, 431)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(107, 30)
        Me.btnReset.TabIndex = 174
        Me.btnReset.Text = "Reset [F5]"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(716, 431)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 30)
        Me.btnSave.TabIndex = 175
        Me.btnSave.Text = "Save [F1]"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'l_Discount
        '
        Me.l_Discount.AutoSize = True
        Me.l_Discount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Discount.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.l_Discount.ForeColor = System.Drawing.Color.Black
        Me.l_Discount.Location = New System.Drawing.Point(124, 221)
        Me.l_Discount.Name = "l_Discount"
        Me.l_Discount.Size = New System.Drawing.Size(63, 19)
        Me.l_Discount.TabIndex = 176
        Me.l_Discount.Text = "Dsc: 0"
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnClose.ForeColor = System.Drawing.Color.Silver
        Me.btnClose.Location = New System.Drawing.Point(809, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 28)
        Me.btnClose.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnClose.TabIndex = 177
        Me.btnClose.Text = "X"
        Me.btnClose.UseCustomBackColor = True
        Me.btnClose.UseCustomForeColor = True
        Me.btnClose.UseSelectable = True
        Me.btnClose.UseStyleColors = True
        '
        'c_Currency
        '
        Me.c_Currency.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.c_Currency.FormattingEnabled = True
        Me.c_Currency.ItemHeight = 23
        Me.c_Currency.Location = New System.Drawing.Point(45, 305)
        Me.c_Currency.Name = "c_Currency"
        Me.c_Currency.Size = New System.Drawing.Size(380, 29)
        Me.c_Currency.Style = MetroFramework.MetroColorStyle.Teal
        Me.c_Currency.TabIndex = 178
        Me.c_Currency.Theme = MetroFramework.MetroThemeStyle.Light
        Me.c_Currency.UseSelectable = True
        Me.c_Currency.UseStyleColors = True
        '
        'c_Supplier
        '
        Me.c_Supplier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.c_Supplier.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.c_Supplier.FormattingEnabled = True
        Me.c_Supplier.ItemHeight = 19
        Me.c_Supplier.Location = New System.Drawing.Point(565, 150)
        Me.c_Supplier.MaxDropDownItems = 13
        Me.c_Supplier.MaxLength = 128
        Me.c_Supplier.Name = "c_Supplier"
        Me.c_Supplier.Size = New System.Drawing.Size(241, 25)
        Me.c_Supplier.Style = MetroFramework.MetroColorStyle.Teal
        Me.c_Supplier.TabIndex = 179
        Me.c_Supplier.Theme = MetroFramework.MetroThemeStyle.Light
        Me.c_Supplier.UseCustomBackColor = True
        Me.c_Supplier.UseSelectable = True
        Me.c_Supplier.UseStyleColors = True
        '
        'c_Category
        '
        Me.c_Category.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.c_Category.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.c_Category.FormattingEnabled = True
        Me.c_Category.ItemHeight = 19
        Me.c_Category.Location = New System.Drawing.Point(565, 206)
        Me.c_Category.MaxDropDownItems = 13
        Me.c_Category.MaxLength = 128
        Me.c_Category.Name = "c_Category"
        Me.c_Category.Size = New System.Drawing.Size(241, 25)
        Me.c_Category.Style = MetroFramework.MetroColorStyle.Teal
        Me.c_Category.TabIndex = 180
        Me.c_Category.Theme = MetroFramework.MetroThemeStyle.Light
        Me.c_Category.UseCustomBackColor = True
        Me.c_Category.UseSelectable = True
        Me.c_Category.UseStyleColors = True
        '
        'c_P_Category
        '
        Me.c_P_Category.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.c_P_Category.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.c_P_Category.FormattingEnabled = True
        Me.c_P_Category.ItemHeight = 19
        Me.c_P_Category.Location = New System.Drawing.Point(565, 263)
        Me.c_P_Category.MaxDropDownItems = 13
        Me.c_P_Category.MaxLength = 128
        Me.c_P_Category.Name = "c_P_Category"
        Me.c_P_Category.Size = New System.Drawing.Size(241, 25)
        Me.c_P_Category.Style = MetroFramework.MetroColorStyle.Teal
        Me.c_P_Category.TabIndex = 181
        Me.c_P_Category.Theme = MetroFramework.MetroThemeStyle.Light
        Me.c_P_Category.UseCustomBackColor = True
        Me.c_P_Category.UseSelectable = True
        Me.c_P_Category.UseStyleColors = True
        '
        'btnAddUnits
        '
        Me.btnAddUnits.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddUnits.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAddUnits.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUnits.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddUnits.ForeColor = System.Drawing.Color.White
        Me.btnAddUnits.Location = New System.Drawing.Point(689, 307)
        Me.btnAddUnits.Name = "btnAddUnits"
        Me.btnAddUnits.Size = New System.Drawing.Size(117, 23)
        Me.btnAddUnits.TabIndex = 218
        Me.btnAddUnits.Tag = ""
        Me.btnAddUnits.Text = "[F3] add units"
        Me.btnAddUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddUnits.UseCompatibleTextRendering = True
        Me.btnAddUnits.Visible = False
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(840, 480)
        Me.Controls.Add(Me.btnAddUnits)
        Me.Controls.Add(Me.c_P_Category)
        Me.Controls.Add(Me.c_Category)
        Me.Controls.Add(Me.c_Supplier)
        Me.Controls.Add(Me.c_Currency)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.l_Discount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.t_Barcode)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.usrAvatar)
        Me.Controls.Add(Me.chkIsWeighable)
        Me.Controls.Add(Me.chkTaxInclusive)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.t_VAT)
        Me.Controls.Add(Me.l_VAT)
        Me.Controls.Add(Me.l_ItemCode)
        Me.Controls.Add(Me.dtp_Expire)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cautionary)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.t_Cost)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.t_Discount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.t_Price)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.l_Selling)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t_Item)
        Me.Controls.Add(Me.Label4)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Items"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Create Item"
        CType(Me.usrAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents t_Cost As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents t_Discount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents t_Price As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents l_Selling As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents t_Barcode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents t_Item As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cautionary As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents dtp_Expire As DateTimePicker
    Friend WithEvents l_ItemCode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents t_VAT As TextBox
    Friend WithEvents l_VAT As Label
    Friend WithEvents chkTaxInclusive As CheckBox
    Friend WithEvents chkIsWeighable As CheckBox
    Friend WithEvents usrAvatar As PictureBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents l_Discount As Label
    Friend WithEvents btnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents c_Currency As MetroFramework.Controls.MetroComboBox
    Friend WithEvents c_Supplier As MetroFramework.Controls.MetroComboBox
    Friend WithEvents c_Category As MetroFramework.Controls.MetroComboBox
    Friend WithEvents c_P_Category As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnAddUnits As Label
End Class
