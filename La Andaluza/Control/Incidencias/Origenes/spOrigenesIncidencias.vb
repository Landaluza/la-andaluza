Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spOrigenesIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[OrigenesIncidenciasSelect]",  _
                     "[dbo].[OrigenesIncidenciasInsert]",  _
                     "[dbo].[OrigenesIncidenciasUpdate]",  _
                     "[dbo].[OrigenesIncidenciasDelete]",  _
                     "[dbo].[OrigenesIncidenciasSelectDgv]",  _
                     "[dbo].[OrigenesIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_OrigenesIncidencias
       Dim dbo As New DBO_OrigenesIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_OrigenesIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_OrigenesIncidencias(ByRef cbo As ComboBox)
       cbo.mam_DataSource("OrigenesIncidenciasCbo", False)
   End Sub

End Class
