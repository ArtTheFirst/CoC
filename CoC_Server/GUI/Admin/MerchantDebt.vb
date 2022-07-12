Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class MerchantDebt
    Sub clearAll()
        loadMerchants()
        t_Paid.Text = 0
        outstanding = 0
    End Sub

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        clearAll()
        loadMerchants()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        clearAll()
    End Sub
    Sub loadMerchants()
        Dim tbl As DataTable = xRead("SELECT clName FROM clMerchants WHERE clOutstanding>0", "clMerchants")
        c_Merchants.Items.Clear()
        For Each row In tbl.Rows
            c_Merchants.Items.Add(row(0).ToString)
        Next

    End Sub
    Dim outstanding As Integer = 0
    Dim Id As String = Nothing
    Private Sub c_Merchants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Merchants.SelectedIndexChanged
        If c_Merchants.Text = NullVal Then outstanding = 0 : Exit Sub

        Dim tbl As DataTable = xRead("SELECT SerialId,clOutstanding FROM clMerchants WHERE clName='" & c_Merchants.Text & "'", "clMerchants")
        For Each row In tbl.Rows
            Id = row(0).ToString
            l_Id.Text = String.Concat("Merchant Id; ", Id)
            outstanding = CInt(row(1))
            l_outstanding.Text = String.Concat("Outstanding Balance; ", FormatNumber(outstanding, 0))
            t_Paid.Text = FormatNumber(outstanding, 0)
        Next

    End Sub

    Sub confirmPay() Handles btnSave.Click
        If Id = Nothing Or Id.Length < 1 Then GoTo 3

        If CInt(t_Paid.Text) > outstanding Or CInt(t_Paid.Text) < outstanding Then GoTo 3

        Try
            With c
                .Open()
            End With
            Dim cm As New SqlCommand("UPDATE clMerchants SET clOutstanding=@clOutstanding WHERE SerialId='" & Id & "'",
                                       c)
            With cm
                .Parameters.Add(New SqlParameter("@clOutstanding", SqlDbType.BigInt)).Value = CInt(t_Paid.Text)
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    clearAll()
                End If
            End With
        Catch ex As Exception
            c.Close()
        End Try
3:      MsgBox("An error is preventing you from continuing! Check that you have selected a merchant and payment amount provided")
        clearAll()

    End Sub

    Private Sub t_Paid_TextChanged(sender As Object, e As EventArgs) Handles t_Paid.TextChanged
        Try
            If t_Paid.Text = NullVal Then t_Paid.Text = 0
            l_outstanding.Text = String.Concat("Outstanding Balance; ", FormatNumber(outstanding - CInt(t_Paid.Text), 0))
        Catch ex As Exception

        End Try

    End Sub

End Class