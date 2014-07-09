Public Class spREsumenDepositos

    Public Function listar_depositos() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("DepositosSelectDgv", True)
    End Function
End Class
