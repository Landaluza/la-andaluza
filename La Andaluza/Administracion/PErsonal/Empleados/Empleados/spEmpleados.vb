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

    Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Empleados
        Dim dbo As New DBO_Empleados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_Empleados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

    Public Function devolver_empleados_inactivos() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("EmpleadosSelectDgvInactivos", True)
    End Function

    Public Sub cargar_Empleados(ByRef cbo As ComboBox)
        cbo.mam_DataSource("EmpleadosCbo", False)
    End Sub

    Sub cargar_Empleados_Analistas(cbo As ComboBox)
        cbo.mam_DataSource("EmpleadosAnalistasCbo", False)
    End Sub

    Function devolver_Empleados_Analistas() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("EmpleadosAnalistasCbo", True)
    End Function

    Function devolver_Empleados_Catadores() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("EmpleadosCatadoresCbo", True)
    End Function

    Public Sub cargar_empleados_por_linea(ByRef cbo As ComboBox, ByVal linea As Integer)
        cbo.mam_DataSource("EmpleadosPorLineaCbo " & linea, False)
    End Sub

    Public Function devolver_empleados_por_linea(ByVal linea As Integer) As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("EmpleadosPorLineaCbo @linea")
        dtb.AñadirParametroConsulta("@linea", linea)
        Return dtb.Consultar()
    End Function

    Public Function devolver_empleados_por_linea_libres(ByVal linea As Integer) As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("EmpleadosPorLineaLibresCbo @linea")
        dtb.AñadirParametroConsulta("@linea", linea)
        Return dtb.Consultar
    End Function

    Public Function devolver_Empleados_Envasados_ocupados(ByVal envasado As Integer) As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("EmpleadosEnvasados_Situacion_Ocupados @envasado")
        dtb.AñadirParametroConsulta("@envasado", envasado)
        Return dtb.Consultar
    End Function

    Public Function devolver_Empleados_Envasados_ocupados_por_linea(ByVal linea As Integer, ByVal envasado As Integer) As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("EmpleadosEnvasados_Situacion_Ocupados_por_linea @linea, @envasado")
        dtb.AñadirParametroConsulta("@linea", linea)
        dtb.AñadirParametroConsulta("@envasado", envasado)
        Return dtb.Consultar
    End Function

    Public Function devolver_Empleados_Envasados_Situacion_Actual() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec EmpleadosEnvasados_SituacionEnLinea", False)
    End Function

    Public Sub cargar_empleados_envasados(ByRef cbo As ComboBox)
        cbo.mam_DataSource("EmpleadosEnvasados", False)
    End Sub

    Function devolver_Empleados_Envasados() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec EmpleadosEnvasados", False)
    End Function

    Function devolver_Empleados_Envasados_libres() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec EmpleadosEnvasadosSinOcupacion", False)
    End Function

    Sub cargar_Empleados_Envasados_libres(ByRef cbo As ComboBox)
        cbo.mam_DataSource("exec EmpleadosEnvasadosSinOcupacion", False)
    End Sub

    Public Sub cargar_empleados_por_perfil(ByRef cbo As ComboBox, ByVal tipoUsuario As Integer)
        cbo.mam_DataSource("EmpleadosPorTipoUsuario " & tipoUsuario, False)
    End Sub

    Public Sub cargar_empleados_por_perfil(ByRef cbo As ComboBox, ByVal tipoUsuario As Integer, ByVal tipoUsuario2 As Integer)
        cbo.mam_DataSource("EmpleadosPorTipoUsuario2 " & tipoUsuario & ", " & tipoUsuario2, False)
    End Sub

    Public Function devolver_linea_envasado_por_empleado(ByVal id_empleado As Integer) As Integer
        Try
            Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
            dtb.PrepararConsulta("select id_lineaEnvasado from empleados_lineasEnvasado where Id_empleado = @id")
            dtb.AñadirParametroConsulta("@id", id_empleado)
            Dim linea As Integer = dtb.Consultar().Rows(0).Item(0)
            Return if(IsDBNull(linea), 1, linea)
        Catch ex As Exception
            Return 1
        End Try

    End Function

    Sub cargar_Empleados_usuarios(ByRef cbo As ComboBox)
        cbo.mam_DataSource("EmpleadosyUsuariosSelectCbo", False)
    End Sub

    Function devolver_Empleados_actuales_del_formato(ByVal formatoEnvasadoId As Integer) As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("EmpleadosActualesPorFormatoEnvasado @formato")
        dtb.AñadirParametroConsulta("@formato", formatoEnvasadoId)
        Return dtb.Consultar
    End Function

    Function devolver_empleados_con_turnos_sin_fin() As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec EmpleadosEnvasados_TurnosSinFinalizar", False)
    End Function
End Class
