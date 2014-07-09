Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spCategoriaIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CategoriaIncidenciasSelect]",  _
                     "[dbo].[CategoriaIncidenciasInsert]",  _
                     "[dbo].[CategoriaIncidenciasUpdate]",  _
                     "[dbo].[CategoriaIncidenciasDelete]",  _
                     "[dbo].[CategoriaIncidenciasSelectDgv]",  _
                     "[dbo].[CategoriaIncidenciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal CategoriaIncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_CategoriaIncidencias
       Dim dbo As New DBO_CategoriaIncidencias
       dbo.searchKey = dbo.item("CategoriaIncidenciaID")
       dbo.searchKey.value = CategoriaIncidenciaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal CategoriaIncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_CategoriaIncidencias
       dbo.searchKey = dbo.item("CategoriaIncidenciaID")
       dbo.searchKey.value = CategoriaIncidenciaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_CategoriaIncidencias(ByRef cbo As ComboBox)
       cbo.mam_DataSource("CategoriaIncidenciasCbo", False)
   End Sub

    Public Sub cargar_CategoriaIncidencias_con_retroCompatibilidad(ByRef cbo As ComboBox)
        cbo.mam_DataSource("CategoriaIncidenciasCbo_OLD", False)
    End Sub
    'Function select_cagtegoria_por_tipoIncidencia(ByVal tipo As Integer) As Object
    '    Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    '    Return dtb.Consultar(String.Empty, False).Rows(0).Item(0)
    'End Function


End Class
