Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class StockDetails
    Sub uploadData() Handles btnRefresh.Click
        UploadProgressDialog("Loading data. Please wait...")

        Try
            If Not xlpth_Products.Exists Then xlpth_Products.Create()

            c_p.Open()

            Dim tSQL As String = "SELECT * FROM [c_Data$]"

            Dim cmd As New OleDbCommand(tSQL, c_p)

            Dim da As New OleDbDataAdapter

            da.SelectCommand = cmd

            Dim excelData As New DataTable

            da.Fill(excelData)

            c_p.Close()

            dg_List.DataSource = excelData

            For i = 0 To dg_List.ColumnCount - 1
                dg_List.Columns.Item(i).HeaderText = UCase(dg_List.Columns.Item(i).HeaderText.Replace("cl", ""))
                dg_List.Columns.Item(3).DefaultCellStyle.Format = "n2"
            Next

            dg_List.DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)

            dg_List.AutoResizeColumns()

            l_RecordsToUpload.Text = String.Concat(dg_List.Rows.Count, " record(s) to upload")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Dim canProceed As Boolean = False

        For Each c As Control In Me.Controls
            If c.Visible Then
                canProceed = True
            Else
                canProceed = False
            End If
        Next

        If Not canProceed Then Exit Sub

        '_Save = _Mode.IsSave
        If _Save = _Mode.IsNothing Then Close()
        uploadData()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        dg_List.DataSource.Clear()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            LoadProducts()
        ElseIf e.KeyCode = Keys.F5 Then
            uploadData()
        ElseIf e.KeyCode = Keys.F9 Then
            dg_List.Rows.Clear()
        End If

    End Sub
    Function vl(value) As Integer
        Dim r = 0
        If value Is DBNull.Value Then
            r = 0
        Else
            r = value
        End If
        Return r
    End Function
    Public Sub LoadProducts() Handles btnBeginUpload.Click
        Dim sql As String = Nothing
        Try
            If _Save = _Mode.IsSave Then
                Dim mg As MsgBoxResult = MsgBox("This action will clear previous database. Continue?", MsgBoxStyle.YesNo)
                If Not mg = MsgBoxResult.Yes Then Exit Sub
                xQry("DELETE FROM clProducts", c_Products)

                xQry("DELETE FROM clBarcodes", c_Products)

            End If

            sql = "INSERT INTO clProducts (SerialId,clName,clBarcode,clPrice," &
                                                                            "clQty,clCurrency,clDiscount," &
                                                                            "clMerchantId,clCategoryId,clPurchaseId," &
                                                                            "clUnit,clUnitCost,clProductExpiry,clDate,clVAT," &
                                                                            "clVATInclusive,clWeighable,clMargin,clWeighableQty," &
                                                                            "clAccountId,clAlertQty,clSellOutOfStock," &
                                                                            "clDocFile,clModifDate) " &
                                    "VALUES " &
                                                             "(@SerialId,@clName,@clBarcode,@clPrice,@" &
                                                                            "clQty,@clCurrency,@clDiscount,@" &
                                                                            "clMerchantId,@clCategoryId,@clPurchaseId,@" &
                                                                            "clUnit,@clUnitCost,@clProductExpiry,@clDate,@clVAT,@" &
                                                                            "clVATInclusive,@clWeighable,@clMargin,@clWeighableQty,@" &
                                                                            "clAccountId,@clAlertQty,@clSellOutOfStock,@" &
                                                                            "clDocFile,@clModifDate)"

            'UploadProgressDialog("Please wait...")
            If c_Products.State = ConnectionState.Closed Then c_Products.Open()
            For Each row As DataGridViewRow In dg_List.Rows

                Dim cm As New SqlCommand(sql, c_Products)
                Dim tD As Date = New Date()
                With Date.Now
                    tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
                End With
                With cm
                    .Parameters.Add(New SqlParameter("@SerialId", SqlDbType.VarChar)).Value = row.Cells(0).Value
                    .Parameters.Add(New SqlParameter("@clName", SqlDbType.VarChar)).Value = row.Cells(1).Value
                    .Parameters.Add(New SqlParameter("@clCategoryId", SqlDbType.VarChar)).Value = row.Cells(2).Value
                    .Parameters.Add(New SqlParameter("@clAccountId", SqlDbType.VarChar)).Value = usrId
                    .Parameters.Add(New SqlParameter("@clUnitCost", SqlDbType.BigInt)).Value = vl(row.Cells(4).Value)
                    .Parameters.Add(New SqlParameter("@clPrice", SqlDbType.BigInt)).Value = vl(row.Cells(5).Value)
                    .Parameters.Add(New SqlParameter("@clQty", SqlDbType.Int)).Value = vl(row.Cells(6).Value)
                    .Parameters.Add(New SqlParameter("@clVATInclusive", SqlDbType.Int)).Value = 0
                    .Parameters.Add(New SqlParameter("@clVAT", SqlDbType.Int)).Value = 0.05 * vl(vl(row.Cells(5).Value))
                    .Parameters.Add(New SqlParameter("@clDiscount", SqlDbType.BigInt)).Value = vl(row.Cells(8).Value)
                    .Parameters.Add(New SqlParameter("@clBarcode", SqlDbType.VarChar)).Value = row.Cells(9).Value
                    .Parameters.Add(New SqlParameter("@clAlertQty", SqlDbType.Int)).Value = vl(row.Cells(10).Value)
                    .Parameters.Add(New SqlParameter("@clSellOutOfStock", SqlDbType.Int)).Value = vl(row.Cells(11).Value)
                    .Parameters.Add(New SqlParameter("@clDocFile", SqlDbType.VarChar)).Value = "null"
                    .Parameters.Add(New SqlParameter("@clDate", SqlDbType.Date)).Value = tD
                    .Parameters.Add(New SqlParameter("@clModifDate", SqlDbType.Date)).Value = tD
                    .Parameters.Add(New SqlParameter("@clMerchantId", SqlDbType.VarChar)).Value = row.Cells(15).Value
                    .Parameters.Add(New SqlParameter("@clPurchaseId", SqlDbType.VarChar)).Value = row.Cells(16).Value
                    .Parameters.Add(New SqlParameter("@clUnit", SqlDbType.VarChar)).Value = row.Cells(17).Value
                    .Parameters.Add(New SqlParameter("@clWeighable", SqlDbType.Int)).Value = 0
                    .Parameters.Add(New SqlParameter("@clMargin", SqlDbType.Int)).Value = 1
                    .Parameters.Add(New SqlParameter("@clWeighableQty", SqlDbType.Int)).Value = vl(row.Cells(4).Value)
                    .Parameters.Add(New SqlParameter("@clCurrency", SqlDbType.VarChar)).Value = row.Cells(18).Value
                    .Parameters.Add(New SqlParameter("@clProductExpiry", SqlDbType.Date)).Value = CDate(row.Cells(19).Value)

                    If c_Products.State = ConnectionState.Closed Then c_Products.Open()

                    Dim fSnd As Integer = .ExecuteNonQuery()
                    If fSnd > 0 Then
                        c_Products.Close()

                        xQry("INSERT INTO clBarcodes (SerialId," &
                                                                           "clBarcode," &
                                                                           "clName) " &
                                                                    "VALUES ('" &
                                                                           row.Cells(0).Value & "','" &
                                                                           row.Cells(9).Value & "','" &
                                                                           row.Cells(1).Value & "')",
                             c_Products)

                    End If
                    '
                End With
            Next
            MsgBox("Save success!")
            'Close()

        Catch ex As Exception
            If c_Products.State = ConnectionState.Open Then c_Products.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        Try
            Dim newDataRow As DataGridViewRow = dg_List.Rows(e.RowIndex)
            With newDataRow
                If .Cells(0).Value Is DBNull.Value Then .Cells(0).Value = e.RowIndex + 1000
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub uploadData(sender As Object, e As EventArgs) Handles btnRefresh.Click
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dg_List.Rows.Clear()
    End Sub

End Class