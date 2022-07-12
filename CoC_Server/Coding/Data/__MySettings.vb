Imports System.Data.SqlClient

Public Class __MySettings

    '//Enumerators
    Public Shared ProcessActive As Integer = 1
    Public Shared ProcessInActive As Integer = 0
    Public Shared LicenseInactive As Integer = 101
    Public Shared LicenseEvaluated As Integer = 200
    Public Shared LicenseActive As Integer = 300

    '//Properties
    Shared vl As Object
    Public Shared Property CompanyName As Object
        Get
            Return vl
        End Get
        Set(value As Object)
            vl = value
        End Set
    End Property

    Shared vl1 As Object
    Public Shared Property CompanyAddress As Object
        Get
            Return vl1
        End Get
        Set(value As Object)
            vl1 = value
        End Set
    End Property

    Shared __value As Object
    Public Shared Property CompanyLogo As Object
        Get
            Return __value
        End Get
        Set(value As Object)
            __value = value
        End Set
    End Property

    Shared vl2 As Object
    Public Shared Property subAdminModifyCashier As Object
        Get
            Return vl2
        End Get
        Set(value As Object)
            vl2 = value
        End Set
    End Property

    Shared vl3 As Object
    Public Shared Property subAdminModifyInvoices As Object
        Get
            Return vl3
        End Get
        Set(value As Object)
            vl3 = value
        End Set
    End Property

    Shared iv As Object
    Public Shared Property CompanyPhone As Object
        Get
            Return iv
        End Get
        Set(value As Object)
            iv = value
        End Set
    End Property

    Shared vl4 As Object
    Public Shared Property CompanyType As Object
        Get
            Return vl4
        End Get
        Set(value As Object)
            vl4 = value
        End Set
    End Property

    Shared vl5 As Object
    Public Shared Property CompanyEmail As Object
        Get
            Return vl5
        End Get
        Set(value As Object)
            vl5 = value
        End Set
    End Property

    Shared _iv As Object
    Public Shared Property AllowSubAdmin As Object
        Get
            Return _iv
        End Get
        Set(value As Object)
            _iv = value
        End Set
    End Property

    Shared _iv1 As Object
    Public Shared Property PerformBackups As Object
        Get
            Return _iv1
        End Get
        Set(value As Object)
            _iv1 = value
        End Set
    End Property

    Shared _iv2 As Object
    Public Shared Property subAdminModifyOwnKey As Object
        Get
            Return _iv2
        End Get
        Set(value As Object)
            _iv2 = value
        End Set
    End Property

    Shared _iv3 As Object
    Public Shared Property subAdminModifyCompany As Object
        Get
            Return _iv3
        End Get
        Set(value As Object)
            _iv3 = value
        End Set
    End Property

    Shared _iv4 As Object
    Public Shared Property subAdminModifySecurity As Object
        Get
            Return _iv4
        End Get
        Set(value As Object)
            _iv4 = value
        End Set
    End Property

    Shared _iv5 As Object
    Public Shared Property subAdminCategoryControl As Object
        Get
            Return _iv5
        End Get
        Set(value As Object)
            _iv5 = value
        End Set
    End Property

    Shared _iv6 As Object
    Public Shared Property subAdminReportControl As Object
        Get
            Return _iv6
        End Get
        Set(value As Object)
            _iv6 = value
        End Set
    End Property

    Shared _iv7 As Object
    Public Shared Property subAdminBackupControl As Object
        Get
            Return _iv7
        End Get
        Set(value As Object)
            _iv7 = value
        End Set
    End Property

    Shared _iv8 As Object
    Public Shared Property backupModeAuto As Object
        Get
            Return _iv8
        End Get
        Set(value As Object)
            _iv8 = value
        End Set
    End Property

    Shared _iv9 As Object
    Public Shared Property IsFirstTimeUse As Object
        Get
            Return _iv9
        End Get
        Set(value As Object)
            _iv9 = value
        End Set
    End Property

    Shared vl6 As Object
    Public Shared Property backupTime As Object
        Get
            Return vl6
        End Get
        Set(value As Object)
            vl6 = value
        End Set
    End Property

    Shared vl7 As Object
    Public Shared Property lastBackup As Object
        Get
            Return vl7
        End Get
        Set(value As Object)
            vl7 = value
        End Set
    End Property

    Shared vl8 As Object
    Public Shared Property subAdminModifyFeatures As Object
        Get
            Return vl8
        End Get
        Set(value As Object)
            vl8 = value
        End Set
    End Property

    Shared vl9 As Object
    Public Shared Property subAdminExportReports As Object
        Get
            Return vl9
        End Get
        Set(value As Object)
            vl9 = value
        End Set
    End Property

    Shared vl10 As Object
    Public Shared Property backupPath As Object
        Get
            Return vl10
        End Get
        Set(value As Object)
            vl10 = value
        End Set
    End Property

    Shared ul1 As Object
    Public Shared Property adminLimit As Object
        Get
            Return ul1
        End Get
        Set(value As Object)
            ul1 = value
        End Set
    End Property

    Shared ul2 As Object
    Public Shared Property clientLimit As Object
        Get
            Return ul2
        End Get
        Set(value As Object)
            ul2 = value
        End Set
    End Property

    Shared LK As Object
    Public Shared Property LicenseKey As Object
        Get
            Return LK
        End Get
        Set(value As Object)
            LK = value
        End Set
    End Property
    Shared LD As Object
    Public Shared Property LicenseDate As Object
        Get
            Return LD
        End Get
        Set(value As Object)
            LD = value
        End Set
    End Property
    Shared _iv10 As Object
    Public Shared Property LicenseStatus As Object
        Get
            Return _iv10
        End Get
        Set(value As Object)
            _iv10 = value
        End Set
    End Property

    Shared Sub loadSetting(scopeName, scopeValue)
        Try
            If Not c.State = ConnectionState.Open Then c.Open()
            Dim cm As New SqlCommand("UPDATE settingsTbl SET cScope=@cScope WHERE cName='" & scopeName & "'",
                                           c)
            With cm
                .Parameters.Add(New SqlParameter("@cScope", SqlDbType.VarChar)).Value = scopeValue
                .ExecuteNonQuery()
                If Not c.State = ConnectionState.Closed Then c.Close()
            End With
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub Save()
        loadSetting("CompanyName", CompanyName)
        loadSetting("CompanyAddress", CompanyAddress)
        loadSetting("CompanyLogo", CompanyLogo)
        loadSetting("subAdminModifyCashier", subAdminModifyCashier)
        loadSetting("subAdminModifyInvoices", subAdminModifyInvoices)
        loadSetting("CompanyPhone", CompanyPhone)
        loadSetting("CompanyType", CompanyType)
        loadSetting("CompanyEmail", CompanyEmail)
        loadSetting("AdminLimit", adminLimit)
        loadSetting("ClientLimit", clientLimit)
        loadSetting("AllowSubAdmin", AllowSubAdmin)
        loadSetting("PerformBackups", PerformBackups)
        loadSetting("subAdminModifyOwnKey", subAdminModifyOwnKey)
        loadSetting("subAdminModifyCompany", subAdminModifyCompany)
        loadSetting("subAdminModifySecurity", subAdminModifySecurity)
        loadSetting("subAdminCategoryControl", subAdminCategoryControl)
        loadSetting("subAdminReportControl", subAdminReportControl)
        loadSetting("subAdminBackupControl", subAdminBackupControl)
        loadSetting("backupTime", backupTime)
        loadSetting("lastBackup", lastBackup)
        loadSetting("backupModeAuto", backupModeAuto)
        loadSetting("subAdminModifyFeatures", subAdminModifyFeatures)
        loadSetting("subAdminExportReports", subAdminExportReports)
        loadSetting("backupPath", backupPath)
        loadSetting("IsFirstTimeUse", IsFirstTimeUse)
        loadSetting("LicenseKey", LicenseKey)
        loadSetting("LicenseDate", LicenseDate)
        loadSetting("LicenseMode", LicenseStatus)

        Reload()

    End Sub

    Public Shared Sub Reload()

        CompanyName = loadSetting("CompanyName")
        CompanyAddress = loadSetting("CompanyAddress")
        CompanyLogo = loadSetting("CompanyLogo")
        subAdminModifyCashier = loadSetting("subAdminModifyCashier")
        subAdminModifyInvoices = loadSetting("subAdminModifyInvoices")
        CompanyPhone = loadSetting("CompanyPhone")
        CompanyType = loadSetting("CompanyType")
        CompanyEmail = loadSetting("CompanyEmail")
        adminLimit = loadSetting("AdminLimit")
        clientLimit = loadSetting("ClientLimit")
        AllowSubAdmin = loadSetting("AllowSubAdmin")
        PerformBackups = loadSetting("PerformBackups")
        subAdminModifyOwnKey = loadSetting("subAdminModifyOwnKey")
        subAdminModifyCompany = loadSetting("subAdminModifyCompany")
        subAdminModifySecurity = loadSetting("subAdminModifySecurity")
        subAdminCategoryControl = loadSetting("subAdminCategoryControl")
        subAdminReportControl = loadSetting("subAdminReportControl")
        subAdminBackupControl = loadSetting("subAdminBackupControl")
        backupTime = loadSetting("backupTime")
        lastBackup = loadSetting("lastBackup")
        backupModeAuto = loadSetting("backupModeAuto")
        subAdminModifyFeatures = loadSetting("subAdminModifyFeatures")
        subAdminExportReports = loadSetting("subAdminExportReports")
        backupPath = loadSetting("backupPath")
        IsFirstTimeUse = loadSetting("IsFirstTimeUse")
        LicenseKey = loadSetting("LicenseKey")
        LicenseDate = loadSetting("LicenseDate")
        LicenseStatus = loadSetting("LicenseMode")

    End Sub
    Shared Function loadSetting(scopeName)
        Dim r = Nothing
        Dim tbl As DataTable = xRead("SELECT cSCope FROM settingsTbl WHERE cName='" & scopeName & "'", "settingsTbl", c)
        For Each row In tbl.Rows
            r = row(0)
        Next
        loadSetting = r

    End Function

    Public Shared Sub Reset()
        loadSetting("CompanyName", "")
        loadSetting("CompanyAddress", "")
        loadSetting("CompanyLogo", "")
        loadSetting("subAdminModifyCashier", ProcessInActive)
        loadSetting("subAdminModifyInvoices", ProcessInActive)
        loadSetting("CompanyPhone", "")
        loadSetting("CompanyType", "")
        loadSetting("CompanyEmail", "")
        loadSetting("AdminLimit", 1)
        loadSetting("ClientLimit", 1)
        loadSetting("AllowSubAdmin", ProcessInActive)
        loadSetting("PerformBackups", ProcessInActive)
        loadSetting("subAdminModifyOwnKey", ProcessInActive)
        loadSetting("subAdminModifyCompany", ProcessInActive)
        loadSetting("subAdminModifySecurity", ProcessInActive)
        loadSetting("subAdminCategoryControl", ProcessInActive)
        loadSetting("subAdminReportControl", ProcessInActive)
        loadSetting("subAdminBackupControl", ProcessInActive)
        loadSetting("backupTime", "")
        loadSetting("lastBackup", "")
        loadSetting("backupModeAuto", ProcessInActive)
        loadSetting("subAdminModifyFeatures", ProcessInActive)
        loadSetting("subAdminExportReports", ProcessInActive)
        loadSetting("backupPath", "")
        loadSetting("IsFirstTimeUse", ProcessActive)

    End Sub

End Class
