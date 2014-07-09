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

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_EstadosControlesIncidencias
       Dim dbo As New DBO_EstadosControlesIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_EstadosControlesIncidencias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Public Sub cargar_estados(ByRef cbo As ComboBox)
        cbo.mam_DataSource("EstadosControlesIncidenciasCbo", False)
    End Sub
End Class
