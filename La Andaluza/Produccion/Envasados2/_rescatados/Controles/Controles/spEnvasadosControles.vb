

Class spEnvasadosControles
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EnvasadosControlesSelect]", "[dbo].[EnvasadosControlesInsert]", "[dbo].[EnvasadosControlesUpdate]", _
                   "[dbo].[EnvasadosControlesDelete]", String.Empty, "EnvasadosControlesSelectDgvByFormatoEnvasadoID")
    End Sub
    Public Function Select_Record(ByVal EnvasadoControlID As Int32) As DBO_EnvasadosControles
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_EnvasadosControles As New DBO_EnvasadosControles
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[EnvasadosControlesSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EnvasadoControlID", EnvasadoControlID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_EnvasadosControles.EnvasadoControlID = If(reader("EnvasadoControlID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoControlID")))
                DBO_EnvasadosControles.ResponsableID = If(reader("ResponsableID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ResponsableID")))
                DBO_EnvasadosControles.FormatoEnvasadoID = If(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoEnvasadoID")))
                DBO_EnvasadosControles.Hora = If(reader("Hora") Is Convert.DBNull, System.DateTime.Now, reader("Hora"))
                DBO_EnvasadosControles.LoteadoEnvase = If(reader("LoteadoEnvase") Is Convert.DBNull, False, Convert.ToBoolean(reader("LoteadoEnvase")))
                DBO_EnvasadosControles.LoteadoCaja = If(reader("LoteadoCaja") Is Convert.DBNull, False, Convert.ToBoolean(reader("LoteadoCaja")))
                DBO_EnvasadosControles.EtiquetaPalet = If(reader("EtiquetaPalet") Is Convert.DBNull, False, Convert.ToBoolean(reader("EtiquetaPalet")))
                DBO_EnvasadosControles.Mosaico = If(reader("Mosaico") Is Convert.DBNull, False, Convert.ToBoolean(reader("Mosaico")))
                DBO_EnvasadosControles.Paletizado = If(reader("Paletizado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Paletizado")))
                DBO_EnvasadosControles.TodoCorrecto = If(reader("TodoCorrecto") Is Convert.DBNull, False, Convert.ToBoolean(reader("TodoCorrecto")))
                DBO_EnvasadosControles.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_EnvasadosControles.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EnvasadosControles.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_EnvasadosControles = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_EnvasadosControles
    End Function

    Public Function EnvasadosControlesInsert(ByVal dbo_EnvasadosControles As DBO_EnvasadosControles) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[EnvasadosControlesInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@ResponsableID", If(dbo_EnvasadosControles.ResponsableID.HasValue, dbo_EnvasadosControles.ResponsableID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FormatoEnvasadoID", If(dbo_EnvasadosControles.FormatoEnvasadoID.HasValue, dbo_EnvasadosControles.FormatoEnvasadoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Hora", dbo_EnvasadosControles.Hora)
        insertCommand.Parameters.AddWithValue("@LoteadoEnvase", dbo_EnvasadosControles.LoteadoEnvase)
        insertCommand.Parameters.AddWithValue("@LoteadoCaja", dbo_EnvasadosControles.LoteadoCaja)
        insertCommand.Parameters.AddWithValue("@EtiquetaPalet", dbo_EnvasadosControles.EtiquetaPalet)
        insertCommand.Parameters.AddWithValue("@Mosaico", dbo_EnvasadosControles.Mosaico)
        insertCommand.Parameters.AddWithValue("@Paletizado", dbo_EnvasadosControles.Paletizado)
        insertCommand.Parameters.AddWithValue("@TodoCorrecto", dbo_EnvasadosControles.TodoCorrecto)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_EnvasadosControles.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_EnvasadosControles.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_EnvasadosControles.UsuarioModificacion)
        
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

    Public Function EnvasadosControlesUpdate(ByVal newDBO_EnvasadosControles As DBO_EnvasadosControles) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[EnvasadosControlesUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewResponsableID", If(newDBO_EnvasadosControles.ResponsableID.HasValue, newDBO_EnvasadosControles.ResponsableID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFormatoEnvasadoID", If(newDBO_EnvasadosControles.FormatoEnvasadoID.HasValue, newDBO_EnvasadosControles.FormatoEnvasadoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewHora", newDBO_EnvasadosControles.Hora)
        updateCommand.Parameters.AddWithValue("@NewLoteadoEnvase", newDBO_EnvasadosControles.LoteadoEnvase)
        updateCommand.Parameters.AddWithValue("@NewLoteadoCaja", newDBO_EnvasadosControles.LoteadoCaja)
        updateCommand.Parameters.AddWithValue("@NewEtiquetaPalet", newDBO_EnvasadosControles.EtiquetaPalet)
        updateCommand.Parameters.AddWithValue("@NewMosaico", newDBO_EnvasadosControles.Mosaico)
        updateCommand.Parameters.AddWithValue("@NewPaletizado", newDBO_EnvasadosControles.Paletizado)
        updateCommand.Parameters.AddWithValue("@NewTodoCorrecto", newDBO_EnvasadosControles.TodoCorrecto)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_EnvasadosControles.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_EnvasadosControles.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_EnvasadosControles.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldEnvasadoControlID", newDBO_EnvasadosControles.EnvasadoControlID)
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
            MessageBox.Show("Error en UpdateEnvasadosControles" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function EnvasadosControlesDelete(ByVal EnvasadoControlID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[EnvasadosControlesDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldEnvasadoControlID", EnvasadoControlID)
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

    Public Sub GrabarEnvasadosControles(ByVal dbo_EnvasadosControles As DBO_EnvasadosControles)
        dbo_EnvasadosControles.FechaModificacion = System.DateTime.Now.date
        dbo_EnvasadosControles.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_EnvasadosControles.EnvasadoControlID = 0 Then
            EnvasadosControlesInsert(dbo_EnvasadosControles)
        Else
            EnvasadosControlesUpdate(dbo_EnvasadosControles)
        End If
    End Sub


    Public Function EnvasadosControlesSelecMax() As Integer
        Dim MaxID As Integer = 0
        Try
            BasesParaCompatibilidad.BD.Conectar()
            Dim cmd as new System.Data.SqlClient.SqlCommand
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = BasesParaCompatibilidad.BD.Cnx
            cmd.CommandText = "EnvasadosControlesSelecMax"
            MaxID = (cmd.ExecuteScalar())
            BasesParaCompatibilidad.BD.Cerrar()
            Return MaxID
        Catch ex As Exception
            messagebox.show("Error en EnvasadosControlesSelecMax" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

End Class
