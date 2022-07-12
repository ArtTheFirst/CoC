Imports System.ComponentModel

Public Class productSearch

    Private tbl As DataTable

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadProduct("")
        IsOpen = True
        lb.Items.Clear()
    End Sub

    Private IsOpen As Boolean = False
    Sub loadProduct(s As String)

        Dim DGVS As DataGridViewCellStyle = Nothing
        Try
            tbl = xRead("SELECT SerialId,clName,clPrice FROM clProducts" & s, "clProducts", c_Products)
            dg_Sales.DataSource = tbl
            If Not IsOpen Then
                dg_Sales.ReadOnly = True
                dg_Sales.AutoResizeColumns()
                dg_Sales.Columns.Item(0).HeaderText = "CODE"
                dg_Sales.Columns.Item(1).HeaderText = "PRODUCT NAME"
                dg_Sales.Columns.Item(1).Width = 480
                dg_Sales.Columns.Item(2).HeaderText = "PRICE"
                dg_Sales.Columns.Item(2).DefaultCellStyle.Format = "n2"
                dg_Sales.Columns.Item(2).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
                dg_Sales.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
                dg_Sales.Columns.Item(2).Width = 180
            End If
            l_TotalRecords.Text = String.Concat(dg_Sales.Rows.Count, " records found")

            s = Nothing

        Catch ex As Exception

        End Try

    End Sub
    Private arr()
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        If CurrentItem = SearchIs.Create Then
            Try
                If Code.Length < 1 Then
                    AddAs = DetailFrom.AbsolutelyNothing__Pity
                Else
                    AddAs = DetailFrom.ProductCode
                End If
            Catch ex As Exception
                AddAs = DetailFrom.AbsolutelyNothing__Pity
            End Try
        ElseIf CurrentItem = SearchIs.Reports Then

            count = lb.Items.Count

            If count > 0 Then _Id = Slicelist(lb, count, 1) Else _Id = ""

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
        Dim pId As String = Nothing
        Dim p = Nothing

        Dim pName As String = Nothing
        Try
            pName = Qry("SELECT clName FROM clBarcodes WHERE clBarcode='" & t_Code.Text & "'", c_Products)
        Catch ex As Exception
            pName = ""
        End Try

        Try
            condition = " WHERE clBarcode LIKE '%" & t_Code.Text & "%' OR SerialId LIKE '%" & t_Code.Text &
                                    "%' OR clName LIKE '%" & t_Code.Text & "%' OR clName='" & pName  & "'"
            loadProduct(condition)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub productSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If CurrentItem = SearchIs.Reports Then
                Close()
            ElseIf CurrentItem = SearchIs.Create Then
                Dim r As Integer = 0
                Try
                    r = dg_Sales.CurrentCell.RowIndex
                    If dg_Sales.Rows(r).Cells(1).Value = "" Then Close() Else GoTo 3
                Catch ex As Exception
                    write_Error(ex.Message)
                End Try
                Exit Sub
3:              Code = dg_Sales.Rows(r).Cells(0).Value
                If _Product = ___Is._Old Then
                    Products.Show()
                End If
                Close()
            End If

        End If

    End Sub
    Private lb As New ListBox
    Private Sub dg_Sales_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_Sales.KeyDown
        If e.KeyCode = Keys.Space Then
            If Not CurrentItem = SearchIs.Reports Then Exit Sub
            If r = -1 Then Exit Sub
            Dim newDataRow As DataGridViewRow = dg_Sales.Rows(r)
            With newDataRow

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
    Private Sub dg_Sales_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Sales.CellEnter
        r = e.RowIndex
    End Sub

End Class