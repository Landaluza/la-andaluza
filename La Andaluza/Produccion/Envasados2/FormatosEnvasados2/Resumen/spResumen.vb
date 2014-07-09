

Public Class spResumen
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("", "", "", "", "", "")
    End Sub

    Private sp_CalcularDetallesIncidencias As String = "FormatosEnvasados2resumenIncidencias"
    Private sp_CalcularTotalesTiempo As String = "FormatosEnvasados2resumenTiempos"
    Private sp_CalcularMediasEnvasado As String = "FormatosEnvasados2resumenMedias"
    Private sp_CalcularTotalesEnvasado As String = "FormatosEnvasados2resumenTotales"

    Public Function selectRecord(ByVal FormatoEnvasadoID As Integer) As DBO_ResumenFormatosEnvasados
        Dim m_dbo As DBO_ResumenFormatosEnvasados = New DBO_ResumenFormatosEnvasados

        m_dbo = DetallesIncidencias(m_dbo)
        m_dbo = MediasEnvasado(m_dbo)
        m_dbo = TotalesEnvasado(m_dbo)
        m_dbo = TotalesTiempo(m_dbo)

        Return m_dbo
    End Function

    Public Function DetallesIncidencias(ByVal m_dbo As DBO_ResumenFormatosEnvasados) As DBO_ResumenFormatosEnvasados
        Try
            BasesParaCompatibilidad.BD.Conectar()
            Dim dbo As DBO_ResumenFormatosEnvasados = New DBO_ResumenFormatosEnvasados
            Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
            Dim selectCommand As New System.Data.SqlClient.SqlCommand(sp_CalcularDetallesIncidencias, connection)
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@FormatoEnvasado", m_dbo.FormatoEnvasadoID)

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                dbo.TotalesIncidencias_CalidadMinutos = If(reader("CalidadMinutos") Is Convert.DBNull, 0, Convert.ToInt32(reader("CalidadMinutos")))
                dbo.TotalesIncidencias_CalidadNumero = If(reader("CalidadNumero") Is Convert.DBNull, 0, Convert.ToInt32(reader("CalidadNumero")))
                dbo.TotalesIncidencias_IntrinsicasMinutos = If(reader("IntrinsicasMinutos") Is Convert.DBNull, 0, Convert.ToInt32(reader("IntrinsicasMinutos")))
                dbo.TotalesIncidencias_IntrinsicasNumero = If(reader("IntrinsicasNumero") Is Convert.DBNull, 0, Convert.ToInt32(reader("IntrinsicasNumero")))
                dbo.TotalesIncidencias_MaquinaMinutos = If(reader("MaquinaMinutos") Is Convert.DBNull, 0, Convert.ToInt32(reader("MaquinaMinutos")))
                dbo.TotalesIncidencias_MaquinaNumero = If(reader("MaquinaNumero") Is Convert.DBNull, 0, Convert.ToInt32(reader("MaquinaNumero")))
                dbo.TotalesIncidencias_OtrosMinutos = If(reader("OtrosMinutos") Is Convert.DBNull, 0, Convert.ToInt32(reader("OtrosMinutos")))
                dbo.TotalesIncidencias_OtrosNumero = If(reader("OtrosNumero") Is Convert.DBNull, 0, Convert.ToInt32(reader("OtrosNumero")))
                dbo.TotalesIncidencias_RecuperablesMinutos = If(reader("RecuperablesMinutos") Is Convert.DBNull, 0, Convert.ToInt32(reader("RecuperablesMinutos")))
                dbo.TotalesIncidencias_RecuperablesNumero = If(reader("RecuperablesNumero") Is Convert.DBNull, 0, Convert.ToInt32(reader("RecuperablesNumero")))
                dbo.TotalesIncidencias_TotalMinutos = If(reader("TotalMinutos") Is Convert.DBNull, 0, Convert.ToInt32(reader("TotalMinutos")))
            End If

            reader.Close()
            connection.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return m_dbo
    End Function

    Public Function MediasEnvasado(ByVal m_dbo As DBO_ResumenFormatosEnvasados) As DBO_ResumenFormatosEnvasados
        Try
            BasesParaCompatibilidad.BD.Conectar()
            Dim dbo As DBO_ResumenFormatosEnvasados = New DBO_ResumenFormatosEnvasados
            Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
            Dim selectCommand As New System.Data.SqlClient.SqlCommand(sp_CalcularMediasEnvasado, connection)
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@FormatoEnvasado", m_dbo.FormatoEnvasadoID)

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                dbo.TotalesIncidencias_CalidadMinutos = If(reader("MinutosPorPalet") Is Convert.DBNull, 0, Convert.ToInt32(reader("MinutosPorPalet")))
                dbo.TotalesIncidencias_CalidadNumero = If(reader("Velocidad") Is Convert.DBNull, 0, Convert.ToInt32(reader("Velocidad")))
                dbo.TotalesIncidencias_IntrinsicasMinutos = If(reader("Efectividad") Is Convert.DBNull, 0, Convert.ToInt32(reader("Efectividad")))
            End If

            reader.Close()
            connection.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return m_dbo
    End Function

    Public Function TotalesEnvasado(ByVal m_dbo As DBO_ResumenFormatosEnvasados) As DBO_ResumenFormatosEnvasados
        Try
            BasesParaCompatibilidad.BD.Conectar()
            Dim dbo As DBO_ResumenFormatosEnvasados = New DBO_ResumenFormatosEnvasados
            Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
            Dim selectCommand As New System.Data.SqlClient.SqlCommand(sp_CalcularTotalesEnvasado, connection)
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@FormatoEnvasado", m_dbo.FormatoEnvasadoID)

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                dbo.TotalesIncidencias_CalidadMinutos = If(reader("TotalPalets") Is Convert.DBNull, 0, Convert.ToInt32(reader("TotalPalets")))
                dbo.TotalesIncidencias_CalidadNumero = If(reader("CajasSueltas") Is Convert.DBNull, 0, Convert.ToInt32(reader("CajasSueltas")))
                dbo.TotalesIncidencias_IntrinsicasMinutos = If(reader("Cajas") Is Convert.DBNull, 0, Convert.ToInt32(reader("Cajas")))
                dbo.TotalesIncidencias_IntrinsicasNumero = If(reader("Botellas") Is Convert.DBNull, 0, Convert.ToInt32(reader("Botellas")))
                dbo.TotalesIncidencias_MaquinaMinutos = If(reader("Litros") Is Convert.DBNull, 0, Convert.ToInt32(reader("Litros")))
                dbo.TotalesIncidencias_MaquinaNumero = If(reader("CajasCompletando") Is Convert.DBNull, 0, Convert.ToInt32(reader("CajasCompletando")))
            End If

            reader.Close()
            connection.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return m_dbo
    End Function

    Public Function TotalesTiempo(ByVal m_dbo As DBO_ResumenFormatosEnvasados) As DBO_ResumenFormatosEnvasados
        Try
            BasesParaCompatibilidad.BD.Conectar()
            Dim dbo As DBO_ResumenFormatosEnvasados = New DBO_ResumenFormatosEnvasados
            Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
            Dim selectCommand As New System.Data.SqlClient.SqlCommand(sp_CalcularTotalesTiempo, connection)
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@FormatoEnvasado", m_dbo.FormatoEnvasadoID)

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                dbo.TotalesIncidencias_CalidadMinutos = If(reader("HoraInicio") Is Convert.DBNull, System.DateTime.Now, reader("HoraInicio"))
                dbo.TotalesIncidencias_CalidadNumero = If(reader("HoraFin") Is Convert.DBNull, System.DateTime.Now, reader("HoraFin"))
                dbo.TotalesIncidencias_IntrinsicasMinutos = If(reader("Asignado") Is Convert.DBNull, 0, Convert.ToInt32(reader("Asignado")))
                dbo.TotalesIncidencias_IntrinsicasNumero = If(reader("IncidenciasEvitables") Is Convert.DBNull, 0, Convert.ToInt32(reader("IncidenciasEvitables")))
                dbo.TotalesIncidencias_MaquinaMinutos = If(reader("IncidenciasnoEvitables") Is Convert.DBNull, 0, Convert.ToInt32(reader("IncidenciasnoEvitables")))
                dbo.TotalesIncidencias_MaquinaNumero = If(reader("TotalIncidencias") Is Convert.DBNull, 0, Convert.ToInt32(reader("TotalIncidencias")))
                dbo.TotalesIncidencias_OtrosMinutos = If(reader("TiempoNoJustificado") Is Convert.DBNull, 0, Convert.ToInt32(reader("TiempoNoJustificado")))
            End If

            reader.Close()
            connection.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return m_dbo
    End Function

End Class
