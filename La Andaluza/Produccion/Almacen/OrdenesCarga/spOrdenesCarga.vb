

Class spOrdenesCarga
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[OrdenesCargaSelect]", "[dbo].[OrdenesCargaInsert]", "[dbo].[OrdenesCargaUpdate]", _
                   "[dbo].[OrdenesCargaDelete]", "OrdenesCargaSelectDgv", "OrdenesCargaSelectDgvByID")
    End Sub
    Public Function Select_Record(ByVal OrdenCargaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_OrdenesCarga
        dtb.Conectar()
        Dim DBO_OrdenesCarga As New DBO_OrdenesCarga

        Dim selectProcedure As String = "[dbo].[OrdenesCargaSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@OrdenCargaID", OrdenCargaID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_OrdenesCarga.OrdenCargaID = If(reader("OrdenCargaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("OrdenCargaID")))
                DBO_OrdenesCarga.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_OrdenesCarga.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_OrdenesCarga.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_OrdenesCarga.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_OrdenesCarga.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_OrdenesCarga = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_OrdenesCarga
    End Function

    Public Function OrdenesCargaInsert(ByVal dbo_OrdenesCarga As DBO_OrdenesCarga, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[OrdenesCargaInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@Fecha", dbo_OrdenesCarga.Fecha)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_OrdenesCarga.Ruta)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_OrdenesCarga.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_OrdenesCarga.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_OrdenesCarga.UsuarioModificacion)

        Try
            insertCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function OrdenesCargaInsert(ByVal dbo_OrdenesCarga As DBO_OrdenesCarga, ByRef dtb As BasesParaCompatibilidad.Database, ByVal stub As Boolean) As Boolean
        dtb.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = dtb.Conexion
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesCargaInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@Fecha", dbo_OrdenesCarga.Fecha)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_OrdenesCarga.Ruta)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_OrdenesCarga.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_OrdenesCarga.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_OrdenesCarga.UsuarioModificacion)

        Try
            insertCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

  
    Public Function OrdenesCargaInsertDetail(ByVal dbo_OrdenesCarga As DBO_OrdenesCargaDetalles, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = dtb.Conexion
        Dim insertProcedure As String = "[dbo].[OrdenesCargaDetallesInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesCargaDetallesInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@id_OrdenCarga", dbo_OrdenesCarga.Id_OrdenCarga)
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_OrdenesCarga.Descripcion)
        insertCommand.Parameters.AddWithValue("@id_tipoFormato", dbo_OrdenesCarga.id_tipoFormato)
        insertCommand.Parameters.AddWithValue("@Palets", dbo_OrdenesCarga.Palets)
        insertCommand.Parameters.AddWithValue("@Pico", dbo_OrdenesCarga.Pico)
        insertCommand.Parameters.AddWithValue("@PaletsCarga", dbo_OrdenesCarga.PaletsCarga)
        insertCommand.Parameters.AddWithValue("@Carga", dbo_OrdenesCarga.carga)
        insertCommand.Parameters.AddWithValue("@CargaSinPedidos", dbo_OrdenesCarga.CargaSinPedidos)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_OrdenesCarga.Observaciones)
        insertCommand.Parameters.AddWithValue("@CargaPicos", If(dbo_OrdenesCarga.cargaPicos Is Nothing, String.Empty, dbo_OrdenesCarga.cargaPicos))
        insertCommand.Parameters.AddWithValue("@CargaSccPicos", If(dbo_OrdenesCarga.cargaPicosSCC Is Nothing, String.Empty, dbo_OrdenesCarga.cargaPicosSCC))
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", Today.Date)
        Try
            insertCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function OrdenesCargaUpdate(ByVal newDBO_OrdenesCarga As DBO_OrdenesCarga, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[OrdenesCargaUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure

        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_OrdenesCarga.Fecha)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_OrdenesCarga.Ruta)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_OrdenesCarga.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_OrdenesCarga.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_OrdenesCarga.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldOrdenCargaID", newDBO_OrdenesCarga.OrdenCargaID)

        Try
            updateCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function OrdenesCargaUpdate(ByVal newDBO_OrdenesCarga As DBO_OrdenesCarga, ByRef dtb As BasesParaCompatibilidad.Database, ByVal stub As Boolean) As Boolean
        dtb.Conectar()

        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesCargaUpdate]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_OrdenesCarga.Fecha)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_OrdenesCarga.Ruta)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_OrdenesCarga.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_OrdenesCarga.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_OrdenesCarga.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldOrdenCargaID", newDBO_OrdenesCarga.OrdenCargaID)

        Try
            updateCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function OrdenesCargaDelete(ByVal OrdenCargaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[OrdenesCargaDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldOrdenCargaID", OrdenCargaID)

        Try
            deleteCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarOrdenesCarga(ByVal dbo_OrdenesCarga As DBO_OrdenesCarga, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_OrdenesCarga.FechaModificacion = System.DateTime.Now.date
        dbo_OrdenesCarga.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_OrdenesCarga.OrdenCargaID = 0 Then
            Return OrdenesCargaInsert(dbo_OrdenesCarga, dtb)
        Else
            Return OrdenesCargaUpdate(dbo_OrdenesCarga, dtb)
        End If
    End Function

    Public Function GrabarOrdenesCarga(ByVal dbo_OrdenesCarga As DBO_OrdenesCarga, ByRef dtb As BasesParaCompatibilidad.Database, ByVal stub As Boolean) As Boolean
        dbo_OrdenesCarga.FechaModificacion = System.DateTime.Now.date
        dbo_OrdenesCarga.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_OrdenesCarga.OrdenCargaID = 0 Then
            Return OrdenesCargaInsert(dbo_OrdenesCarga, dtb, True)
        Else
            Return OrdenesCargaUpdate(dbo_OrdenesCarga, dtb, True)
        End If
    End Function

    Public Function AddOrdenCarga(ByVal Ruta As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim m_DBO_OrdenesCarga As New DBO_OrdenesCarga
        m_DBO_OrdenesCarga.Fecha = Now.Date
        m_DBO_OrdenesCarga.Ruta = Ruta
        m_DBO_OrdenesCarga.Observaciones = String.Empty
        Return Me.GrabarOrdenesCarga(m_DBO_OrdenesCarga, dtb)
    End Function
End Class
