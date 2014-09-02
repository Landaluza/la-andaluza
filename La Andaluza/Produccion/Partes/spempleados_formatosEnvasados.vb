Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spempleados_formatosEnvasados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
        MyBase.New("[dbo].[empleados_formatosEnvasadosSelect]", _
                   "[dbo].[empleados_formatosEnvasadosInsert]", _
                   "[dbo].[empleados_formatosEnvasadosUpdate]", _
                   "[dbo].[empleados_formatosEnvasadosDelete]", _
                   "[dbo].[empleados_formatosEnvasadosSelectDgv]", _
                   "[dbo].[empleados_formatosEnvasadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_empleados_formatosEnvasados
       Dim dbo As New DBO_empleados_formatosEnvasados
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_empleados_formatosEnvasados
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Function EstaDesdoblado(m_DBO_empleados_formatosEnvasados As DBO_empleados_formatosEnvasados, ByVal EnvasadoID As Integer, ByVal id As Integer) As Boolean
        Dim retorno As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        dtb.Conectar()
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[Empleados_formatosEnvasados_ValidarRangoHorario]")

        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@Id_Empleado", m_DBO_empleados_formatosEnvasados.id_empleado)
        selectCommand.Parameters.AddWithValue("@HoraInicio", m_DBO_empleados_formatosEnvasados.Inicio)
        selectCommand.Parameters.AddWithValue("@HoraFin", if(m_DBO_empleados_formatosEnvasados.is_null_Fin, m_DBO_empleados_formatosEnvasados.Inicio, m_DBO_empleados_formatosEnvasados.Fin))
        selectCommand.Parameters.AddWithValue("@Envasado", EnvasadoID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            Dim encontro As Boolean = False
            If reader.Read Then
                Dim cuenta As Integer = Convert.ToInt32(reader("cuenta"))
                If cuenta > if(id <> 0, 1, 0) Then
                    retorno = True
                Else
                    retorno = False
                End If
            Else
                retorno = True
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            retorno = True
        Finally
           dtb.Conectar()
        End Try

        Return retorno
    End Function

    Public Sub cargar_empleados_formatosEnvasadosByFormatoEnvasado(ByRef comboBox As ComboBox, ByVal id_formatoEnvasado As Integer)
        comboBox.mam_DataSource("empleados_formatosEnvasadosCboBy " & id_formatoEnvasado, False)
    End Sub

    Public Sub cargar_empleados_formatosEnvasados(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("empleados_formatosEnvasadosCbo", False)
    End Sub

    Public Function seleccionarUltimoRegistro(Optional ByVal cnn as System.Data.SqlClient.SqlConnection = Nothing, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server, cnn, trans)
        Return dtb.Consultar("select max(id) from Empleados_formatosEnvasados", False).Rows(0).Item(0)
    End Function

    Public Function es_parte_envasado(ByVal id As Integer) As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("select count(*) from partesEnvasados_causasPArtesEnvasado where id = @id and id_causaPArteEnvasado <>2")
        dtb.AñadirParametroConsulta("@id", id)

        If dtb.Consultar().Rows(0).Item(0) = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function numero_de_empleados_por_formato(ByVal formatoEnvasadoid As Integer) As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("select count(*) from empleados_formatosEnvasados where id_formatoEnvasado= @id")
        dtb.AñadirParametroConsulta("@id", formatoEnvasadoid)

        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Public Function actualizar_hora_fin(ByRef dbo As DBO_empleados_formatosEnvasados, Optional ByRef cnn As SqlClient.SqlConnection = Nothing, Optional ByRef trans As SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, cnn, trans)
        Return dtb.ConsultaAlteraciones("update empleados_formatosEnvasados set fin='" & dbo.Fin.Value.ToString & "' where id_empleado=" & dbo.id_empleado & " and id_formatoEnvasado=" & dbo.id_formatoEnvasado & " and fin is null")
    End Function

    Public Function hay_empleados_pendientes(ByVal envasadoID As Integer, ByVal LineaID As Integer) As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("empleados_formatosEnvasadosCountPendientes @env, @linea")
        dtb.AñadirParametroConsulta("@env", envasadoID)
        dtb.AñadirParametroConsulta("@linea", LineaID)
        If dtb.Consultar().Rows(0).Item(0) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function hay_empleados_pendientes_dias_anteriores(ByVal LineaID As Integer) As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("empleados_formatosEnvasadosCountPendientesAnteriores @linea")
        dtb.AñadirParametroConsulta("@linea", LineaID)

        If dtb.Consultar().Rows(0).Item(0) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function empleados_pendientes(ByVal envasadoID As Integer, ByVal LineaID As Integer) As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("empleados_formatosEnvasadosPendientes @env, @linea")
        dtb.AñadirParametroConsulta("@env", envasadoID)
        dtb.AñadirParametroConsulta("@linea", LineaID)
        Return dtb.Consultar()
    End Function

    Function recuperar_envasado_empleados_pendientes_dias_anteriores(ByVal LineaID As Integer) As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("empleados_formatosEnvasadosEnvasadosPendientesAnteriores @linea")
        dtb.AñadirParametroConsulta("@linea", LineaID)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

End Class
