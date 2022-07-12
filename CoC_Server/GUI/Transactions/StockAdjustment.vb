Public Class StockAdjustment

    Sub ResetFn()
        With l_ProgressStat
            .BackColor = Color.Silver
            .ForeColor = Color.Black
            .Text = "waiting for action..."
            pCount = 0
            lb.Items.Clear()
            For Each rw As DataGridViewRow In dg_List.Rows
                rw.Cells(0).Style.BackColor = Color.White
            Next
        End With
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

    Sub loadStockLedger()
        disBandTbl()
        tbl = xRead("SELECT SerialId,clName,clQty FROM clItems ORDER BY clName", "clItems", cItems)
        Try
            dg_List.DataSource = tbl
            dg_List.ReadOnly = True
            dg_List.Columns.Item(0).HeaderText = "ID"
            dg_List.Columns.Item(0).Width = 120
            dg_List.Columns.Item(0).ReadOnly = True
            dg_List.Columns.Item(1).HeaderText = "ITEM NAME"
            dg_List.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg_List.Columns.Item(1).ReadOnly = True
            dg_List.Columns.Item(2).HeaderText = "QTY"
            dg_List.Columns.Item(2).Width = 180
            dg_List.Columns.Item(2).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(2).ReadOnly = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ResetFn()
        loadStockLedger()
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyData = Keys.Escape Then
            disBandTbl()
            Close()
        ElseIf e.KeyData = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        ElseIf e.KeyData = Keys.F5 Then
            ResetFn()
        End If
    End Sub

    Private lb As New ListBox
    Private Sub dg_TXNs_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyCode = Keys.Space Then
            If r = -1 Then Exit Sub
            Dim dR As DataGridViewRow = dg_List.Rows(r)
            With dR

                If Not .Cells(0).Style.BackColor = Color.Silver Then

                    .Cells(0).Style.BackColor = Color.Silver

                    If Not lb.Items.Contains(.Cells(0).Value) Then lb.Items.Add(.Cells(0).Value)

                Else

                    .Cells(0).Style.BackColor = Color.White

                    If lb.Items.Contains(.Cells(0).Value) Then lb.Items.Remove(.Cells(0).Value)

                End If

            End With
        End If

    End Sub
    Private r As Integer = -1
    Private Sub dg_TXNs_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        r = e.RowIndex
    End Sub
    Private pCount As Integer = 0
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ErrMsg As String = Nothing
        Dim IsAll As Boolean = False
        IsAll = chkSelectAll.Checked
        If _This() = LoginIs.Admin Then
            GoTo 3
        ElseIf _This() = LoginIs.SubAdmin Then
            If Cnfg.subAdminModifySecurity = Cnfg.InActv Then
                MsgBox("You do not have the rights to do this. Sorry")
                Mode = LoginMode.AllowAccess
                login.ShowDialog()
                If _Access = _Request.IsGranted And CurrentRequested = UserLogin.IsAdmin Then
                    GoTo 3
                Else
                    ShowMessage("Permission revoked!", _Method.AsError)
                End If
            End If
        End If

        Exit Sub
3:      Dim Sql As String = Nothing
        Dim Appropriation As IsNow = IsNow.ShortOfBeingComplete
        Sql = "UPDATE clItems SET clQty=0"
        Dim condition As String = Nothing

        Dim AcCnfm As MsgBoxResult = MsgBox("Confirm that this request is valid! You cannot reverse this process?", MsgBoxStyle.OkCancel)

        If Not AcCnfm = MsgBoxResult.Ok Then Exit Sub

        Try
            UploadProgressDialog()
            If IsAll Then
                Appropriation = StockAppropriation()
                pCount = pCount + 1
                If Not Appropriation = IsNow._Complete Then
                    GoTo 7
                End If
            Else

                For Each row As DataGridViewRow In dg_List.Rows
                    If row.Cells(0).Style.BackColor = Color.Silver Then
                        Dim PID = 0
                        For i = 0 To lb.Items.Count - 1
                            Dim PID_ = lb.Items.Item(i)
                            Appropriation = StockAppropriation(PID_)
                        Next
                        PID = row.Cells(0).Value
                        Appropriation = StockAppropriation(PID)
                        pCount = pCount + 1

                    End If
                Next
                If pCount = 0 Or Not Appropriation = IsNow._Complete Then
                    GoTo 7
                End If
            End If

            With l_ProgressStat
                .BackColor = Color.Teal
                .ForeColor = Color.White
                .Text = "stock adjustment was successful. [" & pCount & "] items affected..."
            End With
            pCount = 0
            lb.Items.Clear()

            For Each rw As DataGridViewRow In dg_List.Rows
                rw.Cells(0).Style.BackColor = Color.White
            Next

        Catch ex As Exception
            ErrMsg = ex.Message
            GoTo 7
        End Try

        loadStockLedger()

        Exit Sub
7:      pCount = 0
        lb.Items.Clear()
        For Each rw As DataGridViewRow In dg_List.Rows
            rw.Cells(0).Style.BackColor = Color.White
        Next
        With l_ProgressStat
            .BackColor = Color.Red
            .ForeColor = Color.White
            .Text = "stock adjustment failed..." & "[" & LCase(ErrMsg) & "]"
        End With
        ErrMsg = ""

    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        For Each rw As DataGridViewRow In dg_List.Rows
            If chkSelectAll.Checked Then
                rw.Cells(0).Style.BackColor = Color.Silver
            Else
                rw.Cells(0).Style.BackColor = Color.White
            End If
        Next
    End Sub

End Class