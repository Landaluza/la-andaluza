Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPedidosProveedoresEstados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PedidosProveedoresEstadosSelect]",  _
                     "[dbo].[PedidosProveedoresEstadosInsert]",  _
                     "[dbo].[PedidosProveedoresEstadosUpdate]",  _
                     "[dbo].[PedidosProveedoresEstadosDelete]",  _
                     "[dbo].[PedidosProveedoresEstadosSelectDgv]",  _
                     "[dbo].[PedidosProveedoresEstadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal PedidoProveedorEstadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PedidosProveedoresEstados
       Dim dbo As New DBO_PedidosProveedoresEstados
       dbo.searchKey = dbo.item("PedidoProveedorEstadoID")
       dbo.searchKey.value = PedidoProveedorEstadoID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PedidoProveedorEstadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_PedidosProveedoresEstados
       dbo.searchKey = dbo.item("PedidoProveedorEstadoID")
       dbo.searchKey.value = PedidoProveedorEstadoID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_PedidosProveedoresEstados(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PedidosProveedoresEstadosCbo", False)
   End Sub

End Class
