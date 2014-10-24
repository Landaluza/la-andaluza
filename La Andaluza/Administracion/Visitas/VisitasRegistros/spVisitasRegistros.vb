

Class spVisitasRegistros
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[VisitasRegistrosSelect]", "[dbo].[VisitasRegistrosInsert]", _
                   "[dbo].[VisitasRegistrosUpdate]", "[dbo].[VisitasRegistrosDelete]", _
                   "VisitasRegistrosSelectDgv", "VisitasRegistrosSelectDgvByEmpresaID")
    End Sub

    Public Function Select_Record(ByVal VisitaRegistroID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_VisitasRegistros
        dtb.Conectar()
        Dim DBO_VisitasRegistros As New DBO_VisitasRegistros

        Dim selectProcedure As String = "[dbo].[VisitasRegistrosSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@VisitaRegistroID", VisitaRegistroID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_VisitasRegistros.VisitaRegistroID = If(reader("VisitaRegistroID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaRegistroID")))
                DBO_VisitasRegistros.VisitaTipoID = If(reader("VisitaTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaTipoID")))
                DBO_VisitasRegistros.VisitaNombreID = If(reader("VisitaNombreID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaNombreID")))
                DBO_VisitasRegistros.VisitaMotivoID = If(reader("VisitaMotivoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaMotivoID")))
                DBO_VisitasRegistros.EmpresaID = If(reader("EmpresaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EmpresaID")))
                DBO_VisitasRegistros.PersonaResponsableVisitaID = If(reader("PersonaResponsableVisitaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PersonaResponsableVisitaID")))
                DBO_VisitasRegistros.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_VisitasRegistros.HoraEntrada = If(reader("HoraEntrada") Is Convert.DBNull, New TimeSpan(Now.Date.Hour, Now.Date.Minute, Now.Date.Second), CType(reader("HoraEntrada"), TimeSpan))
                DBO_VisitasRegistros.HoraSalida = If(reader("HoraSalida") Is Convert.DBNull, New TimeSpan(Now.Date.Hour, Now.Date.Minute, Now.Date.Second), CType(reader("HoraSalida"), TimeSpan))
                DBO_VisitasRegistros.EmpresaNombre = If(reader("EmpresaNombre") Is Convert.DBNull, String.Empty, Convert.ToString(reader("EmpresaNombre")))
                DBO_VisitasRegistros.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_VisitasRegistros.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_VisitasRegistros.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_VisitasRegistros = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_VisitasRegistros
    End Function

    Public Function VisitasRegistrosInsert(ByVal dbo_VisitasRegistros As DBO_VisitasRegistros, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[VisitasRegistrosInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@VisitaTipoID", If(dbo_VisitasRegistros.VisitaTipoID.HasValue, dbo_VisitasRegistros.VisitaTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@VisitaNombreID", If(dbo_VisitasRegistros.VisitaNombreID.HasValue, dbo_VisitasRegistros.VisitaNombreID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@VisitaMotivoID", If(dbo_VisitasRegistros.VisitaMotivoID.HasValue, dbo_VisitasRegistros.VisitaMotivoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@EmpresaID", If(dbo_VisitasRegistros.EmpresaID.HasValue, dbo_VisitasRegistros.EmpresaID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@PersonaResponsableVisitaID", If(dbo_VisitasRegistros.PersonaResponsableVisitaID.HasValue, dbo_VisitasRegistros.PersonaResponsableVisitaID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_VisitasRegistros.Fecha)
        insertCommand.Parameters.AddWithValue("@HoraEntrada", dbo_VisitasRegistros.HoraEntrada)
        insertCommand.Parameters.AddWithValue("@HoraSalida", dbo_VisitasRegistros.HoraSalida)
        insertCommand.Parameters.AddWithValue("@EmpresaNombre", dbo_VisitasRegistros.EmpresaNombre)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_VisitasRegistros.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_VisitasRegistros.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_VisitasRegistros.UsuarioModificacion)

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
            dtb.Desconectar()
        End Try
    End Function

    Public Function VisitasRegistrosUpdate(ByVal newDBO_VisitasRegistros As DBO_VisitasRegistros, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[VisitasRegistrosUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand
        Try
            updateCommand = dtb.Comando(updateProcedure)
            updateCommand.CommandType = CommandType.StoredProcedure
            '<Tag=[Three][Start]> -- please do not remove this line
            updateCommand.Parameters.AddWithValue("@NewVisitaTipoID", If(newDBO_VisitasRegistros.VisitaTipoID.HasValue, newDBO_VisitasRegistros.VisitaTipoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewVisitaNombreID", If(newDBO_VisitasRegistros.VisitaNombreID.HasValue, newDBO_VisitasRegistros.VisitaNombreID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewVisitaMotivoID", If(newDBO_VisitasRegistros.VisitaMotivoID.HasValue, newDBO_VisitasRegistros.VisitaMotivoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewEmpresaID", If(newDBO_VisitasRegistros.EmpresaID.HasValue, newDBO_VisitasRegistros.EmpresaID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewPersonaResponsableVisitaID", If(newDBO_VisitasRegistros.PersonaResponsableVisitaID.HasValue, newDBO_VisitasRegistros.PersonaResponsableVisitaID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_VisitasRegistros.Fecha)
            updateCommand.Parameters.AddWithValue("@NewHoraEntrada", newDBO_VisitasRegistros.HoraEntrada)
            updateCommand.Parameters.AddWithValue("@NewHoraSalida", newDBO_VisitasRegistros.HoraSalida)
            updateCommand.Parameters.AddWithValue("@NewEmpresaNombre", newDBO_VisitasRegistros.EmpresaNombre)
            updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_VisitasRegistros.Observaciones)
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_VisitasRegistros.FechaModificacion)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_VisitasRegistros.UsuarioModificacion)
            updateCommand.Parameters.AddWithValue("@OldVisitaRegistroID", newDBO_VisitasRegistros.VisitaRegistroID)
            '<Tag=[Three][End]> -- please do not remove this line
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
            MessageBox.Show("Error en UpdateVisitasRegistros" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function VisitasRegistrosDelete(ByVal VisitaRegistroID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[VisitasRegistrosDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldVisitaRegistroID", VisitaRegistroID)
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
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarVisitasRegistros(ByVal dbo_VisitasRegistros As DBO_VisitasRegistros, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_VisitasRegistros.FechaModificacion = System.DateTime.Now.Date
        dbo_VisitasRegistros.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_VisitasRegistros.VisitaRegistroID = 0 Then
            Return VisitasRegistrosInsert(dbo_VisitasRegistros, dtb)
        Else
            Return VisitasRegistrosUpdate(dbo_VisitasRegistros, dtb)
        End If
    End Function

End Class
