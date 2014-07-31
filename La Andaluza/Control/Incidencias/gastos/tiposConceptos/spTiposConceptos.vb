Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spTiposConceptos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposConceptosSelect]",  _
                     "[dbo].[TiposConceptosInsert]",  _
                     "[dbo].[TiposConceptosUpdate]",  _
                     "[dbo].[TiposConceptosDelete]",  _
                     "[dbo].[TiposConceptosSelectDgv]",  _
                     "[dbo].[TiposConceptosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposConceptos
       Dim dbo As New DBO_TiposConceptos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposConceptos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

   Public Sub cargar_TiposConceptos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposConceptosCbo", False)
   End Sub

End Class
