Imports System.ComponentModel
Imports Npgsql
Imports NpgsqlTypes

Public Class Customers

    Sub clearFields()

        For i = 0 To Controls.Count - 1
            If TypeOf (Controls(i)) Is TextBox Then
                Dim f As TextBox = CType(Controls(i), TextBox)
                If f.Name.StartsWith("t_") Then
                    f.Clear()
                End If
            End If
        Next
        t_CreditLimit.Text = 0

    End Sub
    Sub getId()
        Dim r As String = Nothing
        If ThisMerchant = HereIs._New Then

            xQry("DELETE FROM clClients WHERE clName IS NULL OR clName=''")

            Dim f As Integer = 100000 + CInt(calcVal("SerialId",
                                "clClients",
                                CalcMode.GetCount,
                                c))

            r = String.Concat("C", CStr(f))

            Dim findName = Qry("SELECT clName FROM clClients WHERE SerialId='" & r & "'")

            If Not findName Is DBNull.Value Then
                r = f + 1
            Else
                r = f
            End If
            Dim d As String = String.Concat("C", r)
            xQry("INSERT INTO clClients (SerialId) VALUES ('" &
                     d &
                     "')",
                    c)

            CustId = d

            L_Edit.Visible = False

            btnDelete.Enabled = False

        Else

            Dim tbl As DataTable = Nothing



            L_Edit.Visible = True

            btnDelete.Enabled = True

            tbl.Dispose()



        End If

    End Sub
    Function IsMerchant() As Boolean
        Return CBool(ThisClient = IsA.Customer)
    End Function
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        Text = IIf(IsMerchant, "Merchants", "Suppliers")
        chkAllowPurchaseLimit.Visible = IsMerchant()
        clearFields()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        xQry("DELETE FROM clClients WHERE clName IS NULL OR clName=''")
        ThisMerchant = HereIs._Nothing
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If CustId = "" Then Exit Sub
        Dim mgRq As MsgBoxResult = MsgBox("Do you really want to delete record? This is irreversible", MsgBoxStyle.YesNo)
        If Not mgRq = MsgBoxResult.Yes Then Exit Sub
        Dim sS As String = String.Concat("Delete ", xQry("DELETE FROM clClients WHERE SerialId='" & CustId & "'"))
        clearFields()
        MsgBox(sS, MsgBoxStyle.Information)

    End Sub

    Private Sub t_PurchasePower_KeyPress(sender As Object,
                                         e As KeyPressEventArgs) Handles t_CreditLimit.KeyPress,
        t_Phone2.KeyPress,
        t_Phone1.KeyPress,
        t_Fax.KeyPress

        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete
                Exit Sub
            Case Else
                e.Handled = True
        End Select

    End Sub

End Class