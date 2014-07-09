

Public Class spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadSelect]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadInsert]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadUpdate]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadDelete]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadSelectDgv]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
       Dim dbo As New DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
