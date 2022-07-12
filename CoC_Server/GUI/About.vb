Public Class About
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        With My.Application.Info
            header.Text = header.Tag & My.Application.Info.Version.ToString
            Version.Text = String.Concat("V", .Version.Major, " [Build ", .Version.Build, "]")
        End With

    End Sub

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If

    End Sub

End Class