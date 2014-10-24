Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposPendientesSelect]", _
                      "[dbo].[TiposPendientesInsert]", _
                      "[dbo].[TiposPendientesUpdate]", _
                      "[dbo].[TiposPendientesDelete]", _
                      "[dbo].[TiposPendientesSelectDgv]", _
                      "[dbo].[TiposPendientesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposPendientes
        Dim dbo As New DBO_TiposPendientes
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposPendientes
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_TiposPendientes(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposPendientesCbo", False, dtb)
    End Sub

End Class
