

Class spPedidosClientesDocumentos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PedidosClientesDocumentosSelect]", "[dbo].[PedidosClientesDocumentosInsert]", "[dbo].[PedidosClientesDocumentosUpdate]", _
                   "[dbo].[PedidosClientesDocumentosDelete]", "PedidosClientesDocumentosSelectDgv", "PedidosClientesDocumentosSelectDgvByPedidoClienteMaestroID")
    End Sub

    Public Function Select_Record(ByVal PedidoClienteDocumentoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PedidosClientesDocumentos
        dtb.Conectar()
        Dim DBO_PedidosClientesDocumentos As New DBO_PedidosClientesDocumentos

        Dim selectProcedure As String = "[dbo].[PedidosClientesDocumentosSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PedidoClienteDocumentoID", PedidoClienteDocumentoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_PedidosClientesDocumentos.PedidoClienteDocumentoID = If(reader("PedidoClienteDocumentoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoClienteDocumentoID")))
                DBO_PedidosClientesDocumentos.PedidoClienteMaestroID = If(reader("PedidoClienteMaestroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PedidoClienteMaestroID")))
                DBO_PedidosClientesDocumentos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_PedidosClientesDocumentos.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_PedidosClientesDocumentos.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_PedidosClientesDocumentos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PedidosClientesDocumentos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PedidosClientesDocumentos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_PedidosClientesDocumentos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_PedidosClientesDocumentos
    End Function

    Public Function PedidosClientesDocumentosInsert(ByVal dbo_PedidosClientesDocumentos As DBO_PedidosClientesDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PedidosClientesDocumentosInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@PedidoClienteMaestroID", If(dbo_PedidosClientesDocumentos.PedidoClienteMaestroID.HasValue, dbo_PedidosClientesDocumentos.PedidoClienteMaestroID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_PedidosClientesDocumentos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_PedidosClientesDocumentos.Ruta)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_PedidosClientesDocumentos.Fecha)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PedidosClientesDocumentos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PedidosClientesDocumentos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PedidosClientesDocumentos.UsuarioModificacion)
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

    Public Function PedidosClientesDocumentosUpdate(ByVal newDBO_PedidosClientesDocumentos As DBO_PedidosClientesDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PedidosClientesDocumentosUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewPedidoClienteMaestroID", If(newDBO_PedidosClientesDocumentos.PedidoClienteMaestroID.HasValue, newDBO_PedidosClientesDocumentos.PedidoClienteMaestroID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_PedidosClientesDocumentos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_PedidosClientesDocumentos.Ruta)
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_PedidosClientesDocumentos.Fecha)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PedidosClientesDocumentos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PedidosClientesDocumentos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PedidosClientesDocumentos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPedidoClienteDocumentoID", newDBO_PedidosClientesDocumentos.PedidoClienteDocumentoID)
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
            MessageBox.Show("Error en UpdatePedidosClientesDocumentos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function PedidosClientesDocumentosDelete(ByVal PedidoClienteDocumentoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[PedidosClientesDocumentosDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPedidoClienteDocumentoID", PedidoClienteDocumentoID)
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

    Public Sub GrabarPedidosClientesDocumentos(ByVal dbo_PedidosClientesDocumentos As DBO_PedidosClientesDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_PedidosClientesDocumentos.PedidoClienteDocumentoID = 0 Then
            PedidosClientesDocumentosInsert(dbo_PedidosClientesDocumentos, dtb)
        Else
            PedidosClientesDocumentosUpdate(dbo_PedidosClientesDocumentos, dtb)
        End If
    End Sub

End Class
