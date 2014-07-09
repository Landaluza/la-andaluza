
Public Class spEnvasadosProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[EnvasadosProductosSelect]",  _
                     "[dbo].[EnvasadosProductosInsert]",  _
                     "[dbo].[EnvasadosProductosUpdate]",  _
                     "[dbo].[EnvasadosProductosDelete]",  _
                     "[dbo].[EnvasadosProductosSelectDgv]",  _
                     "[dbo].[EnvasadosProductosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal EnvasadoProductoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_EnvasadosProductos
       Dim dbo As New DBO_EnvasadosProductos
       dbo.searchKey = dbo.item("EnvasadoProductoID")
       dbo.searchKey.value = EnvasadoProductoID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal EnvasadoProductoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_EnvasadosProductos
       dbo.searchKey = dbo.item("EnvasadoProductoID")
       dbo.searchKey.value = EnvasadoProductoID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
