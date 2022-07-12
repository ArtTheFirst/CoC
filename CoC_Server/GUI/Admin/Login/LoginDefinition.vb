Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports Npgsql
Imports NpgsqlTypes

Public Class LoginDefinition

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        disposeThisId()
        PId = NullVal
        clearAll()
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyCode = Keys.F1 Then
            btnProceed.PerformClick()
        ElseIf e.KeyCode = Keys.F5 Then
            btnClear.PerformClick()
        ElseIf e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        disposeThisId()
        InitializeId()
    End Sub
    Sub disposeThisId()
        xQry("DELETE FROM clLogs WHERE clName IS NULL OR clName=''")
        xQry("DELETE FROM cocLogin WHERE cocName IS NULL OR cocName=''")
        xQry("DELETE FROM clContacts WHERE clName IS NULL OR clName=''")
    End Sub
    Sub clearAll() Handles btnClear.Click
        lUsrId.Text = lUsrId.Tag
        t_Fullname.Clear()
        tUsr.Clear()
        tKey.Clear()
        c_AAL.Text = ""
        l_KeyNotice.Visible = False
        lUsrId.Visible = False
    End Sub
    Function UserIsValid() As Boolean
        Dim r As Boolean = False
        Dim f As String = "'"
        Try
            'f = Qry("SELECT clName FROM clLogs WHERE SerialId='" & PId & "'")
            f = sQry("clName", "clLogs", "SerialId", PId, NpgsqlDbType.Varchar)
        Catch ex As Exception
            f = ""
        End Try
        If f = "" Then r = False Else r = True
        Return r
    End Function

    Function IsAllOk() As Boolean
        Dim r As Boolean = False
        r = Not t_Fullname.Text Is NullVal AndAlso
             Not tUsr.Text = NullVal AndAlso
             Not tKey.Text Is NullVal AndAlso
             Not c_AAL.Text IsNot NullVal
        Return r
    End Function

    Dim PId As String
    Sub InitializeId()
        clearAll()
        If ThisUser = HereIs._New Then
            btnClear.Enabled = True
            PId = SerialId()
            xQry("INSERT INTO clLogs (SerialId) VALUES ('" & PId & "')")
            xQry("INSERT INTO cocLogin (SerialId) VALUES ('" & PId & "')")
            xQry("INSERT INTO clContacts (SerialId) VALUES ('" & PId & "')")
        ElseIf ThisUser = HereIs._Old Then
            btnClear.Enabled = False
            PId = Id
            Id = NullVal
            loadDataFromId()
        End If

    End Sub

    Sub loadDataFromId()
        Try
            Dim tbl As DataTable = xRead("SELECT clName," &
                                                                     "clClientMode," &
                                                                     "clCanOperate " &
                                                        "FROM clLogs " &
                                                        "WHERE SerialId='" & PId & "'",
                                         "clLogs",)
            For Each row As DataRow In tbl.Rows
                tUsr.Text = row(0).ToString

                Dim cTxt As String = ""

                Dim EM As Integer = -1
                Select Case CType(row(1), Integer)
                    Case AcctAdmin
                        cTxt = c_AAL.Items.Item(1).ToString
                    Case AcctManager
                        cTxt = c_AAL.Items.Item(2).ToString
                    Case AcctCashier
                        cTxt = c_AAL.Items.Item(3).ToString
                    Case Else
                        cTxt = c_AAL.Items.Item(0).ToString
                End Select

                c_AAL.Text = cTxt

                If CType(row(2), Integer) = IsApproved Then
                    chkCanLogin.Checked = True
                ElseIf CType(row(2), Integer) = IsDeclined Then
                    chkCanLogin.Checked = False
                End If

            Next

            tbl.Dispose()

            tbl = New DataTable
            tbl = xRead("SELECT clName " &
                               "FROM clContacts " &
                               "WHERE SerialId='" & PId & "'",
                        "clContacts",)
            For Each row As DataRow In tbl.Rows
                t_Fullname.Text = row(0).ToString
            Next

            tbl.Dispose()

            l_KeyNotice.Visible = True

            lUsrId.Visible = True

            lUsrId.Text = String.Concat(lUsrId.Tag, PId)

        Catch ex As Exception
            write_Error("error while loading data", Name)
        End Try

    End Sub
    Function FieldsOk() As Boolean
        Return Not t_Fullname.Text Is NullVal AndAlso
                   Not tUsr.Text Is NullVal
    End Function
    Function getSalt() As Byte()
        Dim salt As Byte() = Nothing
        Dim myMode As Integer = -1
        Try
            myMode = sQry("clClientMode", "clLogs", "SerialId", PId, NpgsqlDbType.Integer)
        Catch ex As Exception
            myMode = -1
        End Try
        If myMode = AcctAdmin Then
            salt = Convert.FromBase64String(LaptopInABackpack)
        ElseIf myMode = AcctManager Then
            salt = Convert.FromBase64String(Newts)
        ElseIf myMode = AcctCashier Then
            salt = Convert.FromBase64String(Weavers)
        End If
        getSalt = salt
    End Function
    Sub Upload() Handles btnProceed.Click

        If ThisUser = HereIs._Old Then If Not FieldsOk() Then Exit Sub
        Dim UpdRq As MsgBoxResult
        Dim CanChange As Boolean = False

        UpdRq = MsgBox("'Proceed?", MsgBoxStyle.OkCancel)
        If Not UpdRq = MsgBoxResult.Ok Then Exit Sub

        If ThisUser = HereIs._Old Then
            If Not tKey.Text = "" Then
                UpdRq = MsgBox("'Update password?", MsgBoxStyle.YesNo)
                If Not UpdRq = MsgBoxResult.Yes Then CanChange = True
            End If
        End If

        Try

            Dim canUpOld As Boolean = (ThisUser = HereIs._Old And CanChange)

            Dim sqUp As String = IIf(ThisUser = HereIs._New Or canUpOld, ",cocHash=@cocHash", "") & Space(1)

            Dim Sql As String = "UPDATE cocLogin SET cocName=@cocName" &
                                                                             sqUp &
                                            "WHERE SerialId=@SerialId"
            With c 'pid
                If Not .State = ConnectionState.Open Then .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@cocName", tUsr.Text))
                If ThisUser = HereIs._New Or canUpOld Then
                    .Parameters.Add(New NpgsqlParameter("@cocHash", Encrypt(tKey.Text, getSalt)))
                    .Parameters.Add(New NpgsqlParameter("@SerialId", PId))
                End If

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    If Not c.State = ConnectionState.Closed Then c.Close()
                End If

                .Dispose()

            End With

            sqUp = IIf(ThisUser = HereIs._New Or canUpOld, ",clCanOperate=@clCanOperate," &
                                                                                          "clCurrentStatus=@clCurrentStatus", "") & Space(1)

            Sql = "UPDATE clLogs SET clName=@clName,clClientMode=@clClientMode" &
                                                     sqUp &
                                            "WHERE SerialId=@SerialId"
            With c 'pid
                If Not .State = ConnectionState.Open Then .Open()
            End With
            cm = New NpgsqlCommand(Sql, c)
            Dim tD As Date = New Date()
            With Date.Now
                tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
            End With
            With cm
                .Parameters.Add(New NpgsqlParameter("@clName", tUsr.Text))

                Dim r As Integer = -1
                Select Case c_AAL.Text
                    Case c_AAL.Items.Item(1).ToString
                        r = AcctAdmin
                    Case c_AAL.Items.Item(2).ToString
                        r = AcctManager
                    Case c_AAL.Items.Item(3).ToString
                        r = AcctCashier
                End Select

                .Parameters.Add(New NpgsqlParameter("@clClientMode", r))

                If ThisUser = HereIs._New Or canUpOld Then

                    Dim dy As Integer = -1
                    If chkCanLogin.CheckState = CheckState.Checked Then
                        dy = IsApproved
                    ElseIf chkCanLogin.CheckState = CheckState.Unchecked Then
                        dy = IsDeclined
                    End If
                    .Parameters.Add(New NpgsqlParameter("@clCanOperate", dy))
                    .Parameters.Add(New NpgsqlParameter("@clCurrentStatus", StatusIsSuspended))
                    .Parameters.Add(New NpgsqlParameter("@SerialId", PId))

                End If

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    If Not c.State = ConnectionState.Closed Then c.Close()
                End If

                .Dispose()

            End With

            If ThisUser = HereIs._Old Then If t_Fullname.Text Is NullVal Then GoTo 7

            Sql = "UPDATE clContacts SET clName=@clName " &
                                            "WHERE SerialId=@SerialId"
            With c
                If Not .State = ConnectionState.Open Then .Open()
            End With
            cm = New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clName", t_Fullname.Text))
                .Parameters.Add(New NpgsqlParameter("@SerialId", PId))

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    If Not c.State = ConnectionState.Closed Then c.Close()
                End If

                .Dispose()

                GoTo 7

            End With

            If ThisUser = HereIs._Old Then Exit Sub

