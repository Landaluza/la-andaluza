Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spReconocimientosMedicosSolicitudesEmpleados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ReconocimientosMedicosSolicitudesEmpleadosSelect]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesEmpleadosInsert]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesEmpleadosUpdate]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesEmpleadosDelete]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesEmpleadosSelectDgv]",  _
                     "[dbo].[ReconocimientosMedicosSolicitudesEmpleadosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ReconocimientoMedicoSolicitudEmpleadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ReconocimientosMedicosSolicitudesEmpleados
        Dim dbo As New DBO_ReconocimientosMedicosSolicitudesEmpleados
        dbo.searchKey = dbo.item("ReconocimientoMedicoSolicitudEmpleadoID")
        dbo.searchKey.value = ReconocimientoMedicoSolicitudEmpleadoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ReconocimientoMedicoSolicitudEmpleadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ReconocimientosMedicosSolicitudesEmpleados
        dbo.searchKey = dbo.item("ReconocimientoMedicoSolicitudEmpleadoID")
        dbo.searchKey.value = ReconocimientoMedicoSolicitudEmpleadoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_combobox(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("ReconocimientosMedicosSolicitudesEmpleadosSelectCbo", False, dtb)
    End Sub

End Class
