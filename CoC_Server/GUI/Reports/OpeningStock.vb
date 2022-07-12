Public Class OpeningStock

    Sub clearFields()
        dg_List.Rows.Clear()
        calcValues()
    End Sub
    Sub calcValues()
        Dim qty As Integer = 0
        Dim selling As Integer = 0
        Dim tax As Integer = 0
        Dim total As Integer = 0
        Try
            qty = subTotal(3)
            selling = subTotal(4)
            tax = subTotal(5)
            total = subTotal(6)
        Catch ex As Exception
            qty = 0
            selling = 0
            tax = 0
            total = 0
        Finally
            l_Qty.Text = FormatNumber(qty, 2, TriState.True)
            l_Selling.Text = FormatNumber(selling, 2, TriState.True)
            l_Tax.Text = FormatNumber(tax, 2, TriState.True)
            l_Total.Text = FormatNumber(total, 2, TriState.True)
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

    Sub alignValues()
        calcValues()
        Dim cRect As Rectangle = dg_List.GetCellDisplayRectangle(3, 0, False)
        cRect.X += dg_List.Left
        l_Qty.Location = New Point(cRect.X, l_Qty.Location.Y)

        cRect = dg_List.GetCellDisplayRectangle(4, 0, False)
        cRect.X += dg_List.Left
        l_Selling.Location = New Point(cRect.X, l_Selling.Location.Y)

        cRect = dg_List.GetCellDisplayRectangle(5, 0, False)
        cRect.X += dg_List.Left
        l_Tax.Location = New Point(cRect.X, l_Tax.Location.Y)

        cRect = dg_List.GetCellDisplayRectangle(6, 0, False)
        cRect.X += dg_List.Left
        l_Total.Location = New Point(cRect.X, l_Total.Location.Y)

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
        Dim tbl As DataTable = xRead("SELECT clCategoryId,clPrice,clDiscount " &
                                     "FROM " &
                                     "clProducts WHERE clName='" & productName & "'", "clProducts",
                                     c_Products)
        For Each row In tbl.Rows
            dg_List.Rows.Add(" ", productName,
                             row(0).ToString,
                             0)

            Dim newDataRow As DataGridViewRow
            Dim counter As Integer = dg_List.CurrentRow.Index + 1
            If counter = dg_List.RowCount Then
                newDataRow = dg_List.Rows(0)
            Else
                newDataRow = dg_List.Rows(counter)
            End If
            dg_List.CurrentCell = newDataRow.Cells(0)

        Next

    End Sub

    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter

        Try
            Dim newDataRow As DataGridViewRow = dg_List.Rows(e.RowIndex)
            With newDataRow

                If dg_List.CurrentCell.ColumnIndex = 1 Then loadDetails(.Cells(1).Value)

                .Cells(3).Value = FormatNumber(.Cells(3).Value, 2, TriState.True)
                .Cells(4).Value = FormatNumber(.Cells(4).Value, 2, TriState.True)
                .Cells(5).Value = FormatNumber(.Cells(5).Value, 2, TriState.True)
                .Cells(6).Value = FormatNumber(.Cells(6).Value, 2, TriState.True)
                .Cells(7).Value = FormatNumber(.Cells(7).Value, 2, TriState.True)
                '//Totals
                .Cells(9).Value = FormatNumber((CInt(.Cells(3).Value) * CInt(.Cells(4).Value)) - CInt(.Cells(5).Value),
                                               2,
                                               TriState.True)
                .Cells(10).Value = FormatNumber((CInt(.Cells(3).Value) * CInt(.Cells(6).Value)) - CInt(.Cells(7).Value),
                                               2,
                                               TriState.True)

                Dim totals As Integer = CInt(.Cells(9).Value) + CInt(.Cells(10).Value)

                .Cells(8).Value = FormatNumber(totals, 2, TriState.True)

                .Cells(0).Value = e.RowIndex + 1

            End With
            calcValues()
        Catch ex As Exception
        End Try
    End Sub

End Class