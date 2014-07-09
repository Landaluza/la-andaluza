

Public Class spControlIncidencias_Empleados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidencias_EmpleadosSelect]",  _
                     "[dbo].[ControlIncidencias_EmpleadosInsert]",  _
                     "[dbo].[ControlIncidencias_EmpleadosUpdate]",  _
                     "[dbo].[ControlIncidencias_EmpleadosDelete]",  _
                     "[dbo].[ControlIncidencias_EmpleadosSelectDgv]",  _
                     "[dbo].[ControlIncidencias_EmpleadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ControlIncidencias_Empleados
       Dim dbo As New DBO_ControlIncidencias_Empleados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ControlIncidencias_Empleados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
