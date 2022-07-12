Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class Cashier

    Private tbl As DataTable = Nothing
    Private Const cSz As Integer = 60
    Private Const xSz As Integer = 120
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

    Private Function InitiatePay() As String
        l_Change.Visible = True
        Select Case PayMode
            Case _Is.Cash
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
            Case _Is.CashPOS
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
            Case _Is.CashPOSBank
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
            Case _Is.CashBank
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
            Case _Is.CashRRN
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
            Case _Is.CashPOSRRN
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
            Case _Is.CashPOSBankRRN
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
            Case _Is.CashBankRRN
                l_Change.Text = String.Concat("Change: ", FormatNumber(ChangeAmount, 0))
        End Select

        Return 0

    End Function

    Sub LoadTime()
        With Date.Now
            TheTime.Text = String.Concat(.ToShortDateString, "; ",
                                         .ToShortTimeString)
        End With
    End Sub
    Sub GetInvType()
        l_InvoiceType.Text = String.Concat("Invoice Type: ", IIf(_This() = LoginIs.Client, "Cashier", "Admin / Manager"))
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        disposeInvoice()

        If ThisCurrent = BillMode.IsNew Then btnNew_Click(Nothing, Nothing)

        GetInvType()
        Dim oTime As New Timer
        With oTime
            .Enabled = True
            .Interval = 1000
            .Start()
        End With
        AddHandler oTime.Tick, AddressOf LoadTime
        dg_TXNs.Focus()

    End Sub

    Private Sub Cashier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            If btnSave.Enabled Then loadTXNs()
        ElseIf e.KeyCode = Keys.F9 Then
            btnNew_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            If btnCustomers.Enabled Then btnCustomers.PerformClick()
        ElseIf e.KeyCode = Keys.F6 Then
            If btnDiscounts.Enabled Then btnDiscounts_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            btnReceiptModify_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Enter Then
            Exit Sub
        End If

    End Sub

    Private Sub Cashier_Ctrl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If btnSave.Enabled = True Then
            If dg_TXNs.Rows.Count > -1 Then
                Dim MRQ As MsgBoxResult = MsgBox("Close current session?", MsgBoxStyle.OkCancel)
                If Not MRQ = MsgBoxResult.Ok Then Exit Sub
            End If
        End If
        disposeInvoice()
        loadReset(Authentication.AsReset)
        ThisCurrent = BillMode.Is_Absolutely_Nothing

    End Sub
    Sub disposeInvoice()
        xQry("DELETE FROM clInvoices WHERE clClient IS NULL OR clClient=''", cTXNs)
        xQry("DELETE FROM clTXNs WHERE clUser IS NULL OR clUser=''", cTXNs)
    End Sub

    Function rcpt() As String
        Try
            Dim final As Decimal = 100000 + calcVal("SerialId",
                                  "clInvoices",
                    CalcMode.GetCount,
                                     cTXNs,
                                        " WHERE clInvoiceCode ILIKE '%INV%'")

            rcpt = String.Concat("INV" & final)

        Catch ex As Exception
            write_Error("Invoice Generation Error; " & ex.Message, Name)
            MsgBox("Invoice Generation Error; " & ex.Message)
        End Try

        Return 0

    End Function

    Enum Authentication
        AsAdd
        AsReset
    End Enum
    Sub loadReset(_Process As Authentication)

        PayMode = _Is.__SadlyNothing___Pity

        Dsc = 0

        Dsct = 0

        Discounts = 0

        DiscountString = ""

        TotalPrice = 0

        FindSubTotal = 0

        _SubTotal = 0

        'JournalDate = Nothing

        'AmountPaid = 0

        'ChangeAmount = 0

        If _Process = Authentication.AsAdd Then
            btnSave.Enabled = True
            btnDiscounts.Enabled = True

        ElseIf _Process = Authentication.AsReset Then
            'disBandTbl()
            'PrepareDGColumns()
            l_ClientName.Text = ""
            l_Total.Text = l_Total.Tag
            l_DiscountTotal.Text = l_DiscountTotal.Tag
            l_SubTotal.Text = l_SubTotal.Tag
            l_TotalQty.Text = l_TotalQty.Tag
            l_VAT.Text = l_VAT.Tag
            btnSave.Enabled = False
            btnDiscounts.Enabled = False

            AddAs = DetailFrom.AbsolutelyNothing__Pity

            With bottompnl
                .Height = cSz
            End With

            If ThisCurrent = BillMode.IsOld Then
                GoTo 7
            ElseIf ThisCurrent = BillMode.IsNew Then
                InitiateInvoice()
                GoTo 7
            End If

        End If

        Exit Sub
