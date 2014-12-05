Imports BasesParaCompatibilidad.WordExtension

Namespace AlbaranesCarga

    Public Class Albaran


        Public Sub Albaran_provisional(ByVal cliente As String, ByVal conductor As String, ByVal dni As String, ByVal remolque As String)
            'QS.AlbaranProvisional(txtRemolque1.Text, txtConductor.Text, txtDNI.Text, cboClientes.SelectedText)

            Dim Albaran As String
            Dim Serie As String
            Dim CodigoQS As String
            Dim CIF As String
            'Dim LugarEntrega As String
            'Dim DescripcionMercancia As String
            'Dim NumeroDocumento As String
            Dim OperadorTransporte As String
            'Dim MatriculaRemolque As String
            Dim FechaEntrega As String
            Dim Portes As String
            'Dim Transportista As String
            'Dim DNITransportista As String
            'Dim PesoBruto As String
            Dim Anchocolumna As Integer = 300
            Dim Anchocolumna1 As Integer = 300
            Dim Fecha As String = System.DateTime.Today.ToString.Substring(0, 10)
            Dim Fila As Integer = 1

            Dim DireccionJRSabater As String = "    J.R.SABATER, S.A." + Environment.NewLine + _
                                               "    AV. MURCIA, 61 APARTADO 59" + Environment.NewLine + _
                                               "    30110 - CABEZO DE TORRES" + Environment.NewLine + _
                                               "    MURCIA         TELF: 968830979" + Environment.NewLine

            Try
                'Albaran Provisional

                Dim oWord As New Microsoft.Office.Interop.Word.Application
                Dim oDoc As Microsoft.Office.Interop.Word.Document
                Dim oTablaTitulo As Microsoft.Office.Interop.Word.Table

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
                    .LeftMargin = oWord.CentimetersToPoints(1)
                    .RightMargin = oWord.CentimetersToPoints(1)
                    .BottomMargin = oWord.CentimetersToPoints(1)
                    .TopMargin = oWord.CentimetersToPoints(1)
                End With

                oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 23, 1)
                With oTablaTitulo
                    .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                    .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                    .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                    '.Cell(1, 1).Range.InsertAfter("")

                    '.Cell(1, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                    '.Cell(1, 1).Width = oWord.PixelsToPoints(600)
                    '.Cell(1, 1).Range.Font.Size = 18

                    .Cell(1, 1).Split(1, 2)
                    '.Cell(1, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                    .Rows.Item(2).Range.Font.Size = 9
                    .Cell(2, 1).Range.Font.Name = "Arial"
                    '.mam_FormatoLinea(1, 2, 273, 36, WdParagraphAlignment.wdAlignParagraphCenter, "ALBARAN")

                    '.Cell(2, 1).Split(1, 2)
                    '.Cell(3, 1).Split(1, 2)
                    '.Cell(3, 2).Split(1, 6)
                    '.mam_FormatoLineaTitulo(3, 2, 40, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "NUMERO")
                    '.mam_FormatoLineaTitulo(3, 3, 30, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "SERIE")
                    '.mam_FormatoLineaTitulo(3, 4, 68, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "FECHA")
                    '.mam_FormatoLineaTitulo(3, 5, 45, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "CODIGO")
                    '.mam_FormatoLineaTitulo(3, 6, 30, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "TIPO")
                    '.mam_FormatoLineaTitulo(3, 7, 60, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "DNI/CIF")

                    .mam_FormatoLinea(1, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .mam_FormatoLinea(1, 2, 260, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "ALBARAN")

                    .Cell(2, 1).Split(1, 2)
                    .mam_FormatoLinea(2, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .Cell(3, 1).Split(1, 2)
                    .Cell(3, 2).Split(1, 6)
                    .mam_FormatoLinea(3, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .mam_FormatoLineaTitulo(3, 2, 27, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "NUMERO")
                    .mam_FormatoLineaTitulo(3, 3, 30, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "SERIE")
                    .mam_FormatoLineaTitulo(3, 4, 68, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "FECHA")
                    .mam_FormatoLineaTitulo(3, 5, 45, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "CODIGO")
                    .mam_FormatoLineaTitulo(3, 6, 30, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "TIPO")
                    .mam_FormatoLineaTitulo(3, 7, 60, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "DNI/CIF")

                    .Cell(4, 1).Split(1, 2)
                    .mam_FormatoLinea(4, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")

                    Albaran = InputBox("Introduce numero de albaran sin serie", "Albaran")
                    Serie = InputBox("Introduce letra de la serie", "Serie")
                    CodigoQS = InputBox("Introduce codigo QS del cliente", "CodigoQS")
                    CIF = InputBox("Introduce CIF del cliente", "CIF")

                    .Cell(4, 2).Split(1, 6)
                    .mam_FormatoLinea(4, 2, 27, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Albaran)
                    .mam_FormatoLinea(4, 3, 30, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Serie)
                    .mam_FormatoLinea(4, 4, 68, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Fecha)
                    .mam_FormatoLinea(4, 5, 45, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, CodigoQS)
                    .mam_FormatoLinea(4, 6, 30, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, " ")
                    .mam_FormatoLinea(4, 7, 60, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, CIF)

                    .Cell(5, 1).Split(1, 2)
                    .mam_FormatoLinea(5, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .Cell(5, 2).Split(1, 2)
                    .mam_FormatoLineaTitulo(5, 2, 140, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "CENTRO")
                    .mam_FormatoLineaTitulo(5, 3, 120, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "FORMA PAGO")

                    .Cell(6, 1).Split(1, 2)
                    .mam_FormatoLinea(6, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .Cell(6, 2).Split(6, 2)
                    .mam_FormatoLinea(6, 2, 140, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "JEREZ FRONT.ALMAC.EMBOT.VLAND")
                    .mam_FormatoLinea(6, 3, 120, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "PAGARE 85 DIAS F.F.")

                    .Cell(7, 1).Split(1, 2)
                    .mam_FormatoLinea(7, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .Cell(8, 1).Split(1, 2)
                    .mam_FormatoLinea(8, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .mam_FormatoLineaTitulo(8, 2, 140, 12, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "NOMBRE / DIRECCION ENTREGA")

                    .Cell(9, 1).Split(1, 2)
                    .mam_FormatoLinea(9, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                    .mam_FormatoLinea(9, 2, 140, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      DireccionJRSabater + _
                                      Environment.NewLine)

                    .Cell(1, 1).Merge(.Cell(9, 1))


                    .Cell(1, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderTop).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(1, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderBottom).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(1, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                    .Cell(2, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(2, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                    .Cell(7, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(7, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                    .Cell(10, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(10, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(10, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderTop).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(9, 2).Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

                    'Albaran = InputBox("Introduce numero de albaran", "Albaran")
                    'Serie = InputBox("Introduce letra de la serie", "Serie")
                    'CodigoQS = InputBox("Introduce codigo QS del cliente", "CodigoQS")
                    'CIF = InputBox("Introduce CIF del cliente", "CIF")

                    .Cell(11, 1).Split(1, 9)
                    .mam_FormatoLineaTitulo(11, 1, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "COD.ART")
                    .mam_FormatoLineaTitulo(11, 2, 25, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "LOTE")
                    .mam_FormatoLineaTitulo(11, 3, 60, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "CANTIDAD")
                    .mam_FormatoLineaTitulo(11, 4, 20, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "UM")
                    .mam_FormatoLineaTitulo(11, 5, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "EAN FORMATO ENVASE")
                    .mam_FormatoLineaTitulo(11, 6, 170, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "PRODUCTOS")
                    .mam_FormatoLineaTitulo(11, 7, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "PRECIO")
                    .mam_FormatoLineaTitulo(11, 8, 20, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "UM")
                    .mam_FormatoLineaTitulo(11, 9, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "IMPORTE")

                    .Cell(12, 1).Split(1, 9)
                    .mam_FormatoLinea(12, 1, 50, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                    Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 2, 25, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                    Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 3, 60, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, Environment.NewLine + _
                                    Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 4, 20, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Environment.NewLine + _
                                   Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 5, 100, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                  Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 6, 170, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                   Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 7, 50, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                   Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 8, 20, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                   Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(12, 9, 50, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                     Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)


                    .Cell(13, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(13, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                    .Cell(14, 1).Split(1, 7)
                    .mam_FormatoLineaTitulo(14, 1, 75, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "TOTAL")
                    .mam_FormatoLineaTitulo(14, 2, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "BASE IMPONIBLE")
                    .mam_FormatoLineaTitulo(14, 3, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "IVA %")
                    .mam_FormatoLineaTitulo(14, 4, 70, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "IVA IMPORTE")
                    .mam_FormatoLineaTitulo(14, 5, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "R.E. %")
                    .mam_FormatoLineaTitulo(14, 6, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "R.E. IMPORTE")
                    .mam_FormatoLineaTitulo(14, 7, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "TOTAL ALBARAN")

                    .Cell(15, 1).Split(1, 7)
                    .mam_FormatoLinea(15, 1, 75, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(15, 2, 100, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(15, 3, 50, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(15, 4, 70, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                    .mam_FormatoLinea(15, 5, 50, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine)

                    .mam_FormatoLinea(15, 6, 100, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine)

                    .mam_FormatoLinea(15, 7, 100, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine)



                    .Cell(16, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(16, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                    .mam_FormatoLineaTitulo(17, 1, 545, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "OBSERVACIONES")

                    .mam_FormatoLinea(18, 1, 545, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine)

                    .Cell(19, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(19, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                    .Cell(20, 1).Split(1, 2)
                    .mam_FormatoLineaTitulo(20, 1, 360, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "DATOS DEL TRANSPORTISTA")
                    .mam_FormatoLineaTitulo(20, 2, 185, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "FIRMA Y SELLO DEL CLIENTE")

                    .Cell(21, 1).Split(1, 3)
                    OperadorTransporte = InputBox("Introduce Empresa cargadora", "OperadorTransporte")
                    FechaEntrega = InputBox("Introduce Fecha de entrega", "FechaEntrega")
                    Portes = InputBox("Introduce tipo de porte", "Portes")

                    .mam_FormatoLinea(21, 1, 180, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                          "TRANSPORTISTA: " + OperadorTransporte + _
                                          Environment.NewLine + _
                                          "MATRICULA: " + remolque + _
                                          Environment.NewLine + _
                                          "FECHA DE ENTREGA: " + FechaEntrega + _
                                          Environment.NewLine + _
                                          "PORTES: " + Portes + _
                                          Environment.NewLine)

                    'Transportista = InputBox("Introduce nombre del conductor", "Transportista")
                    'DNITransportista = InputBox("Introduce DNI del conductor", "DNITransportista")

                    .mam_FormatoLinea(21, 2, 180, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                          "NOMBRE DEL CONDUCTOR: " + conductor + _
                                          Environment.NewLine + _
                                          "DNI: " + dni + _
                                          Environment.NewLine + _
                                          "FIRMA:" + _
                                          Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine)

                    .mam_FormatoLinea(21, 3, 185, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                          "NOMBRE DEL CLIENTE " + cliente + _
                                          Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine + _
                                          Environment.NewLine + _
                                          "FECHA DE CARGA " + Fecha + _
                                          Environment.NewLine)

                    .Cell(22, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(22, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .Cell(23, 1).Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                    .mam_FormatoLinea(23, 1, 545, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "UM: CJ=CAJAS:BT=BOTELLAS:CJ=CAJEXPOSIT:UN=UNIDADES")

                    '.mam_FormatoLinea(26, 1, 545, 5, WdParagraphAlignment.wdAlignParagraphLeft, "Vinagrería La Andaluza, S.L. inscrita en el Registro Mercantil de Cadiz.Tomo 1682.Libro 0.Folio 31.Sección 8.Hoja CA27329-CIF ES-B11826617")
                End With

                oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
                oWord.Selection.Font.Size = 9
                oWord.Selection.TypeText(Text:="Vinagrería La Andaluza, S.L. inscrita en el Registro Mercantil de Cadiz.Tomo 1682.Libro 0.Folio 31.Sección 8.Hoja CA27329-CIF ES-B11826617")

                'oWord.Selection.TypeText(Text:="V. La Andaluza, S.L." & Environment.NewLine & _
                '                               "C/ Marquetería, 7. 11408 Jerez de la Frontera. Cádiz. España." & Environment.NewLine & _
                '                               "Teléfono: +34 956144538; Fax: +34 956142230" & Environment.NewLine & _
                '                               "calidad@landaluza.es  www.landaluza.es")

                'oDoc.ActiveWindow.View.SeekView = WdSeekView.wdSeekPrimaryFooter
                'oWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
                'oWord.Selection.Font.Color = WdColor.wdColorBlue
                'oWord.Selection.Font.Size = 12
                'oWord.Selection.TypeText(Text:=Now)

                oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
                oWord.Visible = True
                oWord.NormalTemplate.Saved = True
                oWord = Nothing
                oDoc = Nothing
                'Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error." & Environment.NewLine & " Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub


        Public Sub cartaPortesJR(ByVal dni As String, ByVal conductor As String, ByRef dtb As BasesParaCompatibilidad.DataBase)
            Dim cabecera As String
            Dim texto As String
            Dim detalle As String
            Dim pie As String
            Dim pie2 As String
            Dim tlf As String
            Dim fecha_recogida As Date = Now.Date.AddDays(1)
            If fecha_recogida.DayOfWeek = DayOfWeek.Saturday Then fecha_recogida.AddDays(2)

            pie2 = dni
            pie = conductor

            Try
                dtb.PrepararConsulta("select movil from conductores where dni= @dni")
                dtb.AñadirParametroConsulta("@dni", pie2)
                tlf = dtb.Consultar().Rows(0).Item(0).ToString
            Catch ex As Exception
                tlf = InputBox("No se pudo recuperar el telefono de contacto del conductor. Introduzcalo manualmente")
            End Try


            detalle = "Mi teléfono de contacto es " & tlf & _
                Environment.NewLine & Environment.NewLine & _
                Environment.NewLine & Environment.NewLine & _
                Environment.NewLine & "Firmado:"

            texto = "Yo, D. " & pie & ", con DNI " & pie2 & " firmo que he sido informado de la obligación de entergar la mercancía hoy recogida en Vinagrería La Andaluza, a las " _
                & "07:00 del dia " & fecha_recogida.Day & " de " & _
                fecha_recogida.ToString("MMMM", Globalization.CultureInfo.CreateSpecificCulture("es-ES")) & ", en su lugar de entrega." & Environment.NewLine & _
                "En caso de no poder cumplir con los horarios previstos ponerse en contacto con Francisco Gallego Vidal o Cesar Monserrate (tl.968830979)"

            cabecera = "En Jerez de la Frontera a " & Now.Date.Day.ToString & " de " & Now.Date.ToString("MMMM", Globalization.CultureInfo.CreateSpecificCulture("es-ES")) & " de " & Now.Date.Year


            Dim a As New Carta_de_portes.frmCartaDePortes(cabecera, texto, detalle, pie, pie2)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(a)
        End Sub

        Public Sub CartaPortes(ByVal cantidad As String, ByVal cabeza As String, ByVal remolque As String)
            'Dim EmpresaDestinataria As String
            'Dim LugarEntrega As String
            Dim DescripcionMercancia As String
            Dim NumeroDocumento As String
            'Dim OperadorTransporte As String
            'Dim Transportista As String
            Dim PesoBruto As String
            Dim Anchocolumna As Integer = 242
            Dim Anchocolumna1 As Integer = 294
            Dim Fecha As String = System.DateTime.Today.ToString.Substring(0, 10)
            Dim Fila As Integer = 1
            Dim DireccionJRSabater As String = "J.R.SABATER, S.A." + Environment.NewLine + _
                                               "C/Marquetería, 7" + Environment.NewLine + _
                                               "11408 - JEREZ DE LA FRONTERA" + Environment.NewLine + _
                                               "CADIZ - ESPAÑA" + Environment.NewLine

            Dim DireccionMercadonaHuevar As String = "MERCADONA - HUEVAR" + Environment.NewLine + _
                                                     "AV. SEVILLA-HUELVA A-49 KM.21" + Environment.NewLine + _
                                                     "41830 - HUEVAR" + Environment.NewLine + _
                                                     "SEVILLA (ESPAÑA)" + Environment.NewLine

            Dim DireccionMercadonaAntequera As String = "MERCADONA - ANTEQUERA" + Environment.NewLine + _
                                                        "PQ. EMPRESARIAL SECTOR SUP.I 5" + Environment.NewLine + _
                                                        "29200 - ANTEQUERA" + Environment.NewLine + _
                                                        "MALAGA (ESPAÑA)" + Environment.NewLine

            Dim DireccionAcotral As String = "TRANSPORTES ACOTRAL, S.L." + Environment.NewLine + _
                                             "C/ CUEVA DE VIERA, Nº2" + Environment.NewLine + _
                                             "24900 - ANTEQUERA" + Environment.NewLine + _
                                             "MALAGA (ESPAÑA)" + Environment.NewLine

            Dim DireccionTransreyes As String = "TRANSREYES LOGISTICA, S.L." + Environment.NewLine + _
                                                "C/ CEREZO, 8 - Apto. Correos nº1" + Environment.NewLine + _
                                                "18040 - LA ZUBIA" + Environment.NewLine + _
                                                "GRANADA (ESPAÑA)" + Environment.NewLine

            Dim oWord As New Microsoft.Office.Interop.Word.Application
            Dim oDoc As Microsoft.Office.Interop.Word.Document
            Dim oTablaTitulo As Microsoft.Office.Interop.Word.Table
            'Dim oTabla As Table
            'Dim oPara1 As Paragraph

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
                .LeftMargin = oWord.CentimetersToPoints(1)
                .BottomMargin = oWord.CentimetersToPoints(0.7)
                .TopMargin = oWord.CentimetersToPoints(1)
                .TextColumns.SetCount(2)
            End With
            Try
                oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 32, 1)
                With oTablaTitulo
                    .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                    .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                    .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                    .Cell(1, 1).Range.InsertAfter("")
                    '.Cell(1, 1).Width = 63

                    .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                    .Cell(1, 1).Width = oWord.PixelsToPoints(300)
                    .Cell(1, 1).Range.Font.Size = 18
                    .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                    .mam_FormatoLinea(1, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "DOCUMENTO DE CONTROL DEL TRANSPORTE " + Environment.NewLine + _
                                                                                                         "DE MERCANCIAS POR CARRETERA" + Environment.NewLine + _
                                                                                                         "Orden FOM/238/203, de 28 de agosto de 2003")



                    'Dim rngPara As Range
                    ''Set rngPara = ActiveDocument.Paragraphs(1).Range
                    'rngPara = .Cell(1, 1).Range
                    'With rngPara
                    '    .Sentences(1).Select()
                    '    .Bold = True
                    '    .Font.Name = "Arial"
                    'End With
                    '

                    .mam_FormatoLineaTitulo(2, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA CARGADORA (Nombre y domicilio)")
                    .mam_FormatoLinea(3, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionJRSabater)

                    .mam_FormatoLineaTitulo(4, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA EXPEDIDORA (Nombre y domicilio)")
                    .mam_FormatoLinea(5, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionJRSabater)


                    .mam_FormatoLineaTitulo(6, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA DESTINATARIA (Nombre y domicilio)")
                    .mam_FormatoLineaTitulo(10, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "LUGAR ENTREGA MERCANCIA DESTINO")

                    Dim Respuesta As DialogResult
                    Respuesta = MessageBox.Show(" ¿El lugar de entrega es Huevar?", _
                                       "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If Respuesta = DialogResult.Yes Then
                        .mam_FormatoLinea(7, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaHuevar)
                        .mam_FormatoLinea(11, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaHuevar)

                    Else
                        .mam_FormatoLinea(7, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaAntequera)
                        .mam_FormatoLinea(11, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaAntequera)
                    End If

                    .mam_FormatoLineaTitulo(8, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "LUGAR Y FECHA CARGA MERCANCIA")
                    .mam_FormatoLinea(9, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, _
                                                                                                        "JEREZ DE LA FRA - CADIZ - ESPAÑA" + Environment.NewLine + _
                                                                                                        (Fecha) + Environment.NewLine)




                    .mam_FormatoLineaTitulo(12, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "INSTRUCCIONES DEL REMITENTE")
                    .mam_FormatoLinea(13, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine)


                   

                    DescripcionMercancia = Environment.NewLine + _
                                            cantidad + " PALETS DE VINAGRES Y SALSAS" + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine

                    .mam_FormatoLineaTitulo(14, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "DESCRIPCION DE LA MERCANCIA")
                    .mam_FormatoLinea(15, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DescripcionMercancia)

                    .mam_FormatoLineaTitulo(16, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "FIRMA Y SELLO EMPRESA CARGADORA")
                    .mam_FormatoLinea(17, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine)

                    NumeroDocumento = InputBox("Introduce numero documento", "Documento")
                    .mam_FormatoLinea(18, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "DOCUMENTO Nº" + " " + NumeroDocumento.ToString + Environment.NewLine + "Formalizado en Jerez a " + (Fecha) + Environment.NewLine)

                    Dim Respuesta1 As DialogResult
                    Respuesta1 = MessageBox.Show(" ¿Es Acotral la empresa cargadora?", _
                                       "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If Respuesta1 = DialogResult.Yes Then
                        .mam_FormatoLineaTitulo(19, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "OPERADOR DE TRANSPORTE (AGENCIA)")
                        .mam_FormatoLinea(20, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionAcotral)

                        .mam_FormatoLineaTitulo(21, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "TRANSPORTISTA (Nombre y domicilio)")
                        .mam_FormatoLinea(22, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionAcotral)

                    Else
                        .mam_FormatoLineaTitulo(19, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "OPERADOR DE TRANSPORTE (AGENCIA)")
                        .mam_FormatoLinea(20, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionTransreyes)

                        .mam_FormatoLineaTitulo(21, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "TRANSPORTISTA (Nombre y domicilio)")
                        .mam_FormatoLinea(22, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionTransreyes)

                    End If



                    Dim MatriculaTractora As String
                    MatriculaTractora = cabeza
                    MatriculaTractora = MatriculaTractora


                    Dim MatriculaSemirremolque As String
                    MatriculaSemirremolque = remolque
                    MatriculaSemirremolque = MatriculaSemirremolque

                    .mam_FormatoLineaTitulo(23, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "MATRICULA TRACTORA")
                    .mam_FormatoLinea(24, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, MatriculaTractora + Environment.NewLine)


                    .mam_FormatoLineaTitulo(25, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "MATRICULA SEMIRREMOLQUE")
                    .mam_FormatoLinea(26, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, MatriculaSemirremolque + Environment.NewLine)


                    .mam_FormatoLineaTitulo(27, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "RESERVA Y OBSERVACIONES DEL TRANSPORTISTA")
                    .mam_FormatoLinea(28, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine + _
                                                   Environment.NewLine)

                    .Cell(29, 1).Split(1, 4)
                    .Cell(30, 1).Split(1, 4)

                    .mam_FormatoLineaTitulo(29, 1, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "Nº DE BULTOS")
                    .mam_FormatoLinea(30, 1, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine)




                    PesoBruto = InputBox("Introduce peso bruto", "PesoBruto")
                    PesoBruto = Environment.NewLine + _
                                            PesoBruto + " Kg." + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine + _
                                            Environment.NewLine
                    .mam_FormatoLineaTitulo(29, 2, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "PESO BRUTO")
                    .mam_FormatoLinea(30, 2, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, PesoBruto)

                    .mam_FormatoLineaTitulo(29, 3, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "PESO NETO")
                    .mam_FormatoLinea(30, 3, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine)

                    .mam_FormatoLineaTitulo(29, 4, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "VOLUMEN M3")
                    .mam_FormatoLinea(30, 4, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine + _
                    Environment.NewLine)


                    .Cell(31, 1).Split(1, 2)
                    .Cell(32, 1).Split(1, 2)

                    .mam_FormatoLineaTitulo(31, 1, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA TRANSPORTISTA")
                    .mam_FormatoLinea(32, 1, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine)

                    .mam_FormatoLineaTitulo(31, 2, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA DESTINATARIA")
                    .mam_FormatoLinea(32, 2, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine + _
                                                  Environment.NewLine)

                End With

                'oDoc.ActiveWindow.View.SeekView = WdSeekView.wdSeekPrimaryFooter
                'oWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
                'oWord.Selection.Font.Color = WdColor.wdColorBlue
                'oWord.Selection.Font.Size = 12
                'oWord.Selection.TypeText(Text:=Now)

                oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
                oWord.Visible = True
                oWord.NormalTemplate.Saved = True
                oWord = Nothing
                oDoc = Nothing
                'Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error." & Environment.NewLine & " Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
