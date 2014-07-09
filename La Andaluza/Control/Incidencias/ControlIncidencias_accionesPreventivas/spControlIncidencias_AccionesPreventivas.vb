

Public Class spControlIncidencias_AccionesPreventivas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidencias_AccionesPreventivasSelect]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasInsert]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasUpdate]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasDelete]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasSelectDgv]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ControlIncidencias_AccionesPreventivas
       Dim dbo As New DBO_ControlIncidencias_AccionesPreventivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ControlIncidencias_AccionesPreventivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
