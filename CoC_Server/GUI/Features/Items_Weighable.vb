
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class Items_Weighable
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        clearAll()
        LoadItemDetails()
        LoadUp()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        clearAll()
        l_Barcode.Text = l_Barcode.Tag
        l_ItemName.Text = l_ItemName.Tag
        PId.Text = PId.Tag
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnSave.PerformClick()
        ElseIf e.KeyCode = Keys.F5 Then
            btnReset.PerformClick()
        End If
    End Sub
    Private tbl As DataTable = Nothing
    Sub disBandTbl()
        Try
            tbl.Clear()
            dg_List.DataSource = tbl
            dg_List.DataSource = Nothing
            dg_List.Rows.Clear()
            dg_List.Columns.Clear()
            tbl.Dispose()
        Catch ex As Exception
        End Try
    End Sub
    Sub LoadUp()

        disBandTbl()

        Dim Sql As String = "SELECT clItemId,clName,clEquivQty,clUnit,clUnitQty,clUnitPrice " &
                              "FROM " &
                              "clItemsMeasurements"

        Try
            tbl = xRead(Sql,
              "clItemsMeasurements",
              cItems)
            dg_List.DataSource = tbl

            dg_List.ReadOnly = True
            dg_List.Columns.Item(0).HeaderText = "Code"
            dg_List.Columns.Item(1).HeaderText = "ITEM NAME"
            dg_List.Columns.Item(2).HeaderText = "Qty. Equiv"
            dg_List.Columns.Item(2).DefaultCellStyle.Format = "n1"
            dg_List.Columns.Item(3).HeaderText = "Measuring Unit"
            dg_List.Columns.Item(4).HeaderText = "Unit Qty."
            dg_List.Columns.Item(4).DefaultCellStyle.Format = "n1"
            dg_List.Columns.Item(5).HeaderText = "Unit Price."
            dg_List.Columns.Item(5).DefaultCellStyle.Format = "n2"

            dg_List.AutoResizeColumns()

        Catch ex As Exception
            write_Error("Item load error; " & ex.Message, Name)
        End Try

    End Sub
    Private Price As Decimal = 0
    Sub LoadItemDetails()
        Dim tbl As DataTable = xRead("SELECT clBarcode,clName,clPrice " &
                                                        "FROM clItems " &
                                                        "WHERE SerialId='" & Code & "'",
                                     "clItems",
                              cItems)

        For Each row As DataRow In tbl.Rows
            PId.Text = String.Concat(PId.Tag, Code)
            l_Barcode.Text = String.Concat(l_Barcode.Tag, row(0).ToString)
            l_ItemName.Text = String.Concat(l_ItemName.Tag, row(1).ToString)
            Price = row(2)
            t_Price.Text = Price
        Next

    End Sub
    Sub clearAll() Handles btnReset.Click
        t_MeasuringUnit.Clear()
        t_PriceEquiv.Text = 0
        t_UnitQty.Text = 0
        t_UnitPrice.Text = 0
        chkTaxInclusive.CheckState = CheckState.Unchecked
        LoadUp()
    End Sub

    Function FieldsComplete()
        Return t_MeasuringUnit.Text IsNot NullVal AndAlso
            Not t_Price.Text = 0 AndAlso
            Not t_UnitPrice.Text = 0 AndAlso
            Not t_UnitQty.Text = 0
    End Function
    Function FieldsExist() As String
        Dim f As String
        Try
            f = Qry("SELECT clName " &
                            "FROM clItemsMeasurements " &
                            "WHERE clItemId='" & Code & "'  AND " &
                                        "clUnit='" & t_MeasuringUnit.Text & "'",
                    cItems)
        Catch ex As Exception
            f = ""
        End Try
        FieldsExist = f
    End Function
    Sub complain()
        MessageBox.Show("Please complete all fields to continue", "Cy POS")
    End Sub
    Sub xcomplain()
        MessageBox.Show("Record exists", "Cy POS")
    End Sub
    Sub Save() Handles btnSave.Click
        Dim IsVATInclusive As Integer = IIf(chkTaxInclusive.Checked, 1, 0)
        FixNumericBoxes()
        If Not FieldsComplete() Then complain() : Exit Sub
        If Not FieldsExist() = "" Then xcomplain() : Exit Sub
        Dim ChangeReq As MsgBoxResult = -1
        Dim Prc As Decimal = 0
        If t_Price.Text <> Price Then
            ChangeReq = MsgBox("Proceed to modify Item price?", MsgBoxStyle.YesNo)
        End If
        Prc = IIf(ChangeReq = MsgBoxResult.Yes, Price, Convert.ToDecimal(t_Price.Text))
        Try

            If Not cItems.State = ConnectionState.Open Then cItems.Open()

            Dim cm As New NpgsqlCommand("INSERT INTO clItemsMeasurements (" &
                                                                                                 "clItemId," &
                                                                                                 "clName," &
                                                                                                 "clEquivQty," &
                                                                                                 "clUnit," &
                                                                                                 "clUnitQty," &
                                                                                                 "clUnitPrice," &
                                                                                                 "clUnitVAT," &
                                                                                                 "clModifDate) " &
                                                                                         "VALUES (" &
                                                                                                 "@clItemId," &
                                                                                                 "@clName," &
                                                                                                 "@clEquivQty," &
                                                                                                 "@clUnit," &
                                                                                                 "@clUnitQty," &
                                                                                                 "@clUnitPrice," &
                                                                                                 "@clUnitVAT," &
                                                                                                 "@clModifDate" &
                                                                                                    ")",
                                             cItems)
            Dim tD As Date = New Date()
            With Date.Now
                tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cm
                .Parameters.Add(New NpgsqlParameter("@clItemId", NpgsqlDbType.Varchar)).Value = Code
                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = l_ItemName.Text.Replace(l_ItemName.Tag, "")
                .Parameters.Add(New NpgsqlParameter("@clEquivQty", NpgsqlDbType.Integer)).Value = v(t_PriceEquiv.Text)
                .Parameters.Add(New NpgsqlParameter("@clUnit", NpgsqlDbType.Varchar)).Value = t_MeasuringUnit.Text
                .Parameters.Add(New NpgsqlParameter("@clUnitQty", NpgsqlDbType.Integer)).Value = v(t_UnitQty.Text)
                .Parameters.Add(New NpgsqlParameter("@clUnitPrice", NpgsqlDbType.Bigint)).Value = v(t_UnitPrice.Text)
                .Parameters.Add(New NpgsqlParameter("@clUnitVAT", NpgsqlDbType.Integer)).Value = IsVATInclusive
                .Parameters.Add(New NpgsqlParameter("@clModifDate", NpgsqlDbType.Date)).Value = tD
                If Not cItems.State = ConnectionState.Open Then cItems.Open()
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    xQry("UPDATE clItems SET clPrice='" & Prc & "' WHERE SerialId='" & Code & "'", cItems)
                    MsgBox("Save success!")
                    clearAll()
                    cItems.Close()
                End If
            End With

        Catch ex As Exception
            write_Error(ex.Message, Name)
        End Try

    End Sub

    Private Sub FixNumericBoxes()
        If CDec(t_UnitPrice.Text) <= 0 Then
            t_UnitPrice.Text = 0
        End If
        If CDec(t_UnitQty.Text) <= 0 Then
            t_UnitQty.Text = 0
        End If
        If CDec(t_Price.Text) <= 0 Then
            t_Price.Text = Price
        End If
        If CDec(t_PriceEquiv.Text) <= 0 Then
            t_PriceEquiv.Text = 0
        End If
    End Sub

    Private Sub MoveFous(sender As Object, e As KeyEventArgs) Handles t_Price.KeyDown, t_PriceEquiv.KeyDown,
                                                                                            t_MeasuringUnit.KeyDown, t_UnitQty.KeyDown, t_UnitPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            If t_Price.Focused Then
                t_PriceEquiv.Focus()
            ElseIf t_PriceEquiv.Focused Then
                t_MeasuringUnit.Focus()
            ElseIf t_MeasuringUnit.Focused Then
                CurrentItem = SearchIs.Create
                Dim f As New MeasuringUnits
                If Not f.Visible Then f.ShowDialog()
                If _Id = "" Then Exit Sub
                t_MeasuringUnit.Text = _Id
                t_UnitQty.Focus()
            ElseIf t_UnitQty.Focused Then
                t_UnitPrice.Focus()
            ElseIf t_UnitPrice.Focused Then
                Save()
            End If
        End If
    End Sub

    Private Sub dg_List_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
        If e.KeyData = Keys.Delete Then
            Try
                Dim t As Integer = dg_List.CurrentRow.Index
                Dim ndr As DataGridViewRow = dg_List.Rows(t)
                With ndr
                    If .Cells(0).Value = "" Or .Cells(1).Value = "" Then Exit Sub
                    Dim DRq As MsgBoxResult = MsgBox("Proceed to delete?", MsgBoxStyle.OkCancel)
                    If Not DRq = MsgBoxResult.Ok Then Exit Sub
                    Dim xf As String = xQry("DELETE " &
                                                      "FROM clItemsMeasurements " &
                                                      "WHERE clItemId='" & .Cells(0).Value & "' AND " &
                                                                  "clUnit='" & .Cells(3).Value & "'",
                                cItems)
                    MsgBox(xf, "CyPOS")
                    LoadUp()
                End With
            Catch ex As Exception
                LoadUp()
            Finally
                LoadUp()
            End Try
        End If
    End Sub

    Private Sub dg_List_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dg_List.MouseDoubleClick
    End Sub

End Class