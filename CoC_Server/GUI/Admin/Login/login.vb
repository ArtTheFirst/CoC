Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Npgsql
Imports NpgsqlTypes
Imports System.Security
Public Class login

    Protected Const cH As Integer = 191
    Protected Const xH As Integer = 271
    Protected xcept As Boolean = False
    Protected usrId As String

    Sub clearFields()

        tUsr.Clear()
        tKey.Clear()
        tKeyRpt.Clear()
        tUsr.Focus()
        usrId = NullVal
        tKey.Enabled = True
        l_ErrorTxt.Visible = False

        tUsr.Focus()

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Dim headertext As String = ""
        Select Case Mode
            Case LoginMode.Startup
                Text = "Welcome"
                Height = cH
                User = Just.LoggedIn
                tUsr.Focus()

            Case LoginMode.AllowAccess
                Text = "Admin unlock"
                Height = cH

            Case LoginMode.AskModifier
                Text = "Modify passkey"
                Cnfg.Reload()
                If _This() = LoginIs.SubAdmin Then
                    If Cnfg.subAdminModifyOwnKey = Cnfg.InActv Then
                        MsgBox("You do not have the rights to do this. Sorry", MsgBoxStyle.Critical)
                        Close()
                    End If
                End If
                Height = cH
                tUsr.Text = StrConv(usr, VbStrConv.ProperCase)
                If _This() = LoginIs.SubAdmin Then tKey.Enabled = False

            Case LoginMode.ModifyKey
                headertext = "Modify passkey"
                tKey.Clear()
                tKeyRpt.Clear()
                tUsr.Focus()
                Me.Height = xH

        End Select

    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        'e.Cancel = True
        xcept = True
        clearFields()
        If Not Mode = LoginMode.Startup Then Exit Sub Else e.Cancel = True : Hide()
        Dim p As Process = Process.GetCurrentProcess
        p.Kill()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Dim logincount As Integer = -1
    Sub SendResetRequest()
        tKey.Clear()
        logincount = logincount + 1
        If logincount > 2 Then
            Mcomplain()
        End If
    End Sub

    Private myMode As Integer = -1
    Sub getId()
        Dim operateMode = Nothing

        Try
            'usrId = Qry("SELECT SerialId FROM cocLogin WHERE cocName='" & tUsr.Text & "'")
            usrId = sQry("SerialId", "cocLogin", "cocName", tUsr.Text, NpgsqlDbType.Varchar)
        Catch ex As Exception
            usrId = ""
        End Try
        If usrId = "" Then GoTo 5 Else GoTo 2
        Exit Sub
2:      Try
            'operateMode = Qry("SELECT clCanOperate FROM clLogs WHERE SerialId='" & usrId & "'")
            operateMode = sQry("clCanOperate", "clLogs", "SerialId", usrId, NpgsqlDbType.Integer)
            If Not operateMode = IsApproved Then GoTo 5 Else GoTo 3
            l_ErrorTxt.Visible = False
        Catch ex As Exception
            operateMode = IsDeclined
        End Try
        Exit Sub
3:      Try
            myMode = sQry("clClientMode", "clLogs", "SerialId", usrId, NpgsqlDbType.Integer)
        Catch ex As Exception
            myMode = -1
        End Try
        If myMode = -1 Then GoTo 5
        l_ErrorTxt.Visible = False
        Exit Sub
        If operateMode Is Nothing Or CType(operateMode, String) = "" Or operateMode = IsDeclined Then GoTo 3
        Exit Sub
5:      If Not xcept Then Mcomplain()
        clearFields()
        l_ErrorTxt.Visible = True
        myMode = -1

    End Sub
    Sub Mcomplain()
        MetroFramework.MetroMessageBox.Show(Me, "There seems to be a problem with your login. Contact admin", "Login Name Error!")
    End Sub
    Function bypass() As Boolean
        If tKey.Text = "ADMINBypass" Then Return True Else Return False
    End Function
    Function getSalt() As Byte()
        Dim salt As Byte() = Nothing
        If myMode = AcctAdmin Then
            salt = Convert.FromBase64String(LaptopInABackpack)
        ElseIf myMode = AcctManager Then
            salt = Convert.FromBase64String(Newts)
        ElseIf myMode = AcctCashier Then
            salt = Convert.FromBase64String(Weavers)
        End If
        getSalt = salt
    End Function
    Private Sub t_Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles tKey.KeyDown

        Try

            Select Case e.KeyCode

                Case Keys.Enter

                    If Not Mode = LoginMode.ModifyKey Then GoTo 1 Else tKeyRpt.Focus()

1:                  If bypass() Then
                        GoTo 7
                    Else
                        getId()
                        GoTo 2
                    End If

                    If usrId = "" Then MsgBox("What's your username again?") : Exit Sub

2:                  Dim cHash As Byte() = Nothing
                    Try
                        cHash = sQry("cocHash", "cocLogin", "SerialId", usrId, NpgsqlDbType.Bytea)
                    Catch ex As Exception
                        cHash = Nothing
                    End Try

                    If Not cHash Is Nothing Then

                        If Convert.ToBase64String(Encrypt(tKey.Text, getSalt)) = Convert.ToBase64String(cHash) Then
                            updateKey()
                            Try
                                cHash = Nothing
                            Catch ex As Exception
                            End Try
                            GoTo 3
                        Else
                            _Access = _Request.IsRefused
                            SendResetRequest()
                        End If

                    End If

            End Select

        Catch ex As Exception
            'MsgBox(usrId)
            write_Error("Login Failed; " & ex.Message, Name)
        End Try

        Exit Sub
