Imports BasesParaCompatibilidad.DataGridViewExtension

Public Class frmOrdenesEnvasado2Detalle
    Private m_LineaID As Integer
    Private m_DBO_OrdenesEnvasado As DBO_OrdenesEnvasado2
    Private spArticulosOrdenEnvasado2 As spArticulosOrdenEnvasado2
    Private frmEnt As frmEntArticulosOrdenEnvasado2
    Private dtb as BasesParaCompatibilidad.Database
    Private m_DBO_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2
    Private frmDetallesArtOrdEnv As frmDetallesArtOrdEnv

    Public Sub New(ByVal OrdenEnvasado As DBO_OrdenesEnvasado2, ByVal LineaID As Integer)
        InitializeComponent()
        m_DBO_OrdenesEnvasado = OrdenEnvasado
        m_LineaID = LineaID
        spArticulosOrdenEnvasado2 = New spArticulosOrdenEnvasado2
        dtb = New BasesParaCompatibilidad.Database()

        If OrdenEnvasado.OrdenEnvasadoID = 0 Then
            Me.tsFormatos.Enabled = False
            Me.ToolStrip1.Enabled = False
        End If
    End Sub

    Private Sub frm_OrdenPrueba_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrillas()
        FormatoGrillas()
    End Sub

    Private Sub HabilitarBotones()
        Select Case Me.Text.Substring(0, 3)
            Case "Ver", "Ins"
                tsInsertar.Enabled = False
                tsModificar.Enabled = False
                tsEliminar.Enabled = False
                tsInsertar1.Enabled = False
            Case "Mod"
                If dgvArtOrdEnv.RowCount > 0 Then
                    tsInsertar.Enabled = True
                    tsModificar.Enabled = True
                    tsEliminar.Enabled = True
                Else
                    tsInsertar.Enabled = True
                    tsModificar.Enabled = False
                    tsEliminar.Enabled = False
                End If
                If dgvPedidos.RowCount > 0 Then
                    tsInsertar1.Enabled = True
                Else
                    tsInsertar1.Enabled = False
                End If
        End Select
    End Sub

    Private Sub FormatoGrillas()

        With dgvArtOrdEnv
            .Columns("ArticuloOrdenEnvasadoID").Visible = False
            .Columns("LineasEnvasado").Visible = False
            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 480, 0)
            .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 1)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 300, 2)
            .FormatoGeneral()
        End With

        With dgvAlbaranes
            '. dataSource = dtb.Consultar("InformePedidos_SelectAlbaranesCargaMaestro")
            .DataSource = dtb.Consultar("InformePedidos_SelectAlbaranesCargaMaestro", True)
            .Columns("AlbaranCargaMaestroID").Visible = False
            .Columns("ClienteID").Visible = False
            .Columns("Observaciones").Visible = False
            .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 70, 0)
            .FormatoColumna("NumeroQS", BasesParaCompatibilidad.TiposColumna.Miles, 70, 1)
            .FormatoGeneral()
        End With

        With dgvPedidos
            .Columns("TipoFormatoID").Visible = False
            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 480, 0)
            .FormatoColumna("ExistenciasLA", "En LA", BasesParaCompatibilidad.TiposColumna.Miles, 70, 1)
            .FormatoColumna("Transito", BasesParaCompatibilidad.TiposColumna.Miles, 70, 2)
            .FormatoColumna("PedidosJR", BasesParaCompatibilidad.TiposColumna.Miles, 70, 3)
            .FormatoColumna("StockJR", BasesParaCompatibilidad.TiposColumna.Miles, 70, 4)
            .FormatoColumna("PedidosLA", BasesParaCompatibilidad.TiposColumna.Miles, 70, 5)
            .FormatoColumna("StockLA", BasesParaCompatibilidad.TiposColumna.Miles, 70, 6)
            .FormatoColumna("CantOrden", BasesParaCompatibilidad.TiposColumna.Miles, 70, 7)
            .FormatoColumna("A Envasar", BasesParaCompatibilidad.TiposColumna.Miles, 70, 8)
            .FormatoGeneral()
        End With
    End Sub

    Private Sub ActualizarGrillas()
        dgvArtOrdEnv.DataSource = dtb.Consultar("ArticulosOrdenEnvasado2SelectPorOrdenEnvasadoPorLinea " & m_DBO_OrdenesEnvasado.OrdenEnvasadoID & ", " & m_LineaID.ToString, True)
        dgvPedidos.DataSource = dtb.Consultar("OrdenesEnvasados2InformePedidosPorLinea " & m_LineaID & ",'" & m_DBO_OrdenesEnvasado.Fecha & "'", True)
        HabilitarBotones()
    End Sub

    Private Sub Action(ByVal TipoAction As String)
        m_DBO_ArticulosOrdenEnvasado = New DBO_ArticulosOrdenEnvasado2()
        Dim m_Pos As Integer

        Select Case TipoAction
            Case "Insertar"
                m_DBO_ArticulosOrdenEnvasado.OrdenEnvasadoID = m_DBO_OrdenesEnvasado.OrdenEnvasadoID
                m_DBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID = 0
            Case "Insertar1"
                If dgvPedidos.CurrentRow Is Nothing Then
                    MessageBox.Show("No seleccionó ningún registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return
                End If
                m_DBO_ArticulosOrdenEnvasado.OrdenEnvasadoID = m_DBO_OrdenesEnvasado.OrdenEnvasadoID
                m_DBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID = 0
                m_DBO_ArticulosOrdenEnvasado.Cajas = dgvPedidos.CurrentRow.Cells("A Envasar").Value
                m_DBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID = dgvPedidos.CurrentRow.Cells("TipoFormatoID").Value
            Case Else
                m_Pos = dgvArtOrdEnv.CurrentRow.Index
                m_DBO_ArticulosOrdenEnvasado = spArticulosOrdenEnvasado2.Select_Record(dgvArtOrdEnv.CurrentRow.Cells("ArticuloOrdenEnvasadoID").Value, dtb)
        End Select
        m_DBO_ArticulosOrdenEnvasado.LineaID = m_LineaID

        frmEnt = New frmEntArticulosOrdenEnvasado2(m_DBO_ArticulosOrdenEnvasado, m_Pos)
        frmEnt.Text = String.Format("{0} ArticulosOrdenEnvasado", TipoAction)
        AddHandler frmEnt.FormClosed, AddressOf ActualizarGrillas
        'frmEnt.ShowDialog(Me)
        GUImain.añadirPestaña(frmEnt)

        ActualizarGrillas()
        FormatoGrillas()
        'tsLimpiarSelecciones.PerformClick()
    End Sub

    Private Sub tsInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInsertar.Click
        Action("Insertar")
    End Sub

    Private Sub tsModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsModificar.Click
        Action("Modificar")
    End Sub

    Private Sub tsInsertar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInsertar1.Click
        Action("Insertar1")
    End Sub

    Private Sub tsEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsEliminar.Click
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If spArticulosOrdenEnvasado2.ArticulosOrdenEnvasadoDelete(dgvArtOrdEnv.CurrentRow.Cells("ArticuloOrdenEnvasadoID").Value, dtb) Then
                ActualizarGrillas()
                FormatoGrillas()
            End If
        End If
    End Sub

    Private Sub tsDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDetalles.Click
        frmDetallesArtOrdEnv = New frmDetallesArtOrdEnv
        frmDetallesArtOrdEnv.ShowDialog()
    End Sub

    Private Sub tsVerPedidos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsVerPedidos.Click
        dgvPedidos.DataSource = Nothing

        Dim i As Integer = 0
        While i < dgvAlbaranes.SelectedRows.Count
            dtb.Consultar("InformePedidos_InsertTempAlbaranesCargaMaestro " & dgvAlbaranes.SelectedRows(i).Cells("AlbaranCargaMaestroID").Value.ToString, True)
            'DataTableFill("InformePedidos_InsertTempAlbaranesCargaMaestro " & dgvAlbaranes.SelectedRows(i).Cells("AlbaranCargaMaestroID").Value)
            i = i + 1
        End While

        dgvPedidos.DataSource = dtb.Consultar("OrdenesEnvasados2InformePedidosPorLinea " & m_LineaID & ",'" & m_DBO_OrdenesEnvasado.Fecha & "'", True)
        'dgvPedidos.DataSource = DataTableFillSPConParametros("OrdenesEnvasados2InformePedidosPorLinea", "@LineaID", m_LineaID, "@FechaPedido", m_DBO_OrdenesEnvasado.Fecha)
        FormatoGrillas()
        HabilitarBotones()
    End Sub

    Private Sub tsLimpiarSelecciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsLimpiarSelecciones.Click
        dgvAlbaranes.ClearSelection()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsWord.Click
        ImprimirHoja()
    End Sub

    Private Sub ImprimirHoja()
        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTable As Microsoft.Office.Interop.Word.Table
        Dim oPara1 As Microsoft.Office.Interop.Word.Paragraph, oPara2 As Microsoft.Office.Interop.Word.Paragraph

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
                    .Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape
                Catch ex As Exception
                End Try
                .LeftMargin = oWord.CentimetersToPoints(1)
                .BottomMargin = oWord.CentimetersToPoints(1)
                .TopMargin = oWord.CentimetersToPoints(1)
            End With

            'Insert a paragraph at the beginning of the document.
            oPara1 = oDoc.Content.Paragraphs.Add
            oPara1.Range.Text = "                      Orden de envasado del día " & Format("d", m_DBO_OrdenesEnvasado.Fecha)
            oPara1.Range.Font.Bold = True
            oPara1.Range.Font.Size = 28
            oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            'Insert a paragraph at the end of the document.
            '** \endofdoc is a predefined bookmark.
            oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara2.Range.Text = "Observaciones: " & m_DBO_OrdenesEnvasado.Observaciones
            oPara2.Range.Font.Size = 14
            oPara2.Format.SpaceAfter = oWord.CentimetersToPoints(1)
            oPara2.Range.InsertParagraphAfter()

            Dim r As Integer ', c As Integer
            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, dgvArtOrdEnv.RowCount + 2, 3)
            oTable.Range.ParagraphFormat.SpaceAfter = 6

            oTable.Cell(1, 1).Range.InsertAfter("Referencia")
            oTable.Cell(1, 2).Range.InsertAfter("Cajas")
            oTable.Cell(1, 3).Range.InsertAfter("Observaciones")

            For r = 0 To dgvArtOrdEnv.RowCount - 1
                oTable.Cell(r + 2, 1).Range.Text = dgvArtOrdEnv.Rows(r).Cells(2).Value
                oTable.Cell(r + 2, 2).Range.Text = If(dgvArtOrdEnv.Rows(r).Cells(3).Value Is Convert.DBNull, "", Format(dgvArtOrdEnv.Rows(r).Cells(3).Value, "###,###"))
                oTable.Cell(r + 2, 3).Range.Text = If(dgvArtOrdEnv.Rows(r).Cells(4).Value Is Convert.DBNull, "", dgvArtOrdEnv.Rows(r).Cells(4).Value)
                oTable.Rows.Item(r + 2).Range.Font.Bold = False
                oTable.Rows.Item(r + 2).Range.Font.Italic = False
                oTable.Rows.Item(r + 2).Range.Font.Size = 12
                oTable.Cell(r + 2, 2).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            Next

            oTable.Columns.Item(1).Width = oWord.CentimetersToPoints(14)  'Change width of columns 1 & 2
            oTable.Columns.Item(2).Width = oWord.CentimetersToPoints(2.5)
            oTable.Columns.Item(3).Width = oWord.CentimetersToPoints(10)
            'oTable.Columns(2).Width = oWord.CentimetersToPoints(2)

            oTable.Rows.Item(1).Range.Font.Bold = True
            oTable.Rows.Item(1).Range.Font.Italic = True
            oTable.Rows.Item(1).Range.Font.Size = 14
            oTable.Rows(1).Range.Font.Name = "Verdana"
            oTable.Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25
            oTable.Rows(1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
            oTable.Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter

            oTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            oTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

            oWord.Visible = True
            oWord.NormalTemplate.Saved = True
            oWord = Nothing
            oDoc = Nothing
        Catch ex As Exception
            MessageBox.Show("Error generando word. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    'Private Sub frmOrdenesEnvasado2Detalle_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '    If e.KeyCode = Keys.ControlKey And e.KeyCode = Keys.Down Then
    '        Me.SplitContainer1.Panel2Collapsed = True
    '    Else
    '        If e.KeyCode = Keys.ControlKey And e.KeyCode = Keys.Up Then
    '            Me.SplitContainer1.Panel1Collapsed = True
    '        End If
    '    End If
    'End Sub

End Class