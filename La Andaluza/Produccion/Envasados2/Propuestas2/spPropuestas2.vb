

Public Class spPropuestas2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[Propuestas2Select]", "[dbo].[Propuestas2Insert]", "[dbo].[Propuestas2Update]", "[dbo].[Propuestas2Delete]", "Propuestas2SelectPorFormatoEnvasado ", "Propuestas2SelectPorFormatoEnvasado ")
    End Sub
    Public Function Select_Record(ByVal PropuestaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Propuestas2
        dtb.Conectar()
        Dim DBO_Propuestas2 As DBO_Propuestas2 = DBO_Propuestas2.Instance

        Dim selectProcedure As String = "[dbo].[Propuestas2Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PropuestaID", PropuestaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_Propuestas2.PropuestaID = If(reader("PropuestaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PropuestaID")))
                DBO_Propuestas2.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_Propuestas2.Descripcion_IsDBNull = If(reader("Descripcion") Is Convert.DBNull, True, False)
                DBO_Propuestas2.PropuestaTipoMejoraID = If(reader("PropuestaTipoMejoraID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PropuestaTipoMejoraID")))
                DBO_Propuestas2.PropuestaTipoMejoraID_IsDBNull = If(reader("PropuestaTipoMejoraID") Is Convert.DBNull, True, False)
                DBO_Propuestas2.PropuestaUrgenciaID = If(reader("PropuestaUrgenciaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PropuestaUrgenciaID")))
                DBO_Propuestas2.PropuestaUrgenciaID_IsDBNull = If(reader("PropuestaUrgenciaID") Is Convert.DBNull, True, False)
                DBO_Propuestas2.PersonalID = If(reader("PersonalID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PersonalID")))
                DBO_Propuestas2.PersonalID_IsDBNull = If(reader("PersonalID") Is Convert.DBNull, True, False)
                DBO_Propuestas2.FormatoEnvasadoID = If(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoEnvasadoID")))
                DBO_Propuestas2.FormatoEnvasadoID_IsDBNull = If(reader("FormatoEnvasadoID") Is Convert.DBNull, True, False)
                DBO_Propuestas2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Propuestas2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_Propuestas2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_Propuestas2
    End Function

    Public Function Propuestas2Insert(ByVal dbo_Propuestas2 As DBO_Propuestas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[Propuestas2Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", If(dbo_Propuestas2.Descripcion_IsDBNull = True, Convert.DBNull, dbo_Propuestas2.Descripcion))
        insertCommand.Parameters.AddWithValue("@PropuestaTipoMejoraID", If(dbo_Propuestas2.PropuestaTipoMejoraID_IsDBNull = True, Convert.DBNull, dbo_Propuestas2.PropuestaTipoMejoraID))
        insertCommand.Parameters.AddWithValue("@PropuestaUrgenciaID", If(dbo_Propuestas2.PropuestaUrgenciaID_IsDBNull = True, Convert.DBNull, dbo_Propuestas2.PropuestaUrgenciaID))
        insertCommand.Parameters.AddWithValue("@PersonalID", If(dbo_Propuestas2.PersonalID_IsDBNull = True, Convert.DBNull, dbo_Propuestas2.PersonalID))
        insertCommand.Parameters.AddWithValue("@FormatoEnvasadoID", If(dbo_Propuestas2.FormatoEnvasadoID_IsDBNull = True, Convert.DBNull, dbo_Propuestas2.FormatoEnvasadoID))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_Propuestas2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_Propuestas2.UsuarioModificacion)
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

    Public Function Propuestas2Update(ByVal newDBO_Propuestas2 As DBO_Propuestas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[Propuestas2Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", If(newDBO_Propuestas2.Descripcion_IsDBNull = True, Convert.DBNull, newDBO_Propuestas2.Descripcion))
        updateCommand.Parameters.AddWithValue("@NewPropuestaTipoMejoraID", If(newDBO_Propuestas2.PropuestaTipoMejoraID_IsDBNull = True, Convert.DBNull, newDBO_Propuestas2.PropuestaTipoMejoraID))
        updateCommand.Parameters.AddWithValue("@NewPropuestaUrgenciaID", If(newDBO_Propuestas2.PropuestaUrgenciaID_IsDBNull = True, Convert.DBNull, newDBO_Propuestas2.PropuestaUrgenciaID))
        updateCommand.Parameters.AddWithValue("@NewPersonalID", If(newDBO_Propuestas2.PersonalID_IsDBNull = True, Convert.DBNull, newDBO_Propuestas2.PersonalID))
        updateCommand.Parameters.AddWithValue("@NewFormatoEnvasadoID", If(newDBO_Propuestas2.FormatoEnvasadoID_IsDBNull = True, Convert.DBNull, newDBO_Propuestas2.FormatoEnvasadoID))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_Propuestas2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_Propuestas2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPropuestaID", newDBO_Propuestas2.PropuestaID)
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
            MessageBox.Show("Error en UpdatePropuestas2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Propuestas2Delete(ByVal PropuestaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[Propuestas2Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPropuestaID", PropuestaID)
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

    Public Function GrabarPropuestas2(ByVal dbo_Propuestas2 As DBO_Propuestas2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If dbo_Propuestas2.PropuestaID = 0 Then
            Return Propuestas2Insert(dbo_Propuestas2, dtb)
        Else
            Return Propuestas2Update(dbo_Propuestas2, dtb)
        End If
    End Function

End Class
