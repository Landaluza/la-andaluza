

Public Class spSegumientosIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[SegumientosIncidenciasSelect]",  _
                     "[dbo].[SegumientosIncidenciasInsert]",  _
                     "[dbo].[SegumientosIncidenciasUpdate]",  _
                     "[dbo].[SegumientosIncidenciasDelete]",  _
                     "[dbo].[SegumientosIncidenciasSelectDgv]",  _
                     "[dbo].[SegumientosIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_SegumientosIncidencias
       Dim dbo As New DBO_SegumientosIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_SegumientosIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
