Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTareasEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TareasEnvasadoSelect]",  _
                     "[dbo].[TareasEnvasadoInsert]",  _
                     "[dbo].[TareasEnvasadoUpdate]",  _
                     "[dbo].[TareasEnvasadoDelete]",  _
                     "[dbo].[TareasEnvasadoSelectDgv]",  _
                     "[dbo].[TareasEnvasadoSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TareasEnvasado
        Dim dbo As New DBO_TareasEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TareasEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TareasEnvasado(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TareasEnvasadoCbo", False, dtb)
    End Sub

End Class
