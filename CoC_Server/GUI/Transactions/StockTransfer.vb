Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class StockTransfer

    Sub ClearFields()
        PrepareDGColumns()

    End Sub

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
        dg_List.Columns.Item(2).DefaultCellStyle.Format = "n2"
        dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_List.Columns.Item(2).Width = 90
        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "PRICE"
        dg_List.Columns.Add(dgCl)
        dg_List.Columns.Item(3).DefaultCellStyle.Format = "n2"
        dg_List.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_List.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_List.Columns.Item(3).ReadOnly = True
        dg_List.Columns.Item(3).Width = 180
        dgCl = New DataGridViewTextBoxColumn
        dgCl.HeaderText = "AMOUNT"
        dg_List.Columns.Add(dgCl)
        dg_List.Columns.Item(4).DefaultCellStyle.Format = "n2"
        dg_List.Columns.Item(4).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
        dg_List.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        dg_List.Columns.Item(4).Width = 240
        dg_List.Columns.Item(4).ReadOnly = True

    End Sub

    Sub calcTotal()
        l_Qty.Text = "Qty. Total: " & subTotal(2)
        l_Amt.Text = FormatNumber(subTotal(4), 2)
    End Sub

    Dim SessionId As String
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Id = ""
        TTId = ""
        TFId = ""
        l_TransferFrom.Text = l_TransferFrom.Tag
        l_TransferTo.Text = l_TransferTo.Tag
        l_Outstanding.Text = l_Outstanding.Tag
        PrepareDGColumns()
        loadTransferCriteria()
        Inv = rcpt()
        Dim tD As DateTime
        With Date.Now
            tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond, DateTimeKind.Unspecified)
            SessionId = tD.Millisecond
        End With
        l_sessionid.Text = String.Concat("session id: ", SessionId)
        calcTotal()
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnSave_Click_1(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            btnNew_Click(Nothing, Nothing)
        End If
    End Sub

    Sub loadTransferCriteria()
        Dim d As String = Nothing

        Dim td = 0

        Try
            d = SQLDate.Replace("'", "").Replace("=", "")
        Catch ex As Exception
            d = ""
        End Try
        l_InvoiceDate.Text = String.Concat("Invoice Date: ", d)

        Dim Mrct As String = Nothing

        Mrct = l_TransferFrom.Text.Replace("Transfer From: ", "")

        Try
            td = calcVal("clAmountExpected",
                                            "clInvoices",
                         CalcMode.GetSum,
                                         cTXNs,
                         " WHERE clCustomer='" & Mrct &
                         "' AND clPaymentMethod='Credit'" &
                         " AND clType='Stock Transfer'")
        Catch ex As Exception
            td = 0
        End Try
        l_Outstanding.Text = "Outstanding Balance: " &
                                           FormatNumber(td, 2)
        Id = ""
    End Sub
    Private Sub l_InvoiceDate_Click(sender As Object, e As EventArgs) Handles l_InvoiceDate.Click
        DatePanel = ShouldBe.Contracted
        Dim fDt As Form = New DateControl
        If Not fDt.Visible Then fDt.ShowDialog()
        loadTransferCriteria()
    End Sub
    Private Sub l_TransferFrom_Click(sender As Object, e As EventArgs) Handles l_TransferFrom.Click
        CurrentItem = SearchIs.Create
        Company = AddMode.IsNothing
        Dim f As New CompanyList
        If Not f.Visible Then f.ShowDialog()

        If Id = "" Then Exit Sub

        TFId = Id

        If CompanyInfo = "" Then Exit Sub

        Dim TTo As String = Nothing

        TTo = l_TransferTo.Text.Replace("Transfer To: ", "")

        If CompanyInfo = TTo Then ShowMessage("Not allowed", _Method.AsError) : Exit Sub

        l_TransferFrom.Text = String.Concat("Transfer From: ", CompanyInfo)
        loadTransferCriteria()
    End Sub
    Private CId As String
    Dim TTId As String
    Dim TFId As String
    Private Sub l_TransferTo_Click(sender As Object, e As EventArgs) Handles l_TransferTo.Click
        CurrentItem = SearchIs.Create
        Company = AddMode.IsNothing
        Dim f As New CompanyList
        If Not f.Visible Then f.ShowDialog()

        If CompanyInfo = "" Then Exit Sub

        If Id = "" Then Exit Sub

        If Id = "HQ0001" Then
            CId = "clItems"
        Else
            CId = "clItemsHistory"
        End If
        TTId = Id

        Dim TFr As String = Nothing

        TFr = l_TransferFrom.Text.Replace("Transfer From: ", "")

        If CompanyInfo = TFr Then ShowMessage("Not allowed", _Method.AsError) : Exit Sub

        l_TransferTo.Text = String.Concat("Transfer To: ", CompanyInfo)
        loadTransferCriteria()
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
    Private Sub dg_list_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_List.EditingControlShowing

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

                    If Not FromOut Then
                        .Cells(0).Value = row(0).ToString
                        .Cells(1).Value = row(1).ToString
                        If .Cells(2).Value Is DBNull.Value Or .Cells(2).Value = 0 Then
                            .Cells(2).Value = 1
                        End If

                        .Cells(3).Value = row(2)
                    ElseIf FromOut Then
                        Dim SiValues As String() = New String() {row(0).ToString,
                                                                                                row(1).ToString,
                                                                                                1,
                                                                                                row(2)}
                        dg_List.Rows.Add(SiValues)
                    End If

                End With

                'loadReset(Authentication.AsAdd)

                OnCellEdit = True

            Next

            'dg_list.AutoResizeColumns()

        Catch ex As Exception

            write_Error("Cannot load Item details. Please Check error code: " & ex.HResult)

            'MsgBox("Cannot load Item details. Please Check error code" & ex.HResult)

        End Try

    End Sub

    Sub deleteRow()
        Try
            Dim counter As Integer = dg_List.CurrentRow.Index
            dg_List.Rows.RemoveAt(counter)
            If dg_List.Rows.Count <= 0 Then
                PrepareDGColumns()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_List_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        dg_List_CellEnter(Me, e)
        Try
            Dim dR As DataGridViewRow = dg_List.Rows(e.RowIndex)
            With dR
                If OnCellEdit Then
                    If .Cells(3).Value Is DBNull.Value AndAlso
                        Trim(.Cells(3).Value) = "" AndAlso
                        .Cells(3).Value = 0 AndAlso
                        .Cells(4).Value Is DBNull.Value AndAlso
                        Trim(.Cells(4).Value) = "" AndAlso
                        .Cells(4).Value = 0 Then

                        dg_List.Rows.RemoveAt(e.RowIndex)
                        If dg_List.Rows.Count <= 0 Then
                            PrepareDGColumns()
                            GoTo 3
                        End If
                        GoTo 3
                    End If
                End If

            End With
        Catch ex As Exception
            write_Error( ex.Message,name)
        End Try

        Exit Sub
3:      deleteRow()

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
    Private Sub dg_List_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        Dim amt = 0
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

                amt = .Cells(2).Value * .Cells(3).Value

                .Cells(4).Value = FormatNumber(amt, 2)

            End With

            calcAddVal()

            calcTotal()
        Catch ex As Exception
            If OnCellEdit Then GoTo 3
            calcTotal()
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

        Exit Sub
3:      deleteRow()

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

    Dim r As Integer = -1
    Private OnCellEdit As Boolean = False

    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
                If dg_List.Rows.Count <= 0 Then
                    PrepareDGColumns()
                End If
            Catch ex As Exception
            Finally
                calcTotal()
            End Try
        End If
    End Sub
    Private Sub dg_List_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dg_List.KeyPress
        If Asc(e.KeyChar) = 13 Then
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
    Private FromOut As Boolean = False
    Function rcpt() As String
        Dim r As String = ""
        Try
            Dim final As Integer = 100000 + calcVal("SerialId",
                                  "clInvoices",
                    CalcMode.GetCount,
                                         cTXNs,
                                        " WHERE clInvoiceCode ILIKE '%INV%' AND clType='Stock Transfer'")

            r = String.Concat("INV" & final)

        Catch ex As Exception
            r = ""
            write_Error("Invoice Generation Error; " & ex.Message)
            MsgBox("Invoice Generation Error; " & ex.Message)
        Finally
            rcpt = r
        End Try

    End Function
    Sub complain()
        MsgBox("Please provide transfer user data.", MsgBoxStyle.Critical)
    End Sub
    Sub loadTransfer()

        Dim tD As Date = New Date()
        With Date.Now
            tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
        End With

        Dim MRq As MsgBoxResult = MsgBox("Proceed?", MsgBoxStyle.OkCancel)
        If Not MRq = MsgBoxResult.Ok Then Exit Sub

        'SetupBranch(CId)

        If dg_List.Rows.Count <= 0 Then Exit Sub

        MRq = MsgBox("Post as Cash?", MsgBoxStyle.YesNo)
        Dim selectedMethod As String = ""
        Select Case MRq
            Case MsgBoxResult.Yes
                selectedMethod = "Cash"
            Case MsgBoxResult.No
                selectedMethod = "Credit"
        End Select

        Dim Mrct As String = ""
        Dim Rcv As String = ""
        Mrct = l_TransferFrom.Text.Replace("Transfer From: ", "")
        Rcv = l_TransferTo.Text.Replace("Transfer To: ", "")

        If Mrct = "" Or Rcv = "" Then complain() : Exit Sub

        Try

            If cTXNs.State = ConnectionState.Closed Then cTXNs.Open()

            Dim cmd As New NpgsqlCommand("INSERT INTO clInvoices (clInvoiceCode," &
                                                                                                    "clDate,clTime," &
                                                                                                    "clPaymentMethod,clAmountExpected,clAmountPaid," &
                                                                                                    "clClient," &
                                                                                                    "clType,clCustomer,clSeries,clActivityStatus) " &
                                                             "VALUES (" &
                                                                                                 "@clInvoiceCode," &
                                                                                                 "@clDate,@clTime," &
                                                                                                 "@clPaymentMethod,@clAmountExpected,@clAmountPaid," &
                                                                                                 "@clClient," &
                                                                                                 "@clType,@clCustomer,@clSeries,@clActivityStatus)",
                                         cTXNs)
            Dim d1 As DateTime
            With Date.Now
                d1 = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cmd
                .Parameters.Add(New NpgsqlParameter("@clInvoiceCode", NpgsqlDbType.Varchar)).Value = Inv
                .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = tD
                .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = d1
                .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = selectedMethod
                .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = CType(subTotal(4), Decimal)
                .Parameters.Add(New NpgsqlParameter("@clAmountPaid", NpgsqlDbType.Bigint)).Value = IIf(selectedMethod = "Credit", 0, subTotal(4))
                .Parameters.Add(New NpgsqlParameter("@clClient", NpgsqlDbType.Varchar)).Value = usr()
                .Parameters.Add(New NpgsqlParameter("@clType", NpgsqlDbType.Varchar)).Value = "Stock Transfer"
                .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = Mrct
                .Parameters.Add(New NpgsqlParameter("@clSeries", NpgsqlDbType.Varchar)).Value = "Transfer TXNs Entry"
                .Parameters.Add(New NpgsqlParameter("@clActivityStatus", NpgsqlDbType.Integer)).Value = If(subTotal(2) <= 0, _Status.isInActive, _Status.IsActive)

                If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
                Dim fSn As Integer = .ExecuteNonQuery()
                If fSn > 0 Then
                    cTXNs.Close()
                    GoTo 2
                End If
            End With

            Exit Sub

2:          For Each row As DataGridViewRow In dg_List.Rows
                If Not Trim(row.Cells(1).Value) = "" Then
                    If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()

                    Dim Sql As String = Nothing

                    Sql = "INSERT INTO clStockTransfer (clItemId,clTransferInvoiceCode," &
                                                                                                             "clDate,clTime," &
                                                                                                             "clItem,clQuantity," &
                                                                                                              "clCustomer," &
                                                                                                              "clPrice," &
                                                                                                              "clUser) " &
                                                                                                              "VALUES (@clItemId,@clTransferInvoiceCode," &
                                                                                                             "@clDate,@clTime," &
                                                                                                             "@clItem,@clQuantity," &
                                                                                                              "@clCustomer," &
                                                                                                              "@clPrice," &
                                                                                                              "@clUser)"
                    Dim cmd_ As New NpgsqlCommand(Sql,
                                           cTXNs)
                    With cmd_

                        'ShowMessage(row.Cells(1).Value & vbNewLine & row.Cells(2).Value & vbNewLine & row.Cells(3).Value & vbNewLine, _Method.AsInfo)

                        .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = row.Cells(0).Value
                        .Parameters.Add(New NpgsqlParameter("@clTransferInvoiceCode", NpgsqlDbType.Varchar)).Value = Inv
                        .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = tD
                        .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = d1
                        .Parameters.Add(New NpgsqlParameter("@clItem", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                        .Parameters.Add(New NpgsqlParameter("@clQuantity", NpgsqlDbType.Integer)).Value = row.Cells(2).Value
                        .Parameters.Add(New NpgsqlParameter("@clCustomer", NpgsqlDbType.Varchar)).Value = Mrct
                        .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = row.Cells(3).Value
                        .Parameters.Add(New NpgsqlParameter("@clUser", NpgsqlDbType.Varchar)).Value = usr
                        If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
                        Dim fSnd As Integer = .ExecuteNonQuery
                        If fSnd > 0 Then
                            cTXNs.Close()
                            UpdateClosing(row.Cells(0).Value, row.Cells(2).Value)
                        End If
                    End With
                End If
            Next

            'ShowMessage("Upload alternating...", _Method.AsInfo) : GoTo 7 : Exit Sub

            For Each row As DataGridViewRow In dg_List.Rows
                If Not row.Cells(1).Value = "" Then
                    Dim Qty As Decimal = 0
                    Dim IsExistent As Boolean = False
                    If Not cItems.State = ConnectionState.Open Then cItems.Open()
                    Dim Sql As String = Nothing

                    Dim IsAdmin As Boolean = If(TTId = "HQ0001", True, False)

                    Dim condition As String = IIf(IsAdmin, "", " AND clCId='" & TTId & "'")

                    Try
                        IsExistent = If(Qry("SELECT clName FROM " & CId & " WHERE SerialId='" &
                                                  row.Cells(0).Value & "'" & condition,
                                                  cItems) = "",
                                                  False,
                                                  True)
                    Catch ex As Exception
                        IsExistent = False
                    End Try

                    Dim SUParams As String = ""

                    If IsExistent Then

                        SUParams = IIf(IsAdmin, "", ",clCId=@clCId," &
                                                                    "clDate=@clDate," &
                                                                    "clTime=@clTime") &
                                                                             Space(1)

                        Sql = "UPDATE " & CId & " SET clName=@clName," &
                                                                        "clPrice=@clPrice," &
                                                                        "clQty=@clQty " &
                                                                        SUParams &
                                                                                        "WHERE SerialId='" & row.Cells(0).Value & "'" &
                                                                                        condition
                    Else

                        Dim SU As String = IIf(IsAdmin, "", ",clCId," &
                                                                                 "clDate," &
                                                                                 "clTime") & ")"

                        SUParams = IIf(IsAdmin, "", ",@clCId," &
                                                                    "@clDate," &
                                                                    "@clTime") & ")"

                        Sql = "INSERT INTO " & CId & " (SerialId,clName," &
                                                                           "clQty,clPrice" & SU &
                                                                           " VALUES " &
                                                                           "(@SerialId,@clName," &
                                                                           "@clQty,@clPrice" & SUParams

                        Qty = CType(row.Cells(2).Value, Decimal)

                    End If
                    Dim cm As New NpgsqlCommand(Sql, cItems)
                    With cm
                        If Not IsExistent Then _
                        .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = row.Cells(0).Value
                        .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = row.Cells(1).Value
                        .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = Qty
                        .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = row.Cells(3).Value
                        If Not IsAdmin Then
                            If Not IsExistent Then _
                            .Parameters.Add(New NpgsqlParameter("@clCId", NpgsqlDbType.Varchar)).Value = TTId
                            .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Date)).Value = tD
                            .Parameters.Add(New NpgsqlParameter("@clTime", NpgsqlDbType.Time)).Value = d1
                        End If

                        If Not cItems.State = ConnectionState.Open Then cItems.Open()
                        Dim fSnd As Integer = .ExecuteNonQuery
                        If fSnd > 0 Then
                            cItems.Close()
                        End If
                    End With
                End If

            Next

            Try
                For Each row As DataGridViewRow In dg_List.Rows
                    If Not row.Cells(1).Value = "" Then
                        Dim tfCnd As String = ""
                        Dim tfCnd_ As String = ""
                        If TFId = "HQ0001" Then
                            tfCnd = "clItems"
                            tfCnd_ = ""
                        Else
                            tfCnd = "clItemsHistory"
                            tfCnd_ = " AND clCId='" & TFId & "'"
                        End If
                        Dim pQty As Decimal = Qry("SELECT clQty FROM " & tfCnd &
                                                                  " WHERE SerialId='" &
                                                                                row.Cells(0).Value & "'" & tfCnd_,
                                                                    cItems)
                        Dim Qty As Decimal = pQty - CType(row.Cells(2).Value, Decimal)
                        xQry("UPDATE " & tfCnd & " SET clQty='" & Qty &
                                   "' WHERE SerialId='" &
                                                    row.Cells(0).Value & "'" &
                                    tfCnd_,
                             cItems)

                    End If
                Next
            Catch ex As Exception
                write_Error("Qty update error", Name)
            End Try

            'Exit Sub
7:          ShowMessage("Stock Transfer successful!", _Method.AsInfo)

            btnNew_Click(Nothing, Nothing)

        Catch ex As Exception
            write_Error(ex.Message, Name)
            cTXNs.Close()
            cItems.Close()
            cTXNs.Close()
            'btnReset_Click(Nothing, Nothing)
        End Try

    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        loadTransfer()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        OnLoad(Nothing)
    End Sub

End Class