Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPaletsMovimientosTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PaletsMovimientosTiposSelect]",  _
                     "[dbo].[PaletsMovimientosTiposInsert]",  _
                     "[dbo].[PaletsMovimientosTiposUpdate]",  _
                     "[dbo].[PaletsMovimientosTiposDelete]",  _
                     "[dbo].[PaletsMovimientosTiposSelectDgv]",  _
                     "[dbo].[PaletsMovimientosTiposSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal PaletMovimientoTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_PaletsMovimientosTipos
       Dim dbo As New DBO_PaletsMovimientosTipos
       dbo.searchKey = dbo.item("PaletMovimientoTipoID")
       dbo.searchKey.value = PaletMovimientoTipoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PaletMovimientoTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_PaletsMovimientosTipos
       dbo.searchKey = dbo.item("PaletMovimientoTipoID")
       dbo.searchKey.value = PaletMovimientoTipoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_PaletsMovimientosTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PaletsMovimientosTiposCbo", False)
   End Sub

End Class
