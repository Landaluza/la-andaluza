

Class spOrdenesEnvasado2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[OrdenesEnvasados2Select]", "[dbo].[OrdenesEnvasados2Insert]", "[dbo].[OrdenesEnvasados2Update]", _
                   "[dbo].[OrdenesEnvasados2Delete]", String.Empty, String.Empty)

    End Sub

    'Public Function Select_Record(ByVal OrdenEnvasadoID As Int32) As DBO_OrdenesEnvasado2
    '    dtb.Conectar 
    '    Dim DBO_OrdenesEnvasado As New DBO_OrdenesEnvasado2
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[OrdenesEnvasados2Select]"
    '    Dim selectCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(selectProcedure)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    selectCommand.Parameters.AddWithValue("@OrdenEnvasadoID", OrdenEnvasadoID)
    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
    '        If reader.Read Then
    '            DBO_OrdenesEnvasado.OrdenEnvasadoID = if(reader("OrdenEnvasadoID") Is Convert.DBNull, 0, reader("OrdenEnvasadoID")))
    '            DBO_OrdenesEnvasado.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now, reader("Fecha")))
    '            DBO_OrdenesEnvasado.Fecha_IsDBNull = if(reader("Fecha") Is Convert.DBNull, True, False)
    '            DBO_OrdenesEnvasado.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, reader("Observaciones")))
    '            DBO_OrdenesEnvasado.Observaciones_IsDBNull = if(reader("Observaciones") Is Convert.DBNull, True, False)
    '            DBO_OrdenesEnvasado.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, reader("FechaModificacion")))
    '            DBO_OrdenesEnvasado.UsuarioModificacion = if(reader("UsuarioModificacion") Is Convert.DBNull, 0, reader("UsuarioModificacion")))
    '        Else
    '            DBO_OrdenesEnvasado = Nothing
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    '    Return DBO_OrdenesEnvasado
    'End Function

    Public Function Select_Record(ByVal OrdenEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.Database) As DBO_OrdenesEnvasado2
        dtb.Conectar()
        Dim DBO_OrdenesEnvasado As New DBO_OrdenesEnvasado2

        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesEnvasados2Select]")
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@OrdenEnvasadoID", OrdenEnvasadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_OrdenesEnvasado.OrdenEnvasadoID = If(reader("OrdenEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("OrdenEnvasadoID")))
                DBO_OrdenesEnvasado.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_OrdenesEnvasado.Fecha_IsDBNull = If(reader("Fecha") Is Convert.DBNull, True, False)
                DBO_OrdenesEnvasado.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_OrdenesEnvasado.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                DBO_OrdenesEnvasado.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_OrdenesEnvasado.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_OrdenesEnvasado = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.Conectar()
        End Try
        Return DBO_OrdenesEnvasado
    End Function

    Public Function OrdenesEnvasadoInsert(ByVal dbo_OrdenesEnvasado As DBO_OrdenesEnvasado2, ByRef dtb As BasesParaCompatibilidad.Database) As Integer
        dtb.Conectar()
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesEnvasados2Insert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Fecha", If(dbo_OrdenesEnvasado.Fecha_IsDBNull = True, Convert.DBNull, dbo_OrdenesEnvasado.Fecha))
        insertCommand.Parameters.AddWithValue("@Observaciones", If(dbo_OrdenesEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, dbo_OrdenesEnvasado.Observaciones))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_OrdenesEnvasado.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_OrdenesEnvasado.UsuarioModificacion)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try

            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            Return count
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Conectar()
        End Try
    End Function

    Public Function OrdenesEnvasadoUpdate(ByVal newDBO_OrdenesEnvasado As DBO_OrdenesEnvasado2, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()

        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesEnvasados2Update]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewFecha", If(newDBO_OrdenesEnvasado.Fecha_IsDBNull = True, Convert.DBNull, newDBO_OrdenesEnvasado.Fecha))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", If(newDBO_OrdenesEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_OrdenesEnvasado.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_OrdenesEnvasado.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_OrdenesEnvasado.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldOrdenEnvasadoID", newDBO_OrdenesEnvasado.OrdenEnvasadoID)
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
            MessageBox.Show("Error en UpdateOrdenesEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Conectar()
        End Try
    End Function

    'Public Function OrdenesEnvasadoInsert(ByVal dbo_OrdenesEnvasado As DBO_OrdenesEnvasado2) As Integer
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim insertProcedure As String = "[dbo].[OrdenesEnvasados2Insert]"
    '    Dim insertCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(insertProcedure )
    '    insertCommand.CommandType = CommandType.StoredProcedure
    '    insertCommand.Parameters.AddWithValue("@Fecha", if(dbo_OrdenesEnvasado.Fecha_IsDBNull = True, Convert.DBNull, dbo_OrdenesEnvasado.Fecha))
    '    insertCommand.Parameters.AddWithValue("@Observaciones", if(dbo_OrdenesEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, dbo_OrdenesEnvasado.Observaciones))
    '    insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_OrdenesEnvasado.FechaModificacion)
    '    insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_OrdenesEnvasado.UsuarioModificacion)
    '    insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        
    '        insertCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
    '        Return count
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
    '        Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    'Public Function OrdenesEnvasadoUpdate(ByVal newDBO_OrdenesEnvasado As DBO_OrdenesEnvasado2) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim updateProcedure As String = "[dbo].[OrdenesEnvasados2Update]"
    '    Dim updateCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
    '    updateCommand.CommandType = CommandType.StoredProcedure
    '    updateCommand.Parameters.AddWithValue("@NewFecha", if(newDBO_OrdenesEnvasado.Fecha_IsDBNull = True, Convert.DBNull, newDBO_OrdenesEnvasado.Fecha))
    '    updateCommand.Parameters.AddWithValue("@NewObservaciones", if(newDBO_OrdenesEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_OrdenesEnvasado.Observaciones))
    '    updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_OrdenesEnvasado.FechaModificacion)
    '    updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_OrdenesEnvasado.UsuarioModificacion)
    '    updateCommand.Parameters.AddWithValue("@OldOrdenEnvasadoID", newDBO_OrdenesEnvasado.OrdenEnvasadoID)
    '    updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        
    '        updateCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '        MessageBox.Show("Error en UpdateOrdenesEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
    '        Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    Public Function OrdenesEnvasadoDelete(ByVal OrdenEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesEnvasados2Delete]")
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldOrdenEnvasadoID", OrdenEnvasadoID)
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
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Conectar()
        End Try
    End Function

    'Public Function OrdenesEnvasadoDelete(ByVal OrdenEnvasadoID As Int32) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim deleteProcedure As String = "[dbo].[OrdenesEnvasados2Delete]"
    '    Dim deleteCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
    '    deleteCommand.CommandType = CommandType.StoredProcedure
    '    deleteCommand.Parameters.AddWithValue("@OldOrdenEnvasadoID", OrdenEnvasadoID)
    '    deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        
    '        deleteCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
    '        Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    'Public Sub GrabarOrdenesEnvasado(ByRef OrdenesEnvasado As DBO_OrdenesEnvasado2)
    '    If OrdenesEnvasado.OrdenEnvasadoID = 0 Then
    '        OrdenesEnvasado.OrdenEnvasadoID = spOrdenesEnvasado2.GetIDByFecha(OrdenesEnvasado.Fecha)
    '        If OrdenesEnvasado.OrdenEnvasadoID = 0 Then
    '            OrdenesEnvasado.OrdenEnvasadoID = OrdenesEnvasadoInsert(OrdenesEnvasado)
    '        Else
    '            messagebox.show("Ya existe una OrdenEnvasado para el dia " & OrdenesEnvasado.Fecha.Date.ToString, String.Empty, MessageBoxButtons.OK , MessageBoxIcon.Exclamation )
    '        End If
    '    Else
    '        OrdenesEnvasadoUpdate(OrdenesEnvasado)
    '    End If
    'End Sub

    Public Sub GrabarOrdenesEnvasado(ByRef OrdenesEnvasado As DBO_OrdenesEnvasado2, ByRef dtb As BasesParaCompatibilidad.Database)
        If OrdenesEnvasado.OrdenEnvasadoID = 0 Then
            OrdenesEnvasado.OrdenEnvasadoID = Me.GetIDByFecha(OrdenesEnvasado.Fecha, dtb)
            If OrdenesEnvasado.OrdenEnvasadoID = 0 Then
                OrdenesEnvasado.OrdenEnvasadoID = OrdenesEnvasadoInsert(OrdenesEnvasado, dtb)
            Else
                messagebox.show("Ya existe una OrdenEnvasado para el dia " & OrdenesEnvasado.Fecha.Date.ToString, String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            OrdenesEnvasadoUpdate(OrdenesEnvasado, dtb)
        End If
    End Sub

    Public Function GetIDByFecha(ByVal fecha As DateTime, ByRef dtb As BasesParaCompatibilidad.Database) As Integer
        dtb.Conectar()
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[OrdenesEnvasados2GetIDByFecha]")
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@Fecha", fecha)
        Try

            Dim count As Integer = selectCommand.ExecuteScalar()
            Return count
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateOrdenesEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return 0
        Finally
            dtb.Conectar()
        End Try
    End Function

    'Public Function GetIDByFecha(ByVal fecha As DateTime, ByRef dtb as BasesParaCompatibilidad.Database) As Integer
    '    dtb.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[OrdenesEnvasados2GetIDByFecha]"
    '    Dim selectCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(selectProcedure)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    selectCommand.Parameters.AddWithValue("@Fecha", fecha)
    '    Try
    '        
    '        Dim count As Integer = selectCommand.ExecuteScalar()
    '        Return count
    '    Catch ex As System.Data.SqlClient.SqlException
    '        MessageBox.Show("Error en UpdateOrdenesEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
    '        Return 0
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function
End Class
