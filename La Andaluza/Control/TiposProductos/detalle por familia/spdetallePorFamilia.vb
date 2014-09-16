
Public Class spdetallePorFamilia
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[detallePorFamiliaSelect]",  _
                     "[dbo].[detallePorFamiliaInsert]",  _
                     "[dbo].[detallePorFamiliaUpdate]",  _
                     "[dbo].[detallePorFamiliaDelete]",  _
                     "[dbo].[detallePorFamiliaSelectDgv]",  _
                     "[dbo].[detallePorFamiliaSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_detallePorFamilia
       Dim dbo As New DBO_detallePorFamilia
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_detallePorFamilia
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

End Class
