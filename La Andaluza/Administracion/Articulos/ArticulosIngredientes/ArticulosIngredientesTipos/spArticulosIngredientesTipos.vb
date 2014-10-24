

Class spArticulosIngredientesTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosIngredientesTiposSelect]", "[dbo].[ArticulosIngredientesTiposInsert]", "[dbo].[ArticulosIngredientesTiposUpdate]", _
                   "[dbo].[ArticulosIngredientesTiposDelete]", "ArticulosIngredientesTiposSelectDgv", "ArticulosIngredientesTiposSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal IngredienteTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosIngredientesTipos
        dtb.Conectar()
        Dim DBO_ArticulosIngredientesTipos As New DBO_ArticulosIngredientesTipos

        Dim selectProcedure As String = "[dbo].[ArticulosIngredientesTiposSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@IngredienteTipoID", IngredienteTipoID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosIngredientesTipos.IngredienteTipoID = If(reader("IngredienteTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("IngredienteTipoID")))
                DBO_ArticulosIngredientesTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosIngredientesTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosIngredientesTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosIngredientesTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosIngredientesTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ArticulosIngredientesTipos
    End Function


    Public Function ArticulosIngredientesTiposInsert(ByVal dbo_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()


        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosIngredientesTiposInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosIngredientesTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosIngredientesTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosIngredientesTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosIngredientesTipos.UsuarioModificacion)
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
            dtb.Conectar()
        End Try
    End Function

    Public Function ArticulosIngredientesTiposUpdate(ByVal newDBO_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosIngredientesTiposUpdate]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosIngredientesTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosIngredientesTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosIngredientesTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosIngredientesTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldIngredienteTipoID", newDBO_ArticulosIngredientesTipos.IngredienteTipoID)
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
            MessageBox.Show("Error en UpdateArticulosIngredientesTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Conectar()
        End Try
    End Function

    'Public Function ArticulosIngredientesTiposInsert(ByVal dbo_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim insertProcedure As String = "[dbo].[ArticulosIngredientesTiposInsert]"
    '    Dim insertCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(insertProcedure )
    '    insertCommand.CommandType = CommandType.StoredProcedure
    '    insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosIngredientesTipos.Descripcion)
    '    insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosIngredientesTipos.Observaciones)
    '    insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosIngredientesTipos.FechaModificacion)
    '    insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosIngredientesTipos.UsuarioModificacion)
    '    insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

    '    Try
    '        insertCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '           Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '         Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    'Public Function ArticulosIngredientesTiposUpdate(ByVal newDBO_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim updateProcedure As String = "[dbo].[ArticulosIngredientesTiposUpdate]"
    '    Dim updateCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
    '    updateCommand.CommandType = CommandType.StoredProcedure
    '    updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosIngredientesTipos.Descripcion)
    '    updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosIngredientesTipos.Observaciones)
    '    updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosIngredientesTipos.FechaModificacion)
    '    updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosIngredientesTipos.UsuarioModificacion)
    '    updateCommand.Parameters.AddWithValue("@OldIngredienteTipoID", newDBO_ArticulosIngredientesTipos.IngredienteTipoID)
    '    updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

    '    Try
    '        updateCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '           Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '         MessageBox.Show("Error en UpdateArticulosIngredientesTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
    '         Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    'Public Function ArticulosIngredientesTiposIDIInsert(ByVal dbo_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim insertProcedure As String = "[dbo].[ArticulosIngredientesIDITiposInsert]"
    '    Dim insertCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(insertProcedure )
    '    insertCommand.CommandType = CommandType.StoredProcedure
    '    insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosIngredientesTipos.Descripcion)
    '    insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosIngredientesTipos.Observaciones)
    '    insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosIngredientesTipos.FechaModificacion)
    '    insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosIngredientesTipos.UsuarioModificacion)
    '    insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

    '    Try
    '        insertCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '        Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    Public Function ArticulosIngredientesTiposIDIInsert(ByVal dbo_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim insertProcedure As String = "[dbo].[ArticulosIngredientesIDITiposInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosIngredientesIDITiposInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosIngredientesTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosIngredientesTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosIngredientesTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosIngredientesTipos.UsuarioModificacion)
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
            dtb.Conectar()
        End Try
    End Function

    Public Function ArticulosIngredientesTiposIDIUpdate(ByVal newDBO_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosIngredientesIDITiposUpdate]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosIngredientesTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosIngredientesTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosIngredientesTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosIngredientesTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldIngredienteTipoID", newDBO_ArticulosIngredientesTipos.IngredienteTipoID)
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
            MessageBox.Show("Error en UpdateArticulosIngredientesTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Conectar()
        End Try
    End Function

    'Public Function ArticulosIngredientesTiposIDIUpdate(ByVal newDBO_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim updateProcedure As String = "[dbo].[ArticulosIngredientesIDITiposUpdate]"
    '    Dim updateCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
    '    updateCommand.CommandType = CommandType.StoredProcedure
    '    updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosIngredientesTipos.Descripcion)
    '    updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosIngredientesTipos.Observaciones)
    '    updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosIngredientesTipos.FechaModificacion)
    '    updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosIngredientesTipos.UsuarioModificacion)
    '    updateCommand.Parameters.AddWithValue("@OldIngredienteTipoID", newDBO_ArticulosIngredientesTipos.IngredienteTipoID)
    '    updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

    '    Try
    '        updateCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '        MessageBox.Show("Error en UpdateArticulosIngredientesTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType)
    '        Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    Public Function ArticulosIngredientesTiposDelete(ByVal IngredienteTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ArticulosIngredientesTiposDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldIngredienteTipoID", IngredienteTipoID)
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
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function



    Public Sub GrabarArticulosIngredientesTipos(ByVal dbo_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos, ByRef dtb as BasesParaCompatibilidad.Database)
        If dbo_ArticulosIngredientesTipos.IngredienteTipoID = 0 Then
            ArticulosIngredientesTiposInsert(dbo_ArticulosIngredientesTipos, dtb)
        Else
            ArticulosIngredientesTiposUpdate(dbo_ArticulosIngredientesTipos, dtb)
        End If
    End Sub


    Public Sub GrabarArticulosIngredientesIDITipos(ByVal dbo_ArticulosIngredientesTipos As DBO_ArticulosIngredientesTipos, ByRef dtb as BasesParaCompatibilidad.Database)
        If dbo_ArticulosIngredientesTipos.IngredienteTipoID = 0 Then
            ArticulosIngredientesTiposIDIInsert(dbo_ArticulosIngredientesTipos, dtb)
        Else
            ArticulosIngredientesTiposIDIUpdate(dbo_ArticulosIngredientesTipos, dtb)
        End If
    End Sub
End Class
