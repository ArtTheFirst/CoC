Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class OfferManagement

    Private tbl As DataTable = Nothing
    Sub disBandTbl()
        Try
            tbl.Clear()
            dg_List.DataSource = tbl
            dg_List.DataSource = Nothing
            dg_List.Rows.Clear()
            dg_List.Columns.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadReset(Authentication.AsAdd)
        'autosText(t_Name, "clName", "clItems", cItems, , " ")
        t_Name.Focus()
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Escape Then
            loadReset(Authentication.AsReset)
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        End If

    End Sub
    Enum Authentication
        AsAdd
        AsReset
    End Enum
    Sub loadReset(_Process As Authentication)
        Dim tD As New DateTime
        With Date.Now
            tD = New Date(.Year, .Month, .Day, 23, 59, 59)
        End With
        price = 0
        t_Discount.Text = 0
        t_Qty.Text = 1
        t_Name.Clear()
        l_PriceAfter.Text = l_PriceAfter.Tag
        l_PriceReal.Text = l_PriceReal.Tag
        dtp_StartDate.Value = tD
        dtp_EndDate.Value = tD

        If _Process = Authentication.AsAdd Then
            Try
                'dg_List.Rows.Clear()
                disBandTbl()
                Dim tbl As DataTable = xRead("SELECT SerialId,clName,clAmount,clQty," &
                                                                             "clStartDate,clEndDate " &
                                                                 "FROM clDiscountables",
                                             "clDiscountables")

                dg_List.DataSource = tbl

                dg_List.Columns.Item(0).HeaderText = "CODE"
                dg_List.Columns.Item(0).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
                dg_List.Columns.Item(0).DefaultCellStyle.Format = "n2"
                dg_List.Columns.Item(1).HeaderText = "NAME"
                dg_List.Columns.Item(1).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
                dg_List.Columns.Item(2).HeaderText = "DISCOUNT AMOUNT"
                dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
                dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
                dg_List.Columns.Item(2).DefaultCellStyle.Format = "n2"
                dg_List.Columns.Item(3).HeaderText = "DISCOUNT QTY"
                dg_List.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
                dg_List.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
                dg_List.Columns.Item(3).DefaultCellStyle.Format = "n0"
                dg_List.Columns.Item(4).HeaderText = "START DATE"
                dg_List.Columns.Item(4).DefaultCellStyle.Format = "g"
                dg_List.Columns.Item(4).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
                dg_List.Columns.Item(5).HeaderText = "END DATE"
                dg_List.Columns.Item(5).DefaultCellStyle.Format = "g"
                dg_List.Columns.Item(5).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)

                dg_List.ReadOnly = True

                dg_List.AutoResizeColumns()

            Catch ex As Exception

            End Try
        Else
            disBandTbl()
        End If

        Dim rowTotal As Integer = dg_List.Rows.Count

        Dim dscTotal = subTotal(2)

        l_Total.Text = String.Concat(rowTotal, " Records / ", FormatNumber(dscTotal, 2, TriState.True))

    End Sub
    Private price As Integer = 0
    Sub calcProd()
        Try
            l_PriceAfter.Text = (CType(t_Discount.Text, Integer) / 100) * (CType(t_Qty.Text, Integer) * price)
        Catch ex As Exception
            l_PriceAfter.Text = 0
        End Try

    End Sub

    Private Sub t_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Name.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If t_Name.Text.Length < 1 Then t_Name.Focus() : Exit Sub
            loadItemDetails()
        End If

    End Sub
    Sub loadItemDetails()
        searchModule = IsIn.TXNMode
        CurrentItem = SearchIs.Create
        Dim h As New ItemSearch : If Not h.Visible Then h.ShowDialog
        If Trim(Code) = "" Then Exit Sub
        Try
            Dim tbl As DataTable = xRead("SELECT clName,clPrice FROM clItems WHERE SerialId='" & Code & "'", "clItems", cItems)
            'dg_List.Rows.Clear()
            For Each row In tbl.Rows
                t_Name.Text = row(0).ToString
                price = row(1)
                l_PriceReal.Text = String.Concat("Price: ", price)
                calcProd()
            Next
            t_Qty.Focus()
        Catch ex As Exception
        End Try

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

    Private Sub IntKeyTrap(sender As Object, e As KeyPressEventArgs) Handles t_Qty.KeyPress, t_Discount.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub t_Qty_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Qty.KeyDown
        If e.KeyCode = Keys.Enter Then
            t_Discount.Focus()
        End If

    End Sub
    Private Sub t_Discount_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Discount.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_StartDate.Focus()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not fieldsOk() Then Exit Sub

        Dim mgReq As MsgBoxResult = MsgBox("Save?", MsgBoxStyle.OkCancel)

        If Not mgReq = MsgBoxResult.Ok Then Exit Sub

        Dim c_Pr As String = Nothing
        Try
            c_Pr = CStr(Qry("SELECT SerialId FROM clDiscountables WHERE clName='" & t_Name.Text & "clDiscountables'", c))
        Catch ex As Exception
            c_Pr = ""
        End Try
        If c_Pr = "" Then
            With c
                .Open()
            End With
            Dim SqlString As String = Nothing
            SqlString = "INSERT INTO clDiscountables (SerialId,clName," &
                                                                                            "clQty,clAmount," &
                                                                                            "clStartDate,clEndDate)" &
                                                                                                  " VALUES " &
                                                                                                  "(@SerialId,@clName," &
                                                                                            "@clQty,@clAmount," &
                                                                                            "@clStartDate,@clEndDate)"

            Dim cm As New NpgsqlCommand(SqlString,
                                           c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = Code
                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = t_Name.Text
                .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = CInt(t_Qty.Text)
                .Parameters.Add(New NpgsqlParameter("@clAmount", NpgsqlDbType.Bigint)).Value = CLng(l_PriceAfter.Text)

                Dim d1, d2 As DateTime
                With dtp_StartDate.Value
                    d1 = New Date(.Year, .Month, .Day, 0, 0, 0)
                End With
                With dtp_EndDate.Value
                    d2 = New Date(.Year, .Month, .Day, 23, 59, 59)
                End With

                cm.Parameters.Add(New NpgsqlParameter("@clStartDate", NpgsqlDbType.Timestamp)).Value = d1
                cm.Parameters.Add(New NpgsqlParameter("@clEndDate", NpgsqlDbType.Timestamp)).Value = d2
                If Not c.State = ConnectionState.Open Then c.Open()
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    loadReset(Authentication.AsAdd)
                End If
            End With : End If

    End Sub
    Function fieldsOk() As Boolean
        Return t_Name.Text.Length > 1 AndAlso CInt(t_Qty.Text) > 0 AndAlso CInt(t_Discount.Text) > 0
    End Function

    Private Sub dtp_StartDate_ValueChanged(sender As Object, e As EventArgs)
        dtp_EndDate.MinDate = dtp_StartDate.Value
    End Sub
    Private Sub dtp_StartDate_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            dtp_EndDate.Focus()
        End If
    End Sub
    Private Sub dtp_EndDate_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub t_Qty_TextChanged(sender As Object, e As EventArgs) Handles t_Qty.TextChanged
        calcProd()
    End Sub
    Private Sub t_Discount_TextChanged(sender As Object, e As EventArgs) Handles t_Discount.TextChanged
        calcProd()
    End Sub

    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            If dg_List.Rows.Count < 0 Then Exit Sub
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                Dim ndr As DataGridViewRow = dg_List.Rows(counter)
                Dim SId As String = ndr.Cells(0).Value

                Dim mgReq As MsgBoxResult = MsgBox("Continue?", MsgBoxStyle.OkCancel)

                If Not mgReq = MsgBoxResult.Ok Then Exit Sub

                xQry("DELETE FROM clDiscountables WHERE SerialId='" & SId & "'")
                loadReset(Authentication.AsAdd)
            Catch ex As Exception

            End Try

        End If

    End Sub

End Class