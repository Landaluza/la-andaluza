Public Class checks
    Private frmCkeckProduccion As frmCheckeoProduccion
    Private frmChekeModificacionPalets As frmChekeModificacionPalets
    Private frmMediaProduccion As frmMediaProduccion
    Private frmfecha As frmSeleccionFecha
    Private frmSeleccionDosFechas As frmSeleccionDosFechas
    Private InformesCalidad As InformesCalidad.frmjuegos
    Private frmIncidenciasEntreFehcas As Incidencias_entre_fechas.frmIncidenciasEntreFehcas
    Private frmResumenOEE As OEE.frmOee
    Private frmEspera As BasesParaCompatibilidad.frmEspera
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Me.frmCkeckProduccion = New frmCheckeoProduccion
        Me.frmChekeModificacionPalets = New frmChekeModificacionPalets
        frmMediaProduccion = New frmMediaProduccion
    End Sub

    Private Sub checks_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(Me.frmCkeckProduccion, Me.tpChProduccion)
        Engine_LA.FormEnPestaña(Me.frmChekeModificacionPalets, Me.tpchMoidificacion)
        Engine_LA.FormEnPestaña(Me.frmMediaProduccion, Me.tpMediaProduccion)
    End Sub

    Private Sub tsOEE_Click(sender As System.Object, e As System.EventArgs) Handles tsOEE.Click
        frmfecha = New frmSeleccionFecha
        frmEspera = New BasesParaCompatibilidad.frmEspera("Genrando informe, espere unos segundos")

        Try
            frmfecha.ShowDialog()
            If frmfecha.DialogResult = Windows.Forms.DialogResult.OK Then
                frmEspera.Show()
                InformesCalidad = New InformesCalidad.frmjuegos(BasesParaCompatibilidad.Config.connectionString, frmfecha.FechaHoraSeleccionada)
                GUImain.añadirPestaña(InformesCalidad) 'frm.Show()
            End If
        Catch ex As Exception
            MessageBox.Show("Error generando informe. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub tsEntreFechas_Click(sender As Object, e As EventArgs) Handles tsEntreFechas.Click
        frmSeleccionDosFechas = New frmSeleccionDosFechas
        frmEspera = New BasesParaCompatibilidad.frmEspera("Genrando informe, espere unos segundos")

        Try
            frmSeleccionDosFechas.ShowDialog()
            If frmSeleccionDosFechas.DialogResult = Windows.Forms.DialogResult.OK Then
                frmEspera.Show()
                frmIncidenciasEntreFehcas = New Incidencias_entre_fechas.frmIncidenciasEntreFehcas(BasesParaCompatibilidad.Config.connectionString, frmSeleccionDosFechas.FechaHoraInicioSeleccionada, frmSeleccionDosFechas.FechaHoraFinSeleccionada)
                frmIncidenciasEntreFehcas.Text = "Incidencias entre fechas"
                GUImain.añadirPestaña(frmIncidenciasEntreFehcas)
            End If
        Catch ex As Exception
            MessageBox.Show("Error generando informe. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub

    Private Sub tsResumenOEE_Click(sender As Object, e As EventArgs) Handles tsResumenOEE.Click
        frmEspera = New BasesParaCompatibilidad.frmEspera("Genrando informe, espere unos segundos")

        Try
            frmResumenOEE = New OEE.frmOee(BasesParaCompatibilidad.Config.connectionString)
            frmResumenOEE.Text = "Resumen OEE"
            GUImain.añadirPestaña(frmResumenOEE)
        Catch ex As Exception
            MessageBox.Show("Error generando informe. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frmEspera.Close()
        End Try
    End Sub
End Class
