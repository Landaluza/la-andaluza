Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spConceptosGastosIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ConceptosGastosIncidenciasSelect]",  _
                     "[dbo].[ConceptosGastosIncidenciasInsert]",  _
                     "[dbo].[ConceptosGastosIncidenciasUpdate]",  _
                     "[dbo].[ConceptosGastosIncidenciasDelete]",  _
                     "[dbo].[ConceptosGastosIncidenciasSelectDgv]",  _
                     "[dbo].[ConceptosGastosIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ConceptosGastosIncidencias
       Dim dbo As New DBO_ConceptosGastosIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ConceptosGastosIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

   Public Sub cargar_ConceptosGastosIncidencias(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ConceptosGastosIncidenciasCbo", False)
   End Sub

End Class
