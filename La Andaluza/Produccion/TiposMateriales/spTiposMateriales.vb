Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposMateriales
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposMaterialesSelect]",  _
                     "[dbo].[TiposMaterialesInsert]",  _
                     "[dbo].[TiposMaterialesUpdate]",  _
                     "[dbo].[TiposMaterialesDelete]",  _
                     "[dbo].[TiposMaterialesSelectDgv]",  _
                     "[dbo].[TiposMaterialesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal TipoMaterialID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposMateriales
        Dim dbo As New DBO_TiposMateriales
        dbo.searchKey = dbo.item("TipoMaterialID")
        dbo.searchKey.value = TipoMaterialID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoMaterialID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposMateriales
        dbo.searchKey = dbo.item("TipoMaterialID")
        dbo.searchKey.value = TipoMaterialID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposMateriales(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposMaterialesCbo", False, dtb)
    End Sub

End Class
