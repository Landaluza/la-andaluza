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

   Public Overloads Function Select_Record(ByVal TipoMaterialID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposMateriales
       Dim dbo As New DBO_TiposMateriales
       dbo.searchKey = dbo.item("TipoMaterialID")
       dbo.searchKey.value = TipoMaterialID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal TipoMaterialID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TiposMateriales
       dbo.searchKey = dbo.item("TipoMaterialID")
       dbo.searchKey.value = TipoMaterialID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_TiposMateriales(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposMaterialesCbo", False)
   End Sub

End Class
