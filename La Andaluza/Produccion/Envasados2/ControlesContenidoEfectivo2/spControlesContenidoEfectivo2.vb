

Class spControlesContenidoEfectivo2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ControlesContenidoEfectivoSelect2]", "[dbo].[ControlesContenidoEfectivoInsert2]", "[dbo].[ControlesContenidoEfectivoUpdate2]", _
                   "[dbo].[ControlesContenidoEfectivoDelete2]", "ControlesContenidoEfectivoSelectDgv", "ControlesContenidoEfectivoSelectDgvByEnvasadoID")
    End Sub

    Public Function Select_Record(ByVal ControlContenidoEfectivoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ControlesContenidoEfectivo2
        dtb.Conectar()
        Dim DBO_ControlesContenidoEfectivo As New DBO_ControlesContenidoEfectivo2

        Dim selectProcedure As String = "[dbo].[ControlesContenidoEfectivoSelect2]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ControlContenidoEfectivoID", ControlContenidoEfectivoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ControlesContenidoEfectivo.ControlContenidoEfectivoID = If(reader("ControlContenidoEfectivoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ControlContenidoEfectivoID")))
                DBO_ControlesContenidoEfectivo.EnvasadoID = If(reader("EnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoID")))
                DBO_ControlesContenidoEfectivo.VerificadorID = If(reader("VerificadorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VerificadorID")))
                DBO_ControlesContenidoEfectivo.HoraInicio = If(reader("HoraInicio") Is Convert.DBNull, System.DateTime.Now, reader("HoraInicio"))
                DBO_ControlesContenidoEfectivo.HoraFinal = If(reader("HoraFinal") Is Convert.DBNull, System.DateTime.Now, reader("HoraFinal"))
                DBO_ControlesContenidoEfectivo.ContenidoNominal = If(reader("ContenidoNominal") Is Convert.DBNull, 0, Convert.ToInt32(reader("ContenidoNominal")))
                DBO_ControlesContenidoEfectivo.Maximo = If(reader("Maximo") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("Maximo")))
                DBO_ControlesContenidoEfectivo.Minimo = If(reader("Minimo") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("Minimo")))
                DBO_ControlesContenidoEfectivo.T1 = If(reader("T1") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("T1")))
                DBO_ControlesContenidoEfectivo.T2 = If(reader("T2") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("T2")))
                DBO_ControlesContenidoEfectivo.Media = If(reader("Media") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("Media")))
                DBO_ControlesContenidoEfectivo.Desviacion = If(reader("Desviacion") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("Desviacion")))
                DBO_ControlesContenidoEfectivo.Correcto = If(reader("Correcto") Is Convert.DBNull, False, Convert.ToBoolean(reader("Correcto")))
                DBO_ControlesContenidoEfectivo.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ControlesContenidoEfectivo.Lote = If(reader("Lote") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Lote")))
                'DBO_ControlesContenidoEfectivo.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, reader("FechaModificacion")))
                'DBO_ControlesContenidoEfectivo.UsuarioModificacion = if(reader("UsuarioModificacion") Is Convert.DBNull, 0, reader("UsuarioModificacion")))
            Else
                DBO_ControlesContenidoEfectivo = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ControlesContenidoEfectivo
    End Function

    Public Function ControlesContenidoEfectivoInsert(ByVal dbo_ControlesContenidoEfectivo As DBO_ControlesContenidoEfectivo2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ControlesContenidoEfectivoInsert2]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@EnvasadoID", If(dbo_ControlesContenidoEfectivo.EnvasadoID.HasValue, dbo_ControlesContenidoEfectivo.EnvasadoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@VerificadorID", If(dbo_ControlesContenidoEfectivo.VerificadorID.HasValue, dbo_ControlesContenidoEfectivo.VerificadorID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@HoraInicio", dbo_ControlesContenidoEfectivo.HoraInicio)
        insertCommand.Parameters.AddWithValue("@HoraFinal", dbo_ControlesContenidoEfectivo.HoraFinal)
        insertCommand.Parameters.AddWithValue("@ContenidoNominal", If(dbo_ControlesContenidoEfectivo.ContenidoNominal.HasValue, dbo_ControlesContenidoEfectivo.ContenidoNominal, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Maximo", If(dbo_ControlesContenidoEfectivo.Maximo.HasValue, dbo_ControlesContenidoEfectivo.Maximo, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Minimo", If(dbo_ControlesContenidoEfectivo.Minimo.HasValue, dbo_ControlesContenidoEfectivo.Minimo, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@T1", If(dbo_ControlesContenidoEfectivo.T1.HasValue, dbo_ControlesContenidoEfectivo.T1, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@T2", If(dbo_ControlesContenidoEfectivo.T2.HasValue, dbo_ControlesContenidoEfectivo.T2, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Media", If(dbo_ControlesContenidoEfectivo.Media.HasValue, dbo_ControlesContenidoEfectivo.Media, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Desviacion", If(dbo_ControlesContenidoEfectivo.Desviacion.HasValue, dbo_ControlesContenidoEfectivo.Desviacion, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Correcto", dbo_ControlesContenidoEfectivo.Correcto)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ControlesContenidoEfectivo.Observaciones)
        insertCommand.Parameters.AddWithValue("@Lote", dbo_ControlesContenidoEfectivo.Lote)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ControlesContenidoEfectivo.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ControlesContenidoEfectivo.UsuarioModificacion)
        ' insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        'insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            If insertCommand.ExecuteNonQuery() = 0 Then Return False
            ' Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            'If count > 0 Then
            Return True
            ' Else
            '    Return False
            'End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ControlesContenidoEfectivoUpdate(ByVal newDBO_ControlesContenidoEfectivo As DBO_ControlesContenidoEfectivo2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ControlesContenidoEfectivoUpdate2]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@EnvasadoID", If(newDBO_ControlesContenidoEfectivo.EnvasadoID.HasValue, newDBO_ControlesContenidoEfectivo.EnvasadoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@VerificadorID", If(newDBO_ControlesContenidoEfectivo.VerificadorID.HasValue, newDBO_ControlesContenidoEfectivo.VerificadorID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@HoraInicio", newDBO_ControlesContenidoEfectivo.HoraInicio)
        updateCommand.Parameters.AddWithValue("@HoraFinal", newDBO_ControlesContenidoEfectivo.HoraFinal)
        updateCommand.Parameters.AddWithValue("@ContenidoNominal", If(newDBO_ControlesContenidoEfectivo.ContenidoNominal.HasValue, newDBO_ControlesContenidoEfectivo.ContenidoNominal, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@Maximo", If(newDBO_ControlesContenidoEfectivo.Maximo.HasValue, newDBO_ControlesContenidoEfectivo.Maximo, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@Minimo", If(newDBO_ControlesContenidoEfectivo.Minimo.HasValue, newDBO_ControlesContenidoEfectivo.Minimo, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@T1", If(newDBO_ControlesContenidoEfectivo.T1.HasValue, newDBO_ControlesContenidoEfectivo.T1, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@T2", If(newDBO_ControlesContenidoEfectivo.T2.HasValue, newDBO_ControlesContenidoEfectivo.T2, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@Media", If(newDBO_ControlesContenidoEfectivo.Media.HasValue, newDBO_ControlesContenidoEfectivo.Media, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@Desviacion", If(newDBO_ControlesContenidoEfectivo.Desviacion.HasValue, newDBO_ControlesContenidoEfectivo.Desviacion, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@Correcto", newDBO_ControlesContenidoEfectivo.Correcto)
        updateCommand.Parameters.AddWithValue("@Observaciones", newDBO_ControlesContenidoEfectivo.Observaciones)
        updateCommand.Parameters.AddWithValue("@Lote", newDBO_ControlesContenidoEfectivo.Lote)
        updateCommand.Parameters.AddWithValue("@FechaModificacion", newDBO_ControlesContenidoEfectivo.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@UsuarioModificacion", newDBO_ControlesContenidoEfectivo.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@ControlContenidoEfectivoID", newDBO_ControlesContenidoEfectivo.ControlContenidoEfectivoID)
        ' updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        '  updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            If updateCommand.ExecuteNonQuery() = 0 Then Return False
            'Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            ' If count > 0 Then
            Return True
            'Else
            ' Return False
            ' End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateControlesContenidoEfectivo" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ControlesContenidoEfectivoDelete(ByVal ControlContenidoEfectivoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ControlesContenidoEfectivoDelete2]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@ControlContenidoEfectivoID", ControlContenidoEfectivoID)
        'deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        'deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            If deleteCommand.ExecuteNonQuery() = 0 Then Return False
            'Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            '    If count > 0 Then
            Return True
            ' Else
            ' Return False
            'End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarControlesContenidoEfectivo(ByVal dbo_ControlesContenidoEfectivo As DBO_ControlesContenidoEfectivo2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_ControlesContenidoEfectivo.FechaModificacion = System.DateTime.Now.Date
        dbo_ControlesContenidoEfectivo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_ControlesContenidoEfectivo.ControlContenidoEfectivoID = 0 Then
            Return ControlesContenidoEfectivoInsert(dbo_ControlesContenidoEfectivo, dtb)
        Else
            Return ControlesContenidoEfectivoUpdate(dbo_ControlesContenidoEfectivo, dtb)
        End If
    End Function

End Class
