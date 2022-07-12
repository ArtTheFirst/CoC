Imports System.ComponentModel
Imports System.Security
Public Class home

    Sub accessPermissions()
        If Not _This() = LoginIs.Client Then
            ExitToolStripMenuItem.Enabled = True
            InventoryToolStripMenuItem.Visible = True
            BranchesToolStripMenuItem.Visible = True
            _Purchases.Visible = True
            ReportsToolStripMenuItem.Visible = True
            FeaturesConfigurationsToolStripMenuItem.Visible = True
            MerchantsToolStripMenuItem.Visible = True
            SuppliersToolStripMenuItem.Visible = True
            TXNsReturnsToolStripMenuItem.Visible = True
            TXNsOrderToolStripMenuItem.Visible = True

            '//
            'If Not cPPthX64.Exists Or cPPthX86.Exists Then POSToolStripMenuItem.Enabled = False

        End If

    End Sub

    Public Sub InitiateAccess()
        DatePanel = ShouldBe.LeftAlone
        l_AcctDate.Text = String.Concat("Acct. Date: ", JournalDate.ToShortDateString)
        If licensedays > 0 Then If Not l_Counts.Enabled Then l_Counts.Start()
        Cnfg.Reload()
        l_CompanyDetails.Text = String.Concat(Cnfg.CompanyName,
                                              " [", Cnfg.CompanyAddress, "]",
                                              " (", Cnfg.CompanyType, ")")
        l_DaysLeftOnLicense.Text = licenseinfo
        With My.Application.Info
            l_App.Text = String.Concat(.ProductName,
                                                vbNewLine,
                                                "V", .Version.Major, " [Build ", .Version.Build, "]  " &
                                                "Revision [", .Version.MajorRevision, "] [Server Machine]")
        End With

        Call _This()

        If _This() = LoginIs.SubAdmin Then

            If Cnfg.subAdminReportControl = Cnfg.InActv Then
                ReportsToolStripMenuItem.Enabled = False
            Else
                ReportsToolStripMenuItem.Enabled = True
            End If

            '//
            If Cnfg.subAdminReportControl = Cnfg.InActv Then
                InvoicesToolStripMenuItem.Enabled = False
            Else
                InvoicesToolStripMenuItem.Enabled = True
            End If

            '//
            If Cnfg.subAdminModifyFeatures = Cnfg.InActv Then
                FeaturesToolStripMenuItem.Enabled = False
            Else
                FeaturesToolStripMenuItem.Enabled = True
            End If

        ElseIf _This() = LoginIs.Admin Then
            ReportsToolStripMenuItem.Enabled = True
            InvoicesToolStripMenuItem.Enabled = True
            FeaturesToolStripMenuItem.Enabled = True

        End If

        accessPermissions()

        l_usr.Text = String.Concat("Active User; ", sCs(usr))

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        InitiateAccess()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        Dim MRq As MsgBoxResult = MsgBox("Continue?", MsgBoxStyle.YesNo, "Cy POS")
        If MRq = MsgBoxResult.No Then e.Cancel = True : Exit Sub
        logUserExit()
        InitiateEOD()
        Dim YouNowHaveLicenseTo As Process = Process.GetCurrentProcess
        YouNowHaveLicenseTo.Kill()
    End Sub

    Private Sub l_Counts_Tick(sender As Object, e As EventArgs) Handles l_Counts.Tick
        loadDays()
        l_DaysLeftOnLicense.Text = licenseinfo
        'SetupStockStatus()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        logUserExit()
        usr = ""
        Hide()
        Mode = LoginMode.Startup
        login.Show()
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CreateItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateItemToolStripMenuItem.Click
        _Item = ___Is._New
        Dim f As New Items
        If Not f.Visible Then f.ShowDialog()
    End Sub
    Private Sub UpdateItemDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateItemDetailsToolStripMenuItem.Click
        CurrentItem = SearchIs.Create
        _Item = ___Is._Old
        searchModule = IsIn.InAppMode
        Dim h As New ItemSearch : If Not h.Visible Then h.ShowDialog()

    End Sub
    Private Sub StockUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockUpdatesToolStripMenuItem.Click
        StockUpdate.ShowDialog()
    End Sub
    Private Sub StockLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockLedgerToolStripMenuItem.Click
        StockLedger.ShowDialog()
    End Sub

    Private Sub InitiateNewSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InitiateNewSessionToolStripMenuItem.Click
        ThisBillMode = CurrentlyIs.TXNs
        ThisCurrent = BillMode.IsNew
        Cashier.ShowDialog()
    End Sub
    Private Sub PurchasesToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ThisCurrent = BillMode.IsNew
        _Purchase = EnterMode.IsNewEntry
        Purchases.ShowDialog()
    End Sub

    Private Sub CreateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateToolStripMenuItem.Click
        ThisMerchant = HereIs._New
        ThisClient = IsA.Customer
        Dim f As New Customers
        If Not f.Visible Then f.ShowDialog()
    End Sub
    Private Sub CreateModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateModifyToolStripMenuItem.Click
        ThisMerchant = HereIs._New
        ThisClient = IsA.Supplier
        Dim f As New Customers
        If Not f.Visible Then f.ShowDialog()
    End Sub
    Private Sub ModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem.Click
        ThisClient = IsA.Customer
        ThisMerchant = HereIs._Old
        CurrentItem = SearchIs.Create
        Dim f As New Clients
        If Not f.Visible Then f.ShowDialog()
        If CustId = "" Then Exit Sub
        Dim g As New Customers
        If Not g.Visible Then g.ShowDialog()
    End Sub
    Private Sub ModifyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModifyToolStripMenuItem1.Click
        ThisClient = IsA.Supplier
        ThisMerchant = HereIs._Old
        CurrentItem = SearchIs.Create
        Dim f As New Clients
        If Not f.Visible Then f.ShowDialog()
        If CustId = "" Then Exit Sub
        Dim g As New Customers
        If Not g.Visible Then g.ShowDialog()
    End Sub

    Private Sub SetCurrencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetCurrencyToolStripMenuItem.Click
        CurrentItem = SearchIs.Reports
        Dim F As New Currency_Ctrl
        If Not F.Visible Then F.ShowDialog()
    End Sub

    Private Sub SetMeasuringUnitsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetMeasuringUnitsToolStripMenuItem.Click
        CurrentItem = SearchIs.Reports
        Dim F As New MeasuringUnits
        If Not F.Visible Then F.ShowDialog()
    End Sub

    Private Sub SetPaymentMethodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPaymentMethodsToolStripMenuItem.Click
        CurrentItem = SearchIs.Reports
        Dim F As New PayMethod
        If Not F.Visible Then F.ShowDialog()
    End Sub

    Private Sub SetItemCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetItemCategoriesToolStripMenuItem.Click
        CurrentItem = SearchIs.Reports
        Dim F As New Items_CategoryCtrl
        If Not F.Visible Then F.ShowDialog()
    End Sub

    Private Sub SetPurchaseCategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetPurchaseCategoriesToolStripMenuItem.Click
        CurrentItem = SearchIs.Reports
        Dim F As New Purchase_CategoryCtrl
        If Not F.Visible Then F.ShowDialog()
    End Sub

    Private Sub ConfigureOptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigureOptionsToolStripMenuItem.Click
        If _This() = LoginIs.Admin Then
            GoTo 7
        ElseIf _This() = LoginIs.SubAdmin Then
            If Cnfg.subAdminModifySecurity = Cnfg.InActv Then
                MsgBox("You do not have the rights to do this. Sorry")
                Mode = LoginMode.AllowAccess
                login.ShowDialog()
                If _Access = _Request.IsGranted And CurrentRequested = UserLogin.IsAdmin Then
                    GoTo 7
                Else
                    ShowMessage("Permission revoked!", _Method.AsError)
                End If
            End If
        End If

        Exit Sub
