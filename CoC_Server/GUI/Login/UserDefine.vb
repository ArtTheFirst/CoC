Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class UserDefine

    Sub getUnit() Handles rdCashier.CheckedChanged, rdSubAdmin.CheckedChanged
        If Not rdCashier.Checked Or rdSubAdmin.Checked Then Exit Sub

        Dim mode As String = IIf(rdCashier.Checked, "cashier", "admin")
        Dim tbl As DataTable = xRead("SELECT * FROM c_Login WHERE c_ClientMode='" & mode & "'", "c_login", c)
        Dim tC As Integer = tbl.Rows.Count
        Dim ul As Integer = IIf(rdCashier.Checked, cashierlimit, subadminlimit)
        If tC = ul Then
            MsgBox("Maximum account limit has been reached!", MsgBoxStyle.Information)
        Else
            tC = tC + 1
        End If

        t_Name.Text = IIf(rdCashier.Checked, "cashier", "admin") & tC

    End Sub

    Sub clearFields()
        t_Name.Clear()
        t_Key1.Clear()
        t_Key2.Clear()
        l_Status.Text = "match status/strength"

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        clearFields()
        getUnit()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        clearFields()

    End Sub

    Private Sub t_Key1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles t_Key1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            t_Key2.Focus()
        End If
    End Sub
    Private Sub t_Key1_TextChanged(sender As Object, e As EventArgs) Handles t_Key1.TextChanged
        l_Status.Text = IIf(t_Key1.Text.Length >= 8, "Key length strong", "Key too weak")
    End Sub
    Private Sub t_Key2_TextChanged(sender As Object, e As EventArgs) Handles t_Key2.TextChanged
        l_Status.Text = "keys" & IIf(t_Key1.Text = t_Key2.Text, " match", " do not match!")
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If Not rdCashier.Checked Or rdSubAdmin.Checked Then GoTo 7
        Dim mode As String = IIf(rdCashier.Checked, "cashier", "admin")
        If t_Key1.Text.Length < 8 Then GoTo 7

        If Not t_Key1.Text = t_Key2.Text Then GoTo 7

        Dim chk As String = Qry("SELECT SerialId FROM c_Login WHERE c_Name='" & t_Name.Text & "'")
        If Not chk = NullVal Then GoTo 7

        Dim csprng As New RNGCryptoServiceProvider()
        Dim salt As Byte() = New Byte(24) {}
        csprng.GetBytes(salt)
        Try
            Dim Sql As String = "INSERT INTO clLogin (c_Name,SerialId,c_ClientMode,c_Salt,c_Hash,c_ActivateMode" &
                                                                                    ")" &
                                                                    " VALUES (@c_Name,@SerialId,@c_ClientMode@c_Salt,@c_Hash,@c_ActivateMode" &
                                                                                   ")"
            With c
                .Open()
            End With
            Dim cm As New SqlCommand(Sql, c)
            With cm
                .Parameters.Add(New SqlParameter("@c_Name", SqlDbType.VarChar)).Value = t_Name.Text
                .Parameters.Add(New SqlParameter("@c_Salt", SqlDbType.VarBinary)).Value = salt
                .Parameters.Add(New SqlParameter("@c_Hash", SqlDbType.VarBinary)).Value = Encrypt(t_Key1.Text, salt)
                .Parameters.Add(New SqlParameter("@c_ClientMode", SqlDbType.VarChar)).Value = mode
                .Parameters.Add(New SqlParameter("@c_ActivateMode", SqlDbType.VarChar)).Value = "ALLOWED"
                .Parameters.Add(New SqlParameter("@SerialId", SqlDbType.VarChar)).Value = SerialId()
                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    c.Close()
                    Close()
                End If
            End With

        Catch ex As Exception
            If c.State = ConnectionState.Open Then c.Close()
        End Try

        Exit Sub
7:      MsgBox("Something's not quite right!", MsgBoxStyle.Critical)

    End Sub

End Class