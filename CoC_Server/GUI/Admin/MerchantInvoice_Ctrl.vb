Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class MerchantInvoice_Ctrl
    Private tbl As DataTable = Nothing

    Sub fillListView()
        lv_Invoices.Columns.Clear()

        Dim lvColumnHeader As ColumnHeader
        Dim iLength As Integer = lv_Invoices.Width / 10
        lvColumnHeader = lv_Invoices.Columns.Add("Merchant")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Goods Purchased")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Quantity")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Discount Applied")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Total")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Payment Method")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Time Stamp")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Purchasing Power")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Outstanding Balance")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Invoices.Columns.Add("Initiated By")
        lvColumnHeader.Width = iLength

    End Sub
    Sub loadListView() Handles btnLoadInvoices.Click
        Dim tbl As DataTable = xRead("SELECT * FROM clSales", "clSales", c_Sales)
        If tbl Is Nothing AndAlso tbl.Rows.Count < 1 Then Exit Sub
        For Each row In tbl.Rows
            Dim lst As ListViewItem
            lst = lv_Invoices.Items.Add(row(1).ToString)
            For i As Integer = 2 To tbl.Columns.Count - 1
                If i = 2 Or i = 3 Or i = 4 Or i = 7 Or i = 8 Then lst.SubItems.Add(FormatNumber(row(i).ToString, 2)) Else lst.SubItems.Add(row(i).ToString)
            Next
        Next

    End Sub

    Sub clearFields() Handles btnNew.Click
        dId = String.Concat("INV", Date.Now.Year, HexLongSerialId)
        l_InvoiceCode.Text = String.Concat("invoice code ", dId)
        t_ProductQty.Clear()
        t_Paid.Clear()
        t_Discount.Clear()
        l_outstanding.Text = "Outstanding Balance"
        l_PurchasingPower.Text = "Purchasing Power"
        loadData()

    End Sub

    Dim dId As String = Nothing
    Sub loadData()
        tbl = xRead("SELECT clName FROM clMerchants", "clMerchants")
        c_Merchants.Items.Clear()
        For Each row In tbl.Rows
            c_Merchants.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clProducts", "clProducts", c_Products)
        c_Product.Items.Clear()
        For Each row In tbl.Rows
            c_Product.Items.Add(row(0).ToString)
        Next

        c_PayMethod.Items.Clear()
        c_PayMethod.Items.Add("Cash")
        c_PayMethod.Items.Add("Credit")

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        clearFields()

    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        fillListView()
        loadListView()

    End Sub
    Protected merchantPurchase, outstandingBalance
    Private Sub c_Merchants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Merchants.SelectedIndexChanged
        tbl = xRead("SELECT clPurchasePower,clOutstanding FROM clMerchants WHERE clName='" & c_Merchants.Text & "'", "clMerchants")
        For Each row In tbl.Rows
            merchantPurchase = row(0).ToString
            l_PurchasingPower.Text = String.Concat("Purchasing Power; ", FormatNumber(merchantPurchase, 0))
            outstandingBalance = row(1).ToString
            l_outstanding.Text = String.Concat("Outstanding Balance; ", outstandingBalance)
        Next

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If c_Product.Text = NullVal Then MsgBox("You have not provided needed data!", MsgBoxStyle.Information) : Exit Sub
        Try
            With c_Sales
                .Open()
            End With
            Dim cm As New SqlCommand("INSERT INTO clSales (clSalesInvoice,clSalesMerchant,clDate,clTime,clProduct,clQuantity," &
                                     "clMerchant,clPrice,clDiscount,clAmountPaid,clPayMeans,clUser,clCategory)" &
                                                                 " VALUES " &
                                                                                        "(@clSalesInvoice,@clSalesMerchant,@clDate,@clTime,@clProduct,@clQuantity," &
                                  "@clMerchant,@clPrice,@clDiscount,@clAmountPaid,@clPayMeans,@clUser,@clCategory)",
                                       c_Sales)
            With cm
                .Parameters.Add(New SqlParameter("@clSalesInvoice", SqlDbType.VarChar)).Value = String.Concat("MCHNT", HexLongSerialId, Date.Now.ToShortDateString.Replace("/", ""))
                .Parameters.Add(New SqlParameter("@clSalesMerchant", SqlDbType.VarChar)).Value = c_Merchants.Text
                .Parameters.Add(New SqlParameter("@clDate", SqlDbType.Date)).Value = Date.Now.ToShortDateString
                .Parameters.Add(New SqlParameter("@clTime", SqlDbType.Time)).Value = Date.Now.ToShortTimeString
                .Parameters.Add(New SqlParameter("@clProduct", SqlDbType.VarChar)).Value = c_Product.Text
                .Parameters.Add(New SqlParameter("@clQuantity", SqlDbType.Int)).Value = t_ProductQty.Text
                .Parameters.Add(New SqlParameter("@clMerchant", SqlDbType.VarChar)).Value = c_Merchants.Text
                .Parameters.Add(New SqlParameter("@clPrice", SqlDbType.BigInt)).Value = l_Price.Text
                .Parameters.Add(New SqlParameter("@clDiscount", SqlDbType.BigInt)).Value = t_Discount.Text
                .Parameters.Add(New SqlParameter("@clAmountPaid", SqlDbType.BigInt)).Value = t_Paid.Text
                .Parameters.Add(New SqlParameter("@clPayMeans", SqlDbType.VarChar)).Value = c_PayMethod.Text
                .Parameters.Add(New SqlParameter("@clUser", SqlDbType.VarChar)).Value = usr
                .Parameters.Add(New SqlParameter("@clCategory", SqlDbType.VarChar)).Value = Qry("SELECT clCategoryId FROM clProducts WHERE clName='" & c_Product.Text & "'", c_Products)
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c_Sales.Close()
                    clearFields()
                    GoTo 3
                End If
            End With

