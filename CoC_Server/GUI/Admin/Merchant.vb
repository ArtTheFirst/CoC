Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Merchant

    Private tbl As DataTable = Nothing
    Private SaveOff As Boolean = False
    Private OnEdit As Boolean = False

    Sub clearFields()
        OnEdit = False
        SaveOff = False
        t_Company.Clear()
        t_Address.Clear()
        c_Merchants.Text = Nullify
        c_PreferredCurrency.Text = Nullify
        c_PreferredPayment.Text = Nullify
        dId = String.Concat("MCHT", Date.Now.Year, HexLongSerialId)
        l_MerchantId.Text = String.Concat("Merchant Id ", dId)
        t_PurchasePower.Text = FormatNumber(9999999, 2)
        loadCombos()
        btnDelete.Enabled = OnEdit

    End Sub

    Sub initializeId()
        If Not IdXst() Then
            xQry("INSERT INTO clMerchants (SerialId) VALUES ('" & dId & "')")
            OnEdit = True
        End If

    End Sub

    Sub loadCombos()

        tbl = xRead("SELECT clName FROM clMerchants", "clMerchants")
        c_Merchants.Items.Clear()
        For Each row In tbl.Rows
            c_Merchants.Items.Add(row(0).ToString)
        Next

        c_PreferredPayment.Items.Clear()
        c_PreferredPayment.Items.Add("Cash")
        c_PreferredPayment.Items.Add("Credit")

        tbl = xRead("SELECT clName FROM clCurrency", "clCurrency")
        c_PreferredCurrency.Items.Clear()
        For Each row In tbl.Rows
            c_PreferredCurrency.Items.Add(row(0).ToString)
        Next

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        clearFields()
        initializeId()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        If IdXst() Then Exit Sub
        If Not SaveOff AndAlso OnEdit Then xQry("DELETE FROM clDistributors WHERE SerialId='" & dId & "'")
        DisposeId()
    End Sub

    Dim errMsg As String = "Name already exists!"
    Function IdXst() As Boolean
        Return xXst("SerialId", "clMerchants", dId) = xData.Exists
    End Function

    Dim dId As String = Nothing
    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        OnLoad(e)
    End Sub

    Private Sub c_Merchants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Merchants.SelectedIndexChanged
        dId = Qry("SELECT SerialId FROM clMerchants WHERE clName='" & c_Merchants.Text & "'")

        If dId = Nothing Or dId = NullVal Then Exit Sub

        If Not IdXst() Then Exit Sub

        tbl = xRead("SELECT * FROM clMerchants WHERE SerialId='" & dId & "'", "clMerchants")

        If tbl Is Nothing Or tbl.Rows.Count < 1 Then clearFields() : Exit Sub
        clearFields()

        For Each row In tbl.Rows
            l_MerchantId.Text = String.Concat("Merchant Id ", row(1).ToString)
            c_Merchants.Text = row(2).ToString
            t_Company.Text = row(3).ToString
            t_Address.Text = row(4).ToString
            c_PreferredPayment.Text = row(5).ToString
            c_PreferredCurrency.Text = row(6).ToString
        Next
        btnDelete.Enabled = True

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If c_Merchants.Text = NullVal Then MsgBox("You have not provided needed data!", MsgBoxStyle.Information) : Exit Sub

        Try
            With c
                .Open()
            End With
            Dim cm As New SqlCommand("UPDATE clMerchants SET clName=@clName,clCompany=@clCompany,clOutstanding=@clOutstanding," &
                                                                                                          "clAddress=@clAddress,clPreferredPay=@clPreferredPay," &
                                                                                                          "clPreferredCurrency=@clPreferredCurrency,clPurchasePower=@clPurchasePower " &
                                                                                     "WHERE SerialId='" & dId & "'",
                                       c)
            With cm
                .Parameters.Add(New SqlParameter("@clName", SqlDbType.Text)).Value = c_Merchants.Text
                .Parameters.Add(New SqlParameter("@clCompany", SqlDbType.Text)).Value = t_Company.Text
                .Parameters.Add(New SqlParameter("@clAddress", SqlDbType.Text)).Value = t_Address.Text
                .Parameters.Add(New SqlParameter("@clPreferredPay", SqlDbType.Text)).Value = c_PreferredPayment.Text
                .Parameters.Add(New SqlParameter("@clPreferredCurrency", SqlDbType.Text)).Value = c_PreferredCurrency.Text
                .Parameters.Add(New SqlParameter("@clOutstanding", SqlDbType.NVarChar)).Value = 0
                .Parameters.Add(New SqlParameter("@clPurchasePower", SqlDbType.NVarChar)).Value = CType(t_PurchasePower.Text, Integer)

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    SaveOff = True
                    c.Close()
                    clearFields()
                End If
            End With
        Catch ex As Exception
            c.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not IdXst() Then Exit Sub
        Dim mgRq As MsgBoxResult = MsgBox("Do you really want to delete record? This is irreversible", MsgBoxStyle.YesNo)
        If Not mgRq = MsgBoxResult.Yes Then Exit Sub
        Dim sS As String = String.Concat("Delete ", xQry("DELETE FROM clMerchants WHERE SerialId='" & dId & "'"))
        clearFields()
        MsgBox(sS, MsgBoxStyle.Information)

    End Sub

    Private Sub t_PurchasePower_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_PurchasePower.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete
                Exit Sub
            Case Else
                e.Handled = True
        End Select

    End Sub
    Private Sub t_PurchasePower_Leave(sender As Object, e As EventArgs) Handles t_PurchasePower.Leave
        t_PurchasePower.Text = FormatNumber(t_PurchasePower.Text, 2)
    End Sub

End Class