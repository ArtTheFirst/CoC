Public Class UserLog

    Protected tbl As DataTable
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

    Sub LoadUp()
        disBandTbl()

        tbl = xRead("SELECT clName,clLogEntryDate,clLogEntry,clLogNote FROM clLogsHistory", "clLogsHistory")
        dg_List.DataSource = tbl

        dg_List.ReadOnly = True
        dg_List.AutoResizeColumns()
        dg_List.Columns.Item(0).HeaderText = "USERNAME"
        dg_List.Columns.Item(1).HeaderText = "LOG ENTRY DATE"
        dg_List.Columns.Item(2).HeaderText = "LOG ENTRY TIME"
        dg_List.Columns.Item(3).HeaderText = "LOG STATUS"

        dg_List.AutoResizeColumns()

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        LoadUp()
    End Sub

End Class