Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class SupplierDetails

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
    Sub uploadData()
        Try
            disBandTbl()

            UploadProgressDialog("Loading data. Please wait...")

            If _Data = _AccessMode.IsUpload Then
                If Not xlpth_Suppliers.Exists Then xlpth_Suppliers.Create()

                c_s.Open()
                Dim tSQL As String = "SELECT * FROM [c_Data$]"
                Dim cmd As New OleDbCommand(tSQL, c_s)
                Dim da As New OleDbDataAdapter
                da.SelectCommand = cmd
                tbl = New DataTable
                da.Fill(tbl)
                c_s.Close()
            ElseIf _Data = _AccessMode.IsDownload Then
                tbl = xRead("SELECT * FROM clSuppliers",
                            "clSuppliers",
                            c)
            End If

            dg_List.DataSource = tbl

            If _Data = _AccessMode.IsDownload Then dg_List.ReadOnly = True

            dg_List.AutoResizeColumns()

            For i = 0 To dg_List.ColumnCount - 1
                dg_List.Columns.Item(i).HeaderText = UCase(dg_List.Columns.Item(i).HeaderText.Replace("cl", ""))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        _Save = _Mode.IsSave
        If _Save = _Mode.IsNothing Then Close()
        uploadData()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        dg_List.Rows.Clear()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            LoadItems()
        ElseIf e.KeyCode = Keys.F5 Then
            uploadData()
        ElseIf e.KeyCode = Keys.F9 Then
            dg_List.Rows.Clear()
        End If

    End Sub
    Public Sub LoadItems()
        Dim sql As String = Nothing
        Try
            If _Save = _Mode.IsSave Then
                Dim mg As MsgBoxResult = MsgBox("This action will clear previous database. Continue?", MsgBoxStyle.YesNo)
                If Not mg = MsgBoxResult.Yes Then Exit Sub
                xQry("DELETE FROM clSuppliers", c)

            End If
            sql = "INSERT INTO clSuppliers (SerialId,clName,clCompany,clOutstanding,clAddress,clPreferredPay," &
                                                                           "clPreferredCurrency,clPurchasePower,clPhoneH,clPhoneW,clFax,clEmail) " &
                                                                           "VALUES " &
                                                                           "(@SerialId,@clName,@clCompany,@clOutstanding,@clAddress,@clPreferredPay,@" &
                                                                           "clPreferredCurrency,@clPurchasePower,@clPhoneH,@clPhoneW,@clFax,@clEmail)"
            'UploadProgressDialog("Please wait...")
            If c.State = ConnectionState.Closed Then c.Open()
            For Each row As DataGridViewRow In dg_List.Rows

                Dim cm As New NpgsqlCommand(sql, c)
                With cm
                    .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Text)).Value = row.Cells(0).Value
                    .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Text)).Value = row.Cells(1).Value
                    .Parameters.Add(New NpgsqlParameter("@clCompany", NpgsqlDbType.Text)).Value = row.Cells(2).Value
                    .Parameters.Add(New NpgsqlParameter("@clAddress", NpgsqlDbType.Text)).Value = row.Cells(3).Value
                    .Parameters.Add(New NpgsqlParameter("@clPreferredPay", NpgsqlDbType.Text)).Value = row.Cells(4).Value
                    .Parameters.Add(New NpgsqlParameter("@clPreferredCurrency", NpgsqlDbType.Text)).Value = row.Cells(5).Value
                    .Parameters.Add(New NpgsqlParameter("@clOutstanding", NpgsqlDbType.Bigint)).Value = v(row.Cells(6).Value)
                    .Parameters.Add(New NpgsqlParameter("@clPurchasePower", NpgsqlDbType.Bigint)).Value = v(row.Cells(7).Value)
                    .Parameters.Add(New NpgsqlParameter("@clPhoneH", NpgsqlDbType.Integer)).Value = v(row.Cells(8).Value)
                    .Parameters.Add(New NpgsqlParameter("@clPhoneW", NpgsqlDbType.Integer)).Value = v(row.Cells(9).Value)
                    .Parameters.Add(New NpgsqlParameter("@clFax", NpgsqlDbType.Integer)).Value = v(row.Cells(10).Value)
                    .Parameters.Add(New NpgsqlParameter("@clEmail", NpgsqlDbType.Varchar)).Value = row.Cells(11).Value

                    If c.State = ConnectionState.Closed Then c.Open()

                    Dim fSnd As Integer = .ExecuteNonQuery()
                    If fSnd > 0 Then
                        c.Close()
                    End If
                    '
                End With
            Next
            MsgBox("Save success!")
            'Close()

        Catch ex As Exception
            If c.State = ConnectionState.Open Then c.Close()
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dg_list_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellLeave
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellValueChanged
        dg_list_CellEnter(Me, e)
    End Sub
    Private Sub dg_list_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        If _Data = _AccessMode.IsDownload Then Exit Sub
        Try

            For Each rw As DataGridViewRow In dg_List.Rows
                With rw
                    If .Cells(0).Value Is DBNull.Value Then .Cells(0).Value = ++1000
                    If .Cells(1).Value Is DBNull.Value Then .Cells(1).Value = ++1000
                End With
            Next

        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then

            If _Data = _AccessMode.IsDownload Then Exit Sub

            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnBeginUpload_Click(sender As Object, e As EventArgs) Handles btnBeginUpload.Click
        LoadItems()
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        uploadData()
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        disBandTbl()
    End Sub

End Class