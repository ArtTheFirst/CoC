Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms

Module clCrRead

    Private clCrFrm As New Form
    Private clCrRprt As New CrystalReportViewer

    Private Sub SetupCrVw()
        If clCrFrm.IsDisposed Then
            clCrFrm = New Form
            clCrRprt = New CrystalReportViewer
        End If

        With clCrFrm
            .AutoScaleMode = AutoScaleMode.None
            .BackColor = Color.Silver
            .ClientSize = New Size(784, 441)
            .Font = New Font("Corbel", 11.0!)
            .KeyPreview = True
            .MinimizeBox = False
            .Name = "clCrFrm"
            .ShowIcon = False
            .SizeGripStyle = SizeGripStyle.Hide
            .StartPosition = FormStartPosition.CenterScreen
            .Text = " "
            .WindowState = FormWindowState.Maximized
            .ResumeLayout(False)

        End With
        AddHandler clCrFrm.FormClosed, AddressOf DisposeCrVw
        AddHandler clCrFrm.KeyDown, AddressOf HandleMe

        With clCrRprt
            .ActiveViewIndex = -1
            .BorderStyle = BorderStyle.None
            .Cursor = Cursors.Default
            .Dock = DockStyle.Fill
            .Location = New Point(0, 0)
            .Name = "clCrRprt"
            .ShowCloseButton = False
            .ShowGotoPageButton = False
            .ShowGroupTreeButton = False
            .ShowLogo = False
            .Size = New Size(784, 441)
            .TabIndex = 2
            .ToolPanelView = ToolPanelViewType.None

        End With

        clCrFrm.Controls.Add(clCrRprt)

    End Sub

    Private Sub HandleMe(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            clCrFrm.Dispose()
        End If
    End Sub

    Function headerVw() As String
        Dim rptheader As String = ""
        Select Case ThisBillMode
            Case CurrentlyIs.Purchase
                rptheader = "Purchase "
            Case CurrentlyIs.PurchaseOrder
                rptheader = "Purchase Orders "
            Case CurrentlyIs.PurchaseRemittance
                rptheader = "Purchase Remittance "
            Case CurrentlyIs.PurchaseReturns
                rptheader = "Purchase Returns "
            Case CurrentlyIs.TXNs
                rptheader = "Sales "
            Case CurrentlyIs.TXNsOrder
                rptheader = "Sales Order "
            Case CurrentlyIs.TXNsRemittance
                rptheader = "Sales Remittance"
            Case CurrentlyIs.TXNsReturns
                rptheader = "Sales Returns "
            Case CurrentlyIs.StockTransfer
                rptheader = "Stock Transfer "
        End Select
        headerVw = rptheader
    End Function
    Public Function xCr(BM As CurrentlyIs)
        Dim x As Integer = -1
        Select Case BM
            Case CurrentlyIs.Purchase, CurrentlyIs.TXNs
                x = FxQry("DELETE FROM clCrSalesPurchases")
            Case CurrentlyIs.PurchaseOrder, CurrentlyIs.TXNsOrder
                x = FxQry("DELETE FROM clCrOrders")
            Case CurrentlyIs.PurchaseRemittance, CurrentlyIs.TXNsRemittance
                x = FxQry("DELETE FROM clCrRemits")
            Case CurrentlyIs.PurchaseReturns, CurrentlyIs.TXNsReturns
                x = FxQry("DELETE FROM clCrReturns")
            Case CurrentlyIs.StockTransfer
                x = FxQry("DELETE FROM clCrTransfer")
            Case CurrentlyIs.Receipts
                x = FxQry("DELETE FROM clCrystals")
        End Select
        Return 0
    End Function
    Public Sub LoadCrVw(ByRef rptclient As String, ByRef rptdate As Date)

        UploadProgressDialog("Loading Report. Please Hold On")

        SetupCrVw()

        Try

            Dim cn As New OleDbConnection
            cn = cCr
            Dim ds As New CyDs
            Dim sql As String = ""
            Dim sqlparam As String = ""
            Dim table As String = ""
            Dim objrpt As ReportDocument = Nothing

            Select Case ThisBillMode
                Case CurrentlyIs.Purchase, CurrentlyIs.TXNs
                    sqlparam = "SerialId,clName,clQty,clPrice,clDiscount"
                    table = "clCrSalesPurchases"
                    'fxQry("DELETE FROM " & table)
                    objrpt = New clCrSalesPurchases
                Case CurrentlyIs.PurchaseOrder, CurrentlyIs.TXNsOrder
                    sqlparam = "SerialId,clName,clQty,clPrice"
                    table = "clCrOrders"
                    'fxQry("DELETE FROM " & table)
                    objrpt = New clCrOrders
                Case CurrentlyIs.PurchaseRemittance, CurrentlyIs.TXNsRemittance
                    sqlparam = "clUser,clQty,clBillAmt,clDiscount,clCash,clPOS,clBank,clRRN,clCredit"
                    table = "clCrRemits"
                    'fxQry("DELETE FROM " & table)
                    objrpt = New clCrRemit
                Case CurrentlyIs.PurchaseReturns, CurrentlyIs.TXNsReturns
                    sqlparam = "SerialId,clName,clQtyInit,clPriceInit,clQtyRet,clPriceRet"
                    table = "clCrReturns"
                    'fxQry("DELETE FROM " & table)
                    objrpt = New clCrReturns
                Case CurrentlyIs.StockTransfer
                    sqlparam = "SerialId,clName,clQty,clPrice"
                    table = "clCrTransfer"
                    'fxQry("DELETE FROM " & table)
                    objrpt = New clCrTransfers
                Case CurrentlyIs.Receipts
                    sqlparam = "SerialId,clName,clQty,clPrice,clDiscount"
                    table = "clCrystals"
                    'fxQry("DELETE FROM " & table)
                    objrpt = New clCrReceipts
            End Select

            sql = "SELECT " & sqlparam & " FROM " & table

            Dim dscmd As New OleDbDataAdapter(sql, cn)
            dscmd.Fill(ds, table)

            Dim rptobj As TextObject = Nothing
            rptobj = objrpt.ReportDefinition.ReportObjects("tCompany")
            rptobj.Text = String.Concat("Company Name: ", Cnfg.CompanyName.ToString)

            Try
                rptobj = objrpt.ReportDefinition.ReportObjects("tClient")
                rptobj.Text = String.Concat(IIf(ThisBillMode = CurrentlyIs.StockTransfer, "Branch: ", "Client: "), rptclient)
            Catch ex As Exception
                rptobj = Nothing
            End Try

            rptobj = objrpt.ReportDefinition.ReportObjects("tHeader")
            rptobj.Text = String.Concat(headerVw, "Report")
            rptobj = objrpt.ReportDefinition.ReportObjects("tDate")
            rptobj.Text = String.Concat("Invoice Date: ", rptdate.ToShortDateString)

            'MsgBox(sql & vbNewLine & " : " & ds.Tables(table).Rows.Count)

            objrpt.SetDataSource(ds.Tables(table))
            clCrRprt.ReportSource = objrpt
            objrpt.Refresh()
            clCrRprt.Refresh()

            If Not cn.State = ConnectionState.Closed Then cn.Close()

            clCrFrm.ShowDialog()

        Catch ex As Exception
            write_Error(ex.Message, "CrVw")
        End Try

    End Sub

    Public Sub LoadCrVw(bM As BillMode,
                           CrQty As Object,
                           Optional ByVal Srl As String = "",
                           Optional ByVal CrName As Object = "",
                           Optional ByVal CrPrice As Object = 0,
    Optional ByVal CrDiscount As Object = 0,
    Optional ByVal CrUsr As Object = "",
    Optional ByVal CrBillAmt As Object = 0,
    Optional ByVal CrCash As Object = 0,
    Optional ByVal CrPOS As Object = 0,
    Optional ByVal CrBank As Object = 0,
    Optional ByVal CrRRN As Object = 0,
    Optional ByVal CrCredit As Object = 0,
                  Optional ByVal CrRetQty As Object = 0,
                        Optional ByVal CrRetPrice As Object = 0)

        Dim table As String = ""
        Dim sqlparam As String = ""
        Select Case bM
            Case CurrentlyIs.Purchase, CurrentlyIs.TXNs
                FxQry("INSERT INTO clCrSalesPurchases (SerialId,clName,clQty,clPrice,clDiscount) " &
                                      "VALUES ('" & Srl & "','" & CrName & "','" & CrQty & "','" & CrPrice & "','" & CrDiscount & "')")

            Case CurrentlyIs.PurchaseOrder, CurrentlyIs.TXNsOrder
                FxQry("INSERT INTO clCrOrders (SerialId,clName,clQty,clPrice) " &
                                      "VALUES ('" & Srl & "','" & CrName & "','" & CrQty & "','" & CrPrice & "')")

            Case CurrentlyIs.PurchaseRemittance, CurrentlyIs.TXNsRemittance
                FxQry("INSERT INTO clCrRemits (clUser,clQty,clBillAmt,clDiscount,clCash,clPOS,clBank,clRRN,clCredit) " &
                                      "VALUES ('" & CrUsr & "','" & CrQty & "','" & CrBillAmt & "'," &
                                                    "'" & CrDiscount & "','" & CrCash & "','" & CrPOS & "','" & CrBank & "','" & CrRRN & "','" & CrCredit & "')")

            Case CurrentlyIs.PurchaseReturns, CurrentlyIs.TXNsReturns
                FxQry("INSERT INTO clCrReturns (SerialId,clName,clQtyInit,clPriceInit,clQtyRet,clPriceRet) " &
                                      "VALUES ('" & Srl & "','" & CrName & "','" & CrQty & "','" & CrPrice & "','" & CrRetQty & "','" & CrRetPrice & "')")

            Case CurrentlyIs.StockTransfer
                FxQry("INSERT INTO clCrTransfer (SerialId,clName,clQty,clPrice) " &
                                      "VALUES ('" & Srl & "','" & CrName & "','" & CrQty & "','" & CrPrice & "')")

            Case CurrentlyIs.Receipts
                FxQry("INSERT INTO clCrystals (SerialId,clName,clQty,clPrice,clDiscount) " &
                                      "VALUES ('" & Srl & "','" & CrName & "','" & CrQty & "','" & CrPrice & "','" & CrDiscount & "')")

        End Select

    End Sub

    Sub DisposeCrVw()
        clCrRprt.Dispose()
        clCrFrm.Dispose()
    End Sub

End Module
