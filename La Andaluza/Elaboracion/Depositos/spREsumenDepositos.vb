Public Class spREsumenDepositos

    Public Function listar_depositos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("DepositosSelectDgv", True)
    End Function
End Class
