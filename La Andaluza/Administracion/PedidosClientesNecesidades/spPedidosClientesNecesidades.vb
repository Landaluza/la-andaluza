
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

   Public Overloads Function Select_Record(ByVal PedidoClienteNecesidadID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PedidosClientesNecesidades
       Dim dbo As New DBO_PedidosClientesNecesidades
       dbo.searchKey = dbo.item("PedidoClienteNecesidadID")
       dbo.searchKey.value = PedidoClienteNecesidadID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PedidoClienteNecesidadID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_PedidosClientesNecesidades
       dbo.searchKey = dbo.item("PedidoClienteNecesidadID")
       dbo.searchKey.value = PedidoClienteNecesidadID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
