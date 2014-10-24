

Public Class spSegumientosIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[SegumientosIncidenciasSelect]",  _
                     "[dbo].[SegumientosIncidenciasInsert]",  _
                     "[dbo].[SegumientosIncidenciasUpdate]",  _
                     "[dbo].[SegumientosIncidenciasDelete]",  _
                     "[dbo].[SegumientosIncidenciasSelectDgv]",  _
                     "[dbo].[SegumientosIncidenciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_SegumientosIncidencias
        Dim dbo As New DBO_SegumientosIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_SegumientosIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
