

Public Class spVelocidadEnvasados2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("", "", "", "", "", "")
    End Sub
    Public Function Select_Record(ByVal VelocidadEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_VelocidadEnvasados2
        dtb.Conectar()
        Dim DBO_VelocidadEnvasados2 As New DBO_VelocidadEnvasados2

        Dim selectProcedure As String = "[dbo].[VelocidadEnvasados2Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@VelocidadEnvasadoID", VelocidadEnvasadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_VelocidadEnvasados2.VelocidadEnvasadoID = If(reader("VelocidadEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VelocidadEnvasadoID")))
                DBO_VelocidadEnvasados2.HoraInicio = If(reader("HoraInicio") Is Convert.DBNull, System.DateTime.Now.TimeOfDay, reader("HoraInicio"))
                DBO_VelocidadEnvasados2.Velocidad = If(reader("Velocidad") Is Convert.DBNull, 0, Convert.ToInt32(reader("Velocidad")))
                DBO_VelocidadEnvasados2.Observacion = If(reader("Observacion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observacion")))
                DBO_VelocidadEnvasados2.PersonalID = If(reader("PersonalID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PersonalID")))
                DBO_VelocidadEnvasados2.FormatoEnvasadoID = If(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoEnvasadoID")))
                DBO_VelocidadEnvasados2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_VelocidadEnvasados2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_VelocidadEnvasados2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_VelocidadEnvasados2
    End Function

    Public Function VelocidadEnvasados2Insert(ByVal dbo_VelocidadEnvasados2 As DBO_VelocidadEnvasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[VelocidadEnvasados2Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@HoraInicio", If(dbo_VelocidadEnvasados2.HoraInicio.HasValue, dbo_VelocidadEnvasados2.HoraInicio, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Velocidad", If(dbo_VelocidadEnvasados2.Velocidad.HasValue, dbo_VelocidadEnvasados2.Velocidad, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Observacion", dbo_VelocidadEnvasados2.Observacion)
        insertCommand.Parameters.AddWithValue("@PersonalID", If(dbo_VelocidadEnvasados2.PersonalID.HasValue, dbo_VelocidadEnvasados2.PersonalID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FormatoEnvasadoID", If(dbo_VelocidadEnvasados2.FormatoEnvasadoID.HasValue, dbo_VelocidadEnvasados2.FormatoEnvasadoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_VelocidadEnvasados2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_VelocidadEnvasados2.UsuarioModificacion)
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

    Public Function VelocidadEnvasados2Update(ByVal newDBO_VelocidadEnvasados2 As DBO_VelocidadEnvasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[VelocidadEnvasados2Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewHoraInicio", If(newDBO_VelocidadEnvasados2.HoraInicio.HasValue, newDBO_VelocidadEnvasados2.HoraInicio, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewVelocidad", If(newDBO_VelocidadEnvasados2.Velocidad.HasValue, newDBO_VelocidadEnvasados2.Velocidad, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewObservacion", newDBO_VelocidadEnvasados2.Observacion)
        updateCommand.Parameters.AddWithValue("@NewPersonalID", If(newDBO_VelocidadEnvasados2.PersonalID.HasValue, newDBO_VelocidadEnvasados2.PersonalID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFormatoEnvasadoID", If(newDBO_VelocidadEnvasados2.FormatoEnvasadoID.HasValue, newDBO_VelocidadEnvasados2.FormatoEnvasadoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_VelocidadEnvasados2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_VelocidadEnvasados2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldVelocidadEnvasadoID", newDBO_VelocidadEnvasados2.VelocidadEnvasadoID)
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
            MessageBox.Show("Error en UpdateVelocidadEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function VelocidadEnvasados2Delete(ByVal VelocidadEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[VelocidadEnvasados2Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldVelocidadEnvasadoID", VelocidadEnvasadoID)
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

    Public Function GrabarVelocidadEnvasados2(ByVal dbo_VelocidadEnvasados2 As DBO_VelocidadEnvasados2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If dbo_VelocidadEnvasados2.VelocidadEnvasadoID = 0 Then
            Return VelocidadEnvasados2Insert(dbo_VelocidadEnvasados2, dtb)
        Else
            Return VelocidadEnvasados2Update(dbo_VelocidadEnvasados2, dtb)
        End If
    End Function

End Class
