Imports System.Data.OleDb

Module DataPaths

    Public pth As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\init\data")

    Public xl_pth As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\init\xl")

    Public bkp_pth As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\init\BAK")

    Public xlpth_Items As New IO.FileInfo(String.Concat(xl_pth.ToString, "\CyBooks_Format_Items.xls"))
    Public xlpth_Suppliers As New IO.FileInfo(String.Concat(xl_pth.ToString, "\CyBooks_Format_Suppliers.xls"))
    Public xlpth_Clients As New IO.FileInfo(String.Concat(xl_pth.ToString, "\CyBooks_Format_Clients.xls"))
    Public c_p As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & xlpth_Items.ToString & ";" &
                                                            "Extended Properties = ""Excel 12.0 Xml;HDR=YES""")
    Public c_s As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & xlpth_Suppliers.ToString & ";" &
                                                            "Extended Properties = ""Excel 12.0 Xml;HDR=YES""")
    Public c_c As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & xlpth_Clients.ToString & ";" &
                                                            "Extended Properties = ""Excel 12.0 Xml;HDR=YES""")


    Private cy_Log As New IO.FileInfo(String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "\Cy\init\app\logger_.log"))
    Public Sub write_Log(LogString As String)
        If Not cy_Log.Directory.Exists Then cy_Log.Directory.Create()
        Dim dLog As New DateTime()
        With Date.Now
            dLog = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond, DateTimeKind.Utc)
        End With
        If Not cy_Log.Exists Then IO.File.WriteAllText(cy_Log.ToString, "Log Created at " &
                                                       dLog &
                                                       vbNewLine & vbNewLine)

        IO.File.AppendAllText(cy_Log.ToString, vbNewLine & "Logged at: " &
                              Date.Now.ToShortTimeString &
                              "/" &
                              Date.Now.ToShortDateString & vbNewLine &
                              LogString & vbNewLine)

    End Sub

    Private cyErrorLogs As New IO.FileInfo(String.Concat(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "\Cy\init\app\c_err_.log"))
    Public Sub write_Error(ErrorString As String, Optional ByVal frm As String = "")
        If Not cyErrorLogs.Directory.Exists Then cyErrorLogs.Directory.Create()
        Dim dLog As New DateTime()
        With Date.Now
            dLog = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond, DateTimeKind.Utc)
        End With
        If Not cyErrorLogs.Exists Then IO.File.WriteAllText(cyErrorLogs.ToString,
                                                            "Log Created at " & dLog &
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
        Dim dLog As New DateTime()
        With Date.Now
            dLog = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond, DateTimeKind.Utc)
        End With
        IO.File.AppendAllText(cyErrorLogs.ToString, vbNewLine & "---------------------------------------LOG BEGIN---------------------------------------" &
                                                                vbNewLine &
              dLog & vbNewLine)
        IO.File.AppendAllText(cy_Log.ToString, vbNewLine & "---------------------------------------LOG BEGIN---------------------------------------" &
                                                                        vbNewLine &
                      dLog & vbNewLine)
    End Sub
    Public Sub InitiateEOD()
        Dim dLog As New DateTime()
        With Date.Now
            dLog = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second, .Millisecond, DateTimeKind.Utc)
        End With
        IO.File.AppendAllText(cyErrorLogs.ToString, vbNewLine & "------------------------------------------EOD------------------------------------------" &
                                                                        vbNewLine &
                      dLog & vbNewLine)
        IO.File.AppendAllText(cy_Log.ToString, vbNewLine & "------------------------------------------EOD------------------------------------------" &
                                                                        vbNewLine &
                      dLog & vbNewLine)

    End Sub

    Enum _Mode
        IsSave
        IsUpdate
        IsNothing
    End Enum
    Public _Save As _Mode = _Mode.IsNothing

End Module
