Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spIdiomas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[IdiomasSelect]",  _
                     "[dbo].[IdiomasInsert]",  _
                     "[dbo].[IdiomasUpdate]",  _
                     "[dbo].[IdiomasDelete]",  _
                     "[dbo].[IdiomasSelectDgv]",  _
                     "[dbo].[IdiomasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal IdiomaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Idiomas
       Dim dbo As New DBO_Idiomas
       dbo.searchKey = dbo.item("IdiomaID")
       dbo.searchKey.value = IdiomaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal IdiomaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Idiomas
       dbo.searchKey = dbo.item("IdiomaID")
       dbo.searchKey.value = IdiomaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Idiomas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("IdiomasCbo", False)
   End Sub

End Class
