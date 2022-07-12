Imports System.ComponentModel
Imports System.Drawing.Printing
Public Class SelectPrinter

    <BrowsableAttribute(False)>
    Public Property PrinterSettings As PrinterSettings
    Property Value
    Public Function loadPrinterName() As String

        My.Settings.__PrinterToUse = ""
        My.Settings.Save()
        OnLoad(Nothing)

        Dim print_Name As String = ""
        Using p_s As New PrintDialog
            With p_s
                .AllowSelection = True
                .PrinterSettings.Duplex = Duplex.Simplex
                .AllowPrintToFile = True
                .ShowDialog()
                print_Name = .PrinterSettings.PrinterName
            End With
        End Using

        Return print_Name

    End Function
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        l_Name.Text = String.Concat("Print Path: ", My.Settings.__PrinterToUse)
    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F1 Then
            choose()
        End If

    End Sub
    Sub choose() Handles btnBeginUpload.Click
1:      Dim f As String = loadPrinterName()
        If f = "" Then Exit Sub
        My.Settings.__PrinterToUse = f
        My.Settings.Save()
        OnLoad(Nothing)

    End Sub

End Class