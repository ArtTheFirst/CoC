Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class PurchaseOrder

    Sub PrepareDGColumns()
        Dim dgCl As DataGridViewTextBoxColumn = Nothing
        Try
            dg_List.Rows.Clear()
            dg_List.Columns.Clear()
        Catch ex As Exception
        End Try

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "CODE"
        dg_List.Columns.Add(dgCl)
        dg_List.Columns.Item(0).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
        dg_List.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        dg_List.Columns.Item(0).Width = 100

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "ITEM NAME"
        dg_List.Columns.Add(dgCl)
        dg_List.Columns.Item(1).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
        dg_List.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        dg_List.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "QTY"
        dg_List.Columns.Add(dgCl)
        dg_List.Columns.Item(2).DefaultCellStyle.Format = "n0"
        dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_List.Columns.Item(2).Width = 120

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "RATE"
        dg_List.Columns.Add(dgCl)
        dg_List.Columns.Item(3).DefaultCellStyle.Format = "n2"
        dg_List.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_List.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_List.Columns.Item(3).ReadOnly = True
        dg_List.Columns.Item(3).Width = 180

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "TOTAL"
        dg_List.Columns.Add(dgCl)
        dg_List.Columns.Item(4).DefaultCellStyle.Format = "n2"
        dg_List.Columns.Item(4).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_List.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_List.Columns.Item(4).ReadOnly = True
        dg_List.Columns.Item(4).Width = 270

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ThisBillMode = CurrentlyIs.PurchaseOrder
        btnNew.PerformClick()
        PrepareDGColumns()
        dg_List.Focus()
        alignTotalLabels()
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        alignTotalLabels()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        disposeInvoice()
        Inv = ""
        _Purchase = EnterMode.Is_Absolutely_Nothing
        ThisCurrent = BillMode.Is_Absolutely_Nothing
    End Sub

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            updateStockByPurchase()
        ElseIf e.KeyCode = Keys.F2 Then
            btnProceed_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            _Clear(_this.AsReset)
        End If

    End Sub

    Function rcpt() As String
        Try
            Dim final As Integer = 100000 + calcVal("SerialId",
                                  "clInvoiceOrders",
                    CalcMode.GetCount,
                                     cTXNs,
                                        " WHERE clInvoiceCode ILIKE '%PO%'")
            rcpt = String.Concat("PO" & final)
        Catch ex As Exception
            write_Error("Invoice Generation Error; " & ex.Message)
            MsgBox("Invoice Generation Error; " & ex.Message)
        End Try

        Return 0

    End Function

    Sub InitiateInvoice()
        Inv = rcpt()
        xQry("INSERT INTO clInvoiceOrders (clInvoiceCode) VALUES ('" & Inv & "')", cTXNs)
        xQry("INSERT INTO clTXNsOrder (clOrderInvoice) VALUES ('" & Inv & "')", cTXNs)
        With Date.Now
            SessionId = String.Concat(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond)
        End With
        l_SessionId.Text = String.Concat(l_SessionId.Tag, SessionId)
        l_Inv.Text = String.Concat(l_Inv.Tag, Inv)
    End Sub

    Enum _this
        AsAdd
        AsReset
    End Enum
    Sub _Clear(_From As _this)
        Dim execution As Boolean = False
        dg_List.Rows.Clear()
        calcTotals()
        If _From = _this.AsAdd Then
            execution = False

        ElseIf _From = _this.AsReset Then
            autosText(t_SupplierName, "clName", "clSuppliers", c)
            execution = True
            t_SupplierName.Clear()
            l_CompanyName.Text = l_CompanyName.Tag
            dtp_InvoiceDate.Value = Date.Now
            InitiateInvoice()

        End If

        t_SupplierName.Enabled = execution

        btnSave.Enabled = Not execution

        FromOut = False

    End Sub
    Sub calcTotals()

        Dim qtytotal As Integer = 0
        Dim costprice As Integer = 0
        Dim total As Integer = 0

        qtytotal = subTotal(2)
        costprice = subTotal(3)
        total = subTotal(4)

        l_qtyTotal.Text = FormatNumber(qtytotal, 0)
        l_CostTotal.Text = FormatNumber(costprice, 0)
        l_TotalAll.Text = FormatNumber(total, 2, TriState.True)

    End Sub
    Function subTotal(col As Integer) As Decimal
        Dim TotalValue As Decimal
        Dim tmp As Decimal
        For n As Integer = 0 To dg_List.Rows.Count - 1
            Dim nDR As DataGridViewRow = dg_List.Rows(n)
            With nDR
                If Decimal.TryParse(.Cells(col).Value, tmp) Then
                    TotalValue += tmp
                End If
            End With
        Next

        Return TotalValue
    End Function

    Sub alignTotalLabels()
        calcTotals()
        Try
            Dim cRect As Rectangle = dg_List.GetCellDisplayRectangle(2, 0, False)
            cRect.X += dg_List.Left
            l_qtyTotal.Location = New Point(cRect.X, l_qtyTotal.Location.Y)

            cRect = dg_List.GetCellDisplayRectangle(3, 0, False)
            cRect.X += dg_List.Left
            l_CostTotal.Location = New Point(cRect.X, l_CostTotal.Location.Y)

            cRect = dg_List.GetCellDisplayRectangle(4, 0, False)
            cRect.X += dg_List.Left
            l_TotalAll.Location = New Point(cRect.X, l_TotalAll.Location.Y)

        Catch ex As Exception

        End Try

    End Sub

    Sub getDetails()
        If t_SupplierName.Text.Length < 1 Then Exit Sub

        _Clear(_this.AsAdd)

    End Sub
    Private onCellEdit As Boolean = False
    Private Sub dg_List_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_List.EditingControlShowing
        Dim autoBox As TextBox = TryCast(e.Control, TextBox)
        If autoBox Is Nothing Then Exit Sub
        If dg_List.CurrentCell.ColumnIndex = 1 Then
            If dg_List.Columns(dg_List.CurrentCell.ColumnIndex).HeaderText = "ITEM NAME" Then
                autosText(autoBox, "clName", "clItems", cItems)
            Else
                autosText(autoBox, "clName", "clItems", cItems, True)
            End If
        Else
            autosText(autoBox, "clName", "clItems", cItems, True)
        End If

        If dg_List.CurrentCell.ColumnIndex = 0 Or dg_List.CurrentCell.ColumnIndex = 2 Then
            If dg_List.Columns(dg_List.CurrentCell.ColumnIndex).HeaderText = "CODE" Or
                dg_List.Columns(dg_List.CurrentCell.ColumnIndex).HeaderText = "QTY" Then
                InitiateHandler = True
                AddHandler e.Control.KeyPress, AddressOf IntKeyTrap
            Else
                InitiateHandler = False
            End If
        Else
            InitiateHandler = False
        End If

    End Sub
    Private InitiateHandler As Boolean = False
    Private Sub IntKeyTrap(sender As Object, e As KeyPressEventArgs)
        If Not InitiateHandler Then Exit Sub
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select

    End Sub
    Sub loadDetails(ItemName As String)
        If String.IsNullOrEmpty(ItemName) Then Exit Sub
        Dim tbl As DataTable = Nothing
        Dim condition As String = Nothing
        Dim pId As String = Nothing
        Dim p = Nothing
        Try

            If AddAs = DetailFrom.ItemCode Then
                condition = " WHERE SerialId='" & ItemName & "' OR clBarcode='" & ItemName & "'"
            ElseIf AddAs = DetailFrom.ItemName Then
                condition = " WHERE clName='" & ItemName & "' Or SerialId='" & ItemName & "' OR clBarcode='" & ItemName & "'"
            End If
            p = Qry("SELECT clName FROM clItems" & condition, cItems)
            pId = Qry("SELECT SerialId FROM clItmPrx WHERE clName='" & p & "'", cItems)
            condition = " WHERE SerialId='" & pId & "'"
        Catch ex As Exception
            write_Error(ex.Message)
            deleteRow()
        End Try

        Try

            tbl = xRead(" SELECT SerialId,clName,clPrice " &
                    "FROM clItems" & condition,
                    "clItems",
                                cItems)

            If String.IsNullOrEmpty(ItemName) Then Exit Sub

            For Each row In tbl.Rows

                Dim dR As DataGridViewRow = dg_List.Rows(r)
                With dR
                    .Cells(0).Value = row(0).ToString
                    .Cells(1).Value = row(1).ToString
                    If .Cells(2).Value Is DBNull.Value Or .Cells(2).Value = 0 Then
                        .Cells(2).Value = 1
                    End If
                    .Cells(3).Value = row(2)
                End With

                onCellEdit = True

            Next

        Catch ex As Exception

            write_Error("Cannot load Item details. Please Check error code" & ex.HResult)

            'MsgBox("Cannot load Item details. Please Check error code" & ex.HResult)

        End Try

    End Sub

    Sub deleteRow()
        Try
            Dim counter As Integer = dg_List.CurrentRow.Index
            dg_List.Rows.RemoveAt(counter)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Function returns(SId, Name) As String
        Dim q As String = Nothing
        Try
            q = Qry("SELECT clBarcode FROM clItems WHERE SerialId='" & SId & "' AND clName='" & Name & "'", cItems)
        Catch ex As Exception
            q = ""
        End Try
        returns = q
    End Function
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        calcTotals()

        dg_list_CellEnter(Me, e)

    End Sub
    Dim r As Integer = -1
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter

        Try
            r = e.RowIndex
            Dim dR As DataGridViewRow = dg_List.Rows(r)
            With dR
                If dg_List.CurrentCell.ColumnIndex = 1 Then
                    AddAs = DetailFrom.ItemName
                    loadDetails(.Cells(1).Value)
                ElseIf dg_List.CurrentCell.ColumnIndex = 0 Then
                    AddAs = DetailFrom.ItemCode
                    loadDetails(.Cells(0).Value)
                End If

                Dim Total As Integer = CInt(.Cells(2).Value) * CInt(.Cells(3).Value)

                .Cells(4).Value = FormatNumber(Total, 2, TriState.True)

            End With

            calcAddVal()

            calcTotals()
        Catch ex As Exception
        End Try

        If Not FromOut Then
            Try
                Dim nDr As DataGridViewRow = dg_List.Rows(r)
                With nDr
                    If .Cells(0).Value Is DBNull.Value Or
                        Trim(.Cells(0).Value) = "" Or .Cells(1).Value Is DBNull.Value Or
                        Trim(.Cells(1).Value) = "" Or returns(.Cells(0).Value, .Cells(1).Value) = "" Then
                        deleteRow()
                    End If
                End With

            Catch ex As Exception
            End Try

        End If

    End Sub
    Function calcAddVal()
        r = dg_List.CurrentRow.Index
        Dim c As Integer = r - 1
        Dim dR As DataGridViewRow = dg_List.Rows(r)
        With dR
            If c >= 0 Then
                Dim eR As DataGridViewRow = dg_List.Rows(c)
                Dim rVal As Decimal = 0.0
                If returns(dR.Cells(0).Value, dR.Cells(1).Value) = "" Then
                    If Not v(dR.Cells(2).Value) = 0 Then
                        rVal = v(dR.Cells(2).Value) + v(eR.Cells(2).Value)
                        deleteRow()
                        eR.Cells(2).Value = rVal
                    End If
                End If
            End If

        End With
        Return 0
    End Function

    Private FromOut As Boolean = False
    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
            Catch ex As Exception
            Finally
                calcTotals()
            End Try
        ElseIf e.KeyData = Keys.Enter Then
            Dim t As Integer = dg_List.CurrentRow.Index
            Dim ndr As DataGridViewRow = dg_List.Rows(t)
            With ndr
                If dg_List.CurrentCell.ColumnIndex = 0 Or dg_List.CurrentCell.ColumnIndex = 1 Then
                    If Not Trim(.Cells(0).Value) = "" Or Not Trim(.Cells(1).Value) = "" Then Exit Sub
                    CurrentItem = SearchIs.Create
                    Code = ""
                    searchModule = IsIn.TXNMode
                    Dim h As New ItemSearch : If Not h.Visible Then h.ShowDialog
                    If Code = "" Then deleteRow() : Exit Sub
                    If AddAs = DetailFrom.AbsolutelyNothing__Pity Then deleteRow() : Exit Sub
                    FromOut = True

                    If dg_List.CurrentCell.ColumnIndex = 0 Then
                        AddAs = DetailFrom.ItemCode
                        t = dg_List.CurrentRow.Index
                        loadDetails(Code)
                        dg_List.CurrentCell = dg_List.Rows(t).Cells(0)
                    ElseIf dg_List.CurrentCell.ColumnIndex = 1 Then
                        AddAs = DetailFrom.ItemName
                        t = dg_List.CurrentRow.Index
                        loadDetails(Code)
                        dg_List.CurrentCell = dg_List.Rows(t).Cells(1)
                    End If

                    FromOut = False

                End If
            End With
        End If

    End Sub

    Dim sessionid As String
    Sub updateStockByPurchase() Handles btnSave.Click
        Dim Mrc As String = l_CompanyName.Text.Replace(" Company Name:", "")

        Try

            If cTXNs.State = ConnectionState.Closed Then cTXNs.Open()
            Dim Sql As String = ""
            Sql = "UPDATE clInvoiceOrders SET SerialId=@SerialId," &
                                                                        "clDate=@clDate," &
                                                                        "clTime=@clTime," &
                                                                        "clPaymentMethod=@clPaymentMethod," &
                                                                        "clQty=@clQty," &
                                                                        "clAmountExpected=@clAmountExpected," &
                                                                        "clAmountPaid=@clAmountPaid," &
                                                                        "clUser=@clUser," &
                                                                        "clCustomer=@clCustomer," &
                                                                        "clType=@clType," &
                                                                        "clSeries=@clSeries," &
                                                                        "clStatus=@clStatus" &
                                                                                 " WHERE clInvoiceCode='" & Inv & "'"

            Dim cmd As New NpgsqlCommand(Sql,
                                        cTXNs)
            Dim d1 As New TimeSpan
            With Date.Now
                d1 = New TimeSpan(.Hour, .Minute, .Second)
            End With
            With cmd
                .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = SessionId
                .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = dtp_InvoiceDate.Value.Date
                .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = d1
                .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = "Credit"
                .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(2)
                .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = CType(subTotal(4), Long)
                .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr()
                .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = t_SupplierName.Text
                .Parameters.Add(New NpgsqlParameter("@clType", NpgsqlDbType.Varchar)).Value = "Purchase Order"
                .Parameters.Add(New NpgsqlParameter("@clSeries", NpgsqlDbType.Varchar)).Value = "Order"
                .Parameters.Add(New NpgsqlParameter("@clStatus", NpgsqlDbType.Integer)).Value = InvoiceIsOpen

                If cTXNs.State = ConnectionState.Closed Then cTXNs.Open()

                Dim fSn As Integer = .ExecuteNonQuery()
                If fSn > 0 Then

                    GoTo 2
                End If
            End With

            Exit Sub

