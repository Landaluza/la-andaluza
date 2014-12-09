

Class spPaletsMovimientoSubTipo
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PaletsMovimientoSubTipoSelect]", "[dbo].[PaletsMovimientoSubTipoInsert]", "[dbo].[PaletsMovimientoSubTipoUpdate]", _
                   "[dbo].[PaletsMovimientoSubTipoDelete]", "PaletsMovimientoSubTipoSelectDgv", "PaletsMovimientoSubTipoByTipo")
    End Sub

    Public Function Select_Record(ByVal ID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsMovimientoSubTipo
        dtb.Conectar()
        Dim Dbo_PaletsMovimientoSubTipo As New DBO_PaletsMovimientoSubTipo

        Dim selectProcedure As String = "[dbo].[PaletsMovimientoSubTipoSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ID", ID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PaletsMovimientoSubTipo.ID = If(reader("ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ID")))
                Dbo_PaletsMovimientoSubTipo.Tipo = If(reader("Tipo") Is Convert.DBNull, 0, Convert.ToInt32(reader("Tipo")))
                Dbo_PaletsMovimientoSubTipo.Tipo_IsDBNull = If(reader("Tipo") Is Convert.DBNull, True, False)
                Dbo_PaletsMovimientoSubTipo.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                Dbo_PaletsMovimientoSubTipo.Descripcion_IsDBNull = If(reader("Descripcion") Is Convert.DBNull, True, False)
                Dbo_PaletsMovimientoSubTipo.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                Dbo_PaletsMovimientoSubTipo.FechaModificacion_IsDBNull = If(reader("FechaModificacion") Is Convert.DBNull, True, False)
                Dbo_PaletsMovimientoSubTipo.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                Dbo_PaletsMovimientoSubTipo.UsuarioModificacion_IsDBNull = If(reader("UsuarioModificacion") Is Convert.DBNull, True, False)
            Else
                'Dbo_PaletsMovimientoSubTipo = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return Dbo_PaletsMovimientoSubTipo
    End Function

    Public Function InsertPaletsMovimientoSubTipo(ByVal dbo_PaletsMovimientoSubTipo As DBO_PaletsMovimientoSubTipo, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PaletsMovimientoSubTipoInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Tipo", If(dbo_PaletsMovimientoSubTipo.Tipo_IsDBNull = True, Convert.DBNull, dbo_PaletsMovimientoSubTipo.Tipo))
        insertCommand.Parameters.AddWithValue("@Descripcion", If(dbo_PaletsMovimientoSubTipo.Descripcion_IsDBNull = True, Convert.DBNull, dbo_PaletsMovimientoSubTipo.Descripcion))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", If(dbo_PaletsMovimientoSubTipo.FechaModificacion_IsDBNull = True, Convert.DBNull, dbo_PaletsMovimientoSubTipo.FechaModificacion))
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", If(dbo_PaletsMovimientoSubTipo.UsuarioModificacion_IsDBNull = True, Convert.DBNull, dbo_PaletsMovimientoSubTipo.UsuarioModificacion))
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

    Public Function UpdatePaletsMovimientoSubTipo(ByVal oldDbo_PaletsMovimientoSubTipo As DBO_PaletsMovimientoSubTipo, ByVal newDbo_PaletsMovimientoSubTipo As DBO_PaletsMovimientoSubTipo, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PaletsMovimientoSubTipoUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewTipo", If(newDbo_PaletsMovimientoSubTipo.Tipo_IsDBNull = True, Convert.DBNull, newDbo_PaletsMovimientoSubTipo.Tipo))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", If(newDbo_PaletsMovimientoSubTipo.Descripcion_IsDBNull = True, Convert.DBNull, newDbo_PaletsMovimientoSubTipo.Descripcion))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", If(newDbo_PaletsMovimientoSubTipo.FechaModificacion_IsDBNull = True, Convert.DBNull, newDbo_PaletsMovimientoSubTipo.FechaModificacion))
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", If(newDbo_PaletsMovimientoSubTipo.UsuarioModificacion_IsDBNull = True, Convert.DBNull, newDbo_PaletsMovimientoSubTipo.UsuarioModificacion))
        updateCommand.Parameters.AddWithValue("@OldID", oldDbo_PaletsMovimientoSubTipo.ID)
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
            MessageBox.Show("Error en UpdatePaletsMovimientoSubTipo" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function DeletePaletsMovimientoSubTipo(ByVal ID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[PaletsMovimientoSubTipoDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldID", ID)
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