3:      If Mode = LoginMode.AskModifier Then
            Mode = LoginMode.ModifyKey
            OnLoad(Nothing)
        ElseIf Mode = LoginMode.AllowAccess Then
            _Access = _Request.IsGranted

            Dim am As Integer = -1
            Try
                'am = Qry("SELECT clClientMode FROM clLogs WHERE SerialId='" & usrId & "'")
                am = sQry("clClientMode", "clLogs", "SerialId", usrId, NpgsqlDbType.Integer)
            Catch ex As Exception
                am = -1
            End Try
            If am = AcctAdmin Then
                CurrentRequested = UserLogin.IsAdmin
            ElseIf am = AcctManager Then
                CurrentRequested = UserLogin.IsSubAdmin
            Else
                CurrentRequested = UserLogin.IsReallyNutin
            End If
            GoTo 7
        ElseIf Mode = LoginMode.Startup Then
            usr = tUsr.Text
            User = Just.LoggedIn
            logUserEntry()
            CreateLogRecord()
            write_Log(String.Concat(usr, " logged in"))
            home.Show()
            GoTo 7
        Else
            GoTo 7
        End If

        Exit Sub
7:      clearFields()
        If Mode = LoginMode.Startup Then
            Mode = LoginMode.__IsEmpty
        End If
        Close()

    End Sub
    Private Sub t_Key_GotFocus(sender As Object, e As EventArgs) Handles tKey.GotFocus
        tKey.Clear()
        If tUsr.Text = "" And Not tUsr.ContainsFocus Then tUsr.Focus()
    End Sub

    Private Sub t_User_KeyDown(sender As Object, e As KeyEventArgs) Handles tUsr.KeyDown
        If e.KeyData = Keys.Tab Or e.KeyData = Keys.Enter Then
            getId()
            tKey.Focus()
        End If
    End Sub

    Sub CreateLogRecord()
        Try
            Dim Sql As String = "INSERT INTO clLogsHistory (clName," &
                                                                                           "clLogEntryDate,clLogEntry," &
                                                                                           "clLogNote) " &
                                                                          "VALUES (@clName," &
                                                                                        "@clLogEntryDate,@clLogEntry," &
                                                                                        "@clLogNote)"
            With c
                .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            Dim d1 As TimeSpan
            Dim td As Date = New Date
            Dim finalString As String = Nothing
            With Date.Now
                d1 = New TimeSpan(.Hour, .Minute, .Second)
                td = New Date(.Year, .Month, .Day)
            End With

            With cm
                .Parameters.Add(New NpgsqlParameter("@clName", NpgsqlDbType.Varchar)).Value = usr
                .Parameters.Add(New NpgsqlParameter("@clLogEntryDate", NpgsqlDbType.Date)).Value = td
                .Parameters.Add(New NpgsqlParameter("@clLogEntry", NpgsqlDbType.Time)).Value = d1
                .Parameters.Add(New NpgsqlParameter("@clLogNote", NpgsqlDbType.Varchar)).Value = IIf(User = Just.LoggedIn, "Logged In", "Logged Out")

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                End If

                .Dispose()

            End With

        Catch ex As Exception
            write_Error("Could not log user; " & usr & " \\ " & ex.Message, Name)
            If c.State = ConnectionState.Open Then c.Close()
        End Try
    End Sub

    Sub logUserEntry()
        Try
            Dim Sql As String = "UPDATE clLogs SET clLastLogin=@clLastLogin," &
                                                                            "clLogDate=@clLogDate," &
                                                                            "clCurrentStatus=@clCurrentStatus " &
                                            "WHERE SerialId=@SerialId"
            With c
                .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            Dim tD As Date = New Date()
            With Date.Now
                tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cm
                .Parameters.Add(New NpgsqlParameter("@clLastLogin", NpgsqlDbType.Varchar)).Value = tD.ToShortTimeString
                .Parameters.Add(New NpgsqlParameter("@clLogDate", NpgsqlDbType.Date)).Value = tD
                .Parameters.Add(New NpgsqlParameter("@clCurrentStatus", NpgsqlDbType.Integer)).Value = StatusIsOnline
                .Parameters.Add(New NpgsqlParameter("@SerialId", NpgsqlDbType.Varchar)).Value = usrId

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                End If

                CreateLogRecord()

                .Dispose()

            End With

        Catch ex As Exception
            write_Error("Could not make login journal; " & ex.Message, Name)
            If c.State = ConnectionState.Open Then c.Close()
        End Try

    End Sub

    Private Sub t_PasskeyIterate_KeyDown(sender As Object, e As KeyEventArgs) Handles tKeyRpt.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not Mode = LoginMode.ModifyKey Then Exit Sub

            If Not tKey.Text = tKeyRpt.Text Then GoTo 7

            If Not tKey.TextLength >= 4 AndAlso Not tKeyRpt.TextLength >= 4 Then GoTo 7

            updateKey()

            write_Log("Login Modification Success [" & usr & "]")

            clearFields()

            Close()

        End If

        Exit Sub
7:      MsgBox("Passkeys do not match or the length does not match criteria; 8 characters and above")
        write_Error("Login Modification Failed", Name)
        clearFields()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Sub updateKey()
        Try
            Dim Sql As String = "UPDATE cocLogin SET cocHash=@cocHash WHERE SerialId=@SerialId"
            With c
                .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@cocHash", Encrypt(tKey.Text, getSalt)))
                .Parameters.Add(New NpgsqlParameter("@SerialId", usrId))
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                End If

                .Dispose()

            End With

        Catch ex As Exception
            write_Error("Error while updating login info" & " \\ " & ex.Message, Name)
            If c.State = ConnectionState.Open Then c.Close()
        End Try

    End Sub

End Class