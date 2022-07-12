Imports System.ComponentModel

Public Class Users

    Private lb As New ListBox
    Private CanProceed As Boolean = False
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        CanProceed = False
        Id = ""
        _Id = ""
        loadData("")
        IsOpen = True
        lb.Items.Clear()
    End Sub

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

    Private IsOpen As Boolean = False
    Private dgCl As New DataGridViewTextBoxColumn()
    Sub loadData(Optional ByVal s As String = "")
        Dim condition As String = Nothing

        If CurrentItem = SearchIs.Create Then

            If _This() = LoginIs.Admin Then
                If s = "" Then
                    condition = ""
                Else
                    condition = " WHERE clName ILIKE '%" & s & "%'"
                End If
            Else
                condition = " WHERE clName='" & usr & "'"
            End If

        Else

            condition = " WHERE clName ILIKE '%" & s & "%'"

            'condition = ""

        End If

        Dim DGVS As DataGridViewCellStyle = Nothing
        Try
            disBandTbl()
            tbl = xRead("SELECT SerialId,clName,clLastLogin," &
                                                                "clLogDate FROM clLogs" & condition & " ORDER BY clName", "clLogs")
            dg_List.DataSource = tbl
            If Not IsOpen Then
                dg_List.Columns.Item(0).HeaderText = "ID"
                dg_List.Columns.Item(0).ReadOnly = True
                dg_List.Columns.Item(1).HeaderText = "ACCOUNT"

                'If LoadAs = _Item.View Then dg_List.Columns.Item(1).ReadOnly = True

                dg_List.Columns.Item(1).ReadOnly = True

                dg_List.Columns.Item(2).HeaderText = "LAST LOGIN"
                dg_List.Columns.Item(2).DefaultCellStyle.Format = "g"
                dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Segoe UI Light", 12, FontStyle.Regular)
                dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft

                dg_List.Columns.Item(2).ReadOnly = True

                dg_List.Columns.Item(3).HeaderText = "LOGIN DATE"
                dg_List.Columns.Item(3).DefaultCellStyle.Format = "d"
                dg_List.Columns.Item(3).DefaultCellStyle.Font = New Font("Segoe UI Light", 12, FontStyle.Regular)
                dg_List.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft

                dg_List.Columns.Item(3).ReadOnly = True

            End If

            dg_List.Columns.Item(0).Width = 71

            dg_List.Columns.Item(1).Width = dg_List.Width / 4

            dg_List.Columns.Item(3).Width = dg_List.Width / 4

            l_RecordCount.Text = String.Concat(dg_List.Rows.Count, " records found")

            s = Nothing

        Catch ex As Exception

        End Try

    End Sub
    Private arr()

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)

        'ThisUser = HereIs._Old

        'CurrentItem = SearchIs._IsAbsolutelyNothing

        count = 0

        t_User.Clear()

        disBandTbl()

    End Sub

    Dim count As Integer = 0

    Private Sub dg_list_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
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
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        r = e.RowIndex
    End Sub

    Sub Go()
        If CurrentItem = SearchIs.Reports Then
            count = lb.Items.Count
            If count > 0 Then _Id = Slicelist(lb, count, 1) Else _Id = ""
        ElseIf CurrentItem = SearchIs.Create Then
            _Id = dg_List.Rows(r).Cells(1).Value
            Id = dg_List.Rows(r).Cells(0).Value
        End If

        If Not CanProceed Then
            Id = ""
            _Id = ""
        End If

        Close()

    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Escape Then
            Go()
        ElseIf e.KeyCode = Keys.Enter Then
            If CurrentItem = SearchIs.Reports Then
                CanProceed = True
                Go()
            ElseIf CurrentItem = SearchIs.Create Then
                selectContent()
            End If

        End If

    End Sub
    Sub selectContent()
        Dim r As Integer = 0
        Try
            r = dg_List.CurrentCell.RowIndex
            If dg_List.Rows(r).Cells(1).Value = "" Then
                CanProceed = False
            Else
                CanProceed = True
            End If
        Catch ex As Exception
            write_Error(ex.Message, Name)
        Finally
            If Not UCase(dg_List.Rows(r).Cells(1).Value) = "ADMIN" Then Go()
        End Try
    End Sub
    Private Sub dg_List_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellDoubleClick
        selectContent()
    End Sub

    Private Sub t_Code_TextChanged(sender As Object, e As EventArgs) Handles t_User.TextChanged
        If _This() = LoginIs.Admin Or CurrentItem = SearchIs.Reports Then loadData(CType(sender, TextBox).Text)
    End Sub

End Class