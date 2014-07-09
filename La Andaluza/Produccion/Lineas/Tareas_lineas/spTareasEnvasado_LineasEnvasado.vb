

Public Class spTareasEnvasado_LineasEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TareasEnvasado_LineasEnvasadoSelect]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoInsert]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoUpdate]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoDelete]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoSelectDgv]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TareasEnvasado_LineasEnvasado
       Dim dbo As New DBO_TareasEnvasado_LineasEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TareasEnvasado_LineasEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
