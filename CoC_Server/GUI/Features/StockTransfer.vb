Imports System.Data.SqlClient

Public Class StockTransfer

    Sub loadCombos()
        c_TransferTo.Items.Clear()
        Dim tbl As DataTable = xRead("SELECT cmpName FROM companyData", "companyData")
        c_TransferFrom.Items.Clear()
        For Each row In tbl.Rows
            c_TransferFrom.Items.Add(row(0).ToString)
        Next

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        btnReset_Click(Nothing, Nothing)
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F2 Then
            btnOk_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            btnReset_Click(Nothing, Nothing)
        End If

    End Sub

    Sub calcValues()
        l_Amt.Text = FormatNumber(subTotal(5), 2, TriState.True)
        l_Qty.Text = FormatNumber(subTotal(3), 1)
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

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Not c_TransferFrom.Text = "" AndAlso Not c_TransferTo.Text = "" Then
            btnOk.Enabled = False
            c_TransferFrom.Enabled = False
            c_TransferTo.Enabled = False
            dg_List.AllowUserToAddRows = True
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        c_TransferFrom.Items.Clear()
        c_TransferTo.Items.Clear()
        dg_List.Rows.Clear()
        calcValues()
        btnOk.Enabled = True
        c_TransferFrom.Enabled = True
        c_TransferTo.Enabled = True
        dg_List.AllowUserToAddRows = False
        calcValues()
        loadCombos()

    End Sub

    Private Sub dg_List_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_List.EditingControlShowing
        Dim col As String = dg_List.Columns(1).HeaderText
        If Not col = "PRODUCT NAME" Then Exit Sub
        Dim autoBox As TextBox = Nothing
        autoBox = TryCast(e.Control, TextBox)
        If autoBox Is Nothing Then Exit Sub
        autosText(autoBox, "clName", "clProducts", c_Products)

    End Sub
    Sub loadDetails(productName As String)
        If productName.Length < 1 Then Exit Sub
        Dim tbl As DataTable = xRead("SELECT clCategoryId,clPrice " &
                                     "FROM " &
                                     "clProducts WHERE clName='" & productName & "'", "clProducts",
                                     c_Products)
        If productName = "" Or productName Is DBNull.Value Then Exit Sub
        For Each row In tbl.Rows

            Dim newDataRow As DataGridViewRow = dg_List.Rows(r)
            With newDataRow
                .Cells(1).Value = productName
                .Cells(2).Value = row(0).ToString
                .Cells(3).Value = 1
                .Cells(4).Value = FormatNumber(row(1), 2, TriState.True)

            End With
            btnSave.Enabled = True
            calcValues()

        Next

    End Sub
    Function vl(value) As Integer
        Dim r = 0
        If value Is DBNull.Value Or value Is Nothing Or value = "" Then
            r = 0
        Else
            r = value
        End If
        Return r
    End Function
    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        dg_list_CellEnter(Me, e)
    End Sub
    Dim r As Integer = -1
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        Try
            r = e.RowIndex
            Dim newDataRow As DataGridViewRow = dg_List.Rows(r)
            With newDataRow
                If dg_List.CurrentCell.ColumnIndex = 1 Then loadDetails(.Cells(1).Value)
                Dim costTotal As Integer = CInt(.Cells(3).Value) * CInt(.Cells(4).Value)
                .Cells(5).Value = FormatNumber(costTotal, 2, TriState.True)
                .Cells(0).Value = e.RowIndex + 1
            End With
            calcValues()
        Catch ex As Exception
        End Try

    End Sub
    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
            Catch ex As Exception
            Finally
                calcValues()
            End Try
        End If
    End Sub

    Function rcpt() As String
        Dim final As Integer = 100000 + calcVal("SerialId",
                                          "clInvoices",
                            CalcMode.GetCount,
                                             c,
                                                " WHERE clInvoiceCode LIKE '%BST%'")
        rcpt = String.Concat("BST" & final)
    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If c.State = ConnectionState.Closed Then c.Open()

            Dim cmd As New SqlCommand("INSERT INTO clInvoices (clInvoiceCode,clDate,clTime,clPaymentMethod,clAmountExpected,clAmountPaid,clClient," &
                                                                                                              "clType,clMerchant) VALUES " &
                                                                                "(@clInvoiceCode,@clDate,@clTime,@clPaymentMethod,@clAmountExpected,@clAmountPaid,@clClient," &
                                                                                                              "@clType,@clMerchant)",
                                        c)
            Dim tD As Date = New Date()
            With Date.Now
                tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cmd
                .Parameters.Add(New SqlParameter("@clInvoiceCode", SqlDbType.VarChar)).Value = rcpt()
                .Parameters.Add(New SqlParameter("@clDate", SqlDbType.Date)).Value = tD
                .Parameters.Add(New SqlParameter("@clTime", SqlDbType.VarChar)).Value = Now.ToShortTimeString
                .Parameters.Add(New SqlParameter("@clPaymentMethod", SqlDbType.VarChar)).Value = "Credit"
                .Parameters.Add(New SqlParameter("@clAmountExpected", SqlDbType.BigInt)).Value = CInt(l_Amt.Text)
                .Parameters.Add(New SqlParameter("@clAmountPaid", SqlDbType.BigInt)).Value = 0
                .Parameters.Add(New SqlParameter("@clClient", SqlDbType.VarChar)).Value = usr()
                .Parameters.Add(New SqlParameter("@clType", SqlDbType.VarChar)).Value = "Stock Transfer"
                .Parameters.Add(New SqlParameter("@clMerchant", SqlDbType.VarChar)).Value = c_TransferTo.Text

                If c.State = ConnectionState.Closed Then c.Open()

                Dim fSn As Integer = .ExecuteNonQuery()
                If fSn > 0 Then
                    GoTo 2
                End If
            End With

            Exit Sub

