Public Class spREsumenDepositos

    Public Function listar_depositos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("DepositosSelectDgv")
        Return dtb.Consultar()
    End Function
End Class
