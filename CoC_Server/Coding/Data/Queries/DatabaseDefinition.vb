Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Module DatabaseDefinition

    Enum DataFile
        Exists
        NotExists
    End Enum
    Public Function createDatabase() As DataFile
        Dim r As DataFile = -1
        Dim str As String = Nothing
        If Not pth.Exists Then pth.Create()

        Dim d_f As New IO.FileInfo(String.Concat(pth.ToString, "bMG.mdf"))
        Dim d_fl As New IO.FileInfo(String.Concat(pth.ToString, "bMG.ldf"))
        Dim myConn As SqlConnection = New SqlConnection("Data Source=(local)\SQLExpress;Initial Catalog=master;Integrated Security=True")

        If d_f.Exists Then r = DataFile.Exists : GoTo 7

        str = "CREATE DATABASE bMG ON PRIMARY " &
              "(NAME = bMG," &
              " FILENAME = '" & d_f.ToString & "'," &
              " SIZE = 2MB," &
              " MAXSIZE = 10MB," &
              " FILEGROWTH = 10%)" &
              " LOG ON " &
              "(NAME = bMG," &
              " FILENAME = '" & d_fl.ToString & "'," &
              " SIZE = 1MB," &
              " MAXSIZE = 5MB," &
              " FILEGROWTH = 10%)"

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            Dim f As Integer = myCommand.ExecuteNonQuery()
            If f > 0 Then
                MsgBox("We're in!")
            Else
                MsgBox("Okay, let's retrace")
            End If
            r = DataFile.Exists
        Catch ex As Exception
            MsgBox(ex.Message)
            r = DataFile.NotExists
        Finally
            If (myConn.State = ConnectionState.Open) Then
                myConn.Close()
            End If

        End Try
7:      createDatabase = r
    End Function

    Public Sub loadUpDatabase()

        GoTo 3

        Exit Sub
2:      Try
            Dim C As New SqlConnection("Data Source=192.168.1.119,1433;Network Library=DBMSSOCN;Initial Catalog=dbAssQL" &
                                       ";Persist Security Info=True;User Id=sa;Password=s0l1tud3;MultipleActiveResultSets=True;")
            Dim sql As String '//sql query String
            sql = "CREATE TABLE customer(cus_name varchar(50) NULL,address varchar(50) NULL,mobno numeric(18, 0) NULL,tin varchar(50) NULL,kg varchar(50) NULL)"
            Dim cmd As SqlCommand = New SqlCommand(sql, C)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            MsgBox(" Success adding database table", MsgBoxStyle.Exclamation)
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        Exit Sub

3:      Dim d_f As New IO.FileInfo(String.Concat(pth.ToString, "\deadassVB.mdf"))
        Dim f, fN As String
        f = pth.ToString
        fN = "deadassVB"
        If Not pth.Exists Then pth.Create()
        Dim r As DataFile = -1
        If d_f.Exists Then Exit Sub
        Dim cn As SqlConnection = Nothing
        Try
            cn = New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=master;Integrated Security=True;Trusted_Connection=True;")
            Using cn
                cn.Open()
                Dim cmd As SqlCommand = cn.CreateCommand
                Dim str As String = "CREATE Database {0} ON (NAME= N'{0}', FILENAME='{1}\{0}.mdf')"
                cmd.CommandText = String.Format(str, fN, f)
                cmd.ExecuteNonQuery()
            End Using
            'MsgBox("database definition success!", MsgBoxStyle.Information)
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub attachDb()
        'Data Source=.\SQLEXPRESS; AttachDBFileName=|DataDirectory|\MyDBName.mdf;Persist Security Info=True;User ID=sa;Password=s0l1tud3
    End Sub

    Public Function defineDatabases() As DataFile
        Dim d_f As IO.FileInfo = New IO.FileInfo(pth.ToString & "queryTest.mdf")
        If Not pth.Exists Then pth.Create()
        Dim r As DataFile = -1
        If d_f.Exists Then MsgBox("hold up nigga! you got it") : Exit Function

        Try
            Dim Conn As New SqlConnection("Data Source=(local)\SQLExpress;Initial Catalog=master;Integrated Security=True")
            Using Conn
                Conn.Open()
                Dim cmd As SqlCommand = Conn.CreateCommand
                Dim sql As String = "CREATE DATABASE queryTest ON (FILENAME= N'" & d_f.ToString & "') FOR ATTACH;"
                cmd.CommandText = Sql
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("database definition success!", MsgBoxStyle.Information)
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

        Exit Function

3:      Try
            Dim cn As SqlConnection = New SqlConnection("Data Source=(LocalDb)\v11.0;Initial Catalog=master;Integrated Security=SSPI")
            Dim sql As String
            sql = "CREATE TABLE customer(cus_name varchar(50) NULL,address varchar(50) NULL,mobno numeric(18, 0) NULL,tin varchar(50) NULL,kg varchar(50) NULL)"
            Dim cmd = New SqlCommand(sql, cn)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            MsgBox(" Success adding database table", MsgBoxStyle.Critical, " MaS InfoTech")
        Catch
            MsgBox(" Already installed database", MsgBoxStyle.Critical, " MaS InfoTech- Warning")
        End Try

    End Function

End Module
