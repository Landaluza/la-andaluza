Public Class spIncidenciasRecuento

    Public Sub New()

    End Sub
    Public Function SelectByFecha(ByVal inicio As DateTime, ByVal fin As DateTime, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Dim d1 As String = inicio.Year & "-" & inicio.Month & "-" & inicio.Day & " " & inicio.Hour & ":" & inicio.Minute
        Dim d2 As String = fin.Year & "-" & fin.Month & "-" & fin.Day & " " & fin.Hour & ":" & fin.Minute

        dtb.PrepararConsulta("incidenciasRecuentoSelectByFechas @d1, @d2")
        dtb.AñadirParametroConsulta("@d1", d1)
        dtb.AñadirParametroConsulta("@d2", d2)

        Return dtb.Consultar()
    End Function

End Class
