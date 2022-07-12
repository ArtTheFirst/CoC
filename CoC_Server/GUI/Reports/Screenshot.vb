Imports System.ComponentModel

Public Class Screenshot

    Dim held_Shot As Bitmap
    Public Sub holdShot(bmp As Bitmap)
        img_Shot.Image = bmp
        With bmp
            MaximumSize = New Size(.Width + 15, .Height + 10)
        End With
        Size = MaximumSize
        held_Shot = bmp
        ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim prnborderX As Single
        prnborderX = PrintDocument1.DefaultPageSettings.PrintableArea.X + 1
        Dim prnborderY As Single
        prnborderY = PrintDocument1.DefaultPageSettings.PrintableArea.Y + 10
        Dim pagewidth As Single
        pagewidth = PrintDocument1.DefaultPageSettings.PrintableArea.Width
        Dim pageHeight As Single
        pageHeight = PrintDocument1.DefaultPageSettings.PrintableArea.Height

        Dim drawImg As Bitmap = held_Shot
        Dim mgHeight As Single = drawImg.Height
        Dim mgWidth As Single = drawImg.Width
        Dim sourceRectangle As New Rectangle(0, 0, mgWidth, mgHeight - 30)
        Dim destRetangle1 As New Rectangle(55, 90, pagewidth - 75, mgHeight - 30)
        e.Graphics.DrawImage(drawImg, destRetangle1, sourceRectangle, GraphicsUnit.Pixel)

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDocument1.PrinterSettings.PrinterName = IIf(My.Settings.__PrinterToUse = "",
                                                 SelectPrinter.loadPrinterName,
                                                 My.Settings.__PrinterToUse)
        PrintDocument1.PrinterSettings.DefaultPageSettings.Landscape = True
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F10 Then
            btnPrint_Click(Nothing, Nothing)
        End If

    End Sub

End Class