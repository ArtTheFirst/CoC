Imports System.Data.SqlClient
Imports Npgsql

Module DefineDatabase

    Public Const CoC_Mains As String = "coc_serv"
    Public Const CoC_Items As String = "coc_items"
    Public Const CoC_Transactions As String = "coc_transactions"

    Public Sub ForceDisconnects(mydatabasename As String)

        Dim Sql As String = ""

        '//make sure db exists
        Sql = Qry("SELECT * from pg_database where datname = '" & mydatabasename & "'", dionysus)

        '//disallow new connections
        xQry("UPDATE pg_database SET allowconn = 'false' WHERE datname = '" & mydatabasename & "'", dionysus)

        '//change connection limit
        xQry("ALTER DATABASE " & mydatabasename & " CONNECTION LIMIT 1", dionysus)

        '//terminate existing connections
        Sql = Qry("SELECT pg_terminate_backend(pid) FROM pg_stat_activity WHERE datname = '" & mydatabasename & "'", dionysus)

        '//drop database
        xQry("DROP DATABASE '" & mydatabasename & "'", dionysus)

    End Sub

    Function IsUsrExist(usrname As String) As Integer
        Dim r As Integer = -1
        Try
            r = Qry("Select 1 FROM pg_roles WHERE rolname='" & usrname & "'", dionysus)
        Catch ex As Exception
            r = -1
        End Try
        IsUsrExist = r
    End Function
    Public Sub CreateDbUser()
        Dim MyCon As New NpgsqlConnection
        Dim NpgSQlString As String = "Server = 127.0.0.1; " &
                                                      "Port = 5432; " &
                                                      "Database = postgres; " &
                                                      "User Id = postgres; " &
                                                      "Password = 47T3r@byt3s;"

        MyCon.ConnectionString = NpgSQlString

        If IsUsrExist("coc_serv") = 1 Then Exit Sub

        Try
            MyCon.Open()
            Dim cmd As NpgsqlCommand = MyCon.CreateCommand
            cmd.CommandText = "CREATE USER coc_serv WITH CREATEDB PASSWORD '47T3r@byt3s';"
            cmd.ExecuteNonQuery()
            write_Log("CoC_Serv Created Successfully!")
            MyCon.Close()
            cmd.Dispose()

            MyCon.Open()
            cmd = New NpgsqlCommand
            cmd = MyCon.CreateCommand
            cmd.CommandText = "CREATE DATABASE coc_serv WITH OWNER coc_serv;"
            cmd.ExecuteNonQuery()
            write_Log("CoC_Serv Main Db Created Successfully!")
            MyCon.Close()

            cmd.Dispose()
        Catch ex As NpgsqlException
            write_Error("Failed To Create Item; " & ex.Message, "User Setup")
        End Try
    End Sub

    Function IsDbExist(dbname As String) As Integer
        Dim r As Integer = -1
        Try
            r = Qry("SELECT 1 FROM pg_database WHERE datname='" & dbname & "'", dionysus)
        Catch ex As Exception
            r = -1
        End Try
        IsDbExist = r
    End Function
    Public Sub CreateuserDb(DBNAME As String)
        Dim MyCon As New NpgsqlConnection
        Dim NpgSQlString As String = "Server = 127.0.0.1; " &
                                                      "Port = 5432; " &
                                                      "Database = coc_serv; " &
                                                      "User Id = coc_serv; " &
                                                      "Password = 47T3r@byt3s;"

        MyCon.ConnectionString = NpgSQlString

        Dim cnStr As String = "CREATE DATABASE " & DBNAME & " WITH OWNER coc_serv;"

        If IsDbExist(DBNAME) = 1 Then Exit Sub

        Try
            MyCon.Open()
            Dim cmd As NpgsqlCommand = MyCon.CreateCommand
            cmd.CommandText = cnStr
            cmd.ExecuteNonQuery()
            write_Log("Database Created; " & DBNAME)
            MyCon.Close()
            cmd.Dispose()
        Catch ex As NpgsqlException
            write_Error("Failed To Create Database; " & DBNAME & ex.Message, "Database Setup")
        End Try
    End Sub

    Public Sub ModifyDbUser()
        Dim MyCon As New NpgsqlConnection
        Dim NpgSQlString As String = "Server = 127.0.0.1; " &
                                                      "Port = 5432; " &
                                                      "Database = postgres; " &
                                                      "Userid = postgres; " &
                                                      "Password = 47T3r@byt3s;"
        MyCon.ConnectionString = NpgSQlString
        Try
            MyCon.Open()
            Dim cmd As NpgsqlCommand = MyCon.CreateCommand
            cmd.CommandText = "ALTER USER CoC_Serv PASSWORD '47T3r@byt3s';"
            cmd.ExecuteNonQuery()
            write_Log("Database ALTER DONE")
            MyCon.Close()
            cmd.Dispose()
        Catch ex As NpgsqlException
            write_Error("Failed To ALTER; " & ex.Message, "Database Setup")
        End Try
    End Sub

End Module
