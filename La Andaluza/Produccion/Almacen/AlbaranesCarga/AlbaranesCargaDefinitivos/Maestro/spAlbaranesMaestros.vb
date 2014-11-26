Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class spAlbaranesMaestros

    Public Sub seleccionar_agencia_por_conductor(ByVal conductor As Integer, ByRef cbo As ComboBox, dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select camiones.AgenciaTransporteID, Nombre from Camiones, AgenciasTransportes where camiones.AgenciaTransporteID = AgenciasTransportes.AgenciaTransporteID and ConductorHabitualID = @id  order by CamionID ")
        dtb.AñadirParametroConsulta("@id", conductor)
        cbo.mam_DataSource(dtb.Consultar(), False)
    End Sub

    Public Sub seleccionar_remolque_por_conductor(ByVal conductor As Integer, ByRef cbo As ComboBox, dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select camiones.AgenciaTransporteID, Nombre from Camiones, AgenciasTransportes where camiones.AgenciaTransporteID = AgenciasTransportes.AgenciaTransporteID and ConductorHabitualID = @id  order by CamionID ")
        dtb.AñadirParametroConsulta("@id", conductor)
        cbo.mam_DataSource(dtb.Consultar(), False)
    End Sub

    Public Sub seleccionar_cabeza_por_conductor(ByVal conductor As Integer, ByRef cbo As ComboBox, dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select camiones.AgenciaTransporteID, Nombre from Camiones, AgenciasTransportes where camiones.AgenciaTransporteID = AgenciasTransportes.AgenciaTransporteID and ConductorHabitualID = @id  order by CamionID ")
        dtb.AñadirParametroConsulta("@id", conductor)
        cbo.mam_DataSource(dtb.Consultar(), False)
    End Sub
End Class
