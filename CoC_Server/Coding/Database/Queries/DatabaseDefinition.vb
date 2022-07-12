Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Module DatabaseDefinition

    Enum dBase
        IsExistent
        IsNonExistent
    End Enum

    Public Function CheckDataBase() As dBase
        Dim Rslt As dBase = -1
        Dim dbpath As New IO.FileInfo(pth.ToString & "db.database.1.ctd")
        If Not pth.Exists Then pth.Create()
        If dbpath.Exists Then Rslt = dBase.IsExistent : GoTo 3

        Dim cat As New ADOX.Catalog()
        Try

            cat.Create(cnn.ConnectionString)
            cat = Nothing
            Debug.WriteLine("Database definition success!")
            Rslt = dBase.IsExistent
        Catch Excep As COMException
            Debug.WriteLine("Database definition failed!")
            Rslt = dBase.IsNonExistent
        Finally
            cat = Nothing
        End Try

3:      CheckDataBase = Rslt

    End Function

    Public Function CheckProductsDataBase() As dBase
        Dim Rslt As dBase = -1
        Dim dbpath As New IO.FileInfo(pth.ToString & "db.database.products.ctd")
        If Not pth.Exists Then pth.Create()
        If dbpath.Exists Then Rslt = dBase.IsExistent : GoTo 3

        Dim cat As New ADOX.Catalog()
        Try

            cat.Create(cnP.ConnectionString)
            cat = Nothing
            Debug.WriteLine("Database definition success!")
            Rslt = dBase.IsExistent
        Catch Excep As COMException
            Debug.WriteLine("Database definition failed!")
            Rslt = dBase.IsNonExistent
        Finally
            cat = Nothing
        End Try

3:      CheckProductsDataBase = Rslt

    End Function

    Public Function CheckSalesDataBase() As dBase
        Dim Rslt As dBase = -1
        Dim dbpath As New IO.FileInfo(pth.ToString & "db.database.sales.ctd")
        If Not pth.Exists Then pth.Create()
        If dbpath.Exists Then Rslt = dBase.IsExistent : GoTo 3

        Dim cat As New ADOX.Catalog()
        Try

            cat.Create(cns.ConnectionString)
            cat = Nothing
            Debug.WriteLine("Database definition success!")
            Rslt = dBase.IsExistent
        Catch Excep As COMException
            Debug.WriteLine("Database definition failed!")
            Rslt = dBase.IsNonExistent
        Finally
            cat = Nothing
        End Try

3:      CheckSalesDataBase = Rslt

    End Function

    Enum DataFile
        Exists
        NotExists
    End Enum
    Public Function createDatabase() As DataFile
        Dim r As DataFile = -1
        Dim str As String = Nothing
        If Not pth.Exists Then pth.Create()

        Dim d_f As New IO.FileInfo(String.Concat(pth.ToString, "access.main.mdf"))
        Dim d_fl As New IO.FileInfo(String.Concat(pth.ToString, "db_log.ldf"))
        Dim myConn As SqlConnection = New SqlConnection("Server=(local)\netsdk;" &
                                                    "uid=sa;pwd=;database=master")

        If d_f.Exists Then r = DataFile.Exists : GoTo 7

        str = "CREATE DATABASE MyDatabase ON PRIMARY " &
              "(NAME = qryData, " &
              " FILENAME = '" & d_f.ToString & "', " &
              " SIZE = 2MB, " &
              " MAXSIZE = 10MB, " &
              " FILEGROWTH = 10%) " &
              " LOG ON " &
              "(NAME = qyLog, " &
              " FILENAME = '" & d_fl.ToString & "', " &
              " SIZE = 1MB, " &
              " MAXSIZE = 5MB, " &
              " FILEGROWTH = 10%) "

        Dim myCommand As SqlCommand = New SqlCommand(str, myConn)

        Try
            myConn.Open()
            myCommand.ExecuteNonQuery()
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
        Dim d_f As New IO.FileInfo(String.Concat(pth.ToString, "db_Old"))
        Dim f, fN As String

        f = pth.ToString

        fN = "db_Old"

        If Not pth.Exists Then pth.Create()

        Dim r As DataFile = -1

        If d_f.Exists Then GoTo 3

        Try
            Dim Conn As New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=master;Integrated Security=True;Trusted_Connection=True;")
            Using Conn
                Conn.Open()
                Dim cmd As SqlCommand = Conn.CreateCommand
                Dim str As String = "CREATE Database {0} ON (Name= N'{0}', FileName='{1}\{0}.mdf')"
                cmd.CommandText = String.Format(str, fN, f)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("database definition success!", MsgBoxStyle.Information)
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

