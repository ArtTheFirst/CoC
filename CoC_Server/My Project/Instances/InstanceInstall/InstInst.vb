Public Class InstInst

    Protected pth As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\init\pv12")
    Protected initdata As New IO.DirectoryInfo(String.Concat(pth.ToString, "\data"))
    Protected initinstall As New IO.DirectoryInfo(String.Concat(pth.ToString, "\install"))
    Protected InstanceArg As String = ""

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        InstanceArg = "/C " &
                              "instance\postgresql-12.2-2-windows-x64.exe" &
                              " --mode unattended" &
                              " --unattendedmodeui minimalWithDialogs" &
                              " --enable-components server,pgAdmin,commandlinetools" &
                              " --install_runtimes 1" &
                              " --superaccount postgres" &
                              " --superpassword 47T3r@byt3s" &
                              " --prefix " & initinstall.ToString &
                              " --datadir " & initdata.ToString &
                              " --create_shortcuts 1"

        If Not pth.Exists Then pth.Create()

        If Not initdata.Exists Then initdata.Create()

        If Not initinstall.Exists Then initinstall.Create()

        'MsgBox(InstanceArg2)

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