2:          For Each row As DataGridViewRow In dg_List.Rows

                If Not row.Cells(1).Value = "" Then

                    With c_Sales
                        .Open()
                    End With
                    Dim cm As New SqlCommand("INSERT INTO clSales (clSalesInvoice,clSalesMerchant,clDate,clTime,clProduct,clQuantity," &
                                                   "clMerchant,clPrice,clDiscount,clPayMeans,clCategory,clUser,clCost)" &
                                                                     " VALUES " &
                                                     "(@clSalesInvoice,@clSalesMerchant,@clDate,@clTime,@clProduct,@clQuantity," &
                                                            "@clMerchant,@clPrice,@clDiscount,@clPayMeans,@clCategory,@clUser,@clCost)",
                                           c_Sales)

                    With Date.Now
                        tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
                    End With
                    With cm
                        .Parameters.Add(New SqlParameter("@clSalesInvoice", SqlDbType.VarChar)).Value = rcpt()
                        .Parameters.Add(New SqlParameter("@clSalesMerchant", SqlDbType.VarChar)).Value = usr()
                        .Parameters.Add(New SqlParameter("@clDate", SqlDbType.Date)).Value = tD
                        .Parameters.Add(New SqlParameter("@clTime", SqlDbType.VarChar)).Value = tD.ToShortTimeString
                        .Parameters.Add(New SqlParameter("@clProduct", SqlDbType.VarChar)).Value = row.Cells(1).Value
                        .Parameters.Add(New SqlParameter("@clQuantity", SqlDbType.Int)).Value = CInt(row.Cells(3).Value)
                        .Parameters.Add(New SqlParameter("@clMerchant", SqlDbType.VarChar)).Value = c_TransferTo.Text
                        .Parameters.Add(New SqlParameter("@clPrice", SqlDbType.BigInt)).Value = CInt(row.Cells(4).Value)
                        .Parameters.Add(New SqlParameter("@clDiscount", SqlDbType.BigInt)).Value = 0
                        .Parameters.Add(New SqlParameter("@clPayMeans", SqlDbType.VarChar)).Value = "Credit"
                        .Parameters.Add(New SqlParameter("@clCategory", SqlDbType.VarChar)).Value = row.Cells(2).Value
                        .Parameters.Add(New SqlParameter("@clUser", SqlDbType.VarChar)).Value = usr

                        Dim pCost As Integer = CInt(Qry("Select clUnitCost FROM clProducts WHERE clName='" & row.Cells(1).Value & "'", c_Products))
                        .Parameters.Add(New SqlParameter("@clCost", SqlDbType.BigInt)).Value = CInt(row.Cells(3).Value * pCost)
                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then
                            c_Sales.Close()

                            Dim pQty As Integer = Qry("SELECT clQty FROM clProducts WHERE clName='" &
                                                      row.Cells(1).Value & "'",
                                                      c_Products)

                            xQry("UPDATE clProducts SET clQty='" &
                                 pQty - CType(row.Cells(3).Value, Integer) &
                                 "' WHERE clName='" &
                                 row.Cells(1).Value & "'",
                                 c_Products)

                        End If
                    End With

                End If

            Next

            btnSave.Enabled = False

            Dim mg As MsgBoxResult = MsgBox("Print Invoice?", MsgBoxStyle.YesNo)

            If Not mg = MsgBoxResult.Yes Then GoTo 7

            TotalPrice = FormatNumber(subTotal(5), 2, TriState.True)

            Discounts = 0

            AmountPaid = TotalPrice

            InitiatePrint(dg_List)

            If Current = PrintAction.IsInPhase Or Current = PrintAction.Succeeded Then
                Console.WriteLine("Printing began at " & Date.Now.ToShortTimeString)
            Else
                Console.WriteLine("Printing failed at " & Date.Now.ToShortTimeString)
            End If

7:          btnReset_Click(Nothing, Nothing)

        Catch ex As SqlException
            MsgBox(ex.Message)
            If c.State = ConnectionState.Open Then c.Close()
            c_Products.Close()
            c_Sales.Close()

        End Try

    End Sub

    Private Sub c_TransferFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_TransferFrom.SelectedIndexChanged
        If c_TransferFrom.Text = "" Then Exit Sub
        Dim tbl As DataTable = xRead("SELECT cmpName FROM companyData", "companyData")
        c_TransferTo.Items.Clear()
        For Each row In tbl.Rows
            If Not row(0).ToString = c_TransferFrom.Text Then
                c_TransferTo.Items.Add(row(0).ToString)
            End If
        Next

    End Sub
End Class