3:          With c
                .Open()
            End With
            cm = New SqlCommand("UPDATE clMerchants SET clPurchasePower=@clPurchasePower," &
                                                                                           "clOutstanding=@clOutstanding WHERE clName='" & c_Merchants.Text & "'")
            With cm
                .Parameters.Add(New SqlParameter("@clPurchasePower", SqlDbType.BigInt)).Value = CInt(merchantPurchase)
                .Parameters.Add(New SqlParameter("@clOutstanding", SqlDbType.BigInt)).Value = CInt(outstandingBalance)
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    loadData()
                End If
            End With

        Catch ex As Exception
            c_Sales.Close()
            c.Close()
        End Try

    End Sub

    Function productPrice(p)
        Dim prc = -1
        Dim tbl As DataTable = xRead("SELECT clPrice,clDiscount FROM clProducts WHERE clName='" & p & "'", "clProducts", c_Products)
        If tbl Is Nothing AndAlso tbl.Rows.Count < 1 Then
            prc = 0
        Else
            For Each row In tbl.Rows
                l_Price.Text = (row(0) * t_ProductQty.Text) - CInt(row(1))
                t_Discount.Text = row(1)
            Next
        End If
        productPrice = prc
    End Function

    Private Sub Payment(sender As Object, e As EventArgs) Handles t_Paid.TextChanged
        zeroBox(sender)
        Try
            l_PurchasingPower.Text = String.Concat("Purchasing Power; ", FormatNumber(CInt(merchantPurchase) - CInt(t_Paid.Text), 0))

            If outstandingBalance = 0 Or outstandingBalance = NullVal Then
                outstandingBalance = 0
            Else
                outstandingBalance = outstandingBalance + getOutstanding()
            End If

            l_outstanding.Text = String.Concat("Outstanding Balance; ", FormatNumber(outstandingBalance, 0))

        Catch ex As Exception
            l_PurchasingPower.Text = String.Concat("Purchasing Power; ", FormatNumber(merchantPurchase, 0))
            l_outstanding.Text = String.Concat("Outstanding Balance; ", FormatNumber(outstandingBalance, 0))
        End Try

    End Sub

    Private Sub c_Product_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Product.SelectedIndexChanged
        productPrice(c_Product.Text)
    End Sub
    Private Sub t_Discount_TextChanged(sender As Object, e As EventArgs) Handles t_Discount.TextChanged
        zeroBox(sender)
        Dim d = 0
        Try
            c_Product_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
        End Try
    End Sub

    Function getOutstanding()
        getOutstanding = CInt(productPrice(c_Product.Text)) - CInt(t_Paid.Text)
    End Function

    Sub zeroBox(sender)
        If sender.Text = NullVal Then sender.Text = 0
    End Sub
    Private Sub t_ProductQty_TextChanged(sender As Object, e As EventArgs) Handles t_ProductQty.TextChanged
        zeroBox(sender)
    End Sub

    Sub trapTextBox(sender As Object, e As KeyPressEventArgs) Handles t_Discount.KeyPress, t_Paid.KeyPress, t_ProductQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub t_ProductQty_LostFocus(sender As Object, e As EventArgs) Handles t_ProductQty.LostFocus, t_Paid.LostFocus, t_Discount.LostFocus
        zeroBox(sender)
    End Sub

End Class