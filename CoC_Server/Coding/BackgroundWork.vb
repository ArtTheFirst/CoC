Imports System.ComponentModel

Module BackgroundWork

    Private prgFrm As New Form
    Private prgBar As New ProgressBar

    Sub setupControls(Optional ByVal StatusMessage As String = "Loading")
        If prgFrm.IsDisposed Then
            prgFrm = New Form
            prgBar = New ProgressBar
        End If

        With prgFrm
            .Size = New Size(320, 91)
            .StartPosition = FormStartPosition.CenterScreen
            .BackColor = Color.White
            .AutoScaleMode = AutoScaleMode.None
            .MaximizeBox = False
            .MinimizeBox = False
            .FormBorderStyle = FormBorderStyle.FixedToolWindow
            .ControlBox = False
            .Text = StatusMessage
            .Cursor = Cursors.WaitCursor
            .ShowIcon = False
            .ShowInTaskbar = False

        End With
        AddHandler prgFrm.Click, AddressOf clkStop
        With prgBar
            .Maximum = 100
            .Minimum = 0
            .MarqueeAnimationSpeed = 10
            .Style = ProgressBarStyle.Continuous
            .Size = New Size(270, 15)
        End With
        prgFrm.Controls.Add(prgBar)
        prgBar.Location = New Point(20, 21)

    End Sub

    Private WithEvents bgw As New BackgroundWorker
    Public Sub UploadProgressDialog(Optional ByVal StatusMessage As String = "Loading")
        setupControls(StatusMessage)

        bgw.WorkerReportsProgress = True
        bgw.WorkerSupportsCancellation = True

        'If Not prgFrm.Visible Then prgFrm.Show()

        If bgw.IsBusy = False Then
            If Not prgFrm.Visible Then prgFrm.Show()
            bgw.RunWorkerAsync(10)
        End If

    End Sub
    Private Sub bgw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw.DoWork
        Dim numToDo As Integer = CInt(e.Argument)
        For n As Integer = 1 To numToDo
            Threading.Thread.Sleep(100)
            bgw.ReportProgress(Convert.ToInt32((n / numToDo) * 100))
        Next
    End Sub
    Private Sub bgw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw.ProgressChanged
        prgBar.Value = prgBar.Maximum
        prgBar.Value = e.ProgressPercentage

    End Sub
    Sub clkStop()
        prgFrm.Close()
        prgFrm.Dispose()
        prgBar.Dispose()
    End Sub
    Private Sub bgw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw.RunWorkerCompleted
        clkStop()
    End Sub

End Module
