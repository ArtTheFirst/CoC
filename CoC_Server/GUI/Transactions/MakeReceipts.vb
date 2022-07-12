Imports System.Data.SqlClient

Public Class MakeReceipts

    Private cSz As Integer = 60
    Private xSz As Integer = 110

    Sub loadColumns()
        lv_Invoices.Columns.Clear()

        Dim lvColumnHeader As ColumnHeader
        Dim iLength As Integer = lv_Invoices.Width / 7
        lvColumnHeader = lv_Invoices.Columns.Add("Receipt Code")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Date")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Time")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Amount Paid")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Payment Method")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Invoice Code")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Client")
        lvColumnHeader.Width = iLength
    End Sub

    Sub loadList()
        Dim Condition As String = " WHERE clDate='" & Date.Now.Date & "'"
        Try
            Dim tbl As DataTable = xRead("SELECT clSalesInvoiceCode,clDate,clTime,clAmountExpected," &
                                            "clPaymentMethod,clInvoiceCode,clClient FROM clInvoiceToPay" &
                                            Condition,
                                                "clInvoiceToPay")
            lv_Invoices.Items.Clear()
            For Each row In tbl.Rows
                Dim lI As ListViewItem = lv_Invoices.Items.Add(row(0).ToString)
                lI.SubItems.Add(row(1))
                lI.SubItems.Add(row(2))
                lI.SubItems.Add(FormatNumber(row(3), 2, TriState.True))
                lI.SubItems.Add(row(4).ToString)
                lI.SubItems.Add(row(5).ToString)
                lI.SubItems.Add(row(6).ToString)
            Next

            l_Total.Text = String.Concat(Date.Now.ToShortDateString,
                                                            "/",
                                                            lv_Invoices.Items.Count, " item(s); ",
                                         "Total ", FormatNumber(subTotal(3), 2, TriState.True))

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

    Function rcpt() As String
        Dim final As Integer = 100000 + calcVal("clStatus",
                                          "clInvoiceToPay",
                            CalcMode.GetCount,
                                            c)
        rcpt = String.Concat("R_" & final)
    End Function

    Sub cleanData() Handles btnNew.Click
        loadPaymentMeans()
        loadInvoices()
        loadList()
        c_Invoices_SelectedIndexChanged(Nothing, Nothing)
        t_Amount.Text = 0.00
        l_ReceiptCode.Text = String.Concat("Receipt Code: ", rcpt)

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadColumns()
        cleanData()
        pnl_Filter.Height = cSz

    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        OnLoad(Nothing)
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            cleanData()
        End If

    End Sub

    Sub loadPaymentMeans()
        Dim tbl As DataTable = Nothing
        Try
            tbl = xRead("SELECT clName FROM clPayMethods", "clPayMethods")
            c_PayMethod.Items.Clear()
            For Each row In tbl.Rows
                c_PayMethod.Items.Add(row(0).ToString)
            Next
        Catch ex As Exception
        End Try

    End Sub

    Sub loadInvoices()
        Dim Condition As String = " WHERE clAmountPaid<clAmountExpected"

        Try
            Dim tbl As DataTable = xRead("SELECT clInvoiceCode FROM clInvoices" &
                                                    Condition,
                                         "clInvoices")
            c_Invoices.Items.Clear()
            For Each row In tbl.Rows
                c_Invoices.Items.Add(row(0).ToString)
            Next
            l_InvTotal.Text = String.Concat(c_Invoices.Items.Count, " records found")
        Catch ex As Exception
        End Try

    End Sub
    Private Sub c_Invoices_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Invoices.SelectedIndexChanged
        Dim t As Integer = -1

        Dim p As Integer = -1
        Try
            t = calcVal("clAmountExpected",
                                          "clInvoices",
                            CalcMode.GetSum,
                                            c, " WHERE clInvoiceCode='" & c_Invoices.Text & "'")

            p = t - calcVal("clAmountPaid",
                                          "clInvoices",
                            CalcMode.GetSum,
                                            c, " WHERE clInvoiceCode='" & c_Invoices.Text & "'")

        Catch ex As Exception
            t = 0
            p = 0
        Finally
            l_InvoiceTotal.Text = String.Concat("Total TXN: ", FormatNumber(t, 2, TriState.True))

            l_InvBalance.Text = String.Concat("Balance: ", FormatNumber(p, 2, TriState.True))

        End Try

    End Sub

    Sub filterDates() Handles btnExtend.Click
        With pnl_Filter
            btnExtend.Text = IIf(.Height = xSz, "<<", ">>")
            .Height = IIf(.Height = cSz, xSz, cSz)
        End With

        dtp_Ext.MinDate = dtp_Filter.Value

        cleanData()

    End Sub

    Private Sub dtp_Filter_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Filter.ValueChanged
        cleanData()
    End Sub
    Private Sub dtp_Ext_ValueChanged(sender As Object, e As EventArgs) Handles dtp_Ext.ValueChanged
        cleanData()
    End Sub

    Private Sub t_Amount_TextChanged(sender As Object, e As EventArgs) Handles t_Amount.Leave
        Try
            t_Amount.Text = FormatNumber(t_Amount.Text, 2, TriState.True)
        Catch ex As Exception

        End Try

    End Sub

    Sub saveData()

        If CInt(t_Amount.Text) <= 0 Or
            c_Invoices.Text.Length < 1 Or
            c_PayMethod.Text.Length < 1 Then _
            GoTo 7

        If c.State = ConnectionState.Closed Then c.Open()

        Dim cmd As New SqlCommand("INSERT INTO clInvoiceToPay (clSalesInvoiceCode,clDate,clTime," &
                                  "clAmountExpected,clPaymentMethod,clInvoiceCode," &
                                  "clClient,clStatus) VALUES " &
                                                                                "(@clSalesInvoiceCode,@clDate,@clTime," &
                                                                                "@clAmountExpected,@clPaymentMethod,@clInvoiceCode," &
                                                                                "@clClient,@clStatus)",
                                        c)
        With cmd
            .Parameters.Add(New SqlParameter("@clSalesInvoiceCode", SqlDbType.VarChar)).Value = rcpt()
            .Parameters.Add(New SqlParameter("@clDate", SqlDbType.Date)).Value = Date.Now.Date
            .Parameters.Add(New SqlParameter("@clTime", SqlDbType.VarChar)).Value = Date.Now.ToShortTimeString
            .Parameters.Add(New SqlParameter("@clAmountExpected", SqlDbType.BigInt)).Value = CInt(t_Amount.Text)
            .Parameters.Add(New SqlParameter("@clPaymentMethod", SqlDbType.VarChar)).Value = c_PayMethod.Text
            .Parameters.Add(New SqlParameter("@clInvoiceCode", SqlDbType.VarChar)).Value = c_Invoices.Text
            .Parameters.Add(New SqlParameter("@clClient", SqlDbType.VarChar)).Value = usr()

            Dim InvoiceOrigin As String = Nothing
            If c_Invoices.Text.StartsWith("INV") Then
                InvoiceOrigin = "Cash Sales"
            Else
                InvoiceOrigin = "Purchases"

            End If
            .Parameters.Add(New SqlParameter("@clStatus", SqlDbType.VarChar)).Value = InvoiceOrigin

            If c.State = ConnectionState.Closed Then c.Open()
            Dim fSn As Integer = .ExecuteNonQuery()
            If fSn > 0 Then
                c.Close()
                updateInvoice()
                cleanData()
                MsgBox("Save success!")
            Else
                c.Close()
                cleanData()
                GoTo 7
            End If
        End With

        Exit Sub
7:      MsgBox("Save Action Failed Critically! Try Again", MsgBoxStyle.Critical)

    End Sub
    Sub updateInvoice()
        Dim cI As Integer = calcVal("clAmountExpected",
                             "clInvoiceToPay",
                             CalcMode.GetSum,
,
                             " WHERE clInvoiceCode='" & c_Invoices.Text & "'")

        If c.State = ConnectionState.Closed Then c.Open()

        Dim cmd As New SqlCommand("UPDATE clInvoices SET clAmountPaid=@clAmountPaid WHERE clInvoiceCode='" & c_Invoices.Text & "'",
                                        c)
        With cmd
            .Parameters.Add(New SqlParameter("@clAmountPaid", SqlDbType.BigInt)).Value = cI

            If c.State = ConnectionState.Closed Then c.Open()
            Dim fSn As Integer = .ExecuteNonQuery()
            If fSn > 0 Then
                c.Close()
            Else
                c.Close()
            End If
        End With

    End Sub

    Sub keyTrapNum(sender As Object, e As KeyPressEventArgs) Handles t_Amount.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveData()
    End Sub

End Class