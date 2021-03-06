Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposSeguimientos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposSeguimientosSelect]",  _
                     "[dbo].[TiposSeguimientosInsert]",  _
                     "[dbo].[TiposSeguimientosUpdate]",  _
                     "[dbo].[TiposSeguimientosDelete]",  _
                     "[dbo].[TiposSeguimientosSelectDgv]",  _
                     "[dbo].[TiposSeguimientosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposSeguimientos
        Dim dbo As New DBO_TiposSeguimientos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposSeguimientos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposSeguimientos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposSeguimientosCbo", False, dtb)
    End Sub

End Class
