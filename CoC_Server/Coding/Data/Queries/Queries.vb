Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports Npgsql
Imports NpgsqlTypes
Imports System.Data.OleDb

Module Queries

    '//Initialize new connection 

    Public dionysus As New NpgsqlConnection("Server = 127.0.0.1; Port = 5432; Database = postgres" &
                                                        "; User Id = postgres; Password = 47T3r@byt3s;")
    Public c As New NpgsqlConnection("Server = 127.0.0.1; Port = 5432; Database = " & CoC_Mains &
                                                        "; User Id = coc_serv; Password = 47T3r@byt3s;")
    Public cItems As New NpgsqlConnection("Server = 127.0.0.1; Port = 5432; Database = " & CoC_Items &
                                                        "; User Id = coc_serv; Password = 47T3r@byt3s;")
    Public cTXNs As New NpgsqlConnection("Server = 127.0.0.1; Port = 5432; Database = " & CoC_Transactions &
                                                        "; User Id = coc_serv; Password = 47T3r@byt3s;")

    'ACE.OLEDB.12.0;

    'Jet.OLEDB.4.0;

    Public cCr As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\clCrData.mdb;Jet OLEDB:Database Password=47T3r@byt3s")

    '//General SQL Select query
    Public Function Qry(ByVal SqlString As String, Optional ByVal s As NpgsqlConnection = Nothing)
        Dim cn As New NpgsqlConnection
        cn = IIf(s Is Nothing, c, s)
        Dim x As Object = Nothing
        Try
            'If Not cn.State = ConnectionState.Open Then cn.Open()
            Dim cm As New NpgsqlCommand(SqlString, cn)
            If Not cm.Connection.State = ConnectionState.Open Then cm.Connection.Open()
            x = cm.ExecuteScalar
            If cn.State = ConnectionState.Open Then cn.Close()
            If Not cm.Connection.State = ConnectionState.Closed Then cm.Connection.Close()
            cm.Dispose()
        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
            x = -1
        Finally
            Qry = x
            'cn.Dispose()
        End Try

    End Function

    Public Function sQry(ByVal sObject As String,
                                      ByVal tbl As String,
                                      ByVal sIdentifier As String,
                                      ByVal sObjCondition As String,
                         Optional ByVal sObjtyp As NpgsqlDbType = NpgsqlDbType.Unknown,
                        Optional ByVal s As NpgsqlConnection = Nothing)

        Dim cn As New NpgsqlConnection
        cn = IIf(s Is Nothing, c, s)

        Dim Sql As String = "SELECT " & sObject & " FROM " & tbl & " WHERE " & sIdentifier & "=@" & sIdentifier

        Dim x As Object = Nothing

        Try
            'If Not cn.State = ConnectionState.Open Then cn.Open()
            Dim cm As New NpgsqlCommand(Sql, cn)
            If Not cm.Connection.State = ConnectionState.Open Then cm.Connection.Open()
            cm.Parameters.Add("@" & sIdentifier,
                             IIf(sObjtyp = NpgsqlDbType.Unknown, NpgsqlDbType.Varchar, sObjtyp)).Value = sObjCondition
            x = cm.ExecuteScalar
            If cn.State = ConnectionState.Open Then cn.Close()
            If Not cm.Connection.State = ConnectionState.Closed Then cm.Connection.Close()
            cm.Dispose()
        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
            x = -1
        Finally
            sQry = x
            'cn.Dispose()
        End Try
    End Function

    '//General SQL Insert Query
    Public Function xQry(ByVal SqlString As String, Optional ByVal s As NpgsqlConnection = Nothing)

        Dim cn As New NpgsqlConnection
        cn = IIf(s Is Nothing, c, s)

        Dim SuccessString As String = Nothing

        Try
            'If Not cn.State = ConnectionState.Open Then cn.Open()
            Dim cm As New NpgsqlCommand(SqlString, cn)
            If Not cm.Connection.State = ConnectionState.Open Then cm.Connection.Open()
            SuccessString = IIf(cm.ExecuteNonQuery() > 0, "Successful!", "Action Incomplete!")
            If Not cm.Connection.State = ConnectionState.Closed Then cm.Connection.Close()
            cm.Dispose()
        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
        Finally
            xQry = SuccessString
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        'cn.Dispose()
    End Function

    '//Data reader
    Public Function getTblSz(Sql As String, tbl As String, Optional ByVal s As NpgsqlConnection = Nothing) As Integer
        Dim cn As New NpgsqlConnection
        cn = IIf(s Is Nothing, c, s)


        Dim Byt As Byte() = Nothing
        Dim ds As New DataSet
        'If Not cn.State = ConnectionState.Open Then cn.Open()
        Dim cmd As New NpgsqlCommand(Sql, cn)
        If Not cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Open()
        Dim da As New NpgsqlDataAdapter(cmd)
        da.Fill(ds, tbl)
        Using Strm As New MemoryStream
            Dim bf As New BinaryFormatter
            ds.RemotingFormat = SerializationFormat.Binary
            bf.Serialize(Strm, ds)
            Byt = Strm.ToArray
            Strm.Dispose()
        End Using
        If Not cn.State = ConnectionState.Closed Then cn.Close()
        getTblSz = Byt.Length
        ds.Dispose()
        If Not cmd.Connection.State = ConnectionState.Closed Then cmd.Connection.Close()
        cmd.Dispose()
        da.Dispose()
        'cn.Dispose()
    End Function

    '//Data Table
    '//select f from x
    Public Function xRead(Sql As String, tbl As String, Optional ByVal s As NpgsqlConnection = Nothing) As DataTable
        Dim cn As New NpgsqlConnection
        cn = IIf(s Is Nothing, c, s)

        Dim ds As New DataSet
        'If Not cn.State = ConnectionState.Open Then cn.Open()
        Dim cmd As New NpgsqlCommand(Sql, cn)
        If Not cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Open()
        Dim da As New NpgsqlDataAdapter(cmd)
        da.Fill(ds, tbl)
        xRead = ds.Tables(tbl)
        If Not c.State = ConnectionState.Closed Then c.Close()
        ds.Dispose()
        If Not cmd.Connection.State = ConnectionState.Closed Then cmd.Connection.Close()
        cmd.Dispose()
        da.Dispose()
        'cn.Dispose()
    End Function

    '//CrVw

    '//Insert
    Public Function FxQry(SqlString As String)
        Dim cn As New OleDbConnection
        cn = cCr
        Dim f As Integer = -1
        Try
            Dim cm As New OleDbCommand(SqlString, cn)
            If Not cm.Connection.State = ConnectionState.Open Then cm.Connection.Open()
            f = cm.ExecuteNonQuery()
            If Not cm.Connection.State = ConnectionState.Closed Then cm.Connection.Close()
            cm.Dispose()

        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
        Finally
            f = -1
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
        FxQry = f
        'cn.Dispose()
    End Function

End Module
