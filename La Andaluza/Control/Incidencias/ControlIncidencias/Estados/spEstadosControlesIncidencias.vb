Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spEstadosControlesIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[EstadosControlesIncidenciasSelect]",  _
                     "[dbo].[EstadosControlesIncidenciasInsert]",  _
                     "[dbo].[EstadosControlesIncidenciasUpdate]",  _
                     "[dbo].[EstadosControlesIncidenciasDelete]",  _
                     "[dbo].[EstadosControlesIncidenciasSelectDgv]",  _
                     "[dbo].[EstadosControlesIncidenciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_EstadosControlesIncidencias
        Dim dbo As New DBO_EstadosControlesIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_EstadosControlesIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_estados(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EstadosControlesIncidenciasCbo", False, dtb)
    End Sub
End Class
