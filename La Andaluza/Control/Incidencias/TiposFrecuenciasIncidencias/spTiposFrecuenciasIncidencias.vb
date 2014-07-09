Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposFrecuenciasIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposFrecuenciasIncidenciasSelect]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasInsert]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasUpdate]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasDelete]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasSelectDgv]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposFrecuenciasIncidencias
       Dim dbo As New DBO_TiposFrecuenciasIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TiposFrecuenciasIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_TiposFrecuenciasIncidencias(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposFrecuenciasIncidenciasCbo", False)
   End Sub

End Class
