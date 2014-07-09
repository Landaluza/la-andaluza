

Class spPedidosProveedoresEntregas
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosProveedoresEntregasSelect]", "[dbo].[PedidosProveedoresEntregasInsert]", "[dbo].[PedidosProveedoresEntregasUpdate]", _
                   "[dbo].[PedidosProveedoresEntregasDelete]", "PedidosProveedoresEntregasSelectDgv", String.Empty)
    End Sub

    Public Function Select_Record(ByVal PedidoProveedorEntregaID As Int32) As DBO_PedidosProveedoresEntregas
        BasesParaCompatibilidad.BD.Conectar()
        Dim Dbo_PedidosProveedoresEntregas As New DBO_PedidosProveedoresEntregas
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PedidosProveedoresEntregasSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PedidoProveedorEntregaID", PedidoProveedorEntregaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PedidosProveedoresEntregas.PedidoProveedorEntregaID = If(reader("PedidoProveedorEntregaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorEntregaID")))
                Dbo_PedidosProveedoresEntregas.PedidoProveedorDetalleID = If(reader("PedidoProveedorDetalleID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorDetalleID")))
                Dbo_PedidosProveedoresEntregas.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                Dbo_PedidosProveedoresEntregas.Cantidad = If(reader("Cantidad") Is Convert.DBNull, 0, Convert.ToDouble(reader("Cantidad")))
                Dbo_PedidosProveedoresEntregas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                Dbo_PedidosProveedoresEntregas.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                Dbo_PedidosProveedoresEntregas.PedidosProveedoresDetalle_PedidoProveedorDetalleID = If(reader("PedidosProveedoresDetalle_PedidoProveedorDetalleID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidosProveedoresDetalle_PedidoProveedorDetalleID")))
            Else
                Dbo_PedidosProveedoresEntregas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return Dbo_PedidosProveedoresEntregas
    End Function

    Public Function InsertPedidosProveedoresEntregas(ByVal dbo_PedidosProveedoresEntregas As DBO_PedidosProveedoresEntregas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[PedidosProveedoresEntregasInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@PedidoProveedorDetalleID", dbo_PedidosProveedoresEntregas.PedidoProveedorDetalleID)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_PedidosProveedoresEntregas.Fecha)
        insertCommand.Parameters.AddWithValue("@Cantidad", dbo_PedidosProveedoresEntregas.Cantidad)
        insertCommand.Parameters.AddWithValue("@Observaciones", if(dbo_PedidosProveedoresEntregas.Observaciones_IsDBNull = True, Convert.DBNull, dbo_PedidosProveedoresEntregas.Observaciones))
        insertCommand.Parameters.AddWithValue("@PedidosProveedoresDetalle_PedidoProveedorDetalleID", dbo_PedidosProveedoresEntregas.PedidosProveedoresDetalle_PedidoProveedorDetalleID)
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

    Public Function UpdatePedidosProveedoresEntregas(ByVal newDbo_PedidosProveedoresEntregas As DBO_PedidosProveedoresEntregas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PedidosProveedoresEntregasUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewPedidoProveedorDetalleID", newDbo_PedidosProveedoresEntregas.PedidoProveedorDetalleID)
        updateCommand.Parameters.AddWithValue("@NewFecha", newDbo_PedidosProveedoresEntregas.Fecha)
        updateCommand.Parameters.AddWithValue("@NewCantidad", newDbo_PedidosProveedoresEntregas.Cantidad)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", if(newDbo_PedidosProveedoresEntregas.Observaciones_IsDBNull = True, Convert.DBNull, newDbo_PedidosProveedoresEntregas.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewPedidosProveedoresDetalle_PedidoProveedorDetalleID", newDbo_PedidosProveedoresEntregas.PedidosProveedoresDetalle_PedidoProveedorDetalleID)
        updateCommand.Parameters.AddWithValue("@OldPedidoProveedorEntregaID", newDbo_PedidosProveedoresEntregas.PedidoProveedorEntregaID)
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
            MessageBox.Show("Error en UpdatePedidosProveedoresEntregas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function DeletePedidosProveedoresEntregas(ByVal PedidoProveedorEntregaID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[PedidosProveedoresEntregasDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPedidoProveedorEntregaID", PedidoProveedorEntregaID)
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

End Class
