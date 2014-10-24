

Class spParadaOrdenadas2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ParadaOrdenadas2Select]", "[dbo].[ParadaOrdenadas2Insert]", "[dbo].[ParadaOrdenadas2Update]", _
                   "[dbo].[ParadaOrdenadas2Delete]", "ParadasOrdenadas2SelectPorFormatoEnvasado", "ParadasOrdenadas2SelectPorFormatoEnvasado")
    End Sub

    Public Function Select_Record(ByVal ParadaOrdenadaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ParadaOrdenadas2
        dtb.Conectar()
        Dim DBO_ParadaOrdenadas2 As New DBO_ParadaOrdenadas2

        Dim selectProcedure As String = "[dbo].[ParadaOrdenadas2Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ParadaOrdenadaID", ParadaOrdenadaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ParadaOrdenadas2.ParadaOrdenadaID = If(reader("ParadaOrdenadaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ParadaOrdenadaID")))
                DBO_ParadaOrdenadas2.HoraInicio = If(reader("HoraInicio") Is Convert.DBNull, System.DateTime.Now, reader("HoraInicio"))
                DBO_ParadaOrdenadas2.HoraInicio_IsDBNull = If(reader("HoraInicio") Is Convert.DBNull, True, False)
                DBO_ParadaOrdenadas2.HoraFinal = If(reader("HoraFinal") Is Convert.DBNull, System.DateTime.Now, reader("HoraFinal"))
                DBO_ParadaOrdenadas2.HoraFinal_IsDBNull = If(reader("HoraFinal") Is Convert.DBNull, True, False)
                DBO_ParadaOrdenadas2.Observacion = If(reader("Observacion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observacion")))
                DBO_ParadaOrdenadas2.Observacion_IsDBNull = If(reader("Observacion") Is Convert.DBNull, True, False)
                DBO_ParadaOrdenadas2.ParadaOrdenadaMotivoID = If(reader("ParadaOrdenadaMotivoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ParadaOrdenadaMotivoID")))
                DBO_ParadaOrdenadas2.ParadaOrdenadaMotivoID_IsDBNull = If(reader("ParadaOrdenadaMotivoID") Is Convert.DBNull, True, False)
                DBO_ParadaOrdenadas2.PersonalID = If(reader("PersonalID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PersonalID")))
                DBO_ParadaOrdenadas2.PersonalID_IsDBNull = If(reader("PersonalID") Is Convert.DBNull, True, False)
                DBO_ParadaOrdenadas2.FormatoEnvasadoID = If(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoEnvasadoID")))
                DBO_ParadaOrdenadas2.FormatoEnvasadoID_IsDBNull = If(reader("FormatoEnvasadoID") Is Convert.DBNull, True, False)
                DBO_ParadaOrdenadas2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ParadaOrdenadas2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ParadaOrdenadas2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ParadaOrdenadas2
    End Function

    Public Function ParadaOrdenadas2Insert(ByVal dbo_ParadaOrdenadas2 As DBO_ParadaOrdenadas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ParadaOrdenadas2Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@HoraInicio", If(dbo_ParadaOrdenadas2.HoraInicio_IsDBNull = True, Convert.DBNull, dbo_ParadaOrdenadas2.HoraInicio))
        insertCommand.Parameters.AddWithValue("@HoraFinal", If(dbo_ParadaOrdenadas2.HoraFinal_IsDBNull = True, Convert.DBNull, dbo_ParadaOrdenadas2.HoraFinal))
        insertCommand.Parameters.AddWithValue("@Observacion", If(dbo_ParadaOrdenadas2.Observacion_IsDBNull = True, Convert.DBNull, dbo_ParadaOrdenadas2.Observacion))
        insertCommand.Parameters.AddWithValue("@ParadaOrdenadaMotivoID", If(dbo_ParadaOrdenadas2.ParadaOrdenadaMotivoID_IsDBNull = True, Convert.DBNull, dbo_ParadaOrdenadas2.ParadaOrdenadaMotivoID))
        insertCommand.Parameters.AddWithValue("@PersonalID", If(dbo_ParadaOrdenadas2.PersonalID_IsDBNull = True, Convert.DBNull, dbo_ParadaOrdenadas2.PersonalID))
        insertCommand.Parameters.AddWithValue("@FormatoEnvasadoID", If(dbo_ParadaOrdenadas2.FormatoEnvasadoID_IsDBNull = True, Convert.DBNull, dbo_ParadaOrdenadas2.FormatoEnvasadoID))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ParadaOrdenadas2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ParadaOrdenadas2.UsuarioModificacion)
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
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ParadaOrdenadas2Update(ByVal newDBO_ParadaOrdenadas2 As DBO_ParadaOrdenadas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ParadaOrdenadas2Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewHoraInicio", If(newDBO_ParadaOrdenadas2.HoraInicio_IsDBNull = True, Convert.DBNull, newDBO_ParadaOrdenadas2.HoraInicio))
        updateCommand.Parameters.AddWithValue("@NewHoraFinal", If(newDBO_ParadaOrdenadas2.HoraFinal_IsDBNull = True, Convert.DBNull, newDBO_ParadaOrdenadas2.HoraFinal))
        updateCommand.Parameters.AddWithValue("@NewObservacion", If(newDBO_ParadaOrdenadas2.Observacion_IsDBNull = True, Convert.DBNull, newDBO_ParadaOrdenadas2.Observacion))
        updateCommand.Parameters.AddWithValue("@NewParadaOrdenadaMotivoID", If(newDBO_ParadaOrdenadas2.ParadaOrdenadaMotivoID_IsDBNull = True, Convert.DBNull, newDBO_ParadaOrdenadas2.ParadaOrdenadaMotivoID))
        updateCommand.Parameters.AddWithValue("@NewPersonalID", If(newDBO_ParadaOrdenadas2.PersonalID_IsDBNull = True, Convert.DBNull, newDBO_ParadaOrdenadas2.PersonalID))
        updateCommand.Parameters.AddWithValue("@NewFormatoEnvasadoID", If(newDBO_ParadaOrdenadas2.FormatoEnvasadoID_IsDBNull = True, Convert.DBNull, newDBO_ParadaOrdenadas2.FormatoEnvasadoID))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ParadaOrdenadas2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ParadaOrdenadas2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldParadaOrdenadaID", newDBO_ParadaOrdenadas2.ParadaOrdenadaID)
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
            MessageBox.Show("Error en UpdateParadaOrdenadas2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ParadaOrdenadas2Delete(ByVal ParadaOrdenadaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ParadaOrdenadas2Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldParadaOrdenadaID", ParadaOrdenadaID)
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
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarParadaOrdenadas2(ByVal dbo_ParadaOrdenadas2 As DBO_ParadaOrdenadas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If dbo_ParadaOrdenadas2.ParadaOrdenadaID = 0 Then
            Return ParadaOrdenadas2Insert(dbo_ParadaOrdenadas2, dtb)
        Else
            Return ParadaOrdenadas2Update(dbo_ParadaOrdenadas2, dtb)
        End If
    End Function

End Class
