Public Class _server
    Sub LoadTime()
        With Date.Now
            TheTime.Text =
                String.Concat(.ToShortDateString, "; ",
                                         .ToShortTimeString)
        End With

    End Sub

    Sub loadDetails()
        l_usr.Text = String.Concat("signed in as ", usr)

        With My.Application.Info
            l_App.Text = String.Concat(.ProductName, " (", .Description, ")", vbNewLine,
                                                                "Version; ", .Version, " (", .Copyright, ")", vbNewLine)
        End With
        l_CompanyDetails.Text = String.Concat(My.Settings.CompanyName, "; ", My.Settings.CompanyType, "; ", My.Settings.CompanyAddress)

        Try
            Dim buffer As Byte() = Convert.FromBase64String(My.Settings.CompanyLogo)
            If buffer IsNot Nothing Then
                Dim ic As New ImageConverter()
                usrAvatar.Image = TryCast(ic.ConvertFrom(buffer), Image)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        LoadTime()
        Dim oTime As New Timer
        With oTime
            .Enabled = True
            .Interval = 1000
            .Start()
        End With
        AddHandler oTime.Tick, AddressOf LoadTime
        loadDetails()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
        login.Show()
    End Sub

    Private Sub CompanyInformationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Company_Ctrl.ShowDialog()
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LoggedCashiers_Ctrl.ShowDialog()
    End Sub

    Private Sub ModifyUserAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        UserModify_Ctrl.ShowDialog()
    End Sub

    Private Sub CurrencyToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Currency_Ctrl.ShowDialog(Me)
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        SalesCategory_Ctrl.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Purchase_CategoryCtrl.ShowDialog()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Product_CategoryCtrl.ShowDialog()
    End Sub

    Private Sub CreateProductToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Products.ShowDialog()
    End Sub

    Private Sub ShowProductsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Product_Ctrl.ShowDialog()
    End Sub

    Private Sub UnitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Products_Unit.ShowDialog()
    End Sub

    Private Sub MerchantsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Merchant.ShowDialog()
    End Sub

    Private Sub DistributorsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Distributors_Ctrl.ShowDialog()
    End Sub

    Private Sub PrintInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MerchantInvoice_Ctrl.ShowDialog()
    End Sub

    Private Sub SalesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        SalesReports_Ctrl.ShowDialog()
    End Sub

    Private Sub SnapshotToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Day_Report.ShowDialog()
    End Sub

    Private Sub InvoicesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Invoices.ShowDialog()
    End Sub

End Class
