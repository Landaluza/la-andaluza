

Public Class spControlesEntregasEpis
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ControlesEntregasEpisSelect]", "[dbo].[ControlesEntregasEpisInsert]", "[dbo].[ControlesEntregasEpisUpdate]", "[dbo].[ControlesEntregasEpisDelete]", "ControlesEntregasEpisSelectDgv", "")
    End Sub
    Public Function Select_Record(ByVal ControlEntregaEpiID As Int32) As DBO_ControlesEntregasEpis
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ControlesEntregasEpis As New DBO_ControlesEntregasEpis
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ControlesEntregasEpisSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ControlEntregaEpiID", ControlEntregaEpiID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ControlesEntregasEpis.ControlEntregaEpiID = If(reader("ControlEntregaEpiID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ControlEntregaEpiID")))
                DBO_ControlesEntregasEpis.FechaEntrega = If(reader("FechaEntrega") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaEntrega")))
                DBO_ControlesEntregasEpis.EpiID = If(reader("EpiID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EpiID")))
                DBO_ControlesEntregasEpis.EmpleadoID = If(reader("EmpleadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EmpleadoID")))
                DBO_ControlesEntregasEpis.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ControlesEntregasEpis.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                DBO_ControlesEntregasEpis.EntregaAnteriores = If(reader("EntregaAnteriores") Is Convert.DBNull, False, Convert.ToBoolean(reader("EntregaAnteriores")))
                DBO_ControlesEntregasEpis.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ControlesEntregasEpis.FechaModificacion_IsDBNull = If(reader("FechaModificacion") Is Convert.DBNull, True, False)
                DBO_ControlesEntregasEpis.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_ControlesEntregasEpis.UsuarioModificacion_IsDBNull = if(reader("UsuarioModificacion") Is Convert.DBNull, True, False)
            Else
                DBO_ControlesEntregasEpis = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ControlesEntregasEpis
    End Function

    Public Function InsertControlesEntregasEpis(ByVal dbo_ControlesEntregasEpis As DBO_ControlesEntregasEpis) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ControlesEntregasEpisInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@FechaEntrega", dbo_ControlesEntregasEpis.FechaEntrega)
        insertCommand.Parameters.AddWithValue("@EpiID", dbo_ControlesEntregasEpis.EpiID)
        insertCommand.Parameters.AddWithValue("@EmpleadoID", dbo_ControlesEntregasEpis.EmpleadoID)
        insertCommand.Parameters.AddWithValue("@Observaciones", if(dbo_ControlesEntregasEpis.Observaciones_IsDBNull = True, Convert.DBNull, dbo_ControlesEntregasEpis.Observaciones))
        insertCommand.Parameters.AddWithValue("@EntregaAnteriores", dbo_ControlesEntregasEpis.EntregaAnteriores)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", if(dbo_ControlesEntregasEpis.FechaModificacion_IsDBNull = True, Convert.DBNull, dbo_ControlesEntregasEpis.FechaModificacion))
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", if(dbo_ControlesEntregasEpis.UsuarioModificacion_IsDBNull = True, Convert.DBNull, dbo_ControlesEntregasEpis.UsuarioModificacion))
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

    Public Function UpdateControlesEntregasEpis(ByVal oldDBO_ControlesEntregasEpis As DBO_ControlesEntregasEpis, ByVal newDBO_ControlesEntregasEpis As DBO_ControlesEntregasEpis) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ControlesEntregasEpisUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewFechaEntrega", newDBO_ControlesEntregasEpis.FechaEntrega)
        updateCommand.Parameters.AddWithValue("@NewEpiID", newDBO_ControlesEntregasEpis.EpiID)
        updateCommand.Parameters.AddWithValue("@NewEmpleadoID", newDBO_ControlesEntregasEpis.EmpleadoID)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", if(newDBO_ControlesEntregasEpis.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_ControlesEntregasEpis.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewEntregaAnteriores", newDBO_ControlesEntregasEpis.EntregaAnteriores)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", if(newDBO_ControlesEntregasEpis.FechaModificacion_IsDBNull = True, Convert.DBNull, newDBO_ControlesEntregasEpis.FechaModificacion))
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", if(newDBO_ControlesEntregasEpis.UsuarioModificacion_IsDBNull = True, Convert.DBNull, newDBO_ControlesEntregasEpis.UsuarioModificacion))
        updateCommand.Parameters.AddWithValue("@OldControlEntregaEpiID", oldDBO_ControlesEntregasEpis.ControlEntregaEpiID)
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
            MessageBox.Show("Error en UpdateControlesEntregasEpis" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function DeleteControlesEntregasEpis(ByVal ControlEntregaEpiID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ControlesEntregasEpisDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldControlEntregaEpiID", ControlEntregaEpiID)
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

End Class
