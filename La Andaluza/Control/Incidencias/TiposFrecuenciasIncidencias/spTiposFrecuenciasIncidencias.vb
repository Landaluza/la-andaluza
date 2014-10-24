Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposFrecuenciasIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposFrecuenciasIncidenciasSelect]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasInsert]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasUpdate]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasDelete]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasSelectDgv]",  _
                     "[dbo].[TiposFrecuenciasIncidenciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposFrecuenciasIncidencias
        Dim dbo As New DBO_TiposFrecuenciasIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposFrecuenciasIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposFrecuenciasIncidencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposFrecuenciasIncidenciasCbo", False, dtb)
    End Sub

End Class
