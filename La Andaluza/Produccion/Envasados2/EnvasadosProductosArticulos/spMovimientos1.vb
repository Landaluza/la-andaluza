

Class spMovimientos1
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[Movimientos1Select]", "[dbo].[Movimientos1Insert]", "[dbo].[Movimientos1Update]", _
                   "[dbo].[Movimientos1Delete]", String.Empty, String.Empty)
    End Sub

    Public Function Select_Record(ByVal MovimientoID As Int32) As DBO_Movimientos1
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_Movimientos1 As New DBO_Movimientos1
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Movimientos1Select]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@MovimientoID", MovimientoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_Movimientos1.MovimientoID = If(reader("MovimientoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MovimientoID")))
                DBO_Movimientos1.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_Movimientos1.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_Movimientos1.Cantidad = System.Convert.ToDouble(If(reader("Cantidad") Is Convert.DBNull, 0, reader("Cantidad")))
                DBO_Movimientos1.ProcesoID = If(reader("ProcesoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProcesoID")))
                DBO_Movimientos1.EntraDepositoID = If(reader("EntraDepositoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EntraDepositoID")))
                DBO_Movimientos1.SaleDepositoID = If(reader("SaleDepositoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("SaleDepositoID")))
                DBO_Movimientos1.LoteID = If(reader("LoteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("LoteID")))
                DBO_Movimientos1.FiltroID = If(reader("FiltroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FiltroID")))
                DBO_Movimientos1.Suma = If(reader("Suma") Is Convert.DBNull, False, Convert.ToBoolean(reader("Suma")))
                DBO_Movimientos1.NuevoLote = If(reader("NuevoLote") Is Convert.DBNull, False, Convert.ToBoolean(reader("NuevoLote")))
                DBO_Movimientos1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Movimientos1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_Movimientos1 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_Movimientos1
    End Function

    Public Function Movimientos1Insert(ByVal dbo_Movimientos1 As DBO_Movimientos1, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[Movimientos1Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        If Not trans Is Nothing Then insertCommand.Transaction = trans
        
        insertCommand.Parameters.AddWithValue("@Fecha", if(dbo_Movimientos1.Fecha.HasValue, dbo_Movimientos1.Fecha, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Observaciones", if(String.IsNullOrEmpty(dbo_Movimientos1.Observaciones), Convert.DBNull, dbo_Movimientos1.Observaciones))
        insertCommand.Parameters.AddWithValue("@Cantidad", dbo_Movimientos1.Cantidad)
        insertCommand.Parameters.AddWithValue("@ProcesoID", dbo_Movimientos1.ProcesoID)
        insertCommand.Parameters.AddWithValue("@EntraDepositoID", if(dbo_Movimientos1.EntraDepositoID.HasValue, dbo_Movimientos1.EntraDepositoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@SaleDepositoID", if(dbo_Movimientos1.SaleDepositoID.HasValue, dbo_Movimientos1.SaleDepositoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@LoteID", if(dbo_Movimientos1.LoteID.HasValue, dbo_Movimientos1.LoteID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FiltroID", if(dbo_Movimientos1.FiltroID.HasValue, dbo_Movimientos1.FiltroID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Suma", if(dbo_Movimientos1.Suma.HasValue, dbo_Movimientos1.Suma, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@NuevoLote", if(dbo_Movimientos1.NuevoLote.HasValue, dbo_Movimientos1.NuevoLote, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", System.DateTime.Now)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
        
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
            Return False
        Finally
            If trans Is Nothing Then connection.Close()
        End Try
    End Function

    Public Function Movimientos1Update(ByVal newDBO_Movimientos1 As DBO_Movimientos1, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[Movimientos1Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        If Not trans Is Nothing Then updateCommand.Transaction = trans
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewFecha", if(newDBO_Movimientos1.Fecha.HasValue, newDBO_Movimientos1.Fecha, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_Movimientos1.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewCantidad", newDBO_Movimientos1.Cantidad)
        updateCommand.Parameters.AddWithValue("@NewProcesoID", newDBO_Movimientos1.ProcesoID)
        updateCommand.Parameters.AddWithValue("@NewEntraDepositoID", if(newDBO_Movimientos1.EntraDepositoID.HasValue, newDBO_Movimientos1.EntraDepositoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewSaleDepositoID", if(newDBO_Movimientos1.SaleDepositoID.HasValue, newDBO_Movimientos1.SaleDepositoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewLoteID", if(newDBO_Movimientos1.LoteID.HasValue, newDBO_Movimientos1.LoteID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFiltroID", if(newDBO_Movimientos1.FiltroID.HasValue, newDBO_Movimientos1.FiltroID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewSuma", if(newDBO_Movimientos1.Suma.HasValue, newDBO_Movimientos1.Suma, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewNuevoLote", if(newDBO_Movimientos1.NuevoLote.HasValue, newDBO_Movimientos1.NuevoLote, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_Movimientos1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_Movimientos1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldMovimientoID", newDBO_Movimientos1.MovimientoID)
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
            MessageBox.Show("Error en UpdateMovimientos1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            If trans Is Nothing Then connection.Close()
        End Try
    End Function

    Public Function Movimientos1Delete(ByVal MovimientoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[Movimientos1Delete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldMovimientoID", MovimientoID)
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

    Public Function GrabarMovimientos1(ByVal dbo_Movimientos1 As DBO_Movimientos1, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        dbo_Movimientos1.FechaModificacion = System.DateTime.Now.date
        dbo_Movimientos1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_Movimientos1.MovimientoID = 0 Then
            Return Movimientos1Insert(dbo_Movimientos1, trans)
        Else
            Return Movimientos1Update(dbo_Movimientos1, trans)
        End If
    End Function

End Class
