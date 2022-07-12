<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WeightMeasurement
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.t_MeasuringUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.l_UnitsMeasurement = New System.Windows.Forms.Label()
        Me.l_UnitPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.t_UnitRequired = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.l_Total = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(42, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 2)
        Me.Label3.TabIndex = 207
        Me.Label3.Text = "Label3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_MeasuringUnit
        '
        Me.t_MeasuringUnit.BackColor = System.Drawing.Color.White
        Me.t_MeasuringUnit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_MeasuringUnit.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.t_MeasuringUnit.Location = New System.Drawing.Point(42, 98)
        Me.t_MeasuringUnit.MaxLength = 128
        Me.t_MeasuringUnit.Name = "t_MeasuringUnit"
        Me.t_MeasuringUnit.ReadOnly = True
        Me.t_MeasuringUnit.Size = New System.Drawing.Size(131, 19)
        Me.t_MeasuringUnit.TabIndex = 206
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(26, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 19)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Measuring Unit"
        '
        'l_UnitsMeasurement
        '
        Me.l_UnitsMeasurement.BackColor = System.Drawing.SystemColors.Window
        Me.l_UnitsMeasurement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_UnitsMeasurement.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_UnitsMeasurement.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.l_UnitsMeasurement.Location = New System.Drawing.Point(33, 126)
        Me.l_UnitsMeasurement.Name = "l_UnitsMeasurement"
        Me.l_UnitsMeasurement.Size = New System.Drawing.Size(241, 23)
        Me.l_UnitsMeasurement.TabIndex = 208
        Me.l_UnitsMeasurement.Tag = "[] Units / Measurement"
        Me.l_UnitsMeasurement.Text = "[] Units / Measurement"
        Me.l_UnitsMeasurement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.l_UnitsMeasurement.UseCompatibleTextRendering = True
        '
        'l_UnitPrice
        '
        Me.l_UnitPrice.BackColor = System.Drawing.SystemColors.Window
        Me.l_UnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_UnitPrice.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.l_UnitPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.l_UnitPrice.Location = New System.Drawing.Point(33, 153)
        Me.l_UnitPrice.Name = "l_UnitPrice"
        Me.l_UnitPrice.Size = New System.Drawing.Size(241, 23)
        Me.l_UnitPrice.TabIndex = 209
        Me.l_UnitPrice.Tag = "[price]/units"
        Me.l_UnitPrice.Text = "[price]/units"
        Me.l_UnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.l_UnitPrice.UseCompatibleTextRendering = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkGray
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(42, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 2)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        't_UnitRequired
        '
        Me.t_UnitRequired.BackColor = System.Drawing.Color.White
        Me.t_UnitRequired.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.t_UnitRequired.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.t_UnitRequired.Location = New System.Drawing.Point(42, 209)
        Me.t_UnitRequired.MaxLength = 6
        Me.t_UnitRequired.Name = "t_UnitRequired"
        Me.t_UnitRequired.Size = New System.Drawing.Size(131, 19)
        Me.t_UnitRequired.TabIndex = 214
        Me.t_UnitRequired.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Corbel", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(26, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 19)
        Me.Label5.TabIndex = 213
        Me.Label5.Text = "Enter Required Units"
        '
        'l_Total
        '
        Me.l_Total.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.l_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Total.Font = New System.Drawing.Font("Consolas", 29.0!)
        Me.l_Total.ForeColor = System.Drawing.Color.Black
        Me.l_Total.Location = New System.Drawing.Point(17, 248)
        Me.l_Total.Name = "l_Total"
        Me.l_Total.Size = New System.Drawing.Size(264, 39)
        Me.l_Total.TabIndex = 216
        Me.l_Total.Tag = "0.00"
        Me.l_Total.Text = "0.00"
        Me.l_Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.l_Total.UseCompatibleTextRendering = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Corbel", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(175, 61)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(117, 23)
        Me.btnSave.TabIndex = 217
        Me.btnSave.Tag = ""
        Me.btnSave.Text = "[F1] to save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.UseCompatibleTextRendering = True
        '
        'WeightMeasurement
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.l_Total)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.t_UnitRequired)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.l_UnitPrice)
        Me.Controls.Add(Me.l_UnitsMeasurement)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.t_MeasuringUnit)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WeightMeasurement"
        Me.Padding = New System.Windows.Forms.Padding(17, 61, 19, 13)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Set Measurement Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents t_MeasuringUnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents l_UnitsMeasurement As Label
    Friend WithEvents l_UnitPrice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents t_UnitRequired As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents l_Total As Label
    Friend WithEvents btnSave As Label
End Class
