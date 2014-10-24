

Public Class spControlIncidencias_Proveedores
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidencias_ProveedoresSelect]",  _
                     "[dbo].[ControlIncidencias_ProveedoresInsert]",  _
                     "[dbo].[ControlIncidencias_ProveedoresUpdate]",  _
                     "[dbo].[ControlIncidencias_ProveedoresDelete]",  _
                     "[dbo].[ControlIncidencias_ProveedoresSelectDgv]",  _
                     "[dbo].[ControlIncidencias_ProveedoresSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ControlIncidencias_Proveedores
        Dim dbo As New DBO_ControlIncidencias_Proveedores
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ControlIncidencias_Proveedores
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
