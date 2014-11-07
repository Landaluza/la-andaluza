

Public Class Etiquetador
    Private documentoImpresoraEtiquetas As System.Drawing.Printing.PrintDocument
    Private PrintDialogEtiquetas As PrintDialog
    Private PageSetupDialogEtiquetas As PageSetupDialog
    Private PrintPreviewDialogEtiquetas As PrintPreviewDialog
    Private panel As Panel

    Public dpi As Integer = 800 '7200
    'Private image As Bitmap

    Public Sub New()
        PrintDialogEtiquetas = New PrintDialog()
        PageSetupDialogEtiquetas = New PageSetupDialog
        documentoImpresoraEtiquetas = New System.Drawing.Printing.PrintDocument
        documentoImpresoraEtiquetas.OriginAtMargins = True
        PageSetupDialogEtiquetas.Document = documentoImpresoraEtiquetas
        PrintDialogEtiquetas.Document = documentoImpresoraEtiquetas
    End Sub

    Private Sub cargar_ajustes()
        Dim archivo As New BasesParaCompatibilidad.File
        PrintDialogEtiquetas.PrinterSettings = archivo.loadObject(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/PrintDialogEtiquetas.obj")
        PageSetupDialogEtiquetas.PrinterSettings = archivo.loadObject(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/PageSetupDialogEtiquetas.obj")
        PageSetupDialogEtiquetas.PageSettings = archivo.loadObject(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/PageSetupDialogEtiquetas2.obj")
        'PrintPreviewDialogEtiquetas = archivo.loadObject("PrintPreviewDialogEtiquetas.obj")
        documentoImpresoraEtiquetas.PrinterSettings = archivo.loadObject(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/documentoImpresoraEtiquetas.obj")
        PageSetupDialogEtiquetas.Document = documentoImpresoraEtiquetas
        PrintDialogEtiquetas.Document = documentoImpresoraEtiquetas
    End Sub

    Private Sub guardar_ajustes()
        Dim archivo As New BasesParaCompatibilidad.File
        archivo.saveObject(PrintDialogEtiquetas.PrinterSettings, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/PrintDialogEtiquetas.obj")
        archivo.saveObject(PageSetupDialogEtiquetas.PrinterSettings, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/PageSetupDialogEtiquetas.obj")
        archivo.saveObject(PageSetupDialogEtiquetas.PageSettings, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/PageSetupDialogEtiquetas2.obj")
        'archivo.saveObject(PrintPreviewDialogEtiquetas, "PrintPreviewDialogEtiquetas.obj")
        archivo.saveObject(documentoImpresoraEtiquetas.PrinterSettings, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "/documentoImpresoraEtiquetas.obj")
        PageSetupDialogEtiquetas.Document = documentoImpresoraEtiquetas
        PrintDialogEtiquetas.Document = documentoImpresoraEtiquetas
    End Sub

    Private Sub pedir_ajustes()
        While Not Me.PrintDialogEtiquetas.ShowDialog() = Windows.Forms.DialogResult.OK

        End While

        With Me.PageSetupDialogEtiquetas
            'Assign the document to use
            .Document = Me.documentoImpresoraEtiquetas
            'Enable printer button
            .AllowPrinter = True
            .EnableMetric = True
            .PrinterSettings = Me.PageSetupDialogEtiquetas.PrinterSettings
            While Not .ShowDialog = Windows.Forms.DialogResult.OK
                ' Initialize the dialog's PrinterSettings property to hold user
                ' defined page settings.
                Me.PageSetupDialogEtiquetas.PageSettings = _
                    New System.Drawing.Printing.PageSettings
                ' Initialize dialog's PrinterSettings property to hold user
                ' set printer settings.
                .PrinterSettings = _
                    New System.Drawing.Printing.PrinterSettings
            End While
        End With


        Me.PrintPreviewDialogEtiquetas = New PrintPreviewDialog

        Me.PrintPreviewDialogEtiquetas.Document = Me.documentoImpresoraEtiquetas
    End Sub

    Public Sub reconfigurar()
        PrintDialogEtiquetas = New PrintDialog()
        PageSetupDialogEtiquetas = New PageSetupDialog
        documentoImpresoraEtiquetas = New System.Drawing.Printing.PrintDocument
        documentoImpresoraEtiquetas.OriginAtMargins = True
        PageSetupDialogEtiquetas.Document = documentoImpresoraEtiquetas
        PrintDialogEtiquetas.Document = documentoImpresoraEtiquetas

        Try
            cargar_ajustes()
        Catch ex As Exception
        End Try

        pedir_ajustes()

        Try
            guardar_ajustes()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub setup()

        Dim sin_ajustes As Boolean
        Try
            cargar_ajustes()
            sin_ajustes = False
        Catch ex As Exception
            sin_ajustes = True
        End Try

        If sin_ajustes Then
            pedir_ajustes()

            Try
                guardar_ajustes()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub printPanel(ByRef panel As Panel)
        Me.panel = panel
        'DESACTIVADO HASTA PRUEBAS
        AddHandler Me.documentoImpresoraEtiquetas.PrintPage, AddressOf PDoc_PrintPage
        'Aumentarcalidad()
        Me.documentoImpresoraEtiquetas.Print()
        RemoveHandler Me.documentoImpresoraEtiquetas.PrintPage, AddressOf PDoc_PrintPage
    End Sub

    Private Sub PDoc_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)


        PrintToGraphics(e.Graphics, e.MarginBounds)
    End Sub

    
    'Private Sub Aumentarcalidad()


    '    Dim width As Integer
    '    Dim height As Integer



    '    Using dpGRaphics As Graphics = Me.panel.CreateGraphics
    '        width = Convert.ToInt32(panel.Width * dpi / dpGRaphics.DpiX)
    '        height = Convert.ToInt32(panel.Height * dpi / dpGRaphics.DpiY)

    '        image = New Bitmap(width, height, Imaging.PixelFormat.Format32bppArgb)
    '        image.SetResolution(dpi, dpi)
    '        Me.panel.DrawToBitmap(image, New Rectangle(0, 0, width, height))



    '        'Using imageGrpahics As Graphics = Graphics.FromImage(image)

    '        '    Graphics.
    '        '    Printing.PrintPaint(imageGrpahics, _
    '        '       New Rectangle(0, 0, image.Width, image.Height))
    '        '    ' PrintToGraphics(dpGRaphics, e.MarginBounds)
    '        'End Using

    '    End Using
    'End Sub

    'Private Sub PrintToGraphics(Graphics As Graphics, bounds As Rectangle)
    '    'Print the control's view to a Graphics object.
    '    '<param name="graphics">Graphics object to draw on.</param>
    '    '<param name="bounds">Rectangle to print in.</param>

    '    'Draw the control and contents to a bitmap 
    '    'Dim Bitmap As Bitmap = New Bitmap(Me.panel.Width, Me.panel.Height)

    '    'Me.panel.DrawToBitmap(Bitmap, New Rectangle(0, 0, Bitmap.Width, Bitmap.Height))

    '    'Assign Print Bounds to target rectangle
    '    Dim PrtWidth, PrtHeight, PrtLeft, PrtTop As Integer
    '    PrtWidth = bounds.Width
    '    PrtHeight = bounds.Height
    '    PrtLeft = bounds.Left
    '    PrtTop = bounds.Top
    '    Dim i As Integer = Graphics.DpiX
    '    Dim target As Rectangle = New Rectangle(PrtLeft, PrtTop, PrtWidth, PrtHeight)
    '    'Scale bitmap to fit target
    '    Dim xScale As Double = image.Width / PrtWidth
    '    Dim yScale As Double = image.Height / PrtHeight
    '    'Dim xScale As Double = Bitmap.Width / PrtWidth
    '    'Dim yScale As Double = Bitmap.Height / PrtHeight
    '    If xScale < yScale Then
    '        target.Width = Int(xScale * target.Width / yScale)
    '    Else
    '        target.Height = Int(yScale * target.Height / xScale)
    '    End If
    '    'Draw the bitmap
    '    Graphics.PageUnit = GraphicsUnit.Display
    '    Graphics.DrawImage(image, target)
    'End Sub


    Private Sub PrintToGraphics(Graphics As Graphics, bounds As Rectangle)
        'Print the control's view to a Graphics object.
        '<param name="graphics">Graphics object to draw on.</param>
        '<param name="bounds">Rectangle to print in.</param>

        'Draw the control and contents to a bitmap 
        Dim Bitmap As Bitmap = New Bitmap(Me.panel.Width, Me.panel.Height)
        Me.panel.DrawToBitmap(Bitmap, New Rectangle(0, 0, Bitmap.Width, Bitmap.Height))

        'Assign Print Bounds to target rectangle
        Dim PrtWidth, PrtHeight, PrtLeft, PrtTop As Integer
        PrtWidth = bounds.Width
        PrtHeight = bounds.Height
        PrtLeft = bounds.Left
        PrtTop = bounds.Top

        Dim target As Rectangle = New Rectangle(PrtLeft, PrtTop, PrtWidth, PrtHeight)
        'Scale bitmap to fit target
        Dim xScale As Double = Bitmap.Width / PrtWidth
        Dim yScale As Double = Bitmap.Height / PrtHeight
        'Dim xScale As Double = Bitmap.Width  / PrtWidth
        'Dim yScale As Double = Bitmap.Height / PrtHeight
        If xScale < yScale Then
            target.Width = Int(xScale * target.Width / yScale)
        Else
            target.Height = Int(yScale * target.Height / xScale)
        End If

        Bitmap.SetResolution(dpi, dpi)
        'Draw the bitmap
        Graphics.PageUnit = GraphicsUnit.Display
        Graphics.DrawImage(Bitmap, target)
    End Sub
End Class