7:          MsgBox(IIf(ThisUser = HereIs._New, "Save ", "Update ") & "Done!")

            clearAll()

            Close()

        Catch ex As Exception
            write_Error(ex.Message, Name)
            If c.State = ConnectionState.Open Then c.Close()
        End Try

    End Sub

    Private Sub chkCanLogin_CheckedChanged(sender As Object, e As EventArgs) Handles chkCanLogin.CheckedChanged
        If Not ThisUser = HereIs._Old Then Exit Sub

        If Not UserIsValid() Then Exit Sub

        Dim dy As Integer = -1
        If chkCanLogin.CheckState = CheckState.Checked Then
            dy = IsApproved
        ElseIf chkCanLogin.CheckState = CheckState.Unchecked Then
            dy = IsDeclined
        End If
        Try
            Dim Sql As String = "UPDATE clLogs SET clCanOperate=@clCanOperate WHERE SerialId=@SerialId"
            With c
                .Open()
            End With
            Dim cm As NpgsqlCommand = New NpgsqlCommand(Sql, c)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clCanOperate", dy))
                .Parameters.Add(New NpgsqlParameter("@SerialId", PId))
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                End If

                .Dispose()

            End With

        Catch ex As Exception
            If c.State = ConnectionState.Open Then c.Close()
        End Try
    End Sub

    Private Sub t_Fullname_KeyDown(sender As Object, e As KeyEventArgs) Handles t_Fullname.KeyDown, tUsr.KeyDown, tKey.KeyDown, c_AAL.KeyDown
        If e.KeyCode = Keys.Enter Then
            If t_Fullname.Focused Then
                tUsr.Focus()
            ElseIf tUsr.Focused Then
                tKey.Focus()
            ElseIf tKey.Focused Then
                c_AAL.Focus()
            ElseIf c_AAL.Focused Then
                btnProceed.PerformClick()
            End If
        End If
    End Sub

End Class