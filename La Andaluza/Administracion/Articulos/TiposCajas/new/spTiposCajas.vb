Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposCajas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposCajasSelect]", _
                      "[dbo].[TiposCajasInsert]", _
                      "[dbo].[TiposCajasUpdate]", _
                      "[dbo].[TiposCajasDelete]", _
                      "[dbo].[TiposCajasSelectDgv]", _
                      "[dbo].[TiposCajasSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal TipoCajaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposCajas
        Dim dbo As New DBO_TiposCajas
        dbo.searchKey = dbo.item("TipoCajaID")
        dbo.searchKey.value = TipoCajaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoCajaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposCajas
        dbo.searchKey = dbo.item("TipoCajaID")
        dbo.searchKey.value = TipoCajaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_TiposCajas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposCajasCbo", False, dtb)
    End Sub

End Class