2:          Call xCr(ThisBillMode)

            For Each row As DataGridViewRow In dg_List.Rows

                If Not row.Cells(1).Value = "" Then

                    With cTXNs
                        If Not .State = ConnectionState.Open Then .Open()
                    End With
                    Dim cm As New NpgsqlCommand("INSERT INTO clPurchaseOrder (clItemId,clSerialId,clOrderInvoice," &
                                             "clClient,clDate,clTime,clItem,clQuantity," &
                                                   "clSupplier,clCategory,clCost)" &
                                                                     " VALUES " &
                                                     "(@clItemId,@clSerialId,@clOrderInvoice," &
                                                     "@clClient,@clDate,@clTime,@clItem,@clQuantity," &
                                                            "@clSupplier,@clCategory,@clCost)",
                                           cTXNs)
                    Dim tD As Date = New Date()
                    With Date.Now
                        tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
                    End With
                    With cm
                        .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = row.Cells(0).Value
                        .Parameters.Add(New NpgsqlParameter("@clOrderInvoice", NpgsqlDbType.Varchar)).Value = Inv
                        .Parameters.Add(New NpgsqlParameter("@clSerialId", NpgsqlDbType.Varchar)).Value = l_SessionId.Text.Replace(l_SessionId.Tag, "")
                        .Parameters.Add(New NpgsqlParameter("@clClient", NpgsqlDbType.Varchar)).Value = usr()
                        .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = dtp_InvoiceDate.Value.Date
                        .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = New TimeSpan(tD.Hour, tD.Minute, tD.Second)
                        .Parameters.Add(New NpgsqlParameter("@clItem", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                        .Parameters.Add(New NpgsqlParameter("@clQuantity", NpgsqlDbType.Integer)).Value = CInt(row.Cells(2).Value)
                        .Parameters.Add(New NpgsqlParameter("@clSupplier", NpgsqlDbType.Varchar)).Value = t_SupplierName.Text
                        .Parameters.Add(New NpgsqlParameter("@clCategory", NpgsqlDbType.Varchar)).Value = "Order"
                        .Parameters.Add(New NpgsqlParameter("@clCost", NpgsqlDbType.Bigint)).Value = CLng(row.Cells(3).Value)
                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then
                            cTXNs.Close()

                            Dim fQty As Object = row.Cells(2).Value
                            LoadCrVw(ThisBillMode, v(fQty), row.Cells(0).Value, row.Cells(1).Value, v(row.Cells(4).Value), 0)

                        End If
                    End With

                End If

            Next

            'MsgBox("Save success!")

            '//

            LoadCrVw(t_SupplierName.Text, dtp_InvoiceDate.Value.Date)

            _Clear(_this.AsReset)

        Catch ex As SqlException
            MsgBox(ex.Message)
            If cTXNs.State = ConnectionState.Open Then cTXNs.Close()
            cTXNs.Close()

        End Try

    End Sub

    Sub disposeInvoice()
        xQry("DELETE FROM clInvoiceOrders WHERE clClient IS NULL OR clClient=''", cTXNs)
        xQry("DELETE FROM clPurchaseOrder WHERE clUser IS NULL OR clUser=''", cTXNs)
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _Purchase = EnterMode.IsPurchaseOrder
        disposeInvoice()
        _Clear(_this.AsReset)
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs)
        If t_SupplierName.Text.Length < 1 AndAlso t_SupplierName.Text.Length < 1 Then Exit Sub
        _Clear(_this.AsAdd)
        dg_List.Focus()
    End Sub

    Private Sub t_SupplierName_KeyDown(sender As Object, e As KeyEventArgs) Handles t_SupplierName.KeyDown
        If e.KeyData = Keys.Enter Then

            ThisClient = IsA.Supplier

            CurrentItem = SearchIs.Create

            Dim f As New Clients
            If Not f.Visible Then f.ShowDialog()

            If Trim(CustId) = "" Then Exit Sub
            Try
                Dim tbl As DataTable = xRead("SELECT clName,clCompany" &
                                             " FROM clSuppliers " &
                                             "WHERE SerialId='" & CustId & "'", "clSuppliers", )
                For Each row In tbl.Rows
                    t_SupplierName.Text = row(0).ToString
                    l_CompanyName.Text = l_CompanyName.Tag & row(1).ToString
                Next
                btnProceed_Click(Nothing, Nothing)

            Catch ex As Exception
                _Clear(_this.AsReset)
            End Try

        End If

    End Sub

End Class