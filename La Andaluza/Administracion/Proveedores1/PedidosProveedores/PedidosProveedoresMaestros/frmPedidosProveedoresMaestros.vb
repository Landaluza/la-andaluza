Imports BasesParaCompatibilidad.DataGridViewExtension

Public Class frmPedidosProveedoresMaestros
    inherits BasesParaCompatibilidad.FrmAheredarOld

    Public PDFFile As String
    Private tsMail As ToolStripButton
    Private tsCopiar As ToolStripButton
    Private tsMailProveedor As ToolStripButton
    Private frmEnt As frmEntPedidosProveedoresMaestros
    Private frmEspera As BasesParaCompatibilidad.frmEspera

    Public Sub New()
        MyBase.New(New spPedidosProveedoresMaestros, 0)
        InitializeComponent()

        spSelectDgv = "PedidosProveedoresMaestrosSelectDgv"
        PDFFile = "Z:\Compras\Pedidos\" & Convert.ToString(DatePart("yyyy", Now)) & "\"

        tsCopiar = Me.bdnGeneral.Items.Add("Copiar pedido")
        tsCopiar.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsCopiar.Image = My.Resources.emblem_documents
        tsCopiar.TextDirection = ToolStripTextDirection.Horizontal
        tsCopiar.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsCopiar.Click, AddressOf Copiar

        tsMail = Me.bdnGeneral.Items.Add("Enviar correo MAM")
        tsMail.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsMail.Image = My.Resources.emblem_mail_16
        tsMail.TextDirection = ToolStripTextDirection.Horizontal
        tsMail.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsMail.Click, AddressOf EnviarEmail

        tsMailProveedor = Me.bdnGeneral.Items.Add("Enviar correo proveedor")
        tsMailProveedor.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsMailProveedor.Image = My.Resources.mail_forward_4_16
        tsMailProveedor.TextDirection = ToolStripTextDirection.Horizontal
        tsMailProveedor.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsMailProveedor.Click, AddressOf mailProveedor
    End Sub


    'Overrides Sub Insertar()
    '    Action(ACCION_INSERTAR)
    '    GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
    '    GeneralBindingSource.MoveLast()
    '    FomatearGrid()
    'End Sub

    'Overrides Sub Modificar()
    '    Action(ACCION_MODIFICAR)
    '    GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
    '    FomatearGrid()
    'End Sub

    'Overrides Sub Ver()
    '    Action(ACCION_VER)
    '    FomatearGrid()
    'End Sub

    Public Overrides Sub imprimir()
        Impreso()
    End Sub

    Public Sub EnviarEmail()
        Dim resp As DialogResult = MessageBox.Show("¿Enviar correo a gerencia?", "Correo pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.Yes Then
            Dim mail As New Mail.MailGerente()
            mail.send(dgvGeneral, PDFFile)
        End If
    End Sub

    Public Sub Copiar()
        CopiarPedido()
    End Sub

    Overrides Sub Eliminar()
        Dim response As DialogResult
        response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            If CType(sp, spPedidosProveedoresMaestros).DeletePedidosProveedoresMaestros(dgvGeneral.CurrentRow.Cells("PedidoProveedorMaestroID").Value) Then
                dgvFill()
            End If
            'GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
        End If
    End Sub

    Public Overrides Sub Action(ByVal TipoAction As String)
        Dim DBO_PedidoProveedor As New DBO_PedidosProveedoresMaestros
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            'Asignar las propiedades del objeto creado cuyos valores se obtengan en este Form.
            DBO_PedidoProveedor.Numero = (BasesParaCompatibilidad.BD.ConsultaVer("max(Numero)", "PedidosProveedoresMaestros").Rows(0).Item(0)) + 1
            DBO_PedidoProveedor.EstadoID = 1 'Solicitado
        Else
            DBO_PedidoProveedor = CType(sp, spPedidosProveedoresMaestros).Select_Record(GeneralBindingSource(m_Pos).Item("PedidoProveedorMaestroID"))
        End If

        frmEnt = New frmEntPedidosProveedoresMaestros(DBO_PedidoProveedor, m_Pos)
            frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        dgvFill() 'GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Private Sub FomatearGrid()
        For Each Row As DataGridViewRow In dgvGeneral.Rows
            Select Case Row.Cells("Descripcion").Value
                Case Is = "Servido"
                    Row.DefaultCellStyle.BackColor = Color.Lime
                Case Is = "Solicitado"
                    If Row.Cells("FechaServicio").Value < Today Then
                        Row.DefaultCellStyle.BackColor = Color.Red
                    Else
                        Row.DefaultCellStyle.BackColor = Color.LightBlue
                    End If

                Case Is = "Confirmado"
                    If Row.Cells("FechaServicio").Value < Today Then
                        Row.DefaultCellStyle.BackColor = Color.Red
                    Else
                        Row.DefaultCellStyle.BackColor = Color.LightGreen
                    End If

                Case Is = "Retenido por cambios"
                    If Row.Cells("FechaServicio").Value < Today Then
                        Row.DefaultCellStyle.BackColor = Color.Red
                    Else
                        Row.DefaultCellStyle.BackColor = Color.LightCoral
                    End If

                Case Is = "Anulado"
                    Row.DefaultCellStyle.BackColor = Color.LawnGreen
            End Select
        Next
        'dgvGeneral.FormatoGeneral()
    End Sub

    Private Sub Impreso()
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe")
        frmEspera.Show()
        Dim oWord As New Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTablaTitulo As Microsoft.Office.Interop.Word.Table
        Dim oTablaCabecera As Microsoft.Office.Interop.Word.Table
        Dim oTablaFirmas As Microsoft.Office.Interop.Word.Table

        Dim oTablaTituloAnalitica As Microsoft.Office.Interop.Word.Table

        Dim oPara1 As Microsoft.Office.Interop.Word.Paragraph, oPara2 As Microsoft.Office.Interop.Word.Paragraph
        Dim oPara5 As Microsoft.Office.Interop.Word.Paragraph
        Dim Ruta As String = "C:\Temp\LogoLA.bmp"
        Dim bmp As Bitmap = My.Resources.LogoLA
        Dim spSelectDgv As String
        Dim tb As System.Data.DataTable
        Try
            spSelectDgv = "PedidosProveedoresDetallesSelectByMaestroIDDgv '" & dgvGeneral.CurrentRow.Cells("PedidoProveedorMaestroID").Value & "'"
            tb = dtb.Consultar(spSelectDgv)
        Catch ex As Exception
            MessageBox.Show("Error al recuperar datos para el informe. Detalles:" & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmEspera.Close()
            Return
        End Try

        Try
            bmp.Save(Ruta, Imaging.ImageFormat.Bmp)
        Catch ex As Exception
            MessageBox.Show("Error guardar la imagen en disco. Detalles:" & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmEspera.Close()
            Return
        End Try

        oWord.Visible = False
        oDoc = oWord.Documents.Add
        Try
            oWord.ActiveWindow.Selection.Style = Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStylePlainText
        Catch
        End Try

        With oDoc.PageSetup
            Try
                .PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4
            Catch ex As Exception
            End Try
            Try
                .Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientPortrait
            Catch ex As Exception
            End Try
            Try
                .LeftMargin = oWord.CentimetersToPoints(2)
            Catch ex As Exception
            End Try
            Try
                .BottomMargin = oWord.CentimetersToPoints(1)
            Catch ex As Exception
            End Try
            Try
                .TopMargin = oWord.CentimetersToPoints(1)
            Catch ex As Exception
            End Try
        End With

        Try
            oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 2)
            With oTablaTitulo
                .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

                .Cell(1, 1).Range.InsertAfter("")
                .Cell(1, 1).Width = 63

                'Insertamos la imagen en una celda cualquiera, e indicamos que se guarde con el documento en lugar de vincularla.
                .Cell(1, 1).Range.InlineShapes.AddPicture(Ruta, False, True)

                .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter

                .Cell(1, 2).Width = oWord.PixelsToPoints(560)
                .Cell(1, 2).Range.Font.Size = 36
                .Cell(1, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Cell(1, 2).Range.InsertAfter("PEDIDO DE COMPRA")
            End With

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Format.SpaceAfter = 18

            oTablaCabecera = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)

            Dim rw As Integer
            For rw = 1 To 5
                oTablaCabecera.Cell(rw, 1).Width = oWord.PixelsToPoints(200)
                oTablaCabecera.Cell(rw, 1).Range.Font.Size = 18
                oTablaCabecera.Cell(rw, 1).Range.Font.Bold = True

                oTablaCabecera.Cell(rw, 2).Width = oWord.PixelsToPoints(470)
                oTablaCabecera.Cell(rw, 2).Range.Font.Size = 18
                oTablaCabecera.Cell(rw, 2).Range.Font.Bold = False
            Next

            oTablaCabecera.Cell(1, 1).Range.InsertAfter("Numero:")
            oTablaCabecera.Cell(1, 2).Range.Text = dgvGeneral.CurrentRow.Cells("Numero").Value.ToString()
            oTablaCabecera.Cell(2, 1).Range.InsertAfter("Proveedor:")
            oTablaCabecera.Cell(2, 2).Range.Text = dgvGeneral.CurrentRow.Cells("Nombre").Value
            oTablaCabecera.Cell(3, 1).Range.InsertAfter("Fecha pedido:")
            oTablaCabecera.Cell(3, 2).Range.Text = dgvGeneral.CurrentRow.Cells("FechaEmision").Value
            oTablaCabecera.Cell(4, 1).Range.InsertAfter("Fecha entrega:")
            oTablaCabecera.Cell(4, 2).Range.Text = dgvGeneral.CurrentRow.Cells("FechaServicio").Value
            oTablaCabecera.Cell(5, 1).Range.InsertAfter("Observaciones:")
            oTablaCabecera.Cell(5, 2).Range.Text = dgvGeneral.CurrentRow.Cells("Observaciones").Value & ""

            'Rellenar Tabla con los articulos del pedido


            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Format.SpaceAfter = oWord.PixelsToPoints(24)

            oTablaTituloAnalitica = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 10, 5)
            With oTablaTituloAnalitica
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

                .Cell(2, 1).Range.Text = "Código"
                .Cell(2, 2).Range.Text = "Articulo"
                .Cell(2, 3).Range.Text = "Cantidad"
                .Cell(2, 4).Range.Text = "Medida"
                '.Cell(2, 4).Range.Text = "Unidades"
                .Cell(2, 5).Range.Text = "Observaciones"

                Dim r As Integer = 3
                For Each record As DataRow In tb.Rows
                    .Cell(r, 1).Range.Text = record.Item("CodigoLA").ToString
                    .Cell(r, 2).Range.Text = record.Item("DescripcionLA").ToString
                    .Cell(r, 3).Range.Text = If(Convert.ToDouble(record.Item("Cantidad")).ToString().Contains(",0"), _
                                                Convert.ToInt32(record.Item("Cantidad")).ToString("###,###,###"), _
                                                Convert.ToDouble(record.Item("Cantidad")).ToString("###,###,##0.0#"))

                    .Cell(r, 4).Range.Text = record.Item("Medida").ToString
                    .Cell(r, 5).Range.Text = record.Item("Observaciones").ToString
                    r += 1
                Next

                .Columns.Item(1).Select()
                oWord.Selection.Cells().Width = 69
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
                oWord.Selection.Font.Size = 10
                .Columns.Item(2).Select()
                oWord.Selection.Cells().Width = 185
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
                oWord.Selection.Font.Size = 10
                .Columns.Item(3).Select()
                oWord.Selection.Cells().Width = 79
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oWord.Selection.Font.Size = 10
                .Columns.Item(4).Select()
                oWord.Selection.Cells().Width = 79
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
                oWord.Selection.Font.Size = 10
                .Columns.Item(5).Select()
                oWord.Selection.Cells().Width = 120
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
                oWord.Selection.Font.Size = 10


                .Rows.Item(1).Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                .Rows.Item(1).Cells.Item(1).Merge(.Rows.Item(1).Cells.Item(4))
                .Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdYellow
                .Rows.Item(1).Range.Font.Size = 12
                .Rows.Item(1).Range.Font.Bold = True
                .Cell(1, 1).Range.Text = "ARTICULOS DEL PEDIDO"

                .Rows.Item(2).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25
                .Rows.Item(2).Select()
                oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Rows.Item(2).Range.Font.Size = 11
                .Rows.Item(2).Range.Font.Bold = True
                .Rows.Height = 14
            End With

            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Format.SpaceAfter = 12

            oPara2 = oDoc.Content.Paragraphs.Add
            oPara2.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify
            oPara2.Range.Text = "NOTA: sus albaranes y facturas deben indicar el número de nuestro pedido y sus números de lotes." & _
                Environment.NewLine & Environment.NewLine

            Dim oParaN As Microsoft.Office.Interop.Word.Paragraph = oDoc.Content.Paragraphs.Add
            oParaN.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oParaN.Range.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdRed
            oParaN.Range.Font.Size = 16
            oParaN.Range.Text = "HORARIO DE DESCARGA: 07:00 a 14:00"


            oPara5 = oDoc.Content.Paragraphs.Add
            oPara5.Format.SpaceAfter = 70

            oTablaFirmas = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 1, 1)
            oTablaFirmas.Columns.Item(1).Select()
            oWord.Selection.Cells().Width = 150
            oWord.Selection.Cells().Height = 150

            oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
            oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
            oWord.Selection.Font.Size = 9
            oWord.Selection.TypeText(Text:="V. La Andaluza, S.L." & Environment.NewLine & _
                                           "C/ Marquetería, 7. 11408 Jerez de la Frontera. Cádiz. España." & Environment.NewLine & _
                                           "Teléfono: +34 956144538; Fax: +34 956142230" & Environment.NewLine & _
                                           "administracion@landaluza.es  www.landaluza.es")

            oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
            oWord.Visible = False 'True

        Catch ex As Exception
            MessageBox.Show("Error al preparar el informe. Detalles:" & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmEspera.Close()
            Return
        End Try

        Dim GrabarPDF As Boolean = True
        Try

            If IO.File.Exists(PDFFile & Convert.ToString(dgvGeneral.CurrentRow.Cells("Numero").Value) & ".PDF") Then
                Dim response As DialogResult
                response = MessageBox.Show("El fichero ya existe y posiblemente este firmado, si lo vuelves a grabar se debe enviar a nueva autorización ", _
                                  "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If response = DialogResult.No Then
                    GrabarPDF = False
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.Substring(1, 20) & Environment.NewLine & "Fallo al grabar el fichero como PDF")
            frmEspera.Close()
            Return
        End Try

        If Not IO.Directory.Exists(PDFFile) Then
            IO.Directory.CreateDirectory(PDFFile)
        End If

        If GrabarPDF Then
            Try
                oDoc.SaveAs(FileName:=PDFFile & Convert.ToString(dgvGeneral.CurrentRow.Cells("Numero").Value) & ".PDF", _
                          FileFormat:=Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF, _
                          LockComments:=False, AddToRecentFiles:=True, ReadOnlyRecommended:=False, _
                          EmbedTrueTypeFonts:=False, SaveNativePictureFormat:=True, _
                          SaveFormsData:=True, SaveAsAOCELetter:=False, _
                          InsertLineBreaks:=False, AllowSubstitutions:=False, _
                          LineEnding:=Microsoft.Office.Interop.Word.WdLineEndingType.wdCRLF, _
                          AddBiDiMarks:=False)
            Catch ex As Exception
                MessageBox.Show(ex.Message.Substring(1, 20) & Environment.NewLine & "Fallo al grabar el fichero como PDF")
                frmEspera.Close()
                Return
            End Try

            Try
                CType(sp, spPedidosProveedoresMaestros).UpdatePedidosProveedoresMaestros_RutaPDF(dgvGeneral.CurrentRow.Cells("PedidoProveedorMaestroID").Value, PDFFile & Convert.ToString(dgvGeneral.CurrentRow.Cells("Numero").Value) & ".PDF")
            Catch ex As Exception
                MessageBox.Show("Error actualizando tabla. Detalles: " & ex.Message.Substring(1, 20) & Environment.NewLine & "Fallo al grabar el fichero como PDF")
            End Try
        End If

        oDoc.Close(Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges)
        oWord.Quit()
        Dim psi As New ProcessStartInfo()
        psi.UseShellExecute = True
        psi.FileName = PDFFile & Convert.ToString(dgvGeneral.CurrentRow.Cells("Numero").Value) & ".PDF"
        Process.Start(psi)

        oWord = Nothing
        oDoc = Nothing
        'Me.Close()

        'Try
        '    'Eliminamos el archivo temporal
        '    IO.File.Delete(Ruta)
        'Catch ex As Exception
        '    MessageBox.Show("Error al borrar la imagen temporal. Borrela manualmente en la ruta C:\Temp\LogoLA.bmp. Detalles:" & Environment.NewLine & ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End Try

        frmEspera.Close()

    End Sub

    Private Sub CopiarPedido()
        CType(sp, spPedidosProveedoresMaestros).CopyPedidosProveedores(dgvGeneral.CurrentRow.Cells("PedidoProveedorMaestroID").Value)
        GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv)
        GeneralBindingSource.MoveLast()
        Modificar()
    End Sub

    Private Sub mailProveedor()
        Dim resp As DialogResult = MessageBox.Show("¿Enviar correo al proveedor?", "Correo pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.Yes Then
            Dim mail As New Mail.MailProveedores
            mail.send(dgvGeneral, PDFFile)
        End If
    End Sub

    Private Sub butEmailProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        mailProveedor()
    End Sub

    Private Sub dgvGeneral_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs)
        FomatearGrid()
    End Sub

    Protected Overrides Sub cargar_datos()
        If spSelectDgv = "PedidosProveedoresMaestrosSelectDgvByEstado" Then
            spSelectDgv = "PedidosProveedoresMaestrosSelectDgv"
        Else
            spSelectDgv = "PedidosProveedoresMaestrosSelectDgvByEstado"
        End If

        dataSource = dtb.Consultar(spSelectDgv)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .Visible = True
                .DataSource = GeneralBindingSource
                .Columns("PedidoProveedorMaestroID").Visible = False
                .Columns("ProveedorID").Visible = False
                .FormatoColumna("Numero", "Num", BasesParaCompatibilidad.TiposColumna.Miles, 70)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Proveedor, True)
                .FormatoColumna("FechaEmision", "Emision", BasesParaCompatibilidad.TiposColumna.FechaCorta, 95)
                .FormatoColumna("FechaServicio", "Servicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 95)
                .FormatoColumna("Descripcion", "Estado", BasesParaCompatibilidad.TiposColumna.Izquierda, 131)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
     
            End With


            FomatearGrid()
        End If
    End Sub

    
End Class
