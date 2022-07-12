Imports System.ComponentModel

Public Class SettingsCtrl

    Sub checkIp()
        With My.Settings
            t_Server.Text = .ServerIpAddress
            Dim stat As String = Nothing
            Try
                stat = IIf(My.Computer.Network.Ping(.ServerIpAddress), "online", "offline")
            Catch ex As Exception
                stat = "unreachable"
            End Try
            l_Server.Text = String.Concat("server at ", .ServerIpAddress, "[", stat, "]")

        End With

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        checkIp()

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        With My.Settings
            If t_Server.Text = "" Or
                t_Server.Text.IndexOf(".") < 2 Or
                My.Computer.Network.Ping(t_Server.Text) = False Or t_Server.Text.Length < 11 Then
                MsgBox("Ip Address not correct or is empty!", MsgBoxStyle.Critical)
            Else
                .ServerIpAddress = t_Server.Text
                .Save()
                checkIp()
            End If

        End With

    End Sub

End Class