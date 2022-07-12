Public Class Currency_Ctrl

    Sub loadCurrency()
        Dim tbl As DataTable = Nothing
        Try
            tbl = xRead("SELECT clName FROM clCurrency", "clCurrency")
            c_Currency.Items.Clear()
            For Each row In tbl.Rows
                c_Currency.Items.Add(row(0).ToString)
            Next
            t_Unit.Clear()
            xploit = qX.Sv
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        t_Unit.Clear()
        loadCurrency()

    End Sub

    Function IdX() As Boolean
        Return xXst("clName", "clCurrency", c_Currency.Text) = xData.Exists
    End Function

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sQry As String = Nothing
        If c_Currency.Text.Length < 3 Then Exit Sub
        Dim rSlt As String = Nothing
        sQry = IIf(xploit = qX.Sv, "INSERT INTO clCurrency (SerialId,clName,clUnit) VALUES ('" &
                   SerialId() & "','" & c_Currency.Text & "','" & t_Unit.Text & "')",
                                        "UPDATE clCurrency SET clName='" & c_Currency.Text &
                                        "',clUnit='" & t_Unit.Text &
                                        "' WHERE SerialId='" & _Id & "'")
        rSlt = xQry(sQry)
        MsgBox(String.Concat("Save ", rSlt), MsgBoxStyle.Information)
        OnLoad(e)

    End Sub

    Enum qX
        Sv
        Upd
    End Enum
    Private xploit As qX = qX.Sv
    Private Sub c_Currency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Currency.SelectedIndexChanged
        Dim tbl As DataTable = xRead("SELECT SerialId,clUnit FROM clCurrency WHERE clName='" & c_Currency.Text & "'", "clCurrency")
        If tbl Is Nothing Or tbl.Rows.Count < 1 Then OnLoad(Nothing) : Exit Sub
        For Each row In tbl.Rows
            _Id = row(0).ToString

            xploit = IIf(IdX, qX.Upd, qX.Sv)

            If xploit = qX.Sv Then OnLoad(e) : Exit Sub

            t_Unit.Text = row(1).ToString
        Next

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not IdX() Then Exit Sub
        Dim rSlt As String = Nothing
        rSlt = xQry("DELETE FROM clCurrency WHERE SerialId='" & _Id & "'")
        MsgBox(String.Concat("Delete ", rSlt), MsgBoxStyle.Information)
        OnLoad(e)

    End Sub

End Class