3:      Try
            'Dim C As New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=db_Two;Integrated Security=True;")
            Dim C As New SqlConnection("Data Source=192.168.8.100\SQLEXPRESS,1433; Network Library=DBMSSOCN; " &
                                       "Persist Security Info=False; Initial Catalog=db_Old; Integrated Security=True; MultipleActiveResultSets=True;")
            'Data Source=192.168.8.100\SQLEXPRESS,1433; Network Library=DBMSSOCN; Persist Security Info=False; Initial Catalog=db_Old; Integrated Security=True; MultipleActiveResultSets=True
            'Dim C As New SqlConnection("Data Source=192.168.8.100,1433;Network Library=DBMSSOCN;Initial Catalog=db_Old;Integrated Security=True;Trusted_Connection=True;")
            'Data Source=192.168.8.100,1433;Network Library=DBMSSOCN
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

    End Sub

    Public Function defineDatabase() As DataFile
        'Server=(localdb)\v11.0;Integrated Security=true;AttachDbFileName = C : \MyFolder\MyData.mdf;
        If Not pth.Exists Then pth.Create()
        Dim r As DataFile = -1
        'Data Source=(LocalDb)\v11.0;Initial Catalog=DB1;Integrated Security=SSPI;" providerName="System.Data.SqlClient
        Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=(LocalDb)\v11.0;Initial Catalog=master;Integrated Security=SSPI") ';providerName=System.Data.SqlClient")
        'Dim myConnectionString As SqlConnection = New SqlConnection("Data Source=(local)\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Pooling=False")
        '//since we need to create a New database set the Initial Catalog as Master
        '//Which means we are creating database under master DB
        Dim myCommand As String '//To store the sql command To be executed
        myCommand = "CREATE database my_db" '// the command that creates New database
        Dim cmd As SqlCommand = New SqlCommand(myCommand, myConnectionString) '// creating command For execution
        Try
            cmd.Connection.Open() '//open a connection With cmd
            cmd.ExecuteNonQuery() '//Execute the query
            cmd.Connection.Close() '//Close the connection
            MsgBox(" Success adding database", MsgBoxStyle.Critical, " MaS InfoTech")
        Catch
            MsgBox(" Already installed database", MsgBoxStyle.Critical, " MaS InfoTech- Warning")
        End Try
        '//Creating table to the dynamicaly created database
        Try
            Dim cn As SqlConnection = New SqlConnection("Data Source=(LocalDb)\v11.0;Initial Catalog=master;Integrated Security=SSPI")
            '//here the connection string Is initialized with Initial Catalog as my_db
            Dim sql As String '//sql query String
            sql = "CREATE TABLE customer(cus_name varchar(50) NULL,address varchar(50) NULL,mobno numeric(18, 0) NULL,tin varchar(50) NULL,kg varchar(50) NULL)"
            cmd = New SqlCommand(sql, cn) '// create command With connection And query String 
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            MsgBox(" Success adding database table", MsgBoxStyle.Critical, " MaS InfoTech")
        Catch
            MsgBox(" Already installed database", MsgBoxStyle.Critical, " MaS InfoTech- Warning")
        End Try

    End Function

End Module
