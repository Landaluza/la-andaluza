

Class spCambiosFormatosEnvasados2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[CambiosFormatosEnvasados2Select]", "[dbo].[CambiosFormatosEnvasados2Insert]", "[dbo].[CambiosFormatosEnvasados2Update]", _
                   "[dbo].[CambiosFormatosEnvasados2Delete]", "CambiosFormatosEnvasados2SelectPorFormatoEnvasado", "CambiosFormatosEnvasados2SelectPorFormatoEnvasado")
    End Sub

    Public Function Select_Record(ByVal CambioFormatoEnvasadoId As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CambiosFormatosEnvasados2
        dtb.Conectar()
        Dim DBO_CambiosFormatosEnvasados2 As New DBO_CambiosFormatosEnvasados2

        Dim selectProcedure As String = "[dbo].[CambiosFormatosEnvasados2Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@CambioFormatoEnvasadoId", CambioFormatoEnvasadoId)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_CambiosFormatosEnvasados2.CambioFormatoEnvasadoId = If(reader("CambioFormatoEnvasadoId") Is Convert.DBNull, 0, Convert.ToInt32(reader("CambioFormatoEnvasadoId")))
                DBO_CambiosFormatosEnvasados2.HoraInicio = If(reader("HoraInicio") Is Convert.DBNull, System.DateTime.Now, reader("HoraInicio"))
                DBO_CambiosFormatosEnvasados2.HoraInicio_IsDBNull = If(reader("HoraInicio") Is Convert.DBNull, True, False)
                DBO_CambiosFormatosEnvasados2.HoraFin = If(reader("HoraFin") Is Convert.DBNull, System.DateTime.Now, reader("HoraFin"))
                DBO_CambiosFormatosEnvasados2.HoraFin_IsDBNull = If(reader("HoraFin") Is Convert.DBNull, True, False)
                DBO_CambiosFormatosEnvasados2.Observacion = If(reader("Observacion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observacion")))
                DBO_CambiosFormatosEnvasados2.Observacion_IsDBNull = If(reader("Observacion") Is Convert.DBNull, True, False)
                DBO_CambiosFormatosEnvasados2.PersonalID = If(reader("PersonalID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PersonalID")))
                DBO_CambiosFormatosEnvasados2.PersonalID_IsDBNull = If(reader("PersonalID") Is Convert.DBNull, True, False)
                DBO_CambiosFormatosEnvasados2.TipoformatoInicialID = If(reader("TipoformatoInicialID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoformatoInicialID")))
                DBO_CambiosFormatosEnvasados2.TipoformatoInicialID_IsDBNull = If(reader("TipoformatoInicialID") Is Convert.DBNull, True, False)
                DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID = If(reader("FormatoEnvasadoAID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoEnvasadoAID")))
                DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID_IsDBNull = If(reader("FormatoEnvasadoAID") Is Convert.DBNull, True, False)
                DBO_CambiosFormatosEnvasados2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_CambiosFormatosEnvasados2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_CambiosFormatosEnvasados2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_CambiosFormatosEnvasados2
    End Function

    Public Function CambiosFormatosEnvasados2Insert(ByVal dbo_CambiosFormatosEnvasados2 As DBO_CambiosFormatosEnvasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[CambiosFormatosEnvasados2Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@HoraInicio", If(dbo_CambiosFormatosEnvasados2.HoraInicio_IsDBNull = True, Convert.DBNull, dbo_CambiosFormatosEnvasados2.HoraInicio))
        insertCommand.Parameters.AddWithValue("@HoraFin", If(dbo_CambiosFormatosEnvasados2.HoraFin_IsDBNull = True, Convert.DBNull, dbo_CambiosFormatosEnvasados2.HoraFin))
        insertCommand.Parameters.AddWithValue("@Observacion", If(dbo_CambiosFormatosEnvasados2.Observacion_IsDBNull = True, Convert.DBNull, dbo_CambiosFormatosEnvasados2.Observacion))
        insertCommand.Parameters.AddWithValue("@PersonalID", If(dbo_CambiosFormatosEnvasados2.PersonalID_IsDBNull = True, Convert.DBNull, dbo_CambiosFormatosEnvasados2.PersonalID))
        insertCommand.Parameters.AddWithValue("@TipoformatoInicialID", If(dbo_CambiosFormatosEnvasados2.TipoformatoInicialID_IsDBNull = True, Convert.DBNull, dbo_CambiosFormatosEnvasados2.TipoformatoInicialID))
        insertCommand.Parameters.AddWithValue("@FormatoEnvasadoAID", If(dbo_CambiosFormatosEnvasados2.FormatoEnvasadoAID_IsDBNull = True, Convert.DBNull, dbo_CambiosFormatosEnvasados2.FormatoEnvasadoAID))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_CambiosFormatosEnvasados2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_CambiosFormatosEnvasados2.UsuarioModificacion)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function CambiosFormatosEnvasados2Update(ByVal newDBO_CambiosFormatosEnvasados2 As DBO_CambiosFormatosEnvasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[CambiosFormatosEnvasados2Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewHoraInicio", If(newDBO_CambiosFormatosEnvasados2.HoraInicio_IsDBNull = True, Convert.DBNull, newDBO_CambiosFormatosEnvasados2.HoraInicio))
        updateCommand.Parameters.AddWithValue("@NewHoraFin", If(newDBO_CambiosFormatosEnvasados2.HoraFin_IsDBNull = True, Convert.DBNull, newDBO_CambiosFormatosEnvasados2.HoraFin))
        updateCommand.Parameters.AddWithValue("@NewObservacion", If(newDBO_CambiosFormatosEnvasados2.Observacion_IsDBNull = True, Convert.DBNull, newDBO_CambiosFormatosEnvasados2.Observacion))
        updateCommand.Parameters.AddWithValue("@NewPersonalID", If(newDBO_CambiosFormatosEnvasados2.PersonalID_IsDBNull = True, Convert.DBNull, newDBO_CambiosFormatosEnvasados2.PersonalID))
        updateCommand.Parameters.AddWithValue("@NewTipoformatoInicialID", If(newDBO_CambiosFormatosEnvasados2.TipoformatoInicialID_IsDBNull = True, Convert.DBNull, newDBO_CambiosFormatosEnvasados2.TipoformatoInicialID))
        updateCommand.Parameters.AddWithValue("@NewFormatoEnvasadoAID", If(newDBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID_IsDBNull = True, Convert.DBNull, newDBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_CambiosFormatosEnvasados2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_CambiosFormatosEnvasados2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldCambioFormatoEnvasadoId", newDBO_CambiosFormatosEnvasados2.CambioFormatoEnvasadoId)
        updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            updateCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateCambiosFormatosEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function CambiosFormatosEnvasados2Delete(ByVal CambioFormatoEnvasadoId As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[CambiosFormatosEnvasados2Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldCambioFormatoEnvasadoId", CambioFormatoEnvasadoId)
        deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            deleteCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarCambiosFormatosEnvasados2(ByVal dbo_CambiosFormatosEnvasados2 As DBO_CambiosFormatosEnvasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If dbo_CambiosFormatosEnvasados2.CambioFormatoEnvasadoId = 0 Then
            Return CambiosFormatosEnvasados2Insert(dbo_CambiosFormatosEnvasados2, dtb)
        Else
            Return CambiosFormatosEnvasados2Update(dbo_CambiosFormatosEnvasados2, dtb)
        End If
    End Function

    Public Function selectUltimaHoraPorLineaYformato(linea As Integer, formato As Object, ByRef dtb As BasesParaCompatibilidad.DataBase) As DateTime
        dtb.PrepararConsulta("CambiosFormatosSelectUltimaHora @linea, @formato")
        dtb.AņadirParametroConsulta("@linea", linea)
        dtb.AņadirParametroConsulta("@formato", formato)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Function recuperar_ultimo_formato_por_linea_de_formatoEnvasado(ByVal linea As Integer, ByVal formato As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("CambiosFormatosSelectUltimoFormato @linea, @formato")
        dtb.AņadirParametroConsulta("@linea", linea)
        dtb.AņadirParametroConsulta("@formato", formato)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Function recuperar_personal_habitual_por_linea(ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("CambiosFormatosSelecPersonalHabitual @linea")
        dtb.AņadirParametroConsulta("@linea", linea)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function


End Class
