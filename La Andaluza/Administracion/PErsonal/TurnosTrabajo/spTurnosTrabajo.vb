

Class spTurnosTrabajo
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[TurnosTrabajoSelect]", "[dbo].[TurnosTrabajoInsert]", "[dbo].[TurnosTrabajoUpdate]", "[dbo].[TurnosTrabajoDelete]", _
                   "TurnosTrabajoSelectDgv", "TurnosTrabajoSelectDgvByID")
    End Sub
    'Public Function Select_Record(ByVal TurnoTrabajoID As Int32) As DBO_TurnosTrabajo
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim DBO_TurnosTrabajo As New DBO_TurnosTrabajo
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[TurnosTrabajoSelect]"
    '    Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    selectCommand.Parameters.AddWithValue("@TurnoTrabajoID", TurnoTrabajoID)
    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
    '        If reader.Read Then
    '            DBO_TurnosTrabajo.TurnoTrabajoID = if(reader("TurnoTrabajoID") Is Convert.DBNull, 0, reader("TurnoTrabajoID")))
    '            DBO_TurnosTrabajo.Ano = If(reader("Ano") Is Convert.DBNull, System.DateTime.Now, reader("Ano")))
    '            DBO_TurnosTrabajo.Semana = if(reader("Semana") Is Convert.DBNull, 0, reader("Semana")))
    '            DBO_TurnosTrabajo.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, reader("Observaciones")))
    '            DBO_TurnosTrabajo.RutaFichero = If(reader("RutaFichero") Is Convert.DBNull, String.Empty, reader("RutaFichero")))
    '            DBO_TurnosTrabajo.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, reader("FechaModificacion")))
    '            DBO_TurnosTrabajo.UsuarioModificacion = if(reader("UsuarioModificacion") Is Convert.DBNull, 0, reader("UsuarioModificacion")))
    '        Else
    '            DBO_TurnosTrabajo = Nothing
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException

    '    Finally
    '        connection.Close()
    '    End Try
    '    Return DBO_TurnosTrabajo
    'End Function

    Public Function Select_Record(ByVal TurnoTrabajoID As Int32, ByRef dtb as BasesParaCompatibilidad.Database) As DBO_TurnosTrabajo
        dtb.Conectar()
        Dim DBO_TurnosTrabajo As New DBO_TurnosTrabajo
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[TurnosTrabajoSelect]")
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@TurnoTrabajoID", TurnoTrabajoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_TurnosTrabajo.TurnoTrabajoID = If(reader("TurnoTrabajoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TurnoTrabajoID")))
                DBO_TurnosTrabajo.Ano = If(reader("Ano") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Ano")))
                DBO_TurnosTrabajo.Semana = If(reader("Semana") Is Convert.DBNull, 0, Convert.ToInt32(reader("Semana")))
                DBO_TurnosTrabajo.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_TurnosTrabajo.RutaFichero = If(reader("RutaFichero") Is Convert.DBNull, String.Empty, Convert.ToString(reader("RutaFichero")))
                DBO_TurnosTrabajo.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_TurnosTrabajo.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_TurnosTrabajo = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
           dtb.Conectar()
        End Try
        Return DBO_TurnosTrabajo
    End Function

    Public Function TurnosTrabajoInsert(ByVal dbo_TurnosTrabajo As DBO_TurnosTrabajo, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[TurnosTrabajoInsert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Ano", dbo_TurnosTrabajo.Ano)
        insertCommand.Parameters.AddWithValue("@Semana", dbo_TurnosTrabajo.Semana)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_TurnosTrabajo.Observaciones)
        insertCommand.Parameters.AddWithValue("@RutaFichero", dbo_TurnosTrabajo.RutaFichero)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_TurnosTrabajo.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_TurnosTrabajo.UsuarioModificacion)
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

    Public Function TurnosTrabajoUpdate(ByVal newDBO_TurnosTrabajo As DBO_TurnosTrabajo, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[TurnosTrabajoUpdate]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewAno", newDBO_TurnosTrabajo.Ano)
        updateCommand.Parameters.AddWithValue("@NewSemana", newDBO_TurnosTrabajo.Semana)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_TurnosTrabajo.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewRutaFichero", newDBO_TurnosTrabajo.RutaFichero)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_TurnosTrabajo.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_TurnosTrabajo.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldTurnoTrabajoID", newDBO_TurnosTrabajo.TurnoTrabajoID)
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
            MessageBox.Show("Error en UpdateTurnosTrabajo" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
           dtb.Conectar()
        End Try
    End Function

    'Public Function TurnosTrabajoInsert(ByVal dbo_TurnosTrabajo As DBO_TurnosTrabajo) As Boolean
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim insertProcedure As String = "[dbo].[TurnosTrabajoInsert]"
    '    Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
    '    insertCommand.CommandType = CommandType.StoredProcedure
    '    insertCommand.Parameters.AddWithValue("@Ano", dbo_TurnosTrabajo.Ano)
    '    insertCommand.Parameters.AddWithValue("@Semana", dbo_TurnosTrabajo.Semana)
    '    insertCommand.Parameters.AddWithValue("@Observaciones", dbo_TurnosTrabajo.Observaciones)
    '    insertCommand.Parameters.AddWithValue("@RutaFichero", dbo_TurnosTrabajo.RutaFichero)
    '    insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_TurnosTrabajo.FechaModificacion)
    '    insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_TurnosTrabajo.UsuarioModificacion)
    '    insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        
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
    '        connection.Close()
    '    End Try
    'End Function

    'Public Function TurnosTrabajoUpdate(ByVal newDBO_TurnosTrabajo As DBO_TurnosTrabajo) As Boolean
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim updateProcedure As String = "[dbo].[TurnosTrabajoUpdate]"
    '    Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
    '    updateCommand.CommandType = CommandType.StoredProcedure
    '    updateCommand.Parameters.AddWithValue("@NewAno", newDBO_TurnosTrabajo.Ano)
    '    updateCommand.Parameters.AddWithValue("@NewSemana", newDBO_TurnosTrabajo.Semana)
    '    updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_TurnosTrabajo.Observaciones)
    '    updateCommand.Parameters.AddWithValue("@NewRutaFichero", newDBO_TurnosTrabajo.RutaFichero)
    '    updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_TurnosTrabajo.FechaModificacion)
    '    updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_TurnosTrabajo.UsuarioModificacion)
    '    updateCommand.Parameters.AddWithValue("@OldTurnoTrabajoID", newDBO_TurnosTrabajo.TurnoTrabajoID)
    '    updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        
    '        updateCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '           Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '         MessageBox.Show("Error en UpdateTurnosTrabajo" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
    '         Return False
    '    Finally
    '        connection.Close()
    '    End Try
    'End Function

    'Public Function TurnosTrabajoDelete(ByVal TurnoTrabajoID As Int32) As Boolean
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim deleteProcedure As String = "[dbo].[TurnosTrabajoDelete]"
    '    Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
    '    deleteCommand.CommandType = CommandType.StoredProcedure
    '    deleteCommand.Parameters.AddWithValue("@OldTurnoTrabajoID", TurnoTrabajoID)
    '    deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        
    '        deleteCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
    '        If count > 0 Then
    '            Return True
    '        Else
    '           Return False
    '        End If
    '    Catch ex As System.Data.SqlClient.SqlException
    '         Return False
    '    Finally
    '        connection.Close()
    '    End Try
    'End Function

    Public Function TurnosTrabajoDelete(ByVal TurnoTrabajoID As Int32, ByRef dtb as BasesParaCompatibilidad.Database) As Boolean
        dtb.Conectar()
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[TurnosTrabajoDelete]")
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldTurnoTrabajoID", TurnoTrabajoID)
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
           dtb.Conectar()
        End Try
    End Function

    Public Sub GrabarTurnosTrabajo(ByVal dbo_TurnosTrabajo As DBO_TurnosTrabajo, ByRef dtb as BasesParaCompatibilidad.Database)
        If dbo_TurnosTrabajo.TurnoTrabajoID = 0 Then
            TurnosTrabajoInsert(dbo_TurnosTrabajo, dtb)
        Else
            TurnosTrabajoUpdate(dbo_TurnosTrabajo, dtb)
        End If
    End Sub

End Class
