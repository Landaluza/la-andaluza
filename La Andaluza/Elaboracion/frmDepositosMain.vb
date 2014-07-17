Imports FastReport
Imports FastReport.Data
Imports FastReport.Utils

Public Class frmDepositosMain
    Private frmEspera As BasesParaCompatibilidad.frmEspera
    Private frmDepositos As frmDepositos
    Private frmMaterialConstruccion As frmMaterialConstruccion

    Private frmExistenciasPorDepositoFecha As InformesDepositos.frmExistenciasPorDepositoFecha
    Private LisDepPorTipos As LisDepPorTipos
    Private LisDepResumen As LisDepResumen
    Public Sub New()

        InitializeComponent()

        frmDepositos = New frmDepositos
        frmMaterialConstruccion = New frmMaterialConstruccion

        Engine_LA.FormEnPestaña(frmDepositos, TabPage1)
        Engine_LA.FormEnPestaña(frmMaterialConstruccion, TabPage2)
    End Sub

    Private Sub btndepositos_Click(sender As Object, e As EventArgs) Handles btndepositos.Click
        LisDepResumen = New LisDepResumen
        GUImain.añadirPestaña(LisDepResumen)
    End Sub

    Private Sub btnTipos_Click(sender As Object, e As EventArgs) Handles btnTipos.Click
        LisDepPorTipos = New LisDepPorTipos
        GUImain.añadirPestaña(LisDepPorTipos)
    End Sub

    Private Sub btnFechas_Click(sender As Object, e As EventArgs) Handles btnFechas.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera
        frmEspera.Show()
        Try
            frmExistenciasPorDepositoFecha = New InformesDepositos.frmExistenciasPorDepositoFecha(BasesParaCompatibilidad.Config.connectionString)
            GUImain.añadirPestaña(frmExistenciasPorDepositoFecha)
        Catch ex As Exception
            MessageBox.Show("Error mostrando el informe. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim report As New Report
        With report
            '.Load("Elaboracion\Depositos\Listados\Depositos.frx")
            .Load("\\192.168.1.200\datos\informatica\La Andaluza app\Depositos.frx")
            Dim table As TableDataSource = TryCast(report.GetDataSource("tblReport1"), TableDataSource)
            .Show()
        End With
    End Sub
End Class