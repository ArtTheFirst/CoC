Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports Npgsql
Imports NpgsqlTypes

Module TableData

    Private cRead As NpgsqlDataReader

#Region " Table/Field Definition"

    Public Sub DestroyTable(ByVal tblName As String, Optional ByVal s As NpgsqlConnection = Nothing)
        Dim cn As NpgsqlConnection = IIf(s Is Nothing, c, s)
        Try
            xQry("DROP TABLE " & tblName, cn)
            write_Log("Drop Table Success!")
        Catch ex As Exception
            write_Error("Drop table error; Maybe does not exist", ex.Message)
        End Try
    End Sub

    Public Function TableExists(ByVal tblName As String, Optional ByVal s As NpgsqlConnection = Nothing) As Boolean
        Dim cn As NpgsqlConnection = IIf(s Is Nothing, c, s)
        With cn
            If Not .State = ConnectionState.Open Then .Open()

            Dim restrictions(3) As String
            restrictions(2) = tblName
            Dim dbTbl As DataTable = .GetSchema("Tables", restrictions)
            If dbTbl.Rows.Count = 0 Then
                TableExists = False
            Else
                TableExists = True
            End If
            dbTbl.Dispose()

            .Close()
        End With

    End Function

    Function FieldExists(ByVal tblName As String, ByVal fldName As String, Optional ByVal s As NpgsqlConnection = Nothing) As Boolean
        Dim fXst As Boolean = False
        Dim cn As NpgsqlConnection = IIf(s Is Nothing, c, s)
        Try
            With cn
                If Not .State = ConnectionState.Open Then .Open()
                Dim dbTbl As New DataTable
                Dim strSql As String = "Select TOP 1 * from " & tblName
                Dim dbAdapater As New NpgsqlDataAdapter(strSql, cn)
                dbAdapater.Fill(dbTbl)
                Dim i As Integer = dbTbl.Columns.IndexOf(fldName)

                If i = -1 Then
                    fXst = False
                Else
                    fXst = True
                End If
                If Not .State = ConnectionState.Closed Then .Close()
                dbTbl.Dispose()
            End With
        Catch ex As Exception
            fXst = False
        Finally
            If Not cn.State = ConnectionState.Closed Then cn.Close()
            FieldExists = fXst
        End Try
    End Function

    Public Sub AddColumn(clm As String, tbl As String, fieldtype As String, Optional ByVal s As NpgsqlConnection = Nothing)
        Dim cn As NpgsqlConnection = IIf(s Is Nothing, c, s)
        If FieldExists(tbl, clm, cn) Then Exit Sub
        Dim sql As String
        Dim objCmd As New NpgsqlCommand

        sql = "ALTER TABLE " & tbl & " ADD " & clm & Space(1) & fieldtype
        Try
            With cn
                .Open()

                objCmd = New NpgsqlCommand(sql, cn)
                objCmd.ExecuteNonQuery()

                .Close()
            End With
        Catch ex As Exception
            ' write_Error("Cannot create field; " & ex.Message)
        End Try

    End Sub

    Public Sub AlterColumn(clm As String, tbl As String, fieldtype As String, Optional ByVal s As NpgsqlConnection = Nothing)
        Dim cn As NpgsqlConnection = IIf(s Is Nothing, c, s)
        Try
            xQry("ALTER TABLE " & tbl & " ALTER COLUMN " & clm & " TYPE " & fieldtype, cn)
            write_Log("Column modify Success!")
        Catch ex As Exception
            write_Error("Column modify error; Maybe already exists", ex.Message)
        End Try
    End Sub

