

Class spEnvasadosProductosAnaliticas2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EnvasadosProductosAnaliticasSelect]", "[dbo].[EnvasadosProductosAnaliticasInsert]", "[dbo].[EnvasadosProductosAnaliticasUpdate]", _
                   "[dbo].[EnvasadosProductosAnaliticasDelete]", "EnvasadosProductosAnaliticasSelectDgv", "EnvasadosProductosAnaliticasSelectDgvByEnvasadoProductoID")
    End Sub
    Public Function Select_Record(ByVal EnvasadoProductoAnaliticaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_EnvasadosProductosAnaliticas2
        dtb.Conectar()
        Dim DBO_EnvasadosProductosAnaliticas As New DBO_EnvasadosProductosAnaliticas2

        Dim selectProcedure As String = "[dbo].[EnvasadosProductosAnaliticasSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoProductoAnaliticaID", EnvasadoProductoAnaliticaID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_EnvasadosProductosAnaliticas.EnvasadoProductoAnaliticaID = If(reader("EnvasadoProductoAnaliticaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoProductoAnaliticaID")))
                DBO_EnvasadosProductosAnaliticas.EnvasadoProductoID = If(reader("EnvasadoProductoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoProductoID")))
                DBO_EnvasadosProductosAnaliticas.ParametroID = If(reader("ParametroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ParametroID")))
                DBO_EnvasadosProductosAnaliticas.AnalistaID = If(reader("AnalistaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("AnalistaID")))
                DBO_EnvasadosProductosAnaliticas.Valor = If(reader("Valor") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("Valor")))
                DBO_EnvasadosProductosAnaliticas.Hora = If(reader("Hora") Is Convert.DBNull, System.DateTime.Now.TimeOfDay, reader("Hora"))
                DBO_EnvasadosProductosAnaliticas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_EnvasadosProductosAnaliticas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosProductosAnaliticas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_EnvasadosProductosAnaliticas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_EnvasadosProductosAnaliticas
    End Function

    Public Function EnvasadosProductosAnaliticasInsert(ByVal dbo_EnvasadosProductosAnaliticas As DBO_EnvasadosProductosAnaliticas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[EnvasadosProductosAnaliticasInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@EnvasadoProductoID", If(dbo_EnvasadosProductosAnaliticas.EnvasadoProductoID.HasValue, dbo_EnvasadosProductosAnaliticas.EnvasadoProductoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@ParametroID", If(dbo_EnvasadosProductosAnaliticas.ParametroID.HasValue, dbo_EnvasadosProductosAnaliticas.ParametroID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@AnalistaID", If(dbo_EnvasadosProductosAnaliticas.AnalistaID.HasValue, dbo_EnvasadosProductosAnaliticas.AnalistaID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Valor", If(dbo_EnvasadosProductosAnaliticas.Valor.HasValue, dbo_EnvasadosProductosAnaliticas.Valor, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Hora", dbo_EnvasadosProductosAnaliticas.Hora)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_EnvasadosProductosAnaliticas.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_EnvasadosProductosAnaliticas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_EnvasadosProductosAnaliticas.UsuarioModificacion)
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

    Public Function EnvasadosProductosAnaliticasUpdate(ByVal newDBO_EnvasadosProductosAnaliticas As DBO_EnvasadosProductosAnaliticas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[EnvasadosProductosAnaliticasUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewEnvasadoProductoID", If(newDBO_EnvasadosProductosAnaliticas.EnvasadoProductoID.HasValue, newDBO_EnvasadosProductosAnaliticas.EnvasadoProductoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewParametroID", If(newDBO_EnvasadosProductosAnaliticas.ParametroID.HasValue, newDBO_EnvasadosProductosAnaliticas.ParametroID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewAnalistaID", If(newDBO_EnvasadosProductosAnaliticas.AnalistaID.HasValue, newDBO_EnvasadosProductosAnaliticas.AnalistaID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewValor", If(newDBO_EnvasadosProductosAnaliticas.Valor.HasValue, newDBO_EnvasadosProductosAnaliticas.Valor, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewHora", newDBO_EnvasadosProductosAnaliticas.Hora)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_EnvasadosProductosAnaliticas.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_EnvasadosProductosAnaliticas.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_EnvasadosProductosAnaliticas.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldEnvasadoProductoAnaliticaID", newDBO_EnvasadosProductosAnaliticas.EnvasadoProductoAnaliticaID)
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
            MessageBox.Show("Error en UpdateEnvasadosProductosAnaliticas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function EnvasadosProductosAnaliticasDelete(ByVal EnvasadoProductoAnaliticaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Try
            Dim deleteProcedure As String = "[dbo].[EnvasadosProductosAnaliticasDelete]"
            Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@OldEnvasadoProductoAnaliticaID", EnvasadoProductoAnaliticaID)
            deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

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

    Public Function GrabarEnvasadosProductosAnaliticas(ByVal dbo_EnvasadosProductosAnaliticas As DBO_EnvasadosProductosAnaliticas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_EnvasadosProductosAnaliticas.FechaModificacion = System.DateTime.Now.Date
        dbo_EnvasadosProductosAnaliticas.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_EnvasadosProductosAnaliticas.EnvasadoProductoAnaliticaID = 0 Then
            Return EnvasadosProductosAnaliticasInsert(dbo_EnvasadosProductosAnaliticas, dtb)
        Else
            Return EnvasadosProductosAnaliticasUpdate(dbo_EnvasadosProductosAnaliticas, dtb)
        End If
    End Function

End Class
