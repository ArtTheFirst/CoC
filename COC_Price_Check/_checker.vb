Imports System.Data.SqlClient
Public Class _checker
    Private _scannedBarcode As String = ""

#Region " Sizing"

    '//Form
    Dim CW As Integer = 704 ' Current Width
    Dim CH As Integer = 441 ' Current Height
    Dim IW As Integer = 704 ' Initial Width
    Dim IH As Integer = 441 ' Initial Height

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        Dim RW As Double = (Me.Width - CW) / CW ' Ratio change of width
        Dim RH As Double = (Me.Height - CH) / CH ' Ratio change of height

        For Each Ctrl As Control In Controls
            Ctrl.Width += CInt(Ctrl.Width * RW)
            Ctrl.Height += CInt(Ctrl.Height * RH)
            Ctrl.Left += CInt(Ctrl.Left * RW)
            Ctrl.Top += CInt(Ctrl.Top * RH)
        Next

        CW = Me.Width

        CH = Me.Height

        lblPrice.Font = New Font("Consolas", ((CW + CH) * 100 / 1200))

        lblCurrency.Font = New Font("Segoe UI", ((CW + CH) * 32 / 1200), FontStyle.Bold, Nothing)

        lblProductName.Font = New Font("Segoe UI", ((CW + CH) * 32 / 1200), FontStyle.Bold, Nothing)

        lblBarCode.Font = New Font("Segoe UI", ((CW + CH) * 15 / 1200), FontStyle.Bold, Nothing)

    End Sub

#End Region
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        If SettingsCtrl.Visible Then Exit Sub
        If My.Settings.ServerIpAddress = "" Then SettingsCtrl.ShowDialog()

    End Sub
    Private Sub LoadProductData()
        Dim ProdName As String = Nothing
        Try

            Dim tbl As DataTable = xRead("SELECT clName,clPrice FROM clProducts WHERE clBarcode=" & _scannedBarcode, "clProducts", cnP)
            For Each row In tbl.Rows
                lblProductName.Text = row(0).ToString
                lblPrice.Text = FormatNumber(row(1), 2, TriState.True)
            Next
            lblBarCode.Text = String.Concat("BAR CODE: ", _scannedBarcode)
            txtReceivedData.Clear()
        Catch
            GoTo 3
        End Try

        Exit Sub
3:      lblBarCode.Text = "BAR CODE"
        txtReceivedData.Clear()

    End Sub
    Private Sub txtReceivedData_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReceivedData.KeyPress
        If Asc(e.KeyChar) = Keys.Enter AndAlso Not txtReceivedData.Text = "" Then
            _scannedBarcode = txtReceivedData.Text
            LoadProductData()
        End If

    End Sub

    Private Sub _checker_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Alt) Then
            SettingsCtrl.ShowDialog()
        End If

    End Sub

End Class
