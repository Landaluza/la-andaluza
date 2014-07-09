Imports BasesParaCompatibilidad.DataGridViewExtension

Public Class resumenPersonal
    Private datasource As DataTable
    Private dtb As BasesParaCompatibilidad.DataBase
    Private datagridViewProcedure As String
    Public Sub New(ByVal idenvasado As Integer)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        datagridViewProcedure = "resumenPersonal " & idenvasado
        Me.BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub getData()
        datasource = dtb.Consultar(datagridViewProcedure, True)
    End Sub

    Private Sub binDAtaSource()
        If Not Me.datasource Is Nothing Then
            Me.dgvGeneral.DataSource = datasource
            dgvGeneral.FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            dgvGeneral.FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        getData()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        binDAtaSource()
    End Sub

    Private Sub btnResfrescar_Click(sender As Object, e As EventArgs) Handles btnResfrescar.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class