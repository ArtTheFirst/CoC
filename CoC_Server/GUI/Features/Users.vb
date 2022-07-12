Imports System.ComponentModel

Public Class Users

    Private tbl As DataTable

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Dim condititon As String = IIf(CurrentItem = SearchIs.Reports, "", " WHERE c_ClientMode='cashier'")
        Dim IncludeFirst As String = IIf(CurrentItem = SearchIs.Reports, "", " SerialId,")
        Dim DGVS As DataGridViewCellStyle = Nothing
        Try
            tbl = xRead("SELECT " & IncludeFirst & "c_Name FROM c_Login" & condititon, "c_Login")
            dg_Sales.DataSource = tbl
            dg_Sales.ReadOnly = True
            dg_Sales.Columns.Item(0).HeaderText = "ID"
            dg_Sales.Columns.Item(1).HeaderText = "USER"
            dg_Sales.AutoResizeColumns()
        Catch ex As Exception
        End Try

    End Sub
    Private count As Integer = 0
    Private r As Integer = -1
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        If CurrentItem = SearchIs.Create Then
            Try
                _Id = dg_Sales.Rows(r).Cells(0).Value
            Catch ex As Exception
                _Id = ""
            End Try
        ElseIf CurrentItem = SearchIs.Reports Then
            For Each rw As DataGridViewRow In dg_Sales.Rows
                If rw.Cells(0).Style.BackColor = Color.Gainsboro Then
                    count = count + 1
                    _Id = SliceGrid(dg_Sales, count, 1)
                End If
            Next
        End If

        count = 0
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub dg_Sales_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_Sales.KeyDown
        If e.KeyCode = Keys.Space Then
            If CurrentItem = SearchIs.Create Then Exit Sub
            If r = -1 Then Exit Sub
            Dim newDataRow As DataGridViewRow = dg_Sales.Rows(r)
            With newDataRow
                If Not .Cells(0).Style.BackColor = Color.Gainsboro Then
                    .Cells(0).Style.BackColor = Color.Gainsboro
                Else
                    .Cells(0).Style.BackColor = Color.White
                End If
            End With
        End If

    End Sub
    Private Sub dg_Sales_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Sales.CellEnter
        r = e.RowIndex
    End Sub

End Class