

Class spArticulosOrdenEnvasado2
    inherits BasesParaCompatibilidad.sp
    Public Sub New()
        MyBase.New("[dbo].[ArticulosOrdenEnvasado2Select]", "[dbo].[ArticulosOrdenEnvasado2Insert]", "[dbo].[ArticulosOrdenEnvasado2Update]", _
                  "[dbo].[ArticulosOrdenEnvasado2Delete]", String.Empty, String.Empty)
    End Sub

    'Public Function Select_Record(ByVal ArticuloOrdenEnvasadoID As Int32) As DBO_ArticulosOrdenEnvasado2
    '    dtb.Conectar 
    '    Dim DBO_ArticulosOrdenEnvasado As New DBO_ArticulosOrdenEnvasado2
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[ArticulosOrdenEnvasado2Select]"
    '    Dim selectCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(selectProcedure)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    selectCommand.Parameters.AddWithValue("@ArticuloOrdenEnvasadoID", ArticuloOrdenEnvasadoID)
    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
    '        If reader.Read Then
    '            DBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID = if(reader("ArticuloOrdenEnvasadoID") Is Convert.DBNull, 0, reader("ArticuloOrdenEnvasadoID")))
    '            DBO_ArticulosOrdenEnvasado.LineaID = if(reader("LineaID") Is Convert.DBNull, 0, reader("LineaID")))
    '            DBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID = if(reader("ArticuloEnvasadoID") Is Convert.DBNull, 0, reader("ArticuloEnvasadoID")))
    '            DBO_ArticulosOrdenEnvasado.Cajas = System.Convert.ToDouble(if(reader("Cajas") Is Convert.DBNull, 0, reader("Cajas")))
    '            DBO_ArticulosOrdenEnvasado.Cajas_IsDBNull = if(reader("Cajas") Is Convert.DBNull, True, False)
    '            DBO_ArticulosOrdenEnvasado.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, reader("Observaciones")))
    '            DBO_ArticulosOrdenEnvasado.Observaciones_IsDBNull = if(reader("Observaciones") Is Convert.DBNull, True, False)
    '            DBO_ArticulosOrdenEnvasado.OrdenEnvasadoID = if(reader("OrdenEnvasadoID") Is Convert.DBNull, 0, reader("OrdenEnvasadoID")))
    '            DBO_ArticulosOrdenEnvasado.OrdenEnvasadoID_IsDBNull = if(reader("OrdenEnvasadoID") Is Convert.DBNull, True, False)
    '            DBO_ArticulosOrdenEnvasado.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, reader("FechaModificacion")))
    '            DBO_ArticulosOrdenEnvasado.UsuarioModificacion = if(reader("UsuarioModificacion") Is Convert.DBNull, 0, reader("UsuarioModificacion")))
    '        Else
    '            DBO_ArticulosOrdenEnvasado = Nothing
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    '    Return DBO_ArticulosOrdenEnvasado
    'End Function

    Public Function Select_Record(ByVal ArticuloOrdenEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.Database) As DBO_ArticulosOrdenEnvasado2
        dtb.Conectar()
        Dim DBO_ArticulosOrdenEnvasado As New DBO_ArticulosOrdenEnvasado2
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosOrdenEnvasado2Select]")
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloOrdenEnvasadoID", ArticuloOrdenEnvasadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID = If(reader("ArticuloOrdenEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloOrdenEnvasadoID")))
                DBO_ArticulosOrdenEnvasado.LineaID = If(reader("LineaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("LineaID")))
                DBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID = If(reader("ArticuloEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloEnvasadoID")))
                DBO_ArticulosOrdenEnvasado.Cajas = System.Convert.ToDouble(If(reader("Cajas") Is Convert.DBNull, 0, reader("Cajas")))
                DBO_ArticulosOrdenEnvasado.Cajas_IsDBNull = If(reader("Cajas") Is Convert.DBNull, True, False)
                DBO_ArticulosOrdenEnvasado.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosOrdenEnvasado.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                DBO_ArticulosOrdenEnvasado.OrdenEnvasadoID = If(reader("OrdenEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("OrdenEnvasadoID")))
                DBO_ArticulosOrdenEnvasado.OrdenEnvasadoID_IsDBNull = If(reader("OrdenEnvasadoID") Is Convert.DBNull, True, False)
                DBO_ArticulosOrdenEnvasado.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosOrdenEnvasado.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosOrdenEnvasado = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ArticulosOrdenEnvasado
    End Function

    Public Function ArticulosOrdenEnvasadoInsert(ByVal dbo_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosOrdenEnvasado2Insert]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@LineaID", dbo_ArticulosOrdenEnvasado.LineaID)
        insertCommand.Parameters.AddWithValue("@ArticuloEnvasadoID", dbo_ArticulosOrdenEnvasado.ArticuloEnvasadoID)
        insertCommand.Parameters.AddWithValue("@Cajas", If(dbo_ArticulosOrdenEnvasado.Cajas_IsDBNull = True, Convert.DBNull, dbo_ArticulosOrdenEnvasado.Cajas))
        insertCommand.Parameters.AddWithValue("@Observaciones", If(dbo_ArticulosOrdenEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, dbo_ArticulosOrdenEnvasado.Observaciones))
        insertCommand.Parameters.AddWithValue("@OrdenEnvasadoID", If(dbo_ArticulosOrdenEnvasado.OrdenEnvasadoID_IsDBNull = True, Convert.DBNull, dbo_ArticulosOrdenEnvasado.OrdenEnvasadoID))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosOrdenEnvasado.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosOrdenEnvasado.UsuarioModificacion)
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
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ArticulosOrdenEnvasadoUpdate(ByVal newDBO_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosOrdenEnvasado2Update]")
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewLineaID", newDBO_ArticulosOrdenEnvasado.LineaID)
        updateCommand.Parameters.AddWithValue("@NewArticuloEnvasadoID", newDBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID)
        updateCommand.Parameters.AddWithValue("@NewCajas", If(newDBO_ArticulosOrdenEnvasado.Cajas_IsDBNull = True, Convert.DBNull, newDBO_ArticulosOrdenEnvasado.Cajas))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", If(newDBO_ArticulosOrdenEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_ArticulosOrdenEnvasado.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewOrdenEnvasadoID", If(newDBO_ArticulosOrdenEnvasado.OrdenEnvasadoID_IsDBNull = True, Convert.DBNull, newDBO_ArticulosOrdenEnvasado.OrdenEnvasadoID))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosOrdenEnvasado.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosOrdenEnvasado.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloOrdenEnvasadoID", newDBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID)
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
            MessageBox.Show("Error en UpdateArticulosOrdenEnvasado" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    'Public Function ArticulosOrdenEnvasadoInsert(ByVal dbo_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim insertProcedure As String = "[dbo].[ArticulosOrdenEnvasado2Insert]"
    '    Dim insertCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(insertProcedure )
    '    insertCommand.CommandType = CommandType.StoredProcedure
    '    insertCommand.Parameters.AddWithValue("@LineaID", dbo_ArticulosOrdenEnvasado.LineaID)
    '    insertCommand.Parameters.AddWithValue("@ArticuloEnvasadoID", dbo_ArticulosOrdenEnvasado.ArticuloEnvasadoID)
    '    insertCommand.Parameters.AddWithValue("@Cajas", if(dbo_ArticulosOrdenEnvasado.Cajas_IsDBNull = True, Convert.DBNull, dbo_ArticulosOrdenEnvasado.Cajas))
    '    insertCommand.Parameters.AddWithValue("@Observaciones", if(dbo_ArticulosOrdenEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, dbo_ArticulosOrdenEnvasado.Observaciones))
    '    insertCommand.Parameters.AddWithValue("@OrdenEnvasadoID", if(dbo_ArticulosOrdenEnvasado.OrdenEnvasadoID_IsDBNull = True, Convert.DBNull, dbo_ArticulosOrdenEnvasado.OrdenEnvasadoID))
    '    insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosOrdenEnvasado.FechaModificacion)
    '    insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosOrdenEnvasado.UsuarioModificacion)
    '    insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
    '    insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
    '    Try
    '        
    '        insertCommand.ExecuteNonQuery()
    '        Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
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

    'Public Function ArticulosOrdenEnvasadoUpdate(ByVal newDBO_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim updateProcedure As String = "[dbo].[ArticulosOrdenEnvasado2Update]"
    '    Dim updateCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
    '    updateCommand.CommandType = CommandType.StoredProcedure
    '    updateCommand.Parameters.AddWithValue("@NewLineaID", newDBO_ArticulosOrdenEnvasado.LineaID)
    '    updateCommand.Parameters.AddWithValue("@NewArticuloEnvasadoID", newDBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID)
    '    updateCommand.Parameters.AddWithValue("@NewCajas", if(newDBO_ArticulosOrdenEnvasado.Cajas_IsDBNull = True, Convert.DBNull, newDBO_ArticulosOrdenEnvasado.Cajas))
    '    updateCommand.Parameters.AddWithValue("@NewObservaciones", if(newDBO_ArticulosOrdenEnvasado.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_ArticulosOrdenEnvasado.Observaciones))
    '    updateCommand.Parameters.AddWithValue("@NewOrdenEnvasadoID", if(newDBO_ArticulosOrdenEnvasado.OrdenEnvasadoID_IsDBNull = True, Convert.DBNull, newDBO_ArticulosOrdenEnvasado.OrdenEnvasadoID))
    '    updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosOrdenEnvasado.FechaModificacion)
    '    updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosOrdenEnvasado.UsuarioModificacion)
    '    updateCommand.Parameters.AddWithValue("@OldArticuloOrdenEnvasadoID", newDBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID)
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
    '        MessageBox.Show("Error en UpdateArticulosOrdenEnvasado" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
    '        Return False
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    'End Function

    'Public Function ArticulosOrdenEnvasadoDelete(ByVal ArticuloOrdenEnvasadoID As Int32) As Boolean
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim deleteProcedure As String = "[dbo].[ArticulosOrdenEnvasado2Delete]"
    '    Dim deleteCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
    '    deleteCommand.CommandType = CommandType.StoredProcedure
    '    deleteCommand.Parameters.AddWithValue("@OldArticuloOrdenEnvasadoID", ArticuloOrdenEnvasadoID)
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

    Public Function ArticulosOrdenEnvasadoDelete(ByVal ArticuloOrdenEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[ArticulosOrdenEnvasado2Delete]")
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloOrdenEnvasadoID", ArticuloOrdenEnvasadoID)
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
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GrabarArticulosOrdenEnvasado(ByVal dbo_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2, ByRef dtb as BasesParaCompatibilidad.Database)
        If dbo_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID = 0 Then
            ArticulosOrdenEnvasadoInsert(dbo_ArticulosOrdenEnvasado, dtb)
        Else
            ArticulosOrdenEnvasadoUpdate(dbo_ArticulosOrdenEnvasado, dtb)
        End If
    End Sub

    'Public Sub GrabarArticulosOrdenEnvasado(ByVal dbo_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2)
    '    If dbo_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID = 0 Then
    '        ArticulosOrdenEnvasadoInsert(dbo_ArticulosOrdenEnvasado)
    '    Else
    '        ArticulosOrdenEnvasadoUpdate(dbo_ArticulosOrdenEnvasado)
    '    End If
    'End Sub

End Class
