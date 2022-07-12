Imports System.ComponentModel
Imports System.IO
Imports Npgsql
Imports NpgsqlTypes
Imports System.Windows

Public Class AddItemAvatar

    Protected pId As String = ""
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)

        Code = ""

        CurrentItem = SearchIs.Create

        t_ItemName.Clear()
        itemId.Text = itemId.Tag
        itemCode.Text = itemCode.Tag
        pId = ""
        Try
            usrAvatar.Image.Dispose()
        Catch ex As Exception
        End Try

        If Not Code = "" Then
            pId = Code
            loadUp()
            Code = ""
        End If

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        CurrentItem = SearchIs._IsAbsolutelyNothing
    End Sub
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.KeyData = Keys.Escape Then
            Close()
        End If
    End Sub
    Sub loadUp()

        Try

            Dim tbl As DataTable = xRead("SELECT clName,clBarcode FROM clItmPrx WHERE SerialId='" & pId & "'", "clItmPrx", cItems)
            For Each row As DataRow In tbl.Rows
                t_ItemName.Text = row(0).ToString
                itemId.Text = String.Concat(itemId.Tag, pId)
                itemCode.Text = String.Concat(itemCode.Tag, row(1).ToString)
            Next

            'tbl.Clear()

            tbl = xRead("SELECT clAvatar FROM clItemsDetails" &
                        " WHERE SerialId='" &
                        pId & "'",
                        "clItemsDetails",
                        cItems)

            For Each row In tbl.Rows
                If Not row(0) Is DBNull.Value Then
                    Using mStream As New MemoryStream(CType(row(0), Byte()))
                        usrAvatar.Image = Image.FromStream(mStream, True)   '
                    End Using
                End If

            Next

            tbl.Dispose()

        Catch ex As Exception
            write_Error("Image read error" & ex.Message, Name)
        End Try

    End Sub

    Sub UpdateImage() Handles usrAvatar.Click, btn_AvatarSelect.Click
        Dim IMG As String = ""
        If pId = "" Then Exit Sub
        Try
            Dim fi As Image = Image.FromFile(OpenDiag)
            If fi Is Nothing Then Exit Sub
            Dim buffer As Byte() = Nothing

            buffer = BreakImgToByt(fi)

            Dim Sql As String = "UPDATE clItemsDetails SET clAvatar=@clAvatar,clLastModif=@clLastModif " &
                                                                     "WHERE SerialId='" & pId & "'"
            With cItems
                If Not .State = ConnectionState.Open Then .Open()
            End With
            Dim cm As New NpgsqlCommand(Sql, cItems)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clAvatar", NpgsqlDbType.Bytea)).Value = buffer
                .Parameters.Add(New NpgsqlParameter("@clLastModif", NpgsqlDbType.Varchar)).Value = Date.Now.ToShortDateString

                Dim gReq As MsgBoxResult = MsgBox("Update Image?", MsgBoxStyle.YesNo)

                If Not gReq = MsgBoxResult.Yes Then loadUp() : Exit Sub

                Dim fSnd As Integer = .ExecuteNonQuery()
                If fSnd > 0 Then
                    If Not cItems.State = ConnectionState.Closed Then cItems.Close()
                    loadUp()
                End If
            End With

        Catch ex As Exception
            write_Error("Image write error" & ex.Message, Name)
        End Try

    End Sub

    Private Sub t_ItemName_KeyDown(sender As Object, e As KeyEventArgs) Handles t_ItemName.KeyDown
        If e.KeyCode = Keys.Enter Then
            CurrentItem = SearchIs.Create
            Dim f As New ItemSearch
            If Not f.Visible Then f.ShowDialog()
            If Code = "" Then Exit Sub
            pId = Code
            Code = ""

            loadUp()

        End If
    End Sub

End Class