Imports System.ComponentModel
Public Class Clients

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        lb.Items.Clear()
        If ThisClient = IsA.Merchant Then
            HEADER.Text = "Merchants"
        ElseIf ThisClient = IsA.Supplier Then
            HEADER.Text = "Suppliers"
        End If
        CustId = ""
        t_ClientId.Clear()
        loadData(True)
        IsOpen = True
    End Sub
    Private count As Integer = 0
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)

        If CurrentItem = SearchIs.Create Then
            Try
                r = dg_Sales.CurrentCell.RowIndex
                If dg_Sales.Rows(r).Cells(0).Value = "" Then Close()

                CustId = dg_Sales.Rows(r).Cells(0).Value
            Catch ex As Exception
                CustId = ""
            End Try

        ElseIf CurrentItem = SearchIs.Reports Then

            count = lb.Items.Count

            If count > 0 Then _Id = Slicelist(lb, count, 1) Else _Id = ""

        End If

        CurrentItem = SearchIs._IsAbsolutelyNothing

        count = 0

        t_ClientId.Clear()

    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F2 Then
            btnAddNew_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Enter Then
            Close()
        End If

    End Sub
    Private IsOpen As Boolean = False
    Sub loadData(Optional ByVal isAll As Boolean = False)
        Dim merchant As String = IIf(ThisClient = IsA.Merchant, "clMerchants", "clSuppliers")

        Dim power = IIf(ThisClient = IsA.Merchant, "clPurchasePower", "clOutstanding")

        Dim condition As String = IIf(isAll, "", " WHERE clName LIKE '%" & t_ClientId.Text & "%'")

        Dim tbl As DataTable = xRead("SELECT SerialId,clName," &
                                                 "clCompany,clPhoneH FROM " &
                                                        merchant &
                                                        condition,
                                     merchant)
        dg_Sales.DataSource = tbl

        If Not IsOpen Then
            dg_Sales.ReadOnly = True
            dg_Sales.AutoResizeColumns()
            dg_Sales.Columns.Item(0).HeaderText = "CUST ID."
            dg_Sales.Columns.Item(1).HeaderText = "CLIENT NAME"
            dg_Sales.Columns.Item(1).Width = 330
            dg_Sales.Columns.Item(2).HeaderText = "COMPANY NAME"
            dg_Sales.Columns.Item(3).HeaderText = "CONTACT"
        End If

        l_RecordCount.Text = String.Concat(dg_Sales.Rows.Count - 1, " Records Found")

    End Sub

    Private Sub t_ClientId_TextChanged(sender As Object, e As EventArgs) Handles t_ClientId.TextChanged
        loadData(False)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        ThisMecrchant = HereIs._New
        If ThisClient = IsA.Merchant Then
            Merchants.ShowDialog()
        ElseIf ThisClient = IsA.Supplier Then
            Supplier.ShowDialog()
        End If
        OnLoad(Nothing)
    End Sub
    Dim r As Integer = -1
    Private Sub dg_Sales_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_Sales.CellEnter
        r = e.RowIndex
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

End Class