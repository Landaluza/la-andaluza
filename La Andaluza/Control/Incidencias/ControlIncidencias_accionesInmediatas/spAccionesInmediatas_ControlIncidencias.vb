

Public Class spAccionesInmediatas_ControlIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AccionesInmediatas_ControlIncidenciasSelect]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasInsert]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasUpdate]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasDelete]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasSelectDgv]",  _
                     "[dbo].[AccionesInmediatas_ControlIncidenciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AccionesInmediatas_ControlIncidencias
        Dim dbo As New DBO_AccionesInmediatas_ControlIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AccionesInmediatas_ControlIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
