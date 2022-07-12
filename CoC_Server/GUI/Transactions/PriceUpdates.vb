Imports System.Data.SqlClient
Public Class PriceUpdates

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            loadIn()
        ElseIf e.KeyCode = Keys.F5 Then
            btnReset_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub dg_List_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dg_List.EditingControlShowing
        Dim col As String = dg_List.Columns(2).HeaderText
        If Not col = "PRODUCT NAME" Then Exit Sub
        Dim autoBox As TextBox = Nothing
        autoBox = TryCast(e.Control, TextBox)
        If autoBox Is Nothing Then Exit Sub
        autosText(autoBox, "clName", "clProducts", c_Products)

    End Sub
    Sub loadDetails(productName As String)
        If productName.Length < 1 Then Exit Sub
        Dim tbl As DataTable = xRead("SELECT SerialId,clPrice " &
                                     "FROM " &
                                     "clProducts WHERE clName='" & productName & "'", "clProducts",
                                     c_Products)
        If productName = "" Or productName Is DBNull.Value Then Exit Sub
        For Each row In tbl.Rows

            Dim newDataRow As DataGridViewRow = dg_List.Rows(r)
            With newDataRow
                .Cells(1).Value = row(0).ToString
                .Cells(2).Value = productName
                .Cells(3).Value = row(1)

            End With
        Next

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
                If dg_List.CurrentCell.ColumnIndex = 2 Then loadDetails(.Cells(2).Value)
                '.Cells(3).Value = FormatNumber(CInt(.Cells(3).Value), 0)
                .Cells(0).Value = e.RowIndex + 1
            End With
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

                If Not row.Cells(2).Value = "" Then
                    With c_Products
                        If Not .State = ConnectionState.Open Then .Open()
                    End With
                    Dim cm As New SqlCommand("UPDATE clProducts SET clPrice=@clPrice WHERE clName='" & row.Cells(2).Value & "'",
                                           c_Products)
                    With cm
                        .Parameters.Add(New SqlParameter("@clPrice", SqlDbType.BigInt)).Value = vl(row.Cells(3).Value)
                        Dim fSnd As Integer = .ExecuteNonQuery()
                        If fSnd > 0 Then
                            If c_Products.State = ConnectionState.Open Then c_Products.Close()
                            MsgBox("Saved!")
                            dg_List.Rows.Clear()
                        End If
                    End With

                End If

            Next

        Catch ex As SqlException
            MsgBox(ex.Message)
            If c_Products.State = ConnectionState.Open Then c_Products.Close()
            dg_List.Rows.Clear()
        End Try

    End Sub

    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        dg_List.Rows.Clear()
    End Sub

End Class