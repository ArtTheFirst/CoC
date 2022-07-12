Public Class CompanyList

    Sub loadColumns()
        lv_list.Columns.Clear()

        Dim lvColumnHeader As ColumnHeader
        Dim iLength As Integer = lv_list.Width / 3
        lvColumnHeader = lv_list.Columns.Add("SID")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_list.Columns.Add("COMPANY NAME")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_list.Columns.Add("BRANCH INFO")
        lvColumnHeader.Width = iLength

    End Sub
    Sub loadData()
        Dim tbl As DataTable = xRead("SELECT SerialId,cmpName,cmpBranchInfo FROM companyData WHERE SerialId<>'HQ0001'", "companyData")
        lv_list.Items.Clear()
        For Each row In tbl.Rows
            Dim lvI As ListViewItem = lv_list.Items.Add(row(0).ToString)
            lvI.SubItems.Add(row(1).ToString)
            lvI.SubItems.Add(row(2).ToString)

        Next

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        CompanyInfo = ""
        loadColumns()
        loadData()

    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If

    End Sub

    Private Sub lv_Products_DoubleClick(sender As Object, e As EventArgs) Handles lv_list.DoubleClick
        Try
            If lv_list.FocusedItem.SubItems(1).Text = "" Then Close() Else GoTo 3
        Catch ex As Exception
            Close()
        End Try
        Exit Sub
3:      CompanyInfo = lv_list.FocusedItem.Text
        _Company = _AddMode.IsOld
        Close()
    End Sub

End Class