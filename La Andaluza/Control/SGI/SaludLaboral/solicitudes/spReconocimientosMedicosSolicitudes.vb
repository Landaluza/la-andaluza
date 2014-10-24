Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spReconocimientosMedicosSolicitudes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ReconocimientosMedicosSolicitudesSelect]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesInsert]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesUpdate]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesDelete]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesSelectDgv]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ReconocimientoMedicoSolicitudID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ReconocimientosMedicosSolicitudes
        Dim dbo As New DBO_ReconocimientosMedicosSolicitudes
        dbo.searchKey = dbo.item("ReconocimientoMedicoSolicitudID")
        dbo.searchKey.value = ReconocimientoMedicoSolicitudID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ReconocimientoMedicoSolicitudID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ReconocimientosMedicosSolicitudes
        dbo.searchKey = dbo.item("ReconocimientoMedicoSolicitudID")
        dbo.searchKey.value = ReconocimientoMedicoSolicitudID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_ReconocimientosMedicosSolicitudes(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("ReconocimientosMedicosSolicitudesSelectCbo", False, dtb)
    End Sub

End Class