7:      calcTotals()

        FromOut = False

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ThisCurrent = BillMode.IsNew
        loadReset(Authentication.AsReset)
    End Sub

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
        dg_TXNs.Columns.Item(0).Width = 100
        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "ITEM NAME"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dg_TXNs.Columns.Item(1).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "QTY"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(2).DefaultCellStyle.Format = "n0"
        dg_TXNs.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(2).Width = 80
        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "PRICE"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(3).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(3).ReadOnly = True
        dg_TXNs.Columns.Item(3).Width = 150
        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "DISCOUNT"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(4).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(4).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(4).Width = 100
        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "TOTAL"
        dg_TXNs.Columns.Add(dgCl)
        dg_TXNs.Columns.Item(5).DefaultCellStyle.Format = "n2"
        dg_TXNs.Columns.Item(5).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_TXNs.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_TXNs.Columns.Item(5).ReadOnly = True
        dg_TXNs.Columns.Item(5).Width = 150

    End Sub

    Public Shared sessionId As String
    Public Sub InitiateInvoice()

        disBandTbl()

        PrepareDGColumns()

        Try

            If ThisCurrent = BillMode.IsNew Then
                l_acct.Text = String.Concat("Account: ", usr)
                Inv = rcpt()
                xQry("INSERT INTO clInvoices (clInvoiceCode) VALUES ('" & Inv & "')", cTXNs)
                xQry("INSERT INTO clTXNs (clTXNsInvoice) VALUES ('" & Inv & "')", cTXNs)
                With Date.Now
                    sessionId = String.Concat(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond)
                End With
                CustId = SerialId()

            ElseIf ThisCurrent = BillMode.IsOld Then
                Dim InvTyp As String = IIf(ThisBillMode = CurrentlyIs.TXNs, "clInvoices", "clInvoiceOrders")
                Dim UTyp As String = IIf(ThisBillMode = CurrentlyIs.TXNs, "clClient", "clUser")
                tbl = xRead("SELECT SerialId,clAmountPaid,clAmountExpected,clCustomer,clDate," & UTyp & " FROM " & InvTyp & " " &
                            "WHERE clInvoiceCode='" & Inv & "'",
                            InvTyp, cTXNs)
                For Each row As DataRow In tbl.Rows

                    AmountPaid = row(1)

                    ChangeAmount = row(1) - row(2)

                    l_EditMode.Text = "Bill Edit [" & CDate(row(4)).ToShortDateString & "]"
                    CustId = row(3).ToString
                    l_acct.Text = String.Concat("Account: ", row(5).ToString)
                    sessionId = row(0).ToString

                Next

                Dim pId As String = ""
                Dim dbName As String = ""
                Dim allowDsc As String = ""
                Dim ref As String = ""
                If ThisBillMode = CurrentlyIs.TXNs Then
                    pId = "clItemId"
                    dbName = "clTXNs"
                    allowDsc = ",clDiscount"
                    ref = "clTXNsInvoice"
                ElseIf ThisBillMode = CurrentlyIs.TXNsOrder Then
                    pId = "clItemId"
                    dbName = "clTXNsOrder"
                    ref = "clOrderInvoice"
                End If

                Dim Sql As String = String.Concat("SELECT ", pId, ",clItem,clQuantity,clPrice", allowDsc, " FROM ", dbName, " WHERE ", ref, "='", Inv, "'")

                calcTotals()

                'disBandTbl()

                tbl = xRead(Sql, dbName, cTXNs)

                For Each row In tbl.Rows
                    If ThisBillMode = CurrentlyIs.TXNs Then
                        dg_TXNs.Rows.Add(row(0).ToString, row(1).ToString, row(2), row(3), row(4))
                    ElseIf ThisBillMode = CurrentlyIs.TXNsOrder Then
                        dg_TXNs.Rows.Add(row(0).ToString, row(1).ToString, row(2), row(3))
                    End If
                Next
                loadReset(Authentication.AsAdd)

                Try
                    For i = 0 To dg_TXNs.Rows.Count
                        Dim dR As DataGridViewRow = dg_TXNs.Rows(i)
                        With dR
                            Dim tCalc = 0
                            If ThisBillMode = CurrentlyIs.TXNs Then
                                tCalc = (.Cells(2).Value * .Cells(3).Value) - .Cells(4).Value
                            ElseIf ThisBillMode = CurrentlyIs.TXNsOrder Then
                                tCalc = .Cells(2).Value * .Cells(3).Value
                            End If
                            .Cells(5).Value = FormatNumber(tCalc, 0)
                        End With

                    Next

                Catch ex As Exception
                End Try

            End If

            l_InvoiceCode.Text = String.Concat("Invoice Code: ", Inv)

            l_SessionId.Text = String.Concat(l_SessionId.Tag, sessionId)

            l_EditMode.Visible = (ThisCurrent = BillMode.IsOld)

            l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", CustId)
            Try
                l_ClientName.Text = String.Concat("Cust. Name: ", Qry("SELECT clName FROM clCustomers WHERE SerialId='" & CustId & "'"))
            Catch ex As Exception
            End Try

        Catch ex As Exception
            MsgBox(ex.Message & "_InvoiceInitiate_Error", MsgBoxStyle.Critical, "CyPOS")
            write_Error("Invoice Initiate Error; " & ex.Message, Name)
            'loadReset(Authentication.AsReset)
        End Try

    End Sub
    Private Sub btnReceiptModify_Click(sender As Object, e As EventArgs) Handles btnReceiptModify.Click
        'Exit Sub
        ThisBillMode = CurrentlyIs.TXNs

        If _This() = LoginIs.Admin Then
            GoTo 7
        Else
            complain()
            Mode = LoginMode.AllowAccess
            Dim f As New login
            If Not f.Visible Then f.ShowDialog()
            If _Access = _Request.IsGranted And CurrentRequested = UserLogin.IsAdmin Then
                GoTo 7
            Else
                ShowMessage("Permission revoked!", _Method.AsError)
            End If
        End If

        Exit Sub
