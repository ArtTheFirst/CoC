Imports System.ComponentModel

Public Class Product_CategoryCtrl

    Private tbl As DataTable = Nothing
    Private errMsg As String = "Name already exists!"

    Function IdXst() As Boolean
        Return xXst("SerialId", "clCategories", _Id & " AND clCategory='Product'") = xData.Exists
    End Function

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Product'", "clCategories")
        c_Category.Items.Clear()
        For Each row In tbl.Rows
            c_Category.Items.Add(row(0).ToString)
        Next

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        DisposeId()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IdXst() Then MsgBox(errMsg, MsgBoxStyle.Information) : GoTo 3
        Dim Rs As String = String.Concat("Save ", xQry("INSERT INTO clCategories (SerialId,clName,clCategory) VALUES ('" & SerialId() & "','" & c_Category.Text & "','Product')"))
        MsgBox(Rs, MsgBoxStyle.Information)
3:      OnLoad(e)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not IdXst() Then GoTo 3
        Dim Rs As String = String.Concat("Delete ", xQry("DELETE FROM clCategories WHERE clName='" & c_Category.Text & "' AND clCategory='Product'"))
        MsgBox(Rs, MsgBoxStyle.Information)
3:      OnLoad(e)

    End Sub

    Private Sub c_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Category.SelectedIndexChanged
        _Id = Qry("SELECT SerialId FROM clCategories WHERE clCategory='Product' AND clName='" & c_Category.Text & "'")

    End Sub

End Class