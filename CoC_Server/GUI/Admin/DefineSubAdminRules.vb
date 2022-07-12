Imports CoC_Server.Cnfg
Public Class DefineSubAdminRules

    Private Sub chkAllowSubAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllowSubAdmin.CheckedChanged
        Dim i As Integer = If(chkAllowSubAdmin.Checked, Actv, InActv)
        AllowSubAdmin = i
        Save()
        loadSettings()

    End Sub

    Sub loadSettings()
        Reload()
        chkAllowSubAdmin.Checked = If(AllowSubAdmin = Actv, True, False)
        chkModifySubAdmin.Checked = chkAllowSubAdmin.Checked
        chkModifySecurity.Checked = If(subAdminModifySecurity = Actv, True, False)
        chkModifySubAdmin.Checked = If(subAdminModifySecurity = Actv, True, False)
        chkModifyCashier.Checked = If(subAdminModifyCashier = Actv, True, False)
        chkModifyOwnKey.Checked = If(subAdminModifyOwnKey = Actv, True, False)
        chkModifyCompany.Checked = If(subAdminModifyCompany = Actv, True, False)
        chkModifyInvoice.Checked = If(subAdminModifyInvoices = Actv, True, False)
        chkModifyFeatures.Checked = If(subAdminModifyFeatures = Actv, True, False)
        chkViewReports.Checked = If(subAdminReportControl = Actv, True, False)
        chkModifyReports.Checked = If(subAdminReportControl = Actv, True, False)
        chkModifyReports.Enabled = False
        chkDownloadReports.Checked = If(subAdminExportReports = Actv, True, False)
        chkPerformBackup.Checked = If(subAdminBackupControl = Actv, True, False)
        chkAllowAutoBackup.Checked = If(backupModeAuto = Actv, True, False)
        encase.Enabled = If(AllowSubAdmin = Actv, True, False)

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadSettings()

    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If

    End Sub

    Private Sub chkModifyCashier_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyCashier.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminModifyCashier = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkModifyOwnKey_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyOwnKey.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminModifyOwnKey = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkModifyCompany_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyCompany.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminModifyCompany = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkModifySecurity_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifySecurity.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminModifySecurity = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkModifyInvoice_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyInvoice.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminModifyInvoices = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkModifyFeatures_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyFeatures.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminModifyFeatures = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkViewReports_CheckedChanged(sender As Object, e As EventArgs) Handles chkViewReports.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminReportControl = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkDownloadReports_CheckedChanged(sender As Object, e As EventArgs) Handles chkDownloadReports.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminExportReports = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkPerformBackup_CheckedChanged(sender As Object, e As EventArgs) Handles chkPerformBackup.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        subAdminBackupControl = i
        Save()
        loadSettings()

    End Sub
    Private Sub chkAllowAutoBackup_CheckedChanged(sender As Object, e As EventArgs) Handles chkAllowAutoBackup.CheckedChanged
        Dim i As Integer = If(DirectCast(sender, CheckBox).Checked, Actv, InActv)
        backupModeAuto = i
        Save()
        loadSettings()

    End Sub

    Private Sub DefineSubAdminRules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class