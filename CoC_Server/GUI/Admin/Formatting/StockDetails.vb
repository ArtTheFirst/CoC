Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class StockDetails
    Private tbl As DataTable = Nothing
    Sub disBandTbl()
        Try
            tbl.Clear()
            dg_List.DataSource = tbl
            dg_List.DataSource = Nothing
            dg_List.Rows.Clear()
            dg_List.Columns.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Sub uploadData()

        disBandTbl()

        UploadProgressDialog("Loading data. Please wait...")

        Try

            If _Data = _AccessMode.IsUpload Then
                If Not xlpth_Items.Exists Then xlpth_Items.Create()

                c_p.Open()
                Dim tSQL As String = "SELECT SerialId,clBarcode,clName,clCategoryId,clAcctId," &
                                                                "clUnitCost,clPrice,clQty,clUnit,clVATInclusive,clVAT,clDiscount," &
                                                                "clAlertQty,clSellOutOfStock," &
                                                                "clCurrency,clCustomerId,clPurchaseId," &
                                                                "clDate,clItemExpiry FROM [c_Data$]" &
                                                                " WHERE clName IS NOT NULL"
                Dim cmd As New OleDbCommand(tSQL, c_p)
                Dim da As New OleDbDataAdapter
                da.SelectCommand = cmd
                tbl = New DataTable
                da.Fill(tbl)
                c_p.Close()
            ElseIf _Data = _AccessMode.IsDownload Then
                Try
                    tbl.Clear()
                    tbl = Nothing
                Catch
                End Try
                tbl = xRead("SELECT SerialId,clName,clBarcode,clPrice," &
                                                            "clQty,clCurrency,clDiscount," &
                                                            "clCustomerId,clCategoryId,clPurchaseId," &
                                                            "clUnit,clUnitCost,clItemExpiry,clDate,clVAT," &
                                                            "clVATInclusive,clWeighable,clMargin,clWeighableQty," &
                                                            "LastTXNTXNs,LastTXNSupplies," &
                                                            "clAccountId,clAlertQty,clSellOutOfStock," &
                                                            "clModifDate FROM clItems",
                            "clItems",
                            cItems)
            End If

            dg_List.DataSource = tbl

            For i = 0 To dg_List.ColumnCount - 1
                dg_List.Columns.Item(i).HeaderText = UCase(dg_List.Columns.Item(i).HeaderText.Replace("cl", ""))
            Next

            dg_List.ReadOnly = True

            dg_List.AutoResizeColumns()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        btnBeginUpload.Text = "BEGIN " & IIf(_Data = _AccessMode.IsDownload, "DOWNLOAD", "UPLOAD") & " [F1]"

        If _Save = _Mode.IsNothing Then Close()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        disBandTbl()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnBeginUpload.PerformClick()
        ElseIf e.KeyCode = Keys.F5 Then
            btnRefresh.PerformClick()
        ElseIf e.KeyCode = Keys.F9 Then
            btnClear.PerformClick()
        End If

    End Sub
    Public Sub LoadItems()
        Dim sql As String = Nothing
        Try

            If _Data = _AccessMode.IsDownload Then

                ExportGridToExcel(dg_List)

            ElseIf _Data = _AccessMode.IsUpload Then

                If _Save = _Mode.IsSave Then
                    Dim mg As MsgBoxResult = MsgBox("This action will clear previous database. Continue?", MsgBoxStyle.YesNo)
                    If Not mg = MsgBoxResult.Yes Then Exit Sub
                    xQry("DELETE FROM clItems", cItems)

                    xQry("DELETE FROM clItmPrx", cItems)

                End If

                sql = "INSERT INTO clItems (SerialId,clBarcode,clName,clCategoryId," &
                                                                            "clAccountId,clUnitCost,clPrice,clQty," &
                                                                            "clUnit,clVATInclusive,clVAT,clDiscount," &
                                                                            "clAlertQty,clSellOutOfStock,clCurrency," &
                                                                            "clDocFile,clModifDate,clCustomerId,clPurchaseId," &
                                                                            "clWeighable,clMargin,clWeighableQty," &
                                                                            "clDate,clItemExpiry) " &
                                    "VALUES " &
                                                             "(@SerialId,@clBarcode,@clName,@clCategoryId," &
                                                                            "@clAccountId,@clUnitCost,@clPrice,@clQty," &
                                                                            "@clUnit,@clVATInclusive,@clVAT,@clDiscount," &
                                                                            "@clAlertQty,@clSellOutOfStock,@clCurrency," &
                                                                            "@clDocFile,@clModifDate,@clCustomerId,@clPurchaseId," &
                                                                            "@clWeighable,@clMargin,@clWeighableQty," &
                                                                            "@clDate,@clItemExpiry)"

                'UploadProgressDialog("Please wait...")
                If cItems.State = ConnectionState.Closed Then cItems.Open()

                'SetupStockStatus()

                For Each row As DataGridViewRow In dg_List.Rows

                    Dim cm As New NpgsqlCommand(sql, cItems)
                    Dim tD As Date = New Date()
                    With Date.Now
                        tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
                    End With
                    With cm
                        .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Integer)).Value = row.Cells(0).Value
                        .Parameters.Add(New NpgsqlParameter("@clBarcode", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                        .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = UCase(Trim(row.Cells(2).Value))
                        .Parameters.Add(New NpgsqlParameter("@clCategoryId", NpgsqlDbType.Varchar)).Value = row.Cells(3).Value
                        .Parameters.Add(New NpgsqlParameter("@clAccountId", NpgsqlDbType.Varchar)).Value = row.Cells(4).Value

                        .Parameters.Add(New NpgsqlParameter("@clUnitCost", NpgsqlDbType.Bigint)).Value = v(row.Cells(5).Value)
                        .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = v(row.Cells(6).Value)

                        .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = v(row.Cells(7).Value)

                        .Parameters.Add(New NpgsqlParameter("@clUnit", NpgsqlDbType.Varchar)).Value = row.Cells(8).Value

                        .Parameters.Add(New NpgsqlParameter("@clVATInclusive", NpgsqlDbType.Integer)).Value = v(row.Cells(9).Value)
                        .Parameters.Add(New NpgsqlParameter("@clVAT", NpgsqlDbType.Integer)).Value = v(row.Cells(10).Value)

                        .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = v(row.Cells(11).Value)

                        .Parameters.Add(New NpgsqlParameter("@clAlertQty", NpgsqlDbType.Integer)).Value = 0
                        .Parameters.Add(New NpgsqlParameter("@clSellOutOfStock", NpgsqlDbType.Integer)).Value = 0
                        .Parameters.Add(New NpgsqlParameter("@clCurrency", NpgsqlDbType.Varchar)).Value = row.Cells(14).Value
                        .Parameters.Add(New NpgsqlParameter("@clDocFile", NpgsqlDbType.Bytea)).Value = New Byte(8) {}
                        .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = tD
                        .Parameters.Add(New NpgsqlParameter("@clCustomerId", NpgsqlDbType.Varchar)).Value = row.Cells(15).Value
                        .Parameters.Add(New NpgsqlParameter("@clPurchaseId", NpgsqlDbType.Varchar)).Value = row.Cells(16).Value
                        .Parameters.Add(New NpgsqlParameter("@clWeighable", NpgsqlDbType.Integer)).Value = 0
                        .Parameters.Add(New NpgsqlParameter("@clMargin", NpgsqlDbType.Integer)).Value = 1

                        .Parameters.Add(New NpgsqlParameter("@clWeighableQty", NpgsqlDbType.Integer)).Value = v(row.Cells(17).Value)

                        Dim pd As Date = Nothing
                        Dim ed As Date = Nothing
                        Try
                            pd = CDate(row.Cells(17).Value)
                            ed = CDate(row.Cells(18).Value)
                        Catch ex As Exception
                            With Date.Now
                                ed = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second).AddDays(120)
                                pd = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
                            End With
                        End Try

                        .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = pd

                        .Parameters.Add(New NpgsqlParameter("@clItemExpiry", NpgsqlDbType.Date)).Value = ed

                        If cItems.State = ConnectionState.Closed Then cItems.Open()

                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then
                            cItems.Close()

                            xQry("INSERT INTO clItmPrx (SerialId," &
                                                                           "clBarcode," &
                                                                           "clName," &
                                                                           "clPrice) " &
                                                                    "VALUES ('" &
                                                                           row.Cells(0).Value & "','" &
                                                                           row.Cells(1).Value & "','" &
                                                                           row.Cells(2).Value & "','" &
                                                                       v(row.Cells(6).Value) & "')",
                             cItems)

                            xQry("INSERT INTO clItemsDetails (SerialId,clLastModif)" &
                                                                    " VALUES ('" &
                                                                           row.Cells(0).Value & "','" & Date.Now.ToShortDateString & "')",
                             cItems)

                        End If
                        '
                    End With
                Next

                InitiateStocks(True)

                MsgBox("Save success!")

                'Close()

            End If

        Catch ex As Exception
            If Not cItems.State = ConnectionState.Closed Then cItems.Close()
            If Not cTXNs.State = ConnectionState.Closed Then cTXNs.Close()
            'MsgBox(ex.Message)
            write_Error(ex.Message, Name)
        End Try

    End Sub

    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        If _Data = _AccessMode.IsDownload Then Exit Sub
        Try

            For Each rw As DataGridViewRow In dg_List.Rows
                With rw
                    If .Cells(0).Value Is DBNull.Value Then .Cells(0).Value = ++1000
                    If .Cells(1).Value Is DBNull.Value Then .Cells(1).Value = ++1000
                End With
            Next

        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then

            If _Data = _AccessMode.IsDownload Then Exit Sub

            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnBeginUpload_Click(sender As Object, e As EventArgs) Handles btnBeginUpload.Click
        LoadItems()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        uploadData()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        disBandTbl()
    End Sub

End Class