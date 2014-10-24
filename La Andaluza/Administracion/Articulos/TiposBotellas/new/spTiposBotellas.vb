Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposBotellas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposBotellasSelect]", _
                      "[dbo].[TiposBotellasInsert]", _
                      "[dbo].[TiposBotellasUpdate]", _
                      "[dbo].[TiposBotellasDelete]", _
                      "[dbo].[TiposBotellasSelectDgv]", _
                      "[dbo].[TiposBotellasSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal TipoBotellaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposBotellas
        Dim dbo As New DBO_TiposBotellas
        dbo.searchKey = dbo.item("TipoBotellaID")
        dbo.searchKey.value = TipoBotellaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoBotellaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposBotellas
        dbo.searchKey = dbo.item("TipoBotellaID")
        dbo.searchKey.value = TipoBotellaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_TiposBotellas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposBotellasCbo", False, dtb)
    End Sub
End Class
