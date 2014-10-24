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

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_OrigenesIncidencias
        Dim dbo As New DBO_OrigenesIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_OrigenesIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_OrigenesIncidencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("OrigenesIncidenciasCbo", False, dtb)
    End Sub

End Class
