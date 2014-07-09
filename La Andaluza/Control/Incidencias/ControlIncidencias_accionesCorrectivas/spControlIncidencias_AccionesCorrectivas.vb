

Public Class spControlIncidencias_AccionesCorrectivas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlIncidencias_AccionesCorrectivasSelect]",  _
                     "[dbo].[ControlIncidencias_AccionesCorrectivasInsert]",  _
                     "[dbo].[ControlIncidencias_AccionesCorrectivasUpdate]",  _
                     "[dbo].[ControlIncidencias_AccionesCorrectivasDelete]",  _
                     "[dbo].[ControlIncidencias_AccionesCorrectivasSelectDgv]",  _
                     "[dbo].[ControlIncidencias_AccionesCorrectivasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ControlIncidencias_AccionesCorrectivas
       Dim dbo As New DBO_ControlIncidencias_AccionesCorrectivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ControlIncidencias_AccionesCorrectivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
