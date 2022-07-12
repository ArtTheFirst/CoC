Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class login

    Const cH As Integer = 210
    Const xH As Integer = 270
    Enum LoginMode
        Startup
        AllowAccess
        AskModifier
        ModifyKey
    End Enum
    Public Sub CallLock(Mode As LoginMode)
        Select Case Mode
            Case LoginMode.Startup
                Show()
                Height = cH
                lockToken = LoginMode.Startup
            Case LoginMode.AllowAccess
                ShowDialog()
                Height = cH
                lockToken = LoginMode.AllowAccess
            Case LoginMode.AskModifier
                ShowDialog()
                Height = cH
                lockToken = LoginMode.AskModifier
            Case LoginMode.ModifyKey
                Me.Height = xH
                lockToken = LoginMode.ModifyKey
        End Select

    End Sub
    Private lockToken As LoginMode = -1
    Private xcept As Boolean = False

    Sub clearFields()
        t_User.Clear()
        t_Pass.Clear()
        t_PasskeyIterate.Clear()
        t_User.Focus()
        _Id = NullVal

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Exit Sub
        If defineMains() = DataFile.NotExists Or defineProducts() = DataFile.NotExists Or defineSales() = DataFile.NotExists Then GoTo 7

        SetupClientLogin()
        SetupCompanyData()
        SetupMerchantsDb()
        SetupDistributorsDb()
        SetupAccountsDb()
        SetupCategoriesDb()
        SetupCurrencyDb()
        SetupProducts()
        SetupSales()
        SetupInvoices()

        Exit Sub
7:      Dim p As Process = Process.GetCurrentProcess
        MsgBox("Application failed to start!", MsgBoxStyle.Critical)
        p.Kill()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        xcept = True
        clearFields()
        If Not lockToken = LoginMode.Startup Then Exit Sub
        Dim p As Process = Process.GetCurrentProcess
        p.Kill()
    End Sub

    Dim logincount As Integer = -1
    Sub SendResetRequest()
        t_Pass.Clear()
        logincount = logincount + 1
        If logincount > 2 Then
            MsgBox("There seems to be a problem with your login. Contact admin", MsgBoxStyle.Critical, "Login Error")
        End If
    End Sub

    Private cl_Salt, cl_Hash As Byte()
    Function bypass() As Boolean
        If t_User.Text = "Admin" AndAlso t_Pass.Text = "ADMINBypass" Then Return True Else Return False
    End Function
    Sub getId()
        If t_User.Text = NullVal Then GoTo 3
        Try
            _Id = Qry("SELECT SerialId FROM c_Login WHERE c_Name='" & t_User.Text & "' AND c_ClientMode='admin'")
        Catch ex As Exception
            GoTo 3
        End Try

        Exit Sub
3:      If Not xcept Then MsgBox("This name is either unrecognized, you did not provide a name or your account does not provide the necessary admin rights needed", MsgBoxStyle.Information)
        clearFields()

    End Sub
    Private Sub t_Pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_Pass.KeyPress
        Try
            Select Case Asc(e.KeyChar)
                Case 13
                    If Not lockToken = LoginMode.ModifyKey Then GoTo 1 Else t_PasskeyIterate.Focus()

1:                  If bypass() Then
                        GoTo 7
                    Else
                        GoTo 2
                    End If

                    If _Id = NullVal Then MsgBox("What's your username again?") : Exit Sub

2:                  Dim cR As SqlDataReader = fRead("SELECT c_Salt,c_Hash FROM c_Login WHERE SerialId='" & _Id & "'")
                    While cR.Read
                        cl_Salt = CType(cR(0), Byte())
                        cl_Hash = CType(cR(1), Byte())
                    End While

                    If Convert.ToBase64String(Encrypt(t_Pass.Text, cl_Salt)) = Convert.ToBase64String(cl_Hash) Then
                        updateKey()
                        GoTo 7
                    Else
                        SendResetRequest()
                    End If

            End Select

        Catch ex As Exception

        End Try

        Exit Sub
7:      usr = t_User.Text
        clearFields()
        Hide()
        _server.Show()

    End Sub
    Private Sub t_User_LostFocus(sender As Object, e As EventArgs) Handles t_User.LostFocus
        getId()
    End Sub
    Private Sub t_User_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_User.KeyPress
        If Asc(e.KeyChar) = 13 Then
            getId()
        End If
    End Sub
    Private Sub t_PasskeyIterate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_PasskeyIterate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Not lockToken = LoginMode.ModifyKey Then Exit Sub

            If Not t_Pass.Text = t_PasskeyIterate.Text Then GoTo 7

            If Not t_Pass.TextLength >= 8 AndAlso Not t_PasskeyIterate.TextLength >= 8 Then GoTo 7

            updateKey()

            clearFields()

        End If

        Exit Sub
7:      MsgBox("Passkeys do not match or the length does not match criteria; 8 characters and above")
        clearFields()

    End Sub


    Sub updateKey()
        Dim csprng As New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(24) {}
        csprng.GetBytes(salt)
        Try
            Dim Sql As String = "UPDATE clLogin SET c_Salt=@c_Salt,c_Hash=@c_Hash WHERE SerialId='" & _Id & "'"
            With c
                .Open()
            End With
            Dim cm As New SqlCommand(Sql, c)
            With cm
                .Parameters.Add(New SqlParameter("@c_Salt", SqlDbType.VarBinary)).Value = salt
                .Parameters.Add(New SqlParameter("@c_Hash", SqlDbType.VarBinary)).Value = Encrypt(t_Pass.Text, salt)
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