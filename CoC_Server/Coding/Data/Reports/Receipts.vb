Imports System.ComponentModel
Imports System.Drawing.Printing
Module Receipts

    Public Function payMeans() As String
        Select Case PayMode
            Case _Is.Cash
                payMeans = "CASH"
            Case _Is.CashPOS
                payMeans = "CASH / POS"
            Case _Is.CashPOSBank
                payMeans = "CASH / POS / Bank"
            Case _Is.CashBank
                payMeans = "CASH / Bank"
            Case _Is.Credit
                payMeans = "CREDIT"
            Case _Is.POS
                payMeans = "POS"
            Case _Is.POSBank
                payMeans = "POS / Bank"
            Case _Is.Bank
                payMeans = "Bank"
            Case _Is.RRN
                payMeans = "RRN"
            Case _Is.CashRRN
                payMeans = "Cash / RRN"
            Case _Is.POSRRN
                payMeans = "POS / RRN"
            Case _Is.BankRRN
                payMeans = "Bank / RRN"
            Case _Is.CashPOSRRN
                payMeans = "Cash / POS / RRN"
            Case _Is.CashBankRRN
                payMeans = "Cash / Bank / RRN"
            Case _Is.POSBankRRN
                payMeans = "POS / Bank / RRN"
            Case _Is.CashPOSBankRRN
                payMeans = "Cash / POS / Bank / RRN"
            Case Else
                payMeans = ""
        End Select

    End Function

    Enum PrintAction
        Succeeded
        IsInPhase
        HasFailed
    End Enum
    Public Current As PrintAction = -1
    Private Sub PrintDocument1_EndPrint(sender As Object, e As PrintEventArgs)
        Current = PrintAction.IsInPhase
    End Sub
    Private Sub PrintDocument1_BeginPrint(sender As Object, e As PrintEventArgs)
        If e.PrintAction = Drawing.Printing.PrintAction.PrintToPrinter Then
            Current = PrintAction.Succeeded
        Else
            Current = PrintAction.HasFailed
        End If
    End Sub

    Private TextToPrint As String = Nothing
    Private PrintDocument1 As New PrintDocument
    Private Sub loadDetails()
        HeaderText = ""
        TextToPrint = ""
        Cnfg.Reload()
    End Sub
    Sub loadPrint()
        PrintDocument1 = New PrintDocument
        AddHandler PrintDocument1.BeginPrint, AddressOf PrintDocument1_BeginPrint
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
        AddHandler PrintDocument1.EndPrint, AddressOf PrintDocument1_EndPrint
    End Sub

    Private HeaderText As String = Nothing
    Sub DefineReceiptHeader()
        HeaderText = "________________________" & Environment.NewLine
        Dim StringToPrint As String = Cnfg.CompanyName
        HeaderText &= StringToPrint & Environment.NewLine
        StringToPrint = Cnfg.CompanyAddress
        HeaderText &= StringToPrint & Environment.NewLine
        StringToPrint = Cnfg.CompanyType
        HeaderText &= StringToPrint & Environment.NewLine &
                            "________________________" '& Environment.NewLine
    End Sub

    Sub loadListOfItems(dgObj As DataGridView)

        Dim HeaderDivision As String = Nothing

        HeaderDivision = Environment.NewLine &
                                    Environment.NewLine &
                                    Environment.NewLine &
                                    Environment.NewLine &
                                    Environment.NewLine &
                                    Environment.NewLine

        Dim InvChk As String = IIf(ThisCurrent = BillMode.IsNew, "", Environment.NewLine & " (Reprint Copy)")

        Dim InvPointer As String = Environment.NewLine &
                            UCase(String.Concat("Invoice Code:",
                                                       Space(1),
                                                       Inv, InvChk,
                                                       Environment.NewLine)) &
            Environment.NewLine &
            Environment.NewLine
        TextToPrint &= HeaderDivision &
                                InvPointer &
                                "ITEMS LIST" &
                                Environment.NewLine & Environment.NewLine
        For Each row As DataGridViewRow In dgObj.Rows
            With row
                If Not Trim(.Cells(1).Value) = "" Then
                    Dim StringToPrint As String = spC(Trim(.Cells(1).Value) & " x " & .Cells(2).Value & " Units") & Environment.NewLine
                    TextToPrint &= StringToPrint & "=" & .Cells(5).Value & Environment.NewLine
                End If
            End With
        Next
        '.Cells(2).Value & " x " & .Cells(6).Value & " Units"
    End Sub
    Function spC(charc As String) As String
        Dim f As String = Nothing
        Try
            If charc.Length >= 33 Then
                Dim g As String = charc.Substring(0, 33)
                Dim h As String = charc.Substring(33)
                f = g & vbNewLine & h
            Else
                f = charc
            End If
        Catch ex As Exception
            f = charc
        End Try

        spC = f

    End Function
    Function DTC(TextToCut As String) As String
        HeaderText = ""
        Dim StringToPrint As String = TextToCut
        Dim LineLen As Integer = TextToCut.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2))
        HeaderText &= spcLen1 & StringToPrint
        DTC = HeaderText
        StringToPrint = ""
        LineLen = 0
    End Function
    Sub loadChange()
        TextToPrint &= "---------------------------------" & Environment.NewLine
        Dim StringToPrint As String = "Sub Total:" & Space(9) & FormatNumber(FindSubTotal, 0)
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = "Discount:" & Space(10) & DiscountString
        TextToPrint &= StringToPrint & Environment.NewLine
        StringToPrint = "Total:" & Space(13) & FormatNumber(_SubTotal - Discounts, 0)
        TextToPrint &= StringToPrint & Environment.NewLine & Environment.NewLine
        StringToPrint = "Amt. Paid:" & Space(9) & FormatNumber(AmountPaid, 0)
        TextToPrint &= StringToPrint & Environment.NewLine

        Dim change As Long = AmountPaid - (_SubTotal - Discounts)

        StringToPrint = IIf(change <= 0, " ", "Change:" & Space(12) & FormatNumber(change, 0))
        TextToPrint &= IIf(change <= 0, " ", Environment.NewLine & StringToPrint & Environment.NewLine)

        StringToPrint = "---------------------------------"
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = String.Concat("Receipt Issued By:", Space(2), usr)
        TextToPrint &= StringToPrint & Environment.NewLine
        StringToPrint = String.Concat("Paid With:", Space(10), payMeans)
        TextToPrint &= StringToPrint & Environment.NewLine
        StringToPrint = "---------------------------------"
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = String.Concat(Date.Now.ToShortDateString, " ", Date.Now.ToShortTimeString)
        TextToPrint &= StringToPrint
        StringToPrint = "__________________________________"
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = UCase(spC("Thanks for your patronage.       Do come again"))
        TextToPrint &= StringToPrint & Environment.NewLine

    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Static currentChar As Integer

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = 0
            w = 0
            left = 0
            top = 0
        End With

        Dim lines As Integer = CInt(Math.Round(h / 1))
        Dim b As New Rectangle(left, top, w, h)
        Dim format As StringFormat
        format = New StringFormat(StringFormatFlags.LineLimit)
        Dim line, chars As Integer

        e.Graphics.MeasureString(Mid(HeaderText, currentChar + 1), New Font("Arial", 14, FontStyle.Bold), New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(HeaderText.Substring(currentChar, chars), New Font("Arial", 14, FontStyle.Bold), Brushes.Black, b, format)

        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), New Font("Consolas", 10, FontStyle.Regular), New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Consolas", 10, FontStyle.Regular), Brushes.Black, b, format)

        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If

    End Sub

    <BrowsableAttribute(False)>
    Public Property PrinterSettings As PrinterSettings
    Property Value
    Public Sub InitiatePrint(dgObj As DataGridView)
        Try
            loadDetails()
            DefineReceiptHeader()
            loadListOfItems(dgObj)
            loadChange()
            loadPrint()
            With PrintDocument1.PrinterSettings
                .PrinterName = My.Settings.__PrinterToUse
            End With
            Dim printControl = New StandardPrintController
            PrintDocument1.PrintController = printControl
            PrintDocument1.Print()

        Catch ex As Exception
            write_Error("Print Failed. Reason: " & ex.Message)
            MsgBox("Print Failed. Reason: " & ex.Message)
        End Try

    End Sub

End Module
