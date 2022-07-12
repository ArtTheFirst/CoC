Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

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

        If dg_List.CurrentCell.ColumnIndex = 0 Then
            If dg_List.Columns(dg_List.CurrentCell.ColumnIndex).HeaderText = "CODE" Then
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
    Sub deleteRow()
        Try
            Dim counter As Integer = dg_List.CurrentRow.Index
            dg_List.Rows.RemoveAt(counter)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub chkLoadNegatives_CheckedChanged(sender As Object, e As EventArgs) Handles chkLoadNegatives.CheckedChanged
        btnBalanceOut.Visible = chkLoadNegatives.Checked
        btnBalanceOut.Enabled = chkLoadNegatives.Checked
        Try
            FromOut = True
            dg_List.Rows.Clear()
            Dim tbl As DataTable = xRead("SELECT SerialId,clName,clPrice FROM clItems WHERE clPrice<'1'",
                                         "clItems",
                                 cItems)
            For Each row In tbl.Rows
                Dim SiValues As String() = New String() {row(0).ToString,
                                                                                            row(1).ToString,
                                                                                            row(2)}
                dg_List.Rows.Add(SiValues)
            Next

            FromOut = False

        Catch ex As Exception
            write_Error(ex.Message & "; Negate Module", Name)
        End Try

    End Sub
    Private Sub btnBalanceOut_Click(sender As Object, e As EventArgs) Handles btnBalanceOut.Click
        If dg_List.Rows.Count <= 0 Then
            MsgBox("Cannot be empty list", MsgBoxStyle.Critical)
            chkLoadNegatives.CheckState = CheckState.Unchecked
        Else
            GoTo 3
        End If

        Exit Sub
3:      Try

            FromOut = True

            For Each rw As DataGridViewRow In dg_List.Rows

                If Not rw.Cells(0).Value = "" Then
                    If Not rw.Cells(1).Value = "" Then
                        If Not rw.Cells(1).Value Is DBNull.Value Then

                            If rw.Cells(2).Value <= 0 Then
                                rw.Cells(2).Value = 1
                            End If

                        End If
                    End If
                End If
            Next

            FromOut = False

        Catch ex As Exception
            write_Error(ex.Message & "; Balance Negate Module", Name)
        End Try

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
            tbl = xRead("SELECT SerialId,clName,clPrice " &
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
                        .Cells(2).Value = row(2)
                    Else
                        Dim SiValues As String() = New String() {row(0).ToString,
                                                                                            row(1).ToString,
                                                                                            row(2)}
                        dg_List.Rows.Add(SiValues)
                    End If

                End With
            Next

        Catch ex As Exception
            'write_Error("Cannot load Item details. Please Check error code" & ex.HResult, Name)
        End Try

    End Sub

    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        'dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        'dg_list_CellEnter(Me, e)
    End Sub
    Dim r As Integer = -1
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
                '.Cells(3).Value = FormatNumber(CInt(.Cells(3).Value), 0)
            End With
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
    Function returns(SId, Name) As String
        Dim q As String = Nothing
        Try
            q = Qry("SELECT clBarcode FROM clItems WHERE SerialId='" & SId & "' AND clName='" & Name & "'", cItems)
        Catch ex As Exception
            q = ""
        End Try
        returns = q
    End Function
    Function vl(value)
        Dim r = 0
        Try
            r = value * 1
        Catch ex As Exception
            r = 0
        End Try
        Return r
    End Function
    Sub loadIn() Handles btnSave.Click
        If dg_List.Rows.Count < 0 Then Exit Sub
        Try

            If cItems.State = ConnectionState.Closed Then cItems.Open()

2:          For Each row As DataGridViewRow In dg_List.Rows

                If Not row.Cells(1).Value = "" Then
                    If Not vl(row.Cells(2).Value) = 0 Then
                        With cItems
                            If Not .State = ConnectionState.Open Then .Open()
                        End With
                        Dim cm As New NpgsqlCommand("UPDATE clItems SET clPrice=@clPrice WHERE SerialId='" & row.Cells(0).Value & "'",
                                               cItems)

                        With cItems
                            If Not .State = ConnectionState.Open Then .Open()
                        End With

                        With cm
                            .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = row.Cells(2).Value
                            Dim fSnd As Integer = .ExecuteNonQuery()
                            If fSnd > 0 Then
                                cItems.Close()
                                l_Status.BackColor = Color.Teal
                                l_Status.Text = "Success"

                                xQry("UPDATE clItmPrx SET clPrice='" & row.Cells(2).Value & "' WHERE SerialId='" & row.Cells(0).Value & "'", cItems)

                                xQry("UPDATE " & dbName() & " SET clPrice='" & row.Cells(2).Value & "' WHERE clItemId='" & row.Cells(0).Value & "'", cTXNs)

                            Else
                                l_Status.BackColor = Color.Red
                                l_Status.Text = "Error found"
                            End If
                        End With
                    End If

                End If

            Next

        Catch ex As Exception
            write_Error(ex.Message, Name)
            With l_Status
                .BackColor = Color.Red
                .Text = "Error found"
            End With
        Finally
            MsgBox("Done")
            If Not cItems.State = ConnectionState.Closed Then cItems.Close()
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
    Private Sub dg_List_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dg_List.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim t As Integer = dg_List.CurrentRow.Index
            Dim ndr As DataGridViewRow = dg_List.Rows(t)
            With ndr
                If dg_List.CurrentCell.ColumnIndex = 0 Or dg_List.CurrentCell.ColumnIndex = 1 Then
                    If Not Trim(.Cells(0).Value) = "" Or Not Trim(.Cells(1).Value) = "" Then Exit Sub
                    CurrentItem = SearchIs.Create
                    Code = ""
                    searchModule = IsIn.TXNMode
                    Dim h As New ItemSearch : If Not h.Visible Then h.ShowDialog()
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
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        dg_List.Rows.Clear()
    End Sub

    Function dbName() As String
        Dim FilteredString As String = Nothing
        Try
            FilteredString = JournalDate.ToShortDateString.Replace("/", "").Replace("-", "").Replace("=", "").Replace("'", "")
        Catch ex As Exception
        End Try
        Return String.Concat("clStockStatus", FilteredString)
    End Function

End Class