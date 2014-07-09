Public Class spTiposProductosCompuestoPor

    Public Function selectDgv(ByVal Id As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("TiposProductosCompuestoPorSelecDgv", True)
    End Function
End Class
