Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spcabecerasEtiquetas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[cabecerasEtiquetasSelect]", _
                      "[dbo].[cabecerasEtiquetasInsert]", _
                      "[dbo].[cabecerasEtiquetasUpdate]", _
                      "[dbo].[cabecerasEtiquetasDelete]", _
                      "[dbo].[cabecerasEtiquetasSelectDgv]", _
                      "[dbo].[cabecerasEtiquetasSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_cabecerasEtiquetas
        Dim dbo As New DBO_cabecerasEtiquetas
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_cabecerasEtiquetas
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
    End Function

    Public Sub cargar_cabecerasEtiquetas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("cabecerasEtiquetasCbo", False, dtb)
    End Sub

End Class
