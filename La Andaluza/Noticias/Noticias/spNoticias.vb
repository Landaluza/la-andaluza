

Public Class spNoticias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[NoticiasSelect]",  _
                     "[dbo].[NoticiasInsert]",  _
                     "[dbo].[NoticiasUpdate]",  _
                     "[dbo].[NoticiasDelete]",  _
                     "[dbo].[NoticiasSelectDgv]",  _
                     "[dbo].[NoticiasSelectDgvBy]")
   End Sub


    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Noticias
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
    End Function

    Public Function CambiarVigencia(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update noticias set vigente = CASE vigente WHEN 0 THEN 1 ELSE 0 END  where id= @id")
        dtb.AñadirParametroConsulta("@id", id)
        Return dtb.Execute
    End Function
End Class
