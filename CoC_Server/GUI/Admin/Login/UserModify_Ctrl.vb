Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Npgsql
Imports NpgsqlTypes

Public Class UserModify_Ctrl

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        getIdDetails()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        resetAll()
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Sub resetAll()
        t_Pass.Clear()
        t_User.Clear()
        l_ClientId.Text = l_ClientId.Tag
        l_ClientName.Text = l_ClientName.Tag
    End Sub

    Sub getIdDetails()

        If Id = "" Then Close()

        resetAll()

        Dim _u As String = Nothing
        Try
            _u = Qry("SELECT clName FROM clContacts WHERE SerialId='" & Id & "'")
        Catch ex As Exception
            _u = ""
        End Try

        l_ClientName.Text = String.Concat("client name: ", _u)

        l_ClientId.Text = String.Concat("client id: ", Id)

        Dim tbl As DataTable = xRead("SELECT clName,clCanOperate FROM clLogs WHERE SerialId='" & Id & "'", "clLogs")
        For Each row In tbl.Rows
            t_User.Text = row(0).ToString
            If CType(row(1), Integer) = IsApproved Then
                chkCanLogin.Checked = True
            ElseIf CType(row(1), Integer) = IsDeclined Then
                chkCanLogin.Checked = False
            End If
        Next

    End Sub

    Sub UpdateDetails()
        If Trim(t_User.Text) = "" Then Exit Sub

        Dim s As String = Nothing
        Try
            s = Qry("SELECT SerialId FROM clLogs WHERE clName='" & t_User.Text & "'")
        Catch ex As Exception
            s = ""
        End Try
        If Not s = "" Then Exit Sub

        Cnfg.Reload()

        If _This() = LoginIs.Admin Then
            GoTo 3
        Else
            If Cnfg.subAdminModifyOwnKey = Cnfg.Actv Then
                GoTo 3
            Else
                complain()
                Mode = LoginMode.AllowAccess
                login.ShowDialog()
                If _Access = _Request.IsGranted And CurrentRequested = UserLogin.IsAdmin Then
                    GoTo 3
                Else
                    ShowMessage("Permission revoked!", _Method.AsError)
                End If
            End If
        End If

        Exit Sub

3:      Dim iUpdate As Boolean = False
        If t_Pass.Text.Length > 7 Then
            Dim MsgReq As MsgBoxResult = MsgBox("Update user password?", MsgBoxStyle.YesNo, "Cy POS_Logger")
            iUpdate = (MsgReq = MsgBoxResult.Yes)
        End If

        Dim MgReq As MsgBoxResult = MsgBox("Continue?", MsgBoxStyle.OkCancel, "Cy POS_Logger")

        If Not MgReq = MsgBoxResult.Ok Then Exit Sub

        Dim csprng As New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(24) {}
        csprng.GetBytes(salt)
        Try
            Dim Sql As String = "UPDATE cocLogin SET cocName=@cocName" &
                                                                           IIf(iUpdate, ",cocSalt=@cocSalt,cocHash=@cocHash", "") &
                                                                   " WHERE SerialId='" & _Id & "'"
            With c
                .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@cocName", NpgsqlDbType.Varchar)).Value = t_User.Text
                If iUpdate Then
                    .Parameters.Add(New NpgsqlParameter("@cocSalt", NpgsqlDbType.Bytea)).Value = salt
                    .Parameters.Add(New NpgsqlParameter("@cocHash", NpgsqlDbType.Bytea)).Value = Encrypt(t_Pass.Text, salt)
                End If
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    GoTo 6
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
            If c.State = ConnectionState.Open Then c.Close()
        End Try
        Exit Sub

6:      Try
            Dim Sql As String = "UPDATE clLogs SET clName=@clName WHERE SerialId='" & _Id & "'"
            With c
                .Open()
            End With
            Dim cm As NpgsqlCommand = New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = t_User.Text
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    MsgBox("Success!", MsgBoxStyle.Information, "Cy POS_Logger")
                    resetAll()
                End If
            End With

        Catch ex As Exception
            If c.State = ConnectionState.Open Then c.Close()
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateDetails()
    End Sub

    Private Sub chkCanLogin_CheckedChanged(sender As Object, e As EventArgs) Handles chkCanLogin.CheckedChanged

        If Trim(_Id) = "" Then Exit Sub

        Dim dy As Integer = -1
        If chkCanLogin.Checked = True Then
            dy = IsApproved
        ElseIf chkCanLogin.Checked = False Then
            dy = IsDeclined
        End If
        Try
            Dim Sql As String = "UPDATE clLogs SET clCanOperate=@clCanOperate WHERE SerialId='" & _Id & "'"
            With c
                .Open()
            End With
            Dim cm As NpgsqlCommand = New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clCanOperate", NpgsqlDbType.Integer)).Value = dy
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                End If
            End With

        Catch ex As Exception
            If c.State = ConnectionState.Open Then c.Close()
        End Try
    End Sub

End Class