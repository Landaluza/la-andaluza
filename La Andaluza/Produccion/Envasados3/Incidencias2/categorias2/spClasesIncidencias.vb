Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spClasesIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ClasesIncidenciasSelect]",  _
                     "[dbo].[ClasesIncidenciasInsert]",  _
                     "[dbo].[ClasesIncidenciasUpdate]",  _
                     "[dbo].[ClasesIncidenciasDelete]",  _
                     "[dbo].[ClasesIncidenciasSelectDgv]",  _
                     "[dbo].[ClasesIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ClaseIncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ClasesIncidencias
       Dim dbo As New DBO_ClasesIncidencias
       dbo.searchKey = dbo.item("ClaseIncidenciaID")
       dbo.searchKey.value = ClaseIncidenciaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ClaseIncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ClasesIncidencias
       dbo.searchKey = dbo.item("ClaseIncidenciaID")
       dbo.searchKey.value = ClaseIncidenciaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ClasesIncidencias(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ClasesIncidenciasCbo", False)
   End Sub

    Sub cargar_ClasesIncidencias_por_categoria(ByRef cbo As ComboBox, ByVal categoria As Integer)
        cbo.mam_DataSource("ClasesIncidenciasCboByCategoria " & categoria, False)
    End Sub

End Class
