Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports Npgsql
Imports NpgsqlTypes

Public Class Company_Ctrl

    Sub checkHQExists()

        If Company = AddMode.IsHQ Then
            btnSave.Visible = False
            Cnfg.Reload()
        ElseIf Company = AddMode.IsBranch Then
            btnSave.Visible = True
        End If

        'Exit Sub
        Dim r As Integer = -1
        Try
            r = calcVal("cmpBranchInfo", "companyData", CalcMode.GetCount, c, " WHERE cmpBranchInfo='HQ'")
        Catch ex As Exception
            r = -1
        End Try
        If Not r = -1 Then
            chkHQs.Enabled = False
        End If

    End Sub
    Sub DisposeIds()
        xQry("DELETE FROM companyData WHERE cmpName IS NULL OR  cmpName=''")

    End Sub
    Sub checkBranch()
        Try
            bInf = Qry("SELECT cmpBranchInfo FROM companyData WHERE SerialId='" & Id & "'")
        Catch ex As Exception
            bInf = ""
        End Try
        If Not bInf = "" Then
            If bInf = "HQ" Then
                chkHQs.Checked = True
            Else
                chkHQs.Checked = False
            End If
        Else
            chkHQs.Checked = False
        End If
    End Sub
    Sub initializeId()
        clearAll()
        If _Company = _AddMode.IsNew Then
            Id = SerialId()
            'Id = CnvHx()
            xQry("INSERT INTO companyData (SerialId) VALUES ('" & Id & "')")
        ElseIf _Company = _AddMode.IsOld Then
            If Company = AddMode.IsHQ Then
                Id = "HQ0001"
            End If
            loadSettings()
        End If
    End Sub

    Sub clearAll()
        t_Company.Text = ""
        t_Address.Text = ""
        t_OrganisationType.Text = ""
        t_Phone1.Text = ""
        t_Email.Text = ""
        If Not usrAvatar.Image Is Nothing Then usrAvatar.Image.Dispose()
    End Sub
    Sub JustReset()
        DisposeIds()
        If _This() = LoginIs.SubAdmin Then
            If Cnfg.subAdminModifyCompany = Cnfg.InActv Then
                MsgBox("You do not have the rights to do this. Sorry")
                Close()
                Exit Sub
            End If
        End If
        checkHQExists()
        initializeId()
        checkBranch()
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        JustReset()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        DisposeIds()
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            If Not Company = AddMode.IsHQ Then btnSave_Click(Nothing, Nothing)
        End If

    End Sub
    Private bInf As String = Nothing
    Sub loadSettings()
        Dim buffer As Byte() = Nothing

        clearAll()

        Try
            If Company = AddMode.IsHQ Then
                Cnfg.Reload()
                t_Company.Text = Cnfg.CompanyName
                t_Address.Text = Cnfg.CompanyAddress
                t_OrganisationType.Text = Cnfg.CompanyType
                t_Phone1.Text = Cnfg.CompanyPhone
                t_Email.Text = Cnfg.CompanyEmail

            Else
                Dim tbl As DataTable = xRead("SELECT cmpName,cmpAddress," &
                            "cmpType,cmpEmail,cmpPhone FROM companyData" &
                            " WHERE SerialId='" &
                            Id & "'",
                            "companyData")

                For Each row In tbl.Rows
                    t_Company.Text = row(0).ToString
                    t_Address.Text = row(1).ToString
                    t_OrganisationType.Text = row(2).ToString
                    t_Email.Text = row(3).ToString
                    t_Phone1.Text = row(4).ToString

                Next

            End If

            loadImage()

        Catch ex As Exception
            write_Error(ex.Message & "; settings load", Name)
        End Try

    End Sub
    Sub loadImage()
        Dim buffer As Byte() = Nothing

        Try

            Dim tbl As DataTable = xRead("SELECT cmpLogo FROM companyData" &
                            " WHERE SerialId='" &
                            Id & "'",
                            "companyData")

            For Each row In tbl.Rows
                If Not row(0) Is DBNull.Value Then
                    Using mStream As New MemoryStream(CType(row(0), Byte()))
                        usrAvatar.Image = Image.FromStream(mStream, True)   '
                    End Using
                End If

                'iByt = CType(row(5), Byte())
                'buffer = Convert.FromBase64String(Cnfg.CompanyLogo)
                'If iByt IsNot Nothing Then
                'Dim ic As New ImageConverter()
                'usrAvatar.Image = TryCast(ic.ConvertFrom(iByt), Image)
                'End If
            Next

        Catch ex As Exception
            write_Error(ex.Message & "; image load", Name)
        End Try

    End Sub
    Private IMG As String = ""
    Sub loadToSettings()

        Try

            '//
