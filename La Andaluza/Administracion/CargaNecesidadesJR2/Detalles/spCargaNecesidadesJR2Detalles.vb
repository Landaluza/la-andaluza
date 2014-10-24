

Class spCargaNecesidadesJR2Detalles
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[CargaNecesidadesJRDetallesSelect]", "[dbo].[CargaNecesidadesJRDetallesInsert]", "[dbo].[CargaNecesidadesJRDetallesUpdate]", _
                   "[dbo].[CargaNecesidadesJRDetallesDelete]", String.Empty, String.Empty)
    End Sub

    Public Function Select_Record(ByVal CargaNecesidadesJRDetalleID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CargaNecesidadesJR2Detalles
        dtb.Conectar()
        Dim DBO_CargaNecesidadesJRDetalles As New DBO_CargaNecesidadesJR2Detalles

        Dim selectProcedure As String = "[dbo].[CargaNecesidadesJRDetallesSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@CargaNecesidadesJRDetalleID", CargaNecesidadesJRDetalleID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_CargaNecesidadesJRDetalles.CargaNecesidadesJRDetalleID = If(reader("CargaNecesidadesJRDetalleID") Is Convert.DBNull, 0, Convert.ToInt32(reader("CargaNecesidadesJRDetalleID")))
                DBO_CargaNecesidadesJRDetalles.CargaNecesidadesJRMaestroID = If(reader("CargaNecesidadesJRMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("CargaNecesidadesJRMaestroID")))
                DBO_CargaNecesidadesJRDetalles.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_CargaNecesidadesJRDetalles.Carga = If(reader("Carga") Is Convert.DBNull, 0, Convert.ToInt32(reader("Carga")))
                DBO_CargaNecesidadesJRDetalles.Stock = If(reader("Stock") Is Convert.DBNull, 0, Convert.ToInt32(reader("Stock")))
                DBO_CargaNecesidadesJRDetalles.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_CargaNecesidadesJRDetalles.Reserva1 = If(reader("Reserva1") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Reserva1")))
                DBO_CargaNecesidadesJRDetalles.Reserva2 = If(reader("Reserva2") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Reserva2")))
                DBO_CargaNecesidadesJRDetalles.Reserva3 = If(reader("Reserva3") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Reserva3")))
                DBO_CargaNecesidadesJRDetalles.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_CargaNecesidadesJRDetalles.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_CargaNecesidadesJRDetalles = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_CargaNecesidadesJRDetalles
    End Function

    Public Function CargaNecesidadesJRDetallesInsert(ByVal dbo_CargaNecesidadesJRDetalles As DBO_CargaNecesidadesJR2Detalles, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[CargaNecesidadesJRDetallesInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@CargaNecesidadesJRMaestroID", dbo_CargaNecesidadesJRDetalles.CargaNecesidadesJRMaestroID)
        insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_CargaNecesidadesJRDetalles.ArticuloID = 0, Convert.DBNull, dbo_CargaNecesidadesJRDetalles.ArticuloID))
        insertCommand.Parameters.AddWithValue("@Carga", dbo_CargaNecesidadesJRDetalles.Carga)
        insertCommand.Parameters.AddWithValue("@Stock", dbo_CargaNecesidadesJRDetalles.Stock)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_CargaNecesidadesJRDetalles.Observaciones)
        insertCommand.Parameters.AddWithValue("@Reserva1", dbo_CargaNecesidadesJRDetalles.Reserva1)
        insertCommand.Parameters.AddWithValue("@Reserva2", dbo_CargaNecesidadesJRDetalles.Reserva2)
        insertCommand.Parameters.AddWithValue("@Reserva3", dbo_CargaNecesidadesJRDetalles.Reserva3)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_CargaNecesidadesJRDetalles.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_CargaNecesidadesJRDetalles.UsuarioModificacion)
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

    Public Function CargaNecesidadesJRDetallesUpdate(ByVal newDBO_CargaNecesidadesJRDetalles As DBO_CargaNecesidadesJR2Detalles, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[CargaNecesidadesJRDetallesUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewCargaNecesidadesJRMaestroID", newDBO_CargaNecesidadesJRDetalles.CargaNecesidadesJRMaestroID)
        updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_CargaNecesidadesJRDetalles.ArticuloID = 0, Convert.DBNull, newDBO_CargaNecesidadesJRDetalles.ArticuloID))
        updateCommand.Parameters.AddWithValue("@NewCarga", newDBO_CargaNecesidadesJRDetalles.Carga)
        updateCommand.Parameters.AddWithValue("@NewStock", newDBO_CargaNecesidadesJRDetalles.Stock)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_CargaNecesidadesJRDetalles.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewReserva1", newDBO_CargaNecesidadesJRDetalles.Reserva1)
        updateCommand.Parameters.AddWithValue("@NewReserva2", newDBO_CargaNecesidadesJRDetalles.Reserva2)
        updateCommand.Parameters.AddWithValue("@NewReserva3", newDBO_CargaNecesidadesJRDetalles.Reserva3)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_CargaNecesidadesJRDetalles.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_CargaNecesidadesJRDetalles.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldCargaNecesidadesJRDetalleID", newDBO_CargaNecesidadesJRDetalles.CargaNecesidadesJRDetalleID)
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
            MessageBox.Show("Error en UpdateCargaNecesidadesJRDetalles" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function CargaNecesidadesJRDetallesDelete(ByVal CargaNecesidadesJRDetalleID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[CargaNecesidadesJRDetallesDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldCargaNecesidadesJRDetalleID", CargaNecesidadesJRDetalleID)
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

    Public Sub GrabarCargaNecesidadesJRDetalles(ByVal dbo_CargaNecesidadesJRDetalles As DBO_CargaNecesidadesJR2Detalles, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_CargaNecesidadesJRDetalles.CargaNecesidadesJRDetalleID = 0 Then
            CargaNecesidadesJRDetallesInsert(dbo_CargaNecesidadesJRDetalles, dtb)
        Else
            CargaNecesidadesJRDetallesUpdate(dbo_CargaNecesidadesJRDetalles, dtb)
        End If
    End Sub

End Class
