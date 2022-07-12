Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography

Module TableData

    Private cRead As OleDbDataReader

#Region " Table/Field Definition"

    Public Sub DestroyTable(ByVal tblName As String, Optional ByVal c As OleDbConnection = Nothing)
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
        If TableExists(tblName) Then
            With cn
                .Open()
            End With
            Dim cm = New OleDbCommand("DROP TABLE " & tblName, cn)
            cm.ExecuteNonQuery()
            cn.Close()
        End If

    End Sub

    Public Function TableExists(ByVal tblName As String, Optional ByVal c As OleDbConnection = Nothing) As Boolean
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
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

    Function FieldExists(ByVal tblName As String, ByVal fldName As String, Optional ByVal c As OleDbConnection = Nothing) As Boolean
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
        With cn
            .Open()
            Dim dbTbl As New DataTable
            Dim strSql As String = "Select TOP 1 * from " & tblName
            Dim dbAdapater As New OleDbDataAdapter(strSql, cn)
            dbAdapater.Fill(dbTbl)
            Dim i As Integer = dbTbl.Columns.IndexOf(fldName)

            If i = -1 Then
                FieldExists = False
            Else
                FieldExists = True
            End If

            dbTbl.Dispose()
            .Close()
        End With
    End Function

    Public Sub AddColumn(clm As String, tbl As String, Optional ByVal c As OleDbConnection = Nothing)
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
        If FieldExists(tbl, clm) Then Exit Sub

        Dim SQL As String
        Dim objCmd As New OleDbCommand

        SQL = "ALTER TABLE " & tbl & " ADD " & clm & " TEXT(255)"

        With cn
            .Open()

            objCmd = New OleDbCommand(SQL, cn)
            objCmd.ExecuteNonQuery()

            .Close()
        End With

    End Sub

#End Region

#Region " Login"

    Public Sub SetupClientLogin()
        If TableExists("clLogin") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clLogin ([ID] COUNTER, [dtbName] TEXT(255), " &
                                                                        "[dtbSalt] OLEObject, [dtbHash] OLEObject, " &
                                                                        "[dtbClientMode] TEXT(255), [SerialId] TEXT(255), [clStatus] TEXT(255))",
                                      cnn
                                      )
            Dim f As Integer = objCmd.ExecuteNonQuery()

            .Close()
        End With

        Dim csprng As New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(24) {}
        csprng.GetBytes(salt)
        Try
            Dim Sql As String = "INSERT INTO clLogin (dtbName," &
                                                                        "dtbSalt,dtbHash,dtbClientMode," &
                                                                        "SerialId" &
                                                                                    ")" &
                                                                    " VALUES (@dtbName," &
                                                                        "@dtbSalt,@dtbHash,@dtbClientMode," &
                                                                        "@SerialId" &
                                                                                   ")"
            With cnn
                .Open()
            End With
            Dim cm As New OleDbCommand(Sql, cnn)
            With cm
                .Parameters.Add(New OleDbParameter("@dtbName", SqlDbType.Text)).Value = "ADMIN"
                .Parameters.Add(New OleDbParameter("@dtbSalt", SqlDbType.Text)).Value = salt
                .Parameters.Add(New OleDbParameter("@dtbHash", SqlDbType.Text)).Value = Encrypt("ADMIN", salt)
                .Parameters.Add(New OleDbParameter("@dtbClientMode", SqlDbType.Text)).Value = "admin"
                .Parameters.Add(New OleDbParameter("@SerialId", SqlDbType.Text)).Value = "adm_Client_01"
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    cnn.Close()
                End If
            End With

        Catch ex As Exception
            If cnn.State = ConnectionState.Open Then cnn.Close()
        End Try

    End Sub

    Public Sub SetupCompanyData()
        If TableExists("companyData") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE companyData ([ID] COUNTER, [SerialId] TEXT(255), [cmpName] TEXT(255), [cmpLogo] OLEObject, " &
                                                                                                                   "[cmpAddress] TEXT(255), [cmpType] TEXT(255), [cmpWorkersSize] TEXT(255), " &
                                                                                                                   "[cmpPhone] TEXT(255), [cmpSlogan] TEXT(255), [cmpAuthId] TEXT(255))",
                                      cnn
                                      )

            objCmd.ExecuteNonQuery()

            xQry("INSERT INTO companyData (cmpAuthId) VALUES ('ADMIN')")

            .Close()
        End With

    End Sub

