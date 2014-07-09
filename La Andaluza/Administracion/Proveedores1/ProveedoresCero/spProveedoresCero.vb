

Public Class spProveedoresCero
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProveedoresCeroSelect]", "[dbo].[ProveedoresCeroInsert]", "[dbo].[ProveedoresCeroUpdate]", "[dbo].[ProveedoresCeroDelete]", "[dbo].[ProveedoresCeroSelectDgv]", "[dbo].[ProveedoresCeroSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ProveedoresCero
       Dim dbo As New DBO_ProveedoresCero
        dbo.searchKey = dbo.item("Id_proveedor")
        dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ProveedoresCero
        dbo.searchKey = dbo.item("Id_proveedor")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
