Imports System.ComponentModel

Public NotInheritable Class startMe

    Private countTim As Integer = 0
    Function TheKillJoy()
        Dim YouNowHaveLicenseTo As Process = Process.GetCurrentProcess
        YouNowHaveLicenseTo.Kill()
    End Function
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        'write_Error(fetchId, "")
        'Call TheKillJoy()
        'Exit Sub

        With Date.Now
            JournalDate = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond)
        End With

        'Cnfg.IsFirstTimeUse = Cnfg.Actv
        'Cnfg.Save()

        InitiateSOD()

        Try

            CreateDbUser()

            'ModifyDbUser()

            'CreateuserDb(CoC_Mains)
            CreateuserDb(CoC_Items)
            CreateuserDb(CoC_Transactions)

            'defineDatabase_Name("query_Entries")
        Catch ex As Exception
            write_Error(ex.Message, Name)
            MsgBox("APP FAILED TO START! ", MsgBoxStyle.Critical, "Cy POS")
            GoTo 7
        End Try

        Try

            If TableExists("settingsTbl", c) Then
                GoTo 5
            Else

                'IO.File.WriteAllText(cy_Log.ToString, "App Has Been Born. " & vbNewLine & vbNewLine)

                createSettingsTbl()
                MsgBox("Hello!", MsgBoxStyle.Information, "Cy POS")
                Cnfg.Reload()
            End If
        Catch ex As Exception
            'write_Error(UCase(ex.Message), Name)
            'MsgBox("AUTHENTICATION ERROR! " & UCase(ex.Message))
            'GoTo 7
            'Exit Sub
        End Try

        If Cnfg.IsFirstTimeUse = Cnfg.Actv Then
            Cnfg.IsFirstTimeUse = Cnfg.InActv
            Cnfg.Save()

            If CStr(Cnfg.LicenseDate) = NullVal Then

                If Not My.Settings.LicenseDate = Nothing Then
                    Cnfg.LicenseDate = My.Settings.LicenseDate.ToLongDateString

                Else
                    Cnfg.LicenseDate = Date.Now.ToLongDateString
                    My.Settings.LicenseDate = Date.Now.Date
                    My.Settings.Save()

                End If

                Cnfg.Save()

            End If

        End If

5:      Try

            'Dim d As Date
            'With Date.Now
            'd = New Date(.Year, .Month, .Day, 23, 59, 59)
            'End With

            'My.Settings.LicenseDate = D
            'My.Settings.Save()
            'Cnfg.LicenseDate = D

            'Cnfg.LicenseStatus = Cnfg.LicenseEvaluated
            'Cnfg.Save()
            'DestroyTable("clLogsHistory", c)
            'Call TheKillJoy()

            Cnfg.Reload()

            Try
                'MsgBox(My.Settings.LicenseDate.ToShortDateString)
                'MsgBox(Cnfg.LicenseDate)
            Catch ex As Exception

            End Try

            If My.Settings.LicenseDate = Nothing Then _
                My.Settings.LicenseDate = Date.Parse(Cnfg.LicenseDate) : _
                My.Settings.Save()

            loadDays()

            If licensedays <= 0 Then
                Cnfg.LicenseStatus = Cnfg.LicenseInactive
                Dim mgRq As MsgBoxResult = MsgBox(licenseerrormsg,
                   MsgBoxStyle.OkOnly)

                Cnfg.Save()

                If Not mgRq = MsgBoxResult.Ok Then Exit Sub Else GoTo 6

            Else
                Cnfg.LicenseStatus = Cnfg.LicenseEvaluated
                Cnfg.Save()

            End If

6:          BeginSequencing_()

            write_Log("App Started")

            SetupClientLogin()
            SetupSubAccountLog()
            SetupSubAccountLog_Records()
            SetupContacts()
            SetupCompanyData()
            SetupCategoriesDb()
            SetupCurrencyDb()
            SetupDiscountables()
            SetupInvoiceOrders()
            SetupInvoiceOutstandings()
            SetupInvoices()
            SetupInvoicesReturned()
            SetupMeasuringUnits()
            SetupMerchantsDb()
            SetupPaymentMeans()
            SetupItems()
            SetupItemsDetails()
            SetupItemsHistory()
            SetupItemsMeasurements()
            SetupItemProxy()
            setupPurchases()
            SetupPurchaseOrder()
            SetupPurchaseReturns()
            SetupTXNs()
            SetupTXNsModified()
            SetupTXNsOrder()
            SetupTXNsReturns()
            SetupStockStatus()
            SetupStockTransfer()
            SetupStockUpdateStatus()
            SetupSuppliersDb()

            timeCount.Start()

            Uploadfields()

        Catch ex As Exception
            write_Error(ex.Message, Name)
        End Try

        Exit Sub
7:      Dim _YouNowHaveLicenseTo As Process = Process.GetCurrentProcess
        _YouNowHaveLicenseTo.Kill()

    End Sub

    Sub Uploadfields()
        'AlterColumn("clDocFile", "clItems", "bytea", dionysus)
    End Sub
    Dim cScr As Integer = 1
    Private cy_Log As New IO.FileInfo(String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "\Cy\init\app\logger_.log"))
    Private Sub timeCount_Tick(sender As Object, e As EventArgs) 'Handles timeCount.Tick
        cScr = cScr + 1
        If cScr >= 99 Then cScr = 1
        onObjPrg.Spinning = True

        countTim = countTim + 1
        If countTim = 13 Then
            '//bgw_RunWorkerCompleted tested these waters

        End If

    End Sub

    Private WithEvents bgw As New BackgroundWorker
    Public Sub BeginSequencing_()
        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True
        If bgw.IsBusy = False Then
            bgw.RunWorkerAsync(10)
        End If
    End Sub
    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw.DoWork
        Dim numToDo As Integer = CInt(e.Argument)
        For n As Integer = 1 To numToDo
            Threading.Thread.Sleep(100)
            bgw.ReportProgress(Convert.ToInt32((n / numToDo) * 100))
        Next
    End Sub
    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw.ProgressChanged
        onObjPrg.Value = onObjPrg.Maximum
        onObjPrg.Value = e.ProgressPercentage
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        timeCount.Stop()
        Hide()
        Mode = LoginMode.Startup
        login.Show()

    End Sub

End Class
