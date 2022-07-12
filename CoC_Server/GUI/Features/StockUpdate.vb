Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class StockUpdate

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        AddAs = DetailFrom.AbsolutelyNothing__Pity
        alignValues()
    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        alignValues()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        clearFields()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            loadIn()
        ElseIf e.KeyCode = Keys.F2 Then
            btnNew.PerformClick()
        ElseIf e.KeyCode = Keys.F9 Then
            clearFields()
        End If

    End Sub

    Sub clearFields() Handles btnClear.Click
        dg_List.Rows.Clear()
        calcValues()
        FromOut = False
    End Sub
    Sub calcValues()
        Dim qty As Integer = 0
        Dim selling As Integer = 0
        Dim discount As Integer = 0
        Dim total As Integer = 0
        Try
            qty = subTotal(3)
            selling = subTotal(4)
            discount = subTotal(5)
            total = subTotal(6)
        Catch ex As Exception
            qty = 0
            selling = 0
            discount = 0
            total = 0
        Finally
            l_Qty.Text = FormatNumber(qty, 2, TriState.True)
            l_Selling.Text = FormatNumber(selling, 2, TriState.True)
            l_Discount.Text = FormatNumber(discount, 2, TriState.True)
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

        Try
            Dim cRect As Rectangle = dg_List.GetCellDisplayRectangle(3, 0, False)
            cRect.X += dg_List.Right
            l_Qty.Location = New Point(cRect.X, l_Qty.Location.Y)

            cRect = dg_List.GetCellDisplayRectangle(4, 0, False)
            cRect.X += dg_List.Right
            l_Selling.Location = New Point(cRect.X, l_Selling.Location.Y)

            cRect = dg_List.GetCellDisplayRectangle(5, 0, False)
            cRect.X += dg_List.Right
            l_Discount.Location = New Point(cRect.X, l_Discount.Location.Y)

            cRect = dg_List.GetCellDisplayRectangle(6, 0, False)
            cRect.X += dg_List.Right
            l_Total.Location = New Point(cRect.X, l_Total.Location.Y)
        Catch ex As Exception
            write_Error(ex.Message, Name)
        End Try

    End Sub

    Private Sub dg_List_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_List.EditingControlShowing
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

        If dg_List.CurrentCell.ColumnIndex = 0 Or dg_List.CurrentCell.ColumnIndex = 3 Then
            If dg_List.Columns(dg_List.CurrentCell.ColumnIndex).HeaderText = "CODE" Or
            dg_List.Columns(dg_List.CurrentCell.ColumnIndex).HeaderText = "QTY." Then
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
            write_Error(ex.Message, Name)
            deleteRow()
        End Try

        Try
            tbl = xRead("SELECT SerialId,clName,clCategoryId,clQty,clPrice,clDiscount " &
                             "FROM " &
                             "clItems" & condition, "clItems",
                             cItems)

            If String.IsNullOrEmpty(ItemName) Then Exit Sub

            For Each row In tbl.Rows

                Dim dR As DataGridViewRow = dg_List.Rows(r)
                With dR

                    If Not FromOut Then
                        .Cells(0).Value = row(0).ToString
                        .Cells(1).Value = row(1).ToString
                        .Cells(2).Value = row(2).ToString
                        .Cells(3).Value = row(3)
                        .Cells(4).Value = FormatNumber(row(4), 2)
                        .Cells(5).Value = FormatNumber(row(5), 2)
                    Else
                        Dim SiValues As String() = New String() {row(0).ToString,
                                                                                            row(1).ToString,
                                                                                            row(2).ToString,
                                                                                            row(3),
                                                                                            FormatNumber(row(4), 2),
                                                                                            FormatNumber(row(5), 2)}
                        dg_List.Rows.Add(SiValues)
                    End If

                End With
            Next
            calcValues()

        Catch ex As Exception
            write_Error("Cannot load Item details. Please Check error code" & ex.HResult, Name)
        End Try

    End Sub

    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        calcValues()
        dg_list_CellEnter(Me, e)
    End Sub
    Dim r As Integer = -1
    Sub deleteRow()
        Try
            Dim counter As Integer = dg_List.CurrentRow.Index
            dg_List.Rows.RemoveAt(counter)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
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

                .Cells(6).Value = FormatNumber((CInt(.Cells(3).Value) * CInt(.Cells(4).Value)) - CInt(.Cells(5).Value),
                           2,
                           TriState.True)
            End With

            calcAddVal()

            calcValues()
        Catch ex As Exception
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
                    If Not v(dR.Cells(3).Value) = 0 Then
                        rVal = v(dR.Cells(3).Value) + v(eR.Cells(3).Value)
                        deleteRow()
                        eR.Cells(3).Value = rVal
                    End If
                End If
            End If

        End With
        Return 0
    End Function

    Function returns(SId, Name) As String
        Dim q As String = Nothing
        Try
            q = Qry("SELECT clBarcode FROM clItems WHERE SerialId='" & SId & "' AND clName='" & Name & "'", cItems)
        Catch ex As Exception
            q = ""
        End Try
        returns = q
    End Function

    Sub loadIn() Handles btnSave.Click
        If dg_List.Rows.Count < 0 Then Exit Sub
        Try

            If cItems.State = ConnectionState.Closed Then cItems.Open()

2:          For Each row As DataGridViewRow In dg_List.Rows

                If Not row.Cells(1).Value = "" Then
                    With cItems
                        If Not .State = ConnectionState.Open Then .Open()
                    End With
                    Dim cm As New NpgsqlCommand("UPDATE clItems SET clQty=@clQty WHERE SerialId='" & row.Cells(0).Value & "'",
                                           cItems)
                    With cm
                        .Parameters.Add(New NpgsqlParameter("@clQty", NpgsqlDbType.Integer)).Value = v(row.Cells(3).Value)
                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then
                            If cItems.State = ConnectionState.Open Then cItems.Close()
                            With l_Status
                                .BackColor = Color.Teal
                                .Text = "Done"
                            End With
                            MsgBox("Saved!")
                            clearFields()
                        End If
                    End With

                End If

            Next

        Catch ex As SqlException
            write_Error(ex.Message, Name)
            With l_Status
                .BackColor = Color.Red
                .Text = "Error found"
            End With
            If cItems.State = ConnectionState.Open Then cItems.Close()
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
        ElseIf e.KeyData = Keys.Enter Then
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

    Function dbName() As String
        Dim FilteredString As String = Nothing
        Try
            FilteredString = JournalDate.ToShortDateString.Replace("/", "").Replace("-", "").Replace("=", "").Replace("'", "")
        Catch ex As Exception
        End Try
        Return String.Concat("clStockStatus", FilteredString)
    End Function

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        _Item = ___Is._New
        Dim f As New Items
        If Not f.Visible Then f.ShowDialog()
    End Sub

End Class