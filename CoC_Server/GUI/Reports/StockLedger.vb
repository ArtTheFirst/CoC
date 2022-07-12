Public Class StockLedger
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
    Sub loadStockLedger()
        disBandTbl()
        tbl = xRead("SELECT clName,clQty FROM clItems ORDER BY clName", "clItems", cItems)
        Try
            dg_List.DataSource = tbl
            dg_List.ReadOnly = True
            dg_List.Columns.Item(0).HeaderText = "ITEM NAME"
            dg_List.Columns.Item(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg_List.Columns.Item(1).HeaderText = "CLOSING"
            dg_List.Columns.Item(1).Width = 180
            dg_List.Columns.Item(1).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(1).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadStockLedger()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            disBandTbl()
            Close()
        End If

    End Sub

End Class