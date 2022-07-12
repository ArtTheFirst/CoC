Public Class BarcodeSearch

    Private tbl As DataTable

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadItem("")
        IsOpen = True
    End Sub

    Private IsOpen As Boolean = False
    Sub loadItem(s As String)

        Dim DGVS As DataGridViewCellStyle = Nothing
        Try
            tbl = xRead("SELECT SerialId,clName,clBarcode FROM clItmPrx" & s, "clItmPrx", cItems)
            dg_List.DataSource = tbl
            If Not IsOpen Then
                dg_List.ReadOnly = True
                dg_List.AutoResizeColumns()
                dg_List.Columns.Item(0).HeaderText = "CODE"
                dg_List.Columns.Item(1).HeaderText = "ITEM NAME"
                dg_List.Columns.Item(2).HeaderText = "BARCODE"
            End If

            s = Nothing

        Catch ex As Exception

        End Try

    End Sub

    Private Sub t_Code_TextChanged(sender As Object, e As EventArgs) Handles t_Code.TextChanged
        Dim condition As String = Nothing
        Dim pId As String = Nothing
        Dim p = Nothing
        Try
            condition = " WHERE clBarcode ILIKE '%" & t_Code.Text & "%' OR SerialId ILIKE '%" & t_Code.Text & "%' OR clName ILIKE '%" & t_Code.Text & "%'"
            loadItem(condition)
        Catch ex As Exception
        End Try

    End Sub

End Class