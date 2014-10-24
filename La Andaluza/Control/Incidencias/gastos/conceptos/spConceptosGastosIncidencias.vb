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

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ConceptosGastosIncidencias
        Dim dbo As New DBO_ConceptosGastosIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ConceptosGastosIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

    Public Sub cargar_ConceptosGastosIncidencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ConceptosGastosIncidenciasCbo", False, dtb)
    End Sub

End Class
