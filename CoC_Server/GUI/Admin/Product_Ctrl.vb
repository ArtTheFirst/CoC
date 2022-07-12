Imports System.ComponentModel

Public Class Product_Ctrl

    Sub LoadDetails()

        'SerialId,clName,clBarcode,clPrice,clQty,clCurrency,clDiscount,clMerchantId,clCategoryId,clPurchaseId,clSalesId

        lv_Products.Columns.Clear()

        Dim lvColumnHeader As ColumnHeader
        Dim iLength As Integer = lv_Products.Width / 11
        lvColumnHeader = lv_Products.Columns.Add("SerialId")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Product Name")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Barcode")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Price")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Available Qty")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Main Currency")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Applied Discount")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Merchant")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Product Category")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Purchase Category")
        lvColumnHeader.Width = iLength
        lvColumnHeader = lv_Products.Columns.Add("Sales Category")
        lvColumnHeader.Width = iLength

    End Sub

    Sub loadCombos()
        Dim tbl As DataTable = xRead("SELECT clName FROM clCategories WHERE clCategory='Product'", "clCategories")
        c_Category.Items.Clear()
        For Each row In tbl.Rows
            c_Category.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Sales'", "clCategories")
        c_CategorySales.Items.Clear()
        For Each row In tbl.Rows
            c_CategorySales.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clDistributors", "clDistributors")
        c_Distributors.Items.Clear()
        For Each row In tbl.Rows
            c_Distributors.Items.Add(row(0).ToString)
        Next

    End Sub
    Public Sub calcStockQtys()
        Dim f = calcVal("clQty", "clProducts", c_Products, " WHERE clQty<=0")
        l_outOfStock.Text = String.Concat("[", f, "] products out of stock!")
    End Sub
    Public Sub calcStockQty()
        Dim f = calcVal("clQty", "clProducts", c_Products, " WHERE clQty<=" & My.Settings.prodAlertQty)
        Dim gOOS As String = String.Concat("[", f, "] products going out of stock!")
        l_goingOutOfStock.Text = gOOS
        If Not f > 0 Then Exit Sub
        MsgBox(gOOS, MsgBoxStyle.Information)

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadCombos()
        lv_Products.Items.Clear()
        pnl_Filter.Height = cSz
        calcStockQty()
        calcStockQtys()

    End Sub
    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)
        LoadDetails()
        loadData()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        clearAll()
    End Sub
    Sub clearAll() Handles btnClearAll.Click
        lv_Products.Items.Clear()
        l_Total.Text = String.Concat("total products; ", lv_Products.Items.Count)
        loadCombos()
        l_outOfStock.Text = "[] products out of stock!"
        l_TotalSales.Text = "Total Value On All Products; Sales; Cost"
        l_SearchFilter.Text = "Applied Search Filter"
        l_Total.Text = "total products []"
        l_TotalDst.Text = "total products"
        l_TotalPCat.Text = "total products"
        l_TotalSales.Text = "total products"

    End Sub

    Enum loadFilter
        ProductsOnly
        SalesOnly
        DistributorsOnly
        MixedProductsSales
        MIxedProductsDistributors
        MixedSalesDistributors
        MixedAll
        Null
    End Enum
    Private Choose As loadFilter = loadFilter.Null
    Function Alter() As loadFilter
        Dim r As loadFilter = loadFilter.Null
        If Not c_Category.Text = NullVal AndAlso c_CategorySales.Text = NullVal AndAlso c_Distributors.Text = NullVal Then
            r = loadFilter.ProductsOnly
        ElseIf c_Category.Text = NullVal AndAlso Not c_CategorySales.Text = NullVal AndAlso c_Distributors.Text = NullVal Then
            r = loadFilter.SalesOnly
        ElseIf c_Category.Text = NullVal AndAlso c_CategorySales.Text = NullVal AndAlso Not c_Distributors.Text = NullVal Then
            r = loadFilter.DistributorsOnly
        ElseIf Not c_Category.Text = NullVal AndAlso Not c_CategorySales.Text = NullVal AndAlso c_Distributors.Text = NullVal Then
            r = loadFilter.MixedProductsSales
        ElseIf Not c_Category.Text = NullVal AndAlso c_CategorySales.Text = NullVal AndAlso Not c_Distributors.Text = NullVal Then
            r = loadFilter.MIxedProductsDistributors
        ElseIf c_Category.Text = NullVal AndAlso Not c_CategorySales.Text = NullVal AndAlso Not c_Distributors.Text = NullVal Then
            r = loadFilter.MixedSalesDistributors
        ElseIf Not c_Category.Text = NullVal AndAlso Not c_CategorySales.Text = NullVal AndAlso Not c_Distributors.Text = NullVal Then
            r = loadFilter.MixedAll
        End If
        Alter = r
    End Function
    Dim s As String = Nothing
    Public Sub loadData()
        'clMerchantId,clCategoryId,clSalesId
        Dim Xploit As loadFilter = Alter()
        Dim filter As String = Nothing
        Select Case Xploit
            Case loadFilter.ProductsOnly
                s = " WHERE clCategoryId='" & c_Category.Text & "'"
                filter = "Single Mode; Product Category"
                Choose = loadFilter.ProductsOnly
            Case loadFilter.SalesOnly
                s = " WHERE clSalesId='" & c_CategorySales.Text & "'"
                filter = "Single Mode; Sales Category"
                Choose = loadFilter.SalesOnly
            Case loadFilter.DistributorsOnly
                s = " WHERE clMerchantId='" & c_Distributors.Text & "'"
                filter = "Single Mode; Supplier"
                Choose = loadFilter.DistributorsOnly
            Case loadFilter.MixedProductsSales
                s = " WHERE clCategoryId='" & c_Category.Text & "' AND clSalesId='" & c_CategorySales.Text & "'"
                filter = "Dual Mode; Product / Sales"
                Choose = loadFilter.MixedProductsSales
            Case loadFilter.MIxedProductsDistributors
                s = " WHERE clCategoryId='" & c_Category.Text & "' AND clMerchantId='" & c_Distributors.Text & "'"
                filter = "Dual Mode; Product / Supplier"
        End Select
        lv_Products.Items.Clear()

        Dim t1 As DataTable = xRead("SELECT * FROM clProducts" & s, "clProducts", c_Products)

        If t1.Rows.Count > 75 Then UploadProgressDialog()

        Dim row As DataRow
        clearAll()
        For Each row In t1.Rows
            Dim lst As ListViewItem
            lst = lv_Products.Items.Add(row(1).ToString)
            For i As Integer = 2 To t1.Columns.Count - 1
                lst.SubItems.Add(row(i).ToString)
            Next
        Next

        l_SearchFilter.Text = String.Concat("Applied Search Filter; ", filter)

        Dim cost, sales, alltotal
        cost = calcVal("clUnitCost", "clProducts", c_Products, s)
        sales = calcVal("clPrice", "clProducts", c_Products, s)
        alltotal = CInt(cost) + CInt(sales)
        l_TotalSales.Text = String.Concat("Total Value On All Products; ", FormatNumber(alltotal, 0),
                    ";  Cost; ", FormatNumber(cost, 0),
                                          "; Sales", FormatNumber(sales, 0))
        l_Total.Text = String.Concat("total products; ", lv_Products.Items.Count)

    End Sub

    Private Sub lv_Products_DoubleClick(sender As Object, e As EventArgs) Handles lv_Products.DoubleClick
        _Id = lv_Products.FocusedItem.Text
        If _Id = Nothing OrElse _Id = NullVal Then Exit Sub
        Products.ShowDialog(Me)
    End Sub

    Private Sub c_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Category.SelectedIndexChanged
        loadData()
        Dim a = calcVal("clCategoryId", "clProducts", c_Products)
        l_TotalPCat.Text = String.Concat("total products; ", FormatNumber(a, 0))
    End Sub
    Private Sub c_CategorySales_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_CategorySales.SelectedIndexChanged
        loadData()
        Dim a = calcVal("clSalesId", "clProducts", c_Products)
        l_TotalSales.Text = String.Concat("total products; ", FormatNumber(a, 0))
    End Sub
    Private Sub c_Distributors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Distributors.SelectedIndexChanged
        loadData()
        Dim a = calcVal("clMerchantId", "clProducts", c_Products)
        l_TotalDst.Text = String.Concat("total products; ", FormatNumber(a, 0))
    End Sub

    Private Sub btnLoadAll_Click(sender As Object, e As EventArgs) Handles btnLoadAll.Click
        loadData()

    End Sub

    Private cSz As Integer = 54
    Private xSz As Integer = 330
    Sub applyFilterExtension() Handles btnXFltr.Click
        pnl_Filter.Height = IIf(pnl_Filter.Height = cSz, xSz, cSz)
        Dim fPointer As String = Nothing
        fPointer = IIf(pnl_Filter.Height = cSz, ">>", "<<")
        btnXFltr.Text = "Extend Filter" & fPointer
    End Sub
    Private Sub btnXFltr_Click(sender As Object, e As EventArgs) Handles btnXFltr.Click
    End Sub

    Private Sub l_outOfStock_Click(sender As Object, e As EventArgs) Handles l_outOfStock.Click
        ModifyStockStatus.CallLoadForm(ModifyStockStatus.Active.IsOutOfStock, False, Me)
    End Sub
    Private Sub l_goingOutOfStock_Click(sender As Object, e As EventArgs) Handles l_goingOutOfStock.Click
        ModifyStockStatus.CallLoadForm(ModifyStockStatus.Active.IsGoingOutOfStock, False, Me)
    End Sub

End Class