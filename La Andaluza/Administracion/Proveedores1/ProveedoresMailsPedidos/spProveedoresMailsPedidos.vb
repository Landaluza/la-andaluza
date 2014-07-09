
Public Class spProveedoresMailsPedidos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProveedoresMailsPedidosSelect]",  _
                     "[dbo].[ProveedoresMailsPedidosInsert]",  _
                     "[dbo].[ProveedoresMailsPedidosUpdate]",  _
                     "[dbo].[ProveedoresMailsPedidosDelete]",  _
                     "[dbo].[ProveedoresMailsPedidosSelectDgv]",  _
                     "[dbo].[ProveedoresMailsPedidosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ProveedorMailPedidoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ProveedoresMailsPedidos
       Dim dbo As New DBO_ProveedoresMailsPedidos
       dbo.searchKey = dbo.item("ProveedorMailPedidoID")
       dbo.searchKey.value = ProveedorMailPedidoID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ProveedorMailPedidoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ProveedoresMailsPedidos
       dbo.searchKey = dbo.item("ProveedorMailPedidoID")
       dbo.searchKey.value = ProveedorMailPedidoID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
