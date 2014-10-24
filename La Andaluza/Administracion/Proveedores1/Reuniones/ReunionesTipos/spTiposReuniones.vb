Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposReuniones
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposReunionesSelect]", "[dbo].[TiposReunionesInsert]", "[dbo].[TiposReunionesUpdate]", "[dbo].[TiposReunionesDelete]", "[dbo].[TiposReunionesSelectDgv]", "[dbo].[TiposReunionesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposReuniones
        Dim dbo As New DBO_TiposReuniones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposReuniones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposReunionesSelectCbo", False, dtb)
    End Sub

End Class
