Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposReuniones
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposReunionesSelect]", "[dbo].[TiposReunionesInsert]", "[dbo].[TiposReunionesUpdate]", "[dbo].[TiposReunionesDelete]", "[dbo].[TiposReunionesSelectDgv]", "[dbo].[TiposReunionesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposReuniones
       Dim dbo As New DBO_TiposReuniones
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TiposReuniones
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ComboBox(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposReunionesSelectCbo", False)
   End Sub

End Class
