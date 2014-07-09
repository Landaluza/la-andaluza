

Class spProveedores_ProveedoresTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[Proveedores_ProveedoresTiposSelect]", "[dbo].[Proveedores_ProveedoresTiposInsert2]", _
                   "[dbo].[Proveedores_ProveedoresTiposUpdate2]", "[dbo].[Proveedores_ProveedoresTiposDeleteByProveedorID2]", _
                   "Proveedores_ProveedoresTiposSelectDgv", "Proveedores_ProveedoresTiposSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal Proveedor_ProveedorTipoID As Int32) As DBO_Proveedores_ProveedoresTipos
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_Proveedores_ProveedoresTipos As New DBO_Proveedores_ProveedoresTipos
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Proveedores_ProveedoresTiposSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@Proveedor_ProveedorTipoID", Proveedor_ProveedorTipoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_Proveedores_ProveedoresTipos.Proveedor_ProveedorTipoID = If(reader("Proveedor_ProveedorTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("Proveedor_ProveedorTipoID")))
                DBO_Proveedores_ProveedoresTipos.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                DBO_Proveedores_ProveedoresTipos.ProveedorTipoID = If(reader("ProveedorTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorTipoID")))
                DBO_Proveedores_ProveedoresTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Proveedores_ProveedoresTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_Proveedores_ProveedoresTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_Proveedores_ProveedoresTipos
    End Function

    Public Function Proveedores_ProveedoresTiposInsert(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[Proveedores_ProveedoresTiposInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ProveedorID", If(dbo_Proveedores_ProveedoresTipos.ProveedorID.HasValue, dbo_Proveedores_ProveedoresTipos.ProveedorID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@ProveedorTipoID", If(dbo_Proveedores_ProveedoresTipos.ProveedorTipoID.HasValue, dbo_Proveedores_ProveedoresTipos.ProveedorTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_Proveedores_ProveedoresTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_Proveedores_ProveedoresTipos.UsuarioModificacion)
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

    Public Function Proveedores_ProveedoresTiposUpdate(ByVal newDBO_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[Proveedores_ProveedoresTiposUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewProveedorID", If(newDBO_Proveedores_ProveedoresTipos.ProveedorID.HasValue, newDBO_Proveedores_ProveedoresTipos.ProveedorID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewProveedorTipoID", If(newDBO_Proveedores_ProveedoresTipos.ProveedorTipoID.HasValue, newDBO_Proveedores_ProveedoresTipos.ProveedorTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_Proveedores_ProveedoresTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_Proveedores_ProveedoresTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldProveedor_ProveedorTipoID", newDBO_Proveedores_ProveedoresTipos.Proveedor_ProveedorTipoID)
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
            MessageBox.Show("Error en UpdateProveedores_ProveedoresTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposInsertSinTransaccion(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef mytrans as System.Data.SqlClient.SqlTransaction) As Boolean
        Try
            Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
            Dim insertProcedure As String = "[dbo].[Proveedores_ProveedoresTiposInsert2]"
            Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
            insertCommand.Transaction = mytrans
            insertCommand.CommandType = CommandType.StoredProcedure
            insertCommand.Parameters.AddWithValue("@ProveedorID", If(dbo_Proveedores_ProveedoresTipos.ProveedorID.HasValue, dbo_Proveedores_ProveedoresTipos.ProveedorID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@ProveedorTipoID", If(dbo_Proveedores_ProveedoresTipos.ProveedorTipoID.HasValue, dbo_Proveedores_ProveedoresTipos.ProveedorTipoID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_Proveedores_ProveedoresTipos.FechaModificacion)
            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_Proveedores_ProveedoresTipos.UsuarioModificacion)


            insertCommand.ExecuteNonQuery()
           
                Return True
       
        Catch ex As System.Data.SqlClient.SqlException
            Return False     
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposUpdateSinTransaccion(ByVal newDBO_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef mytrans as System.Data.SqlClient.SqlTransaction) As Boolean
        Try

            Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
            Dim updateProcedure As String = "[dbo].[Proveedores_ProveedoresTiposUpdate2]"
            Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
            updateCommand.CommandType = CommandType.StoredProcedure
            updateCommand.Transaction = mytrans
            updateCommand.Parameters.AddWithValue("@NewProveedorID", If(newDBO_Proveedores_ProveedoresTipos.ProveedorID.HasValue, newDBO_Proveedores_ProveedoresTipos.ProveedorID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewProveedorTipoID", If(newDBO_Proveedores_ProveedoresTipos.ProveedorTipoID.HasValue, newDBO_Proveedores_ProveedoresTipos.ProveedorTipoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_Proveedores_ProveedoresTipos.FechaModificacion)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_Proveedores_ProveedoresTipos.UsuarioModificacion)
            updateCommand.Parameters.AddWithValue("@OldProveedor_ProveedorTipoID", newDBO_Proveedores_ProveedoresTipos.Proveedor_ProveedorTipoID)
            updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
            updateCommand.ExecuteNonQuery()

            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)

            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
            MessageBox.Show("Error en UpdateProveedores_ProveedoresTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposDelete(ByVal Proveedor_ProveedorTipoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[Proveedores_ProveedoresTiposDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldProveedor_ProveedorTipoID", Proveedor_ProveedorTipoID)
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

    Public Function Proveedores_ProveedoresTiposDeleteByProveedorID(ByVal ProveedorID As Int32, Optional ByRef mytrans as System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        If mytrans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[Proveedores_ProveedoresTiposDeleteByProveedorID3]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        If Not mytrans Is Nothing Then deleteCommand.Transaction = mytrans
        deleteCommand.Parameters.AddWithValue("@OldProveedorID", ProveedorID)
        Try
            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            If mytrans Is Nothing Then connection.Close()
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposDeleteByProveedorIDSinTransaccion(ByVal ProveedorID As Int32, ByRef mytrans As SqlClient.SqlTransaction) As Boolean
        Try
            Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
            Dim deleteProcedure As String = "[dbo].[Proveedores_ProveedoresTiposDeleteByProveedorID2]"
            Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Transaction = mytrans
            deleteCommand.Parameters.AddWithValue("@OldProveedorID", ProveedorID)
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
            Return False
            Throw
        End Try
    End Function

    Public Sub GrabarProveedores_ProveedoresTipos(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos)
        If dbo_Proveedores_ProveedoresTipos.Proveedor_ProveedorTipoID = 0 Then
            Proveedores_ProveedoresTiposInsert(dbo_Proveedores_ProveedoresTipos)
        Else
            Proveedores_ProveedoresTiposUpdate(dbo_Proveedores_ProveedoresTipos)
        End If
    End Sub

    Public Function GrabarProveedores_ProveedoresTiposSinTransaccion(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef mytrans As SqlClient.SqlTransaction) As Boolean
        If dbo_Proveedores_ProveedoresTipos.Proveedor_ProveedorTipoID = 0 Then
            Return Proveedores_ProveedoresTiposInsertSinTransaccion(dbo_Proveedores_ProveedoresTipos, mytrans)
        Else
            Return Proveedores_ProveedoresTiposUpdateSinTransaccion(dbo_Proveedores_ProveedoresTipos, mytrans)
        End If
    End Function

End Class
