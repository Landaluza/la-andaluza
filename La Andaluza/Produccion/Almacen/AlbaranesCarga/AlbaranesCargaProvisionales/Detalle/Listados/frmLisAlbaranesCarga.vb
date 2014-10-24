Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmLisAlbaranesCarga
    Private strDesde As String
    Private strHasta As String
    Private Referencia As Integer

    Private TotalCajas As Integer
    Private TotalBotellas As Integer
    Private TotalLitros As Integer
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()
        dtpDesde.activarFoco()
        dtpHasta.activarFoco()
    End Sub


    Private Sub frmLisAlbaranesCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboReferencia.mam_DataSource(dtb.Consultar("TiposFormatosSelectCbo1", True), True, "Todas")
        cboClientes.mam_DataSource(dtb.Consultar("ClientesCbo", True), True, "Todos")
        cboLugaresEntrega.mam_DataSource(dtb.Consultar("LugaresEntregasCbo", True), True, "Todos")
    End Sub

    Private Sub btnPorDias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorDias.Click
        listar(True)
    End Sub

    Private Sub dgvEnvasados_Sorted(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvEnvasados.Sorted
        'dgvEnvasados.RowsHeight(16)
        dgvEnvasados.RowTemplate.Height = 16
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim p As New BasesParaCompatibilidad.Printer
        p.ImprimirForm(Me)
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        ' Referenciamos el objeto DataTable enlazado a un control DataGridView
        'Dim dt As DataTable = DirectCast(dgvEnvasados.DataSource, DataTable)
        'ExportarTablaExcel(dt)
        Dim mse As New BasesParaCompatibilidad.MicrosoftOfficeExporter
        mse.ExportToExcel(BasesParaCompatibilidad.MicrosoftOfficeExporter.MANY, "Albaranes de carga", dgvEnvasados)
    End Sub

    Private Sub btnDesglose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesglose.Click
        listar(False)
    End Sub

    Private Sub listar(ByVal desglosado As Boolean)
        Me.Cursor = Cursors.WaitCursor
        TotalCajas = 0
        TotalBotellas = 0
        TotalLitros = 0
        Dim datasource As DataTable
        'Dim dt As DateTime = dtpDesde.Value
        'Dim dthasta As DateTime = dtpHasta.Value
        'strDesde = "'" & Format("yyyy/MM/dd", dt) & "'"
        'strHasta = "'" & Format("yyyy/MM/dd", dthasta) & "'"
        Referencia = cboReferencia.SelectedValue

        'datasource = dtb.Consultar("exec AlbaranesCargaProviDetallesSelectDgv " & strDesde & "," & strHasta & "," & Referencia)
        dtb.PrepararConsulta("AlbaranesCargaProviDetallesSelectDgv @desde, @hasta, @ref")
        dtb.AñadirParametroConsulta("@desde", dtpDesde.Value.Date)
        dtb.AñadirParametroConsulta("@hasta ", dtpHasta.Value.Date)
        dtb.AñadirParametroConsulta("@ref", Referencia)
        datasource = dtb.Consultar()

        If Not datasource Is Nothing Then
            dgvEnvasados.Visible = False
            With dgvEnvasados
                If desglosado Then
                    .DataSource = datasource
                    .Columns("Scc").Visible = False
                Else
                    Dim datasource2 As DataTable
                    dtb.PrepararConsulta("AlbaranesCargaProviDetallesDesglosadoSelectDgv @desde, @hasta, @ref")
                    dtb.AñadirParametroConsulta("@desde", dtpDesde.Value.Date)
                    dtb.AñadirParametroConsulta("@hasta ", dtpHasta.Value.Date)
                    dtb.AñadirParametroConsulta("@ref", Referencia)
                    datasource2 = dtb.Consultar()
                    '.DataSource = dtb.Consultar("exec AlbaranesCargaProviDetallesDesglosadoSelectDgv " & strDesde & "," & strHasta & "," & Referencia)
                    If datasource2 Is Nothing Then
                        Return
                    End If

                    .DataSource = datasource2
                    .Columns("Scc").Visible = True
                    .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles, 55, 3)

                End If

                .SortMode(DataGridViewColumnSortMode.Automatic)
                .FormatoColumna("NumeroQS", BasesParaCompatibilidad.TiposColumna.Miles, 80)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)

                .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 55)
                .FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Lote, 55)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
                .Visible = True
                .FormatoGeneral()
            End With

            For Each row As DataGridViewRow In dgvEnvasados.Rows
                TotalCajas += Convert.ToInt32(If(row.Cells("Cajas").Value = Nothing, 0, row.Cells("Cajas").Value))
                'TotalBotellas += Convert.ToInt32(row.Cells("Botellas").Value)
                'TotalLitros += Convert.ToInt32(row.Cells("Litros").Value)
            Next
            txtTotalCajas.Text = Format(TotalCajas, "##,###")
            'txtTotalBotellas.Text = Format(TotalBotellas, "##,###")
            'txtTotalLitros.Text = Format(TotalLitros, "##,###")
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class