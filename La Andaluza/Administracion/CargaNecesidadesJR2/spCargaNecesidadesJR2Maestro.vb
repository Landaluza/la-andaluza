

Class spCargaNecesidadesJR2Maestro
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[CargaNecesidadesJRMaestroSelect]", "[dbo].[CargaNecesidadesJRMaestroInsert]", "[dbo].[CargaNecesidadesJRMaestroUpdate]", _
                  "[dbo].[CargaNecesidadesJRMaestroDelete]", "CargaNecesidadesJRMaestroSelectDgv", "CargaNecesidadesJRMaestroSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal CargaNecesidadesJRMaestroID As Int32) As DBO_CargaNecesidadesJR2Maestro
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_CargaNecesidadesJRMaestro As New DBO_CargaNecesidadesJR2Maestro
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[CargaNecesidadesJRMaestroSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@CargaNecesidadesJRMaestroID", CargaNecesidadesJRMaestroID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID = If(reader("CargaNecesidadesJRMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("CargaNecesidadesJRMaestroID")))
                DBO_CargaNecesidadesJRMaestro.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_CargaNecesidadesJRMaestro.Hora = If(reader("Hora") Is Convert.DBNull, System.DateTime.Now.TimeOfDay, reader("Hora"))
                DBO_CargaNecesidadesJRMaestro.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_CargaNecesidadesJRMaestro.Reserva1 = If(reader("Reserva1") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Reserva1")))
                DBO_CargaNecesidadesJRMaestro.Reserva2 = If(reader("Reserva2") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Reserva2")))
                DBO_CargaNecesidadesJRMaestro.Reserva3 = If(reader("Reserva3") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Reserva3")))
                DBO_CargaNecesidadesJRMaestro.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_CargaNecesidadesJRMaestro.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_CargaNecesidadesJRMaestro.Servido = If(reader("Servido") Is Convert.DBNull, False, Convert.ToBoolean(reader("Servido")))
            Else
                DBO_CargaNecesidadesJRMaestro = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_CargaNecesidadesJRMaestro
    End Function

    Public Function CargaNecesidadesJRMaestroInsert(ByVal dbo_CargaNecesidadesJRMaestro As DBO_CargaNecesidadesJR2Maestro) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[CargaNecesidadesJRMaestroInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_CargaNecesidadesJRMaestro.Fecha)
        insertCommand.Parameters.AddWithValue("@Hora", dbo_CargaNecesidadesJRMaestro.Hora)
        insertCommand.Parameters.AddWithValue("@Observaciones", if(dbo_CargaNecesidadesJRMaestro.Observaciones Is Nothing, Convert.DBNull, dbo_CargaNecesidadesJRMaestro.Observaciones))
        insertCommand.Parameters.AddWithValue("@Reserva1", if(dbo_CargaNecesidadesJRMaestro.Reserva1 Is Nothing, Convert.DBNull, dbo_CargaNecesidadesJRMaestro.Reserva1))
        insertCommand.Parameters.AddWithValue("@Reserva2", if(dbo_CargaNecesidadesJRMaestro.Reserva2 Is Nothing, Convert.DBNull, dbo_CargaNecesidadesJRMaestro.Reserva2))
        insertCommand.Parameters.AddWithValue("@Reserva3", if(dbo_CargaNecesidadesJRMaestro.Reserva3 Is Nothing, Convert.DBNull, dbo_CargaNecesidadesJRMaestro.Reserva3))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_CargaNecesidadesJRMaestro.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_CargaNecesidadesJRMaestro.UsuarioModificacion)
        insertCommand.Parameters.AddWithValue("@Servido", dbo_CargaNecesidadesJRMaestro.Servido)
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
            connection.Close()
        End Try
    End Function

    Public Function CargaNecesidadesJRMaestroUpdate(ByVal newDBO_CargaNecesidadesJRMaestro As DBO_CargaNecesidadesJR2Maestro) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[CargaNecesidadesJRMaestroUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_CargaNecesidadesJRMaestro.Fecha)
        updateCommand.Parameters.AddWithValue("@NewHora", newDBO_CargaNecesidadesJRMaestro.Hora)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", if(newDBO_CargaNecesidadesJRMaestro.Observaciones Is Nothing, Convert.DBNull, newDBO_CargaNecesidadesJRMaestro.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewReserva1", if(newDBO_CargaNecesidadesJRMaestro.Reserva1 Is Nothing, Convert.DBNull, newDBO_CargaNecesidadesJRMaestro.Reserva1))
        updateCommand.Parameters.AddWithValue("@NewReserva2", if(newDBO_CargaNecesidadesJRMaestro.Reserva2 Is Nothing, Convert.DBNull, newDBO_CargaNecesidadesJRMaestro.Reserva2))
        updateCommand.Parameters.AddWithValue("@NewReserva3", if(newDBO_CargaNecesidadesJRMaestro.Reserva3 Is Nothing, Convert.DBNull, newDBO_CargaNecesidadesJRMaestro.Reserva3))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_CargaNecesidadesJRMaestro.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_CargaNecesidadesJRMaestro.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@NewServido", newDBO_CargaNecesidadesJRMaestro.Servido)
        updateCommand.Parameters.AddWithValue("@OldCargaNecesidadesJRMaestroID", newDBO_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID)
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
            MessageBox.Show("Error en UpdateCargaNecesidadesJRMaestro" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function CargaNecesidadesJRMaestroDelete(ByVal CargaNecesidadesJRMaestroID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[CargaNecesidadesJRMaestroDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldCargaNecesidadesJRMaestroID", CargaNecesidadesJRMaestroID)
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
            connection.Close()
        End Try
    End Function

    Public Sub GrabarCargaNecesidadesJRMaestro(ByVal dbo_CargaNecesidadesJRMaestro As DBO_CargaNecesidadesJR2Maestro)
        If dbo_CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID = 0 Then
            CargaNecesidadesJRMaestroInsert(dbo_CargaNecesidadesJRMaestro)
        Else
            CargaNecesidadesJRMaestroUpdate(dbo_CargaNecesidadesJRMaestro)
        End If
    End Sub

End Class