7:      InvoiceFinder.ShowDialog()

        If Inv = "" Then Exit Sub

        InitiateInvoice()

    End Sub
    Private Dsc As Decimal = 0
    Private Dsct As Decimal = 0
    Private Sub btnDiscounts_Click(sender As Object, e As EventArgs) Handles btnDiscounts.Click
        Dim f As New LoadDiscount
        If Not f.Visible Then f.ShowDialog()
        LoadDiscount.ShowDialog()
        If Discounts <= 0 Then Exit Sub
        For Each rw As DataGridViewRow In dg_TXNs.Rows
            With rw
                .Cells(4).Value = (.Cells(5).Value) * (Discounts / 100)
            End With
        Next

    End Sub

    Sub calcTotals()

        Try

            l_recordCount.Text = dg_TXNs.Rows.Count - 1 & " item(s)"

            l_TotalQty.Text = "Total Qty: " & FormatNumber(subTotal(2), 2)

            TotalPrice = subTotal(5)

            Dsc = TotalPrice * (Discounts / 100)

            _SubTotal = (TotalPrice - Dsc)

            If ThisCurrent = BillMode.IsNew Then
                FindSubTotal = TotalPrice

            ElseIf ThisCurrent = BillMode.IsOld Then
                FindSubTotal = (TotalPrice + subTotal(4))

            End If

            l_SubTotal.Text = "Sub-Total: " & FormatNumber(FindSubTotal, 2)

            l_Total.Text = FormatNumber(_SubTotal, 2)

            Dsct = Math.Round((subTotal(4) * 100) / FindSubTotal, 0)

            l_DiscountTotal.Text = "Dsc: " &
                                                    FormatNumber(subTotal(4), 2) &
                                                 " [" &
                                                 Dsct &
                                                 "%]"

            l_ToPay.Text = "Last Paid " & FormatNumber(AmountPaid, 2)

            Call InitiatePay()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub
    Function subTotal(col As Integer) As Decimal
        Dim TotalValue As Decimal
        Dim tmp As Decimal
        For n = 0 To dg_TXNs.Rows.Count - 1
            Dim nDR As DataGridViewRow = dg_TXNs.Rows(n)
            With nDR
                If Decimal.TryParse(.Cells(col).Value, tmp) Then
                    TotalValue += tmp
                End If
            End With
        Next

        Return TotalValue

    End Function
    Dim _row, _col As Decimal
    Private onCellEdit As Boolean = False
    Private Sub dg_TXNs_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_TXNs.EditingControlShowing

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

        If dg_TXNs.CurrentCell.ColumnIndex = 0 Or dg_TXNs.CurrentCell.ColumnIndex = 2 Or dg_TXNs.CurrentCell.ColumnIndex = 4 Then
            If dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "CODE" Or
            dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "QTY" _
            Or dg_TXNs.Columns(dg_TXNs.CurrentCell.ColumnIndex).HeaderText = "DISCOUNT" Then
                InitiateHandler = True
                AddHandler e.Control.KeyPress, AddressOf IntKeyTrap
            Else
                InitiateHandler = False
            End If
        Else
            InitiateHandler = False
        End If

        'dg_TXNs_CellLeave(Nothing, Nothing)

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
            write_Error(ex.Message, Name)
            deleteRow()
        End Try

        Try

            tbl = xRead(" SELECT SerialId,clName,clPrice,clDiscount,clItemExpiry " &
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
                        If v(.Cells(2).Value) = 0 Then
                            .Cells(2).Value = 1
                        End If

                        .Cells(3).Value = row(2)

                        If v(.Cells(4).Value) = 0 Then
                            .Cells(4).Value = row(3)
                        End If
                    ElseIf FromOut Then
                        Dim SiValues As String() = New String() {row(0).ToString,
                                                                                            row(1).ToString,
                                                                                            1,
                                                                                            row(2),
                                                                                            row(3)}
                        dg_TXNs.Rows.Add(SiValues)
                    End If

                End With

                loadReset(Authentication.AsAdd)

                onCellEdit = True

            Next

            'dg_TXNs.AutoResizeColumns()

        Catch ex As Exception

            write_Error("Cannot load Item details. Please Check error code: " & ex.HResult & vbNewLine & "; Error: " & ex.Message, Name)

            'MsgBox("Cannot load Item details. Please Check error code" & ex.HResult)

        End Try

    End Sub

    Sub deleteRow()
        Try
            Dim counter As Decimal = dg_TXNs.CurrentRow.Index
            dg_TXNs.Rows.RemoveAt(counter)
            If dg_TXNs.Rows.Count <= 0 Then
                loadReset(Authentication.AsReset)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_TXNs_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellLeave
        dg_TXNs_CellEnter(Me, e)
    End Sub
    Private Sub dg_TXNs_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellValueChanged
        'calcTotals()
        dg_TXNs_CellEnter(Me, e)

        Exit Sub

    End Sub
    Dim r As Integer = -1
    Private VAT_ As Decimal = 0
    Function returns(SId, Name) As String
        Dim q As String = Nothing
        Try
            q = Qry("SELECT clBarcode FROM clItems WHERE SerialId='" & SId & "' AND clName='" & Name & "'", cItems)
        Catch ex As Exception
            q = ""
        End Try
        returns = q
    End Function
    Private Sub dg_TXNs_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_TXNs.CellEnter

        Try

            r = dg_TXNs.CurrentRow.Index

            Dim dR As DataGridViewRow = dg_TXNs.Rows(r)

            With dR
                If dg_TXNs.CurrentCell.ColumnIndex = 1 Then
                    AddAs = DetailFrom.ItemName
                    loadDetails(.Cells(1).Value)
                ElseIf dg_TXNs.CurrentCell.ColumnIndex = 0 Then
                    AddAs = DetailFrom.ItemCode
                    loadDetails(.Cells(0).Value)
                End If

                '//To calculate discount per time periods

                Dim TotalVAT As Decimal = 0.0
                Dim selling As Decimal = 0.0
                Dim IsVATInclusive As Decimal = -1

                Try
                    tbl = xRead("SELECT clStartDate,clEndDate,clQty,clAmount FROM clDiscountables WHERE SerialId='" & .Cells(0).Value & "'", "clDiscountables")
                    For Each row In tbl.Rows
                        Dim todaysDate As Date = Date.Now

                        Dim d1, d2 As Date
                        With CType(row(0), Date)
                            d1 = New Date(.Year, .Month, .Day, 0, 0, 0)
                        End With
                        With CType(row(1), Date)
                            d2 = New Date(.Year, .Month, .Day, 23, 59, 59)
                        End With

                        If todaysDate >= d1 And todaysDate <= d2 Then
                            Dim dbQty As Decimal = row(2)
                            Dim realQty As Decimal = CDec(.Cells(2).Value)
                            If realQty >= dbQty Then
                                Dim c_ As String = CStr(realQty / dbQty)
                                If c_.Contains(".") Then
                                    c_ = c_.Substring(0, c_.IndexOf("."))
                                End If
                                .Cells(4).Value = row(3) * (Val(c_))
                            ElseIf realQty < dbQty Then
                                .Cells(4).Value = 0
                            End If
                        End If

                    Next

                Catch ex As Exception
                    write_Error(ex.Message, Name)
                End Try

                Try
                    IsVATInclusive = CInt(Qry("SELECT clVATInclusive FROM clItems WHERE SerialId='" & .Cells(0).Value & "'", cItems))
                Catch ex As Exception
                    IsVATInclusive = -1
                End Try

                If IsVATInclusive = 1 Then
                    TotalVAT = CDec(.Cells(3).Value) * 0.05
                    VAT_ = calcVal("clVAT", "clItems",
                                                                         CalcMode.GetSum,
                                                                         cItems,
                                                                         " WHERE SerialId='" &
                                                                         .Cells(0).Value &
                                                                         "' AND clVATInclusive=1")
                Else
                    TotalVAT = 0
                End If

                l_VAT.Text = String.Concat("VAT: ", FormatNumber(VAT_,
                                                                 0))

                selling = (.Cells(2).Value * (.Cells(3).Value + TotalVAT)) - .Cells(4).Value
                .Cells(5).Value = selling

            End With

            '//To add qty to cell above current empty cell

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

    Private Sub dg_TXNs_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_TXNs.KeyDown
        If e.KeyData = Keys.Delete Then
            If ThisCurrent = BillMode.IsOld Then Exit Sub 
            Try
                Dim counter As Decimal = dg_TXNs.CurrentRow.Index
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

                    Dim q As String
                    Try
                        q = Qry("SELECT clName " &
                                    "FROM clItemsMeasurements " &
                                    "WHERE clItemId='" & Code & "'",
                    cItems)
                    Catch ex As Exception
                        q = ""
                    End Try
                    If q = "" Then MsgBox("No unit measurement was defined for this item.", MsgBoxStyle.Critical) : Exit Sub

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

                    If returns(.Cells(0).Value, .Cells(1).Value) = "" Then deleteRow()

                    FromOut = False

                End If
            End With
        End If
    End Sub
    Private FromOut As Boolean = False
    '
    Sub GetCustId() Handles btnCustomers.Click

        'If Not ThisCurrent = BillMode.IsNew Then Exit Sub

        CurrentItem = SearchIs.Create

        Try
            ThisClient = IsA.Customer
            Clients.ShowDialog()
            If Trim(CustId) = "" Then Exit Sub
            l_ClientName.Text = String.Concat("Client Name: ",
                                                 Qry("SELECT clName FROM clClients WHERE SerialId='" & CustId & "'"))
            l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", CustId)
        Catch ex As Exception
            CustId = SerialId()
            l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", CustId)
            l_ClientName.Text = ""
        End Try

        dg_TXNs.Focus()

    End Sub
    Protected Mrc As String
    Protected d1 As Date
    Sub loadTXNs() Handles btnSave.Click

        If Trim(CustId) = "" Then CustId = SerialId()

        Mrc = CustId

        l_CustomerId.Text = String.Concat(l_CustomerId.Tag, ": ", Mrc)

        Dim PRq As MsgBoxResult = -1
        If ThisCurrent = BillMode.IsOld Then PRq = MsgBox("This action cannot be reversed! Proceed, or Cancel and use sales return instead?", MsgBoxStyle.OkCancel, "Cy POS")
        If ThisCurrent = BillMode.IsOld Then If Not PRq = MsgBoxResult.Ok Then Exit Sub

        calcTotals()

        Payments.ShowDialog(Me)

        If PayMode = _Is.__SadlyNothing___Pity Then MsgBox("Cannot proceed!", MsgBoxStyle.Information) : Exit Sub

        calcTotals()

        Dim Sql As String = ""

        Try

            If cTXNs.State = ConnectionState.Closed Then cTXNs.Open()

            If ThisCurrent = BillMode.IsNew Then
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

            ElseIf ThisCurrent = BillMode.IsOld Then
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

            With Date.Now
                d1 = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With

            Dim cmd As New NpgsqlCommand(Sql,
                                        cTXNs)

            With cmd

                If ThisCurrent = BillMode.IsNew Then
                    .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = sessionId
                    .Parameters.Add(New NpgsqlParameter("@clCreationDate", NpgsqlDbType.Timestamp)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = payMeans()
                    .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(2)
                    .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = _SubTotal
                    .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = AmountPaid
                    .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = v(Discounts)
                    .Parameters.Add(New NpgsqlParameter("@clClient", NpgsqlDbType.Varchar)).Value = Mrc
                    .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr
                    .Parameters.Add(New NpgsqlParameter("@clType", NpgsqlDbType.Varchar)).Value = "TXNs"
                    .Parameters.Add(New NpgsqlParameter("@clSeries", NpgsqlDbType.Varchar)).Value = "Inbound TXNs Entry"
                    .Parameters.Add(New NpgsqlParameter("@clBillDate", NpgsqlDbType.Date)).Value = d1.Date

                ElseIf ThisCurrent = BillMode.IsOld Then
                    .Parameters.Add(New NpgsqlParameter("@clPaymentMethodUpdate", NpgsqlDbType.Varchar)).Value = payMeans()
                    .Parameters.Add(New NpgsqlParameter("@clQtyUpdate", NpgsqlDbType.Integer)).Value = subTotal(2)
                    .Parameters.Add(New NpgsqlParameter("@clAmountExpectedUpdate", NpgsqlDbType.Bigint)).Value = _SubTotal
                    .Parameters.Add(New NpgsqlParameter("@clAmountPaidUpdate", NpgsqlDbType.Bigint)).Value = AmountPaid
                    .Parameters.Add(New NpgsqlParameter("@clDiscountUpdate", NpgsqlDbType.Bigint)).Value = v(Discounts)
                    .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Timestamp)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clModifUser", NpgsqlDbType.Varchar)).Value = usr
                    .Parameters.Add(New NpgsqlParameter("@clModifClient", NpgsqlDbType.Varchar)).Value = Mrc
                    .Parameters.Add(New NpgsqlParameter("@clActivityStatus", NpgsqlDbType.Integer)).Value = If(subTotal(2) <= 0, InvoiceIsOpen, InvoiceIsClosed)

                End If

                If cTXNs.State = ConnectionState.Closed Then cTXNs.Open()

                Dim fsn As Integer = .ExecuteNonQuery()
                If fsn > 0 Then
                    GoTo 1
                End If
            End With

            Exit Sub

1:          DiscountString = l_DiscountTotal.Text.Replace("Dsc: ", "")

            'Call ThrowInQtyReduce()

            ThrowInOrderInv()

            For Each row As DataGridViewRow In dg_TXNs.Rows
                If Not row.Cells(1).Value = "" Then

                    With cTXNs
                        If Not .State = ConnectionState.Open Then .Open()
                    End With

                    Dim SqlString As String = Nothing

                    If ThisCurrent = BillMode.IsNew Then
                        SqlString = "INSERT INTO clTXNs (clItemId,clTXNsInvoice,clSeries,clCreation," &
                                                                                  "clItem,clQuantity,clClient," &
                                                                                  "clPrice,clDiscount,clPayMeans,clUser)" &
                                                                                  " VALUES " &
                                                                                  "(@clItemId,@clTXNsInvoice,@clSeries,@clCreation," &
                                                                                  "@clItem,@clQuantity,@clClient,@" &
                                                                                  "clPrice,@clDiscount,@clPayMeans,@clUser)"

                    ElseIf ThisCurrent = BillMode.IsOld Then
                        SqlString = "UPDATE clTXNs SET clCreationModif," &
                                                                        "clQuantityModif," &
                                                                        "clClientModif," &
                                                                        "clPriceModif," &
                                                                        "clDiscountModif," &
                                                                        "clPayMeansModif," &
                                                                        "clUserModif " &
                                                                        "WHERE clItemId='" & row.Cells(0).Value & "' AND clTXNsInvoice='" & Inv & "'"

                    End If

                    Dim cm As New NpgsqlCommand(SqlString,
                                           cTXNs)
                    With cm

                        Dim oClause As String = IIf(ThisCurrent = BillMode.IsNew, "", "Modif")

                        If ThisCurrent = BillMode.IsNew Then .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = row.Cells(0).Value
                        If ThisCurrent = BillMode.IsNew Then .Parameters.Add(New NpgsqlParameter("@clTXNsInvoice", NpgsqlDbType.Varchar)).Value = Inv
                        If ThisCurrent = BillMode.IsNew Then .Parameters.Add(New NpgsqlParameter("@clSeries", NpgsqlDbType.Varchar)).Value = "Inbound TXNs"
                        .Parameters.Add(New NpgsqlParameter("@clCreation" & oClause, NpgsqlDbType.Date)).Value = d1.Date
                        If ThisCurrent = BillMode.IsNew Then .Parameters.Add(New NpgsqlParameter("@clItem", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                        .Parameters.Add(New NpgsqlParameter("@clQuantity" & oClause, NpgsqlDbType.Integer)).Value = CDec(row.Cells(2).Value)
                        .Parameters.Add(New NpgsqlParameter("@clClient" & oClause, NpgsqlDbType.Varchar)).Value = Mrc
                        .Parameters.Add(New NpgsqlParameter("@clPrice" & oClause, NpgsqlDbType.Bigint)).Value = CDec(row.Cells(3).Value)
                        .Parameters.Add(New NpgsqlParameter("@clDiscount" & oClause, NpgsqlDbType.Bigint)).Value = CDec(row.Cells(4).Value)
                        .Parameters.Add(New NpgsqlParameter("@clPayMeans" & oClause, NpgsqlDbType.Varchar)).Value = payMeans()
                        .Parameters.Add(New NpgsqlParameter("@clUser" & oClause, NpgsqlDbType.Varchar)).Value = usr

                        If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
                        Dim fsnd As Integer = .ExecuteNonQuery()
                        If fsnd > 0 Then
                            cTXNs.Close()
                        End If

                    End With

                End If

            Next

            InitiatePrint(dg_TXNs)

            If Current = PrintAction.IsInPhase Or Current = PrintAction.Succeeded Then
                write_Log("Printing began")
            Else
                write_Error("Printing failed", Name)
            End If

            For Each rw As DataGridViewRow In dg_TXNs.Rows
                If Not rw.Cells(1).Value = "" Then

                    If Not cItems.State = ConnectionState.Open Then cItems.Open()
                    Dim cm As New NpgsqlCommand("UPDATE clItems SET clQty=@clQty," &
                                                                                                        "LastTXNTXNs=@LastTXNTXNs " &
                                                                                                               "WHERE SerialId='" & rw.Cells(0).Value & "'",
                                             cItems)
                    With cm
                        Dim Qty As Decimal = 0.0
                        Dim pQty = 0
                        Try
                            pQty = Qry("SELECT clQty FROM clItems WHERE SerialId='" &
                                                  rw.Cells(0).Value & "'",
                                                  cItems)
                        Catch ex As Exception
                            pQty = 0
                        End Try

                        If pQty > 0 Then

                            Dim newVal As Decimal = 0.0
                            If ThisCurrent = BillMode.IsOld Then
                                Dim oldVal As Decimal = 0.0
                                Dim lstVal As Decimal = 0.0
                                Dim condition As String = " WHERE clItemId='" & rw.Cells(0).Value &
                                                                     "' AND clTXNsInvoice='" & Inv & "'"
                                Try
                                    oldVal = Qry("SELECT clQuantity FROM clTXNs" & condition, cTXNs)
                                Catch ex As Exception
                                    oldVal = 0.0
                                End Try
                                If Not oldVal = 0.0 Then
                                    lstVal = CDec(rw.Cells(2).Value)
                                    If Not lstVal = oldVal Then
                                        newVal = lstVal - oldVal
                                    Else
                                        newVal = oldVal
                                    End If
                                End If
                            ElseIf ThisCurrent = BillMode.IsNew Then
                                newVal = CType(rw.Cells(2).Value, Decimal)
                            End If

                            Qty = CDec(pQty) - newVal

                            .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = Qty
                            .Parameters.Add(New NpgsqlParameter("@LastTXNTXNs", NpgsqlDbType.Timestamp)).Value = d1
                            If Not cItems.State = ConnectionState.Open Then cItems.Open()
                            Dim _fsnd As Integer = .ExecuteNonQuery()
                            If _fsnd > 0 Then
                                cItems.Close()
                                Dim TXNs As Decimal = rw.Cells(2).Value
                                UpdateClosing(rw.Cells(0).Value, TXNs)
                            End If
                        End If

                    End With

                End If

            Next

        Catch ex As SqlException
            write_Error(ex.Message, Name)
            If cItems.State = ConnectionState.Open Then cItems.Close()
            If cTXNs.State = ConnectionState.Open Then cTXNs.Close()
        Finally

            btnNew.PerformClick()

            If ThisCurrent = BillMode.IsNew Then
                MsgBox("Save Success!")
            ElseIf ThisCurrent = BillMode.IsOld Then
                MsgBox("Update Success!!")
            End If

        End Try

    End Sub
    Function ThrowInQtyReduce()
        If ThisCurrent = BillMode.IsOld Then
            Dim iCount As Decimal = 0
            For Each rw As DataGridViewRow In dg_TXNs.Rows

                Dim pQty As Decimal = 0
                Try
                    pQty = Qry("SELECT clQty FROM clItems WHERE SerialId='" &
                                          rw.Cells(0).Value & "'",
                                          cItems)
                Catch ex As Exception
                    pQty = 0.0
                End Try

                Dim _Pqty As Decimal = 0.0
                Try
                    _Pqty = Qry("SELECT clQuantity FROM clTXNs WHERE clItem='" &
                                                 rw.Cells(1).Value & "' AND clTXNsInvoice='" & Inv & "'",
                                                 cTXNs)
                Catch ex As Exception
                    _Pqty = 0.0
                End Try

                xQry("UPDATE clItems SET clQty='" &
                         pQty + _Pqty &
                         "' WHERE SerialId='" &
                         rw.Cells(0).Value & "'",
                         cItems)

                iCount = iCount + 1

            Next

            'Call ThrowInModify()

            'xQry("DELETE FROM clTXNs WHERE clTXNsInvoice='" & Inv & "'", cTXNs)

            'Call ThrowInOrderInv()

        End If
        Return 0
    End Function
    Function ThrowInOrderInv()
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
                                                            "clClient=@clClient," &
                                                            "clStatus=@clStatus," &
                                                            "clModifDate=@clModifDate," &
                                                            "clModifTime=@clModifTime," &
                                                            "clModifUser=@clModifUser" &
                                                                     " WHERE clInvoiceCode='" & Inv & "'"
                Dim uCmd As New NpgsqlCommand(uSql, c)
                With uCmd
                    .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = payMeans()
                    .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = subTotal(2)
                    .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = _SubTotal
                    .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = AmountPaid
                    .Parameters.Add(New NpgsqlParameter("@clClient", NpgsqlDbType.Varchar)).Value = Mrc
                    .Parameters.Add(New NpgsqlParameter("@clStatus", NpgsqlDbType.Integer)).Value = InvoiceIsClosed
                    .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = d1.Date
                    .Parameters.Add(New NpgsqlParameter("@clModifTime", NpgsqlDbType.Time)).Value = d1
                    .Parameters.Add(New NpgsqlParameter("@clModifUser", NpgsqlDbType.Varchar)).Value = usr

                    If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

                    Dim fSn As Integer = .ExecuteNonQuery()
                    If fSn > 0 Then
                        If Not cTXNs.State = ConnectionState.Closed Then cTXNs.Close()
                    End If
                End With

            End If
        End If
        Return 0
    End Function
    Sub ThrowInModify()
        xQry("DELETE FROM clTXNsModified WHERE clTXNsInvoice='" & Inv & "'", cTXNs)

        Dim tMdf As DataTable = xRead("SELECT clItemId,clTXNsInvoice,clTXNsClient,clCreation," &
                                                                                      "clItem,clQuantity,clClient," &
                                                                                      "clPrice,clDiscount,clPayMeans,clUser " &
                                                        "FROM clTXNs " &
                                                        "WHERE clTXNsInvoice='" & Inv & "'",
                                  "clTXNs",
                                  cTXNs)
        For Each rw As DataRow In tMdf.Rows
            If Not rw(5).ToString = "" Then
                With cTXNs
                    If Not .State = ConnectionState.Open Then .Open()
                End With

                Dim SqlString As String = Nothing

                SqlString = "INSERT INTO clTXNsModified (clItemId,clTXNsInvoice,clTXNsClient,clCreation," &
                                                                                          "clItem,clQuantity,clClient," &
                                                                                          "clPrice,clDiscount,clPayMeans,clUser)" &
                                                                                          " VALUES " &
                                                                                          "(@clItemId,@clTXNsInvoice,@clTXNsClient,@clCreation," &
                                                                                          "@clItem,@clQuantity,@clClient,@" &
                                                                                          "clPrice,@clDiscount,@clPayMeans,@clUser)"

                Dim cm As New NpgsqlCommand(SqlString,
                                   cTXNs)
                With cm
                    .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = rw(0).ToString
                    .Parameters.Add(New NpgsqlParameter("@clTXNsInvoice", NpgsqlDbType.Varchar)).Value = rw(1).ToString
                    .Parameters.Add(New NpgsqlParameter("@clTXNsClient", NpgsqlDbType.Varchar)).Value = rw(2).ToString
                    .Parameters.Add(New NpgsqlParameter("@clCreation", NpgsqlDbType.Date)).Value = rw(3)
                    .Parameters.Add(New NpgsqlParameter("@clItem", NpgsqlDbType.Varchar)).Value = rw(4).ToString
                    .Parameters.Add(New NpgsqlParameter("@clQuantity", NpgsqlDbType.Integer)).Value = rw(5)
                    .Parameters.Add(New NpgsqlParameter("@clClient", NpgsqlDbType.Varchar)).Value = rw(6).ToString
                    .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = rw(7)
                    .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = rw(8)
                    .Parameters.Add(New NpgsqlParameter("@clPayMeans", NpgsqlDbType.Varchar)).Value = rw(9).ToString
                    .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = rw(10).ToString

                    If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
                    Dim xsnd As Integer = .ExecuteNonQuery()
                    If xsnd > 0 Then
                        cTXNs.Close()
                    End If

                End With

            End If

        Next
    End Sub

End Class