﻿Imports System.Data.SqlClient

Public Class ModifyStockStatus

    Enum Active
        IsOutOfStock
        IsGoingOutOfStock
    End Enum
    Private ActiveLoad As Active = -1
    Public Sub CallLoadForm(LoadMode As Active, CallModeInForm As Boolean, Optional f As Form = Nothing)
        Dim s, cat As String
        Select Case LoadMode
            Case Active.IsGoingOutOfStock
                s = "<=" & My.Settings.prodAlertQty
                cat = "out of stock"
                ActiveLoad = Active.IsGoingOutOfStock
            Case Active.IsOutOfStock
                s = "<=0"
                cat = "going out of stock"
                ActiveLoad = Active.IsOutOfStock
        End Select
        Dim tbl As DataTable = xRead("SELECT clName,clQty,clCategoryId FROM clProducts WHERE clQty" & s, "clProducts", c_Products)
        dg_OOSL.Rows.Clear()
        For Each row In tbl.Rows
            dg_OOSL.Rows.Add(" ", row(0).ToString, FormatNumber(row(1).ToString, 0), row(1).ToString)

        Next
        l_Total.Text = String.Concat("[", dg_OOSL.RowCount, "] products in total ", cat, "; Total Sum; ", subTotal(2))

        If Not CallModeInForm Then ShowDialog(f)

    End Sub
    Public Function subTotal(col As Integer) As Decimal
        Dim TotalValue As Decimal
        Dim tmp As Decimal
        For n As Integer = 0 To dg_OOSL.Rows.Count - 1
            Dim nDR As DataGridViewRow = dg_OOSL.Rows(n)
            With nDR
                If Decimal.TryParse(.Cells(col).Value, tmp) Then
                    TotalValue += tmp
                End If
            End With
        Next

        Return TotalValue
    End Function

    Sub saveDetails() Handles btnLoadAll.Click
        If Not c_Products.State = ConnectionState.Open Then c_Products.Open()
        For Each row As DataGridViewRow In dg_OOSL.Rows
            Dim cm As New SqlCommand("UPDATE clProducts SET clQty=@clQty WHERE clName='" & row.Cells(1).Value &
                                                                "' AND clCategoryId='" & row.Cells(2).Value,
                                       c_Products)
            With cm
                .Parameters.Add(New SqlParameter("@clQty", SqlDbType.NVarChar)).Value = CInt(row.Cells(3).Value)
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c_Products.Close()
                    CallLoadForm(ActiveLoad, True)
                Else
                    dg_OOSL.Rows.Clear()
                    MsgBox("Update failed!")
                    Close()
                End If
            End With
        Next

    End Sub

End Class