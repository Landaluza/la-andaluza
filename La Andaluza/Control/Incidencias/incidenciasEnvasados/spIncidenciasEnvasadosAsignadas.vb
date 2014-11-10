Public Class spIncidenciasEnvasadosAsignadas


    Public Function asignados(ByVal id_controlIncidencia As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("IncidenciasSelectDgvByControlIncidencia @id")
        dtb.AñadirParametroConsulta("@id", id_controlIncidencia)
        Return dtb.Consultar
    End Function

    Public Function asignables(ByVal fecha As DateTime, ByVal tipoIncidenciaCalidad As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("IncidenciasSelectDgvByFecha @tipo, @fecha")
        dtb.AñadirParametroConsulta("@tipo", tipoIncidenciaCalidad)
        dtb.AñadirParametroConsulta("@fecha", fecha.Year & If(fecha.Month < 10, "0" & fecha.Month, Convert.ToString(fecha.Month)) & If(fecha.Day < 10, "0" & fecha.Day, Convert.ToString(fecha.Day)))
        Return dtb.Consultar
    End Function

    Public Function asignar_incidencia_envasado(ByVal id_incidenciaEnvasado As Integer, ByVal id_ControlIncidencia As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update incidencias set id_controlIncidencia = @con where incidenciaID= @inc")
        dtb.AñadirParametroConsulta("@con", id_ControlIncidencia)
        dtb.AñadirParametroConsulta("@inc", id_incidenciaEnvasado)
        Return dtb.Execute
    End Function

    Public Function eliminar_incidencia_envasado(ByVal id_incidenciaEnvasado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update incidencias set id_controlIncidencia = null where incidenciaID= @id")
        dtb.AñadirParametroConsulta("@id", id_incidenciaEnvasado)
        Return dtb.Execute
    End Function
End Class
