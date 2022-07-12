Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class Purchases

    Sub PrepareDGColumns()
        Dim dgCl As DataGridViewTextBoxColumn = Nothing
        Try
            dg_TXNs.Rows.Clear()
            dg_TXNs.Columns.Clear()
        Catch ex As Exception
        End Try

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "CODE"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(0).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        dg_TXNs.Columns.Item(0).Width = 130

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "ITEM NAME"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(1).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        dg_TXNs.Columns.Item(1).Width = 435

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "QTY"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(2).DefaultCellStyle.Format = "n0"
        dg_TXNs.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(2).Width = 120

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "FREE QTY."
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(3).DefaultCellStyle.Format = "n0"
        dg_TXNs.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(3).Width = 120

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "MARGIN (%)"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(4).DefaultCellStyle.Format = "n0"
        dg_TXNs.Columns.Item(4).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(4).Width = 120

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "PURCHASE RATE"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(5).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(5).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(5).Width = 210

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "SELLING RATE"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(6).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(6).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(6).ReadOnly = True
        dg_TXNs.Columns.Item(6).Width = 210

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "DISCOUNT (%)"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(7).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(7).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(7).Width = 120

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "VAT (5%)"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(8).DefaultCellStyle.Format = "n0"
        dg_TXNs.Columns.Item(8).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(8).Width = 120

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "MRP"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(9).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(9).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(9).Width = 210

        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "TOTAL"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(10).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(10).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(10).ReadOnly = True
        dg_TXNs.Columns.Item(10).Width = 270

    End Sub

    Private tbl As DataTable = Nothing
    Sub disBandTbl()

        Try
            tbl.Clear()
            dg_TXNs.DataSource = tbl
            dg_TXNs.DataSource = Nothing
            dg_TXNs.Rows.Clear()
            dg_TXNs.Columns.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Sub InitiateEntry()

        disBandTbl()

        PrepareDGColumns()

        Dim tD As Date = New Date()
        With Date.Now
            tD = New Date(.Year, .Month, .Day)
        End With

        l_BillDate.Text = String.Concat("Bill Date: ", tD.ToShortDateString)

        dtp_InvoiceDate_ValueChanged(Nothing, Nothing)

        Try
            If _Purchase = EnterMode.IsPurchaseOrder Then

                Dim tbl As DataTable = xRead("SELECT * FROM clInvoiceOrders WHERE clInvoiceCode='" & Inv & "'", "clInvoiceOrders", cTXNs)
                For Each row In tbl.Rows
                    t_SupplierName.Text = row("clCustomer")
                    dtp_InvoiceDate.Value = row("clDate")
                    l_OrderDate.Text = String.Concat("Order Date: ", CDate(row("clDate")).ToShortDateString)
                    sessionId = row("SerialId").ToString
                Next

                tbl = xRead("SELECT * FROM clPurchaseOrder WHERE clOrderInvoice='" & Inv & "'", "clPurchaseOrder", cTXNs)
                dg_TXNs.Rows.Clear()
                For Each row In tbl.Rows

                    Dim Dsc As Integer = 0
                    Try
                        Dsc = CInt(Qry("SELECT clDiscount FROM clItems WHERE SerialId='" & row("SerialId").ToString & "'", cItems))
                    Catch ex As Exception
                        Dsc = 0
                    End Try

                    dg_TXNs.Rows.Add(row("clItemId"),
                                                row("clItem"),
                                                row("clQuantity"),
                                     0,
                                     0,
                                                row("clCost"),
                                     0,
                                     Dsc,
                                     0.05 * row("clCost"))
                Next

                calcTotals()

            ElseIf _Purchase = EnterMode.IsNewEntry Then
                Inv = rcpt()
                xQry("INSERT INTO clInvoices (clInvoiceCode) VALUES ('" & Inv & "')", cTXNs)
                xQry("INSERT INTO clPurchases (clOrderInvoice) VALUES ('" & Inv & "')", cTXNs)

                With Date.Now
                    sessionId = String.Concat(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond)
                End With

            End If

            l_Inv.Text = String.Concat("Invoice No.: ", Inv)

        Catch ex As Exception
            write_Error(ex.Message, Name)
            MsgBox(ex.Message)
        End Try

    End Sub
    Function rcpt() As String
        Try
            Dim final As Integer = 100000 + calcVal("SerialId",
                                  "clInvoices",
                    CalcMode.GetCount,
                                    cTXNs,
                                        " WHERE clInvoiceCode ILIKE '%P%'")
            rcpt = String.Concat("P" & final)

        Catch ex As Exception
            write_Error("Invoice Generation Error; " & ex.Message)
            MsgBox("Invoice Generation Error; " & ex.Message)
        End Try

    End Function
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        If _Purchase = EnterMode.IsNewEntry Then btnNew_Click(Nothing, Nothing)
        InitiateEntry()
        dg_TXNs.Focus()
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
            btnSaveSession_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F2 Then
            btnSavePrintSession_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            _Clear(_this.AsReset)
        End If

    End Sub
    Enum _this
        AsAdd
        AsReset
    End Enum
    Sub _Clear(_From As _this)
        Dim execution As Boolean = False
        If _Purchase = EnterMode.IsNewEntry Then dg_TXNs.Rows.Clear()
        calcTotals()
        If _From = _this.AsAdd Then
            execution = False
            Try
                outstanding = Qry("SELECT clOutstanding FROM clSuppliers WHERE clName='" & t_SupplierName.Text & "'")
            Catch ex As Exception
                outstanding = 0
            End Try
            l_Outstanding.Text = "Outstanding: " & FormatNumber(outstanding, 2)

        ElseIf _From = _this.AsReset Then
            autosText(t_SupplierName, "clName", "clSuppliers", c)
            execution = True
            t_SupplierName.Clear()
            l_CompanyName.Text = "Company Name: "
            outstanding = 0
            l_Outstanding.Text = "Outstanding: " & FormatNumber(outstanding, 2)
            l_BillDate.Text = String.Concat("Bill Date: ", Date.Now.ToShortDateString)
            l_OrderDate.Text = String.Concat("Order Date: ")
        End If

        t_SupplierName.Enabled = execution

        btnSavePrintSession.Enabled = Not execution

        btnSaveSession.Enabled = Not execution

        FromOut = False

    End Sub
    Sub disposeInvoice()
        xQry("DELETE FROM clInvoices WHERE clClient IS NULL OR clClient=''", cTXNs)
        xQry("DELETE FROM clPurchases WHERE clUser IS NULL OR clUser=''", cTXNs)
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _Purchase = EnterMode.IsNewEntry
        disposeInvoice()
        _Clear(_this.AsReset)
    End Sub
    Private outstanding As Decimal
    Sub calcTotals()
        l_ItemsTotal.Text = "Total Items: " & FormatNumber(dg_TXNs.Rows.Count - 1, 2)
        l_Qty.Text = "Total Qty.: " & FormatNumber(subTotal(2), 2)
        l_FreeTotal.Text = "Total Free: " & FormatNumber(subTotal(3), 2)
        l_Discounts.Text = "Total Discounts: " & FormatNumber(subTotal(7), 2) & "%"
        l_Outstanding.Text = "Outstanding: " & FormatNumber(outstanding, 2)
        l_Total.Text = FormatNumber(subTotal(10), 2)
    End Sub
    Function subTotal(col As Integer) As Decimal
        Dim TotalValue As Decimal
        Dim tmp As Decimal
        For n As Integer = 0 To dg_TXNs.Rows.Count - 1
            Dim nDR As DataGridViewRow = dg_TXNs.Rows(n)
            With nDR
                If Decimal.TryParse(.Cells(col).Value, tmp) Then
                    TotalValue += tmp
                End If
            End With
        Next

        Return TotalValue
    End Function

    Sub getDetails()
        If t_SupplierName.Text.Length < 1 Then Exit Sub

        _Clear(_this.AsAdd)

    End Sub

    Private onCellEdit As Boolean = False
    Private Sub dg_List_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_TXNs.EditingControlShowing
        Dim autoBox As TextBox = TryCast(e.Control, TextBox)
        If autoBox Is Nothing Then Exit Sub
        If dg_TXNs.CurrentCell.ColumnIndex = 1 Then
            If dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "ITEM NAME" Then
                autosText(autoBox, "clName", "clItems", cItems)
            Else
                autosText(autoBox, "clName", "clItems", cItems, True)
            End If
        Else
            autosText(autoBox, "clName", "clItems", cItems, True)
        End If

        If dg_TXNs.CurrentCell.ColumnIndex = 0 Or
            dg_TXNs.CurrentCell.ColumnIndex = 2 Or
            dg_TXNs.CurrentCell.ColumnIndex = 3 Or
            dg_TXNs.CurrentCell.ColumnIndex = 4 Or
            dg_TXNs.CurrentCell.ColumnIndex = 5 Or
            dg_TXNs.CurrentCell.ColumnIndex = 6 Or
            dg_TXNs.CurrentCell.ColumnIndex = 7 Or
            dg_TXNs.CurrentCell.ColumnIndex = 8 Or
            dg_TXNs.CurrentCell.ColumnIndex = 9 Or
            dg_TXNs.CurrentCell.ColumnIndex = 10 Then
            If dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "QTY" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "PURCHASE RATE" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "DISCOUNT (%)" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "MARGIN (%)" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "VAT (5%)" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "FREE" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "SELLING RATE" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "TOTAL" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "CODE" Or
                dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "MRP" Then
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

    Private FromOut As Boolean = False
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

            tbl = xRead("SELECT SerialId,clName,clUnitCost,clPrice,clDiscount,clMargin " &
                    "FROM clItems" & condition,
                    "clItems",
                                cItems)

            If String.IsNullOrEmpty(ItemName) Then Exit Sub

            For Each row In tbl.Rows

                Dim dR As DataGridViewRow = dg_TXNs.Rows(r)
                With dR

                    If Not FromOut Then
                        .Cells(0).Value = row(0).ToString
                        .Cells(1).Value = row(1).ToString
                        If .Cells(2).Value Is DBNull.Value Or .Cells(2).Value = 0 Then
                            .Cells(2).Value = 1
                        End If
                        If .Cells(3).Value Is DBNull.Value Or .Cells(3).Value = 0 Then
                            .Cells(3).Value = 0
                        End If
                        If .Cells(4).Value Is DBNull.Value Or .Cells(4).Value = 0 Then
                            .Cells(4).Value = 0
                        End If
                        If .Cells(5).Value Is DBNull.Value Or .Cells(5).Value = 0 Then
                            .Cells(5).Value = row(2)
                        End If
                        If .Cells(6).Value Is DBNull.Value Or .Cells(6).Value = 0 Then
                            .Cells(6).Value = row(3)
                        End If
                        If .Cells(7).Value Is DBNull.Value Or .Cells(7).Value = 0 Then
                            .Cells(7).Value = row(4)
                        End If
                        If .Cells(9).Value Is DBNull.Value Or .Cells(9).Value = 0 Then
                            .Cells(9).Value = row(5)
                        End If

                    Else
                        Dim SiValues As String() = New String() {row(0).ToString,
                                                                    row(1).ToString,
                                                                    1,
                                                                    0,
                                                                    0,
                                                                    row(2),
                                                                    row(3),
                                                                    row(4),
                                                                    row(5)}

                        dg_TXNs.Rows.Add(SiValues)

                    End If

                End With

                onCellEdit = True

            Next

        Catch ex As Exception

            write_Error("Cannot load Item details. Please Check error code" & ex.HResult & vbNewLine & ex.Message)

            'MsgBox("Cannot load Item details. Please Check error code" & ex.HResult & " / " & vbNewLine & ex.Message)

        End Try

    End Sub
    Sub deleteRow()
        Try
            Dim counter As Integer = dg_TXNs.CurrentRow.Index
            dg_TXNs.Rows.RemoveAt(counter)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellLeave
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
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellValueChanged
        calcTotals()

        dg_list_CellEnter(Me, e)

    End Sub
    Dim r As Integer = -1
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellEnter

        Try
            r = e.RowIndex
            Dim dR As DataGridViewRow = dg_TXNs.Rows(r)
            With dR
                If dg_TXNs.CurrentCell.ColumnIndex = 1 Then
                    AddAs = DetailFrom.ItemName
                    loadDetails(.Cells(1).Value)
                ElseIf dg_TXNs.CurrentCell.ColumnIndex = 0 Then
                    AddAs = DetailFrom.ItemCode
                    loadDetails(.Cells(0).Value)
                End If

                Dim Qty, Margin, Rate, Selling, dscPrc, Ttl, Final, VAT
                Rate = .Cells(5).Value
                Selling = .Cells(6).Value

                If .Cells(4).Value > 0 Then
                    Margin = (100 - .Cells(4).Value) / 100
                    Ttl = Math.Round(Rate / Margin, 2)
                Else
                    Ttl = Selling
                End If

                .Cells(9).Value = Ttl

                dscPrc = .Cells(7).Value / 100

                Qty = .Cells(2).Value - .Cells(3).Value

                Final = (Ttl * Qty) - dscPrc

                VAT = 0.05 * Ttl

                .Cells(8).Value = VAT * Qty

                .Cells(10).Value = FormatNumber(Final, 2, TriState.True)

            End With

            calcAddVal()

            calcTotals()

        Catch ex As Exception
        End Try

        If Not FromOut Then
            Try
                Dim nDr As DataGridViewRow = dg_TXNs.Rows(r)
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
        r = dg_TXNs.CurrentRow.Index
        Dim c As Integer = r - 1
        Dim dR As DataGridViewRow = dg_TXNs.Rows(r)
        With dR
            If c >= 0 Then
                Dim eR As DataGridViewRow = dg_TXNs.Rows(c)
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
    Private Sub dg_List_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellContentClick
        dg_list_CellEnter(Nothing, Nothing)
    End Sub
    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_TXNs.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_TXNs.CurrentRow.Index
                dg_TXNs.Rows.RemoveAt(counter)
            Catch ex As Exception
            Finally
                calcTotals()
            End Try
        ElseIf e.KeyData = Keys.Enter Then
            Dim t As Integer = dg_TXNs.CurrentRow.Index
            Dim ndr As DataGridViewRow = dg_TXNs.Rows(t)
            With ndr
                If dg_TXNs.CurrentCell.ColumnIndex = 0 Or dg_TXNs.CurrentCell.ColumnIndex = 1 Then
                    If Not Trim(.Cells(0).Value) = "" Or Not Trim(.Cells(1).Value) = "" Then Exit Sub
                    CurrentItem = SearchIs.Create
                    Code = ""
                    searchModule = IsIn.TXNMode
                    Dim h As New ItemSearch : If Not h.Visible Then h.ShowDialog()
                    If Code = "" Then deleteRow() : Exit Sub
                    If AddAs = DetailFrom.AbsolutelyNothing__Pity Then deleteRow() : Exit Sub
                    FromOut = True

                    If dg_TXNs.CurrentCell.ColumnIndex = 0 Then
                        AddAs = DetailFrom.ItemCode
                        t = dg_TXNs.CurrentRow.Index
                        loadDetails(Code)
                        dg_TXNs.CurrentCell = dg_TXNs.Rows(t).Cells(0)
                    ElseIf dg_TXNs.CurrentCell.ColumnIndex = 1 Then
                        AddAs = DetailFrom.ItemName
                        t = dg_TXNs.CurrentRow.Index
                        loadDetails(Code)
                        dg_TXNs.CurrentCell = dg_TXNs.Rows(t).Cells(1)
                    End If

                    FromOut = False

                End If
            End With
        End If
    End Sub

    Enum ModeIs
        SaveAndPrint
        SaveOnly
        None
    End Enum
    Private CurrentPrint As ModeIs = ModeIs.None
    Sub PleaseComplain()
        MsgBox("Invoice Amount Cannot Be Less Than Purchase Amount. Please Review", MsgBoxStyle.Information, "CyPOS")
    End Sub
    Private iUpdate As Boolean = False
    Private Sql As String = ""
    Dim sessionId As String
    Sub updateStockByPurchase()

        If dg_TXNs.Rows.Count <= 0 Then ShowMessage("Nothing to save! Cannot continue", _Method.AsError) : Exit Sub

        ThisClient = IsA.Supplier

        _SubTotal = subTotal(10)

        calcTotals()

        Payments.ShowDialog(Me)

        If PayMode = _Is.__SadlyNothing___Pity Then MsgBox("Cannot proceed!", MsgBoxStyle.Information) : Exit Sub

        Dim Sql As String = ""

        Try

            If cTXNs.State = ConnectionState.Closed Then cTXNs.Open()

            If _Purchase = EnterMode.IsNewEntry Then
                Sql = "UPDATE clInvoices SET SerialId=@SerialId," &
                                              "clCreationDate=@clCreationDate," &
                                              "clPaymentMethod=@clPaymentMethod," &
                                              "clQty=@clQty," &
                                              "clAmountExpected=@clAmountExpected," &
                                              "clAmountPaid=@clAmountPaid," &
                                              "clDiscount=@clDiscount," &
                                              "clClient=@clClient," &
                                              "clUser=@clUser," &
                                              "clType=@clType," &
                                              "clSeries=@clSeries," &
                                              "clBillDate=@clBillDate," &
                                              "clActivityStatus=@clActivityStatus" &
                                 " WHERE clInvoiceCode='" & Inv & "'"

            ElseIf _Purchase = EnterMode.IsPurchaseOrder Then
                Sql = "UPDATE clInvoices SET clPaymentMethodUpdate=@clPaymentMethodUpdate," &
                                                     "clQtyUpdate=@clQtyUpdate," &
                                                     "clAmountExpectedUpdate=@clAmountExpectedUpdate," &
                                                     "clAmountPaidUpdate=@clAmountPaidUpdate," &
                                                     "clDiscountUpdate=@clDiscountUpdate," &
                                                     "clModifDate=@clModifDate," &
                                                     "clModifUser=@clModifUser," &
                                                     "clModifClient=@clModifClient," &
                                                     "clActivityStatus=@clActivityStatus" &
                                        " WHERE clInvoiceCode='" & Inv & "'"

            End If

            Dim Mrc As String = l_CompanyName.Text.Replace("Company Name:", "")

            Dim d1 As Date
            With Date.Now
                d1 = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With

            Dim cmd As New NpgsqlCommand(Sql,
                                         cTXNs)
            With cmd

                If _Purchase = EnterMode.IsNewEntry Then
                    .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = sessionId
                    .Parameters.Add(New NpgsqlParameter("@clCreationDate", NpgsqlDbType.Timestamp)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = payMeans()
                    .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(2)
                    .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = _SubTotal
                    .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = AmountPaid
                    .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clClient", NpgsqlDbType.Varchar)).Value = t_SupplierName.Text
                    .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr
                    .Parameters.Add(New NpgsqlParameter("@clType", NpgsqlDbType.Varchar)).Value = "Purchase"
                    .Parameters.Add(New NpgsqlParameter("@clSeries", NpgsqlDbType.Varchar)).Value = "Inbound Purchase"
                    .Parameters.Add(New NpgsqlParameter("@clBillDate", NpgsqlDbType.Date)).Value = dtp_InvoiceDate.Value

                ElseIf _Purchase = EnterMode.IsPurchaseOrder Then
                    .Parameters.Add(New NpgsqlParameter("@clPaymentMethodUpdate", NpgsqlDbType.Varchar)).Value = payMeans()
                    .Parameters.Add(New NpgsqlParameter("@clQtyUpdate", NpgsqlDbType.Integer)).Value = subTotal(2)
                    .Parameters.Add(New NpgsqlParameter("@clAmountExpectedUpdate", NpgsqlDbType.Bigint)).Value = _SubTotal
                    .Parameters.Add(New NpgsqlParameter("@clAmountPaidUpdate", NpgsqlDbType.Bigint)).Value = TotalPrice
                    .Parameters.Add(New NpgsqlParameter("@clDiscountUpdate", NpgsqlDbType.Bigint)).Value = subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Timestamp)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clModifUser", NpgsqlDbType.Varchar)).Value = usr
                    .Parameters.Add(New NpgsqlParameter("@clModifClient", NpgsqlDbType.Varchar)).Value = Mrc
                    .Parameters.Add(New NpgsqlParameter("@clActivityStatus", NpgsqlDbType.Integer)).Value = If(subTotal(2) <= 0, InvoiceIsOpen, InvoiceIsClosed)

                End If

                If cTXNs.State = ConnectionState.Closed Then cTXNs.Open()

                Dim fSn As Integer = .ExecuteNonQuery()
                If fSn > 0 Then

                    GoTo 2
                End If
            End With

            Exit Sub

