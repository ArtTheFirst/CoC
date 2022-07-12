Imports System.Data.SqlClient

Module Queries

    '//Initialize new connection 
    Public cnn As SqlConnection = New SqlConnection("Data Source=" & My.Settings.ServerIpAddress &
                                                        ",1433;Network Library=DBMSSOCN;Initial Catalog=query_Mains" &
                                       ";Persist Security Info=True;User Id=sa;Password=L1f31sn0tf@1r;")
    Public cnP As SqlConnection = New SqlConnection("Data Source=" & My.Settings.ServerIpAddress &
                                                        ",1433;Network Library=DBMSSOCN;Initial Catalog=query_Products" &
                                       ";Persist Security Info=True;User Id=sa;Password=L1f31sn0tf@1r;")
    Public cns As SqlConnection = New SqlConnection("Data Source=" & My.Settings.ServerIpAddress &
                                                        ",1433;Network Library=DBMSSOCN;Initial Catalog=query_Sales" &
                                       ";Persist Security Info=True;User Id=sa;Password=L1f31sn0tf@1r;")

    '//General SQL Select query
    Public Function Qry(ByVal SqlString As String, Optional ByVal c As SqlConnection = Nothing)
        Dim cn As SqlConnection = IIf(c Is Nothing, cnn, cnP)
        Try
            If Not cn.State = ConnectionState.Open Then cn.Open()
            Dim cm As New SqlCommand(SqlString, cn)
            Qry = cm.ExecuteScalar
            If cn.State = ConnectionState.Open Then cn.Close()
        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
        Finally
            '
        End Try
    End Function

    '//General SQL Insert Query
    Public Function xQry(ByVal SqlString As String, Optional ByVal c As SqlConnection = Nothing)
        Dim cn As SqlConnection = IIf(c Is Nothing, cnn, cnP)
        Dim SuccessString As String = Nothing

        Try
            If Not cn.State = ConnectionState.Open Then cn.Open()
            Dim cm As New SqlCommand(SqlString, cn)
            SuccessString = IIf(cm.ExecuteNonQuery() > 0, "Successful!", "Action Incomplete!")
        Catch ex As Exception
            Debug.WriteLine("The Problem Here Is: " & ex.Message)
        Finally
            xQry = SuccessString
            If cn.State = ConnectionState.Open Then cn.Close()
        End Try
    End Function

    '//Data Table
    Public Function xRead(Sql As String, tbl As String, Optional ByVal c As SqlConnection = Nothing) As DataTable
        Dim cn As SqlConnection = IIf(c Is Nothing, cnn, cnP)
        Dim ds As New DataSet
        If Not cn.State = ConnectionState.Open Then cn.Open()
        Dim cmd As New SqlCommand(Sql, cn)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, tbl)
        xRead = ds.Tables(tbl)
        If cn.State = ConnectionState.Open Then cn.Close()

    End Function

    Public Function AutoCompleteBox(ByVal filter As String, Table_ As String, Optional ByVal c As SqlConnection = Nothing) As AutoCompleteStringCollection
        c = IIf(c Is Nothing, cnn, c)

        Dim query As String = "SELECT " & filter & " FROM " & Table_
        Dim ds As New DataSet
        c.Open()
        Dim cmd As New SqlCommand(query, c)
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, Table_)
        cnn.Close()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim col As New AutoCompleteStringCollection
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)(filter).ToString())
        Next
        Return col
    End Function
    Public Sub autosText(obj As Object, ByVal filter As String, Table_ As String, Optional ByVal c As SqlConnection = Nothing)
        obj.AutoCompleteSource = AutoCompleteSource.CustomSource
        obj.AutoCompleteCustomSource = AutoCompleteBox(filter, Table_, c)
        obj.AutoCompleteMode = AutoCompleteMode.Suggest
    End Sub

End Module
