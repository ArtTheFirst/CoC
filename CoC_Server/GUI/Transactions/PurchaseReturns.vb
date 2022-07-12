Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class PurchaseReturns

    Private tbl As DataTable = Nothing
    Sub disBandTbl()
        Try
            tbl.Clear()
            dg_TXNs.DataSource = tbl
            dg_TXNs.DataSource = Nothing
            dg_TXNs.Rows.Clear()
            dg_TXNs.Columns.Clear()
            tbl.Dispose()
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Initial = False
        clearAll(True)
        l_Usr.Text = "Initiated by: " & usr
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        'ThisBillMode = CurrentlyIs._Nothing
        'ThisClient = IsA.nEmptyString
        clearAll(True)
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            btnFindInvoice_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            btnReset_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            clearAll(True)
            Close()
        End If

    End Sub
    Private SRC As Integer = 0
    Sub clearAll(IsFirst As Boolean)
        l_SessionId.Text = String.Concat("Session Id: ")
        l_SupplierName.Text = String.Concat("Supplier Name: ")
        l_OrderDate.Text = String.Concat("Order Date: ")
        l_BillDate.Text = String.Concat("Bill Date: ")
        l_Qty.Text = "[Qty]"
        l_QtyAmt.Text = "[Amt]"
        disBandTbl()
        'If IsFirst Then Inv = ""
        l_InvoiceCode.Text = String.Concat("Invoice No.: ", Inv)
        SRC = 0
        calcTotal()
    End Sub

    Sub WithInvoiceCode()

        l_InvoiceCode.Text = String.Concat("Invoice No.: ", Inv)

        InitiateEntry()

    End Sub
    Sub findInvoice()
        ThisBillMode = CurrentlyIs.Purchase
        ThisClient = IsA.Supplier
        Dim f As New InvoiceFinder
        If Not f.Visible Then f.ShowDialog()

        If Inv = "" Then clearAll(True) : Exit Sub

        Dim InvTyp As String = Nothing
        Try
            InvTyp = Qry("SELECT clSeries FROM clInvoices WHERE clInvoiceCode='" & Inv & "'", cTXNs)
        Catch ex As Exception
            InvTyp = ""
        End Try

        If InvTyp = "" Then clearAll(True) : Exit Sub

        If InvTyp = "Returns" Then clearAll(True) : Exit Sub

        WithInvoiceCode()

    End Sub
    Sub InitiateEntry()

        Try

            disBandTbl()

            tbl = xRead("SELECT * FROM clInvoices WHERE clInvoiceCode='" & Inv & "'", "clInvoices", cTXNs)
            For Each row In tbl.Rows
                l_SessionId.Text = String.Concat("Session Id: ", row("SerialId").ToString)
                l_SupplierName.Text = String.Concat("Supplier Name: ", row("clCustomer").ToString)
                l_OrderDate.Text = String.Concat("Order Date: ", CDate(row("clDate")).ToShortDateString)
                l_BillDate.Text = String.Concat("Bill Date: ", CDate(row("clDate")).ToShortDateString)
                l_PaymentType.Text = String.Concat(row("clPaymentMethod").ToString, " Entry")
            Next

            tbl = xRead("SELECT clSessionId,clItem," &
                                             "clQuantity,clFreeQty,clCost,clDiscount " &
                                              "FROM clPurchases " &
                                                  "WHERE clOrderInvoice='" & Inv & "' AND clQuantity>0",
                        "clPurchases",
                        cTXNs)
            dg_TXNs.DataSource = tbl

            dg_TXNs.Columns.Item(0).HeaderText = "CODE"
            dg_TXNs.Columns.Item(0).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_TXNs.Columns.Item(0).Width = 100
            dg_TXNs.Columns.Item(0).ReadOnly = True

            dg_TXNs.Columns.Item(1).HeaderText = "ITEM NAME"
            dg_TXNs.Columns.Item(1).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_TXNs.Columns.Item(1).ReadOnly = True
            dg_TXNs.Columns.Item(1).Width = 390

            dg_TXNs.Columns.Item(2).HeaderText = "QTY."
            dg_TXNs.Columns.Item(2).DefaultCellStyle.Format = "n0"
            dg_TXNs.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_TXNs.Columns.Item(2).Width = 80

            dg_TXNs.Columns.Item(3).HeaderText = "FREE QTY."
            dg_TXNs.Columns.Item(3).DefaultCellStyle.Format = "n0"
            dg_TXNs.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_TXNs.Columns.Item(3).Width = 80

            dg_TXNs.Columns.Item(4).HeaderText = "RATE"
            dg_TXNs.Columns.Item(4).DefaultCellStyle.Format = "n2"
            dg_TXNs.Columns.Item(4).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_TXNs.Columns.Item(4).Width = 150
            dg_TXNs.Columns.Item(4).ReadOnly = True

            dg_TXNs.Columns.Item(5).HeaderText = "DISCOUNT"
            dg_TXNs.Columns.Item(5).DefaultCellStyle.Format = "n2"
            dg_TXNs.Columns.Item(5).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_TXNs.Columns.Item(5).Width = 150
            dg_TXNs.Columns.Item(5).ReadOnly = True

            Dim dgCl As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
            dgCl.HeaderText = "TOTAL"
            dg_TXNs.Columns.Add(dgCl)
            dg_TXNs.Columns.Item(6).DefaultCellStyle.Format = "n2"
            dg_TXNs.Columns.Item(6).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_TXNs.Columns.Item(6).Width = 150
            dg_TXNs.Columns.Item(6).ReadOnly = True

            dgCl = New DataGridViewTextBoxColumn
            dgCl.HeaderText = "RETURN QTY."
            dg_TXNs.Columns.Add(dgCl)
            dg_TXNs.Columns.Item(7).DefaultCellStyle.Format = "n0"
            dg_TXNs.Columns.Item(7).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_TXNs.Columns.Item(7).Width = 80
            dg_TXNs.Columns.Item(7).ReadOnly = False

            dgCl = New DataGridViewTextBoxColumn
            dgCl.HeaderText = "FINAL QTY."
            dg_TXNs.Columns.Add(dgCl)
            dg_TXNs.Columns.Item(8).DefaultCellStyle.Format = "n0"
            dg_TXNs.Columns.Item(8).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_TXNs.Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_TXNs.Columns.Item(8).Width = 120
            dg_TXNs.Columns.Item(8).ReadOnly = False

            Initial = True

            'EqualizeInitial()

            For i = 0 To dg_TXNs.Rows.Count - 1
                EqualizeInitial(i)
            Next

            EqualizeCells()

            calcTotal()

            Initial = False

            InitUpdate = CDec(l_QtyAmt.Text)

        Catch ex As Exception
            write_Error(ex.Message, Name)
        End Try

    End Sub
    Dim InitUpdate As Decimal = 0
    Private Initial As Boolean = False
    Sub calcTotal()
        l_Qty.Text = "Purchase Qty.: " & subTotal(2) - subTotal(3)
        Dim QtyTotal As Integer = 0
        QtyTotal = subTotal(8)
        l_RtnQty.Text = "Returned Qty.: " & QtyTotal
        l_QtyAmt.Text = FormatNumber(subTotal(6), 0)
    End Sub
    Sub EqualizeInitial(Ndx)
        If Not Initial Then Exit Sub
        Dim dR As DataGridViewRow = dg_TXNs.Rows(Ndx)
        With dR
            Dim SQty As Decimal = 0.0
            Dim _Qty As Decimal = .Cells(2).Value - .Cells(3).Value
            Try
                SQty = Qry("SELECT clReturnedQuantity FROM clPurchaseReturns WHERE clTransferInvoiceCode='" & Inv & "' AND clItemId='" & .Cells(0).Value & "'", cTXNs)
                'SQty = Qry("SELECT clReturnedQuantity FROM clTXNsReturns WHERE clItemId='" & .Cells(0).Value & "'", cTXNs)
            Catch ex As Exception
                SQty = 0.0
            End Try
            .Cells(8).Value = _Qty - SQty
        End With
    End Sub
    Sub EqualizeCells()
        Try
            For i = 0 To dg_TXNs.Rows.Count
                Dim dR As DataGridViewRow = dg_TXNs.Rows(i)
                With dR
                    Dim tCalc = 0
                    Dim fQty As Decimal = .Cells(2).Value - .Cells(3).Value
                    tCalc = (.Cells(4).Value * (fQty - .Cells(7).Value)) - .Cells(5).Value

                    .Cells(6).Value = FormatNumber(tCalc, 0)
                End With

                calcTotal()

            Next

        Catch ex As Exception
        End Try
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
    Private Sub dg_TXNs_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellEnter
        Try
            Dim nDr As DataGridViewRow = dg_TXNs.Rows(e.RowIndex)
            With nDr
                Dim fQty As Decimal = .Cells(2).Value - .Cells(3).Value
                If .Cells(7).Value > fQty Then
                    .Cells(7).Value = 0
                End If

                .Cells(5).Value = (.Cells(4).Value * (fQty - .Cells(7).Value)) - .Cells(5).Value

                Try
                    tbl = xRead("SELECT * FROM clDiscountables WHERE SerialId='" & .Cells(0).Value & "'", "clDiscountables")
                    For Each row In tbl.Rows
                        Dim todaysDate As Date = Date.Now

                        Dim d1, d2 As Date
                        With CType(row("clStartDate"), Date)
                            d1 = New Date(.Year, .Month, .Day, 0, 0, 0)
                        End With
                        With CType(row("clEndDate"), Date)
                            d2 = New Date(.Year, .Month, .Day, 23, 59, 59)
                        End With

                        If todaysDate >= d1 And todaysDate <= d2 Then
                            Dim dbQty As Decimal = row("clQty")
                            Dim realQty As Decimal = CDec(.Cells(2).Value) - CDec(.Cells(6).Value)
                            If realQty >= dbQty Then
                                Dim c_ As String = CStr(realQty / dbQty)
                                If c_.Contains(".") Then
                                    c_ = c_.Substring(0, c_.IndexOf("."))
                                End If
                                .Cells(5).Value = row("clAmount") * (Val(c_))
                            ElseIf realQty < dbQty Then
                                .Cells(5).Value = 0
                            End If
                        End If

                    Next

                Catch ex As Exception
                    write_Error(ex.Message, Name)
                End Try

            End With
        Catch ex As Exception
        End Try
        EqualizeCells()
    End Sub
    Private Sub dg_TXNs_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellValueChanged
        dg_TXNs_CellEnter(Nothing, Nothing)
        Try
            Dim nDr As DataGridViewRow = dg_TXNs.Rows(e.RowIndex)
            With nDr
                Dim fQty As Decimal = .Cells(2).Value - .Cells(3).Value
                If .Cells(7).Value > fQty Then
                    .Cells(7).Value = 0
                End If
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_TXNs_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellLeave
        dg_TXNs_CellEnter(Nothing, Nothing)
    End Sub

    Sub InitiateReturn()
        If Trim(Inv) = "" Then Exit Sub

        Dim d1 As TimeSpan
        With Date.Now
            d1 = New TimeSpan(.Hour, .Minute, .Second)
        End With

        Dim tD As Date = New Date()
        With Date.Now
            tD = New Date(.Year, .Month, .Day)
        End With

        Dim MgReq As MsgBoxResult = MsgBox("Proceed?", MsgBoxStyle.OkCancel)
        If Not MgReq = MsgBoxResult.Ok Then Exit Sub
        Dim Sql As String = ""
        Try
            Dim Mrc As String = Nothing

            Mrc = l_SupplierName.Text.Replace("Client Name: ", "")

            Dim Xst As String = ""
            Try
                Xst = Qry("SELECT SessionId FROM clInvoiceReturned WHERE clInvoiceCode='" & Inv & "'",
                       cTXNs)
            Catch ex As Exception
                Xst = ""
            End Try
            If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
            Dim cm As New NpgsqlCommand
            Dim IsModif As Boolean = False

            If Xst = "" Then
                IsModif = False
                Sql = "INSERT INTO clInvoiceReturned " &
                                                                            "(SessionId,clInvoiceCode,clDate,clTime," &
                                                                                              "clCustomer," &
                                                                                              "clQty,clTotal,clInvoiceAmt,clDiscount," &
                                                                                              "clSeries," &
                                                                                              "clUser," &
                                                                                              "clQtyUpdate," &
                                                                                              "clTotalUpdate," &
                                                                                              "clInvoiceAmtUpdate," &
                                                                                              "clDiscountUpdate," &
                                                                                              "clModifDate," &
                                                                                              "clActivityStatus," &
                                                                                              "clInvoicePayOut," &
                                                                                              "clInvoicePayOutUpdate) " &
                                                                "VALUES (@SessionId,@clInvoiceCode,@clDate,@clTime," &
                                                                                              "@clCustomer," &
                                                                                              "@clQty,@clTotal,@clInvoiceAmt,@clDiscount," &
                                                                                              "@clSeries," &
                                                                                              "@clUser," &
                                                                                              "@clQtyUpdate," &
                                                                                              "@clTotalUpdate," &
                                                                                              "@clInvoiceAmtUpdate," &
                                                                                              "@clDiscountUpdate," &
                                                                                              "@clModifDate," &
                                                                                              "@clActivityStatus," &
                                                                                              "@clInvoicePayOut," &
                                                                                              "@clInvoicePayOutUpdate)"
            Else
                IsModif = True
                Sql = "UPDATE clInvoiceReturned Set clQtyUpdate=@clQtyUpdate," &
                                                                          "clTotalUpdate=@clTotalUpdate," &
                                                                          "clInvoiceAmtUpdate=@clInvoiceAmtUpdate," &
                                                                          "clDiscountUpdate=@clDiscountUpdate," &
                                                                          "clModifDate=@clModifDate," &
                                                                          "clLastModifier=@clLastModifier," &
                                                                          "clModifierTime=@clModifierTime," &
                                                                          "clActivityStatus=@clActivityStatus," &
                                                                          "clInvoicePayOut=@clInvoicePayOut," &
                                                                          "clInvoicePayOutUpdate=@clInvoicePayOutUpdate " &
                                                                          "WHERE " &
                                                                          "clInvoiceCode='" & Inv & "'"
            End If

            cm = New NpgsqlCommand(Sql,
                       cTXNs)
            Dim SsId As String = Nothing
            SsId = l_SessionId.Text.Replace("Session Id: ", "")

            Dim Qty As Decimal = CDec(l_QtyAmt.Text) - subTotal(5)

            Dim fA As Decimal = 0
            Try
                fA = Qry("SELECT clInvoicePayOut " &
                                   "FROM clInvoiceReturned " &
                                   "WHERE clInvoiceCode='" & Inv & "'", cTXNs)
            Catch ex As Exception
                fA = 0
            End Try
            Dim xA As Decimal = InitUpdate - Qty
            With cm
                If Not IsModif Then
                    .Parameters.Add(New NpgsqlParameter("@SessionId", NpgsqlDbType.Varchar)).Value = SsId
                    .Parameters.Add(New NpgsqlParameter("@clInvoiceCode", NpgsqlDbType.Varchar)).Value = Inv
                    .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = tD
                    .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = Mrc
                    .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clTotal", NpgsqlDbType.Integer)).Value = subTotal(8) - subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clInvoiceAmt", NpgsqlDbType.Bigint)).Value = Qty
                    .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = subTotal(5)
                    .Parameters.Add(New NpgsqlParameter("@clSeries", NpgsqlDbType.Varchar)).Value = "Purchases"
                    .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr

                    .Parameters.Add(New NpgsqlParameter("@clQtyUpdate", NpgsqlDbType.Integer)).Value = subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clTotalUpdate", NpgsqlDbType.Integer)).Value = subTotal(8) - subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clInvoiceAmtUpdate", NpgsqlDbType.Bigint)).Value = Qty
                    .Parameters.Add(New NpgsqlParameter("@clDiscountUpdate", NpgsqlDbType.Bigint)).Value = subTotal(5)
                    .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = tD

                    .Parameters.Add(New NpgsqlParameter("@clActivityStatus", NpgsqlDbType.Integer)).Value = If(Qty <= 0, InvoiceIsClosed, InvoiceIsOpen)
                    .Parameters.Add(New NpgsqlParameter("@clInvoicePayOut", NpgsqlDbType.Bigint)).Value = fA + xA
                    .Parameters.Add(New NpgsqlParameter("@clInvoicePayOutUpdate", NpgsqlDbType.Bigint)).Value = fA + xA
                Else
                    .Parameters.Add(New NpgsqlParameter("@clQtyUpdate", NpgsqlDbType.Integer)).Value = subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clTotalUpdate", NpgsqlDbType.Integer)).Value = subTotal(8) - subTotal(7)
                    .Parameters.Add(New NpgsqlParameter("@clInvoiceAmtUpdate", NpgsqlDbType.Bigint)).Value = Qty
                    .Parameters.Add(New NpgsqlParameter("@clDiscountUpdate", NpgsqlDbType.Bigint)).Value = subTotal(5)
                    .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = tD

                    .Parameters.Add(New NpgsqlParameter("@clLastModifier", NpgsqlDbType.Varchar)).Value = usr
                    .Parameters.Add(New NpgsqlParameter("@clModifierTime", NpgsqlDbType.Time)).Value = d1

                    .Parameters.Add(New NpgsqlParameter("@clActivityStatus", NpgsqlDbType.Integer)).Value = If(Qty <= 0, InvoiceIsClosed, InvoiceIsOpen)
                    .Parameters.Add(New NpgsqlParameter("@clInvoicePayOut", NpgsqlDbType.Bigint)).Value = fA + xA
                    .Parameters.Add(New NpgsqlParameter("@clInvoicePayOutUpdate", NpgsqlDbType.Bigint)).Value = fA + xA
                End If

                If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

                Dim _fsnd As Integer = .ExecuteNonQuery()
                If _fsnd > 0 Then
                    cTXNs.Close()
                Else
                    Exit Sub
                End If

            End With

            'MsgBox(Inv)
            'Exit Sub

            For Each row As DataGridViewRow In dg_TXNs.Rows
                If Not row.Cells(1).Value = "" Then
                    If Not row.Cells(7).Value = "" Then
                        If Not row.Cells(7).Value Is DBNull.Value Then
                            If Not row.Cells(7).Value = 0 Then
                                If Not row.Cells(7).Value > (row.Cells(2).Value - row.Cells(3).Value) Then

                                    Sql = ""

                                    If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

                                    Dim IsFound As String = ""
                                    Try
                                        IsFound = Qry("SELECT clItem FROM clPurchaseReturns WHERE clItemId='" & row.Cells(0).Value & "' " &
                                                                                               "AND " &
                                                                                                           "clTransferInvoiceCode='" & Inv & "'", cTXNs)
                                    Catch ex As Exception
                                        IsFound = ""
                                    End Try
                                    If IsFound = "" Then
                                        Sql = "INSERT INTO clPurchaseReturns " &
                                                                                             "(clTransferInvoiceCode," &
                                                                                                                 "clDate,clTime," &
                                                                                                                 "clItemId,clItem," &
                                                                                                                 "clPurchasedQuantity,clPurchaseDiscount,clPurchasedRate," &
                                                                                                                 "clReturnedQuantity,clReturnDiscount,clReturnedRate,clUser) " &
                                                                                   "VALUES " &
                                                                                              "(@clTransferInvoiceCode,@" &
                                                                                                                 "clDate,@clTime,@" &
                                                                                                                 "clItemId,@clItem,@" &
                                                                                                                 "clPurchasedQuantity,@clPurchaseDiscount,@clPurchasedRate,@" &
                                                                                                                 "clReturnedQuantity,@clReturnDiscount,@clReturnedRate,@clUser)"
                                    Else
                                        Sql = "UPDATE clPurchaseReturns SET clReturnedQuantity=@clReturnedQuantity," &
                                                                                               "clReturnedRate=@clReturnedRate," &
                                                                                               "clModifUser=@clModifUser " &
                                                                                               "WHERE clItemId='" & row.Cells(0).Value & "' " &
                                                                                               "AND " &
                                                                                                           "clTransferInvoiceCode='" & Inv & "'"
                                    End If

                                    'MsgBox(Sql)

                                    cm = New NpgsqlCommand(Sql,
                                                 cTXNs)
                                    With cm
                                        If IsFound = "" Then
                                            .Parameters.Add(New NpgsqlParameter("@clTransferInvoiceCode", NpgsqlDbType.Varchar)).Value = Inv
                                            .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = tD
                                            .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = d1
                                            .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = row.Cells(0).Value
                                            .Parameters.Add(New NpgsqlParameter("@clItem", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                                            .Parameters.Add(New NpgsqlParameter("@clPurchasedQuantity", NpgsqlDbType.Integer)).Value = v(row.Cells(2).Value) - v(row.Cells(3).Value)
                                            .Parameters.Add(New NpgsqlParameter("@clPurchaseDiscount", NpgsqlDbType.Bigint)).Value = v(row.Cells(5).Value)
                                            .Parameters.Add(New NpgsqlParameter("@clPurchasedRate", NpgsqlDbType.Bigint)).Value = v(row.Cells(4).Value)
                                        End If

                                        .Parameters.Add(New NpgsqlParameter("@clReturnedQuantity", NpgsqlDbType.Integer)).Value = v(row.Cells(7).Value)
                                        .Parameters.Add(New NpgsqlParameter("@clReturnDiscount", NpgsqlDbType.Bigint)).Value = v(row.Cells(5).Value)
                                        .Parameters.Add(New NpgsqlParameter("@clReturnedRate", NpgsqlDbType.Bigint)).Value = v(row.Cells(4).Value)
                                        .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr

                                        If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

                                        Dim _fsnd As Integer = .ExecuteNonQuery()
                                        If _fsnd > 0 Then
                                            cTXNs.Close()
                                        End If
                                    End With

                                End If
                            End If
                        End If
                    End If

                End If

            Next

            For Each row As DataGridViewRow In dg_TXNs.Rows
                If Not row.Cells(1).Value = "" Then
                    If Not row.Cells(7).Value = "" Then
                        If Not row.Cells(7).Value Is DBNull.Value Then
                            If Not row.Cells(7).Value = 0 Then
                                If Not row.Cells(7).Value > (row.Cells(2).Value - row.Cells(3).Value) Then

                                    ThisBillMode = CurrentlyIs.TXNs

                                    Dim pQty As Decimal = Qry("SELECT clQty FROM clItems WHERE SerialId='" &
                                                                          row.Cells(0).Value & "'",
                                                                          cItems)

                                    Dim fQty As Decimal = 0.0

                                    fQty = (CType(row.Cells(2).Value, Decimal) - CType(row.Cells(3).Value, Decimal)) - CType(row.Cells(7).Value, Decimal)

                                    Dim Fs As Decimal = 0.0

                                    Fs = pQty - fQty

                                    xQry("UPDATE clItems SET clQty='" &
                                                             Fs &
                                                             "' WHERE SerialId='" &
                                                             row.Cells(0).Value & "'",
                                                             cItems)

                                    ThisBillMode = CurrentlyIs.PurchaseReturns

                                    Dim CsA As Decimal = 0.0

                                    UpdateClosing(row.Cells(0).Value, fQty)

                                    SRC = SRC + 1

                                End If
                            End If
                        End If
                    End If
                End If

            Next

            'ThisBillMode = CurrentlyIs.TXNs

        Catch ex As Exception
            ShowMessage("Action failed at some point! " & ex.Message & "; " & ex.HResult, _Method.AsError)
            write_Error("Action failed at some point! " & ex.Message & "; " & ex.HResult)
        Finally
            'IsModif = False
            ShowMessage("Success! " & SRC & " Records Affected", _Method.AsInfo)
            clearAll(True)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSaveSession.Click
        InitiateReturn()
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        clearAll(True)
    End Sub
    Private Sub btnFindInvoice_Click(sender As Object, e As EventArgs) Handles btnFindInvoice.Click
        findInvoice()
    End Sub

End Class