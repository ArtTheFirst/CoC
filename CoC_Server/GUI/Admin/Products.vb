Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Products
    Private SaveOff As Boolean = False
    Private OnEdit As Boolean = False
    Private dId As String = Nothing

    Private tbl As DataTable
    Sub loadCombos()

        tbl = xRead("SELECT clName FROM clMerchants", "clMerchants")
        c_Merchant.Items.Clear()
        For Each row In tbl.Rows
            c_Merchant.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCurrency", "clCurrency")
        c_Currency.Items.Clear()
        For Each row In tbl.Rows
            c_Currency.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Product'", "clCategories")
        c_Category.Items.Clear()
        For Each row In tbl.Rows
            c_Category.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Purchase'", "clCategories")
        c_P_Category.Items.Clear()
        For Each row In tbl.Rows
            c_P_Category.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Sales'", "clCategories")
        c_S_Category.Items.Clear()
        For Each row In tbl.Rows
            c_S_Category.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clAccounts", "clAccounts")
        c_Units.Items.Clear()
        For Each row In tbl.Rows
            c_Units.Items.Add(row(0).ToString)
        Next

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadCombos()
        SaveOff = False
        OnEdit = False
        clearFields()
        initiateFields()

        t_AlertQty.Text = My.Settings.prodAlertQty

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        If IdXst() Then
            If Product_Ctrl.Visible Then
                Product_Ctrl.loadData()
            Else
                If Not SaveOff AndAlso OnEdit Then xQry("DELETE FROM clProducts WHERE SerialId='" & dId & "'", c_Products)
                DisposeId()
            End If
        End If

    End Sub
    Sub clearFields()
        t_Product.Text = NullVal
        t_Barcode.Text = NullVal
        t_Price.Text = NullVal
        t_Qty.Text = NullVal
        c_Currency.Text = NullVal
        t_Discount.Text = NullVal
        c_Merchant.Text = NullVal
        c_Category.Text = NullVal
        c_P_Category.Text = NullVal
        c_S_Category.Text = NullVal
    End Sub
    Sub initiateFields()

        initializeId()
        Try
            tbl = xRead("SELECT * FROM clProducts WHERE SerialId='" & dId & "'", "clProducts", c_Products)
            For Each row In tbl.Rows
                t_Product.Text = row(2).ToString
                t_Barcode.Text = row(3).ToString
                t_Price.Text = row(4).ToString
                t_Qty.Text = row(5).ToString
                c_Currency.Text = row(6).ToString
                t_Discount.Text = row(7).ToString
                c_Merchant.Text = row(8).ToString
                c_Category.Text = row(9).ToString
                c_P_Category.Text = row(10).ToString
                c_S_Category.Text = row(11).ToString
            Next

        Catch ex As Exception

        End Try

    End Sub

    Function IdXst() As Boolean
        Return xXst("SerialId", "clProducts", _Id, c_Products) = xData.Exists
    End Function
    Sub initializeId()
        If Not IdXst() Then
            dId = String.Concat("PRD", Date.Now.Year, HexLongSerialId)
            xQry("INSERT INTO clProducts (SerialId) VALUES ('" & dId & "')", c_Products)
        Else
            dId = _Id
        End If
        OnEdit = True

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If t_Product.Text.Length < 3 Then GoTo 3
        If CInt(t_AlertQty.Text) <= 0 Then GoTo 3
        If CInt(t_Price.Text) <= 0 Then GoTo 3
        If CInt(t_Qty.Text) <= 0 Then GoTo 3
        c_Products.Open()
        Dim cm As New SqlCommand("UPDATE clProducts SET clName=@clName,clBarcode=@clBarcode,clPrice=@clPrice," &
                                                                                                           "clQty=@clQty,clCurrency=@clCurrency,clDiscount=@clDiscount,clMerchantId=@clMerchantId," &
                                                                                                           "clCategoryId=@clCategoryId,clPurchaseId=@clPurchaseId,clSalesId=@clSalesId," &
                                                                                                           "clUnit=@clUnit,clUnitCost=@clUnitCost WHERE SerialId='" & dId & "'",
                                         c_Products)
        With cm

            .Parameters.Add(New SqlParameter("@clName", SqlDbType.Text)).Value = t_Product.Text
            .Parameters.Add(New SqlParameter("@clBarcode", SqlDbType.Text)).Value = t_Barcode.Text
            .Parameters.Add(New SqlParameter("@clPrice", SqlDbType.NVarChar)).Value = CInt(t_Price.Text)
            .Parameters.Add(New SqlParameter("@clQty", SqlDbType.NVarChar)).Value = CInt(t_Qty.Text)
            .Parameters.Add(New SqlParameter("@clCurrency", SqlDbType.Text)).Value = c_Currency.Text
            .Parameters.Add(New SqlParameter("@clDiscount", SqlDbType.NVarChar)).Value = CInt(t_Discount.Text)
            .Parameters.Add(New SqlParameter("@clMerchantId", SqlDbType.Text)).Value = c_Merchant.Text
            .Parameters.Add(New SqlParameter("@clCategoryId", SqlDbType.Text)).Value = c_Category.Text
            .Parameters.Add(New SqlParameter("@clPurchaseId", SqlDbType.Text)).Value = c_P_Category.Text
            .Parameters.Add(New SqlParameter("@clSalesId", SqlDbType.Text)).Value = c_S_Category.Text
            .Parameters.Add(New SqlParameter("@clUnit", SqlDbType.Text)).Value = c_Units.Text
            .Parameters.Add(New SqlParameter("@clUnitCost", SqlDbType.NVarChar)).Value = CInt(t_Cost.Text)
            Dim fSnd As Integer = .ExecuteNonQuery()
            If fSnd > 0 Then
                c_Products.Close()
                SaveOff = True
                Close()
            End If
        End With

3:      MsgBox("something's not right!", MsgBoxStyle.Critical)

    End Sub

    Sub keyTrapNum(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs)
        clearFields()
    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class