2:          If _Purchase = EnterMode.IsPurchaseOrder Then
                Sql = "UPDATE clPurchases SET clSessionId=@clSessionId," &
                                                                   "clSessionType=@clSessionType," &
                                                                   "clDate=@clDate," &
                                                                   "clTime=@clTime," &
                                                                   "clItem=@clItem," &
                                                                   "clQuantity=@clQuantity," &
                                                                   "clFreeQty=@clFreeQty," &
                                                                   "clSupplier=@clSupplier," &
                                                                   "clCost=@clCost," &
                                                                   "clPrice=@clPrice," &
                                                                   "clDiscount=@clDiscount," &
                                                                   "clMarginPrcnt=@clMarginPrcnt," &
                                                                   "clMRP=@clMRP," &
                                                                   "clUser=@clUser " &
                           "WHERE clOrderInvoice='" & Inv & "'"

            ElseIf _Purchase = EnterMode.IsNewEntry Then
                Sql = "INSERT INTO clPurchases (clOrderInvoice,clSessionId,clSessionType," &
                                                                     "clCreationDate," &
                                                                     "clItem,clQuantity,clFreeQty,clSupplier,clCost,clPrice,clDiscount," &
                                                                     "clMarginPrcnt,clMRP," &
                                                                     "clUser) VALUES " &
                                                                "(@clOrderInvoice,@clSessionId,@clSessionType," &
                                                                  "@clCreationDate," &
                                                                  "@clItem,@clQuantity,@clFreeQty,@clSupplier,@clCost,@clPrice,@clDiscount," &
                                                                  "@clMarginPrcnt,@clMRP," &
                                                                  "@clUser)"

            End If

            Dim Itp As Integer
            Try
                Itp = Qry("SELECT clStatus FROM clInvoiceOrders WHERE clInvoiceCode='" & Inv & "'", cTXNs)
            Catch ex As Exception
                Itp = -1
            End Try
            If Not Itp = -1 Then
                If Itp = InvoiceIsOpen Then
                    If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
                    Dim uSql As String = "UPDATE clInvoiceOrders SET clPaymentMethod=@clPaymentMethod," &
                                                                "clQty=@clQty," &
                                                                "clAmountExpected=@clAmountExpected," &
                                                                "clAmountPaid=@clAmountPaid," &
                                                                "clCustomer=@clCustomer," &
                                                                "clStatus=@clStatus," &
                                                                "clModifDate=@clModifDate," &
                                                                "clModifUser=@clModifUser" &
                                                                         " WHERE clInvoiceCode='" & Inv & "'"
                    Dim uCmd As New NpgsqlCommand(uSql, cTXNs)
                    With uCmd
                        .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = payMeans()
                        .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(2)
                        .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = _SubTotal
                        .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = AmountPaid
                        .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = Mrc
                        .Parameters.Add(New NpgsqlParameter("@clStatus", NpgsqlDbType.Integer)).Value = InvoiceIsClosed
                        .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = d1.Date
                        .Parameters.Add(New NpgsqlParameter("@clModifUser", NpgsqlDbType.Varchar)).Value = usr

                        If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

                        Dim fSn As Integer = .ExecuteNonQuery()
                        If fSn > 0 Then
                            If Not cTXNs.State = ConnectionState.Closed Then cTXNs.Close()
                        End If
                    End With

                End If
            End If

            If CurrentPrint = ModeIs.SaveAndPrint Then Call xCr(ThisBillMode)

            For Each row As DataGridViewRow In dg_TXNs.Rows

                If Not row.Cells(1).Value = "" Then

                    With cTXNs
                        If Not .State = ConnectionState.Open Then .Open()
                    End With
                    Dim cm_ As New NpgsqlCommand(Sql,
                                           cTXNs)
                    With cm_

                        If _Purchase = EnterMode.IsNewEntry Then .Parameters.Add(New NpgsqlParameter("@clOrderInvoice", NpgsqlDbType.Varchar)).Value = Inv
                        .Parameters.Add(New NpgsqlParameter("@clSessionId", NpgsqlDbType.Varchar)).Value = row.Cells(0).Value
                        .Parameters.Add(New NpgsqlParameter("@clSessionType", NpgsqlDbType.Varchar)).Value = "Purchase Entry"
                        .Parameters.Add(New NpgsqlParameter("@clCreationDate", NpgsqlDbType.Timestamp)).Value = d1
                        .Parameters.Add(New NpgsqlParameter("@clItem", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                        .Parameters.Add(New NpgsqlParameter("@clQuantity", NpgsqlDbType.Integer)).Value = v(row.Cells(2).Value)
                        .Parameters.Add(New NpgsqlParameter("@clFreeQty", NpgsqlDbType.Integer)).Value = v(row.Cells(3).Value)
                        .Parameters.Add(New NpgsqlParameter("@clSupplier", NpgsqlDbType.Varchar)).Value = t_SupplierName.Text
                        .Parameters.Add(New NpgsqlParameter("@clCost", NpgsqlDbType.Bigint)).Value = v(row.Cells(5).Value)
                        .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = v(row.Cells(6).Value)
                        .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = v(row.Cells(7).Value)
                        .Parameters.Add(New NpgsqlParameter("@clMarginPrcnt", NpgsqlDbType.Integer)).Value = v(row.Cells(4).Value)
                        .Parameters.Add(New NpgsqlParameter("@clMRP", NpgsqlDbType.Integer)).Value = v(row.Cells(9).Value)
                        .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr
                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then
                            cTXNs.Close()

                            If CurrentPrint = ModeIs.SaveAndPrint Then
                                Dim fQty As Object = row.Cells(2).Value - row.Cells(3).Value
                                LoadCrVw(ThisBillMode, v(fQty), row.Cells(0).Value, row.Cells(1).Value, v(row.Cells(10).Value), v(row.Cells(7).Value))
                            End If

                        End If
                    End With

                End If

            Next

            Dim mgReq As MsgBoxResult = MsgBox("Update new price?", MsgBoxStyle.YesNo)

            If mgReq = MsgBoxResult.Yes Then iUpdate = True Else iUpdate = False

            For Each rw As DataGridViewRow In dg_TXNs.Rows
                If Not rw.Cells(1).Value = "" Then
                    If Not cItems.State = ConnectionState.Open Then cItems.Open()

                    Dim cm As New NpgsqlCommand("UPDATE clItems SET clPrice=@clPrice," &
                                                                                                               "clQty=@clQty,clDiscount=@clDiscount," &
                                                                                                               "clUnitCost=@clUnitCost," &
                                                                                                               "clVAT=@clVAT," &
                                                                                                               "clVATInclusive=@clVATInclusive," &
                                                                                                               "clMargin=@clMargin,LastTXNSupplies=@LastTXNSupplies " &
                                                                                                               "WHERE SerialId='" & rw.Cells(0).Value & "'",
                                             cItems)
                    With cm
                        Dim price = Nothing
                        If iUpdate Then
                            price = rw.Cells(9).Value
                        Else
                            price = rw.Cells(6).Value
                        End If
                        .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = price
                        Dim pQty As Integer = Qry("SELECT clQty FROM clItems WHERE SerialId='" &
                                                  rw.Cells(0).Value & "'",
                                                  cItems)
                        Dim Qty As Integer = rw.Cells(2).Value - rw.Cells(3).Value

                        Dim fQty As Integer = Qty + pQty

                        .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = fQty

                        Dim Disc As Object = CDec(rw.Cells(7).Value / 100) * price

                        .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = Disc

                        .Parameters.Add(New NpgsqlParameter("@clUnitCost", NpgsqlDbType.Bigint)).Value = rw.Cells(5).Value

                        Dim toVAT As Boolean = False
                        If rw.Cells(8).Value > 0 Then toVAT = True Else toVAT = 0
                        .Parameters.Add(New NpgsqlParameter("@clVAT", NpgsqlDbType.Integer)).Value = IIf(toVAT, rw.Cells(8).Value / Qty, 0)
                        .Parameters.Add(New NpgsqlParameter("@clVATInclusive", NpgsqlDbType.Integer)).Value = IIf(toVAT, 1, 0)
                        .Parameters.Add(New NpgsqlParameter("@clMargin", NpgsqlDbType.Integer)).Value = v(rw.Cells(5).Value)
                        .Parameters.Add(New NpgsqlParameter("@LastTXNSupplies", NpgsqlDbType.Date)).Value = d1.Date
                        If Not cItems.State = ConnectionState.Open Then cItems.Open()
                        Dim _fSnd As Integer = .ExecuteNonQuery()
                        If _fSnd > 0 Then
                            cItems.Close()

                            UpdateClosing(rw.Cells(0).Value, Qty)

                        End If
                    End With

                End If

            Next

7:          Dim oX As Decimal = 0
            If PayMode = _Is.Bank Or PayMode = _Is.Cash Or PayMode = _Is.CashPOS Then
                If TotalPrice > outstanding Then
                    oX = TotalPrice
                Else
                    oX = outstanding - TotalPrice
                End If
            End If

            '//modified details 17-05-2020
            xQry("UPDATE clSuppliers SET clOutstanding='" & oX & "' WHERE clName='" & t_SupplierName.Text & "'", c) '//error found 12-04-2020 1.15; worked on 04-05-2020 11:58

            If CurrentPrint = ModeIs.SaveOnly Then MsgBox("Stock purchase update success!")

            If CurrentPrint = ModeIs.SaveAndPrint Then
                LoadCrVw(t_SupplierName.Text, dtp_InvoiceDate.Value.Date)
            End If

            _Clear(_this.AsReset)

        Catch ex As Exception
            write_Error(ex.Message, Name)
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Cy POS")
            If cTXNs.State = ConnectionState.Open Then cTXNs.Close()
            cTXNs.Close()
            CurrentPrint = ModeIs.None
        End Try

    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs)
        If t_SupplierName.Text.Length < 1 Then Exit Sub
        _Clear(_this.AsAdd)
        dg_TXNs.Focus()
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

    Private Sub dtp_InvoiceDate_ValueChanged(sender As Object, e As EventArgs)
        l_OrderDate.Text = String.Concat("Order Date: ", dtp_InvoiceDate.Value.ToShortDateString)
    End Sub

    Private Sub btnSaveSession_Click(sender As Object, e As EventArgs) Handles btnSaveSession.Click
        CurrentPrint = ModeIs.SaveOnly
        updateStockByPurchase()
    End Sub
    Private Sub btnSavePrintSession_Click(sender As Object, e As EventArgs) Handles btnSavePrintSession.Click
        CurrentPrint = ModeIs.SaveAndPrint
        updateStockByPurchase()
    End Sub

End Class