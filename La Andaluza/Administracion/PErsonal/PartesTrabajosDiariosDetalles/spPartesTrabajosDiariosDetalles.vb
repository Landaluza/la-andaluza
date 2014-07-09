

Class spPartesTrabajosDiariosDetalles
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PartesTrabajosDiariosDetallesSelect]", "[dbo].[PartesTrabajosDiariosDetallesInsert]", "[dbo].[PartesTrabajosDiariosDetallesUpdate]", _
                   "[dbo].[PartesTrabajosDiariosDetallesDelete]", "PartesTrabajosDiariosDetallesSelectDgv", "PartesTrabajosDiariosDetallesSelectDgvByParteTrabajoDiarioMaestroID")
    End Sub

    Public Function Select_Record(ByVal ParteTrabajoDiarioDetalleID As Int32) As DBO_PartesTrabajosDiariosDetalles
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_PartesTrabajosDiariosDetalles As New DBO_PartesTrabajosDiariosDetalles
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PartesTrabajosDiariosDetallesSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ParteTrabajoDiarioDetalleID", ParteTrabajoDiarioDetalleID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                
                DBO_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioDetalleID = If(reader("ParteTrabajoDiarioDetalleID") Is Convert.DBNull, 0, System.Convert.ToInt32(reader("ParteTrabajoDiarioDetalleID")))
                DBO_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioMaestroID = If(reader("ParteTrabajoDiarioMaestroID") Is Convert.DBNull, 0, System.Convert.ToInt32(reader("ParteTrabajoDiarioMaestroID")))
                DBO_PartesTrabajosDiariosDetalles.TareasID = If(reader("TareasID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TareasID")))
                DBO_PartesTrabajosDiariosDetalles.HoraInicio = If(reader("HoraInicio") Is Convert.DBNull, New TimeSpan(Now.Date.Hour, Now.Date.Minute, Now.Date.Second), CType(reader("HoraInicio"), TimeSpan))
                DBO_PartesTrabajosDiariosDetalles.HoraFinal = If(reader("HoraFinal") Is Convert.DBNull, New TimeSpan(Now.Date.Hour, Now.Date.Minute, Now.Date.Second), CType(reader("HoraFinal"), TimeSpan))
                DBO_PartesTrabajosDiariosDetalles.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, System.Convert.ToString(reader("Observaciones")))
                DBO_PartesTrabajosDiariosDetalles.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now, System.Convert.ToDateTime(reader("FechaModificacion")))
                DBO_PartesTrabajosDiariosDetalles.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, System.Convert.ToInt32(reader("UsuarioModificacion")))
                
            Else
                DBO_PartesTrabajosDiariosDetalles = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_PartesTrabajosDiariosDetalles
    End Function

    Public Function PartesTrabajosDiariosDetallesInsert(ByVal dbo_PartesTrabajosDiariosDetalles As DBO_PartesTrabajosDiariosDetalles) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[PartesTrabajosDiariosDetallesInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@ParteTrabajoDiarioMaestroID", If(dbo_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioMaestroID.HasValue, dbo_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioMaestroID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@TareasID", If(dbo_PartesTrabajosDiariosDetalles.TareasID.HasValue, dbo_PartesTrabajosDiariosDetalles.TareasID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@HoraInicio", dbo_PartesTrabajosDiariosDetalles.HoraInicio)
        insertCommand.Parameters.AddWithValue("@HoraFinal", dbo_PartesTrabajosDiariosDetalles.HoraFinal)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PartesTrabajosDiariosDetalles.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PartesTrabajosDiariosDetalles.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PartesTrabajosDiariosDetalles.UsuarioModificacion)
        
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
            connection.Close()
        End Try
    End Function

    Public Function PartesTrabajosDiariosDetallesUpdate(ByVal newDBO_PartesTrabajosDiariosDetalles As DBO_PartesTrabajosDiariosDetalles) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PartesTrabajosDiariosDetallesUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewParteTrabajoDiarioMaestroID", If(newDBO_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioMaestroID.HasValue, newDBO_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioMaestroID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewTareasID", If(newDBO_PartesTrabajosDiariosDetalles.TareasID.HasValue, newDBO_PartesTrabajosDiariosDetalles.TareasID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewHoraInicio", newDBO_PartesTrabajosDiariosDetalles.HoraInicio)
        updateCommand.Parameters.AddWithValue("@NewHoraFinal", newDBO_PartesTrabajosDiariosDetalles.HoraFinal)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PartesTrabajosDiariosDetalles.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PartesTrabajosDiariosDetalles.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PartesTrabajosDiariosDetalles.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldParteTrabajoDiarioDetalleID", newDBO_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioDetalleID)
        '<Tag=[Three][End]> -- please do not remove this line
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
            MessageBox.Show("Error en UpdatePartesTrabajosDiariosDetalles" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function PartesTrabajosDiariosDetallesDelete(ByVal ParteTrabajoDiarioDetalleID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[PartesTrabajosDiariosDetallesDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldParteTrabajoDiarioDetalleID", ParteTrabajoDiarioDetalleID)
        '<Tag=[Four][End]> -- please do not remove this line
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
            connection.Close()
        End Try
    End Function

    Public Sub GrabarPartesTrabajosDiariosDetalles(ByVal dbo_PartesTrabajosDiariosDetalles As DBO_PartesTrabajosDiariosDetalles)
        dbo_PartesTrabajosDiariosDetalles.FechaModificacion = System.DateTime.Now.date
        dbo_PartesTrabajosDiariosDetalles.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_PartesTrabajosDiariosDetalles.ParteTrabajoDiarioDetalleID = 0 Then
            PartesTrabajosDiariosDetallesInsert(dbo_PartesTrabajosDiariosDetalles)
        Else
            PartesTrabajosDiariosDetallesUpdate(dbo_PartesTrabajosDiariosDetalles)
        End If
    End Sub

End Class
