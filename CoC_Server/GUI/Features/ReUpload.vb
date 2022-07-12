Imports System.Data.OleDb

Public Class ReUpload

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If

    End Sub

    Sub getDetails(path As IO.FileInfo, connection As OleDbConnection)

        UploadProgressDialog("Loading data. Please wait...")

        l_DataSize.Text = String.Concat("Data Size: ", Math.Round(path.Length / 1024 ^ 2, 2), "MB")
        l_DataFormat.Text = String.Concat("Data Format: ", path.Extension)
        l_DataDate.Text = String.Concat("File Date: ", path.CreationTime.ToShortDateString)
        l_LastModifiedDate.Text = String.Concat("Last Modified On ", path.LastWriteTime.ToShortDateString)

        If Not connection.State = ConnectionState.Open Then connection.Open()
        Dim tSQL As String = "SELECT * FROM [c_Data$]"

        Dim cmd As New OleDbCommand(tSQL, connection)

        Dim da As New OleDbDataAdapter

        da.SelectCommand = cmd

        Dim excelData As New DataTable

        da.Fill(excelData)
        connection.Close()

        l_RecordsCount.Text = String.Concat(excelData.Rows.Count, " Records Found")

    End Sub

    Sub chooseExploit()
        Dim r As String = Nothing
        If rdUploadClients.Checked Then
            r = "Clients Data"
        ElseIf rdUploadStock.Checked Then
            r = "Stock Data"
        ElseIf rdUploadSuppliers.Checked Then
            r = "Supplier Data"
        End If
        l_SelectedExploit.Text = String.Concat("Selected: ", r)

    End Sub

    Private Sub chkAppend_CheckedChanged(sender As Object, e As EventArgs) Handles chkAppend.CheckedChanged
        If rdUploadClients.Checked Or rdUploadStock.Checked Or rdUploadSuppliers.Checked Then
            _Save = IIf(chkAppend.Checked, _Mode.IsUpdate, _Mode.IsSave)
        End If

    End Sub

    Private Sub rdUploadStock_CheckedChanged(sender As Object, e As EventArgs) Handles rdUploadStock.CheckedChanged
        chooseExploit()
        getDetails(xlpth_Products, c_p)
    End Sub
    Private Sub rdUploadSuppliers_CheckedChanged(sender As Object, e As EventArgs) Handles rdUploadSuppliers.CheckedChanged
        chooseExploit()
        getDetails(xlpth_Suppliers, c_s)
    End Sub
    Private Sub rdUploadClients_CheckedChanged(sender As Object, e As EventArgs) Handles rdUploadClients.CheckedChanged
        chooseExploit()
        getDetails(xlpth_Clients, c_c)
    End Sub

    Private Sub btnBeginUpload_Click(sender As Object, e As EventArgs) Handles btnBeginUpload.Click
        Dim r As String = Nothing
        If rdUploadClients.Checked Then
            ClientDetails.ShowDialog()
        ElseIf rdUploadStock.Checked Then
            StockDetails.ShowDialog()
        ElseIf rdUploadSuppliers.Checked Then
            SupplierDetails.ShowDialog()
        End If

    End Sub

End Class