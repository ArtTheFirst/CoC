Imports System.ComponentModel

Public Class Products_Unit

    Sub loadAccts()
        Dim tbl As DataTable = Nothing
        tbl = xRead("SELECT clName FROM clAccounts", "clAccounts")
        c_Units.Items.Clear()
        c_Units.Items.Add(Space(1))
        For Each row In tbl.Rows
            c_Units.Items.Add(row(0).ToString)
        Next
        c_Units.Text = Nullify
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadAccts()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        DisposeId()

    End Sub

    Dim errMsg As String = "Name already exists!"
    Function IdX() As Boolean
        Return xXst("clName", "clAccounts", c_Units.Text) > 1
    End Function
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sQry As String = Nothing
        Dim s As String = c_Units.Text
        If s = NullVal Then Exit Sub
        If IdX() Then
            sQry = "UPDATE clAccounts SET clName='" & c_Units.Text & "' WHERE clName='" & s & "'"
        Else
            sQry = "INSERT INTO clAccounts (clName,SerialId) VALUES ('" & c_Units.Text & "','" & SerialId() & "')"
        End If

        Dim rSlt As String = Nothing
        rSlt = xQry(sQry)
        loadAccts()
        MsgBox(String.Concat("Save ", rSlt), MsgBoxStyle.Information)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If IdX() Then MsgBox(errMsg, MsgBoxStyle.Information) : Exit Sub
        Dim rSlt As String = Nothing
        rSlt = xQry("DELETE FROM clAccounts WHERE clName='" & c_Units.Text & "')")
        loadAccts()
        MsgBox(String.Concat("Delete ", rSlt), MsgBoxStyle.Information)

    End Sub

End Class