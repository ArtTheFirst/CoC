Imports System.Data.OleDb
Imports System.Data.SqlClient

Module DatabasePath

    Public pth As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\ctds\CoC")

    Public xl_pth As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\ctds\XLSX")

    Public bkp_pth As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\ctds\BAK")

    Public xlpth_Products As New IO.FileInfo(String.Concat(xl_pth.ToString, "\CyBooks_Format_Products.xls"))
    Public xlpth_Suppliers As New IO.FileInfo(String.Concat(xl_pth.ToString, "\CyBooks_Format_Suppliers.xls"))
    Public xlpth_Clients As New IO.FileInfo(String.Concat(xl_pth.ToString, "\CyBooks_Format_Clients.xls"))
    Public c_p As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & xlpth_Products.ToString & ";" &
                                                            "Extended Properties = ""Excel 12.0 Xml;HDR=YES""")
    Public c_s As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & xlpth_Suppliers.ToString & ";" &
                                                            "Extended Properties = ""Excel 12.0 Xml;HDR=YES""")
    Public c_c As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & xlpth_Clients.ToString & ";" &
                                                            "Extended Properties = ""Excel 12.0 Xml;HDR=YES""")

    Const AppName_ As String = "\CyTech_Systems\PLv3\POS_Logger.exe"
    Public cPPthX86 As New IO.FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & AppName_)
    Public cPPthX64 As New IO.FileInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) & AppName_)
    Public Sub LaunchInventoriesApp()
        If cPPthX86.Exists Then
            Process.Start(cPPthX86.ToString)
        ElseIf cPPthX64.Exists Then
            Process.Start(cPPthX64.ToString)
        Else
            ShowMessage("App not installed! Contact admin", _Method.AsError)
        End If
    End Sub

    Private cy_Log As New IO.FileInfo(String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "\CyTech_Systems\CoC\SqlInstall\logger_.log"))
    Public Sub write_Log(LogString As String)
        If Not cy_Log.Directory.Exists Then cy_Log.Directory.Create()
        If Not cy_Log.Exists Then IO.File.WriteAllText(cy_Log.ToString, "Log Created at " &
                                                       Date.Now.ToShortTimeString &
                                                       " / " &
                                                       Date.Now.ToShortDateString &
                                                       vbNewLine & vbNewLine)

        IO.File.AppendAllText(cy_Log.ToString, vbNewLine & "Logged at: " &
                              Date.Now.ToShortTimeString &
                              "/" &
                              Date.Now.ToShortDateString & vbNewLine &
                              LogString & vbNewLine)

    End Sub

    Private cyErrorLogs As New IO.FileInfo(String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "\CyTech_Systems\CoC\SqlInstall\c_err_.log"))
    Public Sub write_Error(ErrorString As String, Optional ByVal frm As String = "")
        If Not cyErrorLogs.Directory.Exists Then cyErrorLogs.Directory.Create()
        If Not cyErrorLogs.Exists Then IO.File.WriteAllText(cyErrorLogs.ToString,
                                                            "Log Created at " & Date.Now.ToShortTimeString &
                                                            " / " &
                                                            Date.Now.ToShortDateString &
                                                       vbNewLine & vbNewLine)

        IO.File.AppendAllText(cyErrorLogs.ToString, vbNewLine & "Form: " & sCs(frm) &
                                                                                vbNewLine &
                                                                                             "Error Encountered at " &
                              Date.Now.ToShortTimeString &
                              "/" &
                              Date.Now.ToShortDateString & vbNewLine &
                              ErrorString & vbNewLine)

    End Sub
    Public Sub InitiateSOD()
        IO.File.AppendAllText(cyErrorLogs.ToString, vbNewLine & "---------------------------------------LOG BEGIN---------------------------------------" &
                                                                vbNewLine &
              Date.Now.ToShortTimeString &
              "/" &
              Date.Now.ToShortDateString & vbNewLine)
        IO.File.AppendAllText(cy_Log.ToString, vbNewLine & "---------------------------------------LOG BEGIN---------------------------------------" &
                                                                        vbNewLine &
                      Date.Now.ToShortTimeString &
                      "/" &
                      Date.Now.ToShortDateString & vbNewLine)
    End Sub
    Public Sub InitiateEOD()
        IO.File.AppendAllText(cyErrorLogs.ToString, vbNewLine & "------------------------------------------EOD------------------------------------------" &
                                                                        vbNewLine &
                      Date.Now.ToShortTimeString &
                      "/" &
                      Date.Now.ToShortDateString & vbNewLine)
        IO.File.AppendAllText(cy_Log.ToString, vbNewLine & "------------------------------------------EOD------------------------------------------" &
                                                                        vbNewLine &
                      Date.Now.ToShortTimeString &
                      "/" &
                      Date.Now.ToShortDateString & vbNewLine)
    End Sub

    Enum _Mode
        IsSave
        IsUpdate
        IsNothing
    End Enum
    Public _Save As _Mode = _Mode.IsNothing

    Dim INstallShield As String = "/QS /ACTION=Install /HIDECONSOLE /" &
                            "INSTANCENAME=AMAZINGCHARTS /FEATURES=SQLENGINE /SQLSVCSTARTUPTYPE=Automatic" &
                           " /SQLSVCACCOUNT=NT AUTHORITY\NETWORK SERVICE /INDICATEPROGRESS" &
                                  " /IACCEPTSQLSERVERLICENSETERMS /TCPENABLED=1" &
                                    " /NPENABLED=1 /SQLSYSADMINACCOUNTS=BUILTIN\" &
                                    "Administrators /BROWSERSVCSTARTUPTYPE=Automatic" &
                                  " /ASSYSADMINACCOUNTS=BUILTIN\Administrators /AGTSVCACCOUNT=NT AUTHORITY\NETWORK SERVICE /SECURITYMODE=" &
                                "SQL /ASCOLLATION=SQL_Latin1_General_CP1_CI_AS /SQLCOLLATION=SQL_Latin1_General_CP1_CI_AS /" &
                            "SAPWD=t6mp5Install0Pwd /ADDCURRENTUSERASSQLADMIN=false"

End Module
