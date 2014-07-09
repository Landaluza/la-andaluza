Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmLisEnvPorArticuloPrimario
    Private datasource As DataTable
    Private dtb As BasesParaCompatibilidad.DataBase
    Private mse As BasesParaCompatibilidad.MicrosoftOfficeExporter
    Private consulta As String
    Public Sub New()

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        mse = New BasesParaCompatibilidad.MicrosoftOfficeExporter
        dtpHasta.activarFoco()
        dtpDesde.activarFoco()
        dtb.TimeOut = 300
    End Sub

    Private Sub btnPorDias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPorDias.Click
        dgvFill()
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        dgvFill()
        mse.ExportToExcel("Many", Me.Text, dgvEnvasados)
    End Sub

    Private Sub dgvFill()

        consulta = "exec SumaEnvasesEntreFechas '" & _
                              Format("yyyy/MM/dd", dtpDesde.Value) & "', '" & _
                                 Format("yyyy/MM/dd", dtpHasta.Value) & "'"


        If Not BackgroundWorker1.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try

            datasource = dtb.Consultar(consulta, False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If Not datasource Is Nothing Then
            With dgvEnvasados
                If Not datasource Is Nothing Then
                    .SuspendLayout()
                    .DataSource = datasource
                    .FormatoColumna("Envase", BasesParaCompatibilidad.TiposColumna.Descripcion, True, 0, 350)
                    .FormatoColumna("TotalEnvases", BasesParaCompatibilidad.TiposColumna.Miles, True)
                    .FormatoColumna("TotalMinutos", BasesParaCompatibilidad.TiposColumna.Miles, True)
                    .FormatoColumna("TotalHoras", BasesParaCompatibilidad.TiposColumna.Miles, True)
                    .FormatoColumna("EnvasesHora", BasesParaCompatibilidad.TiposColumna.Miles, True)
                    .FormatoColumna("TotalPesetas", BasesParaCompatibilidad.TiposColumna.Miles, True)
                    .FormatoColumna("PesetasEnvase", BasesParaCompatibilidad.TiposColumna.Double5, True)
                    ResumeLayout()
                End If
            End With
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class