Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class ConformBarcode
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        clearAll(Nothing, Nothing)
        autosText(t_Name, "clName", "clItems", cItems)
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        clearAll()
        Code = ""
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.F5 Then
            clearAll()
        ElseIf e.KeyCode = Keys.F7 Then
            btnCheckAll_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Sub clearAll()
        dg_List.Rows.Clear()
        t_Barcode.Clear()
        t_Name.Clear()
        t_Name.Enabled = True
    End Sub
    Sub loadItem(Optional ByVal showUp As Boolean = False)

        If showUp Then
            _Item = ___Is._SadlyNothing
            CurrentItem = SearchIs.Create
            searchModule = IsIn.TXNMode
            Dim h As New ItemSearch : If Not h.Visible Then h.ShowDialog()
            If Trim(Code) = "" Then Exit Sub
        End If

        Try
            Dim tbl As DataTable = xRead("SELECT clBarcode,clName FROM clItmPrx WHERE SerialId='" & Code & "'", "clItmPrx", cItems)
            dg_List.Rows.Clear()
            For Each row In tbl.Rows
                t_Name.Text = row(1).ToString
                dg_List.Rows.Add(row(0).ToString)
                l_ItemCode.Text = l_ItemCode.Tag & Code
                l_SelectedItem.Text = l_SelectedItem.Tag & t_Name.Text
            Next
            t_Barcode.Clear()
            t_Barcode.Focus()
        Catch ex As Exception
            write_Error(ex.Message & "; Item load error", Name)
        End Try

    End Sub
    Function askFields() As Boolean
        Return Not t_Name.Text Is NullVal AndAlso Not t_Barcode.Text Is NullVal
    End Function
    Sub AddNew()
        Try
            If Not cItems.State = ConnectionState.Open Then cItems.Open()

            Dim cm As New NpgsqlCommand("INSERT INTO clItmPrx (SerialId,clName,clBarcode) VALUES (@SerialId,@clName,@clBarcode)",
                                             cItems)
            Dim prevVal = Nothing
            Dim xst As Integer = -1
            For Each row As DataGridViewRow In dg_List.Rows
                Try
                    prevVal = Qry("SELECT SerialId FROM clItmPrx WHERE clBarcode='" & t_Barcode.Text & "'", cItems)
                Catch ex As Exception
                    prevVal = ""
                End Try
                If Not prevVal = "" Then xst = xst + 1
            Next
            If xst >= 0 Then MsgBox("Already Exists!") : Exit Sub
            With cm
                .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = Code
                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = t_Name.Text
                .Parameters.Add(New NpgsqlParameter("@clBarcode", NpgsqlDbType.Varchar)).Value = t_Barcode.Text

                If Not cItems.State = ConnectionState.Open Then cItems.Open()
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    cItems.Close()
                    loadItem()
                    't_Barcode.Clear()
                End If
            End With

            MsgBox("Save success!")
        Catch ex As SqlException
            'MsgBox(ex.Message)
            write_Error(ex.Message, Name)
        End Try

    End Sub

    Sub deleteRow()
        Try
            Dim counter As Integer = dg_List.CurrentRow.Index
            dg_List.Rows.RemoveAt(counter)
            If dg_List.Rows.Count <= 0 Then
                clearAll()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            If dg_List.Rows.Count < 0 Then Exit Sub
            Try
                Dim counter As Integer = dg_List.CurrentRow.Index
                Dim ndr As DataGridViewRow = dg_List.Rows(counter)
                Dim SId As String = ndr.Cells(0).Value
                Dim mgReq As MsgBoxResult = MsgBox("Continue?", MsgBoxStyle.OkCancel)
                If Not mgReq = MsgBoxResult.Ok Then Exit Sub
                xQry("DELETE FROM clItmPrx WHERE clBarcode='" & SId & "'", cItems)
                loadItem()
            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub t_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Name.KeyDown
        If e.KeyCode = Keys.Enter Then
            loadItem(True)
        End If

    End Sub
    Private Sub IntKeyTrap(sender As Object, e As KeyPressEventArgs) Handles t_Barcode.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select

    End Sub
    Private Sub t_Barcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_Barcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(t_Name.Text) Is NullVal Then Exit Sub
            If Trim(t_Barcode.Text) Is NullVal Then Exit Sub
            If dg_List.Rows.Count < 0 Then Exit Sub
            Dim mg As MsgBoxResult = MsgBox("Save?", MsgBoxStyle.YesNo)
            If Not mg = MsgBoxResult.Yes Then Exit Sub
            AddNew()
        End If

    End Sub

    Private Sub clearAll(sender As Object, e As EventArgs) Handles btnClearAll.Click
        t_Barcode.Clear()
        t_Name.Clear()
        l_ItemCode.Text = l_ItemCode.Tag
        l_SelectedItem.Text = l_SelectedItem.Tag
    End Sub

    Private Sub btnCheckAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        BarcodeSearch.ShowDialog()
    End Sub

End Class