Imports System.Data.OleDb

Public Class ReUpload

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        rdUploadClients.Checked = False
        rdUploadStock.Checked = False
        rdUploadSuppliers.Checked = False
        chkRecordMode_CheckedChanged(Nothing, Nothing)
        chkAppend_CheckedChanged(Nothing, Nothing)
    End Sub

    Sub getDetails(path As IO.FileInfo, connection As OleDbConnection)
        Dim tbl As DataTable = Nothing

        Dim rC As Integer = 0

        Dim CanShow As Boolean = False

        UploadProgressDialog("Loading data. Please wait...")

        If _Data = _AccessMode.IsDownload Then
            CanShow = False

            Dim DtSz As Integer = 0

            If path Is xlpth_Clients Then
                DtSz = getTblSz("SELECT * FROM clCustomers", "clCustomers")
                rC = calcVal("SerialId", "clCustomers", CalcMode.GetCount, c)
            ElseIf path Is xlpth_Suppliers Then
                DtSz = getTblSz("SELECT * FROM clSuppliers", "clSuppliers")
                rC = calcVal("SerialId", "clSuppliers", CalcMode.GetCount, c)
            ElseIf path Is xlpth_Items Then
                DtSz = getTblSz("SELECT * FROM clItems", "clItems", cItems)
                rC = calcVal("SerialId", "clItems", CalcMode.GetCount, cItems)
            End If

            l_DataSize.Text = String.Concat("Data Size: ", Math.Round(DtSz / 1024 ^ 2, 2), "MB")

        ElseIf _Data = _AccessMode.IsUpload Then
            CanShow = True

            l_DataSize.Text = String.Concat("Data Size: ", Math.Round(path.Length / 1024 ^ 2, 2), "MB")
            l_DataFormat.Text = String.Concat("Data Format: ", path.Extension)
            l_DataDate.Text = String.Concat("File Date: ", path.CreationTime.ToShortDateString)
            l_LastModifiedDate.Text = String.Concat("Last Modified On ", path.LastWriteTime.ToShortDateString)
            If Not connection.State = ConnectionState.Open Then connection.Open()
            Dim tSQL As String = "SELECT * FROM [c_Data$]"
            Dim cmd As New OleDbCommand(tSQL, connection)
            Dim da As New OleDbDataAdapter
            da.SelectCommand = cmd
            tbl = New DataTable
            da.Fill(tbl)
            connection.Close()

            rC = tbl.Rows.Count

        End If

        l_DataFormat.Visible = CanShow

        l_DataDate.Visible = CanShow

        l_LastModifiedDate.Visible = CanShow

        l_RecordsCount.Text = String.Concat(rC, " Records Found")

    End Sub

    Private Sub chkAppend_CheckedChanged(sender As Object, e As EventArgs) Handles chkAppend.CheckedChanged
        If chkAppend.CheckState = CheckState.Checked Then
            _Save = _Mode.IsUpdate
        ElseIf chkAppend.CheckState = CheckState.Unchecked Then
            _Save = _Mode.IsSave
        End If
    End Sub

    Private Sub rdUploadStock_CheckedChanged(sender As Object, e As EventArgs) Handles rdUploadStock.CheckedChanged
        getDetails(xlpth_Items, c_p)
    End Sub
    Private Sub rdUploadSuppliers_CheckedChanged(sender As Object, e As EventArgs) Handles rdUploadSuppliers.CheckedChanged
        getDetails(xlpth_Suppliers, c_s)
    End Sub
    Private Sub rdUploadClients_CheckedChanged(sender As Object, e As EventArgs) Handles rdUploadClients.CheckedChanged
        getDetails(xlpth_Clients, c_c)
    End Sub

    Private Sub btnBeginUpload_Click(sender As Object, e As EventArgs) Handles btnBeginUpload.Click

        chkAppend_CheckedChanged(Nothing, Nothing)

        Dim r As String = Nothing
        If rdUploadClients.Checked Then
            ClientDetails.ShowDialog()
        ElseIf rdUploadStock.Checked Then
            StockDetails.ShowDialog()
        ElseIf rdUploadSuppliers.Checked Then
            SupplierDetails.ShowDialog()
        End If

    End Sub

    Private DLod As Boolean = False
    Private Sub chkRecordMode_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecordMode.CheckedChanged
        If chkRecordMode.CheckState = CheckState.Checked Then
            DLod = True
        Else
            DLod = False
        End If

        If DLod Then
            _Data = _AccessMode.IsDownload
        Else
            _Data = _AccessMode.IsUpload
        End If

        chkRecordMode.Text = IIf(DLod,
                                                "Download Records To XLSX",
                                                  "Upload Records From Database")

        Dim txt As String = Nothing
        txt = IIf(DLod, "DOWNLOAD", "UPLOAD")
        btnBeginUpload.Text = String.Concat("BEGIN ", txt)

        chkAppend.Visible = Not DLod

        If rdUploadClients.Checked Then
            rdUploadClients_CheckedChanged(Nothing, Nothing)
        ElseIf rdUploadStock.Checked Then
            rdUploadStock_CheckedChanged(Nothing, Nothing)
        ElseIf rdUploadSuppliers.Checked Then
            rdUploadSuppliers_CheckedChanged(Nothing, Nothing)
        End If

    End Sub

    Private Sub clearDb()
        Dim MReq As MsgBoxResult = MsgBox("Clear Data?", MsgBoxStyle.YesNo, "CyPOS")
        If Not MReq = MsgBoxResult.Yes Then Exit Sub
        Try
            xQry("DELETE FROM clInvoices", cTXNs)

            xQry("DELETE FROM clInvoiceToPay", cTXNs)

            xQry("DELETE FROM clInvoiceReturned",
                       cTXNs)

            xQry("DELETE FROM clTXNs", cTXNs)

            xQry("DELETE FROM clPurchases", cTXNs)

            xQry("DELETE FROM clPurchaseOrder", cTXNs)

            xQry("DELETE FROM clPurchaseReturns", cTXNs)

            xQry("DELETE FROM clTXNsOrder", cTXNs)

            xQry("DELETE FROM clTXNsReturns", cTXNs)

            xQry("DELETE FROM clStockTransfer", cTXNs)

            xQry("DELETE FROM clStockUpdateHistory", cTXNs)

            xQry("DELETE FROM clItems", cItems)

            xQry("DELETE FROM clItmPrx", cItems)
        Catch ex As Exception
            write_Error("Transactions Deletion Error", Name)
        Finally
            ShowMessage("Done!", _Method.AsInfo)
        End Try

    End Sub

End Class