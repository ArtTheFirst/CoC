Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Module _Configurations
    Public Function StockTable() As String
        Dim FilteredString As String = Nothing
        Try
            FilteredString = JournalDate.ToShortDateString.Replace("/", "").Replace("-", "").Replace("=", "").Replace("'", "")
        Catch ex As Exception
        End Try
        Dim TbNm As String = String.Concat("clStockStatus", FilteredString)
        StockTable = TbNm
    End Function
    Public Enum IsNow
        _Complete
        ShortOfBeingComplete
    End Enum
    Public Function StockAppropriation(Optional ByVal Opt As String = "") As IsNow
        Dim r As IsNow = IsNow.ShortOfBeingComplete
        Try
            Dim Sql As String = Nothing
            If Opt = "" Then
                Sql = "UPDATE clItems SET clQty=@clQty"
            Else
                Sql = "UPDATE clItems SET clQty=@clQty WHERE SerialId='" & Opt & "'"
            End If

            With cItems
                .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, cItems)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = 0
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    r = IsNow._Complete
                    cItems.Close()
                End If
            End With

        Catch ex As Exception
            r = IsNow.ShortOfBeingComplete
            write_Error(ex.Message)
            'MsgBox(ex.Message)
            If cItems.State = ConnectionState.Open Then cItems.Close()
        End Try
        StockAppropriation = r
    End Function

    Public Sub InitiateStocks(Optional AsNew As Boolean = False)
        Dim SSi As String = SerialId()

        Dim Opt As String = IIf(AsNew, ",clStockOpening,clStockOpeningAmt", "")

        Dim OptParam As String = IIf(AsNew, ",@clStockOpening,@clStockOpeningAmt", "")

        Dim TbNm As String = StockTable()
        Dim SqlUpdt As String = "INSERT INTO " & TbNm & " (clSessionId,clDate," &
                                                                                         "clItemId,clName," &
                                                                                          "clStockTransfer,clStockTransferAmt," &
                                                                                          "clTXNs,clTXNsAmt,clStockPurchase,clStockPurchaseAmt," &
                                                                                          "clTXNsReturns,clTXNsReturnsAmt,clPurchaseReturns,clPurchaseReturnsAmt," &
                                                                                          "clTXNsOrders,clTXNsOrdersAmt,clPurchaseOrders,clPurchaseOrdersAmt," &
                                                                                          "clStockClosing,clStockClosingAmt," &
                                                                                          "clCost,clPrice" & Opt & ")" &
                                                                               "VALUES (@clSessionId,@clDate,@" &
                                                                                         "clItemId,@clName,@" &
                                                                                          "clStockTransfer,@clStockTransferAmt,@" &
                                                                                          "clTXNs,@clTXNsAmt,@clStockPurchase,@clStockPurchaseAmt,@" &
                                                                                          "clTXNsReturns,@clTXNsReturnsAmt,@clPurchaseReturns,@clPurchaseReturnsAmt,@" &
                                                                                          "clTXNsOrders,@clTXNsOrdersAmt,@clPurchaseOrders,@clPurchaseOrdersAmt,@" &
                                                                                          "clStockClosing,@clStockClosingAmt," &
                                                                                          "@clCost,@clPrice" & OptParam & ")"
        Try
            Dim tbl As DataTable = xRead("SELECT SerialId,clName,clQty,clPrice,clUnitCost FROM clItems", "clItems", cItems)
            For Each row As DataRow In tbl.Rows
                With cTXNs
                    If Not .State = ConnectionState.Open Then .Open()
                End With
                Dim cm As New NpgsqlCommand(SqlUpdt, cTXNs)
                With cm
                    .Parameters.Add(New NpgsqlParameter("@clSessionId", NpgsqlDbType.Varchar)).Value = SSi
                    Dim d As Date = New Date
                    With JournalDate
                        d = New Date(.Year, .Month, .Day)
                    End With
                    .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = d
                    .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = row(0).ToString
                    .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = row(1).ToString
                    .Parameters.Add(New NpgsqlParameter("@clStockTransfer", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clStockTransferAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clTXNs", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clTXNsAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clStockPurchase", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clStockPurchaseAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clTXNsReturns", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clTXNsReturnsAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clPurchaseReturns", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clPurchaseReturnsAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clTXNsOrders", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clTXNsOrdersAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clPurchaseOrders", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clPurchaseOrdersAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clStockClosing", NpgsqlDbType.Integer)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clStockClosingAmt", NpgsqlDbType.Bigint)).Value = 0
                    .Parameters.Add(New NpgsqlParameter("@clCost", NpgsqlDbType.Bigint)).Value = row(4)
                    .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = row(3)
                    If AsNew Then
                        Dim Qty As Decimal = row(2)
                        Dim QtyAmt As Decimal = Qty * row(3)
                        .Parameters.Add(New NpgsqlParameter("@clStockOpening", NpgsqlDbType.Integer)).Value = Qty
                        .Parameters.Add(New NpgsqlParameter("@clStockOpeningAmt", NpgsqlDbType.Bigint)).Value = QtyAmt
                    End If
                    With cTXNs
                        If Not .State = ConnectionState.Open Then .Open()
                    End With
                    Dim fSnd As Integer = .ExecuteNonQuery()
                    If fSnd > 0 Then
                        cItems.Close()
                        cTXNs.Close()
                    End If
                End With
            Next
        Catch ex As Exception
            cItems.Close()
            cTXNs.Close()
            write_Error(ex.Message)
        End Try

    End Sub

    Public Sub UpdateClosing(PrdId As String, TXNDetail As Integer)

        Dim CsP As Integer = 0
        Dim CspAmt As Long = 0
        Try
            CsP = Qry("SELECT clQty FROM clItems WHERE SerialId='" & PrdId & "'", cItems)
            CspAmt = Qry("SELECT clPrice FROM clItems WHERE SerialId='" & PrdId & "'", cItems)
        Catch ex As Exception
            CsP = 0
            CspAmt = 0
        End Try

        Dim FigUpdtAmt As Long = CsP * CspAmt

        Dim Sql As String = Nothing
        Dim TXNType As String = Nothing
        If ThisBillMode = CurrentlyIs.TXNs Then
            TXNType = "clTXNs"
        ElseIf ThisBillMode = CurrentlyIs.Purchase Then
            TXNType = "clStockPurchase"
        ElseIf ThisBillMode = CurrentlyIs.StockTransfer Then
            TXNType = "clStockTransfer"
        ElseIf ThisBillMode = CurrentlyIs.TXNsReturns Then
            TXNType = "clTXNsReturns"
        ElseIf ThisBillMode = CurrentlyIs.PurchaseReturns Then
            TXNType = "clPurchaseReturns"
        ElseIf ThisBillMode = CurrentlyIs.TXNsOrder Then
            TXNType = "clTXNsOrders"
        ElseIf ThisBillMode = CurrentlyIs.PurchaseOrder Then
            TXNType = "clPurchaseOrders"
        End If

        Dim TbNm As String = StockTable()

        Dim UpdtFig As Long = 0
        Try
            UpdtFig = Qry("SELECT " & TXNType & " FROM " & TbNm & " WHERE clItemId='" & PrdId & "'", cTXNs)
        Catch ex As Exception
            UpdtFig = 0
        End Try
        Dim fUpdate As Long = UpdtFig + TXNDetail

        Dim FigAmt As Long = fUpdate * CspAmt

        Sql = "UPDATE " & TbNm & " SET clStockClosing=@clStockClosing," &
                                                                TXNType & "=@" & TXNType & "," &
                                                                TXNType & "Amt=@" & TXNType & "Amt," &
                                                                "clStockClosingAmt=@clStockClosingAmt " &
                                                                "WHERE clItemId='" & PrdId & "'"

        Try
            With cTXNs
                If Not .State = ConnectionState.Open Then .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, cTXNs)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clStockClosing", NpgsqlDbType.Integer)).Value = CsP
                .Parameters.Add(New NpgsqlParameter("@" & TXNType, NpgsqlDbType.Integer)).Value = fUpdate
                .Parameters.Add(New NpgsqlParameter("@" & TXNType & "Amt", NpgsqlDbType.Bigint)).Value = FigAmt
                .Parameters.Add(New NpgsqlParameter("@clStockClosingAmt", NpgsqlDbType.Bigint)).Value = FigUpdtAmt
                If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    With cTXNs
                        If Not .State = ConnectionState.Closed Then .Close()
                    End With
                End If
            End With
        Catch ex As Exception
            With cTXNs
                If Not .State = ConnectionState.Closed Then .Close()
            End With
            write_Error(ex.Message & " - Closing Stock Update")
        Finally
            With cTXNs
                If Not .State = ConnectionState.Closed Then .Close()
            End With
        End Try

    End Sub

End Module
