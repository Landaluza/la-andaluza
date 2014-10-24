
Public Class spPedidosClientesNecesidades
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PedidosClientesNecesidadesSelect]", _
                      "[dbo].[PedidosClientesNecesidadesInsert]", _
                      "[dbo].[PedidosClientesNecesidadesUpdate]", _
                      "[dbo].[PedidosClientesNecesidadesDelete]", _
                      "[dbo].[PedidosClientesNecesidadesSelectDgv]", _
                      "[dbo].[PedidosClientesNecesidadesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal PedidoClienteNecesidadID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PedidosClientesNecesidades
        Dim dbo As New DBO_PedidosClientesNecesidades
        dbo.searchKey = dbo.item("PedidoClienteNecesidadID")
        dbo.searchKey.value = PedidoClienteNecesidadID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PedidoClienteNecesidadID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PedidosClientesNecesidades
        dbo.searchKey = dbo.item("PedidoClienteNecesidadID")
        dbo.searchKey.value = PedidoClienteNecesidadID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
