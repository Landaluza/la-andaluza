

Public Class spControlIncidencias_AccionesPreventivas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidencias_AccionesPreventivasSelect]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasInsert]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasUpdate]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasDelete]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasSelectDgv]",  _
                     "[dbo].[ControlIncidencias_AccionesPreventivasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ControlIncidencias_AccionesPreventivas
        Dim dbo As New DBO_ControlIncidencias_AccionesPreventivas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ControlIncidencias_AccionesPreventivas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
