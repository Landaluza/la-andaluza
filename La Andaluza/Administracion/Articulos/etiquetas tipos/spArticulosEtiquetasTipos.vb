Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spArticulosEtiquetasTipos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosEtiquetasTiposSelect]", _
                      "[dbo].[ArticulosEtiquetasTiposInsert]", _
                      "[dbo].[ArticulosEtiquetasTiposUpdate]", _
                      "[dbo].[ArticulosEtiquetasTiposDelete]", _
                      "[dbo].[ArticulosEtiquetasTiposSelectDgv]", _
                      "[dbo].[ArticulosEtiquetasTiposSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal ArticuloEtiquetaTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosEtiquetasTipos
        Dim dbo As New DBO_ArticulosEtiquetasTipos
        dbo.searchKey = dbo.item("ArticuloEtiquetaTipoID")
        dbo.searchKey.value = ArticuloEtiquetaTipoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ArticuloEtiquetaTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ArticulosEtiquetasTipos
        dbo.searchKey = dbo.item("ArticuloEtiquetaTipoID")
        dbo.searchKey.value = ArticuloEtiquetaTipoID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_ArticulosEtiquetasTipos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ArticulosEtiquetasTiposCbo", False, dtb)
    End Sub

End Class
