Public Class Purchase_CategoryCtrl

    Private tbl As DataTable = Nothing
    Private errMsg As String = "Name already exists!"

    Function IdXst() As Boolean
        Return xXst("clName", "clCategories", c_Category.Text & " AND clCategory='Purchase'") > 1
    End Function

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        tbl = xRead("SELECT clName FROM clCategories WHERE clCategory='Purchase'", "clCategories")
        c_Category.Items.Clear()
        c_Category.Items.Add(Space(1))
        For Each row In tbl.Rows
            c_Category.Items.Add(row(0).ToString)
        Next

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If IdXst() Then MsgBox(errMsg, MsgBoxStyle.Information) : GoTo 3
        Dim Rs As String = String.Concat("Save ", xQry("INSERT INTO clCategories (SerialId,clName,clCategory) VALUES ('" & SerialId() & "','" & c_Category.Text & "','Purchase')"))
        MsgBox(Rs, MsgBoxStyle.Information)
3:      OnLoad(e)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not IdXst() Then GoTo 3
        Dim Rs As String = String.Concat("Delete ", xQry("DELETE FROM clCategories WHERE clName='" & c_Category.Text & "' AND clCategory='Purchase'"))
        MsgBox(Rs, MsgBoxStyle.Information)
3:      OnLoad(e)

    End Sub

End Class