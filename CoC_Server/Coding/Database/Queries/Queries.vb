Imports System.Data.OleDb

Module Queries

    '//Initialize new connection 
    Public cnn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pth.ToString & "db.database.1.ctd" &
                                                                                            ";Jet OLEDB:Database Password=digitalaccuracy;")
    Public cnP As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pth.ToString & "db.database.products.ctd" &
                                                                                            ";Jet OLEDB:Database Password=digitalaccuracy;")
    Public cns As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pth.ToString & "db.database.sales.ctd" &
                                                                                            ";Jet OLEDB:Database Password=digitalaccuracy;")

    '//General SQL Select query
    Public Function Qry(ByVal SqlString As String, Optional ByVal c As OleDbConnection = Nothing)
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
        Try
            If Not cn.State = ConnectionState.Open Then cn.Open()
            Dim cm As New OleDbCommand(SqlString, cn)
            Qry = cm.ExecuteScalar
            If cn.State = ConnectionState.Open Then cn.Close()
        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
        Finally
            '
        End Try
    End Function

    '//General SQL Insert Query
    Public Function xQry(ByVal SqlString As String, Optional ByVal c As OleDbConnection = Nothing)
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
        Dim SuccessString As String = Nothing

        Try
            If Not cn.State = ConnectionState.Open Then cn.Open()
            Dim cm As New OleDbCommand(SqlString, cn)
            SuccessString = IIf(cm.ExecuteNonQuery() > 0, "Successful!", "Action Incomplete!")
        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
        Finally
            xQry = SuccessString
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    '//Check if data exists
    Enum xData
        Exists
        NotExists
    End Enum
    Public Function xXst(ColumnName As String, TableName As String, Criteria As String, Optional ByVal c As OleDbConnection = Nothing) As xData
        Dim s As Integer = -1
        s = CType(Qry("SELECT ID FROM " & TableName & " WHERE " & ColumnName & "='" & Criteria & "'", c), Integer)
        xXst = IIf(s > 1, xData.Exists, xData.NotExists)
    End Function

    Public Function fId(ColumnName As String, TableName As String, Criteria As String, Optional ByVal c As OleDbConnection = Nothing) As String
        Return Qry("SELECT SerialId FROM " & TableName & " WHERE " & ColumnName & "='" & Criteria & "'", c)
    End Function

    '//Data reader
    Public Function fRead(SqlString As String, Optional ByVal c As OleDbConnection = Nothing) As OleDbDataReader
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
        If Not cn.State = ConnectionState.Open Then cn.Open()
        Dim cm As New OleDbCommand(SqlString, cn)
        fRead = cm.ExecuteReader
    End Function

    '//Data Table
    Public Function xRead(Sql As String, tbl As String, Optional ByVal c As OleDbConnection = Nothing) As DataTable
        Dim cn As OleDbConnection = IIf(c Is Nothing, cnn, c)
        Dim ds As New DataSet
        If Not cn.State = ConnectionState.Open Then cn.Open()
        Dim cmd As New OleDbCommand(Sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, tbl)
        xRead = ds.Tables(tbl)
        If cn.State = ConnectionState.Open Then cn.Close()

    End Function

End Module
