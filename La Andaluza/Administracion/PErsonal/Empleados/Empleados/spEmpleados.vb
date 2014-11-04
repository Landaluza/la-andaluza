Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spEmpleados
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[EmpleadosSelect]", _
                        "[dbo].[EmpleadosInsert]", _
                        "[dbo].[EmpleadosUpdate]", _
                        "[dbo].[EmpleadosDelete]", _
                        "[dbo].[EmpleadosSelectDgv]", _
                        "[dbo].[EmpleadosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Empleados
        Dim dbo As New DBO_Empleados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Empleados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Function devolver_empleados_inactivos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosSelectDgvInactivos")
        Return dtb.Consultar()
    End Function

    Public Sub cargar_Empleados(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EmpleadosCbo", False, dtb)
    End Sub

    Sub cargar_Empleados_Analistas(cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.database)
        cbo.mam_DataSource("EmpleadosAnalistasCbo", False, dtb)
    End Sub

    Function devolver_Empleados_Analistas(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosAnalistasCbo")
        Return dtb.Consultar()
    End Function

    Function devolver_Empleados_Catadores(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosCatadoresCbo")
        Return dtb.Consultar()
    End Function

    Public Sub cargar_empleados_por_linea(ByRef cbo As ComboBox, ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EmpleadosPorLineaCbo " & linea, False, dtb)
    End Sub

    Public Function devolver_empleados_por_linea(ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosPorLineaCbo @linea")
        dtb.AñadirParametroConsulta("@linea", linea)
        Return dtb.Consultar()
    End Function

    Public Function devolver_empleados_por_linea_libres(ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosPorLineaLibresCbo @linea")
        dtb.AñadirParametroConsulta("@linea", linea)
        Return dtb.Consultar
    End Function

    Public Function devolver_Empleados_Envasados_ocupados(ByVal envasado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosEnvasados_Situacion_Ocupados @envasado")
        dtb.AñadirParametroConsulta("@envasado", envasado)
        Return dtb.Consultar
    End Function

    Public Function devolver_Empleados_Envasados_ocupados_por_linea(ByVal linea As Integer, ByVal envasado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosEnvasados_Situacion_Ocupados_por_linea @linea, @envasado")
        dtb.AñadirParametroConsulta("@linea", linea)
        dtb.AñadirParametroConsulta("@envasado", envasado)
        Return dtb.Consultar
    End Function

    Public Function devolver_Empleados_Envasados_Situacion_Actual(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosEnvasados_SituacionEnLinea")
        Return dtb.Consultar()
    End Function

    Public Sub cargar_empleados_envasados(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EmpleadosEnvasados", False, dtb)
    End Sub

    Function devolver_Empleados_Envasados(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosEnvasados")
        Return dtb.Consultar()
    End Function

    Function devolver_Empleados_Envasados_libres(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosEnvasadosSinOcupacion")
        Return dtb.Consultar()
    End Function

    Sub cargar_Empleados_Envasados_libres(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EmpleadosEnvasadosSinOcupacion", True, dtb)
    End Sub

    Public Sub cargar_empleados_por_perfil(ByRef cbo As ComboBox, ByVal tipoUsuario As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EmpleadosPorTipoUsuario " & tipoUsuario, True, dtb)
    End Sub

    Public Sub cargar_empleados_por_perfil(ByRef cbo As ComboBox, ByVal tipoUsuario As Integer, ByVal tipoUsuario2 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EmpleadosPorTipoUsuario2 " & tipoUsuario & ", " & tipoUsuario2, True, dtb)
    End Sub

    Public Function devolver_linea_envasado_por_empleado(ByVal id_empleado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.PrepararConsulta("select id_lineaEnvasado from empleados_lineasEnvasado where Id_empleado = @id")
            dtb.AñadirParametroConsulta("@id", id_empleado)
            Dim linea As Integer = dtb.Consultar().Rows(0).Item(0)
            Return If(IsDBNull(linea), 1, linea)
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Sub cargar_Empleados_usuarios(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("EmpleadosyUsuariosSelectCbo", False, dtb)
    End Sub

    Function devolver_Empleados_actuales_del_formato(ByVal formatoEnvasadoId As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosActualesPorFormatoEnvasado @formato")
        dtb.AñadirParametroConsulta("@formato", formatoEnvasadoId)
        Return dtb.Consultar
    End Function

    Function devolver_empleados_con_turnos_sin_fin(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("EmpleadosEnvasados_TurnosSinFinalizar")
        Return dtb.Consultar()
    End Function
End Class
