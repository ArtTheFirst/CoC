Public Class Configurations

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        loadDays()
        loadSettings()

        admTab.SelectedTab = tInfoLicense
    End Sub

    Sub loadSettings()

        Cnfg.Reload()
        l_AppName.Text = My.Application.Info.ProductName

        Dim Lic As String = Nothing
        If Cnfg.LicenseStatus = Cnfg.LicenseInactive Then
            Lic = "Inactive"
        ElseIf Cnfg.LicenseStatus = Cnfg.LicenseEvaluated Then
            Lic = "Evaluation Mode (30-Day Trial) [" & licenseinfo & "]"
        ElseIf Cnfg.LicenseStatus = Cnfg.LicenseActive Then
            Lic = "Activated"
        End If
        l_LicenseStatus.Text = String.Concat("License Status: ", Lic)

        l_LicenseKey.Text = String.Concat("License Key: ", Cnfg.LicenseKey)

        l_ClientNo.Text = String.Concat("No. Of Clients Allowed: ", Cnfg.adminLimit - 1)

        chkTakeBackup.Checked = If(Cnfg.PerformBackups = Cnfg.Actv, True, False)
        btnBackup.Enabled = chkTakeBackup.Checked

    End Sub

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If

    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        ReUpload.ShowDialog()

    End Sub

    Private Sub btnLoadCompany_Click(sender As Object, e As EventArgs) Handles btnLoadCompany.Click
        Company = AddMode.IsHQ
        _Company = _AddMode.IsOld
        Id = "HQ0001"
        Dim f As New Company_Ctrl
        If Not f.Visible Then f.ShowDialog()
    End Sub

    Private Sub btnLoadSubAdmin_Click(sender As Object, e As EventArgs) Handles btnLoadSubAdmin.Click

        If _This() = LoginIs.Admin Then
            GoTo 7
        ElseIf _This() = LoginIs.SubAdmin Then
            complain()
            Mode = LoginMode.AllowAccess
            login.ShowDialog()
            If _Access = _Request.IsGranted And CurrentRequested = UserLogin.IsAdmin Then
                GoTo 7
            Else
                ShowMessage("Permission revoked!", _Method.AsError)
            End If
        End If

        Exit Sub

7:      Dim f As New DefineSubAdminRules
        If Not f.Visible Then f.ShowDialog()

    End Sub

    Private Sub btnChoosePrinter_Click(sender As Object, e As EventArgs) Handles btnChoosePrinter.Click
        Dim f As New SelectPrinter
        If Not f.Visible Then f.ShowDialog()
    End Sub

    Private Sub chkTakeBackup_CheckedChanged(sender As Object, e As EventArgs) Handles chkTakeBackup.CheckedChanged

        Cnfg.Reload()
        If _This() = LoginIs.SubAdmin Then
            If Cnfg.subAdminBackupControl = Cnfg.InActv Then
                MsgBox("You do not have the rights to do this. Sorry")
                chkTakeBackup.Checked = False

            End If
        ElseIf _This() = LoginIs.Admin Then
            GoTo 7
        End If

        Exit Sub
7:      Dim i As Integer = If(chkTakeBackup.Checked, Cnfg.Actv, Cnfg.InActv)
        Cnfg.PerformBackups = i
        Cnfg.Save()
        loadSettings()

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        ThisUser = HereIs._New

        If _This() = LoginIs.Admin Then
            GoTo 7
        ElseIf _This() = LoginIs.SubAdmin Then
            complain()
            Mode = LoginMode.AllowAccess
            Dim frm As New login
            If Not frm.Visible Then frm.ShowDialog()
            If _Access = _Request.IsGranted And CurrentRequested = UserLogin.IsAdmin Then
                GoTo 7
            Else
                ShowMessage("Permission revoked!", _Method.AsError)
            End If
        End If

        Exit Sub
7:      Dim f As New LoginDefinition
        If Not f.Visible Then f.ShowDialog()

    End Sub

    Private Sub btnModifyAccount_Click(sender As Object, e As EventArgs) Handles btnModifyAccount.Click

        ThisUser = HereIs._Old

        If _This() = LoginIs.Admin Then
            GoTo 7
        ElseIf _This() = LoginIs.SubAdmin Then
            complain()
            Mode = LoginMode.AllowAccess
            Dim frm As New login
            If Not frm.Visible Then frm.ShowDialog()
            If _Access = _Request.IsGranted And CurrentRequested = UserLogin.IsAdmin Then
                GoTo 7
            Else
                ShowMessage("Permission revoked!", _Method.AsError)
            End If
        End If

        Exit Sub
7:      CurrentItem = SearchIs.Create

        'LoadAs = _Item.View
        Dim g As New Users
        If Not g.Visible Then g.ShowDialog()

        If Id = "" Then Exit Sub

        'UserModify_Ctrl.Show()

        Dim f As New LoginDefinition
        If Not Id = "" Then If Not f.Visible Then f.ShowDialog()

    End Sub

    Private Sub btnModifyAdminLogin_Click(sender As Object, e As EventArgs) Handles btnModifyAdminLogin.Click
        If Not _This() = LoginIs.Admin Then Exit Sub
        Mode = LoginMode.AskModifier

        Dim frm As New login

        If Not frm.Visible Then frm.ShowDialog()

        'login.ShowDialog()
    End Sub

    Private Sub btnCreateBranch_Click(sender As Object, e As EventArgs) Handles btnCreateBranch.Click

        Company = AddMode.IsBranch
        _Company = _AddMode.IsNew
        Id = ""
        Dim f As New Company_Ctrl
        If Not f.Visible Then f.ShowDialog()

    End Sub

    Private Sub btnLoadLogs_Click(sender As Object, e As EventArgs) Handles btnLoadLogs.Click
        Dim f As New UserLog
        If Not f.Visible Then f.ShowDialog()
    End Sub

End Class