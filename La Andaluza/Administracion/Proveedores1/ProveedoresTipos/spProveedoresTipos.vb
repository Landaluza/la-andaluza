

Class spProveedoresTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ProveedoresTiposSelect]", "[dbo].[ProveedoresTiposInsert]", _
                  "[dbo].[ProveedoresTiposUpdate]", "[dbo].[ProveedoresTiposDelete]", _
                  "ProveedoresTiposSelectDgv", "ProveedoresTiposSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal ProveedorTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ProveedoresTipos
        dtb.Conectar()
        Dim DBO_ProveedoresTipos As New DBO_ProveedoresTipos

        Dim selectProcedure As String = "[dbo].[ProveedoresTiposSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ProveedorTipoID", ProveedorTipoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ProveedoresTipos.ProveedorTipoID = If(reader("ProveedorTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorTipoID")))
                DBO_ProveedoresTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ProveedoresTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ProveedoresTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ProveedoresTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ProveedoresTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ProveedoresTipos
    End Function

    Public Function ProveedoresTiposInsert(ByVal dbo_ProveedoresTipos As DBO_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ProveedoresTiposInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ProveedoresTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ProveedoresTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ProveedoresTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ProveedoresTipos.UsuarioModificacion)
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

    Public Function ProveedoresTiposUpdate(ByVal newDBO_ProveedoresTipos As DBO_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ProveedoresTiposUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ProveedoresTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ProveedoresTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ProveedoresTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ProveedoresTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldProveedorTipoID", newDBO_ProveedoresTipos.ProveedorTipoID)
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
            MessageBox.Show("Error en UpdateProveedoresTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ProveedoresTiposDelete(ByVal ProveedorTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ProveedoresTiposDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldProveedorTipoID", ProveedorTipoID)
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

    Public Sub GrabarProveedoresTipos(ByVal dbo_ProveedoresTipos As DBO_ProveedoresTipos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_ProveedoresTipos.ProveedorTipoID = 0 Then
            ProveedoresTiposInsert(dbo_ProveedoresTipos, dtb)
        Else
            ProveedoresTiposUpdate(dbo_ProveedoresTipos, dtb)
        End If
    End Sub

End Class
