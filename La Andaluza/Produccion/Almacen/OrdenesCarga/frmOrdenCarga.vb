Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.dtpExtension

Public Class frmOrdenCarga
    'Private ctlPalPro As New ctlPaletsProducidos
    Private spPaletsProducidos As New spPaletsProducidos
    Private Palets As New DataTable
    Private PaletsProducidosSumReferencia As New DataTable
    Private PaletsSeleccionados As Integer = 0
    Private O_Item As ListViewItem
    Private TotalCajasAlmacen As Integer

    Public Sub New()
        InitializeComponent()
        Palets = spPaletsProducidos.SelectPaletsProducidosBySccAndReferencia
        PaletsProducidosSumReferencia = spPaletsProducidos.SelectPaletsProducidosSumReferencia

        With Me.ltwPaletsEnAlmacen
            .View = View.Details
            .Columns.Add(New ColumnHeader)
            .Columns(0).Text = "SCC"
            .Columns(0).Width = 50
            .Columns.Add(New ColumnHeader)
            .Columns(1).Text = "Fecha"
            .Columns(1).Width = 80
            .Columns.Add(New ColumnHeader)
            .Columns(2).Text = "Descripcion"
            .Columns(2).Width = 250
            .Columns.Add(New ColumnHeader)
            .Columns(3).Text = "Cajas"
            .Columns(3).Width = 50
            .Columns(3).TextAlign = HorizontalAlignment.Right
            .FullRowSelect = True
            .GridLines = True
            .Sorting = SortOrder.None
        End With

        Dim i As Integer = 0
        While i < Palets.Rows.Count
            Dim lVI As New ListViewItem(New String() {Palets.Rows(i).Item("SCC").ToString, _
                                                      Palets.Rows(i).Item("Fecha").ToString, _
                                                     Palets.Rows(i).Item("Descripcion").ToString, _
                                                     Palets.Rows(i).Item("Cajas").ToString})
            Me.ltwPaletsEnAlmacen.Items.Add(lVI)
            TotalCajasAlmacen += (Palets.Rows(i).Item("Cajas"))
            i += 1
        End While
        Me.txtTotalCajasAlmacen1.Text = Format(TotalCajasAlmacen, "##,###")
        txtTotalPalesAlmacen.Text = ltwPaletsEnAlmacen.Items.Count.ToString
        TotalCajasAlmacen = 0

        With Me.lvwCajasAlmacenPorReferencia
            .View = View.Details
            .Columns.Add(New ColumnHeader)
            .Columns(0).Text = "Descripcion"
            .Columns(0).Width = 250
            .Columns.Add(New ColumnHeader)
            .Columns(1).Text = "Cajas"
            .Columns(1).Width = 50
            .Columns(1).TextAlign = HorizontalAlignment.Right
            .FullRowSelect = True
            .GridLines = True
            .Sorting = SortOrder.None
        End With

        i = 0
        While i < PaletsProducidosSumReferencia.Rows.Count
            Dim lVI As New ListViewItem(New String() {PaletsProducidosSumReferencia.Rows(i).Item("Descripcion").ToString, _
                                                       Format(PaletsProducidosSumReferencia.Rows(i).Item("Cajas"), "##,###")})
            Me.lvwCajasAlmacenPorReferencia.Items.Add(lVI)
            TotalCajasAlmacen += (PaletsProducidosSumReferencia.Rows(i).Item("Cajas"))
            i += 1
        End While
        Me.txtTotalCajasAlmacen.Text = Format(TotalCajasAlmacen, "##,###")

        With Me.lvwPalets
            .View = View.Details
            .Columns.Add(New ColumnHeader)
            .Columns(0).Text = "SCC"
            .Columns(0).Width = 50
            .Columns.Add(New ColumnHeader)
            .Columns(1).Text = "Fecha"
            .Columns(1).Width = 0
            .Columns.Add(New ColumnHeader)
            .Columns(2).Text = "Descripcion"
            .Columns(2).Width = 250
            .Columns.Add(New ColumnHeader)
            .Columns(3).Text = "Cajas"
            .Columns(3).Width = 50
            .Columns(3).TextAlign = HorizontalAlignment.Right
            .FullRowSelect = True
            .GridLines = True
        End With

        With Me.lvwCajasCargaPorReferencia
            .View = View.Details
            .Columns.Add(New ColumnHeader)
            .Columns(0).Text = "Descripcion"
            .Columns(0).Width = 250
            .Columns.Add(New ColumnHeader)
            .Columns(1).Text = "Cajas"
            .Columns(1).Width = 50
            .Columns(1).TextAlign = HorizontalAlignment.Right
            .FullRowSelect = True
            .GridLines = True
        End With

        dtpFecha.activarFoco()
    End Sub

    Private Sub frmExpedicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spCargasNecesidades As New spCargasNecesidades
        Dim UltimasNecesidadesID As Integer = spCargasNecesidades.spMaxCargaNecesidadesMaestro
        With dgvNecesidadesJR
            .DataSource = BasesParaCompatibilidad.BD.ConsultaProcedAlmacenado("SelectCargaNecDetByMaestroIdTotal", UltimasNecesidadesID)
            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 235, 0)
            .FormatoColumna("Carga", BasesParaCompatibilidad.TiposColumna.Miles, , 1)
            .FormatoColumna("Stock", BasesParaCompatibilidad.TiposColumna.Miles, , 2)
            .FormatoColumna("Total", BasesParaCompatibilidad.TiposColumna.Miles, , 3)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 100, 4)
            .Columns("DetalleID").Visible = False
            .Columns("MaestroID").Visible = False
            .FormatoGeneral()
        End With


        'Recuperar las ultimas cargas realizadas.
        'Incluir un campo en la tabla de cargas, de tal forma que controlemos si ese camión se ha sumado a las existencias de JR o no.
        'Sumar todas las cargas que no estan incluidas en las existencias de JR en la consulta SelectCargaNecDetByMaestroIdTotal.
        'Mostrar la suma en la columna adecuada de cada Articulo.


    End Sub

    Private Sub btnExpedir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpedirPrioritario.Click
        Dim IndexOld As Integer
        IndexOld = Me.ltwPaletsEnAlmacen.SelectedItems(0).Index
        'If IndexOld = 0 Then IndexOld = 1
        If txtPaletsCarga.Text = "" Then txtPaletsCarga.Text = "0"
        txtPaletsCarga.Text = txtPaletsCarga.Text + 1

        If Me.ltwPaletsEnAlmacen.SelectedItems.Count > 0 Then
            Dim lVI As New ListViewItem(New String() {Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(0).Text, _
                                                          Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(1).Text, _
                                                          Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(2).Text, _
                                                          Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(3).Text}, -1, Color.Black, Color.AntiqueWhite, New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, System.Byte)))
            Me.lvwPalets.Items.Add(lVI)

            O_Item = lvwCajasAlmacenPorReferencia.FindItemWithText(Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(2).Text)
            If O_Item Is Nothing Then 'Si no se encontró la cadena, O_Item pasa a valer Nothing 

            Else
                Me.lvwCajasAlmacenPorReferencia.Items(O_Item.Index).SubItems(1).Text = _
                    Format(Me.lvwCajasAlmacenPorReferencia.Items(O_Item.Index).SubItems(1).Text - Convert.ToInt32(Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(3).Text.ToString), "##,###")
                If Me.lvwCajasAlmacenPorReferencia.Items(O_Item.Index).SubItems(1).Text = "" Then
                    Me.lvwCajasAlmacenPorReferencia.Items(O_Item.Index).Remove()
                End If
            End If

            PaletsSeleccionados += 1
            If PaletsSeleccionados = 1 Then 'Si es primero lo añade al ListView de totales
                Dim RowArticuloEnvasado As New ListViewItem(New String() {Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(2).Text, _
                                                                               Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(3).Text})
                Me.lvwCajasCargaPorReferencia.Items.Add(RowArticuloEnvasado)
            Else ' Hay que buscar para ver si el ArticuloEnvasado existe en ListView
                O_Item = lvwCajasCargaPorReferencia.FindItemWithText(Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(2).Text)
                If O_Item Is Nothing Then 'Si no se encontró la cadena, O_Item pasa a valer Nothing  
                    Dim RowArticuloEnvasado As New ListViewItem(New String() {Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(2).Text, _
                                                                              Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(3).Text})
                    Me.lvwCajasCargaPorReferencia.Items.Add(RowArticuloEnvasado)
                Else 'Selecciona el elemento encontrado 
                    Me.lvwCajasCargaPorReferencia.Items(O_Item.Index).SubItems(1).Text = _
                        Format(Me.lvwCajasCargaPorReferencia.Items(O_Item.Index).SubItems(1).Text.ToString + Convert.ToInt32(Me.ltwPaletsEnAlmacen.SelectedItems(0).SubItems(3).Text.ToString), "##,###")
                End If

            End If
            ltwPaletsEnAlmacen.SelectedItems(0).Remove()
            If IndexOld = ltwPaletsEnAlmacen.Items.Count Then
                IndexOld = ltwPaletsEnAlmacen.Items.Count - 1
            End If
            ltwPaletsEnAlmacen.Items(IndexOld).Selected = True
            ltwPaletsEnAlmacen.Select()
        Else
            messagebox.show("Debes seleccionar al menos un palet", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

        txtPaletsCarga.Text = Convert.ToInt32(txtPaletsCarga.Text) - 1
        PaletsSeleccionados -= 1
        If Me.lvwPalets.SelectedItems.Count > 0 Then
            Dim lVI As New ListViewItem(New String() {Me.lvwPalets.SelectedItems(0).SubItems(0).Text, _
                                                      Me.lvwPalets.SelectedItems(0).SubItems(1).Text, _
                                                      Me.lvwPalets.SelectedItems(0).SubItems(2).Text, _
                                                      Me.lvwPalets.SelectedItems(0).SubItems(3).Text})
            Me.ltwPaletsEnAlmacen.Items.Add(lVI)

            O_Item = lvwCajasAlmacenPorReferencia.FindItemWithText(Me.lvwPalets.SelectedItems(0).SubItems(2).Text)
            If O_Item Is Nothing Then 'Si no se encontró la cadena, O_Item pasa a valer Nothing  
                Dim RowArticuloEnvasado As New ListViewItem(New String() {Me.lvwPalets.SelectedItems(0).SubItems(2).Text, _
                                                                          Me.lvwPalets.SelectedItems(0).SubItems(3).Text})
                Me.lvwCajasAlmacenPorReferencia.Items.Add(RowArticuloEnvasado)
            Else
                Me.lvwCajasAlmacenPorReferencia.Items(O_Item.Index).SubItems(1).Text = Format(Me.lvwCajasAlmacenPorReferencia.Items(O_Item.Index).SubItems(1).Text + _
                    Convert.ToInt32(Me.lvwPalets.SelectedItems(0).SubItems(3).Text.ToString), "##,###")
            End If

            O_Item = lvwCajasCargaPorReferencia.FindItemWithText(Me.lvwPalets.SelectedItems(0).SubItems(2).Text)
            If O_Item Is Nothing Then 'Si no se encontró la cadena, O_Item pasa a valer Nothing  

            Else
                Me.lvwCajasCargaPorReferencia.Items(O_Item.Index).SubItems(1).Text = Format(Me.lvwCajasCargaPorReferencia.Items(O_Item.Index).SubItems(1).Text _
                                                                                      - Convert.ToInt32(Me.lvwPalets.SelectedItems(0).SubItems(3).Text.ToString), "##,###")
                If Me.lvwCajasCargaPorReferencia.Items(O_Item.Index).SubItems(1).Text = "" Then
                    Me.lvwCajasCargaPorReferencia.Items(O_Item.Index).Remove()
                End If
            End If

            lvwPalets.SelectedItems(0).Remove()
            'ltwPaletsEnAlmacen.Clear()
            'Dim i As Integer = 0
            'While i < Palets.Rows.Count - 1
            '    Dim lVI1 As New ListViewItem(New String() {Palets.Rows(i).Item("SCC").ToString, _
            '                                             Palets.Rows(i).Item("Fecha").ToString, _
            '                                             Palets.Rows(i).Item("Descripcion").ToString, _
            '                                             Palets.Rows(i).Item("Cajas").ToString})
            '    Me.ltwPaletsEnAlmacen.Items.Add(lVI1)
            '    i += 1
            'End While
            'ltwPaletsEnAlmacen.Show()
        Else
            messagebox.show("Debes seleccionar al menos un palet", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnAlbaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlbaran.Click
        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTable As Microsoft.Office.Interop.Word.Table
        Dim oPara1 As Microsoft.Office.Interop.Word.Paragraph, oPara2 As Microsoft.Office.Interop.Word.Paragraph, oPara3 As Microsoft.Office.Interop.Word.Paragraph

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
        oPara1.Range.Text = "         Orden de carga del día " & String.Format("d", dtpFecha.Value)
        oPara1.Range.Font.Bold = True
        oPara1.Range.Font.Size = 20
        oPara1.Format.SpaceAfter = 6
        oPara1.Range.InsertParagraphAfter()

        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Observaciones: " & Me.rtbObservaciones.Text
        oPara2.Range.Font.Size = 14
        oPara2.Format.SpaceAfter = oWord.CentimetersToPoints(1)
        oPara2.Range.InsertParagraphAfter()

        Dim r As Integer
        'oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, lvwPalets.Items.Count + 2, 5)
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 30, 5)
        oTable.Range.ParagraphFormat.SpaceAfter = 6

        oTable.Cell(1, 1).Range.InsertAfter("SCC")
        oTable.Cell(1, 2).Range.InsertAfter("Referencia")
        oTable.Cell(1, 3).Range.InsertAfter("Cajas")
        oTable.Cell(1, 4).Range.InsertAfter("OK")
        oTable.Cell(1, 5).Range.InsertAfter("Observaciones")

        For r = 0 To lvwPalets.Items.Count - 1
            oTable.Cell(r + 2, 1).Range.Text = Format(lvwPalets.Items(r).SubItems(0).Text, "###,###")
            oTable.Cell(r + 2, 2).Range.Text = lvwPalets.Items(r).SubItems(2).Text
            oTable.Cell(r + 2, 3).Range.Text = Format(lvwPalets.Items(r).SubItems(3).Text, "###,###")
            oTable.Rows.Item(r + 2).Range.Font.Bold = False
            oTable.Rows.Item(r + 2).Range.Font.Italic = False
            oTable.Rows.Item(r + 2).Range.Font.Size = 12
            oTable.Cell(r + 2, 1).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable.Cell(r + 2, 2).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft
            oTable.Cell(r + 2, 3).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        Next

        oTable.Columns.Item(1).Width = oWord.CentimetersToPoints(1.6)
        oTable.Columns.Item(2).Width = oWord.CentimetersToPoints(9)
        oTable.Columns.Item(3).Width = oWord.CentimetersToPoints(1.7)
        oTable.Columns.Item(4).Width = oWord.CentimetersToPoints(1)
        oTable.Columns.Item(5).Width = oWord.CentimetersToPoints(5.9)

        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Italic = True
        oTable.Rows.Item(1).Range.Font.Size = 12
        oTable.Rows(1).Range.Font.Name = "Verdana"
        oTable.Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25
        oTable.Rows(1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
        oTable.Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter

        oTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
        oTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

        oPara3 = oDoc.Content.Paragraphs.Add
        oPara3.Format.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
        oPara3.Range.Text = "Responsable de almacen"

        oWord.Visible = True
        oWord.NormalTemplate.Saved = True
        oWord = Nothing
        oDoc = Nothing

    End Sub




End Class