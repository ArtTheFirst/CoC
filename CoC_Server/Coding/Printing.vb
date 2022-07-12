Imports System.ComponentModel
Imports System.Drawing.Printing

Module Printing

    <BrowsableAttribute(False)>
    Public Property PrinterSettings As PrinterSettings
    Property Value
    Function loadPrinterName() As String
        Dim print_Name As String = ""
        Using p_s As New PrintDialog
            With p_s
                print_Name = .PrinterSettings.PrinterName
                .AllowSelection = True
                .PrinterSettings.Duplex = Duplex.Simplex
                .ShowDialog()
            End With
        End Using

        Return print_Name

        AddHandler PrintDocument1.BeginPrint, AddressOf PrintDocument1_BeginPrint
        AddHandler PrintDocument1.PrintPage, AddressOf PrintDocument1_PrintPage
        AddHandler PrintDocument1.EndPrint, AddressOf PrintDocument1_EndPrint

    End Function
    Private PrintDocument1 As New PrintDocument
    Public Sub InitiatePrint()
        PrintDocument1.PrinterSettings.PrinterName = loadPrinterName()
        DefineReceiptHeader()
        loadListOfItems()
        loadChange()
        Dim printControl = New StandardPrintController
        PrintDocument1.PrintController = printControl
        PrintDocument1.Print()

    End Sub

    Public Current As PrintAction = -1
    Public TextToPrint As String = Nothing
    Private InvHdr As String = Nothing
    Dim defaultLength As Integer = 33
    Sub DefineReceiptHeader()
        TextToPrint = ""

        Dim StringToPrint As String = ""

        StringToPrint = Environment.NewLine & Environment.NewLine
        TextToPrint &= StringToPrint

        StringToPrint = cN
        Dim LineLen As Integer = StringToPrint.Length
        Dim spcLen1 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen1 & StringToPrint & Environment.NewLine

        StringToPrint = cA
        LineLen = StringToPrint.Length
        Dim spcLen2 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen2 & StringToPrint & Environment.NewLine

        StringToPrint = Cp
        LineLen = StringToPrint.Length
        Dim spcLen3 As New String(" "c, Math.Round((33 - LineLen) / 2))
        TextToPrint &= spcLen3 & StringToPrint & Environment.NewLine

    End Sub
    Dim dg_sales As New DataGridView
    Sub loadListOfItems()
        TextToPrint &= "Description" & Environment.NewLine
        For Each row As DataGridViewRow In dg_Sales.Rows
            With row
                Dim StringToPrint As String = .Cells(4).Value & " x " & .Cells(5).Value & " = " & FormatCurrency(CInt(.Cells(7).Value) + CInt(.Cells(6).Value), 2)
                TextToPrint &= .Cells(1).Value & Environment.NewLine
                TextToPrint &= StringToPrint & Environment.NewLine
            End With
        Next

    End Sub
    Sub loadChange()
        Dim StringToPrint As String = "Sub Total               " & FormatCurrency(0, 2)
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = "Discount                " & FormatCurrency(0, 2)
        TextToPrint &= StringToPrint & Environment.NewLine
        StringToPrint = "Total                      " & FormatCurrency(0)
        TextToPrint &= StringToPrint & Environment.NewLine
        StringToPrint = "Paid                       " & FormatCurrency(0, 2)
        TextToPrint &= StringToPrint & Environment.NewLine
        StringToPrint = "Change                  " & FormatCurrency(FormatNumber(0, 2) - FormatNumber(0, 2), 2)
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = String.Concat("Receipt Cashier; ", usr)
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = 0
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = String.Concat(Date.Now.ToShortDateString, "; ", Date.Now.ToShortTimeString)
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = cT
        TextToPrint &= Environment.NewLine & StringToPrint & Environment.NewLine
        StringToPrint = My.Application.Info.CompanyName
        TextToPrint &= StringToPrint & Environment.NewLine
    End Sub

    Enum PrintAction
        Succeeded
        IsInPhase
        HasFailed
    End Enum
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Static currentChar As Integer
        Dim textfont As New Font("Corbel", 9, FontStyle.Regular)
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

        e.Graphics.MeasureString(Mid(InvHdr, currentChar + 1), New Font("Corbel", 12, FontStyle.Bold), New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(InvHdr.Substring(currentChar, chars), New Font("Corbel", 12, FontStyle.Bold), Brushes.Black, b, format)

        e.Graphics.MeasureString(Mid(TextToPrint, currentChar + 1), New Font("Corbel", 9, FontStyle.Regular), New SizeF(w, h), format, chars, line)
        e.Graphics.DrawString(TextToPrint.Substring(currentChar, chars), New Font("Corbel", 9, FontStyle.Regular), Brushes.Black, b, format)

        currentChar = currentChar + chars
        If currentChar < TextToPrint.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            currentChar = 0
        End If

    End Sub
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

End Module
