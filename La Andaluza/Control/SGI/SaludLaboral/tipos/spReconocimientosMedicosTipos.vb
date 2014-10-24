Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spReconocimientosMedicosTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ReconocimientosMedicosTiposSelect]",  _
                     "[dbo].[ReconocimientosMedicosTiposInsert]",  _
                     "[dbo].[ReconocimientosMedicosTiposUpdate]",  _
                     "[dbo].[ReconocimientosMedicosTiposDelete]",  _
                     "[dbo].[ReconocimientosMedicosTiposSelectDgv]",  _
                     "[dbo].[ReconocimientosMedicosTiposSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ReconocimientoMedicoTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ReconocimientosMedicosTipos
        Dim dbo As New DBO_ReconocimientosMedicosTipos
        dbo.searchKey = dbo.item("ReconocimientoMedicoTipoID")
        dbo.searchKey.value = ReconocimientoMedicoTipoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ReconocimientoMedicoTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ReconocimientosMedicosTipos
        dbo.searchKey = dbo.item("ReconocimientoMedicoTipoID")
        dbo.searchKey.value = ReconocimientoMedicoTipoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ReconocimientosMedicosTipos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ReconocimientosMedicosTiposCbo", False, dtb)
    End Sub

End Class
