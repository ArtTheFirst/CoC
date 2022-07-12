<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectPrinter
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
        Me.btnBeginUpload = New System.Windows.Forms.Label()
        Me.l_Name = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBeginUpload
        '
        Me.btnBeginUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBeginUpload.BackColor = System.Drawing.Color.Teal
        Me.btnBeginUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeginUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeginUpload.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBeginUpload.ForeColor = System.Drawing.Color.White
        Me.btnBeginUpload.Location = New System.Drawing.Point(66, 75)
        Me.btnBeginUpload.Name = "btnBeginUpload"
        Me.btnBeginUpload.Size = New System.Drawing.Size(154, 29)
        Me.btnBeginUpload.TabIndex = 168
        Me.btnBeginUpload.Text = "FIND PRINTER [F1]"
        Me.btnBeginUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnBeginUpload.UseCompatibleTextRendering = True
        '
        'l_Name
        '
        Me.l_Name.BackColor = System.Drawing.Color.Transparent
        Me.l_Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Name.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.l_Name.ForeColor = System.Drawing.Color.Red
        Me.l_Name.Location = New System.Drawing.Point(23, 132)
        Me.l_Name.Name = "l_Name"
        Me.l_Name.Size = New System.Drawing.Size(238, 105)
        Me.l_Name.TabIndex = 169
        Me.l_Name.Tag = "Print Path: "
        Me.l_Name.Text = "Print Path: "
        '
        'SelectPrinter
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.l_Name)
        Me.Controls.Add(Me.btnBeginUpload)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SelectPrinter"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Choose Default Printer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBeginUpload As Label
    Friend WithEvents l_Name As Label
End Class
