

Public Class spControlIncidencias_Causas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidencias_CausasSelect]",  _
                     "[dbo].[ControlIncidencias_CausasInsert]",  _
                     "[dbo].[ControlIncidencias_CausasUpdate]",  _
                     "[dbo].[ControlIncidencias_CausasDelete]",  _
                     "[dbo].[ControlIncidencias_CausasSelectDgv]",  _
                     "[dbo].[ControlIncidencias_CausasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ControlIncidencias_Causas
       Dim dbo As New DBO_ControlIncidencias_Causas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ControlIncidencias_Causas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
