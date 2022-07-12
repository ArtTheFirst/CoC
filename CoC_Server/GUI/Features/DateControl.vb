Imports System.ComponentModel

Public Class DateControl
    Private Const xSz As Integer = 240
    Private Const cSz As Integer = 163
    Private GoOn As Boolean = False
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        GoOn = False
        Height = cSz
        Dim tD As Date = New Date()
        With Date.Now
            tD = New Date(.Year, .Month, .Day, .Hour, .Minute, .Second)
        End With
        dtp_DateFilter1.Value = tD
        dtp_DateFilter2.MinDate = dtp_DateFilter1.Value
        dtp_DateFilter1.Focus()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)

        If Not GoOn Then Exit Sub

        SQLDate = IIf(Height = cSz, "='" & dtp_DateFilter1.Value.Date & "'",
              " BETWEEN '" & dtp_DateFilter1.Value.Date &
              "' AND '" & dtp_DateFilter2.Value.Date & "'")

        JournalDate = dtp_DateFilter1.Value

    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            GoOn = True
            Close()
        End If

    End Sub

    Sub xtend() Handles btnExtension.Click
        If DatePanel = ShouldBe.Contracted Then Exit Sub
        dtp_DateFilter2.MinDate = dtp_DateFilter1.Value
        Height = IIf(Height = cSz, xSz, cSz)
    End Sub

End Class