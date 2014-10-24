

Class spPartesTrabajosDiariosMaestros
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PartesTrabajosDiariosMaestrosSelect]", "[dbo].[PartesTrabajosDiariosMaestrosInsert]", "[dbo].[PartesTrabajosDiariosMaestrosUpdate]", _
                   "[dbo].[PartesTrabajosDiariosMaestrosDelete]", "PartesTrabajosDiariosMaestrosSelectDgv", "PartesTrabajosDiariosMaestrosSelectDgvByEmpleadoID")
    End Sub

    Public Function Select_Record(ByVal ParteTrabajoDiarioMaestroID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PartesTrabajosDiariosMaestros
        dtb.Conectar()
        Dim DBO_PartesTrabajosDiariosMaestros As New DBO_PartesTrabajosDiariosMaestros

        Dim selectProcedure As String = "[dbo].[PartesTrabajosDiariosMaestrosSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ParteTrabajoDiarioMaestroID", ParteTrabajoDiarioMaestroID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_PartesTrabajosDiariosMaestros.ParteTrabajoDiarioMaestroID = If(reader("ParteTrabajoDiarioMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ParteTrabajoDiarioMaestroID")))
                DBO_PartesTrabajosDiariosMaestros.EmpleadoID = If(reader("EmpleadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EmpleadoID")))
                DBO_PartesTrabajosDiariosMaestros.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_PartesTrabajosDiariosMaestros.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PartesTrabajosDiariosMaestros.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PartesTrabajosDiariosMaestros.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_PartesTrabajosDiariosMaestros = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_PartesTrabajosDiariosMaestros
    End Function

    Public Function PartesTrabajosDiariosMaestrosInsert(ByVal dbo_PartesTrabajosDiariosMaestros As DBO_PartesTrabajosDiariosMaestros, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PartesTrabajosDiariosMaestrosInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@EmpleadoID", If(dbo_PartesTrabajosDiariosMaestros.EmpleadoID.HasValue, dbo_PartesTrabajosDiariosMaestros.EmpleadoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_PartesTrabajosDiariosMaestros.Fecha)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PartesTrabajosDiariosMaestros.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PartesTrabajosDiariosMaestros.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PartesTrabajosDiariosMaestros.UsuarioModificacion)

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

    Public Function PartesTrabajosDiariosMaestrosUpdate(ByVal newDBO_PartesTrabajosDiariosMaestros As DBO_PartesTrabajosDiariosMaestros, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PartesTrabajosDiariosMaestrosUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewEmpleadoID", If(newDBO_PartesTrabajosDiariosMaestros.EmpleadoID.HasValue, newDBO_PartesTrabajosDiariosMaestros.EmpleadoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_PartesTrabajosDiariosMaestros.Fecha)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PartesTrabajosDiariosMaestros.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PartesTrabajosDiariosMaestros.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PartesTrabajosDiariosMaestros.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldParteTrabajoDiarioMaestroID", newDBO_PartesTrabajosDiariosMaestros.ParteTrabajoDiarioMaestroID)
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
            MessageBox.Show("Error en UpdatePartesTrabajosDiariosMaestros" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function PartesTrabajosDiariosMaestrosDelete(ByVal ParteTrabajoDiarioMaestroID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[PartesTrabajosDiariosMaestrosDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldParteTrabajoDiarioMaestroID", ParteTrabajoDiarioMaestroID)
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
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GrabarPartesTrabajosDiariosMaestros(ByVal dbo_PartesTrabajosDiariosMaestros As DBO_PartesTrabajosDiariosMaestros, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_PartesTrabajosDiariosMaestros.FechaModificacion = System.DateTime.Now.Date
        dbo_PartesTrabajosDiariosMaestros.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_PartesTrabajosDiariosMaestros.ParteTrabajoDiarioMaestroID = 0 Then
            PartesTrabajosDiariosMaestrosInsert(dbo_PartesTrabajosDiariosMaestros, dtb)
        Else
            PartesTrabajosDiariosMaestrosUpdate(dbo_PartesTrabajosDiariosMaestros, dtb)
        End If
    End Sub

End Class