#End Region

    Public Sub createSettingsTbl()
        If TableExists("settingsTbl", c) Then Exit Sub

        Dim objCmd As New NpgsqlCommand

        With c
            .Open()
            objCmd = New NpgsqlCommand("CREATE TABLE settingsTbl(cName varchar(255),cScope varchar(255))",
                                      c
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

        loadSetting("CompanyName", "")
        loadSetting("CompanyAddress", "")
        loadSetting("CompanyLogo", "")
        loadSetting("CompanyPhone", "")
        loadSetting("CompanyType", "")
        loadSetting("CompanyEmail", "")
        loadSetting("AdminLimit", 2)
        loadSetting("ClientLimit", 1)
        loadSetting("AllowSubAdmin", Cnfg.InActv)
        loadSetting("subAdminModifyCashier", Cnfg.InActv)
        loadSetting("subAdminModifyInvoices", Cnfg.InActv)
        loadSetting("subAdminModifyOwnKey", Cnfg.InActv)
        loadSetting("subAdminModifyCompany", Cnfg.InActv)
        loadSetting("subAdminModifySecurity", Cnfg.InActv)
        loadSetting("subAdminCategoryControl", Cnfg.InActv)
        loadSetting("subAdminReportControl", Cnfg.InActv)
        loadSetting("subAdminBackupControl", Cnfg.InActv)
        loadSetting("subAdminModifyFeatures", Cnfg.InActv)
        loadSetting("subAdminExportReports", Cnfg.InActv)
        loadSetting("PerformBackups", Cnfg.InActv)
        loadSetting("backupTime", "00:00")
        loadSetting("lastBackup", "")
        loadSetting("backupModeAuto", Cnfg.InActv)
        loadSetting("backupPath", "")
        loadSetting("IsFirstTimeUse", Cnfg.Actv)
        loadSetting("LicenseKey", "")
        loadSetting("LicenseDate", "")
        loadSetting("LicenseMode", Cnfg.LicenseEvaluated)

    End Sub
    Sub loadSetting(_ScopeName, _Scope)
        If Not c.State = ConnectionState.Open Then c.Open()
        Dim cm As New NpgsqlCommand("INSERT INTO settingsTbl " &
                                                                "(cName,cScope) VALUES (@cName,@cScope)",
                                   c)
        With cm
            .Parameters.Add(New NpgsqlParameter("@cName", SqlDbType.VarChar)).Value = _ScopeName
            .Parameters.Add(New NpgsqlParameter("@cScope", SqlDbType.VarChar)).Value = _Scope
            .ExecuteNonQuery()
        End With
        If Not c.State = ConnectionState.Closed Then c.Close()
    End Sub

#Region " Login"

    Public Sub SetupClientLogin()
        If TableExists("cocLogin", c) Then Exit Sub

        Try

            Dim sql As String = "CREATE TABLE cocLogin(SerialId varchar(255)," &
                                                                                "cocName varchar(255),cocHash bytea)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            cmd.Dispose()

        Catch ex As NpgsqlException

        End Try

        Dim r As String = ""
        Try
            r = sQry("SerialId", "cocLogin", "cocName", "ADMIN", NpgsqlDbType.Varchar)
            'r = Qry("SELECT SerialId FROM cocLogin WHERE cocName='ADMIN'")
        Catch ex As Exception
            r = ""
        End Try
        If Not r = "" Then Exit Sub

        Dim salt As Byte() = Convert.FromBase64String(LaptopInABackpack)

        Try
            Dim sql As String = "INSERT INTO cocLogin (SerialId," &
                                                                                "cocName," &
                                                                                "cocHash" &
                                                                                    ")" &
                                                                    " VALUES (@SerialId," &
                                                                                   "@cocName," &
                                                                                   "@cocHash" &
                                                                                   ")"
            With c
                If Not .State = ConnectionState.Open Then .Open()
            End With
            Dim cm As New NpgsqlCommand(sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = serializers
                .Parameters.Add(New NpgsqlParameter("@cocName", NpgsqlDbType.Varchar)).Value = "ADMIN"
                .Parameters.Add(New NpgsqlParameter("@cocHash", NpgsqlDbType.Bytea)).Value = Encrypt("ADMIN", salt)

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    If Not c.State = ConnectionState.Closed Then c.Close()
                End If

                salt = Nothing

                .Dispose()

            End With

        Catch ex As Exception
            write_Error(ex.Message, "login secure setup")
            If c.State = ConnectionState.Open Then c.Close()
        End Try

    End Sub
    Private serializers As String
    Public Sub SetupSubAccountLog()
        If TableExists("clLogs", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clLogs(SerialId varchar(255),clName varchar(255)," &
                                                                "clClientMode integer,clCanOperate integer,clLastLogin varchar(255),clLastLogout varchar(255)," &
                                                                "clLogDate date,clCurrentStatus integer," &
                                                                "clCreationDate timestamp,clLastModifyDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            cmd.Dispose()

        Catch ex As Exception

        End Try
        Dim r As String = ""
        Try
            r = sQry("SerialId", "clLogs", "clName", "ADMIN", NpgsqlDbType.Varchar)
            'r = Qry("SELECT SerialId FROM clLogs WHERE clName='ADMIN'")
        Catch ex As Exception
            r = ""
        End Try
        If Not r = "" Then Exit Sub
        Try
            Dim sql As String = "INSERT INTO clLogs (SerialId,clName," &
                                                                "clClientMode,clCanOperate,clLastLogin,clLastLogout," &
                                                                "clLogDate,clCurrentStatus," &
                                                                "clCreationDate" &
                                                                                   ")" &
                                                                   " VALUES (@SerialId,@clName," &
                                                                    "@clClientMode,@clCanOperate,@clLastLogin,@clLastLogout," &
                                                                            "@clLogDate,@clCurrentStatus," &
                                                                                  "@clCreationDate)"
            With c
                If Not .State = ConnectionState.Open Then .Open()
            End With
            Dim cm As NpgsqlCommand = New NpgsqlCommand(sql, c)
            Dim tD As Date = New DateTime()
            With Date.Now
                tD = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cm
                .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = serializers
                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = "ADMIN"
                .Parameters.Add(New NpgsqlParameter("@clClientMode", NpgsqlDbType.Integer)).Value = AcctAdmin
                .Parameters.Add(New NpgsqlParameter("@clCanOperate", NpgsqlDbType.Integer)).Value = IsApproved
                .Parameters.Add(New NpgsqlParameter("@clLastLogin", NpgsqlDbType.Varchar)).Value = ""
                .Parameters.Add(New NpgsqlParameter("@clLastLogout", NpgsqlDbType.Varchar)).Value = ""
                .Parameters.Add(New NpgsqlParameter("@clLogDate", NpgsqlDbType.Date)).Value = tD.Date
                .Parameters.Add(New NpgsqlParameter("@clCurrentStatus", NpgsqlDbType.Integer)).Value = StatusIsSuspended
                .Parameters.Add(New NpgsqlParameter("@clCreationDate", NpgsqlDbType.Timestamp)).Value = tD

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    If Not c.State = ConnectionState.Closed Then c.Close()
                End If

                .Dispose()

            End With

        Catch ex As Exception
            write_Error(ex.Message, "login setup; logs")
            If c.State = ConnectionState.Open Then c.Close()
        End Try

    End Sub

    Public Sub SetupSubAccountLog_Records()
        If TableExists("clLogsHistory", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clLogsHistory(clName varchar(255)," &
                                                                "clLogEntryDate date,clLogEntry time,clLogNote varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            cmd.Dispose()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupContacts()
        If TableExists("clContacts", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clContacts(SerialId varchar(255),clName varchar(255),clLogo varchar(255)," &
                                                                                                                   "clAddress varchar(255),clEmail varchar(255)," &
                                                                                                                   "clPhone varchar(255)," &
                                                                "clCreationDate timestamp,clLastModifyDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            cmd.Dispose()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupCompanyData()
        If TableExists("companyData", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE companyData(SerialId varchar(255),cmpName varchar(255),cmpLogo bytea," &
                                                                                                                   "cmpAddress varchar(255),cmpType varchar(255),cmpEmail varchar(255)," &
                                                                                                                   "cmpPhone varchar(255),cmpBranchInfo varchar(255)," &
                                                                "clCreationDate timestamp,clLastModifyDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            cmd.Dispose()

            xQry("INSERT INTO companyData (SerialId,cmpName,cmpBranchInfo) VALUES ('HQ0001','Company','HQ')")

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region " Features"

    Public Sub SetupBranch(CmpCd As String)
        If TableExists(CmpCd, cItems) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE " & CmpCd & "(SerialId varchar(255),clName varchar(255)," &
                                                                                                "clQty integer,clPrice bigint)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cItems)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try


    End Sub

    Public Sub SetupCategoriesDb()
        If TableExists("clCategories", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clCategories(SerialId varchar(255),clName varchar(255),clCategory varchar(255)," &
                                                                "clCreationDate timestamp,clLastModifyDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupCurrencyDb()
        If TableExists("clCurrency", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clCurrency(SerialId varchar(255),clName varchar(255),clUnit varchar(255)," &
                                                                "clCreationDate timestamp,clLastModifyDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupDiscountables()
        If TableExists("clDiscountables", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clDiscountables(SerialId varchar(255),clName varchar(255)," &
                                                                                                "clQty integer,clAmount bigint," &
                                                                                                "clStartDate timestamp,clEndDate timestamp," &
                                                                "clCreationDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Discountables setup")
        End Try

    End Sub

    Public Sub SetupMeasuringUnits()
        If TableExists("clMeasuringUnits", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clMeasuringUnits(SerialId varchar(255),clName varchar(255)," &
                                                                "clCreationDate timestamp,clLastModifyDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupPaymentMeans()
        If TableExists("clPayMethods", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clPayMethods(SerialId varchar(255),clName varchar(255)," &
                                                                "clCreationDate timestamp,clLastModifyDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            '3043700123812
        End Try

    End Sub

#End Region

#Region " Transactions"

    Public Sub SetupClientsDb()
        If TableExists("clClients", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clClients(SerialId varchar(255),clName varchar(255)," &
                                                                                    "clCompany varchar(255),clAddress varchar(255)," &
                                                                                    "clIsCreditClient integer,clCreditLimit bigint,clOutstanding bigint," &
                                                                                    "clLastPurchaseTXN bigint,clLastSaleTXN bigint," &
                                                                                    "clLastPurchase timestamp,clLastSale timestamp," &
                                                                                    "clPhoneH integer,clPhoneW integer,clFax integer,clEmail varchar(255)," &
                                                                                    "clCreationDate timestamp,clLastModifyDate timestamp," &
                                                                                    "clClientCategory integer)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Clients setup")
        End Try

    End Sub

    Public Sub SetupInvoiceOrders()
        If TableExists("clInvoiceOrders", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clInvoiceOrders(SerialId varchar(255),clInvoiceCode varchar(255)," &
                                                                                                             "clCreationDate timestamp," &
                                                                                                             "clPaymentMethod varchar(255)," &
                                                                                                             "clQty integer,clAmountExpected bigint,clAmountPaid bigint," &
                                                                                                             "clUser varchar(255),clCustomer varchar(255)," &
                                                                                                             "clType varchar(255),clSeries varchar(255)," &
                                                                                                             "clStatus integer," &
                                                                                                              "clModifDate date,clModifUser varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Invoices setup")
        End Try

    End Sub

    Public Sub SetupInvoiceOutstandings()
        If TableExists("clInvoiceToPay", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clInvoiceToPay(clSessionId varchar(255)," &
                                                                                                  "clTXNInvoiceCode varchar(255),clInvoiceCode varchar(255),clLogInfo timestamp," &
                                                                                     "clAmountExpected bigint,clClient varchar(255),clPaymentMethod varchar(255),clStatus varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupInvoices()
        If TableExists("clInvoices", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clInvoices(SerialId varchar(255),clInvoiceCode varchar(255),clCreationDate timestamp," &
                                                                                                             "clPaymentMethod varchar(255)," &
                                                                                                             "clQty integer,clAmountExpected bigint,clAmountPaid bigint,clDiscount bigint," &
                                                                                                             "clAmountExpectedUpdate bigint," &
                                                                                                             "clPaymentMethodUpdate varchar(255)," &
                                                                                                             "clQtyUpdate integer,clAmountPaidUpdate bigint,clDiscountUpdate bigint," &
                                                                                                             "clUser varchar(255),clClient varchar(255)," &
                                                                                                              "clType varchar(255),clSeries varchar(255),clBillDate date," &
                                                                                                              "clModifDate timestamp," &
                                                                                                              "clModifUser varchar(255),clModifClient varchar(255)," &
                                                                                                              "clActivityStatus integer,clReturnInitiated integer)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Invoices setup")
        End Try

    End Sub

    Public Sub SetupInvoicesReturned()
        If TableExists("clInvoiceReturned", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clInvoiceReturned(SessionId varchar(255),clInvoiceCode varchar(255),clDate timestamp," &
                                                                                                             "clClient varchar(255)," &
                                                                                                             "clQty integer,clReturnTotal integer," &
                                                                                                             "clInvoiceReturnAmt bigint,clDiscount bigint," &
                                                                                                             "clQtyUpdate integer,clReturnTotalUpdate integer," &
                                                                                                             "clInvoiceReturnAmtUpdate bigint,clDiscountUpdate bigint," &
                                                                                                              "clSeries varchar(255)," &
                                                                                                              "clUser varchar(255),clLastModifier varchar(255)," &
                                                                                                              "clActivityStatus integer," &
                                                                                                              "clInvoicePayOut bigint," &
                                                                                                              "clInvoicePayOutUpdate bigint," &
                                                                                                              "clModifDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql,
                       cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Invoice Return setup")
        End Try

    End Sub

    Public Sub SetupItemProxy()
        If TableExists("clItmPrx", cItems) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clItmPrx(SerialId varchar(255),clBarcode varchar(255),clName varchar(255),clPrice bigint)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cItems)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "barcodes setup")
        End Try

    End Sub

    Public Sub SetupItems()
        If TableExists("clItems", cItems) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clItems(SerialId varchar(255),clName varchar(255),clBarcode varchar(255),clPrice bigint," &
                                                                                                              "clQty integer,clCurrency varchar(255),clDiscount integer," &
                                                                                                              "clCustomerId varchar(255),clCategoryId varchar(255),clPurchaseId varchar(255)," &
                                                                                                              "clUnit varchar(255),clUnitCost bigint,clItemExpiry timestamp,clDate timestamp,clVAT integer," &
                                                                                                              "clVATInclusive integer,clWeighable integer,clMargin integer,clWeighableQty integer," &
                                                                                                              "LastTXNTXNs timestamp,LastTXNSupplies timestamp," &
                                                                                                              "clAccountId varchar(255),clAlertQty integer,clSellOutOfStock integer," &
                                                                                                              "clDocFile bytea,clModifDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cItems)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Items setup")
        End Try

    End Sub

    Public Sub SetupItemsDetails()
        If TableExists("clItemsDetails", cItems) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clItemsDetails(SerialId varchar(255),clAvatar bytea,clLastModif varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cItems)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            cmd.Dispose()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupItemsHistory()
        If TableExists("clItemsHistory", cItems) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clItemsHistory(SerialId varchar(255),clName varchar(255)," &
                                                                                                "clQty integer,clPrice bigint," &
                                                                                                "clCId varchar(255)," &
                                                                                                "clDate date,clTime time)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cItems)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupItemsMeasurements()
        If TableExists("clItemsMeasurements", cItems) Then Exit Sub
        Try
            Dim sql As String = "CREATE TABLE clItemsMeasurements(clItemId varchar(255)," &
                                                                                                            "clName varchar(255)," &
                                                                                                            "clEquivQty integer," &
                                                                                                            "clUnit varchar(255)," &
                                                                                                            "clUnitQty integer," &
                                                                                                            "clUnitPrice bigint," &
                                                                                                            "clUnitVAT integer," &
                                                                                                            "clModifDate date" &
                                                                                                                   ")"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cItems)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Items setup / Measurements")
        End Try

    End Sub

    Public Sub SetupMerchantsDb()
        If TableExists("clCustomers", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clCustomers(SerialId varchar(255),clName varchar(255),clCompany varchar(255),clAddress varchar(255)," &
                                                                                           "clPreferredPay varchar(255),clPreferredCurrency varchar(255),clPurchasePower bigint" &
                                                                                           ",clPhoneH integer,clPhoneW integer,clFax integer,clEmail varchar(255),clAllowPurchaseLimit integer)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Clients setup")
        End Try

    End Sub

    Public Sub SetupPurchaseOrder()
        If TableExists("clPurchaseOrder", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clPurchaseOrder(clItemId varchar(255),clSerialId varchar(255)," &
                                                                                                              "clOrderInvoice varchar(255),clClient varchar(255),clDate date," &
                                                                                                              "clTime varchar(255),clItem varchar(255),clQuantity integer,clSupplier varchar(255)," &
                                                                                                              "clCategory varchar(255),clCost bigint)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub
    Public Sub SetupPurchaseReturns()
        If TableExists("clPurchaseReturns", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clPurchaseReturns(clTransferInvoiceCode varchar(255)," &
                                                                                                                 "clDate date,clTime time," &
                                                                                                                 "clItemId varchar(255),clItem varchar(255)," &
                                                                                                                 "clPurchasedQuantity integer,clPurchaseDiscount bigint,clPurchasedRate bigint," &
                                                                                                                 "clReturnedQuantity integer,clReturnDiscount bigint,clReturnedRate bigint," &
                                                                                                                 "clUser varchar(255),clModifUser varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub setupPurchases()
        If TableExists("clPurchases", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clPurchases(clSessionId varchar(255),clSessionType varchar(255)," &
                                                                                                              "clOrderInvoice varchar(255),clCreationDate timestamp," &
                                                                                                              "clItem varchar(255),clQuantity integer," &
                                                                                                              "clFreeQty integer,clMarginPrcnt integer,clMRP integer," &
                                                                                                              "clSupplier varchar(255)," &
                                                                                                              "clCost bigint,clPrice bigint,clDiscount bigint," &
                                                                                                              "clCategory varchar(255),clUser varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Purchases setup")
        End Try

    End Sub

    Public Sub SetupStockStatus()
        Dim FilteredString As String = Nothing
        Try
            FilteredString = JournalDate.ToShortDateString.Replace("/", "").Replace("-", "").Replace("=", "").Replace("'", "")
        Catch ex As Exception
        End Try
        Dim TbNm As String = String.Concat("clStockStatus", FilteredString)

        If TableExists(TbNm, cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE " & TbNm & "(clSessionId varchar(255),clDate date," &
                                                                                         "clItemId varchar(255),clName varchar(255)," &
                                                                                          "clCost bigint,clPrice bigint," &
                                                                                          "clStockOpening integer,clStockOpeningAmt bigint," &
                                                                                          "clStockTransfer integer,clStockTransferAmt bigint," &
                                                                                          "clTXNs integer,clTXNsAmt bigint,clStockPurchase integer,clStockPurchaseAmt bigint," &
                                                                                          "clTXNsReturns integer,clTXNsReturnsAmt bigint,clPurchaseReturns integer,clPurchaseReturnsAmt bigint," &
                                                                                          "clTXNsOrders integer,clTXNsOrdersAmt bigint,clPurchaseOrders integer,clPurchaseOrdersAmt bigint," &
                                                                                          "clStockClosing integer,clStockClosingAmt bigint" &
                                                                                          ")"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            InitiateStocks(True)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub SetupStockTransfer()
        If TableExists("clStockTransfer", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clStockTransfer(clItemId varchar(255),clTransferInvoiceCode varchar(255)," &
                                                                                                             "clDate date,clTime time," &
                                                                                                             "clItem varchar(255),clQuantity integer," &
                                                                                                              "clCustomer varchar(255)," &
                                                                                                              "clPrice bigint," &
                                                                                                              "clUser varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupStockUpdateStatus()
        If TableExists("clStockUpdateHistory", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clStockUpdateHistory(clItemId varchar(255),clItem varchar(255)," &
                                                                                                             "clDate date,clTime time," &
                                                                                                             "clPreviousQty integer,clNewQty integer,clPrice bigint," &
                                                                                                              "clUser varchar(255),clTXNType varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Stock Update setup")
        End Try

    End Sub

    Public Sub SetupSuppliersDb()
        If TableExists("clSuppliers", c) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clSuppliers(SerialId varchar(255),clName varchar(255),clCompany varchar(255),clAddress varchar(255)," &
                                                                                           "clPreferredPay varchar(255),clPreferredCurrency varchar(255),clOutstanding bigint" &
                                                                                           ",clPhoneH integer,clPhoneW integer,clFax integer,clEmail varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, c)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "Suppliers setup")
        End Try

    End Sub

    Public Sub SetupTXNs()
        If TableExists("clTXNs", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clTXNs(clItemId varchar(255)," &
                                                                                              "clTXNsInvoice varchar(255),clSeries varchar(255)," &
                                                                                              "clCreation timestamp,clItem varchar(255),clQuantity integer,clClient varchar(255)," &
                                                                                              "clPrice bigint,clDiscount bigint," &
                                                                                              "clPayMeans varchar(255),clCategory varchar(255),clCost bigint,clUser varchar(255)," &
                                                                                              "clCreationModif timestamp,clQuantityModif integer,clClientModif varchar(255)," &
                                                                                              "clPriceModif bigint,clDiscountModif bigint," &
                                                                                              "clPayMeansModif varchar(255),clUserModif varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "TXNs setup")
        End Try

    End Sub

    Public Sub SetupTXNsModified()
        If TableExists("clTXNsModified", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clTXNsModified(clSessionId varchar(255)," &
                                                                                             "clTXNsInvoice varchar(255),clTXNsClient varchar(255)," &
                                                                                             "clCreation timestamp,clItem varchar(255),clQuantity integer,clClient varchar(255)," &
                                                                                             "clPrice bigint,clDiscount bigint," &
                                                                                             "clPayMeans varchar(255),clCategory varchar(255),clCost bigint,clUser varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception
            'write_Error(ex.Message, "TXNs setup")
        End Try

    End Sub

    Public Sub SetupTXNsOrder()
        If TableExists("clTXNsOrder", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clTXNsOrder(clItemId varchar(255)," &
                                                                                                              "clOrderInvoice varchar(255),clDate date," &
                                                                                                              "clTime varchar(255),clItem varchar(255),clQuantity integer," &
                                                                                                              "clCustomer varchar(255)," &
                                                                                                              "clPrice bigint," &
                                                                                                              "clUser varchar(255))"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub SetupTXNsReturns()
        If TableExists("clTXNsReturns", cTXNs) Then Exit Sub

        Try
            Dim sql As String = "CREATE TABLE clTXNsReturns(clTransferInvoiceCode varchar(255)," &
                                                                                                                 "clDate timestamp," &
                                                                                                                 "clItemId varchar(255),clItem varchar(255)," &
                                                                                                                 "clSoldQuantity integer,clSoldDiscount bigint,clSoldPrice bigint," &
                                                                                                                 "clReturnedQuantity integer,clReturnedDiscount bigint,clReturnedPrice bigint," &
                                                                                                                 "clUser varchar(255),clModifUser varchar(255)," &
                                                                                                                 "clModifDate timestamp)"
            Dim cmd As NpgsqlCommand = New NpgsqlCommand(sql, cTXNs)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

        Catch ex As Exception

        End Try

    End Sub

#End Region

#Region " Stored Procedures"

    Public Sub CreateMockTable()
        If TableExists("tblSPExample", c) Then Exit Sub
        Dim d As String = ControlChars.Quote
        Dim q As String = String.Concat(d, "definenewtables", d)
        Try
            Dim sql As String = "CREATE OR REPLACE PROCEDURE public." & q & "()
                                            LANGUAGE 'plpgsql'
                                            AS $BODY$CREATE TABLE clnuisancedotcomm(serialId varchar(255),clnaming varchar(255))$BODY$;"

            Dim Asql = "CREATE OR REPLACE PROCEDURE DefineTable " &
                                            "LANGUAGE 'plpgsql' " &
                                            "AS CREATE TABLE clnuisancedotcomm(serialId varchar(255),clnaming varchar(255))"

            MsgBox(Asql)

            Dim cmd As New NpgsqlCommand
            cmd.Connection = c
            cmd.CommandText = Asql
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()

            MsgBox(cmd.Connection.FullState.ToString)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Stored Procedure Test")
            write_Error(ex.Message, "Stored Procedure Test")
        End Try

    End Sub

    Dim pSql As String = Nothing
    Sub CreateTables()
        pSql = "CREATE PROCEDURE " &
                                            "CreateTable " &
                                            "AS " &
                                            "BEGIN " &
                                            "CREATE TABLE " &
                                            "tblSPExample (StudentID int IDENTITY(1,1), Name varchar(50) NOT NULL, Surname varchar(50) NOT NULL, Age int NOT NULL, " &
                                            "PRIMARY KEY (StudentID)) " &
                                            "END"
    End Sub

    Sub CreateInserts()
        pSql = "CREATE PROCEDURE " &
                            "InsertDataIntoTable @Name varchar(50), @Surname varchar(50), @Age int " &
                         "AS " &
                         "BEGIN " &
                            "INSERT INTO tblSPExample(Name, Surname, Age) VALUES ( @Name, @Surname, @Age) " &
                            "END"
    End Sub

    Sub CreateUpdates()
        pSql = "CREATE PROCEDURE " &
                            "UpdateDataInsideTable @Name varchar(50), @Surname varchar(50), @Age int, @StudentID int " &
                          "AS " &
                          "BEGIN " &
                            "UPDATE tblSPExample SET Name =  @Name, Surname = @Surname, Age = @Age WHERE StudentID = @StudentID " &
                            "END"
    End Sub

    Sub CreateDeletes()
        pSql = "CREATE PROCEDURE " &
            "DeleteDataFromTable @StudentID int " &
            "AS " &
            "BEGIN " &
            "DELETE FROM tblSPExample " &
            "WHERE StudentID = @StudentID " &
            "END"
    End Sub

    Sub CreateDrops()
        pSql = "CREATE PROCEDURE " &
                         "DropTable " &
                         "AS " &
                         "BEGIN " &
                         "DROP TABLE tblSPExample " &
                         "END"
    End Sub

#End Region

End Module
