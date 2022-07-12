Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class SupplierDetails

    Sub uploadData() Handles btnRefresh.Click
        Try
            If Not xlpth_Suppliers.Exists Then xlpth_Suppliers.Create()

            c_s.Open()
            Dim tSQL As String = "SELECT * FROM [c_Data$]"

            Dim cmd As New OleDbCommand(tSQL, c_s)

            Dim da As New OleDbDataAdapter

            da.SelectCommand = cmd

            Dim excelData As New DataTable

            da.Fill(excelData)
            c_s.Close()
            dg_List.Rows.Clear()
            For Each row In excelData.Rows
                If Not row(1).ToString = "" Then dg_List.Rows.Add(row(0),
                                             row(1),
                                             row(2),
                                             row(3),
                                             row(4),
                                             row(5),
                                             row(6),
                                             row(7),
                                             row(8),
                                             row(9),
                                             row(10),
                                             row(11))

                Dim newDataRow As DataGridViewRow
                Dim counter As Integer = dg_List.CurrentRow.Index + 1
                If counter = dg_List.RowCount Then
                    newDataRow = dg_List.Rows(0)
                Else
                    newDataRow = dg_List.Rows(counter)
                End If
                dg_List.CurrentCell = newDataRow.Cells(0)

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
            LoadProducts()
        ElseIf e.KeyCode = Keys.F5 Then
            uploadData()
        ElseIf e.KeyCode = Keys.F9 Then
            dg_List.Rows.Clear()
        End If

    End Sub
    Function vl(value) As Integer
        Dim r = 0
        If value Is DBNull.Value Then
            r = 0
        Else
            r = value
        End If
        Return r
    End Function
    Public Sub LoadProducts() Handles btnBeginUpload.Click
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

                Dim cm As New SqlCommand(sql, c)
                With cm
                    .Parameters.Add(New SqlParameter("@SerialId", SqlDbType.Text)).Value = row.Cells(0).Value
                    .Parameters.Add(New SqlParameter("@clName", SqlDbType.Text)).Value = row.Cells(1).Value
                    .Parameters.Add(New SqlParameter("@clCompany", SqlDbType.Text)).Value = row.Cells(2).Value
                    .Parameters.Add(New SqlParameter("@clAddress", SqlDbType.Text)).Value = row.Cells(3).Value
                    .Parameters.Add(New SqlParameter("@clPreferredPay", SqlDbType.Text)).Value = row.Cells(4).Value
                    .Parameters.Add(New SqlParameter("@clPreferredCurrency", SqlDbType.Text)).Value = row.Cells(5).Value
                    .Parameters.Add(New SqlParameter("@clOutstanding", SqlDbType.BigInt)).Value = vl(row.Cells(6).Value)
                    .Parameters.Add(New SqlParameter("@clPurchasePower", SqlDbType.BigInt)).Value = vl(row.Cells(7).Value)
                    .Parameters.Add(New SqlParameter("@clPhoneH", SqlDbType.Int)).Value = vl(row.Cells(8).Value)
                    .Parameters.Add(New SqlParameter("@clPhoneW", SqlDbType.Int)).Value = vl(row.Cells(9).Value)
                    .Parameters.Add(New SqlParameter("@clFax", SqlDbType.Int)).Value = vl(row.Cells(10).Value)
                    .Parameters.Add(New SqlParameter("@clEmail", SqlDbType.VarChar)).Value = row.Cells(11).Value

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
        Try
            Dim newDataRow As DataGridViewRow = dg_List.Rows(e.RowIndex)
            With newDataRow
                .Cells(0).Value = e.RowIndex + 1001
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                dg_List.Rows.RemoveAt(counter)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub uploadData(sender As Object, e As EventArgs) Handles btnRefresh.Click
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dg_List.Rows.Clear()
    End Sub

End Class