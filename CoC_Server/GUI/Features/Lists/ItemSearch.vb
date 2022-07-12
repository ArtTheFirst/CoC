Imports System.ComponentModel

Public Class ItemSearch

    Private tbl As DataTable = Nothing
    Private GoOn As Boolean = False
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

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadItem("")
        IsOpen = True
        GoOn = False
        lb.Items.Clear()
        lb.Items.Add(" ")
    End Sub

    Private IsOpen As Boolean = False
    Sub loadItem(s As String)

        Dim DGVS As DataGridViewCellStyle = Nothing
        Dim Sql As String = "SELECT clItmPrx.SerialId, clItmPrx.clName, clItems.clPrice FROM clItmPrx "
        Dim InnerJoin As String = " INNER JOIN clItems ON clItems.SerialId = clItmPrx.SerialId "

        Dim Search As String = "SELECT SerialId,clName,clPrice FROM clItmPrx"
        Dim IfOrder As String = " ORDER BY clName"

        Dim f As String = ""
        If s.Length < 1 Then
            f = " WHERE clPrice>'0'"
        Else
            If searchModule = IsIn.TXNMode Then
                f = s & " AND clPrice > '0'"
            ElseIf searchModule = IsIn.InAppMode Then
                f = s
            End If
        End If

        Try
            disBandTbl()
            tbl = xRead(Search & s & IfOrder, "clItems", cItems)
            dg_List.DataSource = tbl

            dg_List.ReadOnly = True

            dg_List.Columns.Item(0).HeaderText = "CODE"
            dg_List.Columns.Item(1).HeaderText = "ITEM NAME"
            dg_List.Columns.Item(2).HeaderText = "PRICE"
            dg_List.Columns.Item(2).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

            dg_List.Columns.Item(1).Width = 480
            dg_List.Columns.Item(2).Width = 180

            l_TotalRecords.Text = String.Concat(dg_List.Rows.Count, " Items Listed")

            s = Nothing

        Catch ex As Exception
            write_Error("Item search error; " & ex.Message, Name)
        End Try

    End Sub
    Private arr()
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        If CurrentItem = SearchIs.Create Then
            If Not GoOn Then AddAs = DetailFrom.AbsolutelyNothing__Pity : Exit Sub

            Try
                If Code.Length < 1 Then
                    AddAs = DetailFrom.AbsolutelyNothing__Pity
                Else
                    AddAs = DetailFrom.ItemCode
                End If
            Catch ex As Exception
                AddAs = DetailFrom.AbsolutelyNothing__Pity
            End Try
        ElseIf CurrentItem = SearchIs.Reports Then
            If Not GoOn Then Code = "" : _Id = "" : Exit Sub

            count = lb.Items.Count

            If count >= 0 Then _Id = Slicelist(lb, count, 1) Else _Id = ""

        End If

        CurrentItem = SearchIs._IsAbsolutelyNothing

        count = 0

        t_Code.Clear()

    End Sub
    Dim count As Integer = 0

    Private Sub t_Barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_Code.KeyPress
        If Asc(e.KeyChar) = 13 Then
            t_Code_TextChanged(Nothing, Nothing)
        End If

    End Sub
    Private Sub t_Code_TextChanged(sender As Object, e As EventArgs) Handles t_Code.TextChanged
        Dim condition As String = Nothing

        Try
            Dim dfs As String = " WHERE clName IS NOT NULL AND clName NOT LIKE '%-%' AND" &
                                                          " clBarcode='" & t_Code.Text &
                                                    "' OR SerialId LIKE '%" & t_Code.Text &
                                                  "%' OR clName ILIKE '%" & t_Code.Text & "%'"
            If t_Code.Text.Length < 1 Then
                condition = " WHERE clPrice>'0'"
            Else
                If searchModule = IsIn.TXNMode Then
                    condition = dfs & " AND clPrice > '0'"
                ElseIf searchModule = IsIn.InAppMode Then
                    condition = dfs
                End If
            End If

            loadItem(condition)

        Catch ex As Exception
            write_Error("Item search error; parameterized; " & ex.Message, Name)
        End Try

    End Sub

    Private Sub Itemsearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            GoOn = True
            If CurrentItem = SearchIs.Reports Then
                Close()
            ElseIf CurrentItem = SearchIs.Create Then
                selectContent()
            End If
        End If
    End Sub
    Private lb As New ListBox
    Private Sub dg_TXNs_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyCode = Keys.Space Then
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
        End If

    End Sub
    Dim r As Integer = -1
    Private Sub dg_TXNs_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        r = e.RowIndex
    End Sub

    Private Sub dg_List_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellDoubleClick
        GoOn = True
        selectContent()
    End Sub
    Sub selectContent()
        Dim r As Integer = 0
        Try
            r = dg_List.CurrentCell.RowIndex
            If Not dg_List.Rows(r).Cells(1).Value = "" Then

                Code = dg_List.Rows(r).Cells(0).Value

                If _Item = ___Is._Old Then
                    Dim F As New Items
                    If Not F.Visible Then F.Show()
                    Close()

                Else
                    Close()

                End If

            Else
                Close()

            End If

        Catch ex As Exception
            write_Error(ex.Message, Name)
        End Try

    End Sub

End Class