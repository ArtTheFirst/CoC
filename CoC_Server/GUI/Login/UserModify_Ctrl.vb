Imports System.ComponentModel
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class UserModify_Ctrl

    Sub loadAccts()
        Dim tbl As DataTable = Nothing
        tbl = xRead("SELECT dtbName FROM clLogin WHERE dtbClientMode='base'", "clLogin")
        c_Accts.Items.Clear()
        For Each row In tbl.Rows
            c_Accts.Items.Add(row(0).ToString)
        Next

    End Sub
    Sub loadDetails()


    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        btnSave.Enabled = False
        loadAccts()
        l_usr.Text = String.Concat("signed in as ", usr)
        l_Server.Text = String.Concat("server address ", GetIPAddress)

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        c_Accts.Text = NullVal
        t_Pass.Clear()
        l_Login.Text = "User Details"

    End Sub

    Sub addAcct()
        If c_Accts.Text.Length < 3 Or t_Pass.Text.Length < 3 Then GoTo 3

        If dId = NullVal Or dId.Length < 1 Then GoTo 3 Else GoTo 1

        Exit Sub
1:      Dim csprng As New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(24) {}
        csprng.GetBytes(salt)
        Try
            Dim Sql As String = "UPDATE clLogin SET dtbName=@dtbName,dtbSalt=@dtbSalt,dtbHash=@dtbHash,dtbClientMode=@dtbClientMode WHERE SerialId='" & dId & "'"
            With c
                .Open()
            End With
            Dim cm As New SqlCommand(Sql, c)
            With cm
                .Parameters.Add(New SqlParameter("@dtbName", SqlDbType.Text)).Value = c_Accts.Text
                .Parameters.Add(New SqlParameter("@dtbSalt", SqlDbType.Text)).Value = salt
                .Parameters.Add(New SqlParameter("@dtbHash", SqlDbType.Text)).Value = Encrypt(t_Pass.Text, salt)
                .Parameters.Add(New SqlParameter("@dtbClientMode", SqlDbType.Text)).Value = "base"
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    loadAccts()
                    OnClosing(Nothing)
                    MsgBox("Update successful!", MsgBoxStyle.Information)
                Else
                    GoTo 3
                End If
            End With

        Catch ex As Exception
            If c.State = ConnectionState.Open Then c.Close()
            GoTo 3
        End Try

        Exit Sub
3:      MsgBox("Error while saving account! Check details provided", MsgBoxStyle.Critical)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        addAcct()
    End Sub
    Dim dId As String = Nothing
    Private Sub c_Accts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles c_Accts.SelectedIndexChanged
        Dim tbl As DataTable = xRead("SELECT SerialId,c_ClientMode,c_ActivateMode FROM clLogin WHERE c_Name='" & c_Accts.Text & "'", "cLogin",)
        If tbl Is Nothing Or tbl.Rows.Count < 1 Then Exit Sub
        For Each row In tbl.Rows
            dId = row(0).ToString
            l_Login.Text = String.Concat(c_Accts.Text, vbNewLine,
                                              "access level: ", row(1).ToString,
                                         "active status; ", row(2).ToString)
        Next

    End Sub

End Class