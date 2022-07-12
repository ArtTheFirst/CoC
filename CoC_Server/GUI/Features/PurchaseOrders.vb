Imports System.ComponentModel

Public Class PurchaseOrders

    Sub loadList()
        Try
            Dim tbl As DataTable = xRead("SELECT clInvoiceCode,clCustomer,clDate FROM clInvoices" &
                                         " WHERE clDate" & SQLDate &
                                         " AND clType='Purchase Order'", "clInvoices", cTXNs)
            dg_List.Rows.Clear()
            For Each row In tbl.Rows
                dg_List.Rows.Add(" ", row(0).ToString, row(1).ToString, row(2))
            Next
        Catch ex As Exception
            MsgBox("FAILED TO INITIATE! " & ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        dg_List.Rows.Clear()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf (e.KeyCode = Keys.D And e.Modifiers = Keys.Control) Or (e.KeyCode = Keys.D And e.Modifiers = Keys.ControlKey) Then
            filterDate_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Enter Then
            Dim r As Integer = dg_List.CurrentRow.Index
            Dim dR As DataGridViewRow = dg_List.Rows(r)
            With dR
                If .Cells(1).Value Is DBNull.Value Then Exit Sub
                Inv = .Cells(1).Value
                _Purchase = EnterMode.IsPurchaseOrder
                Close()
                Purchases.Show()

            End With
        End If

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
            Dim dR As DataGridViewRow = dg_List.Rows(e.RowIndex)
            With dR
                .Cells(4).Value = FormatNumber(.Cells(4).Value, 0)
                .Cells(0).Value = e.RowIndex + 1
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub filterDate_Click(sender As Object, e As EventArgs) Handles filterDate.Click
        DateControl.ShowDialog()
        filterDate.Text = String.Concat("date filter [", SQLDate, "]")
        loadList()
    End Sub

End Class