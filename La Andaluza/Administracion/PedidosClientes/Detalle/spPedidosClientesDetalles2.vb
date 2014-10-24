

Class spPedidosClientesDetalles2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosClientesDetalles2Select]", "[dbo].[PedidosClientesDetalles2Insert]", "[dbo].[PedidosClientesDetalles2Update]", _
                   "[dbo].[PedidosClientesDetalles2Delete]", "PedidosClientesDetalles2SelectDgv", "PedidosClientesDetalles2SelectDgvByPedidoClienteDatalleID")
    End Sub

    Public Function Select_Record(ByVal PedidoClienteDatalleID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PedidosClientesDetalles2
        dtb.Conectar()
        Dim DBO_PedidosClientesDetalles2 As New DBO_PedidosClientesDetalles2

        Dim selectProcedure As String = "[dbo].[PedidosClientesDetalles2Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PedidoClienteDatalleID", PedidoClienteDatalleID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_PedidosClientesDetalles2.PedidoClienteDatalleID = If(reader("PedidoClienteDatalleID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoClienteDatalleID")))
                DBO_PedidosClientesDetalles2.PedidoclienteMaestroID = If(reader("PedidoclienteMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoclienteMaestroID")))
                DBO_PedidosClientesDetalles2.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_PedidosClientesDetalles2.Cantidad = If(reader("Cantidad") Is Convert.DBNull, 0, Convert.ToInt32(reader("Cantidad")))
                DBO_PedidosClientesDetalles2.Servido = If(reader("Servido") Is Convert.DBNull, False, Convert.ToBoolean(reader("Servido")))
                DBO_PedidosClientesDetalles2.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PedidosClientesDetalles2.FechaServicio = If(reader("FechaServicio") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaServicio")))
                DBO_PedidosClientesDetalles2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PedidosClientesDetalles2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_PedidosClientesDetalles2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_PedidosClientesDetalles2
    End Function

    Public Function PedidosClientesDetalles2Insert(ByVal dbo_PedidosClientesDetalles2 As DBO_PedidosClientesDetalles2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PedidosClientesDetalles2Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@PedidoclienteMaestroID", dbo_PedidosClientesDetalles2.PedidoclienteMaestroID)
        insertCommand.Parameters.AddWithValue("@ArticuloID", dbo_PedidosClientesDetalles2.ArticuloID)
        insertCommand.Parameters.AddWithValue("@Cantidad", dbo_PedidosClientesDetalles2.Cantidad)
        insertCommand.Parameters.AddWithValue("@Servido", dbo_PedidosClientesDetalles2.Servido)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PedidosClientesDetalles2.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaServicio", If(dbo_PedidosClientesDetalles2.FechaServicio.HasValue, dbo_PedidosClientesDetalles2.FechaServicio, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PedidosClientesDetalles2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PedidosClientesDetalles2.UsuarioModificacion)
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

    Public Function PedidosClientesDetalles2Update(ByVal newDBO_PedidosClientesDetalles2 As DBO_PedidosClientesDetalles2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PedidosClientesDetalles2Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewPedidoclienteMaestroID", newDBO_PedidosClientesDetalles2.PedidoclienteMaestroID)
        updateCommand.Parameters.AddWithValue("@NewArticuloID", newDBO_PedidosClientesDetalles2.ArticuloID)
        updateCommand.Parameters.AddWithValue("@NewCantidad", newDBO_PedidosClientesDetalles2.Cantidad)
        updateCommand.Parameters.AddWithValue("@NewServido", newDBO_PedidosClientesDetalles2.Servido)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PedidosClientesDetalles2.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaServicio", If(newDBO_PedidosClientesDetalles2.FechaServicio.HasValue, newDBO_PedidosClientesDetalles2.FechaServicio, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PedidosClientesDetalles2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PedidosClientesDetalles2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPedidoClienteDatalleID", newDBO_PedidosClientesDetalles2.PedidoClienteDatalleID)
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
            MessageBox.Show("Error en UpdatePedidosClientesDetalles2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function PedidosClientesDetalles2Delete(ByVal PedidoClienteDatalleID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[PedidosClientesDetalles2Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPedidoClienteDatalleID", PedidoClienteDatalleID)
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

    Public Sub GrabarPedidosClientesDetalles2(ByVal dbo_PedidosClientesDetalles2 As DBO_PedidosClientesDetalles2, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_PedidosClientesDetalles2.PedidoClienteDatalleID = 0 Then
            PedidosClientesDetalles2Insert(dbo_PedidosClientesDetalles2, dtb)
        Else
            PedidosClientesDetalles2Update(dbo_PedidosClientesDetalles2, dtb)
        End If
    End Sub

End Class
