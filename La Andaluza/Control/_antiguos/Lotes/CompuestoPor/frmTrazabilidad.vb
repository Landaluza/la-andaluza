Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTrazabilidad
    Private dtb As BasesParaCompatibilidad.DataBase
    Private loteID As Integer
    Private ctlLot As ctlLotes
    Private ConEnologicos As Boolean
    Private spCompuesto As spCompuestoPor
    Private dtPArtida As DataTable
    Private dtFinal As DataTable
    Private form As New FrmEntLotes

    Public ReadOnly Property count As Integer
        Get
            Return dgvCompuestoPor.RowCount
        End Get
    End Property

    Public Sub New(ByVal loteID As Integer, conenologicos As Boolean)
        InitializeComponent()

        Me.loteID = loteID
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        spCompuesto = New spCompuestoPor
        Me.ConEnologicos = conenologicos
        ctlLot = New ctlLotes
        ctlLot.setLoteID(loteID)
        Me.BackgroundWorker1.RunWorkerAsync()
    End Sub

    'Private Sub cargarTrazabilidad()




    'ctlLot.mostrarLotesComponentes(dtsCompuestoPor)
    'With dgvCompuestoPor
    '    .DataSource = dtsCompuestoPor
    '    .FormatoGeneral()
    '    .Columns("LoteId").Visible = False
    '    .FormatoColumna("CodigoLote", "Lote", BasesParaCompatibilidad.TiposColumna.Lote, 135, 0)
    '    .FormatoColumna("Cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 64, 1)
    '    .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2)
    'End With

    'ctlLot.mostrarLotesQueCompone(dtsComponenteDe)
    'With dgvComponenteDe
    '    .DataSource = dtsComponenteDe
    '    .FormatoGeneral()
    '    .Columns("LoteId").Visible = False
    '    .FormatoColumna("CodigoLote", "Lote", BasesParaCompatibilidad.TiposColumna.Lote, 135, 0)
    '    .FormatoColumna("Cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 64, 1)
    '    .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 2)
    'End With
    ' End Sub

    Private Sub dgvCompuestoPor_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvCompuestoPor.CellMouseDoubleClick
        Try
            Dim aux As Integer = ctlLot.mostrarPosicionPAraTrazabilidadLotes(dgvCompuestoPor.Rows(e.RowIndex).Cells("loteid").Value, ConEnologicos)
            If aux <> 0 Then
                form = New FrmEntLotes
                form.Text = dgvCompuestoPor.Rows(e.RowIndex).Cells("codigolote").Value.ToString & ", Modificar Lote trazabilidad"
                form.CargarDatos(aux, dgvCompuestoPor.Rows(e.RowIndex).Cells("loteid").Value, 0, 0, ConEnologicos)
                form.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvComponenteDe_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComponenteDe.CellDoubleClick
        Try
            Dim aux As Integer = ctlLot.mostrarPosicionPAraTrazabilidadLotes(dgvComponenteDe.Rows(e.RowIndex).Cells("loteid").Value, ConEnologicos)
            If aux <> 0 Then
                form = New FrmEntLotes
                form.Text = dgvComponenteDe.Rows(e.RowIndex).Cells("codigolote").Value.ToString & ", Modificar Lote trazabilidad"
                form.CargarDatos(aux, dgvComponenteDe.Rows(e.RowIndex).Cells("loteid").Value, 0, 0, ConEnologicos)
                form.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        dtPArtida = Me.dtb.Consultar(spCompuesto.DataGridViewStoredProcedureForFilteredSelect2 & " " & loteID)
        dtFinal = Me.dtb.Consultar(spCompuesto.DataGridViewStoredProcedureForFilteredSelect3 & " " & loteID)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If Not dtPArtida Is Nothing Then
            With dgvCompuestoPor
                .SuspendLayout()
                .DataSource = dtPArtida
                .Columns("loteid").Visible = False
                .Columns("movimientoid").Visible = False
                .FormatoColumna("codigolote", "Lote", BasesParaCompatibilidad.TiposColumna.Descripcion, 95, 1)
                .FormatoColumna("cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 64, 2)
                .FormatoColumna("Observacion", BasesParaCompatibilidad.TiposColumna.Descripcion, True, 3)
                .ResumeLayout()
            End With
        End If

        If Not dtFinal Is Nothing Then
            With dgvComponenteDe
                .SuspendLayout()
                .DataSource = dtFinal
                .Columns("loteid").Visible = False
                .Columns("movimientoid").Visible = False
                .FormatoColumna("codigolote", "Lote", BasesParaCompatibilidad.TiposColumna.Descripcion, 95, 1)
                .FormatoColumna("cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 64, 2)
                .FormatoColumna("Observacion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
                .ResumeLayout()
            End With
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarFormaPArtedeToolStripMenuItem1.Click
        If Not dgvComponenteDe.CurrentRow Is Nothing Then
            Dim frm As New BasesParaCompatibilidad.frmEntrada("Nueva cantidad", "Introduce la nueva cantidad para este movimiento", dgvComponenteDe.CurrentRow.Cells("cantidad").Value.ToStrin)
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                If actualizarTrazabilidad(frm.Result, dgvComponenteDe.CurrentRow.Cells("movimientoid").Value.ToString) Then
                    Me.BackgroundWorker1.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarCompuestoToolStripMenuItem.Click
        If Not dgvCompuestoPor.CurrentRow Is Nothing Then
            Dim frm As New BasesParaCompatibilidad.frmEntrada("Nueva cantidad", "Introduce la nueva cantidad para este movimiento", dgvCompuestoPor.CurrentRow.Cells("cantidad").Value.ToString)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If actualizarTrazabilidad(frm.Result, dgvCompuestoPor.CurrentRow.Cells("movimientoid").Value.ToString) Then
                    Me.BackgroundWorker1.RunWorkerAsync()
                End If
            End If
        End If
    End Sub

    Private Function actualizarTrazabilidad(ByVal cantidad As String, ByVal movimiento As String) As Boolean
        dtb.EmpezarTransaccion()
        Try
            If dtb.ConsultaAlteraciones("update compuestopor set cantidad=" & cantidad & " where movimientoid=" & movimiento) Then
                If dtb.ConsultaAlteraciones("update movimientos set cantidad=" & cantidad & " where movimientoid=" & movimiento) Then
                    dtb.TerminarTransaccion()
                    MessageBox.Show("Operacion completada.", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                Else
                    dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo completar la operacion.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            Else
                dtb.CancelarTransaccion()
                MessageBox.Show("No se pudo completar la operacion.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("No se pudo completar la operacion. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
End Class