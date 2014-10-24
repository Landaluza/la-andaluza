

Public Class spTareasEnvasado_LineasEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TareasEnvasado_LineasEnvasadoSelect]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoInsert]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoUpdate]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoDelete]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoSelectDgv]",  _
                     "[dbo].[TareasEnvasado_LineasEnvasadoSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TareasEnvasado_LineasEnvasado
        Dim dbo As New DBO_TareasEnvasado_LineasEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TareasEnvasado_LineasEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
