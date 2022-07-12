Public Class StockStatus_Branch

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
    Sub loadStockStatus()
        Dim CId As String = Nothing
        Dim Sql As String = Nothing
        Dim condition As String = Nothing
        If Id = "HQ0001" Then
            CId = "clItems"
            condition = ""
        Else
            CId = "clItemsHistory"
            condition = " WHERE clCId='" & Id & "'"
        End If

        Sql = "SELECT clName,clQty FROM " & CId & condition & " ORDER BY clName"

        headerText.Text = String.Concat("Stock Status - ", CompanyInfo)
        disBandTbl()
        tbl = xRead(Sql, CId, cItems)
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

            dg_List.ReadOnly = True

        Catch ex As Exception
            write_Error(ex.Message, Name)
            Close()
        End Try
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadStockStatus()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            disBandTbl()
            Close()
        End If

    End Sub

End Class