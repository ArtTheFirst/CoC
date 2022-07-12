Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class TXNsOrder

    Sub LoadTime()
        With Date.Now
            TheTime.Text = String.Concat(.ToShortDateString, "; ",
                                         .ToShortTimeString)
        End With
    End Sub
    Sub GetInvType()
        l_InvoiceType.Text = String.Concat("Invoice Type: ", IIf(_This() = LoginIs.Client, "Cashier", "Admin / Manager"))
    End Sub

    Sub disposeInvoice()
        xQry("DELETE FROM clInvoiceOrders WHERE clClient IS NULL OR clClient=''", cTXNs)
        xQry("DELETE FROM clTXNsOrder WHERE clUser IS NULL OR clUser=''", cTXNs)
    End Sub

    Function rcpt() As String
        Dim r As String = ""
        Try
            Dim final As Integer = 100000 + calcVal("SerialId",
                                  "clInvoiceOrders",
                    CalcMode.GetCount,
                                     cTXNs,
                                        " WHERE clInvoiceCode ILIKE '%INV%' AND clSeries='Order'")
            r = String.Concat("INV" & final)

        Catch ex As Exception
            write_Error("Invoice Generation Error; " & ex.Message, Name)
            MsgBox("Invoice Generation Error; " & ex.Message)
            r = ""
        Finally
            rcpt = r
        End Try

    End Function

    Enum Authentication
        AsAdd
        AsReset
    End Enum
    Private onEdit As Boolean = False
    Sub loadReset(_Process As Authentication)
        onEdit = False

        If _Process = Authentication.AsAdd Then
            btnConfirm.Enabled = True

        ElseIf _Process = Authentication.AsReset Then
            Code = ""
            AddAs = DetailFrom.AbsolutelyNothing__Pity
            Inv = rcpt()
            l_InvoiceCode.Text = String.Concat("Invoice Code: ", Inv)
            dg_TXNs.Rows.Clear()
            CustId = SerialId()
            l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", CustId)
            l_ClientName.Text = ""
            l_Total.Text = l_Total.Tag
            l_SubTotal.Text = l_SubTotal.Tag
            l_TotalQty.Text = l_TotalQty.Tag

            l_SessionId.Text = l_SessionId.Tag

            btnConfirm.Enabled = False

            ThisCurrent = BillMode.IsNew

            InitiateInvoice()

        End If

        calcTotals()

        FromOut = False

    End Sub
    Private tbl As DataTable = Nothing
    Public Sub InitiateInvoice()
        Try

            If ThisCurrent = BillMode.IsNew Then
                Inv = rcpt()
                xQry("INSERT INTO clInvoiceOrders (clInvoiceCode) VALUES ('" & Inv & "')", cTXNs)
                xQry("INSERT INTO clTXNsOrder (clOrderInvoice) VALUES ('" & Inv & "')", cTXNs)
                With Date.Now
                    sessionId = String.Concat(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond)
                End With

            ElseIf ThisCurrent = BillMode.IsOld Then
                tbl = xRead("SELECT * FROM clInvoiceOrders WHERE clInvoiceCode='" & Inv & "' AND clStatus='" & InvoiceIsOpen & "'", "clInvoiceOrders", cTXNs)
                For Each row In tbl.Rows
                    AmountPaid = row("clAmountPaid")
                    l_EditMode.Text = String.Concat("Bill Edit [", CDate(row("clDate")).ToShortDateString, "]")
                    CustId = row("clCustomer").ToString
                    l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", CustId)
                    l_ClientName.Text = String.Concat("Cust. Name: ",
                                                             Qry("SELECT clName FROM clCustomers WHERE SerialId='" & CustId & "'"))
                    l_usr.Text = String.Concat("User: ", row("clUser").ToString)
                    sessionId = row("SerialId")

                Next

                tbl = xRead("SELECT clItemId,clItem,clQuantity,clPrice FROM clTXNsOrder WHERE clOrderInvoice='" & Inv & "'", "clTXNsOrder", cTXNs)
                dg_TXNs.Rows.Clear()
                For Each row In tbl.Rows
                    dg_TXNs.Rows.Add(row(0).ToString, row(1).ToString, row(2), row(3))
                Next

                loadReset(Authentication.AsAdd)

                l_InvoiceCode.Text = String.Concat("Invoice Code: ", Inv)

            End If

        Catch ex As Exception
            write_Error("Invoice Initiate Error; " & ex.Message, Name)
        Finally
            l_SessionId.Text = String.Concat(l_SessionId.Tag, sessionId)

            l_EditMode.Visible = (ThisCurrent = BillMode.IsOld)

        End Try

    End Sub

    Private Sub Cashier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            If btnConfirm.Enabled Then loadTXNs()
        ElseIf e.KeyCode = Keys.F3 Then
            If btnCustomers.Enabled Then GetCustId()
        ElseIf e.KeyCode = Keys.F4 Then
            btnReceiptModify_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            loadReset(Authentication.AsReset)
        End If

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        onEdit = False
        ThisBillMode = CurrentlyIs.TXNsOrder
        If ThisCurrent = BillMode.IsNew Then loadReset(Authentication.AsReset)
        l_usr.Text = String.Concat("session initiated by:  ", usr)
        GetInvType()
        Dim oTime As New Timer
        With oTime
            .Enabled = True
            .Interval = 1000
            .Start()
        End With
        AddHandler oTime.Tick, AddressOf LoadTime
        'l_ToPay.Text = l_ToPay.Tag
        dg_TXNs.Focus()

        'InitiateInvoice()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        If btnConfirm.Enabled = True Then
            If dg_TXNs.Rows.Count > -1 Then
                Dim MRQ As MsgBoxResult = MsgBox("Discard records?", MsgBoxStyle.OkCancel)
                If Not MRQ = MsgBoxResult.Ok Then Exit Sub
            End If
        End If
        loadReset(Authentication.AsReset)
        Inv = ""
        disposeInvoice()
        ThisCurrent = BillMode.Is_Absolutely_Nothing

    End Sub
    Sub calcTotals()

        Try

            l_recordCount.Text = String.Concat(dg_TXNs.Rows.Count - 1, " item(s)")

            l_TotalQty.Text = String.Concat("Total Qty: ", FormatNumber(subTotal(2), 0))

            TotalPrice = CInt(subTotal(4))

            _SubTotal = TotalPrice

            l_SubTotal.Text = String.Concat("Sub-Total: ",
                                                     FormatNumber(_SubTotal, 0))
            l_Total.Text = FormatNumber(TotalPrice, 0)

            'l_ToPay.Text = String.Concat("Last Paid ", FormatNumber(AmountPaid, 0))

        Catch ex As Exception
            write_Log("error while calculating TXNs order total; " & ex.Message)
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

        If dg_TXNs.CurrentCell.ColumnIndex = 0 Or dg_TXNs.CurrentCell.ColumnIndex = 2 Then
            If dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "CODE" Or
            dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "QTY" Then
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

                Dim dR As DataGridViewRow = dg_TXNs.Rows(r)
                With dR

                    If Not FromOut Then
                        .Cells(0).Value = row(0).ToString
                        .Cells(1).Value = row(1).ToString
                        If .Cells(2).Value Is DBNull.Value Or .Cells(2).Value = 0 Then
                            .Cells(2).Value = 1
                        End If

                        .Cells(3).Value = row(2)
                    Else
                        Dim SiValues As String() = New String() {row(0).ToString,
                                                                                       row(1).ToString,
                                                                                       1,
                                                                                       row(2)}
                        dg_TXNs.Rows.Add(SiValues)
                    End If

                End With

                loadReset(Authentication.AsAdd)

                onCellEdit = True

            Next

        Catch ex As Exception

            write_Error("Cannot load Item details. Please Check error code" & ex.HResult)

            'MsgBox("Cannot load Item details. Please Check error code" & ex.HResult)

        End Try

    End Sub
    Private FromOut As Boolean = False
    Function vl(value) As Integer
        Dim r = 0
        If value Is DBNull.Value Or value Is Nothing Or value = "" Then
            r = 0
        Else
            r = value
        End If
        Return r

    End Function
    Sub deleteRow()
        Try
            Dim counter As Integer = dg_TXNs.CurrentRow.Index
            dg_TXNs.Rows.RemoveAt(counter)
            If dg_TXNs.Rows.Count <= 0 Then
                loadReset(Authentication.AsReset)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellValueChanged
        calcTotals()
        dg_list_CellEnter(Me, e)
    End Sub
    Dim r As Integer = -1

    Function returns(SId, Name) As String
        Dim q As String = Nothing
        Try
            q = Qry("SELECT clBarcode FROM clItems WHERE SerialId='" & SId & "' OR clName='" & Name & "'", cItems)
        Catch ex As Exception
            q = ""
        End Try
        returns = q
    End Function
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

                Dim selling As Integer = 0
                selling = (.Cells(2).Value * (.Cells(3).Value))
                .Cells(4).Value = FormatNumber(selling, 0)

            End With

            Call calcAddVal()

            calcTotals()

        Catch ex As Exception
            If onCellEdit Then GoTo 3
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

        Exit Sub
