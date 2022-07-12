Public Class setup

    Sub loadUp() Handles btnLoadUp.Click
        defineMains()
        defineProducts()
        defineSales()
        If TableExists("settingsTbl", c) Then
            MsgBox("Databases ready", MsgBoxStyle.Information)
        End If

        Exit Sub

        Try
            createSettingsTbl()
            __MySettings.Reload()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If __MySettings.IsFirstTimeUse = __MySettings.ProcessActive Then
            __MySettings.IsFirstTimeUse = __MySettings.ProcessInActive
            If __MySettings.LicenseDate.ToString = "" Then
                __MySettings.LicenseDate = Date.Now
            End If

            __MySettings.Save()

            MsgBox("We are not live yet")

        End If

        UploadProgressDialog("Setting up. Please wait")
        SetupClientLogin()
        SetupSubAccountLog()
        SetupCompanyData()
        SetupCategoriesDb()
        SetupCurrencyDb()
        SetupInvoices()
        SetupInvoiceOutstandings()
        SetupMeasuringUnits()
        SetupMerchantsDb()
        SetupPaymentMeans()
        SetupProducts()
        SetupSales()
        SetupSuppliersDb()
        SetupUnitDb()

        loadText()

    End Sub
    Sub loadText()
        Dim fBol As Boolean = False
        If defineMains() = DataFile.Exists AndAlso defineProducts() = DataFile.Exists AndAlso defineSales() = DataFile.Exists Then
            If TableExists("settingsTbl", c) Then
                fBol = True
            End If
        End If
        Dim defM As String = "Database status; "
        l_Mains.Text = String.Concat(defM, String.Concat("mains", IIf(fBol, " ", " not "), "present"))
        l_Products.Text = String.Concat(defM, String.Concat("products", IIf(fBol, " ", " not "), "present"))
        l_Sales.Text = String.Concat(defM, String.Concat("sales", IIf(fBol, " ", " not "), "present"))
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadText()

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Close()
        startMe.Show()
    End Sub

End Class