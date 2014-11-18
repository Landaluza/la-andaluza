Imports BasesParaCompatibilidad.DataGridViewExtension


Public Class frmPaletSCC
    Private dbo_movimiento As Dbo_PaletsMovimiento
    Private dbo_MovimientoDB As New spPaletsMovimiento
    Private m_DesdeMovimiento As Boolean
    Private m_OrigenDestino As String
    Private m_PaletProducidoOrigen As DBO_PaletsProducidos2
    Private m_PaletProducidoDestino As DBO_PaletsProducidos2
    Private spPaletsProducidos2 As spPaletsProducidos2
    Private spPaletsContenidos2 As spPaletsContenidos2

    Public Sub New()
        InitializeComponent()
        spPaletsProducidos2 = New spPaletsProducidos2
        spPaletsContenidos2 = New spPaletsContenidos2

    End Sub

    Public Sub New(ByVal DesdeMovimiento As Boolean, ByVal OrigenDestino As String)
        InitializeComponent()
        spPaletsProducidos2 = New spPaletsProducidos2
        spPaletsContenidos2 = New spPaletsContenidos2

        m_DesdeMovimiento = DesdeMovimiento
        m_OrigenDestino = OrigenDestino
    End Sub

    Private Sub btnVer_Click(sender As System.Object, e As System.EventArgs) Handles btnVer.Click
        Me.Cursor = Cursors.WaitCursor
        Me.buscar()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub buscar()
        Try
            Dim dtb As New BasesParaCompatibilidad.DataBase
            Dim m_EnAlmacen As Boolean = False
            dtb.PrepararConsulta("PaletsProducidosSCCSelect @scc")
            dtb.AñadirParametroConsulta("@scc", txtSCC.Text)
            Dim dt As DataTable = dtb.Consultar()

            If dt Is Nothing Then
                MessageBox.Show("Debes introducir un SSCC valido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtSCC.Focus()
                Me.dgvMovimientos.DataSource = Nothing
                Return
            End If

            If dt.Rows.Count = 0 Then
                Me.dgvMovimientos.DataSource = Nothing
                Return
            End If

            If m_DesdeMovimiento Then
                'Hay que buscar el PaletID del SSCC
                If m_OrigenDestino = "Origen" Then
                    m_PaletProducidoOrigen = spPaletsProducidos2.Select_RecordBySSCC(txtSCC.Text, dtb)
                    'Compruebo si alguno de los ContenidosPalet del PaletProducido estan en Almacen.
                    Dim tbPaletsContenidos As DataTable = spPaletsContenidos2.PaletsContenidosPorPaletsProducidos(m_PaletProducidoOrigen.PaletProducidoID, dtb)

                    If tbPaletsContenidos.Rows.Count > 0 Then
                        Dim m_DataRow As DataRow
                        For Each m_DataRow In tbPaletsContenidos.Rows
                            If Convert.ToString(m_DataRow.Item("EnAlmacen")) = "True" Then
                                m_EnAlmacen = True
                            End If
                        Next
                    Else
                        m_EnAlmacen = True
                    End If
                    'El problema es que en las monodosis tenemos varios PaletsProducidosID con un mismo SSCC


                    If m_EnAlmacen Then
                        FillDgv(dt)
                    Else
                        MessageBox.Show("Este palet no esta en Almacen, no se pueden hacer movimientos de el.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtSCC.Focus()
                    End If
                Else
                    m_PaletProducidoDestino = spPaletsProducidos2.Select_RecordBySSCC(txtSCC.Text, dtb)
                    'Compruebo si alguno de los ContenidosPalet del PaletProducido estan en Almacen.
                    Dim tbPaletsContenidos As DataTable = spPaletsContenidos2.PaletsContenidosPorPaletsProducidos(m_PaletProducidoDestino.PaletProducidoID, dtb)

                    If tbPaletsContenidos.Rows.Count > 0 Then
                        Dim m_DataRow As DataRow
                        For Each m_DataRow In tbPaletsContenidos.Rows
                            If Convert.ToString(m_DataRow.Item("EnAlmacen")) = "True" Then
                                m_EnAlmacen = True
                            End If
                        Next
                    Else
                        m_EnAlmacen = True
                    End If

                    If m_EnAlmacen Then
                        FillDgv(dt)
                    Else
                        MessageBox.Show("Este palet no esta en Almacen, no se pueden hacer movimientos de el.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtSCC.Focus()
                    End If
                End If

            Else
                FillDgv(dt)
            End If
            
        Catch ex As Exception
            MessageBox.Show("No se pudo recuperar la lista de movimientos. " & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub FillDgv(ByVal dt As DataTable)
        Dim dtb As New BasesParaCompatibilidad.DataBase
        tsimprimir.Visible = True
        dgvMovimientos.Visible = True
        lblArticulo.Visible = True
        lblCajas.Visible = True
        lblDescripcion.Visible = True
        LblCajasExisten.Visible = True

        Try
            If dt.Rows.Item(0).Item("Description") Is Convert.DBNull Then
                lblDescripcion.Text = dt.Rows.Item(1).Item("Description")
                Dim LastRow As Integer = dt.Rows.Count
                LblCajasExisten.Text = dt.Rows.Item(LastRow).Item("CajasFinal")
            Else
                lblDescripcion.Text = dt.Rows.Item(0).Item("Description")
                Dim LastRow As Integer = dt.Rows.Count - 1
                LblCajasExisten.Text = dt.Rows.Item(LastRow).Item("CajasFinal")
            End If

        Catch ex As Exception
            LblCajasExisten.Text = dt.Rows.Item(dt.Rows.Count - 1).Item("CajasFinal")
        End Try

        With dgvMovimientos
            .DataSource = dt
            .SortMode(DataGridViewColumnSortMode.Automatic)
            .Columns("Row").Visible = False
            .Columns("id_movimiento").Visible = False
            .Columns("Tipo").Visible = False
            .Columns("Palet").Visible = False
            .Columns("SCC").Visible = False
            .Columns("Description").Visible = False
            .Columns("UsuarioModificacion").Visible = False
            .Columns("FechaModificacion").Visible = False

            .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 0)
            .FormatoColumna("HoraInicio", "Hora inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85, 1)
            .FormatoColumna("HoraFinal", "Hora final", BasesParaCompatibilidad.TiposColumna.Hora, 85, 2)
            .FormatoColumna("CajasInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Miles, , 3)
            .FormatoColumna("TipoMovimiento", "Movimiento", BasesParaCompatibilidad.TiposColumna.Izquierda, 80, 4)
            .FormatoColumna("CajasMovimiento", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 5)
            .FormatoColumna("CajasFinal", "Final", BasesParaCompatibilidad.TiposColumna.Miles, , 6)
            .FormatoColumna("Documento", BasesParaCompatibilidad.TiposColumna.Izquierda, 90, 7)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True, 8)

            .Visible = True
            '.RowsHeight(16)
            .RowTemplate.Height = 16
        End With


        Me.tsNoConforme.Enabled = True

        Try

            dtb.PrepararConsulta("select max(isnull(id_estado,0)) from paletsproducidos where scc = @scc")
            dtb.AñadirParametroConsulta("@scc", dt.Rows(0).Item("SCC"))
            Dim rdt As DataTable = dtb.Consultar()
            If rdt.Rows(0).Item(0) <> 3 Then
                Me.tsNoConforme.Text = "Marcar como no conforme"
            Else
                Me.tsNoConforme.Text = "Marcar como conforme"
            End If
        Catch ex As Exception
            Me.tsNoConforme.Enabled = False
        End Try
    End Sub



    Private Sub frmdbo_Movimiento_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Dispose()
    End Sub



    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles tsimprimir.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New BasesParaCompatibilidad.frmEspera("Imprimiendo resultados")
        frm.Show()

        Dim oWord As Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTable As Microsoft.Office.Interop.Word.Table
        Dim oPara1 As Microsoft.Office.Interop.Word.Paragraph
        'Dim oPara2 As Word.Paragraph
        Dim dtb As New BasesParaCompatibilidad.DataBase

        Try
            Dim dt As DataTable = dbo_MovimientoDB.SelectPaletSCC(txtSCC.Text, dtb)
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
            oPara1.Range.Text = "Palet SCC :: " & dt.Rows.Item(0).Item("SCC") & " :: " & dt.Rows.Item(0).Item("Description")
            oPara1.Range.Font.Bold = False
            oPara1.Range.Font.Size = 10
            oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter()

            'Insert a 3 x 5 table, fill it with data, and make the first row
            'bold and italic.
            Dim r As Integer ', c As Integer
            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, dt.Rows.Count + 2, 9)
            oTable.Range.ParagraphFormat.SpaceAfter = 6

            oTable.Cell(1, 1).Range.InsertAfter("Fecha")
            oTable.Cell(1, 2).Range.InsertAfter("Hora" & vbCr & "Inicio")
            oTable.Cell(1, 3).Range.InsertAfter("Hora" & vbCr & "Final")
            oTable.Cell(1, 4).Range.InsertAfter("Movimiento")
            oTable.Cell(1, 5).Range.InsertAfter("Cajas" & vbCr & "Inicio")
            oTable.Cell(1, 6).Range.InsertAfter("Cajas" & vbCr & "Movimiento")
            oTable.Cell(1, 7).Range.InsertAfter("Cajas" & vbCr & "Final")
            oTable.Cell(1, 8).Range.InsertAfter("Documento")
            oTable.Cell(1, 9).Range.InsertAfter("Observaciones")

            oTable.Cell(1, 2).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable.Cell(1, 3).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable.Cell(1, 5).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable.Cell(1, 6).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable.Cell(1, 7).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight

            For r = 0 To dt.Rows.Count - 1
                oTable.Cell(r + 2, 1).Range.Text = If(dt.Rows.Item(r).Item("Fecha") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("Fecha"))
                oTable.Cell(r + 2, 2).Range.Text = If(dt.Rows.Item(r).Item("HoraInicio") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("HoraInicio"))
                oTable.Cell(r + 2, 3).Range.Text = If(dt.Rows.Item(r).Item("HoraFinal") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("HoraFinal"))
                oTable.Cell(r + 2, 4).Range.Text = If(dt.Rows.Item(r).Item("TipoMovimiento") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("TipoMovimiento"))
                oTable.Cell(r + 2, 5).Range.Text = If(dt.Rows.Item(r).Item("CajasInicio") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("CajasInicio"))
                oTable.Cell(r + 2, 6).Range.Text = If(dt.Rows.Item(r).Item("CajasMovimiento") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("CajasMovimiento"))
                oTable.Cell(r + 2, 7).Range.Text = If(dt.Rows.Item(r).Item("CajasFinal") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("CajasFinal"))
                oTable.Cell(r + 2, 8).Range.Text = If(dt.Rows.Item(r).Item("Documento") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("Documento"))
                oTable.Cell(r + 2, 9).Range.Text = If(dt.Rows.Item(r).Item("Observaciones") Is System.Convert.DBNull, "", dt.Rows.Item(r).Item("Observaciones"))
                oTable.Cell(r + 2, 2).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 3).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 5).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 6).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r + 2, 7).Range.Paragraphs.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight
            Next

            oTable.Rows.Item(1).Cells.Shading.BackgroundPatternColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdGray25

            oTable.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
            oTable.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

            oTable.AllowAutoFit = True
            oTable.Columns.AutoFit()

            'All done. Close this form.
            oWord.Visible = True
            oWord.NormalTemplate.Saved = True
            oWord = Nothing
            oDoc = Nothing
        Catch ex As Exception
            MessageBox.Show("Erroe." & Environment.NewLine, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Me.Close()
            frm.Close()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.txtSCC.Focus()
        End Try

    End Sub

    Private Sub tsPalet_Click(sender As System.Object, e As System.EventArgs) Handles tsPalet.Click
        marcar_no_expedido()
        Me.buscar()
    End Sub

    Private Function marcar_no_expedido() As Boolean
        If Me.txtSCC.Text <> "" Then
            If IsNumeric(Me.txtSCC.Text) Then
                Dim resp As DialogResult = MessageBox.Show("¿Seguro que desea marcar el palet como 'no expedido'?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If resp = DialogResult.OK Then
                    Dim dtb As New BasesParaCompatibilidad.DataBase
                    dtb.PrepararConsulta("update paletsproducidos set enAlmacen=1 where scc = @scc")
                    dtb.AñadirParametroConsulta("@scc", Me.txtSCC.Text)

                    If Not dtb.Execute() Then
                        MessageBox.Show("No se pudo actualizar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                End If
            End If
        End If

        Return True
    End Function

    Private Sub tsNoConforme_Click(sender As System.Object, e As System.EventArgs) Handles tsNoConforme.Click
        Try
            If tsNoConforme.Text = "Marcar como conforme" Then
                If Me.txtSCC.Text <> "" Then
                    If IsNumeric(Me.txtSCC.Text) Then
                        Dim resp As DialogResult = MessageBox.Show("¿Seguro que desea marcar el palet como 'conforme'?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If resp = DialogResult.OK Then
                            Dim dtb As New BasesParaCompatibilidad.DataBase
                            dtb.PrepararConsulta("update paletsproducidos set id_estado=1 where scc = @scc")
                            dtb.AñadirParametroConsulta("@scc", Me.txtSCC.Text)

                            If Not dtb.Execute Then
                                MessageBox.Show("No se pudo actualizar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                            Me.buscar()
                        End If
                    End If
                End If
            Else
                If Me.txtSCC.Text <> "" Then
                    If IsNumeric(Me.txtSCC.Text) Then
                        Dim resp As DialogResult = MessageBox.Show("¿Seguro que desea marcar el palet como 'no conforme'?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If resp = DialogResult.OK Then
                            Dim dtb As New BasesParaCompatibilidad.DataBase
                            dtb.PrepararConsulta("update paletsproducidos set id_estado=3 where scc = @scc")
                            dtb.AñadirParametroConsulta("@scc", Me.txtSCC.Text)

                            If Not dtb.Execute Then
                                MessageBox.Show("No se pudo actualizar los datos", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                            Me.buscar()
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub EliminarMovimientoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarMovimientoToolStripMenuItem.Click, tsEliminar2.Click
        Try
            If Not dgvMovimientos.CurrentRow Is Nothing Then
                If Me.dgvMovimientos.CurrentRow.Cells("TipoMovimiento").Value = "Envasar" Then
                    Dim resp As DialogResult = MessageBox.Show("Esta operación eliminará el contenido del palet y puede generar información incorrecta." & Environment.NewLine & _
                                                      "Tenga en cuenta que el movimiento de envasado puede ir unido a un movimiento de o varios de diferencia." & Environment.NewLine & _
                                                       "Si continua se le dirigirá a la ventana de palets producidos ¿Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If resp = DialogResult.Yes Then
                        Dim dtb As New BasesParaCompatibilidad.DataBase
                        Dim spForamtos As New spFormatosEnvasados
                        Dim spEnvasados2 As New spEnvasados2
                        'Dim m_p As DBO_PaletsProducidos2 = spPaletsProducidos2.Select_RecordBySSCC(Me.dgvMovimientos.CurrentRow.Cells("SCC").Value, dtb)
                        'Dim m_f As DBO_FormatosEnvasados = spForamtos.Select_Record(m_p.FormatoID, dtb)
                        'Dim m_e As DBO_Envasados2 = spEnvasados2.Select_Record(m_f.EnvasadoID, dtb)
                        Dim sppp As New spPaletsProducidos
                        Dim dboPaletsProducidos As DBO_PaletsProducidos = sppp.Select_RecordBySSCC(Me.dgvMovimientos.CurrentRow.Cells("SCC").Value, dtb)

                        Dim dbpFormato As DBO_FormatosEnvasados = spForamtos.Select_Record(dboPaletsProducidos.FormatoID, dtb)
                        Dim frm As New frmEntPaletsProducidos(0, dbpFormato.TipoFormatoEnvasadoID, dbpFormato.EnvasadoID, BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sppp, dboPaletsProducidos)

                        'Dim frm As New frmEntPaletsProducidos2(m_f.ID, True)
                        '' Dim frm As New frmEntPaletsProducidos(, )
                        'frm.Text = "Modificar palet producido"
                        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                    End If
                Else
                    If Me.dgvMovimientos.CurrentRow.Cells("TipoMovimiento").Value = "Expedir" Then
                        marcar_no_expedido()
                    Else
                        If Not IsDBNull(Me.dgvMovimientos.CurrentRow.Cells("id_movimiento").Value) Then
                            Dim sp As New spPaletsMovimiento
                            Dim dtb As New BasesParaCompatibilidad.DataBase
                            If Not sp.Delete(Me.dgvMovimientos.CurrentRow.Cells("id_movimiento").Value, dtb) Then
                                Throw New Exception("ERR1. Error al eliminar el movimiento")
                            End If
                        End If
                    End If
                End If
            Else
                MessageBox.Show("seleccione una fila")
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el registro. Detalles: " & Environment.NewLine & ex.Message)
            Return
        End Try

        buscar()
    End Sub

    Private Sub ModificarMovimientoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModificarMovimientoToolStripMenuItem.Click
        Dim dtb As New BasesParaCompatibilidad.DataBase
        Try
            If Me.dgvMovimientos.CurrentRow.Cells("TipoMovimiento").Value = "Envasar" Then
                Dim resp As DialogResult = MessageBox.Show("Esta operación modificará el contenido del palet y puede generar información incorrecta." & Environment.NewLine & _
                                                  "Tenga en cuenta que el movimiento de envasado puede ir unido a un movimiento de encajado." & Environment.NewLine & _
                                                   "Si continua se le dirigirá a la ventana de palets producidos ¿Desea continuar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resp = DialogResult.Yes Then

                    Dim spForamtos As New spFormatosEnvasados
                    Dim spEnvasados2 As New spEnvasados2
                    Dim sppp As New spPaletsProducidos
                    Dim dboPaletsProducidos As DBO_PaletsProducidos = sppp.Select_RecordBySSCC(Me.dgvMovimientos.CurrentRow.Cells("SCC").Value, dtb)

                    Dim dbpFormato As DBO_FormatosEnvasados = spForamtos.Select_Record(dboPaletsProducidos.FormatoID, dtb)
                    Dim frm As New frmEntPaletsProducidos(0, dbpFormato.TipoFormatoEnvasadoID, dbpFormato.EnvasadoID, BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, sppp, dboPaletsProducidos)

                    'Dim spFormato As New spFormatosEnvasados
                    'Dim spEnvasados2 As New spEnvasados2
                    'Dim m_p As DBO_PaletsProducidos2 = spPaletsProducidos2.Select_RecordBySSCC(Me.dgvMovimientos.CurrentRow.Cells("SCC").Value, dtb)
                    'Dim m_f As DBO_FormatosEnvasados = spFormato.Select_Record(m_p.FormatoID, dtb)
                    'Dim m_e As DBO_Envasados2 = spEnvasados2.Select_Record(m_f.EnvasadoID, dtb)

                    'Dim frm As New frmEntPaletsProducidos2(m_f.ID, True)
                    'frm.Text = "Modificar palet producido"
                    BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                    buscar()

                End If

            Else

                Dim sp As New spPaletsMovimiento
                Dim sp2 As New spPaletsMovimientosTipos
                Dim dbo As Dbo_PaletsMovimiento = sp.Select_Record(Me.dgvMovimientos.CurrentRow.Cells("id_movimiento").Value, dtb)
                Dim d As DBO_PaletsMovimientosTipos = sp2.Select_Record(dbo.Tipo, dtb)

                If d.EntrePalets Then
                    If dbo.MovimientoEntrePaletsID = Nothing Then
                        MessageBox.Show("No se puede modificar el movimiento. Falta información sobre el segundo movimiento")
                        Return
                    End If
                End If

                Dim frm As New frmModMovimientoPalet(dbo)
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                buscar()
                'If d.EntrePalets Then
                '    messagebox.show("No se puede modificar un movimiento entre palets")
                'Else

                '    Dim frm As New frmModMovimientoPalet(dbo)
                '    BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                '    buscar()

                'End If



            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CambiarHoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarHoraToolStripMenuItem.Click, tsCambiarHora.Click
        Try
            If Me.dgvMovimientos.CurrentRow Is Nothing Then
                Return
            End If

            If Me.dgvMovimientos.CurrentRow.Cells("id_movimiento").Value Is Convert.DBNull Then
                Return
            End If

            Dim dtb As New BasesParaCompatibilidad.DataBase
            Dim sp As New spPaletsMovimiento
            Dim dbo As Dbo_PaletsMovimiento = sp.Select_Record(Me.dgvMovimientos.CurrentRow.Cells("id_movimiento").Value, dtb)
            Dim frm As New frmModificarHora()
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                dbo.Hora = frm.Hora
                dtb.PrepararConsulta("update paletsmovimiento set hora = @hora where id = @id")
                dtb.AñadirParametroConsulta("@hora", dbo.Hora)
                dtb.AñadirParametroConsulta("@id", dbo.ID)
                If Not dtb.Execute Then
                    MessageBox.Show("No se pudo actualizar la hora", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        buscar()
    End Sub

    Private Sub CambiarFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarFechaToolStripMenuItem.Click, tsCAmbiarFecha.Click
        Try
            If Me.dgvMovimientos.CurrentRow Is Nothing Then
                Return
            End If

            If Me.dgvMovimientos.CurrentRow.Cells("id_movimiento").Value Is Convert.DBNull Then
                Return
            End If

            Dim dtb As New BasesParaCompatibilidad.DataBase
            Dim sp As New spPaletsMovimiento
            Dim dbo As Dbo_PaletsMovimiento = sp.Select_Record(Me.dgvMovimientos.CurrentRow.Cells("id_movimiento").Value, dtb)
            Dim frm As New frmModificarFecha()
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                dbo.Fecha = frm.Fecha
                dtb.PrepararConsulta("update paletsmovimiento set fecha = @fecha where id = @id")
                dtb.AñadirParametroConsulta("@fecha", dbo.Fecha)
                dtb.AñadirParametroConsulta("@id", dbo.ID)

                If Not dtb.Execute Then
                    MessageBox.Show("No se pudo actualizar la hora", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

        buscar()
    End Sub
End Class
