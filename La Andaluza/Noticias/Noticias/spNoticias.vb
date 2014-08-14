

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
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.DataBussines), trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dbo As New DBO_Noticias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.DataBussines), trans)
    End Function

    Public Function CambiarVigencia(ByVal id As Integer) As Boolean
        Return Me.dtb.ConsultaAlteraciones("update noticias set vigente = CASE vigente WHEN 0 THEN 1 ELSE 0 END  where id=" & id)
    End Function
End Class
