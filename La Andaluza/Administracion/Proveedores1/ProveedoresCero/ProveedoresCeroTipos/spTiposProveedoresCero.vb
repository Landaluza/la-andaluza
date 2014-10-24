Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposProveedoresCero
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposProveedoresCeroSelect]", "[dbo].[TiposProveedoresCeroInsert]", "[dbo].[TiposProveedoresCeroUpdate]", "[dbo].[TiposProveedoresCeroDelete]", "[dbo].[TiposProveedoresCeroSelectDgv]", "[dbo].[TiposProveedoresCeroSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposProveedoresCero
        Dim dbo As New DBO_TiposProveedoresCero
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposProveedoresCero
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposProveedoresCeroCbo", False, dtb)
    End Sub

End Class
