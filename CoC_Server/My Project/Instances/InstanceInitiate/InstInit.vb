Public Class InitiateInst

    Private dQ As String = ControlChars.Quote

    Private prog As String = "pg_ctl.exe"
    Private arg1 As String = " -D"
    Private progPath As String = String.Concat(dQ, "coc_serv\data", dQ)
    Private arg2 As String = " -l"
    Private logpath As String = "coc_serv\log\psql.log"
    Private logarg As String = String.Concat(dQ, logpath, dQ)
    Private arg3 As String = " start"
    Private InstanceArg As String = String.Concat("/C ", prog,
                                                                            arg1,
                                                                            progPath,
                                                                            arg2,
                                                                            logpath,
                                                                            logarg,
                                                                            arg3)

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Dim sqlInstanceInfo As New ProcessStartInfo
        With sqlInstanceInfo
            .FileName = "cmd.exe"
            .Verb = "runas"
            .UseShellExecute = False
            .Arguments = InstanceArg
        End With
        Dim p As Process = New Process
        p.StartInfo = sqlInstanceInfo
        p.Start()

        Close()

    End Sub

End Class
