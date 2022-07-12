Public Class WeightMeasurement
    Private CanProceed As Boolean = False
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            CanProceed = True
            btnSave_Click(Nothing, Nothing)
        End If
    End Sub
    Sub LoadDetails()

        Dim Sql As String = "SELECT clUnitQty,clUnitPrice " &
                                        "FROM " &
                                            "clItemsMeasurements " &
                                         "WHERE clItemId='" & Code &
                                         "'  AND " &
                                                     "clUnit='" & _Id & "'"
        'MsgBox(Sql)
        Try
            Dim tbl As DataTable = xRead(Sql, "clItemsMeasurements", cItems)
            For Each row In tbl.Rows
                WeighedQuantity = row(0)
                WeighedPrice = row(1)
            Next
        Catch ex As Exception
            'ClearAll()
            write_Error(ex.Message, Name)
        End Try
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        CanProceed = False
        ClearAll()
    End Sub
    Sub ClearAll()
        t_MeasuringUnit.Clear()
        l_UnitPrice.Text = l_UnitPrice.Tag
        l_UnitsMeasurement.Text = l_UnitsMeasurement.Tag
        t_UnitRequired.Text = 0
        l_Total.Text = l_Total.Tag
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not CanProceed Then
            ClearAll()
        Else
            WeighedQuantity = CDec(t_UnitRequired.Text)
        End If
        Close()
    End Sub

    Private Sub t_MeasuringUnit_KeyDown(sender As Object, e As KeyEventArgs) Handles t_MeasuringUnit.KeyDown, t_UnitRequired.KeyDown
        If e.KeyCode = Keys.Enter Then
            If t_MeasuringUnit.Focused Then
                CurrentItem = SearchIs.Create
                Dim f As New MeasuringUnits
                If Not f.Visible Then f.ShowDialog()
                LoadDetails()
                If _Id = "" Then CanProceed = False : Exit Sub
                If WeighedPrice = 0 Then Exit Sub
                t_MeasuringUnit.Text = _Id
                l_UnitsMeasurement.Text = WeighedQuantity & " Units / Measurement"
                l_UnitPrice.Text = WeighedPrice & " / " & WeighedQuantity & " Unit(s)"
                t_UnitRequired.Focus()
            ElseIf t_UnitRequired.Focused Then
                CanProceed = True
                btnSave_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub t_UnitRequired_TextChanged(sender As Object, e As EventArgs) Handles t_UnitRequired.TextChanged
        Try
            Dim Ttl As Decimal = 0.0
            Dim Qty As Decimal = CDec(WeighedQuantity)
            Dim Price As Decimal = CDec(WeighedPrice)
            Dim ReqQty As Decimal = CDec(t_UnitRequired.Text)
            Ttl = Math.Round((Price * ReqQty) / Qty)
            l_Total.Text = FormatNumber(Ttl, 2)
            If t_UnitRequired.Text <= 0 Then
                t_UnitRequired.Text = 0
            End If
        Catch ex As Exception
            t_UnitRequired.Text = 0
        End Try
    End Sub

End Class