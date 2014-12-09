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

    Public Overloads Function Select_Record(ByVal CategoriaIncidenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CategoriaIncidencias
        Dim dbo As New DBO_CategoriaIncidencias
        dbo.searchKey = dbo.item("CategoriaIncidenciaID")
        dbo.searchKey.value = CategoriaIncidenciaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal CategoriaIncidenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_CategoriaIncidencias
        dbo.searchKey = dbo.item("CategoriaIncidenciaID")
        dbo.searchKey.value = CategoriaIncidenciaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_CategoriaIncidencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("CategoriaIncidenciasCbo", False, dtb)
    End Sub

    Public Sub cargar_CategoriaIncidencias_con_retroCompatibilidad(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("CategoriaIncidenciasCbo_OLD", False, dtb)
    End Sub
    'Function select_cagtegoria_por_tipoIncidencia(ByVal tipo As Integer) As Object
    '    Return dtb.Consultar(String.Empty, False).Rows(0).Item(0)
    'End Function


End Class
