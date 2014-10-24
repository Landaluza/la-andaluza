

Class spPedidosProveedoresDetalles
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosProveedoresDetallesSelect]", "[dbo].[PedidosProveedoresDetallesInsert]", "[dbo].[PedidosProveedoresDetallesUpdate]", _
                   "[dbo].[PedidosProveedoresDetallesDelete]", "PedidosProveedoresDetallesSelectDgv", String.Empty)
    End Sub

    Public Function Select_Record(ByVal PedidoProveedorDetalleID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PedidosProveedoresDetalles
        dtb.Conectar()
        Dim Dbo_PedidosProveedoresDetalles As New DBO_PedidosProveedoresDetalles

        Dim selectProcedure As String = "[dbo].[PedidosProveedoresDetallesSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PedidoProveedorDetalleID", PedidoProveedorDetalleID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PedidosProveedoresDetalles.PedidoProveedorDetalleID = If(reader("PedidoProveedorDetalleID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorDetalleID")))
                Dbo_PedidosProveedoresDetalles.PedidoProveedorMaestroID = If(reader("PedidoProveedorMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorMaestroID")))
                Dbo_PedidosProveedoresDetalles.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                Dbo_PedidosProveedoresDetalles.Cantidad = If(reader("Cantidad") Is Convert.DBNull, 0, Convert.ToDouble(reader("Cantidad")))
                Dbo_PedidosProveedoresDetalles.FechaServicio = If(reader("FechaServicio") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaServicio")))
                Dbo_PedidosProveedoresDetalles.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                Dbo_PedidosProveedoresDetalles.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                Dbo_PedidosProveedoresDetalles.EstadoID = If(reader("EstadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EstadoID")))
                Dbo_PedidosProveedoresDetalles.PedidosProveedoresMaestro_PedidoProveedorMaestroID = If(reader("PedidosProveedoresMaestro_PedidoProveedorMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidosProveedoresMaestro_PedidoProveedorMaestroID")))
                Dbo_PedidosProveedoresDetalles.MedidaProductoID = If(reader("MedidaProductoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MedidaProductoID")))
                Dbo_PedidosProveedoresDetalles.MedidaProductoID_IsDBNull = If(reader("MedidaProductoID") Is Convert.DBNull, True, False)
            Else
                Dbo_PedidosProveedoresDetalles = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return Dbo_PedidosProveedoresDetalles
    End Function

    Public Function InsertPedidosProveedoresDetalles(ByVal dbo_PedidosProveedoresDetalles As DBO_PedidosProveedoresDetalles, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PedidosProveedoresDetallesInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@PedidoProveedorMaestroID", dbo_PedidosProveedoresDetalles.PedidoProveedorMaestroID)
        insertCommand.Parameters.AddWithValue("@ArticuloID", dbo_PedidosProveedoresDetalles.ArticuloID)
        insertCommand.Parameters.AddWithValue("@Cantidad", dbo_PedidosProveedoresDetalles.Cantidad)
        insertCommand.Parameters.AddWithValue("@FechaServicio", dbo_PedidosProveedoresDetalles.FechaServicio)
        insertCommand.Parameters.AddWithValue("@Observaciones", If(dbo_PedidosProveedoresDetalles.Observaciones_IsDBNull = True, Convert.DBNull, dbo_PedidosProveedoresDetalles.Observaciones))
        insertCommand.Parameters.AddWithValue("@EstadoID", dbo_PedidosProveedoresDetalles.EstadoID)
        insertCommand.Parameters.AddWithValue("@PedidosProveedoresMaestro_PedidoProveedorMaestroID", dbo_PedidosProveedoresDetalles.PedidosProveedoresMaestro_PedidoProveedorMaestroID)
        insertCommand.Parameters.AddWithValue("@MedidaProductoID", If(dbo_PedidosProveedoresDetalles.MedidaProductoID_IsDBNull = True, Convert.DBNull, dbo_PedidosProveedoresDetalles.MedidaProductoID))
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

    Public Function UpdatePedidosProveedoresDetalles(ByVal newDbo_PedidosProveedoresDetalles As DBO_PedidosProveedoresDetalles, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PedidosProveedoresDetallesUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewPedidoProveedorMaestroID", newDbo_PedidosProveedoresDetalles.PedidoProveedorMaestroID)
        updateCommand.Parameters.AddWithValue("@NewArticuloID", newDbo_PedidosProveedoresDetalles.ArticuloID)
        updateCommand.Parameters.AddWithValue("@NewCantidad", newDbo_PedidosProveedoresDetalles.Cantidad)
        updateCommand.Parameters.AddWithValue("@NewFechaServicio", newDbo_PedidosProveedoresDetalles.FechaServicio)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", If(newDbo_PedidosProveedoresDetalles.Observaciones_IsDBNull = True, Convert.DBNull, newDbo_PedidosProveedoresDetalles.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewEstadoID", newDbo_PedidosProveedoresDetalles.EstadoID)
        updateCommand.Parameters.AddWithValue("@NewPedidosProveedoresMaestro_PedidoProveedorMaestroID", newDbo_PedidosProveedoresDetalles.PedidosProveedoresMaestro_PedidoProveedorMaestroID)
        updateCommand.Parameters.AddWithValue("@NewMedidaProductoID", If(newDbo_PedidosProveedoresDetalles.MedidaProductoID_IsDBNull = True, Convert.DBNull, newDbo_PedidosProveedoresDetalles.MedidaProductoID))
        updateCommand.Parameters.AddWithValue("@OldPedidoProveedorDetalleID", newDbo_PedidosProveedoresDetalles.PedidoProveedorDetalleID)
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
            MessageBox.Show("Error en UpdatePedidosProveedoresDetalles" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function DeletePedidosProveedoresDetalles(ByVal PedidoProveedorDetalleID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[PedidosProveedoresDetallesDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPedidoProveedorDetalleID", PedidoProveedorDetalleID)
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

End Class
