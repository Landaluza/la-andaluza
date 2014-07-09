Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmLisEnvPorReferencia
    Private TotalEnvasados As Integer
    Private TotalMinutos As Integer
    Private TotalCajas As Integer
    Private TotalBotellas As Integer
    Private TotalLitros As Integer
    Private VelocidadMedia As Integer
    Private datasource As DataTable
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtpDesde.activarFoco()
        dtpHasta.activarFoco()
    End Sub

    Private Sub frmLisEnvPorReferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboReferencia.mam_DataSource("TiposFormatosSelectCbo", True, "Todas")
    End Sub

    Private Sub btnPorDias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorDias.Click
        TotalMinutos = 0
        TotalCajas = 0
        TotalBotellas = 0
        TotalLitros = 0

        Try

            datasource = dtb.Consultar("exec PaletsContenidosSelectDatosEnvasados" & "'" & dtpDesde.Value.ToString & "','" & dtpHasta.Value.AddDays(1).ToString & "'," & cboReferencia.SelectedValue & ",0")
            If Not datasource Is Nothing Then
                dgvEnvasados.Visible = False
                With dgvEnvasados
                    .DataSource = datasource
                    .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 1)
                    .Columns("Fecha").Visible = True
                    If cboReferencia.SelectedValue = 0 Then
                        .Columns("Descripcion").Visible = True
                        .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
                        Panel1.Visible = False

                        .FormatoColumna("Minutos", BasesParaCompatibilidad.TiposColumna.Miles, 63)
                        .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles)
                        .FormatoColumna("Botellas", BasesParaCompatibilidad.TiposColumna.Miles)
                        .FormatoColumna("Litros", BasesParaCompatibilidad.TiposColumna.Miles)
                        .FormatoColumna("Velocidad", BasesParaCompatibilidad.TiposColumna.Miles, 73)
                    Else
                        Panel1.Visible = True
                        .Columns("Descripcion").Visible = False

                        .FormatoColumna("Minutos", BasesParaCompatibilidad.TiposColumna.Miles, True)
                        .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, True)
                        .FormatoColumna("Botellas", BasesParaCompatibilidad.TiposColumna.Miles, True)
                        .FormatoColumna("Litros", BasesParaCompatibilidad.TiposColumna.Miles, True)
                        .FormatoColumna("Velocidad", BasesParaCompatibilidad.TiposColumna.Miles, True)
                    End If

                    .FormatoGeneral()
                End With

                For Each row As DataGridViewRow In dgvEnvasados.Rows
                    TotalMinutos += Convert.ToInt32(If(row.Cells("Minutos").Value = Nothing, 0, row.Cells("Minutos").Value))
                    TotalCajas += Convert.ToInt32(If(row.Cells("Cajas").Value = Nothing, 0, row.Cells("Cajas").Value))
                    TotalBotellas += Convert.ToInt32(If(row.Cells("Botellas").Value = Nothing, 0, row.Cells("Botellas").Value))
                    TotalLitros += Convert.ToInt32(If(row.Cells("Litros").Value = Nothing, 0, row.Cells("Litros").Value))
                Next

                txtTotalBotellas.Visible = True
                txtTotalLitros.Visible = True
                lblBotellas.Visible = True
                lblLitros.Visible = True

                txtTotalEnvasados.Text = Format(dgvEnvasados.Rows.Count, "##,###")
                txtTotalMinutos.Text = Format(TotalMinutos, "##,###")
                txtTotalCajas.Text = Format(TotalCajas, "##,###")
                txtTotalBotellas.Text = Format(TotalBotellas, "##,###")
                txtTotalLitros.Text = Format(TotalLitros, "##,###")
                'VelocidadMedia = (TotalBotellas / TotalMinutos) * 60
                txtVelocidadMedia.Text = Format(VelocidadMedia, "##,###")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.dgvEnvasados.Visible = True
    End Sub

    Private Sub btnPorSCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorSCC.Click
        TotalCajas = 0
        Me.Text = "Listado todos los palets"
        datasource = dtb.Consultar("exec getSCC '" & dtpDesde.Value & "','" & dtpHasta.Value & "'," & cboReferencia.SelectedValue & ",0")

        If Not datasource Is Nothing Then
            With dgvEnvasados
                .DataSource = datasource

                .SortMode(DataGridViewColumnSortMode.Automatic)
                .FormatoColumna("SCC", "SCC", BasesParaCompatibilidad.TiposColumna.Miles, , 0)
                .FormatoColumna("Descripcion", "Referencia", BasesParaCompatibilidad.TiposColumna.Referencia, , 1)
                .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 2)
                .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 3)
                .FormatoColumna("HoraInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 85, 4)
                .FormatoColumna("HoraFin", "Final", BasesParaCompatibilidad.TiposColumna.Hora, 85, 5)
                .FormatoGeneral()
                .Visible = True
            End With

            For Each row As DataGridViewRow In dgvEnvasados.Rows
                TotalCajas += Convert.ToInt32(If(row.Cells("Cajas").Value = Nothing, 0, row.Cells("Cajas").Value))
            Next

            txtTotalCajas.Text = Format(TotalCajas, "##,###")
            txtTotalBotellas.Visible = False
            txtTotalLitros.Visible = False
            lblBotellas.Visible = False
            lblLitros.Visible = False
        End If
    End Sub

    Private Sub btnNoSCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNoSCC.Click
        datasource = dtb.Consultar("exec getSCC '" & dtpDesde.Value & "','" & dtpHasta.Value & "'," & cboReferencia.SelectedValue & "," & Me.txtSCC.Text)

        If Not datasource Is Nothing Then
            With dgvEnvasados
                .DataSource = datasource
                .SortMode(DataGridViewColumnSortMode.Automatic)
                .FormatoColumna("SCC", "SCC", BasesParaCompatibilidad.TiposColumna.Miles, , 0)
                .FormatoColumna("Descripcion", "Referencia", BasesParaCompatibilidad.TiposColumna.Referencia, , 1)
                .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 2)
                .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 3)
                .FormatoColumna("HoraInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Hora, , 4)
                .FormatoColumna("HoraFin", "Final", BasesParaCompatibilidad.TiposColumna.Hora, , 5)
                .FormatoGeneral()
                .Visible = True
            End With

            Me.btnNoSCC.Visible = False
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim mse As New BasesParaCompatibilidad.MicrosoftOfficeExporter
        mse.ExportToExcel("Many", Me.Text, dgvEnvasados)
    End Sub

    Private Sub dgvEnvasados_RowStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvEnvasados.RowStateChanged
        Try
            dgvEnvasados.FormatoGeneral()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnAgrupados_Click(sender As System.Object, e As System.EventArgs) Handles btnAgrupados.Click
        Me.Cursor = Cursors.WaitCursor
        TotalCajas = 0
        datasource = dtb.Consultar("exec PaletsContenidosSelectDatosEnvasados '" & dtpDesde.Value & "','" & dtpHasta.Value.AddDays(1) & "'," & cboReferencia.SelectedValue & ",1")
        Me.Text = "Listado todos los palets"

        If Not datasource Is Nothing Then
            With dgvEnvasados
                .DataSource = datasource
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
                Panel1.Visible = False

                .FormatoColumna("Minutos", BasesParaCompatibilidad.TiposColumna.Miles, 63)
                .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles)
                .FormatoColumna("Botellas", BasesParaCompatibilidad.TiposColumna.Miles)
                .FormatoColumna("Litros", BasesParaCompatibilidad.TiposColumna.Miles)
                .FormatoColumna("Velocidad", BasesParaCompatibilidad.TiposColumna.Miles, 73)
            End With

            For Each row As DataGridViewRow In dgvEnvasados.Rows
                TotalCajas += Convert.ToInt32(If(row.Cells("Cajas").Value = Nothing, 0, row.Cells("Cajas").Value))
            Next

            txtTotalCajas.Text = Format(TotalCajas, "##,###")
            txtTotalBotellas.Visible = False
            txtTotalLitros.Visible = False
            lblBotellas.Visible = False
            lblLitros.Visible = False
            Me.dgvEnvasados.Visible = True
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class