#End Region

#Region " Clients/Cashiers"

    Public Sub SetupAccountsDb()
        If TableExists("clAccounts") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clAccounts ([ID] COUNTER, [SerialId] TEXT(255), " &
                                                                                                              "[clName] TEXT(255))",
                                      cnn
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

    Public Sub SetupCategoriesDb()
        If TableExists("clCategories") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clCategories ([ID] COUNTER, [SerialId] TEXT(255), " &
                                                                                                              "[clName] TEXT(255), [clCategory] TEXT(255))",
                                      cnn
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

    Public Sub SetupCurrencyDb()
        If TableExists("clCurrency") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clCurrency ([ID] COUNTER, [SerialId] TEXT(255), " &
                                                                                                              "[clName] TEXT(255), [clUnit] TEXT(255))",
                                      cnn
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

    Public Sub SetupDistributorsDb()
        If TableExists("clDistributors") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clDistributors ([ID] COUNTER, [SerialId] TEXT(255), " &
                                                                                                            "[clName] TEXT(255), [clCompany] TEXT(255), [clAddress] TEXT(255), " &
                                                                                                             "[clPreferredPay] TEXT(255), [clPreferredCurrency] TEXT(255), " &
                                                                                                             "[clPurchasePower] Integer)",
                                      cnn
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

    Public Sub SetupInvoices()
        If TableExists("clInvoices") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clInvoices ([ID] COUNTER, [SerialId] TEXT(255), " &
                                                                                                            "[clInvoiceCode] TEXT(255), [clDate] TEXT(255), [clTime] TEXT(255), " &
                                                                                                             "[clPaymentMethod] TEXT(255), [clAmountExpected] Integer, [clAmountPaid] Integer, " &
                                                                                                             "[clClient] TEXT(255), [clProfitMade] Integer)",
                                      cnn
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

    Public Sub SetupMerchantsDb()
        If TableExists("clMerchants") Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnn
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clMerchants ([ID] COUNTER, [SerialId] TEXT(255), " &
                                                                                                            "[clName] TEXT(255), [clCompany] TEXT(255), [clAddress] TEXT(255), " &
                                                                                                             "[clPreferredPay] TEXT(255), [clPreferredCurrency] TEXT(255), " &
                                                                                                             "[clPurchasePower] Integer)",
                                      cnn
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

    Public Sub SetupProducts()
        If TableExists("clProducts", cnP) Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cnP
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clProducts ([ID] COUNTER, [SerialId] TEXT(255), " &
                                                                                                              "[clName] TEXT(255), [clBarcode] TEXT(255), [clPrice] Integer, " &
                                                                                                              "[clQty] Integer, [clCurrency] TEXT(255), [clDiscount] Integer, " &
                                                                                                              "[clMerchantId] TEXT(255), [clCategoryId] TEXT(255), [clPurchaseId] TEXT(255), [clSalesId] TEXT(255), " &
                                                                                                              "[clUnit] TEXT(255), [clUnitCost] Integer)",
                                      cnP
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

    Public Sub SetupSales()
        If TableExists("clSales", cns) Then Exit Sub

        Dim objCmd As New OleDbCommand

        With cns
            .Open()
            objCmd = New OleDbCommand("CREATE TABLE clSales ([ID] COUNTER, [clSalesInvoice] TEXT(255), [clSalesMerchant] TEXT(255), [clDate] TEXT(255), " &
                                                                                                              "[clTime] TEXT(255),[clProduct] TEXT(255), [clQuantity] Integer, [clMerchant] TEXT(255), " &
                                                                                                              "[clPrice] Integer, [clDiscount] Integer, " &
                                                                                                              "[clPayMeans] TEXT(255), [clCategory] TEXT(255), [clCost] Integer)",
                                      cns
                                      )

            objCmd.ExecuteNonQuery()
            .Close()
        End With

    End Sub

#End Region

End Module
