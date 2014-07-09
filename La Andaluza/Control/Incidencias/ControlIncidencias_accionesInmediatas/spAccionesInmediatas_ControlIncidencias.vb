

Public Class spAccionesInmediatas_ControlIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AccionesInmediatas_ControlIncidenciasSelect]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasInsert]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasUpdate]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasDelete]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasSelectDgv]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AccionesInmediatas_ControlIncidencias
       Dim dbo As New DBO_AccionesInmediatas_ControlIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AccionesInmediatas_ControlIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
