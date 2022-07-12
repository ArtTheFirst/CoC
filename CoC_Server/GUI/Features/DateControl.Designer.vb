<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DateControl
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
        Me.btnExtension = New MetroFramework.Controls.MetroButton()
        Me.dtp_DateFilter1 = New MetroFramework.Controls.MetroDateTime()
        Me.dtp_DateFilter2 = New MetroFramework.Controls.MetroDateTime()
        Me.SuspendLayout()
        '
        'btnExtension
        '
        Me.btnExtension.BackColor = System.Drawing.Color.Green
        Me.btnExtension.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExtension.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExtension.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnExtension.ForeColor = System.Drawing.Color.White
        Me.btnExtension.Location = New System.Drawing.Point(19, 203)
        Me.btnExtension.Name = "btnExtension"
        Me.btnExtension.Size = New System.Drawing.Size(262, 30)
        Me.btnExtension.TabIndex = 96
        Me.btnExtension.Text = "Extend Filter"
        Me.btnExtension.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnExtension.UseCustomBackColor = True
        Me.btnExtension.UseCustomForeColor = True
        Me.btnExtension.UseSelectable = True
        Me.btnExtension.UseStyleColors = True
        '
        'dtp_DateFilter1
        '
        Me.dtp_DateFilter1.Location = New System.Drawing.Point(39, 79)
        Me.dtp_DateFilter1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_DateFilter1.Name = "dtp_DateFilter1"
        Me.dtp_DateFilter1.Size = New System.Drawing.Size(225, 29)
        Me.dtp_DateFilter1.TabIndex = 97
        '
        'dtp_DateFilter2
        '
        Me.dtp_DateFilter2.Location = New System.Drawing.Point(39, 162)
        Me.dtp_DateFilter2.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_DateFilter2.Name = "dtp_DateFilter2"
        Me.dtp_DateFilter2.Size = New System.Drawing.Size(225, 29)
        Me.dtp_DateFilter2.TabIndex = 98
        '
        'DateControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(300, 240)
        Me.Controls.Add(Me.dtp_DateFilter2)
        Me.Controls.Add(Me.dtp_DateFilter1)
        Me.Controls.Add(Me.btnExtension)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DateControl"
        Me.Padding = New System.Windows.Forms.Padding(19, 61, 19, 7)
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Select Date"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExtension As MetroFramework.Controls.MetroButton
    Friend WithEvents dtp_DateFilter1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtp_DateFilter2 As MetroFramework.Controls.MetroDateTime
End Class