3:          Dim Sql As String = "UPDATE companyData SET cmpName=@cmpName," &
                                                                     "cmpAddress=@cmpAddress," &
                                                                     "cmpType=@cmpType," &
                                                                     "cmpEmail=@cmpEmail," &
                                                                     "cmpPhone=@cmpPhone," &
                                                                     "cmpBranchInfo=@cmpBranchInfo " &
                                                                     "WHERE SerialId='" & Id & "'"
            With c
                If Not .State = ConnectionState.Open Then .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@cmpName", NpgsqlDbType.Varchar)).Value = t_Company.Text
                .Parameters.Add(New NpgsqlParameter("@cmpAddress", NpgsqlDbType.Varchar)).Value = t_Address.Text
                .Parameters.Add(New NpgsqlParameter("@cmpType", NpgsqlDbType.Varchar)).Value = t_OrganisationType.Text
                .Parameters.Add(New NpgsqlParameter("@cmpEmail", NpgsqlDbType.Varchar)).Value = t_Email.Text
                .Parameters.Add(New NpgsqlParameter("@cmpPhone", NpgsqlDbType.Varchar)).Value = t_Phone1.Text
                .Parameters.Add(New NpgsqlParameter("@cmpBranchInfo", NpgsqlDbType.Varchar)).Value = IIf(Company = AddMode.IsHQ, "HQ", "Annex")
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    With c
                        If Not .State = ConnectionState.Closed Then .Close()
                    End With

                    If Company = AddMode.IsHQ Then
                        Cnfg.CompanyName = t_Company.Text
                        Cnfg.CompanyAddress = t_Address.Text
                        Cnfg.CompanyType = t_OrganisationType.Text
                        Cnfg.CompanyPhone = t_Phone1.Text
                        Cnfg.CompanyEmail = t_Email.Text
                        Cnfg.CompanyLogo = IMG
                        Cnfg.Save()

                        home.l_CompanyDetails.Text = String.Concat(Cnfg.CompanyName, " [", Cnfg.CompanyAddress, "]")

                    Else
                        MsgBox("Saved!")
                    End If

                    JustReset()

                End If
            End With
        Catch ex As Exception
            If Not c.State = ConnectionState.Closed Then c.Close()
            write_Error(ex.Message & "; settings call", Name)
        End Try

    End Sub

    Sub UpdateImage() Handles usrAvatar.Click, modifyAvatar.Click
        Dim IMG As String = ""
        Try
            Dim fi As Image = Image.FromFile(OpenDiag)
            'usrAvatar.Image = Image.FromFile(OpenDiag)
            If fi Is Nothing Then Exit Sub
            'Dim ic As New ImageConverter()
            Dim buffer As Byte() = Nothing ' DirectCast(ic.ConvertTo(usrAvatar.Image, GetType(Byte())), Byte())
            'IMG = Convert.ToBase64String(buffer, Base64FormattingOptions.InsertLineBreaks)

            buffer = BreakImgToByt(fi)

            Dim Sql As String = "UPDATE companyData SET cmpLogo=@cmpLogo " &
                                                                     "WHERE SerialId='" & Id & "'"
            With c
                .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@cmpLogo", NpgsqlDbType.Bytea)).Value = buffer
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    loadImage()
                End If
            End With

        Catch ex As Exception
            write_Error("Image write error" & ex.Message, Name)
        End Try

    End Sub

    Sub inFocus()
        loadSettings()
    End Sub
    Sub outFocus(box As Object)
        If box.Text = NullVal Then inFocus() : Exit Sub
        loadToSettings()
    End Sub
    Private Sub tGBoxes(sender As Object, e As EventArgs) Handles t_Company.GotFocus,
        t_Address.GotFocus,
        t_Phone1.GotFocus,
        t_OrganisationType.GotFocus,
        t_Email.GotFocus

        inFocus()

    End Sub
    Private Sub tLBoxes(sender As Object, e As EventArgs) Handles t_Company.LostFocus,
        t_Address.LostFocus,
        t_Phone1.LostFocus,
        t_OrganisationType.LostFocus,
        t_Email.LostFocus

        outFocus(DirectCast(sender, TextBox))

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If t_Phone1.Text = "" Then t_Phone1.Text = 0
        If t_Company.Text = "" Then MsgBox("Please provide a name", MsgBoxStyle.Information) : Exit Sub
        loadToSettings()
    End Sub

    Private Sub t_Company_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Company.KeyDown
        If e.KeyCode = Keys.Enter Then
            t_Address.Focus()
        End If

    End Sub
    Private Sub t_Address_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Address.KeyDown
        If e.KeyCode = Keys.Enter Then
            t_OrganisationType.Focus()
        End If

    End Sub
    Private Sub t_OrganisationType_KeyDown(sender As Object, e As KeyEventArgs) Handles t_OrganisationType.KeyDown
        If e.KeyCode = Keys.Enter Then
            t_Phone1.Focus()
        End If

    End Sub
    Private Sub t_Phone1_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Phone1.KeyDown
        If e.KeyCode = Keys.Enter Then
            t_Email.Focus()
        End If

    End Sub
    Private Sub t_Email_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Email.KeyDown
        If e.KeyCode = Keys.Enter Then
            t_Company.Focus()
        End If

    End Sub

End Class