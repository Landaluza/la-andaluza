

Class spPedidosProveedoresDocumentos1
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosProveedoresDocumentos1Select]", "[dbo].[PedidosProveedoresDocumentos1Insert]", "[dbo].[PedidosProveedoresDocumentos1Update]", _
                    "[dbo].[PedidosProveedoresDocumentos1Delete]", "PedidosProveedoresDocumentos1SelectDgv", "PedidosProveedoresDocumentos1SelectDgvByPedidoProveedorMaestroID")
    End Sub

    Public Function Select_Record(ByVal PedidoProveedorDocumentoID As Int32) As DBO_PedidosProveedoresDocumentos1
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_PedidosProveedoresDocumentos1 As New DBO_PedidosProveedoresDocumentos1
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PedidosProveedoresDocumentos1Select]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PedidoProveedorDocumentoID", PedidoProveedorDocumentoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_PedidosProveedoresDocumentos1.PedidoProveedorDocumentoID = If(reader("PedidoProveedorDocumentoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorDocumentoID")))
                DBO_PedidosProveedoresDocumentos1.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_PedidosProveedoresDocumentos1.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_PedidosProveedoresDocumentos1.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_PedidosProveedoresDocumentos1.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID = If(reader("PedidoProveedorMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoProveedorMaestroID")))
                DBO_PedidosProveedoresDocumentos1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PedidosProveedoresDocumentos1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_PedidosProveedoresDocumentos1 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_PedidosProveedoresDocumentos1
    End Function

    Public Function PedidosProveedoresDocumentos1Insert(ByVal dbo_PedidosProveedoresDocumentos1 As DBO_PedidosProveedoresDocumentos1) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[PedidosProveedoresDocumentos1Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_PedidosProveedoresDocumentos1.Descripcion)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_PedidosProveedoresDocumentos1.Ruta)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_PedidosProveedoresDocumentos1.Fecha)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PedidosProveedoresDocumentos1.Observaciones)
        insertCommand.Parameters.AddWithValue("@PedidoProveedorMaestroID", dbo_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PedidosProveedoresDocumentos1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PedidosProveedoresDocumentos1.UsuarioModificacion)
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

    Public Function PedidosProveedoresDocumentos1Update(ByVal newDBO_PedidosProveedoresDocumentos1 As DBO_PedidosProveedoresDocumentos1) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PedidosProveedoresDocumentos1Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_PedidosProveedoresDocumentos1.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_PedidosProveedoresDocumentos1.Ruta)
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_PedidosProveedoresDocumentos1.Fecha)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PedidosProveedoresDocumentos1.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewPedidoProveedorMaestroID", newDBO_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PedidosProveedoresDocumentos1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PedidosProveedoresDocumentos1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPedidoProveedorDocumentoID", newDBO_PedidosProveedoresDocumentos1.PedidoProveedorDocumentoID)
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
            MessageBox.Show("Error en UpdatePedidosProveedoresDocumentos1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function PedidosProveedoresDocumentos1Delete(ByVal PedidoProveedorDocumentoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[PedidosProveedoresDocumentos1Delete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPedidoProveedorDocumentoID", PedidoProveedorDocumentoID)
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

    Public Sub GrabarPedidosProveedoresDocumentos1(ByVal dbo_PedidosProveedoresDocumentos1 As DBO_PedidosProveedoresDocumentos1)
        If dbo_PedidosProveedoresDocumentos1.PedidoProveedorDocumentoID = 0 Then
            PedidosProveedoresDocumentos1Insert(dbo_PedidosProveedoresDocumentos1)
        Else
            PedidosProveedoresDocumentos1Update(dbo_PedidosProveedoresDocumentos1)
        End If
    End Sub

End Class
