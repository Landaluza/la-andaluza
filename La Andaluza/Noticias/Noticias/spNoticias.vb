

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

    Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Noticias
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), trans)
    End Function

End Class
