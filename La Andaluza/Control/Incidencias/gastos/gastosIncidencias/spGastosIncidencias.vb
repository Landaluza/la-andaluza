
Public Class spGastosIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[GastosIncidenciasSelect]",  _
                     "[dbo].[GastosIncidenciasInsert]",  _
                     "[dbo].[GastosIncidenciasUpdate]",  _
                     "[dbo].[GastosIncidenciasDelete]",  _
                     "[dbo].[GastosIncidenciasSelectDgv]",  _
                     "[dbo].[GastosIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_GastosIncidencias
       Dim dbo As New DBO_GastosIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_GastosIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

End Class
