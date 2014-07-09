

Class spEnvasadosControles2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EnvasadosControles2Select]", "[dbo].[EnvasadosControles2Insert]", "[dbo].[EnvasadosControles2Update]", _
                   "[dbo].[EnvasadosControles2Delete]", "EnvasadosControles2SelectDgv", "EnvasadosControles2SelectDgvByEnvasadoControlID")
    End Sub
    Public Function SelectByEnvasadoControlID(ByVal EnvasadoControlID As Int32) As DBO_EnvasadosControles2
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_EnvasadosControles2 As New DBO_EnvasadosControles2
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[EnvasadosControles2SelectByEnvasadoControlID]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoControlID", EnvasadoControlID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosControles2.EnvasadoControl2ID = If(reader("EnvasadoControl2ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControl2ID")))
                DBO_EnvasadosControles2.EnvasadoControlID = If(reader("EnvasadoControlID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlID")))
                DBO_EnvasadosControles2.Boquilla1 = If(reader("Boquilla1") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla1")))
                DBO_EnvasadosControles2.Boquilla2 = If(reader("Boquilla2") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla2")))
                DBO_EnvasadosControles2.Boquilla3 = If(reader("Boquilla3") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla3")))
                DBO_EnvasadosControles2.Boquilla4 = If(reader("Boquilla4") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla4")))
                DBO_EnvasadosControles2.Boquilla5 = If(reader("Boquilla5") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla5")))
                DBO_EnvasadosControles2.Boquilla6 = If(reader("Boquilla6") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla6")))
                DBO_EnvasadosControles2.Etiquetado = If(reader("Etiquetado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Etiquetado")))
                DBO_EnvasadosControles2.Taponado = If(reader("Taponado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Taponado")))
                DBO_EnvasadosControles2.Bote = If(reader("Bote") Is Convert.DBNull, False, Convert.ToBoolean(reader("Bote")))
                DBO_EnvasadosControles2.Etiqueta = If(reader("Etiqueta") Is Convert.DBNull, False, Convert.ToBoolean(reader("Etiqueta")))
                DBO_EnvasadosControles2.Tapon = If(reader("Tapon") Is Convert.DBNull, False, Convert.ToBoolean(reader("Tapon")))
                DBO_EnvasadosControles2.Retractil = If(reader("Retractil") Is Convert.DBNull, False, Convert.ToBoolean(reader("Retractil")))
                DBO_EnvasadosControles2.Caja = If(reader("Caja") Is Convert.DBNull, False, Convert.ToBoolean(reader("Caja")))
                DBO_EnvasadosControles2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosControles2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                'DBO_EnvasadosControles2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_EnvasadosControles2
    End Function

    Public Function Select_Record(ByVal EnvasadoControl2ID As Int32) As DBO_EnvasadosControles2
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_EnvasadosControles2 As New DBO_EnvasadosControles2
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[EnvasadosControles2Select]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoControl2ID", EnvasadoControl2ID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosControles2.EnvasadoControl2ID = If(reader("EnvasadoControl2ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControl2ID")))
                DBO_EnvasadosControles2.EnvasadoControlID = If(reader("EnvasadoControlID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlID")))
                DBO_EnvasadosControles2.Boquilla1 = If(reader("Boquilla1") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla1")))
                DBO_EnvasadosControles2.Boquilla2 = If(reader("Boquilla2") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla2")))
                DBO_EnvasadosControles2.Boquilla3 = If(reader("Boquilla3") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla3")))
                DBO_EnvasadosControles2.Boquilla4 = If(reader("Boquilla4") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla4")))
                DBO_EnvasadosControles2.Boquilla5 = If(reader("Boquilla5") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla5")))
                DBO_EnvasadosControles2.Boquilla6 = If(reader("Boquilla6") Is Convert.DBNull, False, Convert.ToBoolean(reader("Boquilla6")))
                DBO_EnvasadosControles2.Etiquetado = If(reader("Etiquetado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Etiquetado")))
                DBO_EnvasadosControles2.Taponado = If(reader("Taponado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Taponado")))
                DBO_EnvasadosControles2.Bote = If(reader("Bote") Is Convert.DBNull, False, Convert.ToBoolean(reader("Bote")))
                DBO_EnvasadosControles2.Etiqueta = If(reader("Etiqueta") Is Convert.DBNull, False, Convert.ToBoolean(reader("Etiqueta")))
                DBO_EnvasadosControles2.Tapon = If(reader("Tapon") Is Convert.DBNull, False, Convert.ToBoolean(reader("Tapon")))
                DBO_EnvasadosControles2.Retractil = If(reader("Retractil") Is Convert.DBNull, False, Convert.ToBoolean(reader("Retractil")))
                DBO_EnvasadosControles2.Caja = If(reader("Caja") Is Convert.DBNull, False, Convert.ToBoolean(reader("Caja")))
                DBO_EnvasadosControles2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosControles2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_EnvasadosControles2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_EnvasadosControles2
    End Function

    Public Function EnvasadosControles2Insert(ByVal dbo_EnvasadosControles2 As DBO_EnvasadosControles2) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[EnvasadosControles2Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@EnvasadoControlID", If(dbo_EnvasadosControles2.EnvasadoControlID.HasValue, dbo_EnvasadosControles2.EnvasadoControlID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Boquilla1", dbo_EnvasadosControles2.Boquilla1)
        insertCommand.Parameters.AddWithValue("@Boquilla2", dbo_EnvasadosControles2.Boquilla2)
        insertCommand.Parameters.AddWithValue("@Boquilla3", dbo_EnvasadosControles2.Boquilla3)
        insertCommand.Parameters.AddWithValue("@Boquilla4", dbo_EnvasadosControles2.Boquilla4)
        insertCommand.Parameters.AddWithValue("@Boquilla5", dbo_EnvasadosControles2.Boquilla5)
        insertCommand.Parameters.AddWithValue("@Boquilla6", dbo_EnvasadosControles2.Boquilla6)
        insertCommand.Parameters.AddWithValue("@Etiquetado", dbo_EnvasadosControles2.Etiquetado)
        insertCommand.Parameters.AddWithValue("@Taponado", dbo_EnvasadosControles2.Taponado)
        insertCommand.Parameters.AddWithValue("@Bote", dbo_EnvasadosControles2.Bote)
        insertCommand.Parameters.AddWithValue("@Etiqueta", dbo_EnvasadosControles2.Etiqueta)
        insertCommand.Parameters.AddWithValue("@Tapon", dbo_EnvasadosControles2.Tapon)
        insertCommand.Parameters.AddWithValue("@Retractil", dbo_EnvasadosControles2.Retractil)
        insertCommand.Parameters.AddWithValue("@Caja", dbo_EnvasadosControles2.Caja)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_EnvasadosControles2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_EnvasadosControles2.UsuarioModificacion)
        
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

    Public Function EnvasadosControles2Update(ByVal newDBO_EnvasadosControles2 As DBO_EnvasadosControles2) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[EnvasadosControles2Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewEnvasadoControlID", If(newDBO_EnvasadosControles2.EnvasadoControlID.HasValue, newDBO_EnvasadosControles2.EnvasadoControlID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewBoquilla1", newDBO_EnvasadosControles2.Boquilla1)
        updateCommand.Parameters.AddWithValue("@NewBoquilla2", newDBO_EnvasadosControles2.Boquilla2)
        updateCommand.Parameters.AddWithValue("@NewBoquilla3", newDBO_EnvasadosControles2.Boquilla3)
        updateCommand.Parameters.AddWithValue("@NewBoquilla4", newDBO_EnvasadosControles2.Boquilla4)
        updateCommand.Parameters.AddWithValue("@NewBoquilla5", newDBO_EnvasadosControles2.Boquilla5)
        updateCommand.Parameters.AddWithValue("@NewBoquilla6", newDBO_EnvasadosControles2.Boquilla6)
        updateCommand.Parameters.AddWithValue("@NewEtiquetado", newDBO_EnvasadosControles2.Etiquetado)
        updateCommand.Parameters.AddWithValue("@NewTaponado", newDBO_EnvasadosControles2.Taponado)
        updateCommand.Parameters.AddWithValue("@NewBote", newDBO_EnvasadosControles2.Bote)
        updateCommand.Parameters.AddWithValue("@NewEtiqueta", newDBO_EnvasadosControles2.Etiqueta)
        updateCommand.Parameters.AddWithValue("@NewTapon", newDBO_EnvasadosControles2.Tapon)
        updateCommand.Parameters.AddWithValue("@NewRetractil", newDBO_EnvasadosControles2.Retractil)
        updateCommand.Parameters.AddWithValue("@NewCaja", newDBO_EnvasadosControles2.Caja)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_EnvasadosControles2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_EnvasadosControles2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldEnvasadoControl2ID", newDBO_EnvasadosControles2.EnvasadoControl2ID)
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
            MessageBox.Show("Error en UpdateEnvasadosControles2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function EnvasadosControles2Delete(ByVal EnvasadoControl2ID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[EnvasadosControles2Delete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldEnvasadoControl2ID", EnvasadoControl2ID)
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

    Public Sub GrabarEnvasadosControles2(ByVal dbo_EnvasadosControles2 As DBO_EnvasadosControles2)
        dbo_EnvasadosControles2.FechaModificacion = System.DateTime.Now.date
        dbo_EnvasadosControles2.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_EnvasadosControles2.EnvasadoControl2ID = 0 Then
            EnvasadosControles2Insert(dbo_EnvasadosControles2)
        Else
            EnvasadosControles2Update(dbo_EnvasadosControles2)
        End If
    End Sub

End Class
