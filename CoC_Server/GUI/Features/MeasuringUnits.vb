Public Class MeasuringUnits
    Private GoOn As Boolean = False
    Sub loadList()
        Dim tbl As DataTable = xRead("SELECT * FROM clMeasuringUnits", "clMeasuringUnits",)
        dg_List.Rows.Clear()
        t_Name.Clear()
        For Each row In tbl.Rows
            dg_List.Rows.Add(row(0).ToString, row(1).ToString)
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
            If String.IsNullOrEmpty(t_Name.Text) Then Exit Sub
            If t_Name.Text.Length < 2 Then t_Name.Clear() : Exit Sub
            Dim result As String = xQry("INSERT INTO clMeasuringUnits (SerialId,clName) VALUES ('" & SerialId() & "','" & t_Name.Text & "')",)
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
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                'dg_List.Rows.RemoveAt(counter)
                Dim nDR As DataGridViewRow = dg_List.Rows(counter)
                result = xQry("DELETE FROM clMeasuringUnits WHERE SerialId='" & nDR.Cells(0).Value & "'",)
                MsgBox(result)
            Catch ex As Exception
            Finally
                loadList()
            End Try
        ElseIf e.KeyCode = Keys.Enter Then

            For Each row As DataGridViewRow In dg_List.Rows
                If Not row.Cells(0).Value = "" And Not row.Cells(1).Value = "" Then
                    result = xQry("UPDATE clMeasuringUnits SET clName='" & row.Cells(1).Value &
                                        "' WHERE SerialId='" & row.Cells(0).Value & "'")
                End If
            Next
            loadList()

        End If

    End Sub
    Sub complain()
        MetroFramework.MetroMessageBox.Show(Me, "There seems to be an error. Please try again", "Error found!")
    End Sub

End Class