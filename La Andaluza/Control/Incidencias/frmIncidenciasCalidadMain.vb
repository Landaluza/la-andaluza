
Public Class frmIncidenciasCalidadMain
 
    Private frmIncidenciasCalidadGeneral As frmIncidenciasCalidadGeneral
    Private frmControlIncidencias As frmControlIncidencias

    Private InformesCalidad As InformesCalidad.Main
    Private InformesCalidad2 As InformesCalidad.Form1
    Private InformesCalidad3 As InformesCalidad.AlmacenNC
    Private frmEspera As BasesParaCompatibilidad.frmEspera

    Private frmTiposIncidencias As frmTiposIncidencias
    Private frmClasesIncidencias As frmClasesIncidencias
    Private frmCategoriaIncidencias As frmCategoriaIncidencias
    Private frmEvaluacion As EvaluacionIncidencia.Form1

    Public Sub New()
        InitializeComponent()

        frmIncidenciasCalidadGeneral = New frmIncidenciasCalidadGeneral
        frmControlIncidencias = New frmControlIncidencias
        frmTiposIncidencias = New frmTiposIncidencias
        frmClasesIncidencias = New frmClasesIncidencias
        frmCategoriaIncidencias = New frmCategoriaIncidencias

        Engine_LA.FormEnPestaña(frmIncidenciasCalidadGeneral, tpIncidenciasGenerales)
        Engine_LA.FormEnPestaña(frmControlIncidencias, tpControlIncidencias)
        Engine_LA.FormEnPestaña(frmTiposIncidencias, tpTiposEnvasados)
        Engine_LA.FormEnPestaña(frmClasesIncidencias, tpCalsesEnvasados)
        Engine_LA.FormEnPestaña(frmCategoriaIncidencias, tpCAtegoriasEnvasados)
    End Sub

    Private Sub tsInforme1_Click(sender As System.Object, e As System.EventArgs) Handles btnIncidencias.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe, espere unos segundos.")
        frmEspera.Show()
        Try
            If Me.frmControlIncidencias.SelectedItem = 0 Then
                Me.tpControlIncidencias.Focus()
            End If
            InformesCalidad = New InformesCalidad.Main(Me.frmControlIncidencias.SelectedItem, BasesParaCompatibilidad.Config.connectionString)
            InformesCalidad.Text = "Informe incidencias"
            GUImain.añadirPestaña(InformesCalidad) 'frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error generando informe. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub tsIncidenciasVigentes_Click(sender As System.Object, e As System.EventArgs) Handles btnVigentes.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe, espere unos segundos.")
        frmEspera.Show()
        Try
            InformesCalidad2 = New InformesCalidad.Form1(BasesParaCompatibilidad.Config.connectionString)
            InformesCalidad2.Text = "Incidencias vigentes"
            GUImain.añadirPestaña(InformesCalidad2) ' frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error generando informe. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub tsAlmacenNC_Click(sender As System.Object, e As System.EventArgs) Handles btnNC.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe, espere unos segundos.")
        frmEspera.Show()
        Try
            InformesCalidad3 = New InformesCalidad.AlmacenNC(BasesParaCompatibilidad.Config.connectionString)
            InformesCalidad3.Text = "Almacen no conforme"
            GUImain.añadirPestaña(InformesCalidad3) ' frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error generando informe. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub btnEvaluacion_Click(sender As Object, e As EventArgs) Handles btnEvaluacion.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe, espere unos segundos.")
        frmEspera.Show()
        Try
            frmEvaluacion = New EvaluacionIncidencia.Form1(BasesParaCompatibilidad.Config.connectionString)
            frmEvaluacion.Text = "Evaluacion"
            GUImain.añadirPestaña(frmEvaluacion) ' frm.Show()
        Catch ex As Exception
            MessageBox.Show("Error generando informe. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub
End Class