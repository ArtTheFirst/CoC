Imports System.Data.SqlClient

Public Class StockUpdate

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        clearFields()
        alignValues()
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        alignValues()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            loadIn()
        ElseIf e.KeyCode = Keys.F5 Then
            clearFields()
        End If

    End Sub

    Sub clearFields() Handles btnReset.Click
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
        Try
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
        Catch ex As Exception

        End Try

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
        Dim tbl As DataTable = xRead("SELECT clCategoryId,clQty,clPrice,clDiscount " &
                                     "FROM " &
                                     "clProducts WHERE clName='" & productName & "'", "clProducts",
                                     c_Products)
        If productName = "" Or productName Is DBNull.Value Then Exit Sub
        For Each row In tbl.Rows

            Dim newDataRow As DataGridViewRow = dg_List.Rows(r)
            With newDataRow
                .Cells(1).Value = productName
                .Cells(2).Value = row(0).ToString
                .Cells(3).Value = row(1)
                .Cells(4).Value = FormatNumber(row(2), 2, TriState.True)
                .Cells(5).Value = FormatNumber(row(3), 2, TriState.True)

            End With
        Next
        calcValues()

    End Sub

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
                .Cells(6).Value = FormatNumber((CInt(.Cells(3).Value) * CInt(.Cells(4).Value)) - CInt(.Cells(5).Value),
                           2,
                           TriState.True)
                .Cells(0).Value = e.RowIndex + 1
            End With
            calcValues()
        Catch ex As Exception
        End Try

    End Sub
    Function vl(value) As Integer
        Dim r = 0
        If value Is DBNull.Value Then
            r = 0
        Else
            r = value
        End If
        Return r
    End Function
    Sub loadIn() Handles btnSave.Click
        If dg_List.Rows.Count < 0 Then Exit Sub
        Try

            If c_Products.State = ConnectionState.Closed Then c_Products.Open()

2:          For Each row As DataGridViewRow In dg_List.Rows

                If Not row.Cells(1).Value = "" Then
                    With c_Products
                        If Not .State = ConnectionState.Open Then .Open()
                    End With
                    Dim cm As New SqlCommand("UPDATE clProducts SET clQty=@clQty,clDiscount=@clDiscount WHERE clName='" & row.Cells(1).Value & "'",
                                           c_Products)
                    With cm
                        .Parameters.Add(New SqlParameter("@clQty", SqlDbType.Int)).Value = vl(row.Cells(3).Value)
                        .Parameters.Add(New SqlParameter("@clDiscount", SqlDbType.BigInt)).Value = vl(row.Cells(5).Value)
                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then
                            If c_Products.State = ConnectionState.Open Then c_Products.Close()
                            MsgBox("Saved!")
                            clearFields()
                        End If
                    End With

                End If

            Next

        Catch ex As SqlException
            MsgBox(ex.Message)
            If c_Products.State = ConnectionState.Open Then c_Products.Close()
            clearFields()
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

End Class