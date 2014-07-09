Imports BasesParaCompatibilidad.WordExtension


Public Class lstPedidosProveedoresPendientes
    Private oWord As Microsoft.Office.Interop.Word._Application
    Private oDoc As Microsoft.Office.Interop.Word.Document
    Private oTablaTitulo As Microsoft.Office.Interop.Word.Table
    Private oTabla As Microsoft.Office.Interop.Word.Table
    Private oPara1 As Microsoft.Office.Interop.Word.Paragraph
    Private dtb as BasesParaCompatibilidad.Database
    Private tab As System.Data.DataTable
    Private tabDetalles As System.Data.DataTable
    Private tabEntregas As System.Data.DataTable
    Private bw As System.ComponentModel.BackgroundWorker
    Private m_MaestroID As String
    Private m_DetalleID As Integer

    Private Fila As Integer
    Private i As Integer
    Private j As Integer
    Private k As Integer
    Private totalEntregas As Double
    Private frmEspera As BasesParaCompatibilidad.frmEspera
    Private orden As Integer

    Public Sub New()

        totalEntregas = 0
        Fila = 1
        i = 0
        j = 0
        k = 0

        oWord = New Microsoft.Office.Interop.Word.Application
        bw = New System.ComponentModel.BackgroundWorker
        orden = 2
        AddHandler bw.DoWork, AddressOf cargar_datos
        AddHandler bw.RunWorkerCompleted, AddressOf crear_informe
    End Sub

    Private Sub cargar_datos()
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim filtro As String = String.Empty

        Select Case Me.orden
            Case 1
                filtro = " ORDER BY PedidosProveedoresMaestros.FechaServicio"
            Case 3
                filtro = " ORDER BY Proveedores.Nombre"
            Case Else
                filtro = " ORDER BY PedidosProveedoresMaestros.Numero"
        End Select

        ' tab = dtb.Consultar("PedidosProveedoresPendientes")
        tab = dtb.Consultar("SELECT PedidosProveedoresMaestros.PedidoProveedorMaestroID,PedidosProveedoresMaestros.Numero, Proveedores.Nombre,PedidosProveedoresMaestros.FechaEmision ,PedidosProveedoresMaestros.FechaServicio ,PedidosProveedoresMaestros.EstadoID ,PedidosProveedoresMaestros.Observaciones FROM PedidosProveedoresMaestros INNER JOIN Proveedores ON PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID WHERE PedidosProveedoresMaestros.EstadoID < 5 " & filtro, False)
        Fila = 1
        i = 0
        j = 0
        k = 0
        totalEntregas = 0
    End Sub

    Private Sub crear_informe()
        

        Try
            

            oWord.Visible = False
            oDoc = oWord.Documents.Add
            oWord.ActiveWindow.Selection.Style = Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStylePlainText

            With oDoc.PageSetup
                Try
                    .PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4
                Catch ex As Exception
                End Try
                Try
                    .Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientPortrait
                Catch ex As Exception
                End Try
                .LeftMargin = oWord.CentimetersToPoints(2)
                .BottomMargin = oWord.CentimetersToPoints(1)
                .TopMargin = oWord.CentimetersToPoints(1)
            End With

            oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 2)
            With oTablaTitulo
                .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Cell(1, 1).Range.InsertAfter("")
                .Cell(1, 1).Width = 63
                Dim Ruta As String = "C:\LogoLA.bmp"
                Dim bmp As Bitmap = My.Resources.LogoLA
                'Guardamos la imagen en disco
                bmp.Save(Ruta, Imaging.ImageFormat.Bmp)
                'Insertamos la imagen en una celda cualquiera, e indicamos que se guarde con el documento en lugar de vincularla.
                .Cell(1, 1).Range.InlineShapes.AddPicture(Ruta, False, True)
                'Eliminamos el archivo temporal
                IO.File.Delete(Ruta)

                .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Cell(1, 2).Width = oWord.PixelsToPoints(560)
                .Cell(1, 2).Range.Font.Size = 18
                .Cell(1, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Cell(1, 2).Range.InsertAfter("PEDIDOS DE COMPRA PENDIENTES SERVIR")
            End With

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Format.SpaceAfter = 18

            oTabla = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 5)
            With oTabla
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

                While i < tab.Rows.Count
                    If Convert.ToDateTime(tab.Rows(i).Item("FechaServicio")) < DateTime.Now Then
                        .Rows.Item(Fila).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdRed
                    Else
                        .Rows.Item(Fila).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25
                    End If

                    .mam_FormatoLinea(Fila, 1, 34, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(i).Item("Numero"))
                    .mam_FormatoLinea(Fila, 2, 240, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(i).Item("Nombre"))
                    .mam_FormatoLinea(Fila, 3, 60, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(i).Item("FechaEmision"))
                    .mam_FormatoLinea(Fila, 4, 60, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tab.Rows(i).Item("FechaServicio"))
                    .mam_FormatoLinea(Fila, 5, 200, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Convert.ToString(tab.Rows(i).Item("Observaciones")) & "")

                    m_MaestroID = tab.Rows(i).Item("PedidoProveedorMaestroID")
                    tabDetalles = dtb.Consultar("PedidosProveedoresDetallesSelectByMaestroIDListadoPendientes '" & m_MaestroID & "'")

                    Fila += 1
                    .Rows.Add()
                    .Rows.Item(Fila).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdWhite

                    j = 0
                    While j < tabDetalles.Rows.Count
                        .Cell(Fila, 1).Width = oWord.PixelsToPoints(30)
                        .mam_FormatoLinea(Fila, 2, 60, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tabDetalles.Rows(j).Item("CodigoQS"))
                        .mam_FormatoLinea(Fila, 3, 225, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tabDetalles.Rows(j).Item("DescripcionLA"))
                        '.mam_FormatoLinea(Fila, 4, 60, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, Format(tabDetalles.Rows(j).Item("Cantidad"), "##,###"))
                        .mam_FormatoLinea(Fila, 4, 60, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, _
                                            If(Convert.ToDouble(tabDetalles.Rows(j).Item("Cantidad")).ToString().Contains(",0"), _
                                                Convert.ToInt32(tabDetalles.Rows(j).Item("Cantidad")).ToString("###,###,###"), _
                                                Convert.ToDouble(tabDetalles.Rows(j).Item("Cantidad")).ToString("###,###,##0.0#")))
                        .mam_FormatoLinea(Fila, 5, 225, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Convert.ToString(tabDetalles.Rows(j).Item("Observaciones")))

                        '---------------
                        m_DetalleID = tabDetalles.Rows(j).Item("PedidoProveedorDetalleID")
                        tabEntregas = dtb.Consultar("PedidosProveedoresEntregasSelectByDetalleIDListadoPendientes '" & m_DetalleID & "'")
                        '---------------

                        j += 1
                        Fila += 1
                        .Rows.Add()

                        '---------------
                        k = 0
                        totalEntregas = 0
                        While k < tabEntregas.Rows.Count
                            .Cell(Fila, 1).Width = oWord.PixelsToPoints(349)
                            .mam_FormatoLinea(Fila, 2, 55, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, tabEntregas.Rows(k).Item("Fecha"))
                            .mam_FormatoLinea(Fila, 3, 50, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, _
                                                If(Convert.ToDouble(tabEntregas.Rows(k).Item("Cantidad")).ToString().Contains(",00"), _
                                                Convert.ToInt32(tabEntregas.Rows(k).Item("Cantidad")).ToString("###,###,###"), _
                                                Convert.ToDouble(tabEntregas.Rows(k).Item("Cantidad")).ToString("###,###,##0.0#")))
                            'tabEntregas.Rows(k).Item("Cantidad"))

                            .mam_FormatoLinea(Fila, 4, 150, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Convert.ToString(tabEntregas.Rows(k).Item("Observaciones")))
                            totalEntregas += Convert.ToDouble(tabEntregas.Rows(k).Item("Cantidad"))

                            k += 1
                            Fila += 1
                            .Rows.Add()
                        End While

                        If totalEntregas > 0 Then
                            .Cell(Fila, 1).Width = oWord.PixelsToPoints(262)
                            .mam_FormatoLinea(Fila, 2, 120, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, "Total entregas:")
                            .mam_FormatoLinea(Fila, 3, 50, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, _
                                             If(Convert.ToDouble(totalEntregas).ToString().Contains(",00"), _
                                            Convert.ToInt32(totalEntregas).ToString("###,###,###"), _
                                            Convert.ToDouble(totalEntregas).ToString("###,###,##0.0#")))
                            'totalEntregas)
                            Fila += 1
                            .Rows.Add()
                            .Cell(Fila, 1).Width = oWord.PixelsToPoints(262)
                            .mam_FormatoLinea(Fila, 2, 120, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, "Resta por entregar:")
                            Dim restante As Double = Convert.ToDouble(tabDetalles.Rows(j - 1).Item("Cantidad")) - totalEntregas
                            .mam_FormatoLinea(Fila, 3, 50, 8, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, _
                                            If(Convert.ToDouble(restante).ToString().Contains(",00"), _
                                            Convert.ToInt32(restante).ToString("###,###,###"), _
                                            Convert.ToDouble(restante).ToString("###,###,##0.0#")))
                            'restante)
                            .Rows.Add()
                        End If
                        '---------------
                    End While

                    Fila += 1
                    .Rows.Add()
                    i += 1
                End While
            End With

            oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
            oWord.Selection.Font.Size = 12
            oWord.Selection.TypeText(Text:=Convert.ToString(DateTime.Now))

            oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
            oWord.Visible = True
            oWord.NormalTemplate.Saved = True
            oWord = Nothing
            oDoc = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.frmEspera.Close()

        End Try


    End Sub

    Public Sub GenerarListado()
        Dim frm As New frmElegirOrdenListadoPedidos
        frm.ShowDialog()
        frmEspera = New BasesParaCompatibilidad.frmEspera("Preparando informe. Espere unos segundos")
        frmEspera.Show()
        Me.orden = frm.Seleccion
        frm.Dispose()
        bw.RunWorkerAsync()
    End Sub
End Class
