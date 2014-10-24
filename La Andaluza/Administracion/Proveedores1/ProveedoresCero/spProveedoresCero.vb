

Public Class spProveedoresCero
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProveedoresCeroSelect]", "[dbo].[ProveedoresCeroInsert]", "[dbo].[ProveedoresCeroUpdate]", "[dbo].[ProveedoresCeroDelete]", "[dbo].[ProveedoresCeroSelectDgv]", "[dbo].[ProveedoresCeroSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ProveedoresCero
        Dim dbo As New DBO_ProveedoresCero
        dbo.searchKey = dbo.item("Id_proveedor")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ProveedoresCero
        dbo.searchKey = dbo.item("Id_proveedor")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
