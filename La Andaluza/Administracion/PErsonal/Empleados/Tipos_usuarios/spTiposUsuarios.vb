Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposUsuarios
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposUsuariosSelect]", _
                      "[dbo].[TiposUsuariosInsert]", _
                      "[dbo].[TiposUsuariosUpdate]", _
                      "[dbo].[TiposUsuariosDelete]", _
                      "[dbo].[TiposUsuariosSelectDgv]", _
                      "[dbo].[TiposUsuariosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal TipoUsuarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposUsuarios
        Dim dbo As New DBO_TiposUsuarios
        dbo.searchKey = dbo.item("TipoUsuarioID")
        dbo.searchKey.value = TipoUsuarioID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoUsuarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposUsuarios
        dbo.searchKey = dbo.item("TipoUsuarioID")
        dbo.searchKey.value = TipoUsuarioID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposUsuarios(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposUsuariosCbo", False, dtb)
    End Sub

End Class
