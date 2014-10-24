

Class spPedidosClientesMaestros2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosClientesMaestros2Select]", "[dbo].[PedidosClientesMaestros2Insert]", "[dbo].[PedidosClientesMaestros2Update]", _
                   "[dbo].[PedidosClientesMaestros2Delete]", "PedidosClientesMaestros2SelectDgv", "PedidosClientesMaestros2SelectDgvByPedidoClienteMaestroID")
    End Sub

    Public Function Select_Record(ByVal PedidoClienteMaestroID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PedidosClientesMaestros2
        dtb.Conectar()
        Dim DBO_PedidosClientesMaestros2 As New DBO_PedidosClientesMaestros2

        Dim selectProcedure As String = "[dbo].[PedidosClientesMaestros2Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PedidoClienteMaestroID", PedidoClienteMaestroID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_PedidosClientesMaestros2.PedidoClienteMaestroID = If(reader("PedidoClienteMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoClienteMaestroID")))
                DBO_PedidosClientesMaestros2.ClienteID = If(reader("ClienteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ClienteID")))
                DBO_PedidosClientesMaestros2.Numero = If(reader("Numero") Is Convert.DBNull, 0, Convert.ToInt32(reader("Numero")))
                DBO_PedidosClientesMaestros2.FechaEmision = If(reader("FechaEmision") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaEmision")))
                DBO_PedidosClientesMaestros2.FechaServicio = If(reader("FechaServicio") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaServicio")))
                DBO_PedidosClientesMaestros2.Servido = If(reader("Servido") Is Convert.DBNull, False, Convert.ToBoolean(reader("Servido")))
                DBO_PedidosClientesMaestros2.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PedidosClientesMaestros2.NumeroPedidoCliente = If(reader("NumeroPedidoCliente") Is Convert.DBNull, 0, Convert.ToInt32(reader("NumeroPedidoCliente")))
                DBO_PedidosClientesMaestros2.PedidoClienteLugarEntregaID = If(reader("PedidoClienteLugarEntregaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoClienteLugarEntregaID")))
                DBO_PedidosClientesMaestros2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PedidosClientesMaestros2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_PedidosClientesMaestros2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_PedidosClientesMaestros2
    End Function

    Public Function PedidosClientesMaestros2Insert(ByVal dbo_PedidosClientesMaestros2 As DBO_PedidosClientesMaestros2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PedidosClientesMaestros2Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ClienteID", dbo_PedidosClientesMaestros2.ClienteID)
        insertCommand.Parameters.AddWithValue("@Numero", dbo_PedidosClientesMaestros2.Numero)
        insertCommand.Parameters.AddWithValue("@FechaEmision", dbo_PedidosClientesMaestros2.FechaEmision)
        insertCommand.Parameters.AddWithValue("@FechaServicio", If(dbo_PedidosClientesMaestros2.FechaServicio.HasValue, dbo_PedidosClientesMaestros2.FechaServicio, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Servido", dbo_PedidosClientesMaestros2.Servido)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PedidosClientesMaestros2.Observaciones)
        insertCommand.Parameters.AddWithValue("@NumeroPedidoCliente", If(dbo_PedidosClientesMaestros2.NumeroPedidoCliente.HasValue, dbo_PedidosClientesMaestros2.NumeroPedidoCliente, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@PedidoClienteLugarEntregaID", dbo_PedidosClientesMaestros2.PedidoClienteLugarEntregaID)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PedidosClientesMaestros2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PedidosClientesMaestros2.UsuarioModificacion)
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

    Public Function PedidosClientesMaestros2Update(ByVal newDBO_PedidosClientesMaestros2 As DBO_PedidosClientesMaestros2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PedidosClientesMaestros2Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewClienteID", newDBO_PedidosClientesMaestros2.ClienteID)
        updateCommand.Parameters.AddWithValue("@NewNumero", newDBO_PedidosClientesMaestros2.Numero)
        updateCommand.Parameters.AddWithValue("@NewFechaEmision", newDBO_PedidosClientesMaestros2.FechaEmision)
        updateCommand.Parameters.AddWithValue("@NewFechaServicio", If(newDBO_PedidosClientesMaestros2.FechaServicio.HasValue, newDBO_PedidosClientesMaestros2.FechaServicio, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewServido", newDBO_PedidosClientesMaestros2.Servido)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PedidosClientesMaestros2.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewNumeroPedidoCliente", If(newDBO_PedidosClientesMaestros2.NumeroPedidoCliente.HasValue, newDBO_PedidosClientesMaestros2.NumeroPedidoCliente, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewPedidoClienteLugarEntregaID", newDBO_PedidosClientesMaestros2.PedidoClienteLugarEntregaID)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PedidosClientesMaestros2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PedidosClientesMaestros2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPedidoClienteMaestroID", newDBO_PedidosClientesMaestros2.PedidoClienteMaestroID)
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
            MessageBox.Show("Error en UpdatePedidosClientesMaestros2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function PedidosClientesMaestros2Delete(ByVal PedidoClienteMaestroID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[PedidosClientesMaestros2Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPedidoClienteMaestroID", PedidoClienteMaestroID)
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

    Public Function GrabarPedidosClientesMaestros2(ByVal dbo_PedidosClientesMaestros2 As DBO_PedidosClientesMaestros2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If dbo_PedidosClientesMaestros2.PedidoClienteMaestroID = 0 Then
            Return PedidosClientesMaestros2Insert(dbo_PedidosClientesMaestros2, dtb)
        Else
            Return PedidosClientesMaestros2Update(dbo_PedidosClientesMaestros2, dtb)
        End If
    End Function

End Class
