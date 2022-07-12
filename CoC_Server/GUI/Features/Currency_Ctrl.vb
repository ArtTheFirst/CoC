Public Class Currency_Ctrl

    Sub loadList()
        Dim tbl As DataTable = xRead("SELECT * FROM clCurrency", "clCurrency",)
        dg_List.Rows.Clear()
        t_Name.Clear()
        t_Unit.Clear()
        For Each row In tbl.Rows
            dg_List.Rows.Add(row(0).ToString, row(1).ToString, row(2).ToString)
        Next
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadList()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If Not CurrentItem = SearchIs.Create Then Exit Sub
            selectContent()
        ElseIf e.KeyCode = Keys.F1 Then
            Dim result As String = Nothing
            If t_Name.Text.Length < 3 Then t_Name.Clear() : Exit Sub
            If t_Unit.Text.Length < 1 Then t_Unit.Clear() : Exit Sub
            result = xQry("INSERT INTO clCurrency (SerialId,clUnit,clName) VALUES ('" & SerialId() & "','" & t_Unit.Text & "','" & t_Name.Text & "')",)
            MsgBox(result)
            loadList()

        End If

    End Sub
    Sub selectContent()
        Dim r As Integer = 0
        Try
            r = dg_List.CurrentCell.RowIndex
            _Id = dg_List.Rows(r).Cells(1).Value
        Catch ex As Exception
            _Id = ""
        End Try
        Close()
    End Sub

    Private Sub dgList_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        Dim result As String = Nothing
        If e.KeyCode = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                'dg_List.Rows.RemoveAt(counter)
                Dim nDR As DataGridViewRow = dg_List.Rows(counter)
                result = xQry("DELETE FROM clCurrency WHERE SerialId='" & nDR.Cells(0).Value & "'",)
                MsgBox(result)
            Catch ex As Exception
            Finally
                loadList()
            End Try
        ElseIf e.KeyCode = Keys.enter Then

            For Each row As DataGridViewRow In dg_List.Rows
                result = xQry("UPDATE clCurrency SET clName='" & row.Cells(2).Value &
                     "',clUnit='" & row.Cells(1).Value & "' WHERE SerialId='" & row.Cells(0).Value & "'")
            Next
            loadList()

        End If

    End Sub

    Sub complain()
        MetroFramework.MetroMessageBox.Show(Me, "There seems to be an error. Please try again", "Error found!")
    End Sub

End Class