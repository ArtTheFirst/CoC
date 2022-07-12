Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Environment
Imports System.IO
Imports System.Text
Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions
Imports Npgsql
Imports System.Net

Module Dclr
    Public NullVal As String = ""
    Public Nullify As String = Space(1)

    '0, 174, 219

    Public Function v(value)
        Dim r
        Try
            r = value * 1
        Catch ex As Exception
            r = 0
        End Try
        v = r
    End Function

    Enum CalcMode
        GetCount
        GetSum
    End Enum
    Public Function calcVal(Field As String,
                                         Table As String, Expected As CalcMode,
                                         Optional ByVal c As NpgsqlConnection = Nothing,
                                         Optional ByVal Condition As String = "") As Integer
        Dim intRslt = Nothing
        c = IIf(c Is Nothing, c, c)
        Dim Query As String = String.Concat("SELECT * FROM ", Table, Condition)
        Dim tbl As DataTable = xRead(Query, Table, c)

        Dim getResult = Nothing
        If Expected = CalcMode.GetCount Then
            getResult = tbl.Rows.Count
        ElseIf Expected = CalcMode.GetSum Then
            getResult = tbl.Compute("Sum(" & Field & ")", "")
        End If

        intRslt = IIf(getResult Is Nothing Or getResult Is DBNull.Value, 0, getResult)

        Return CInt(intRslt)
    End Function

    Public Function FindDiag() As String
        Dim Rslt As String = Nothing

        Using nImg As New OpenFileDialog
            With nImg
                .CheckFileExists = True
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Select File"
                Dim BrReq As DialogResult = .ShowDialog()
                If Not BrReq = DialogResult.OK Then Rslt = "" : GoTo 7
                Rslt = .FileName.ToString
            End With
        End Using

7:      Return Rslt

    End Function

    Public Function OpenDiag() As String
        Dim Rslt As String = Nothing

        Using nImg As New OpenFileDialog
            With nImg
                .CheckFileExists = True
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Select Image File"
                .Filter() = "BMP (*.bmp)|*.bmp|" &
                                 "JPG (*.jpg)|*.jpg|" &
                                 "PNG (*.png)|*.png"
                Dim BrReq As DialogResult = .ShowDialog()
                If Not BrReq = DialogResult.OK Then Rslt = "" : GoTo 7
                Rslt = .FileName.ToString
            End With
        End Using

7:      Return Rslt

    End Function

    Function sCs(word As String)
        word = LCase(word)

        Dim fullWord As String = Nothing

        fullWord = StrConv(word, VbStrConv.ProperCase)

        Return fullWord

    End Function

    Public Function BreakImgToByt(Img As Image) As Byte()
        Dim imgCon As New ImageConverter()
        Return DirectCast(imgCon.ConvertTo(Img, GetType(Byte())), Byte())
    End Function

    Public Function slicegGrid2(Dgv As DataGridView)
        Dim Data As New List(Of String())
        For Each r As DataGridViewRow In Dgv.Rows
            If r.Cells(0).Value IsNot Nothing Then
                Data.Add(r.Cells(0).Value.ToString().Split(","c))
            End If
        Next
        MessageBox.Show(String.Join(", ", Data))
    End Function

    Private arr()
    Public Function SliceGrid(DGV As DataGridView, InitCount As Integer, columnIndex As Integer)
        ReDim arr(InitCount)
        For i = 0 To InitCount - 1
            Dim row As DataGridViewRow = DGV.Rows(i)
            arr(i) = row.Cells(columnIndex).Value
        Next
        SliceGrid = String.Join(",", arr)
    End Function
    Public Function Slicelist(LB As ListBox, InitCount As Integer, columnIndex As Integer)
        ReDim arr(InitCount)
        For i = 0 To InitCount - 1
            arr(i) = LB.Items(i).ToString
        Next
        Slicelist = String.Join(",", arr)
    End Function

    Public Function RenderSqlString(InitLogic As String, TableName As String, Logic As String) As String
        Dim t As String = TableName & "='" & InitLogic.Replace(",", "' " & Logic & " " & TableName & "='") & "ampersand999888"
        Dim render As String = ""
        render = t.Replace(" " & Logic & " " & TableName & "='ampersand999888", "")
        RenderSqlString = render.Replace("='ampersand999888", " IS NOT NULL")
    End Function

    Public Function AutoCompleteBox(ByVal filter As String, Table_ As String,
                                    Optional ByVal cb As NpgsqlConnection = Nothing,
                                    Optional ByVal Lod As Boolean = False,
                                    Optional ByVal condition As String = "") As AutoCompleteStringCollection
        cb = IIf(cb Is Nothing, c, cb)

        Dim query As String = "SELECT " & filter & " FROM " & Table_ & condition
        Dim ds As New DataSet
        If Not cb.State = ConnectionState.Open Then cb.Open()
        Dim cmd As New NpgsqlCommand(query, cb)
        Dim da As New NpgsqlDataAdapter(cmd)
        da.Fill(ds, Table_)
        cb.Close()
        Dim t1 As DataTable = ds.Tables(Table_)
        Dim col As New AutoCompleteStringCollection

        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)(filter).ToString())
        Next

        Return col

    End Function
    Public Sub autosText(obj As Object, ByVal filter As String, Table_ As String,
                         Optional ByVal c As NpgsqlConnection = Nothing,
                         Optional ByVal Lod As Boolean = False,
                         Optional ByVal condition As String = "")
        obj.AutoCompleteSource = AutoCompleteSource.CustomSource
        obj.AutoCompleteCustomSource = AutoCompleteBox(filter, Table_, c, Lod, condition)

        If Not Lod Then
            obj.AutoCompleteMode = AutoCompleteMode.Suggest
        Else
            obj.AutoCompleteMode = AutoCompleteMode.None
        End If

    End Sub

    Public Function GetIPAddress()
        Dim strHostName As String = Nothing
        Dim strIPAddress As String = Nothing
        strHostName = Dns.GetHostName()
        Return Dns.GetHostByName(strHostName).AddressList(0).ToString()
        'MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)

        Dim hostname As IPHostEntry = Dns.GetHostByName(strHostName)
        Dim ip As IPAddress() = hostname.AddressList
        Return ip(0).ToString()

    End Function

End Module
