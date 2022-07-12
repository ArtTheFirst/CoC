Imports System.ComponentModel

Public Class StockLedgerSummary

    Private tbl As DataTable = Nothing
    Sub DisbandTbl()
        Try
            tbl.Clear()
            dg_List.DataSource = tbl
            dg_List.DataSource = Nothing
            dg_List.Columns.Clear()
            dg_List.Rows.Clear()
        Catch ex As Exception
        End Try
    End Sub
    Sub LoadUp()
        If SQLDate = "" Then Close()

        Dim hdrTxt As String = Nothing

        Dim FilteredString As String = Nothing
        Try
            FilteredString = SQLDate.ToString.Replace("/", "").Replace("-", "").Replace("=", "").Replace("'", "")
        Catch ex As Exception
        End Try
        Dim TbNm As String = String.Concat("clStockStatus", FilteredString)

        Try
            hdrTxt = String.Concat("Stock Summary;  ", SQLDate).Replace("'", "").Replace("=", "").Replace("BETWEEN", "")
        Catch ex As Exception
            hdrTxt = String.Concat("Stock Summary;  ", SQLDate)
        End Try

        HeaderText.Text = hdrTxt

        DisbandTbl()

        Try
            tbl = xRead("SELECT clDate,clItemId,clName," &
                                             "clStockOpening,clStockOpeningAmt," &
                                             "clStockTransfer,clStockTransferAmt," &
                                              "clTXNs,clTXNsAmt,clStockPurchase,clStockPurchaseAmt," &
                                              "clTXNsReturns,clTXNsReturnsAmt,clPurchaseReturns,clPurchaseReturnsAmt," &
                                              "clTXNsOrders,clTXNsOrdersAmt,clPurchaseOrders,clPurchaseOrdersAmt," &
                                              "clStockClosing,clStockClosingAmt" &
                                              " FROM " &
                                              TbNm,
                        TbNm,
                        cTXNs)

            dg_List.DataSource = tbl

            dg_List.Columns.Item(0).HeaderText = "DATE"
            dg_List.Columns.Item(0).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
            dg_List.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_List.Columns.Item(0).Width = 100

            dg_List.Columns.Item(1).HeaderText = "CODE"
            dg_List.Columns.Item(1).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
            dg_List.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_List.Columns.Item(1).Width = 150

            dg_List.Columns.Item(2).HeaderText = "ITEM NAME"
            dg_List.Columns.Item(2).DefaultCellStyle.Font = New Font("Corbel", 12, FontStyle.Regular)
            dg_List.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft
            dg_List.Columns.Item(2).Width = 420

            dg_List.Columns.Item(3).HeaderText = "OPENING STOCK (QTY)"
            dg_List.Columns.Item(3).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(3).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(3).Width = 210

            dg_List.Columns.Item(4).HeaderText = "OPENING STOCK (AMT.)"
            dg_List.Columns.Item(4).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(4).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(4).Width = 240

            dg_List.Columns.Item(5).HeaderText = "TRANSFERS (QTY)"
            dg_List.Columns.Item(5).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(5).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(5).Width = 210

            dg_List.Columns.Item(6).HeaderText = "TRANSFERS (AMT.)"
            dg_List.Columns.Item(6).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(6).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(6).Width = 240

            dg_List.Columns.Item(7).HeaderText = "TXNS (QTY)"
            dg_List.Columns.Item(7).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(7).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(7).Width = 210

            dg_List.Columns.Item(8).HeaderText = "TXNS (AMT.)"
            dg_List.Columns.Item(8).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(8).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(8).Width = 240

            dg_List.Columns.Item(9).HeaderText = "PURCHASES (QTY)"
            dg_List.Columns.Item(9).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(9).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(9).Width = 210

            dg_List.Columns.Item(10).HeaderText = "PURCHASES (AMT.)"
            dg_List.Columns.Item(10).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(10).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(10).Width = 240

            dg_List.Columns.Item(11).HeaderText = "TXNS RETURNS (QTY)"
            dg_List.Columns.Item(11).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(11).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(11).Width = 210

            dg_List.Columns.Item(12).HeaderText = "TXNS RETURNS (AMT.)"
            dg_List.Columns.Item(12).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(12).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(12).Width = 240

            dg_List.Columns.Item(13).HeaderText = "PURCHASE RETURNS (QTY)"
            dg_List.Columns.Item(13).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(13).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(13).Width = 210

            dg_List.Columns.Item(14).HeaderText = "PURCAHSE RETURNS (AMT.)"
            dg_List.Columns.Item(14).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(14).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(14).Width = 240

            dg_List.Columns.Item(15).HeaderText = "TXNS ORDERS (QTY)"
            dg_List.Columns.Item(15).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(15).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(15).Width = 210

            dg_List.Columns.Item(16).HeaderText = "TXNS ORDERS (AMT.)"
            dg_List.Columns.Item(16).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(16).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(16).Width = 240

            dg_List.Columns.Item(17).HeaderText = "PURCHASE ORDERS (QTY)"
            dg_List.Columns.Item(17).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(17).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(17).Width = 210

            dg_List.Columns.Item(18).HeaderText = "PURCHASE ORDERS (AMT.)"
            dg_List.Columns.Item(18).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(18).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(18).Width = 240

            dg_List.Columns.Item(19).HeaderText = "CLOSING STOCK (QTY)"
            dg_List.Columns.Item(19).DefaultCellStyle.Format = "n0"
            dg_List.Columns.Item(19).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(19).Width = 210

            dg_List.Columns.Item(20).HeaderText = "CLOSING STOCK (AMT.)"
            dg_List.Columns.Item(20).DefaultCellStyle.Format = "n2"
            dg_List.Columns.Item(20).DefaultCellStyle.Font = New Font("Consolas", 12, FontStyle.Regular)
            dg_List.Columns.Item(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
            dg_List.Columns.Item(20).Width = 240

            dg_List.ReadOnly = True

        Catch ex As Exception
            Close()
        End Try

    End Sub
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        DatePanel = ShouldBe.Contracted
        LoadUp()
    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        DisbandTbl()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ExportGridToExcel(dg_List)
    End Sub
    Private Sub btnModifyDate_Click(sender As Object, e As EventArgs) Handles btnModifyDate.Click
        DatePanel = ShouldBe.Contracted
        Dim f As New DateControl
        If Not f.Visible Then f.ShowDialog()
        LoadUp()
    End Sub

End Class