3:      deleteRow()

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

    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_TXNs.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_TXNs.CurrentRow.Index
                dg_TXNs.Rows.RemoveAt(counter)
                If dg_TXNs.Rows.Count <= 0 Then
                    loadReset(Authentication.AsReset)
                End If
            Catch ex As Exception
            Finally
                calcTotals()
            End Try
        ElseIf e.KeyData = Keys.Enter Then
            Dim t As Integer = dg_TXNs.CurrentRow.Index
            Dim ndr As DataGridViewRow = dg_TXNs.Rows(t)
            With ndr
                If dg_TXNs.CurrentCell.ColumnIndex = 3 Then

                    Code = .Cells(0).Value

                    Dim IsWeighable As Decimal = -1
                    Dim IsWeighed As Decimal = -1
                    Try
                        IsWeighable = CDec(Qry("SELECT clWeighable FROM clItems WHERE SerialId='" & .Cells(0).Value & "'", cItems))
                        IsWeighed = CDec(Qry("SELECT clUnitPrice FROM clItemsMeasurements WHERE clItemId='" & .Cells(0).Value & "'", cItems))
                    Catch ex As Exception
                        IsWeighable = -1
                        IsWeighed = -1
                    End Try
                    If IsWeighable > -1 Then
                        If IsWeighed > -1 Then
                            Dim f As New WeightMeasurement
                            If Not f.Visible Then f.ShowDialog()
                            If WeighedQuantity > 0 Then
                                .Cells(2).Value = WeighedQuantity
                            End If
                            If WeighedPrice > 0 Then
                                .Cells(3).Value = WeighedPrice
                            End If
                        End If
                    End If

                End If
            End With

        End If

    End Sub

    Private Sub dg_TXNs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dg_TXNs.KeyPress
        If Asc(e.KeyChar) = 13 Then
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

    Sub GetCustId() Handles btnCustomers.Click
        CurrentItem = SearchIs.Create
        'Cnfg.Reload()
        'If Not Cnfg.LicenseStatus = Cnfg.LicenseActive Then complain() : Exit Sub
        Try
            ThisClient = IsA.Customer
            Dim f As New Clients
            If Not f.Visible Then f.ShowDialog()
            If Trim(CustId) = "" Then Exit Sub
            l_ClientName.Text = String.Concat("Client Name: ",
                                                 Qry("SELECT clName FROM clCustomers WHERE SerialId='" & CustId & "'"))
            l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", CustId)
        Catch ex As Exception
            write_Error(ex.Message, Name)
            CustId = SerialId()
            l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", CustId)
            l_ClientName.Text = ""
        End Try

        dg_TXNs.Focus()

    End Sub

    Dim sessionId As String
    Sub loadTXNs() Handles btnConfirm.Click

        If onEdit Then Exit Sub

        Call xCr(ThisBillMode)

        Dim Mrc As String = Trim(l_ClientName.Text.Replace("Client Name: ", ""))

        If Mrc = "" Then MsgBox("You must select a customer to continue!") : Exit Sub

        calcTotals()

        Try

            If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

            Dim Sql As String = ""
            If ThisCurrent = BillMode.IsNew Then
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
                                                                        "clStatus=@clStatus," &
                                                                        "clModifDate=@clModifDate," &
                                                                        "clModifTime=@clModifTime," &
                                                                        "clModifUser=@clModifUser" &
                                                                                 " WHERE clInvoiceCode='" & Inv & "'"

            ElseIf ThisCurrent = BillMode.IsOld Then
                Sql = "UPDATE clInvoiceOrders SET clQty=@clQty," &
                                                                "clAmountExpected=@clAmountExpected," &
                                                                "clAmountPaid=@clAmountPaid," &
                                                                "clCustomer=@clCustomer," &
                                                                "clStatus=@clStatus," &
                                                                "clModifDate=@clModifDate," &
                                                                "clModifTime=@clModifTime," &
                                                                "clModifUser=@clModifUser" &
                                                                         " WHERE clInvoiceCode='" & Inv & "'"

            End If

            Dim cmd As New NpgsqlCommand(Sql,
                                        cTXNs)
            Dim tD As Date = New Date()
            Dim d1 As New TimeSpan
            With Date.Now
                d1 = New TimeSpan(.Hour, .Minute, .Second)
                tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cmd

                If ThisCurrent = BillMode.IsNew Then
                    .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = sessionId
                    .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = tD
                    .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = "Credit"
                    .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(2)
                    .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = TotalPrice
                    .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = AmountPaid
                    .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr()
                    .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = Mrc
                    .Parameters.Add(New NpgsqlParameter("@clType", NpgsqlDbType.Varchar)).Value = "TXNs Order"
                    .Parameters.Add(New NpgsqlParameter("@clSeries", NpgsqlDbType.Varchar)).Value = "Order"
                    .Parameters.Add(New NpgsqlParameter("@clStatus", NpgsqlDbType.Integer)).Value = InvoiceIsOpen
                    .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = tD
                    .Parameters.Add(New NpgsqlParameter("@clModifTime", NpgsqlDbType.Time)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clModifUser", NpgsqlDbType.Varchar)).Value = usr

                ElseIf ThisCurrent = BillMode.IsOld Then
                    .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(2)
                    .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = TotalPrice
                    .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = AmountPaid
                    .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = Mrc
                    .Parameters.Add(New NpgsqlParameter("@clStatus", NpgsqlDbType.Integer)).Value = InvoiceIsClosed
                    .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = tD
                    .Parameters.Add(New NpgsqlParameter("@clModifTime", NpgsqlDbType.Time)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clModifUser", NpgsqlDbType.Varchar)).Value = usr

                End If

                If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

                Dim fSn As Integer = .ExecuteNonQuery()
                If fSn > 0 Then
                    If Not cTXNs.State = ConnectionState.Closed Then cTXNs.Close()
                End If
            End With

            If ThisCurrent = BillMode.IsOld Then
                Dim iCount As Integer = 0
                For Each rw As DataGridViewRow In dg_TXNs.Rows

                    Dim pQty As Integer = Qry("SELECT clQty FROM clItems WHERE SerialId='" &
                                                      rw.Cells(0).Value & "'",
                                                      cItems)

                    Dim _Pqty As Integer = Qry("SELECT clQuantity FROM clTXNsOrder WHERE clItem='" &
                                                      rw.Cells(1).Value & "' AND clOrderInvoice='" & Inv & "'",
                                                      cTXNs)

                    xQry("UPDATE clItems SET clQty='" &
                             pQty + _Pqty &
                             "' WHERE SerialId='" &
                             rw.Cells(0).Value & "'",
                             cItems)

                    iCount = iCount + 1

                Next

                xQry("DELETE FROM clTXNsOrder WHERE clOrderInvoice='" & Inv & "'", cTXNs)

            End If

            For Each row As DataGridViewRow In dg_TXNs.Rows

                If Not row.Cells(1).Value = "" Then

                    With cTXNs
                        .Open()
                    End With

                    Dim SqlString As String = Nothing

                    SqlString = "INSERT INTO clTXNsOrder (clOrderInvoice,clItemId,clDate," &
                                                                                                  "clTime,clItem,clQuantity,clCustomer," &
                                                                                                  "clPrice,clUser)" &
                                                                                                  " VALUES " &
                                                                                                  "(@clOrderInvoice,@clItemId,@clDate,@" &
                                                                                                  "clTime,@clItem,@clQuantity,@clCustomer,@" &
                                                                                                  "clPrice,@clUser)"

                    Dim cm As New NpgsqlCommand(SqlString,
                                           cTXNs)
                    With cm
                        .Parameters.Add(New NpgsqlParameter("@clOrderInvoice", NpgsqlDbType.Varchar)).Value = Inv
                        .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = row.Cells(0).Value
                        .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = tD
                        .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Varchar)).Value = tD.ToShortTimeString
                        .Parameters.Add(New NpgsqlParameter("@clItem", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                        .Parameters.Add(New NpgsqlParameter("@clQuantity", NpgsqlDbType.Integer)).Value = v(row.Cells(2).Value)
                        .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = Mrc
                        .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = v(row.Cells(3).Value)
                        .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr
                        If Not _
                            cTXNs.State = ConnectionState.Open Then _
                            cTXNs.Open()
                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then

                            LoadCrVw(ThisBillMode, row.Cells(2).Value, row.Cells(0).Value, row.Cells(1).Value, row.Cells(4).Value, 0)

                            cTXNs.Close()
                        End If

                    End With

                End If

            Next

            LoadCrVw(Mrc, tD)

        Catch ex As Exception
            MsgBox(ex.Message)
            write_Error(ex.Message)
            If cTXNs.State = ConnectionState.Open Then cTXNs.Close()
            cItems.Close()
            cTXNs.Close()
        Finally
            If ThisCurrent = BillMode.IsNew Then
                MsgBox("Save Success!")
            ElseIf ThisCurrent = BillMode.IsOld Then
                MsgBox("Update Success!!")
            End If
            btnNew.PerformClick()

        End Try

    End Sub

    Private Sub btnReceiptModify_Click(sender As Object, e As EventArgs) Handles btnReceiptModify.Click

        ThisBillMode = CurrentlyIs.TXNsOrder

        If _This() = LoginIs.Admin Then
            GoTo 7
        Else
            Mode = LoginMode.AllowAccess
            login.ShowDialog()
            If _Access = _Request.IsGranted Then
                GoTo 7
            End If
        End If

        Exit Sub
7:      Dim f As New InvoiceFinder
        If Not f.Visible Then f.ShowDialog()

        ThisCurrent = BillMode.IsOld

        InitiateInvoice()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadReset(Authentication.AsReset)
    End Sub

End Class