7:      Dim f As New Configurations
        If Not f.Visible Then f.ShowDialog()

    End Sub

    Private Sub StockTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockTransferToolStripMenuItem.Click
        DatePanel = ShouldBe.Contracted
        Dim fDt As Form = New DateControl

        If Not fDt.Visible Then fDt.ShowDialog()
        StockTransfer.ShowDialog()
    End Sub

    Private Sub CreateModifyBranchToolStripMenuItem_Click(sender As Object, e As EventArgs)
        _Company = _AddMode.IsNew
        Company = AddMode.IsBranch
        Company_Ctrl.ShowDialog()
    End Sub

    Private Sub DefineBanksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefineBanksToolStripMenuItem.Click
        Dim f As New Banks
        If Not f.Visible Then f.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim f As New About
        If Not f.Visible Then f.ShowDialog()
    End Sub

    Private Sub home_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Escape Then
            ExitToolStripMenuItem_Click(Nothing, Nothing)

        ElseIf (e.KeyCode = Keys.I And e.Modifiers = Keys.Control) Or (e.KeyCode = Keys.I And e.Modifiers = Keys.ControlKey) Then
            CreateItemToolStripMenuItem_Click(Nothing, Nothing)

        ElseIf (e.KeyCode = Keys.S And e.Modifiers = Keys.Control) Or (e.KeyCode = Keys.S And e.Modifiers = Keys.ControlKey) Then
            InitiateNewSessionToolStripMenuItem_Click(Nothing, Nothing)

        ElseIf (e.KeyCode = Keys.P And e.Modifiers = Keys.Control) Or (e.KeyCode = Keys.P And e.Modifiers = Keys.ControlKey) Then
            PurchasesToolStripMenuItem1_Click(Nothing, Nothing)

        End If

    End Sub

    Private Sub MultiplePriceUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplePriceUpdateToolStripMenuItem.Click
        PriceUpdates.ShowDialog()
    End Sub

    Private Sub MergeBarcodesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MergeBarcodesToolStripMenuItem.Click
        ConformBarcode.ShowDialog()
    End Sub

    Private Sub GeneralDiscountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralDiscountsToolStripMenuItem.Click
        OfferManagement.ShowDialog()
    End Sub

    Private Sub TXNsReturnsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXNsReturnsToolStripMenuItem.Click
        ThisClient = IsA.Customer
        TXNsReturns.ShowDialog()
    End Sub

    Private Sub CreateWeighableItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateWeighableItemsToolStripMenuItem.Click
        CurrentItem = SearchIs.Create
        Code = ""
        Dim q As New ItemSearch
        If Not q.Visible Then q.ShowDialog()
        If Code = "" Then Exit Sub

        Dim IsWeighable As Decimal = -1
        Try
            IsWeighable = Qry("SELECT clWeighable FROM clItems WHERE SerialId='" & Code & "'", cItems)
        Catch ex As Exception
            IsWeighable = -1
        End Try

        If Not IsWeighable = 1 Then MsgBox("This item was not specified as weighable. Please correct and come back") : Exit Sub

        Dim fr As New Items_Weighable
        If Not fr.Visible Then fr.ShowDialog()

    End Sub

    Private Sub TXNsOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXNsOrderToolStripMenuItem.Click
        ThisCurrent = BillMode.IsNew
        ThisBillMode = CurrentlyIs.TXNsOrder
        ThisClient = IsA.Customer
        TXNsOrder.ShowDialog()
    End Sub

    Private Sub InitiateNewSessionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles InitiateNewSessionToolStripMenuItem1.Click
        ThisBillMode = CurrentlyIs.Purchase
        _Purchase = EnterMode.IsNewEntry
        Purchases.ShowDialog()
    End Sub

    Private Sub PurchaseReturnsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurchaseReturnsToolStripMenuItem1.Click
        ThisClient = IsA.Supplier
        PurchaseReturns.ShowDialog()
    End Sub

    Private Sub PurchaseOrdersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PurchaseOrdersToolStripMenuItem1.Click
        ThisBillMode = CurrentlyIs.PurchaseOrder
        ThisClient = IsA.Supplier
        PurchaseOrder.ShowDialog()
    End Sub

    Private Sub StockStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockStatusToolStripMenuItem.Click
        CurrentItem = SearchIs.Create
        Dim f As New CompanyList
        If CompanyInfo = "" Then Exit Sub
        If Not f.Visible Then f.ShowDialog()
        StockStatus_Branch.ShowDialog()
    End Sub

    Private Sub AppropriateStocksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppropriateStocksToolStripMenuItem.Click
        StockAdjustment.ShowDialog()
    End Sub

    Private Sub StockLedgerSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockLedgerSummaryToolStripMenuItem.Click
        Dim fDt As Form = New DateControl

        If Not fDt.Visible Then fDt.ShowDialog()

        StockLedgerSummary.ShowDialog()
    End Sub

    Private Sub SetOpeningStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetOpeningStockToolStripMenuItem.Click
        TodaysCurrent = StockMode.IsOpening
        StockStatus.ShowDialog()
    End Sub

    Private Sub SetClosingStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetClosingStockToolStripMenuItem.Click
        TodaysCurrent = StockMode.IsClosing
        StockStatus.ShowDialog()
    End Sub

    Private Sub Pp() Handles Panel1.Click

        Exit Sub
        CreateMockTable()
        Exit Sub
        Dim dgvs As New DataGridView
        Dim SiValues As String() = New String() {"biscuits", "candy", "cakes", "soda"}
        dgvs.Columns.Add("", "")
        dgvs.Rows.Add(SiValues)
        slicegGrid2(dgvs)

        Exit Sub
        ThisBillMode = CurrentlyIs.StockTransfer

        xQry("DELETE FROM clCrTXNsPurchases")
        LoadCrVw(ThisBillMode, 100, SerialId, "BRISKET BONE", 50000, 0,,,,,,,, 50, 25000)
        LoadCrVw(ThisBillMode, 100, SerialId, "BRISKET BONE CAMILLA", 40000, 0,,,,,,,, 50, 20000)
        'ThisBillMode = CurrentlyIs.PurchaseOrder
        'LoadCrVw(ThisBillMode, 100,, 5000000,, 0, usr, 4000000, 3000000, 1000000,,,,,)
        'LoadCrVw(ThisBillMode, 100,,, 5000000, 0, "FxCrVw", 5000000, 4000000, 1000000,,,,,)
        'LoadCrVw(ThisBillMode, 10, SerialId, "CASHEW NUTS x10", 4500, 0)
        LoadCrVw("Cy Tech", "Genetrix", Date.Now)

        Exit Sub
        Try
            cCr.Open()
            MsgBox("Open!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Exit Sub

        Dim scrpwd As New SecureString
        For Each v As Char In ""
            scrpwd.AppendChar(v)
            scrpwd.MakeReadOnly()
        Next
        'Dim key As ConsoleKeyInfo
        'Console.Write("enter key here")
        'Do
        'key = Console.ReadKey(True)
        'If CInt(key.Key) >= 65 And CInt(key.Key <= 90) Then
        '     scrpwd.AppendChar(key.KeyChar)
        '      Console.Write("*")
        '   End If
        'Loop While key.Key <> ConsoleKey.Enter
        'Console.WriteLine()
        Try
            Process.Start("Notepad.exe", "MyUser", scrpwd, "MyDomain")
        Catch ex As Win32Exception
            Console.WriteLine(ex.Message)
        Finally
            scrpwd.Dispose()
        End Try
    End Sub

    Private Sub ModifyItemAvatarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyItemAvatarToolStripMenuItem.Click
        _Item = ___Is._SadlyNothing
        Dim f As New AddItemAvatar
        If Not f.Visible Then f.ShowDialog()
    End Sub

    Private Sub RemittancesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemittancesToolStripMenuItem.Click
        Dim f As New Features
        If Not f.Visible Then f.ShowDialog()
    End Sub

End Class