Imports System.ComponentModel

Public Class InvoiceReceipts

    Private Const cSz As Integer = 0
    Private Const xSz As Integer = 120

    Dim tbl As DataTable = Nothing

    Sub loadColumns()
        lv_Invoices.Columns.Clear()

        Dim lvColumnHeader As ColumnHeader
        Dim iLength As Integer = lv_Invoices.Width / 12
        lvColumnHeader = lv_Invoices.Columns.Add("Invoice Date")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Invoice Receipt Code")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Time Created")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Invoice Code")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Invoice Type")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Amount Due")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Amount Paid")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Total Discount Applied")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Payment Method")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Client")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Invoice Outstandings")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Created By")
        lvColumnHeader.Width = iLength

    End Sub

    Sub alignFigures()
        Dim pAD As Integer = lv_Invoices.Items.Item("Amount Due").Position.X
        l_AmtDue.Location = New Point(pAD, l_AmtDue.Location.Y)
        Dim pAp As Integer = lv_Invoices.Items.Item("Amount Paid").Position.X
        l_AmtPaid.Location = New Point(pAp, l_AmtPaid.Location.Y)
        Dim pTD As Integer = lv_Invoices.Items.Item("Total Discount Applied").Position.X
        l_TotalDiscount.Location = New Point(pTD, l_TotalDiscount.Location.Y)

    End Sub

    Function rcpt() As Integer
        Dim final As Integer = 999999 + Date.Now.Minute + Date.Now.Second + calcVal("clOrigin",
                                          "clInvoiceToPay",
                            CalcMode.GetCount,
                                            c)
        rcpt = final
    End Function
    Sub clearAll() Handles btnNew.Click
        lv_Invoices.Items.Clear()
        pnl_Filter.Height = cSz
        l_SessionId.Text = l_SessionId.Tag & rcpt()
        chkMerchants.Checked = False
        chkPurchases.Checked = False
        l_RecordCount.Text = l_RecordCount.Tag
        l_AmtDue.Text = l_AmtDue.Tag
        l_AmtPaid.Text = l_AmtPaid.Tag
        l_TotalDiscount.Text = l_TotalDiscount.Tag
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        l_User.Text = String.Concat("logged in as ", usr)
        clearAll()

    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        loadColumns()
        alignFigures()
        loadData()
    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        clearAll()
    End Sub

    Function getDate() As String
        Dim r As String = Nothing
        Select Case pnl_Filter.Height
            Case = cSz
                r = "='" & dtp_Filter.Value.Date & "'"
            Case = xSz
                r = " BETWEEN '" & dtp_Filter.Value.Date & "' AND '" & dtp_Ext.Value.Date & "'"
        End Select
        getDate = r
    End Function

    Sub loadData() Handles chkMerchants.CheckedChanged, chkPurchases.CheckedChanged

        Dim IncludeMerchants As String = IIf(chkMerchants.Checked,
                                             " AND clOrigin='Merchant Sales'",
                                             "")

        Dim IncludePurchases As String = IIf(chkPurchases.Checked,
                                             " AND clOrigin='Purchases'",
                                             "")

        Dim condition As String = " WHERE clDate" & getDate()
        Try
            tbl = xRead("SELECT *" &
                                 " FROM clInvoiceToPay" &
                                 String.Concat(condition,
                                               IncludeMerchants,
                                               IncludePurchases),
             "clInvoices")
            For Each row In tbl.Rows
                Dim lItem As ListViewItem = lv_Invoices.Items.Add(row("clDate"))
                lItem.SubItems.Add(row("clSalesInvoiceCode").ToString)
                lItem.SubItems.Add(row("clTime").ToString)
                lItem.SubItems.Add(row("clInvoiceCode").ToString)
                Dim invTyp As String = Qry("SELECT clType FROM clSales WHERE clSalesInvoice='" &
                                           row("clInvoiceCode").ToString & "'",
                                           c_Sales)
                lItem.SubItems.Add(invTyp) '//Invoice Type

                lItem.SubItems.Add(FormatNumber(row("clAmountExpected"), 2, TriState.True))
                Dim TAP As Integer = calcVal("clAmountPaid",
                                             "clInvoices",
                                             CalcMode.GetSum,
,
                                             " WHERE clInvoiceCode='" &
                                           row("clInvoiceCode").ToString & "'")
                lItem.SubItems.Add(FormatNumber(TAP, 2, TriState.True)) '//Amount Paid

                Dim TD As Integer = calcVal("clDiscount",
                                            "clSales",
                                            CalcMode.GetSum,
                                            c_Sales,
                                            " WHERE clSalesInvoice='" &
                                           row("clInvoiceCode").ToString & "'")
                lItem.SubItems.Add(FormatNumber(TD, 2, TriState.True)) '//Total Discount

                lItem.SubItems.Add(row("clPaymentMethod").ToString)

                Dim SM As String = Qry("SELECT clSalesMerchant FROM clSales WHERE clSalesInvoice='" &
                                           row("clInvoiceCode").ToString & "'",
                                           c_Sales)
                lItem.SubItems.Add(SM) '//Get Merchant/Client

                Dim TAE As Integer = calcVal("clAmountExpected",
                                             "clInvoices",
                                             CalcMode.GetSum,
,
                                             " WHERE clInvoiceCode='" &
                                           row("clInvoiceCode").ToString & "'")
                lItem.SubItems.Add(FormatNumber(TAE - TAP, 2, TriState.True)) '//Invoice Outstanding

                lItem.SubItems.Add(row("clClient").ToString)

            Next

            l_AmtDue.Text = FormatNumber(subTotal(5), 2, TriState.True)

            l_AmtPaid.Text = FormatNumber(subTotal(6), 2, TriState.True)

            l_TotalDiscount.Text = FormatNumber(subTotal(7), 2, TriState.True)

        Catch ex As Exception

        End Try

    End Sub
    Function subTotal(xpCol As Integer) As Decimal
        Dim TotalValue, tmp As Decimal
        For n As Integer = 0 To lv_Invoices.Items.Count - 1
            If Decimal.TryParse(lv_Invoices.Items(n).SubItems(xpCol).Text, tmp) Then
                TotalValue += tmp
            End If
        Next
        Return TotalValue
    End Function

    Sub extendSize() Handles btnExtend.Click
        Dim DefHgt As Integer = IIf(pnl_Filter.Height = cSz, xSz, cSz)
        Dim DefTxt As String = IIf(pnl_Filter.Height = cSz, ">>", "<<")
        pnl_Filter.Height = DefHgt
        btnExtend.Text = String.Concat("extend filter", DefTxt)
    End Sub
    Private Sub pnl_Filter_SizeChanged(sender As Object, e As EventArgs) Handles pnl_Filter.SizeChanged
        dtp_Ext.MinDate = dtp_Filter.Value.Date
    End Sub

End Class