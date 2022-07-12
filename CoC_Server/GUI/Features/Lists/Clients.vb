Imports System.ComponentModel
Public Class Clients
    Private GoOn As Boolean = False
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        LoadUp()
    End Sub
    Sub LoadUp()
        GoOn = False
        lb.Items.Clear()
        If ThisClient = IsA.Customer Then
            Text = "Customers"
        ElseIf ThisClient = IsA.Supplier Then
            Text = "Suppliers"
        End If

        Dim merchant As String = IIf(ThisClient = IsA.Customer, "clCustomers", "clSuppliers")
        xQry("DELETE FROM " & merchant & " WHERE clName is NULL or clName=''", c)

        CustId = ""
        t_ClientId.Clear()
        loadData(True)
    End Sub
    Private count As Integer = 0
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)

        If Not GoOn Then Exit Sub

        If CurrentItem = SearchIs.Create Then
            Try
                r = dg_List.CurrentCell.RowIndex
                If dg_List.Rows(r).Cells(0).Value = "" Then Exit Sub

                CustId = dg_List.Rows(r).Cells(0).Value
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
            dg_List_MouseDoubleClick(Nothing, Nothing)
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
        Catch ex As Exception
        End Try
    End Sub
    Sub loadData(Optional ByVal isAll As Boolean = False)

        disBandTbl()

        Dim merchant As String = IIf(ThisClient = IsA.Customer, "clCustomers", "clSuppliers")

        Dim condition As String = IIf(isAll, "", " WHERE clName ILIKE '%" & t_ClientId.Text & "%'")

        tbl = xRead("SELECT SerialId,clName," &
                                                 "clCompany,clPhoneH FROM " &
                                                        merchant &
                                                        condition,
                                     merchant)
        dg_List.DataSource = tbl

        dg_List.ReadOnly = True

        dg_List.Columns.Item(0).HeaderText = "CUST ID."
        dg_List.Columns.Item(0).Width = 100
        dg_List.Columns.Item(1).HeaderText = "CLIENT NAME"
        dg_List.Columns.Item(1).Width = 371
        dg_List.Columns.Item(2).HeaderText = "COMPANY NAME"
        dg_List.Columns.Item(2).Width = 151
        dg_List.Columns.Item(3).HeaderText = "CONTACT"
        dg_List.Columns.Item(3).Width = 151

        l_RecordCount.Text = String.Concat(dg_List.Rows.Count, " Record(s) Found")

    End Sub

    Private Sub t_ClientId_TextChanged(sender As Object, e As EventArgs) Handles t_ClientId.TextChanged
        loadData(False)
    End Sub
    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        ThisMerchant = HereIs._New
        Dim f As New Customers
        If Not f.Visible Then f.ShowDialog()
        LoadUp()
    End Sub
    Dim r As Integer = -1
    Private Sub dg_TXNs_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dg_List.CellEnter
        r = e.RowIndex
    End Sub
    Private lb As New ListBox
    Private Sub dg_TXNs_KeyDown(sender As Object, e As KeyEventArgs) Handles dg_List.KeyDown
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

    Private Sub dg_List_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dg_List.MouseDoubleClick
        GoOn = True
        Close()
    End Sub

End Class