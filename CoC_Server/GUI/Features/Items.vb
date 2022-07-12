Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Npgsql
Imports NpgsqlTypes

Public Class Items
    Private SaveOff As Boolean = False
    Private OnEdit As Boolean = False

    Private tbl As DataTable
    Sub loadCombos()

        tbl = xRead("SELECT clName FROM clCustomers", "clCustomers")
        c_Supplier.Items.Clear()
        For Each row In tbl.Rows
            c_Supplier.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCurrency", "clCurrency")
        c_Currency.Items.Clear()
        For Each row In tbl.Rows
            c_Currency.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Item'", "clCategories")
        c_Category.Items.Clear()
        c_Category.Items.Add("NA")
        For Each row In tbl.Rows
            c_Category.Items.Add(row(0).ToString)
        Next

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Purchases'", "clCategories")
        c_P_Category.Items.Clear()
        c_P_Category.Items.Add("NA")
        For Each row In tbl.Rows
            c_P_Category.Items.Add(row(0).ToString)
        Next

    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Dim tD As New DateTime
        With Date.Now
            tD = New Date(.Year, .Month, .Day, .Hour, 59, 59)
        End With
        dtp_Expire.MinDate = tD
        SaveOff = False
        OnEdit = False
        clearFields()
        DiscardRecords()
        initiateFields()

    End Sub
    Sub DiscardRecords()
        xQry("DELETE FROM clItems WHERE clName IS NULL OR clName=''", cItems)
        xQry("DELETE FROM clItmPrx WHERE clName IS NULL OR clName=''", cItems)
        xQry("DELETE FROM " & StockTable() & " WHERE clName IS NULL OR clName=''", cTXNs)
        xQry("DELETE FROM clItemsMeasurements WHERE clName IS NULL OR clName=''", cItems)
        xQry("DELETE FROM clItemsDetails WHERE clLastModif IS NULL OR clLastModif=''", cItems)
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        DiscardRecords()
        clearFields()
        _Item = ___Is._SadlyNothing
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            btnNew_Click(Nothing, Nothing)
        End If

    End Sub
    Sub clearFields()
        l_ItemCode.Text = "Item Code: "
        t_Item.Text = NullVal
        t_Barcode.Text = NullVal
        t_Price.Text = 0
        t_Discount.Text = 0
        t_Cost.Text = 0
        t_VAT.Text = 0
        l_Discount.Text = "Dsc: 0"

        Try
            usrAvatar.Image.Dispose()
        Catch
        End Try

        loadCombos()
        Dim tD As New DateTime
        With Date.Now
            tD = New Date(.Year, .Month, .Day, .Hour, 59, 59)
        End With
        With tD
            dtp_Expire.MinDate = New Date(.Year,
                                          .Month,
                                          .Day)
        End With
        chkTaxInclusive_CheckedChanged(Nothing, Nothing)

    End Sub

    Sub getItemId()
        If _Item = ___Is._New Then

            Dim f As Integer = 1 + CInt(calcVal("SerialId",
                                "clItems",
                                CalcMode.GetCount,
                                cItems))

            Dim s As String = ""
            Try
                s = Qry("SELECT clName FROM clItems WHERE SerialId='" & CStr(f) & "'")
            Catch ex As Exception
                s = ""
            End Try
            If Not s = "" Then f = f + 1

            pID = String.Concat(CStr(f))

            xQry("INSERT INTO clItems (SerialId) VALUES ('" & pID & "')", cItems)

            xQry("INSERT INTO clItmPrx (SerialId) VALUES ('" & pID & "')", cItems)

            xQry("INSERT INTO " & StockTable() & " (clItemId) VALUES ('" & pID & "')", cTXNs)

            xQry("INSERT INTO clItemsMeasurements (clItemId) VALUES ('" & pID & "')", cItems)

            xQry("INSERT INTO clItemsDetails (SerialId) VALUES ('" & pID & "')", cItems)

            OnEdit = True
        Else
            pID = Code
        End If
    End Sub
    Dim pID As String = Nothing
    Sub initiateFields()
        getItemId()

        l_ItemCode.Text = String.Concat("Item Code: ", pID)

        Try
            tbl = xRead("SELECT clName,clBarcode,clPrice," &
                                                         "clCurrency, clDiscount," &
                                                         "clCustomerId,clCategoryId,clPurchaseId," &
                                                         "clUnitCost,clItemExpiry,clVAT,clVATInclusive,clWeighable FROM clItems" &
                                                         " WHERE SerialId='" &
            pID &
                                                         "'",
                        "clItems",
                        cItems)

            For Each row In tbl.Rows
                t_Item.Text = row(0).ToString
                t_Barcode.Text = row(1).ToString
                t_Price.Text = Convert.ToDecimal(row(2))
                c_Currency.Text = row(3).ToString
                t_Discount.Text = row(4)
                c_Supplier.Text = row(5).ToString
                c_Category.Text = row(6).ToString
                c_P_Category.Text = row(7).ToString

                Dim IsWeight As Boolean = (row(12) = 1)
                chkIsWeighable.Checked = IsWeight
                chkIsWeighable.Enabled = Not IsWeight
                btnAddUnits.Visible = IsWeight

                t_Cost.Text = row(8)

                chkTaxInclusive.Checked = (row(11) = 1)

                t_VAT.Text = Convert.ToDecimal(row(10))

                dtp_Expire.Value = CDate(row(9))
            Next

            loadAvatar()

        Catch ex As Exception
            write_Error(ex.Message, Name)
        Finally
            Try

            Catch ex As Exception
                write_Error(ex.Message, Name)
            End Try
        End Try

    End Sub
    Sub loadAvatar()
        Try
            tbl = xRead("SELECT clAvatar FROM clItemsDetails" &
                        " WHERE SerialId='" &
                        pID & "'",
                        "clItemsDetails", cItems)

            For Each row In tbl.Rows
                If Not row(0) Is DBNull.Value Then
                    Using mStream As New MemoryStream(CType(row(0), Byte()))
                        usrAvatar.Image = Image.FromStream(mStream, True)   '
                    End Using
                End If

            Next

            tbl.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Function askFields() As Boolean
        Dim Result As Boolean = False
        Result = t_Item.Text IsNot NullVal AndAlso
                   Not v(t_Price.Text) = 0 AndAlso Not v(t_Barcode.Text) = 0
        Return Result
    End Function
    Sub keyTrapNum(sender As Object, e As KeyPressEventArgs) Handles t_Cost.KeyPress, t_Discount.KeyPress, t_Price.KeyPress, t_VAT.KeyPress, t_Barcode.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub
    Sub clearAll()
        OnLoad(Nothing)
    End Sub
    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        clearAll()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        LoadUp()
    End Sub
    Sub LoadUp()
        Try
            If Not cItems.State = ConnectionState.Open Then cItems.Open()
            Dim cm As New NpgsqlCommand("UPDATE clItems SET clName=@clName,clBarcode=@clBarcode,clPrice=@clPrice," &
                                                                                                               "clCurrency=@clCurrency,clDiscount=@clDiscount," &
                                                                                                               "clCustomerId=@clCustomerId," &
                                                                                                               "clCategoryId=@clCategoryId,clPurchaseId=@clPurchaseId," &
                                                                                                               "clUnitCost=@clUnitCost," &
                                                                                                               "clItemExpiry=@clItemExpiry,clDate=@clDate,clVAT=@clVAT," &
                                                                                                               "clVATInclusive=@clVATInclusive,clWeighable=@clWeighable," &
                                                                                                               "clMargin=@clMargin " &
                                                                                                               "WHERE SerialId='" & pID & "'",
                                             cItems)
            Dim tD As Date = New Date()
            With Date.Now
                tD = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cm

                If Not askFields() Then GoTo 3

                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = t_Item.Text
                .Parameters.Add(New NpgsqlParameter("@clBarcode", NpgsqlDbType.Varchar)).Value = t_Barcode.Text
                .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = v(t_Price.Text)
                .Parameters.Add(New NpgsqlParameter("@clCurrency", NpgsqlDbType.Varchar)).Value = c_Currency.Text
                .Parameters.Add(New NpgsqlParameter("@clDiscount", NpgsqlDbType.Bigint)).Value = v(t_Discount.Text / 100) * v(t_Price.Text)
                .Parameters.Add(New NpgsqlParameter("@clCustomerId", NpgsqlDbType.Varchar)).Value = c_Supplier.Text
                .Parameters.Add(New NpgsqlParameter("@clCategoryId", NpgsqlDbType.Varchar)).Value = c_Category.Text
                .Parameters.Add(New NpgsqlParameter("@clPurchaseId", NpgsqlDbType.Varchar)).Value = c_P_Category.Text
                .Parameters.Add(New NpgsqlParameter("@clUnitCost", NpgsqlDbType.Bigint)).Value = v(t_Cost.Text)
                .Parameters.Add(New NpgsqlParameter("@clItemExpiry", NpgsqlDbType.Timestamp)).Value = dtp_Expire.Value
                .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Timestamp)).Value = tD
                .Parameters.Add(New NpgsqlParameter("@clVAT", NpgsqlDbType.Integer)).Value = v(t_VAT.Text)
                .Parameters.Add(New NpgsqlParameter("@clWeighable", NpgsqlDbType.Integer)).Value = IIf(chkIsWeighable.Checked, 1, 0)
                .Parameters.Add(New NpgsqlParameter("@clVATInclusive", NpgsqlDbType.Integer)).Value = IIf(chkTaxInclusive.Checked, 1, 0)
                .Parameters.Add(New NpgsqlParameter("@clMargin", NpgsqlDbType.Integer)).Value = 1
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    MsgBox("Save success!")
                    cItems.Close()
                    SaveOff = True
                    OnEdit = False

                    xQry("UPDATE clItmPrx SET clName='" & t_Item.Text & "'," &
                                                                    "clBarcode='" & t_Barcode.Text &
                                                                  "',clPrice='" & v(t_Price.Text) & "' " &
                                            "WHERE SerialId='" & pID & "'",
                         cItems)

                    UpdateDailyStock()

                    clearFields()

                    Close()
                Else
                    GoTo 3
                End If
            End With
        Catch ex As SqlException
            write_Error(ex.Message, Name)
            'MsgBox(ex.Message)
        End Try

        Exit Sub
