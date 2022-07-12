Imports System.ComponentModel
Imports System.Drawing.Printing

Public Class Screenshot
    'PaperSize("A4Landscape", 827, 1169)
    Dim held_Shot As Bitmap
    Public Sub holdShot(bmp As Bitmap)
        WindowState = FormWindowState.Normal
        img_Shot.Image = bmp
        With bmp
            MaximumSize = New Size(.Width + 5, .Height + 10)
        End With
        Size = MaximumSize
        held_Shot = bmp
        ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'Dim ImgView As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        'DataGridView1.DrawToBitmap(dataGridViewImage, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        'e.Graphics.DrawImage(dataGridViewImage, 0, 0)

        'Exit Sub
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
        Dim destRetangle1 As New Rectangle(55, 90, Width - 273, mgHeight - 43)
        e.Graphics.DrawImage(drawImg, destRetangle1, sourceRectangle, GraphicsUnit.Pixel)

        'PrintPreviewDialog1.Document = PrintDocument1

    End Sub

    <BrowsableAttribute(False)>
    Public Property PrinterSettings As PrinterSettings
    Property Value
    Public Sub InitiatePrint() Handles btnPrint.Click
        Try
            'Dim printControl = New StandardPrintController
            'PrintDocument1.PrintController = printControl
            With PrintPreviewDialog1
                .Document = PrintDocument1
                PrintDocument1.DefaultPageSettings.Landscape = True
                .ShowDialog()
            End With

            With PrintDocument1.PrinterSettings
                '.PrinterName = My.Settings.__PrinterToUse
            End With
        Catch ex As Exception
            write_Error("Print Failed. Reason: " & ex.Message)
            MsgBox("Print Failed. Reason: " & ex.Message)
        End Try

    End Sub

    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F10 Then
            InitiatePrint()
        End If

    End Sub

End Class