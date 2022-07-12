Imports System.ComponentModel

Public Class InvoiceFinder

    Private GoOn As Boolean = False
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        t_InvCode.Clear()
        Inv = ""
        GoOn = False
        loadList(True)
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)

        If Not GoOn Then Exit Sub

        If Inv = NullVal Or
                            Inv = Nothing Or
                            Inv Is DBNull.Value Or
                            Inv = "" Then MsgBox("You did not select any invoice.",
                                                    MsgBoxStyle.Information,
                                                       "CyPOS") : Inv = ""

        If Not ThisBillMode = CurrentlyIs.TXNs Then Exit Sub

        If Not Cashier.Visible Then Exit Sub

        ThisCurrent = BillMode.IsOld

        Cashier.InitiateInvoice()

    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            GoOn = False
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            btnProceed_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            btnSelectDate_Click(Nothing, Nothing)
        End If

    End Sub

    Sub loadList(Optional ByVal isAll As Boolean = False)
        Dim dateFilter As String = IIf(SQLDate = "", "", " clDate" & SQLDate & " AND ")
        Dim TXNType As String = ""
        Dim TXNSeries As String = ""
        Dim condition As String = ""
        Dim Sql As String = ""
        Dim InvTbl As String = ""
        Dim HeaderTxt As String = ""

        Select Case ThisBillMode
            Case CurrentlyIs.TXNs
                TXNSeries = "'Inbound TXNs Entry'"
                TXNType = "'TXNs'"
                GoTo 5
            Case CurrentlyIs.Purchase
                TXNSeries = "'Inbound Purchase'"
                TXNType = "'Purchase'"
                GoTo 5
            Case CurrentlyIs.TXNsOrder
                TXNType = "'TXNs Order'"
                GoTo 1
            Case CurrentlyIs.PurchaseOrder
                TXNType = "'Purchase Order'"
                GoTo 1
            Case CurrentlyIs.TXNsReturns
                TXNSeries = "'TXNs'"
                GoTo 3
            Case CurrentlyIs.PurchaseReturns
                TXNSeries = "'Purchases'"
                GoTo 3
            Case CurrentlyIs.StockTransfer
                TXNSeries = "'Transfer TXNs Entry'"
                TXNType = "'Stock Transfer'"
                GoTo 5
        End Select

        Exit Sub
1:      InvTbl = "clInvoiceOrders"

        condition = " WHERE" & dateFilter &
                " clType=" & TXNType
        Sql = "SELECT clInvoiceCode,clDate,clTime,clAmountExpected,clUser FROM " & InvTbl & condition
        HeaderTxt = TXNType.Replace("'", "").Replace("TXN", "Sale")
        'MsgBox(Sql)
        GoTo 7

        Exit Sub
3:      InvTbl = "clInvoiceReturned"
        Dim IntS As Integer = InvoiceIsOpen
        Dim cActivity As String = " AND clActivityStatus='" & IntS & "'"
        'cActivity = ""
        condition = " WHERE" & dateFilter &
                " clSeries=" &
                TXNSeries &
                cActivity
        Sql = "SELECT clInvoiceCode,clDate,clTime,clInvoiceAmtUpdate,clUser FROM " & InvTbl & condition
        HeaderTxt = TXNSeries.Replace("'", "")
        GoTo 7

        Exit Sub
5:      InvTbl = "clInvoices"

        condition = " WHERE" & dateFilter &
                " clType=" & TXNType &
                " AND clSeries=" &
                TXNSeries
        Sql = "SELECT clInvoiceCode,clDate,clTime,clAmountExpectedUpdate,clClient FROM " & InvTbl & condition
        HeaderTxt = TXNType.Replace("'", "")
        'MsgBox(Sql)
        GoTo 7

        Exit Sub
7:      Dim nCldInvTxt As String = IIf(isAll, "", " AND clinv ILIKE '%" & t_InvCode.Text & "%'")
        'MsgBox(Sql)
        Try
            Dim tbl As DataTable = xRead(Sql &
                                                             nCldInvTxt,
                                         InvTbl, cTXNs)
            dg_List.DataSource = tbl

            dg_List.ReadOnly = True

            dg_List.Columns.Item(0).HeaderText = "INVOICE CODE"
            dg_List.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg_List.Columns.Item(1).HeaderText = "INVOICE DATE"
            dg_List.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg_List.Columns.Item(2).HeaderText = "INVOICE TIME"
            dg_List.Columns.Item(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg_List.Columns.Item(3).HeaderText = "INVOICE AMOUNT"
            dg_List.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(3).DefaultCellStyle.Format = "N2"
            dg_List.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg_List.Columns.Item(4).HeaderText = "INITIATED BY"
            dg_List.Columns.Item(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            InvoiceList = dg_List.Rows.Count

        Catch ex As Exception
            write_Error(ex.Message, Name)
        End Try

    End Sub
    Public InvoiceAmount As Decimal = 0.0
    Public InvoiceList As Integer = -1
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        GoOn = True
        Try
            Inv = dg_List.Rows(dg_List.CurrentRow.Index).Cells(0).Value
            Close()
        Catch ex As Exception
            Inv = ""
        End Try

    End Sub

    Private Sub btnSelectDate_Click(sender As Object, e As EventArgs) Handles btnSelectDate.Click
        Dim fDt As Form = New DateControl
        If Not fDt.Visible Then fDt.ShowDialog()
        loadList()
    End Sub

    Private Sub t_InvCode_TextChanged(sender As Object, e As EventArgs) Handles t_InvCode.TextChanged
        loadList()
    End Sub

    Private Sub dg_List_DoubleClick(sender As Object, e As EventArgs) Handles dg_List.DoubleClick
        btnProceed_Click(Nothing, Nothing)
    End Sub

End Class