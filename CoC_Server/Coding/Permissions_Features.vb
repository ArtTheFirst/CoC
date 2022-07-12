Imports System.Data.SqlClient
Imports System.Management
Imports System.Security.Cryptography
Imports Npgsql
Imports NpgsqlTypes

Module Permissions_Features

    Public Function fetchId() As String
        Dim csprng As New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(256) {}
        csprng.GetBytes(salt)
        fetchId = Convert.ToBase64String(salt)
    End Function

    Public Newts As String = "6IBU+c3OoVbwrcV9lLvF9Q5A9NrYv7wo8hCJ6/Jkv+OplTqmsvIDCW/p0wlOOiRJakm" &
        "HjQxsLIEeORlYkNhyjn4+k01sCNfdu8YMiSEwlZF1XWXTQVXXeL8d4ZB4IlcKWol+oRHoPeVV7JpBlVBNGtBpyqVWkaCoVzMIMxXCRGft5NigVnTp6RTywkibqBX3pi6wc0BQze7xyvv1BSVjEmMmdb6lRV1wjDYTRtl6j8uihTeNDj2o1GJTaK3FnZCwqjYAGmOfhnEbckPVpceo6Y3WUQhSky3BmTubWyOSAnu/DkGfsN+C1cUtIK+c" &
                                                               "acoKPtrZ80Uayvd4S86GAb5uc2A="
    Public Weavers As String = "JIYEWax3wi4MfAREjpqUsxshtLG0sfkwWlqR0Aym3LrdClYGSaHtR4G14wIm2Jv1Sw" &
        "hdx727A2/dmidcJbJO3srZhirw0YmxPfWJNEQy+Ur8Brb+6jvllhzKj/1/DzsPnN1JU5UkspS9eMhtw6bEfUXeGe+O1+xCRrPl+EMsf04fgl1oFdxaPbdGwepwyrYCt+unUrOzcUcvX5WoGbpECYL2X5t40eW2AohgNJJP/rMClzz0nGUPcn4yhjLV2cFPR0Hg3UScSPBUMuHxgz88+TrY4m02z8Zo7aEiKgHcjXSQCgZndr1cxFQNiiDkZUTTNM0" &
                                                              "8Z4xz6lSzf6MrV1f/J6k="
    Public LaptopInABackpack As String = "XisfJtBw6aRJrPmBEkKf77FSdY1SJLMkV7kJrUWgEFiwXzovL22HNgr4++sKMyy2wUduSFk5Zo3uOra2TP+0W4yFSEYVGgavTrf4qE0bCdvUKBwweNAVMhwJ4Ki65Zj6XNMl/DNFqSOlqzADdtZabCkxJd8LiiScsvFQDmtLInA9kvIS0VNWgaZBkM7/kLxqhVm22ZqnAnKJ31sKZ4+TeX7xxpa2Njr+FCTszTGfNPIUtKT+Vy1Xi011xw/KICTi0v0NUw0rLVczIqXCWz6spvZyHkPGbsxcdkpt/+kdiPvSrOseD2" &
                                                               "sKuAw6V7y4b2p0X2klCzfRfbdfM2IPWgrJJl0="
    Public Sub logUserExit()
        Try
            Dim Sql As String = "UPDATE clLogs SET clLastLogout=@clLastLogout," &
                                                "clCurrentStatus=@clCurrentStatus WHERE clName='" & usr & "'"
            With c
                .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clLastLogout", NpgsqlDbType.Varchar)).Value = Date.Now.ToShortTimeString
                .Parameters.Add(New NpgsqlParameter("@clCurrentStatus", NpgsqlDbType.Integer)).Value = StatusIsOffline
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    User = Just.LoggedOut
                    login.CreateLogRecord()
                End If
            End With

        Catch ex As Exception
            write_Error("Could not make logout journal; " & ex.Message, "logout")
            If c.State = ConnectionState.Open Then c.Close()
        End Try

    End Sub

    Public licensedays As Integer = 0
    Public licenseinfo As String = Nothing
    Public Const licenseerrormsg As String = "Your license has expired and you will no longer be able to use this app's full features."
    Public Sub complain()
        ShowMessage("You do not have access to do this! Sorry", _Method.AsError)
    End Sub
    Public Sub loadDays()

        Dim diff As Integer = 0

        Dim d1 As Date

        With Date.Now
            d1 = New Date(.Year, .Month, .Day, 23, 59, 59)
        End With

        Dim d2 As Date = CDate(My.Settings.LicenseDate)
        Dim dff As TimeSpan = d1.Subtract(d2)
        Dim totaldays As Integer = dff.TotalDays

        If totaldays <= 30 Then
            diff = 30 - totaldays
        ElseIf totaldays < 1 Then
            diff = 0
        ElseIf totaldays > 30 Then

            If totaldays >= 365 Then
                diff = totaldays / 365
            Else
                diff = totaldays
            End If
        End If

        licensedays = IIf(diff < 1, 0, diff)

        Dim finaldiff As Integer = 0
        Cnfg.Reload()
        If Not Cnfg.LicenseActive = Cnfg.Actv Then
            If licensedays > 31 Then
                finaldiff = 0
            Else
                finaldiff = licensedays
            End If
        End If

        licenseinfo = String.Concat(finaldiff, Space(1),
                                    IIf(finaldiff >= 365, "Year", "Day"),
                                    IIf(finaldiff <= 1, "",
                                        "s"), Space(1),
                                    "Left On License")

    End Sub

    Enum LoginIs
        Admin
        SubAdmin
        Client
        ___SadlyNothing
    End Enum
    Public Function _This() As LoginIs
        Dim q As Integer = -1
        Dim r As LoginIs = LoginIs.___SadlyNothing
        Try
            q = sQry("clClientMode", "clLogs", "clName", usr, NpgsqlDbType.Integer)
        Catch ex As Exception
            q = -1
        End Try

        If q = AcctAdmin Then
            r = LoginIs.Admin
        ElseIf q = AcctManager Then
            r = LoginIs.SubAdmin
        ElseIf q = AcctCashier Then
            r = LoginIs.Client
        Else
            r = LoginIs.___SadlyNothing
        End If
        _This = r
    End Function

    Enum UserLogin
        IsAdmin
        IsSubAdmin
        IsReallyNutin
    End Enum
    Public CurrentRequested As UserLogin = UserLogin.IsReallyNutin

    Enum Just
        LoggedIn
        LoggedOut
        __DidNothing
    End Enum
    Public User As Just = Just.__DidNothing

    Enum AddMode As Integer
        IsHQ = 100
        IsBranch = 101
        IsNothing = 0
    End Enum
    Public Company As AddMode = AddMode.IsNothing

    Enum _Method
        AsInfo
        AsError
    End Enum
    Public Sub ShowMessage(Info As String, Popup As _Method)
        Select Case Popup
            Case _Method.AsError
                MsgBox(Info, MsgBoxStyle.Critical, "Cy POS")
            Case _Method.AsInfo
                MsgBox(Info, MsgBoxStyle.Information, "Cy POS")
        End Select
    End Sub

End Module
