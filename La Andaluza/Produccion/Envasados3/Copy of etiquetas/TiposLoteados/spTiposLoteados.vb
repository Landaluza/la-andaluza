Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposLoteados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposLoteadosSelect]",  _
                     "[dbo].[TiposLoteadosInsert]",  _
                     "[dbo].[TiposLoteadosUpdate]",  _
                     "[dbo].[TiposLoteadosDelete]",  _
                     "[dbo].[TiposLoteadosSelectDgv]",  _
                     "[dbo].[TiposLoteadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposLoteados
       Dim dbo As New DBO_TiposLoteados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposLoteados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_TiposLoteados(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposLoteadosCbo", False)
   End Sub

End Class
