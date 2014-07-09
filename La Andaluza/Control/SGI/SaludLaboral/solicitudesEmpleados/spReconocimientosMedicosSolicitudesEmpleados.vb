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

   Public Overloads Function Select_Record(ByVal ReconocimientoMedicoSolicitudEmpleadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ReconocimientosMedicosSolicitudesEmpleados
       Dim dbo As New DBO_ReconocimientosMedicosSolicitudesEmpleados
       dbo.searchKey = dbo.item("ReconocimientoMedicoSolicitudEmpleadoID")
       dbo.searchKey.value = ReconocimientoMedicoSolicitudEmpleadoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ReconocimientoMedicoSolicitudEmpleadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ReconocimientosMedicosSolicitudesEmpleados
       dbo.searchKey = dbo.item("ReconocimientoMedicoSolicitudEmpleadoID")
       dbo.searchKey.value = ReconocimientoMedicoSolicitudEmpleadoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_combobox(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("ReconocimientosMedicosSolicitudesEmpleadosSelectCbo", False)
    End Sub

End Class
