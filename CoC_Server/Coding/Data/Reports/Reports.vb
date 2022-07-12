Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Module Reports

    Private Reports_Xl As New IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Cy\init\xl")
    Public Sub ExportGridToExcel(DGV As DataGridView, Optional WorkshseetName As String = "Report")

        Dim xlFile As String = Nothing

        Dim fileName As String = "XLSX Report"

        If Not xl_pth.Exists Then xl_pth.Create()

        xlFile = xl_pth.ToString & "\" & fileName & ".xlsx"

        If DGV.Rows.Count <= 0 Then MsgBox("item count cannot be zero", MsgBoxStyle.Critical, "POS_Logger") : Exit Sub

        Try

            UploadProgressDialog()

            Dim xls As New Excel.Application
            xls.DisplayAlerts = False
            Dim book As Excel.Workbook
            Dim sheet As Excel.Worksheet
            xls.Workbooks.Add()
            book = xls.ActiveWorkbook
            sheet = book.ActiveSheet

            With DGV.Columns
                For _c = 0 To .Count - 1
                    sheet.Cells(1, _c + 1) = .Item(_c).HeaderText
                Next
            End With

            For i = 0 To DGV.RowCount - 1
                For j = 0 To DGV.ColumnCount - 1
                    sheet.Cells(i + 2, j + 1).value = DGV.Rows(i).Cells(j).Value.ToString
                Next
            Next

            sheet.Range("A1:AZ1").Font.Bold = True

            sheet.Columns.AutoFit()

            book.SaveAs(xlFile)
            xls.Workbooks.Close()
            xls.Quit()
            releaseObj(sheet)
            releaseObj(book)
            releaseObj(xls)

            If IO.File.Exists(xlFile) Then Process.Start(xlFile)

        Catch ex As Runtime.InteropServices.COMException
            MsgBox(Err.Description)
        End Try

    End Sub

    Sub releaseObj(obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Module
