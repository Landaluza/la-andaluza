Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposGravedadesIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposGravedadesIncidenciasSelect]",  _
                     "[dbo].[TiposGravedadesIncidenciasInsert]",  _
                     "[dbo].[TiposGravedadesIncidenciasUpdate]",  _
                     "[dbo].[TiposGravedadesIncidenciasDelete]",  _
                     "[dbo].[TiposGravedadesIncidenciasSelectDgv]",  _
                     "[dbo].[TiposGravedadesIncidenciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposGravedadesIncidencias
        Dim dbo As New DBO_TiposGravedadesIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposGravedadesIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposGravedadesIncidencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposGravedadesIncidenciasCbo", False, dtb)
    End Sub

End Class
