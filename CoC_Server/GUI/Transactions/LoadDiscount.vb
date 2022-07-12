Imports System.ComponentModel

Public Class LoadDiscount

    Sub keyTrapNum(sender As Object, e As KeyPressEventArgs) Handles t_DscAmt.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub t_DscAmt_TextChanged(sender As Object, e As EventArgs) Handles t_DscAmt.TextChanged
        Try
            Dim f As Integer = TotalPrice * (CType(t_DscAmt.Text, Integer) / 100)
            Discounts = CType(t_DscAmt.Text, Integer)
            l_Total.Text = FormatNumber(f, 2)
        Catch ex As Exception
            t_DscAmt.Text = 0
            l_Total.Text = FormatNumber(0, 2)
        End Try

    End Sub
    Private Sub t_DscAmt_KeyDown(sender As Object, e As KeyEventArgs) Handles t_DscAmt.KeyDown
        If e.KeyCode = Keys.Enter Then
            Close()
        End If

    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        Discounts = CType(t_DscAmt.Text, Integer)
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf (e.KeyCode = Keys.s And e.Modifiers = Keys.Control) Or (e.KeyCode = Keys.s And e.Modifiers = Keys.ControlKey) Then
            OnClosing(Nothing)
        End If

    End Sub

End Class