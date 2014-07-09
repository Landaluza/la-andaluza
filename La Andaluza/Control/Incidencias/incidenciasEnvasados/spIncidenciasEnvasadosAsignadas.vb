Public Class spIncidenciasEnvasadosAsignadas


    Public Function asignados(ByVal id_controlIncidencia As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("IncidenciasSelectDgvByControlIncidencia " & id_controlIncidencia, False)
    End Function

    Public Function asignables(ByVal fecha As DateTime, ByVal tipoIncidenciaCalidad As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("IncidenciasSelectDgvByFecha " & tipoIncidenciaCalidad & ", " & fecha.Year & If(fecha.Month < 10, "0" & fecha.Month, Convert.ToString(fecha.Month)) & If(fecha.Day < 10, "0" & fecha.Day, Convert.ToString(fecha.Day)), False)
    End Function

    Public Function asignar_incidencia_envasado(ByVal id_incidenciaEnvasado As Integer, ByVal id_ControlIncidencia As Integer) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.ConsultaAlteraciones("update incidencias set id_controlIncidencia = " & id_ControlIncidencia & " where incidenciaID=" & id_incidenciaEnvasado)
    End Function

    Public Function eliminar_incidencia_envasado(ByVal id_incidenciaEnvasado As Integer) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.ConsultaAlteraciones("update incidencias set id_controlIncidencia = null where incidenciaID=" & id_incidenciaEnvasado)
    End Function
End Class
