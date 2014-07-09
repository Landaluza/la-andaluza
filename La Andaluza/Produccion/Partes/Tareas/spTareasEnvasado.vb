Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTareasEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TareasEnvasadoSelect]",  _
                     "[dbo].[TareasEnvasadoInsert]",  _
                     "[dbo].[TareasEnvasadoUpdate]",  _
                     "[dbo].[TareasEnvasadoDelete]",  _
                     "[dbo].[TareasEnvasadoSelectDgv]",  _
                     "[dbo].[TareasEnvasadoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TareasEnvasado
       Dim dbo As New DBO_TareasEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TareasEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_TareasEnvasado(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TareasEnvasadoCbo", False)
   End Sub

End Class
