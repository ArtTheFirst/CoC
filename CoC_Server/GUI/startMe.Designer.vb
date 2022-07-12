<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class startMe
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.timeCount = New System.Windows.Forms.Timer(Me.components)
        Me.CompanyName = New System.Windows.Forms.Label()
        Me.CompanyText = New System.Windows.Forms.Label()
        Me.onObjPrg = New MetroFramework.Controls.MetroProgressSpinner()
        Me.l_ErrorTxt = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'timeCount
        '
        Me.timeCount.Interval = 1000
        '
        'CompanyName
        '
        Me.CompanyName.AutoSize = True
        Me.CompanyName.BackColor = System.Drawing.Color.Transparent
        Me.CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CompanyName.Font = New System.Drawing.Font("Corbel", 64.0!, System.Drawing.FontStyle.Bold)
        Me.CompanyName.ForeColor = System.Drawing.Color.Teal
        Me.CompanyName.Location = New System.Drawing.Point(38, 59)
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Size = New System.Drawing.Size(319, 105)
        Me.CompanyName.TabIndex = 2
        Me.CompanyName.Text = "Cy POS"
        Me.CompanyName.UseWaitCursor = True
        '
        'CompanyText
        '
        Me.CompanyText.AutoSize = True
        Me.CompanyText.BackColor = System.Drawing.Color.Transparent
        Me.CompanyText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CompanyText.Font = New System.Drawing.Font("Corbel", 16.0!, System.Drawing.FontStyle.Bold)
        Me.CompanyText.ForeColor = System.Drawing.Color.Teal
        Me.CompanyText.Location = New System.Drawing.Point(104, 164)
        Me.CompanyText.Name = "CompanyText"
        Me.CompanyText.Size = New System.Drawing.Size(167, 27)
        Me.CompanyText.TabIndex = 4
        Me.CompanyText.Text = "Cy Tech Systems"
        Me.CompanyText.UseWaitCursor = True
        '
        'onObjPrg
        '
        Me.onObjPrg.BackColor = System.Drawing.Color.White
        Me.onObjPrg.CustomBackground = True
        Me.onObjPrg.Location = New System.Drawing.Point(277, 154)
        Me.onObjPrg.Maximum = 100
        Me.onObjPrg.Name = "onObjPrg"
        Me.onObjPrg.Size = New System.Drawing.Size(67, 61)
        Me.onObjPrg.Style = MetroFramework.MetroColorStyle.Teal
        Me.onObjPrg.TabIndex = 5
        Me.onObjPrg.Theme = MetroFramework.MetroThemeStyle.Light
        Me.onObjPrg.UseCustomBackColor = True
        Me.onObjPrg.UseCustomForeColor = True
        Me.onObjPrg.UseSelectable = True
        Me.onObjPrg.UseStyleColors = True
        Me.onObjPrg.UseWaitCursor = True
        '
        'l_ErrorTxt
        '
        Me.l_ErrorTxt.AutoSize = True
        Me.l_ErrorTxt.BackColor = System.Drawing.Color.Red
        Me.l_ErrorTxt.FontSize = MetroFramework.MetroLabelSize.Small
        Me.l_ErrorTxt.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.l_ErrorTxt.ForeColor = System.Drawing.Color.White
        Me.l_ErrorTxt.Location = New System.Drawing.Point(87, 259)
        Me.l_ErrorTxt.Name = "l_ErrorTxt"
        Me.l_ErrorTxt.Size = New System.Drawing.Size(287, 15)
        Me.l_ErrorTxt.TabIndex = 160
        Me.l_ErrorTxt.Text = "Error Encountered: Application will now shut down"
        Me.l_ErrorTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.l_ErrorTxt.Theme = MetroFramework.MetroThemeStyle.Light
        Me.l_ErrorTxt.UseCustomBackColor = True
        Me.l_ErrorTxt.UseCustomForeColor = True
        Me.l_ErrorTxt.UseStyleColors = True
        Me.l_ErrorTxt.Visible = False
        '
        'startMe
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(474, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.l_ErrorTxt)
        Me.Controls.Add(Me.onObjPrg)
        Me.Controls.Add(Me.CompanyText)
        Me.Controls.Add(Me.CompanyName)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "startMe"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeCount As Timer
    Friend Shadows WithEvents CompanyName As Label
    Friend WithEvents CompanyText As Label
    Friend WithEvents onObjPrg As MetroFramework.Controls.MetroProgressSpinner
    Friend WithEvents l_ErrorTxt As MetroFramework.Controls.MetroLabel
End Class
