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

    Public Overloads Function Select_Record(ByVal PaletMovimientoTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsMovimientosTipos
        Dim dbo As New DBO_PaletsMovimientosTipos
        dbo.searchKey = dbo.item("PaletMovimientoTipoID")
        dbo.searchKey.value = PaletMovimientoTipoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PaletMovimientoTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PaletsMovimientosTipos
        dbo.searchKey = dbo.item("PaletMovimientoTipoID")
        dbo.searchKey.value = PaletMovimientoTipoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_PaletsMovimientosTipos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PaletsMovimientosTiposCbo", False, dtb)
    End Sub

End Class
