Imports BasesParaCompatibilidad.DataGridViewExtension

Public Class frmPaletsIncompletos
    inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New()
        MyBase.New()
        InitializeComponent()
        spSelectDgv = "DevolverPaletsIncompletos"
    End Sub
    Private Sub frmPaletsIncompletos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        

        'Dim ctlPal As New ctlPaletsProducidos

        'Ocultar todos los botones de la barra
        Dim i As Integer = 0
        While i < bdnGeneral.Items.Count
            bdnGeneral.Items(i).Visible = False
            i += 1
        End While
        butSalir.Visible = True
        butImprimir.Visible = True

        GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv, True)
        With dgvPalet
            .Width = 605
            .DataSource = GeneralBindingSource
            '.DataSource = ctlPal.devolverPaletsIncompletos()

            .SortMode(DataGridViewColumnSortMode.Automatic)
            .FormatoColumna("SCC", "SCC", BasesParaCompatibilidad.TiposColumna.Miles, , 0)
            .FormatoColumna("Descripcion", "Referencia", BasesParaCompatibilidad.TiposColumna.Referencia, True, 1)
            .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 2)
            .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 3)
            .FormatoColumna("HoraInicio", "Hora inicio", BasesParaCompatibilidad.TiposColumna.Hora, , 4)
            .FormatoColumna("HoraFin", "Hora final", BasesParaCompatibilidad.TiposColumna.Hora, , 5)
            .Visible = True
            .FormatoGeneral()
        End With
    End Sub

    Private Sub butImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New BasesParaCompatibilidad.frmEspera("Exportando resultados")
        frm.Show()
        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTable As Microsoft.Office.Interop.Word.Table
        Dim oPara1 As Microsoft.Office.Interop.Word.Paragraph
        Dim r As Integer

        Try
            'Start Word and open the document template.
            oWord = CreateObject("Word.Application")
            oWord.Visible = False
            oDoc = oWord.Documents.Add
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
                .BottomMargin = oWord.CentimetersToPoints(1)
                .TopMargin = oWord.CentimetersToPoints(1)
            End With

            'Insert a paragraph at the beginning of the document.
            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = "                   Palets incompletos "
            oPara1.Range.Font.Bold = True
            oPara1.Range.Font.Size = 28
            oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, dgvPalet.RowCount + 1, 6)
            oTable.Range.Font.Bold = False
            oTable.Range.Font.Size = 12
            oTable.Range.ParagraphFormat.SpaceAfter = 6

            oTable.Cell(1, 1).Range.InsertAfter("SCC")
            oTable.Cell(1, 2).Range.InsertAfter("Referencia")
            oTable.Cell(1, 3).Range.InsertAfter("Cajas")
            oTable.Cell(1, 4).Range.InsertAfter("Fecha")
            oTable.Cell(1, 5).Range.InsertAfter("Inicio")
            oTable.Cell(1, 6).Range.InsertAfter("Final")

            oTable.Columns.Item(1).Width = oWord.CentimetersToPoints(1.5)
            oTable.Columns.Item(2).Width = oWord.CentimetersToPoints(9)
            oTable.Columns.Item(3).Width = oWord.CentimetersToPoints(2)
            oTable.Columns.Item(4).Width = oWord.CentimetersToPoints(3)
            oTable.Columns.Item(5).Width = oWord.CentimetersToPoints(1.9)
            oTable.Columns.Item(6).Width = oWord.CentimetersToPoints(1.7)

            oTable.Rows.Item(1).Range.Font.Bold = True
            oTable.Rows.Item(1).Range.Font.Italic = True
            oTable.Rows.Item(1).Range.Font.Size = 14
            oTable.Rows(1).Range.Font.Name = "Verdana"
            oTable.Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25
            oTable.Rows(1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter

            oTable.Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
            oTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            oTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

            For r = 0 To dgvPalet.RowCount - 1

                oTable.Cell(r + 2, 1).Range.Text = Format(dgvPalet.Rows(r).Cells("SCC").Value, "###,###")
                oTable.Cell(r + 2, 2).Range.Text = dgvPalet.Rows(r).Cells("Descripcion").Value
                oTable.Cell(r + 2, 3).Range.Text = Format(dgvPalet.Rows(r).Cells("Cajas").Value, "###,###")
                oTable.Cell(r + 2, 4).Range.Text = dgvPalet.Rows(r).Cells("Fecha").Value
                oTable.Cell(r + 2, 5).Range.Text = dgvPalet.Rows(r).Cells("HoraInicio").Value
                oTable.Cell(r + 2, 6).Range.Text = dgvPalet.Rows(r).Cells("HoraFin").Value

                oTable.Cell(r + 2, 1).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 3).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 4).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 5).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 6).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            Next

            'Genera el pie de pagina
            oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
            oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
            oWord.Selection.Font.Size = 14
            oWord.Selection.TypeText(Text:=Convert.ToString(Now))
            oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument

            oWord.Visible = True
            oWord = Nothing
            oDoc = Nothing
        Catch ex As Exception
            MessageBox.Show("Error. " & Environment.NewLine & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Close()
        End Try
       
    End Sub
End Class
