Public Class Purchase_CategoryCtrl

    Sub loadList()
        Dim tbl As DataTable = xRead("SELECT * FROM clCategories WHERE clCategory='Purchases'", "clCategories",)
        t_Name.Clear()
        dg_List.Rows.Clear()
        For Each row In tbl.Rows
            dg_List.Rows.Add(row(0).ToString, row(1).ToString)
        Next
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadList()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim result As String = Nothing
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            If t_Name.Text.Length < 3 Then t_Name.Clear() : Exit Sub
            result = xQry("INSERT INTO clCategories (SerialId,clName,clCategory) VALUES ('" & SerialId() & "','" & t_Name.Text & "','Purchases')",)
            MsgBox(result)
            loadList()

        ElseIf e.KeyCode = Keys.Enter Then
            If Not CanProceed Then Exit Sub
            selectContent()
        End If

    End Sub
    Private CanProceed As Boolean = False
    Sub selectContent()
        Dim r As Integer = 0
        Try
            r = dg_List.CurrentCell.RowIndex
            Id = dg_List.Rows(r).Cells(1).Value
        Catch ex As Exception
            Id = ""
        End Try
        Close()
    End Sub

    Private Sub dgList_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        Dim result As String = Nothing
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
                Dim nDR As DataGridViewRow = dg_List.Rows(counter)
                result = xQry("DELETE FROM clCategories WHERE SerialId='" & nDR.Cells(0).Value & "' AND clCategory='Purchases'",)
                MsgBox(result)
            Catch ex As Exception
            Finally
                loadList()
            End Try

        ElseIf e.KeyCode = Keys.Enter Then
            For Each row As DataGridViewRow In dg_List.Rows
                result = xQry("UPDATE clCategories SET clName='" & row.Cells(1).Value &
                     "' WHERE SerialId='" & row.Cells(0).Value & "' AND clCategory='Purchases'",)
            Next
            loadList()

        End If

    End Sub

End Class