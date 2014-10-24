

Class spProveedores_ProveedoresTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[Proveedores_ProveedoresTiposSelect]", "[dbo].[Proveedores_ProveedoresTiposInsert2]", _
                   "[dbo].[Proveedores_ProveedoresTiposUpdate2]", "[dbo].[Proveedores_ProveedoresTiposDeleteByProveedorID2]", _
                   "Proveedores_ProveedoresTiposSelectDgv", "Proveedores_ProveedoresTiposSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal Proveedor_ProveedorTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Proveedores_ProveedoresTipos
        dtb.Conectar()
        Dim DBO_Proveedores_ProveedoresTipos As New DBO_Proveedores_ProveedoresTipos

        Dim selectProcedure As String = "[dbo].[Proveedores_ProveedoresTiposSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
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
            dtb.Desconectar()
        End Try
        Return DBO_Proveedores_ProveedoresTipos
    End Function

    Public Function Proveedores_ProveedoresTiposInsert(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[Proveedores_ProveedoresTiposInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
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
            dtb.Desconectar()
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposUpdate(ByVal newDBO_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[Proveedores_ProveedoresTiposUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
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
            MessageBox.Show("Error en UpdateProveedores_ProveedoresTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposInsertSinTransaccion(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try

            Dim insertProcedure As String = "[dbo].[Proveedores_ProveedoresTiposInsert2]"
            Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)

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

    Public Function Proveedores_ProveedoresTiposUpdateSinTransaccion(ByVal newDBO_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try


            Dim updateProcedure As String = "[dbo].[Proveedores_ProveedoresTiposUpdate2]"
            Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
            updateCommand.CommandType = CommandType.StoredProcedure

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
            MessageBox.Show("Error en UpdateProveedores_ProveedoresTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposDelete(ByVal Proveedor_ProveedorTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[Proveedores_ProveedoresTiposDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
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
            dtb.Desconectar()
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposDeleteByProveedorID(ByVal ProveedorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[Proveedores_ProveedoresTiposDeleteByProveedorID3]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure

        deleteCommand.Parameters.AddWithValue("@OldProveedorID", ProveedorID)
        Try
            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Proveedores_ProveedoresTiposDeleteByProveedorIDSinTransaccion(ByVal ProveedorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try

            Dim deleteProcedure As String = "[dbo].[Proveedores_ProveedoresTiposDeleteByProveedorID2]"
            Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(deleteProcedure)
            deleteCommand.CommandType = CommandType.StoredProcedure

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

    Public Sub GrabarProveedores_ProveedoresTipos(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_Proveedores_ProveedoresTipos.Proveedor_ProveedorTipoID = 0 Then
            Proveedores_ProveedoresTiposInsert(dbo_Proveedores_ProveedoresTipos, dtb)
        Else
            Proveedores_ProveedoresTiposUpdate(dbo_Proveedores_ProveedoresTipos, dtb)
        End If
    End Sub

    Public Function GrabarProveedores_ProveedoresTiposSinTransaccion(ByVal dbo_Proveedores_ProveedoresTipos As DBO_Proveedores_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If dbo_Proveedores_ProveedoresTipos.Proveedor_ProveedorTipoID = 0 Then
            Return Proveedores_ProveedoresTiposInsertSinTransaccion(dbo_Proveedores_ProveedoresTipos, dtb)
        Else
            Return Proveedores_ProveedoresTiposUpdateSinTransaccion(dbo_Proveedores_ProveedoresTipos, dtb)
        End If
    End Function

End Class
