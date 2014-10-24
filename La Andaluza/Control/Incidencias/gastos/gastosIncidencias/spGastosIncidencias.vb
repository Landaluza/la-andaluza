
Public Class spGastosIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[GastosIncidenciasSelect]",  _
                     "[dbo].[GastosIncidenciasInsert]",  _
                     "[dbo].[GastosIncidenciasUpdate]",  _
                     "[dbo].[GastosIncidenciasDelete]",  _
                     "[dbo].[GastosIncidenciasSelectDgv]",  _
                     "[dbo].[GastosIncidenciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_GastosIncidencias
        Dim dbo As New DBO_GastosIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_GastosIncidencias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

End Class
