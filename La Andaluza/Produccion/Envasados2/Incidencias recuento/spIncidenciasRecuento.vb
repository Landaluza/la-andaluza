Public Class spIncidenciasRecuento
    Private dtb as BasesParaCompatibilidad.Database

    Public Sub New()
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    End Sub
    Public Function SelectByFecha(ByVal inicio As DateTime, ByVal fin As DateTime) As DataTable
        Dim d1 As String = inicio.Year & "-" & inicio.Month & "-" & inicio.Day & " " & inicio.Hour & ":" & inicio.Minute
        Dim d2 As String = fin.Year & "-" & fin.Month & "-" & fin.Day & " " & fin.Hour & ":" & fin.Minute

        dtb.PrepararConsulta("incidenciasRecuentoSelectByFechas @d1, @d2")
        dtb.AñadirParametroConsulta("@d1", d1)
        dtb.AñadirParametroConsulta("@d2", d2)

        Return dtb.Consultar()
    End Function

End Class
