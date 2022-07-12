
Imports System.ComponentModel

Public Class Items_CategoryCtrl

    Sub loadList()
        Dim tbl As DataTable = xRead("SELECT * FROM clCategories WHERE clCategory='Item'",
                                     "clCategories", c)
        t_Name.Clear()
        dg_List.Rows.Clear()
        For Each row In tbl.Rows
            dg_List.Rows.Add(row(0).ToString, row(1).ToString)
        Next
    End Sub
    Private CanProceed As Boolean = False
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        CanProceed = False
        loadList()
        lb.Items.Clear()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim result As String = Nothing
        If e.KeyCode = Keys.Escape Then
            CanProceed = False
            Close()
        ElseIf e.KeyData = Keys.F1 Then

            If t_Name.Text.Length < 3 Then t_Name.Clear() : Exit Sub
            result = xQry("INSERT INTO clCategories (SerialId,clName,clCategory) VALUES ('" & SerialId() & "','" & t_Name.Text & "','Item')",)
            MsgBox(result)
            loadList()

        ElseIf e.KeyCode = Keys.Enter Then
            CanProceed = True
            Close()
        End If

    End Sub
    Sub selectContent()
        Dim r As Integer = 0
        Try
            r = dg_List.CurrentCell.RowIndex
            Id = dg_List.Rows(r).Cells(1).Value
        Catch ex As Exception
            Id = ""
        End Try

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)

        If Not CanProceed Then Exit Sub

        If CurrentItem = SearchIs.Create Then
            selectContent()
        ElseIf CurrentItem = SearchIs.Reports Then
            count = lb.Items.Count
            If count > 0 Then _Id = Slicelist(lb, count, 1) Else _Id = ""
            CurrentItem = SearchIs._IsAbsolutelyNothing
            count = 0
        End If

    End Sub

    Private Sub dgList_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        Dim result As String = Nothing
        If e.KeyData = Keys.Delete Then
            If CurrentItem = SearchIs.Reports Then Exit Sub
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
                Dim nDR As DataGridViewRow = dg_List.Rows(counter)
                result = xQry("DELETE FROM clCategories WHERE SerialId='" & nDR.Cells(0).Value & "' AND clCategory='Item'",)
                MsgBox(result)
            Catch ex As Exception
            Finally
                loadList()
            End Try
        ElseIf e.KeyCode = Keys.Space Then
            If Not CurrentItem = SearchIs.Reports Then Exit Sub
            If r = -1 Then Exit Sub
            Dim dR As DataGridViewRow = dg_List.Rows(r)
            With dR

                If Not .Cells(0).Style.BackColor = Color.Gainsboro Then

                    .Cells(0).Style.BackColor = Color.Gainsboro

                    If Not lb.Items.Contains(.Cells(1).Value) Then lb.Items.Add(.Cells(1).Value)

                Else

                    .Cells(0).Style.BackColor = Color.White

                    If lb.Items.Contains(.Cells(1).Value) Then lb.Items.Remove(.Cells(1).Value)

                End If

            End With
        ElseIf e.KeyCODE = Keys.ENTER Then

            For Each row As DataGridViewRow In dg_List.Rows
                result = xQry("UPDATE clCategories SET clName='" & row.Cells(1).Value &
                         "' WHERE SerialId='" & row.Cells(0).Value & "' AND clCategory='Item'",)
            Next
            loadList()

        End If

    End Sub

    Private Sub dgList_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        r = e.RowIndex
    End Sub

    Private lb As New ListBox
    Private count As Integer = 0
    Private r As Integer = -1

End Class