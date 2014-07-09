Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPaletsTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PaletsTiposSelect]",  _
                     "[dbo].[PaletsTiposInsert]",  _
                     "[dbo].[PaletsTiposUpdate]",  _
                     "[dbo].[PaletsTiposDelete]",  _
                     "[dbo].[PaletsTiposSelectDgv]",  _
                     "[dbo].[PaletsTiposSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal PaletTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PaletsTipos
       Dim dbo As New DBO_PaletsTipos
       dbo.searchKey = dbo.item("PaletTipoID")
       dbo.searchKey.value = PaletTipoID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PaletTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_PaletsTipos
       dbo.searchKey = dbo.item("PaletTipoID")
       dbo.searchKey.value = PaletTipoID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_PaletsTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PaletsTiposCbo", False)
   End Sub

End Class
