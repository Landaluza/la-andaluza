Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class spAlbaranesMaestros

    Public Function seleccionar_agencia_por_conductor(ByVal camion As Integer, dtb As BasesParaCompatibilidad.DataBase) As String
        dtb.PrepararConsulta("select camiones.AgenciaTransporteID, Nombre from Camiones, AgenciasTransportes where camiones.AgenciaTransporteID = AgenciasTransportes.AgenciaTransporteID and camionID = @id  order by CamionID ")
        dtb.AñadirParametroConsulta("@id", camion)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Public Function seleccionar_remolque_por_conductor(ByVal camion As Integer, dtb As BasesParaCompatibilidad.DataBase) As String
        dtb.PrepararConsulta("select MatriculaRemolque, MatriculaRemolque from Camiones where camionID = @id  order by CamionID ")
        dtb.AñadirParametroConsulta("@id", camion)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Public Sub seleccionar_cabeza_por_conductor(ByVal conductor As Integer, ByRef cbo As ComboBox, dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select camionID , MatriculaCabeza from Camiones where ConductorHabitualID = @id  order by CamionID ")
        dtb.AñadirParametroConsulta("@id", conductor)
        cbo.mam_DataSource(dtb.Consultar(), False)
    End Sub

    Public Sub cargar_agencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select AgenciaTransporteID, Nombre from AgenciasTransportes")
        cbo.mam_DataSource(dtb.Consultar(), False)
    End Sub
End Class
