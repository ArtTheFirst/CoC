<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setup
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
        Me.btnLoadUp = New System.Windows.Forms.Button()
        Me.l_Sales = New System.Windows.Forms.Label()
        Me.l_Products = New System.Windows.Forms.Label()
        Me.l_Mains = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLoadUp
        '
        Me.btnLoadUp.BackColor = System.Drawing.Color.LightGray
        Me.btnLoadUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoadUp.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnLoadUp.FlatAppearance.BorderSize = 2
        Me.btnLoadUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadUp.Location = New System.Drawing.Point(19, 223)
        Me.btnLoadUp.Name = "btnLoadUp"
        Me.btnLoadUp.Size = New System.Drawing.Size(429, 33)
        Me.btnLoadUp.TabIndex = 0
        Me.btnLoadUp.Text = "LOAD UP DATABASES"
        Me.btnLoadUp.UseVisualStyleBackColor = False
        '
        'l_Sales
        '
        Me.l_Sales.AutoSize = True
        Me.l_Sales.BackColor = System.Drawing.Color.Transparent
        Me.l_Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Sales.ForeColor = System.Drawing.Color.Blue
        Me.l_Sales.Location = New System.Drawing.Point(32, 192)
        Me.l_Sales.Name = "l_Sales"
        Me.l_Sales.Size = New System.Drawing.Size(214, 18)
        Me.l_Sales.TabIndex = 1
        Me.l_Sales.Text = "Database status; sales not present"
        '
        'l_Products
        '
        Me.l_Products.AutoSize = True
        Me.l_Products.BackColor = System.Drawing.Color.Transparent
        Me.l_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Products.ForeColor = System.Drawing.Color.Blue
        Me.l_Products.Location = New System.Drawing.Point(32, 169)
        Me.l_Products.Name = "l_Products"
        Me.l_Products.Size = New System.Drawing.Size(240, 18)
        Me.l_Products.TabIndex = 2
        Me.l_Products.Text = "Database status; products not present"
        '
        'l_Mains
        '
        Me.l_Mains.AutoSize = True
        Me.l_Mains.BackColor = System.Drawing.Color.Transparent
        Me.l_Mains.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.l_Mains.ForeColor = System.Drawing.Color.Blue
        Me.l_Mains.Location = New System.Drawing.Point(32, 145)
        Me.l_Mains.Name = "l_Mains"
        Me.l_Mains.Size = New System.Drawing.Size(215, 18)
        Me.l_Mains.TabIndex = 3
        Me.l_Mains.Text = "Database status; main not present"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Corbel", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Database status"
        '
        'btnLoad
        '
        Me.btnLoad.AutoSize = True
        Me.btnLoad.BackColor = System.Drawing.Color.LightGray
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.Location = New System.Drawing.Point(349, 200)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(98, 18)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Continue open"
        '
        'setup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.CoC_Server.My.Resources.Resources.buy_now_icon_button_market_sell_retail_vector_4457527
        Me.ClientSize = New System.Drawing.Size(464, 261)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.l_Mains)
        Me.Controls.Add(Me.l_Products)
        Me.Controls.Add(Me.l_Sales)
        Me.Controls.Add(Me.btnLoadUp)
        Me.Font = New System.Drawing.Font("Corbel", 11.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "setup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cy POS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadUp As Button
    Friend WithEvents l_Sales As Label
    Friend WithEvents l_Products As Label
    Friend WithEvents l_Mains As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLoad As Label
End Class
