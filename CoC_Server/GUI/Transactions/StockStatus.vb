Imports System.ComponentModel
Imports Npgsql

Public Class StockStatus

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyData = Keys.Escape Then
            Close()
        ElseIf e.KeyData = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        ElseIf e.KeyData = Keys.F5 Then
            btnNew_Click(Nothing, Nothing)
        End If

    End Sub

    Private tbl As DataTable = Nothing
    Sub DisbandTbl()
        Try
            tbl.Clear()
            dg_List.DataSource = tbl
            dg_List.DataSource = Nothing
            dg_List.Columns.Clear()
            dg_List.Rows.Clear()
        Catch ex As Exception
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        LoadUp()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        TodaysCurrent = StockMode.isNoOnesBusiness

    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        LoadUp()

    End Sub
    Private Sub chkOutNegative_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutNegative.CheckedChanged
        btnNew.PerformClick()
        btnBalance.Visible = chkOutNegative.Checked

    End Sub

    Sub LoadUp()

        Try
            dg_List.Rows.Clear()
            dg_List.Columns.Clear()
        Catch ex As Exception
        End Try
        Dim r As String = IIf(CurrentItem = SearchIs.Create, "Set", "")

        DisbandTbl()

        Dim condition As String = ""
        condition = IIf(chkOutNegative.Checked, " WHERE clQty<'1'", "") & " ORDER BY clName"
        Dim s As String = IIf(TodaysCurrent = StockMode.IsOpening, "clStockOpening", "clStockClosing")
        condition = IIf(chkOutNegative.Checked, " WHERE " & s & "<'1'", "") & " ORDER BY clName"

        Dim Table As String = dbName()
        Dim xTable As String = "clItems"
        Dim Sql As String = "SELECT clItemId,clName," & s & " FROM " & Table & condition
        Dim xSql As String = "SELECT SerialId,clName,clQty FROM " & xTable & condition

        'MsgBox(Sql)

        Try
            tbl = xRead(Sql,
                        Table,
                        cTXNs)

            If tbl Is Nothing Or tbl.Rows.Count < 0 Then Close()

            dg_List.DataSource = tbl

            dg_List.Columns.Item(0).HeaderText = "CODE"
            dg_List.Columns.Item(0).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
            dg_List.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_List.Columns.Item(0).Width = 120
            dg_List.Columns.Item(0).ReadOnly = True

            dg_List.Columns.Item(1).HeaderText = "ITEM NAME"
            dg_List.Columns.Item(1).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
            dg_List.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_List.Columns.Item(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            dg_List.Columns.Item(1).ReadOnly = True

            dg_List.Columns.Item(2).HeaderText = IIf(TodaysCurrent = StockMode.IsOpening, "OPENING", "CLOSING") & " QTY"
            dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_List.Columns.Item(2).Width = 150
            dg_List.Columns.Item(2).ReadOnly = False

        Catch ex As Exception
            s = IIf(TodaysCurrent = StockMode.IsOpening, "Opening Stock", "Closing Stock")
            write_Error(ex.Message, s & " Load")
        End Try

    End Sub

    Sub FillUp(IsBalance As Boolean)
        Dim MReq As MsgBoxResult = MsgBox("Proceed?", MsgBoxStyle.YesNo, "CyPOS")
        If Not MReq = MsgBoxResult.Yes Then Exit Sub
        Dim s As String = Nothing

        UploadProgressDialog("Updating...")

        Try
            For Each rw As DataGridViewRow In dg_List.Rows
                If Not rw.Cells(0).Value = "" Then
                    If Not rw.Cells(1).Value = "" Then
                        If Not rw.Cells(1).Value Is DBNull.Value Then
                            Dim PrdId As String = rw.Cells(0).Value
                            If IsBalance Then
                                If rw.Cells(2).Value <= 0 Then
                                    rw.Cells(2).Value = 1
                                End If
                            End If
                            s = IIf(TodaysCurrent = StockMode.IsOpening, "StockOpening", "StockClosing")
                            Dim Sql As String = "UPDATE " & dbName() & " SET cl" & s & "='" & rw.Cells(2).Value & "'" & " WHERE clItemId='" & PrdId & "'"
                            Dim xSql As String = "UPDATE clItems SET " & "clQty='" & rw.Cells(2).Value & "'" & " WHERE SerialId='" & PrdId & "'"
                            xQry(Sql, cTXNs)

                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            s = IIf(TodaysCurrent = StockMode.IsOpening, "Opening Stock", "Closing Stock")
            write_Error(ex.Message & IIf(IsBalance, " - " & s & " Negative Balance", " - Update " & s))
        Finally
            If IsBalance Then
                chkOutNegative.CheckState = CheckState.Unchecked
                LoadUp()
            Else
                'ShowMessage("Done!", _Method.AsInfo)
                LoadUp()
            End If

        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        FillUp(False)

    End Sub
    Private Sub btnBalance_Click(sender As Object, e As EventArgs) Handles btnBalance.Click
        FillUp(True)

    End Sub
    Function dbName() As String
        Dim FilteredString As String = Nothing
        Try
            FilteredString = JournalDate.ToShortDateString.Replace("/", "").Replace("-", "").Replace("=", "").Replace("'", "")
        Catch ex As Exception
        End Try
        Return String.Concat("clStockStatus", FilteredString)
    End Function

End Class