

Public Class spControlIncidencias_Clientes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidencias_ClientesSelect]",  _
                     "[dbo].[ControlIncidencias_ClientesInsert]",  _
                     "[dbo].[ControlIncidencias_ClientesUpdate]",  _
                     "[dbo].[ControlIncidencias_ClientesDelete]",  _
                     "[dbo].[ControlIncidencias_ClientesSelectDgv]",  _
                     "[dbo].[ControlIncidencias_ClientesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ControlIncidencias_Clientes
       Dim dbo As New DBO_ControlIncidencias_Clientes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ControlIncidencias_Clientes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