3:      MsgBox("something's not right!", MsgBoxStyle.Critical)
        GoTo 7
        Exit Sub
7:      If cItems.State = ConnectionState.Open Then cItems.Close()

    End Sub
    Sub UpdateDailyStock()
        Dim TbNm As String = StockTable()
        Dim SqlUpdt As String = "UPDATE " & TbNm & " SET clSessionId=@clSessionId,clDate=@clDate," &
                                                                                          "clName=@clName," &
                                                                                          "clStockTransfer=@clStockTransfer,clStockTransferAmt=@clStockTransferAmt," &
                                                                                          "clTXNs=@clTXNs,clTXNsAmt=@clTXNsAmt," &
                                                                                          "clStockPurchase=@clStockPurchase,clStockPurchaseAmt=@clStockPurchaseAmt," &
                                                                                          "clTXNsReturns=@clTXNsReturns,clTXNsReturnsAmt=@clTXNsReturnsAmt," &
                                                                                          "clPurchaseReturns=@clPurchaseReturns,clPurchaseReturnsAmt=@clPurchaseReturnsAmt," &
                                                                                          "clTXNsOrders=@clTXNsOrders,clTXNsOrdersAmt=@clTXNsOrdersAmt," &
                                                                                          "clPurchaseOrders=@clPurchaseOrders,clPurchaseOrdersAmt=@clPurchaseOrdersAmt," &
                                                                                          "clStockOpening=@clStockOpening,clStockOpeningAmt=@clStockOpeningAmt," &
                                                                                          "clStockClosing=@clStockClosing,clStockClosingAmt=@clStockClosingAmt," &
                                                                                          "clCost=@clCost,clPrice=@clPrice" &
                                                                                  " WHERE clItemId='" & pID & "'"
        Try
            With cTXNs
                If Not .State = ConnectionState.Open Then .Open()
            End With
            Dim cm As New NpgsqlCommand(SqlUpdt, cTXNs)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clSessionId", NpgsqlDbType.Varchar)).Value = SerialId()
                Dim d As Date = New Date
                With JournalDate
                    d = New Date(.Year, .Month, .Day)
                End With
                .Parameters.Add(New NpgsqlParameter("@clDate", NpgsqlDbType.Timestamp)).Value = d
                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = t_Item.Text
                .Parameters.Add(New NpgsqlParameter("@clStockTransfer", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clStockTransferAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clTXNs", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clTXNsAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clStockPurchase", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clStockPurchaseAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clTXNsReturns", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clTXNsReturnsAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clPurchaseReturns", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clPurchaseReturnsAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clTXNsOrders", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clTXNsOrdersAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clPurchaseOrders", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clPurchaseOrdersAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clStockOpening", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clStockOpeningAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clStockClosing", NpgsqlDbType.Integer)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clStockClosingAmt", NpgsqlDbType.Bigint)).Value = 0
                .Parameters.Add(New NpgsqlParameter("@clCost", NpgsqlDbType.Bigint)).Value = v(Convert.ToDecimal(t_Cost.Text))
                .Parameters.Add(New NpgsqlParameter("@clPrice", NpgsqlDbType.Bigint)).Value = v(Convert.ToDecimal(t_Price.Text))

                With cTXNs
                    If Not .State = ConnectionState.Open Then .Open()
                End With
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    cTXNs.Close()
                End If
            End With

        Catch ex As Exception
            cTXNs.Close()
            write_Error(ex.Message, Name)
        End Try

    End Sub
    Private Sub chkTaxInclusive_CheckedChanged(sender As Object, e As EventArgs) Handles chkTaxInclusive.CheckedChanged
        If chkTaxInclusive.Checked Then
            Try
                t_VAT.Text = CInt(t_Price.Text) * 0.05
            Catch ex As Exception
                t_VAT.Text = 0
            End Try
        Else
            t_VAT.Text = 0
        End If

    End Sub
    Private Sub t_Discount_TextChanged(sender As Object, e As EventArgs) Handles t_Discount.TextChanged
        Dim Ds As Decimal = 0.00
        Try
            Ds = Convert.ToDecimal((CDec(t_Discount.Text) / 100) * (t_Price.Text))
        Catch ex As Exception
            Ds = 0
        End Try
        l_Discount.Text = "Dsc: " & Ds
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnAddUnits_Click(sender As Object, e As EventArgs) Handles btnAddUnits.Click
        Code = pID
        Dim fr As New Items_Weighable
        If Not fr.Visible Then fr.ShowDialog()
    End Sub

    Private Sub img_Avatar_DoubleClick(sender As Object, e As EventArgs) Handles usrAvatar.DoubleClick
        Dim f As New AddItemAvatar

        Dim gReq As MsgBoxResult = MsgBox("Modify Image?", MsgBoxStyle.YesNo)

        If Not gReq = MsgBoxResult.Yes Then Exit Sub

        If Not f.Visible Then f.ShowDialog()

        loadAvatar()

    End Sub

    Private Sub t_Item_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Item.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If t_Barcode.Focused Then
                t_Item.Focus()
            ElseIf t_Item.Focused Then
                t_Price.Focus()
            ElseIf t_Price.Focused Then
                t_Discount.Focus()
            ElseIf t_Discount.Focused Then
                c_Currency.Focus()
            ElseIf c_Currency.Focused Then
                t_Cost.Focus()
            ElseIf t_Cost.Focused Then
                t_VAT.Focus()
            ElseIf t_VAT.Focused Then
                c_Supplier.Focus()
            ElseIf c_Supplier.Focused Then
                c_Category.Focus()
            ElseIf c_Category.Focused Then
                c_P_Category.Focus()
            ElseIf c_P_Category.Focused Then
                chkIsWeighable.Focus()
            ElseIf chkIsWeighable.Focused Then
                dtp_Expire.Focus()
            ElseIf dtp_Expire.Focused Then
                btnSave.Focus()

            End If
        End If

    End Sub

End Class