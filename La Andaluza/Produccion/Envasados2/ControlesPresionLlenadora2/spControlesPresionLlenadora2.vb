

Class spControlesPresionLlenadora2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ControlesPresionLlenadora1Select2]", "[dbo].[ControlesPresionLlenadora1Insert2]", _
                   "[dbo].[ControlesPresionLlenadora1Update2]", "[dbo].[ControlesPresionLlenadora1Delete2]", _
                   "ControlesPresionLlenadora1SelectDgv", "ControlesPresionLlenadora1SelectDgvByEnvasadoID")
    End Sub
    Public Function Select_Record(ByVal ControlPresionLlenadora1ID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ControlesPresionLlenadora2
        dtb.Conectar()
        Dim DBO_ControlesPresionLlenadora1 As New DBO_ControlesPresionLlenadora2

        Dim selectProcedure As String = "[dbo].[ControlesPresionLlenadora1Select2]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ControlPresionLlenadora1ID", ControlPresionLlenadora1ID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ControlesPresionLlenadora1.ControlPresionLlenadora1ID = If(reader("ControlPresionLlenadora1ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ControlPresionLlenadora1ID")))
                DBO_ControlesPresionLlenadora1.EnvasadoID = If(reader("EnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EnvasadoID")))
                DBO_ControlesPresionLlenadora1.VerificadorID = If(reader("VerificadorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VerificadorID")))
                DBO_ControlesPresionLlenadora1.Hora = If(reader("Hora") Is Convert.DBNull, System.DateTime.Now.TimeOfDay, reader("Hora"))
                DBO_ControlesPresionLlenadora1.Presion = If(reader("Presion") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("Presion")))
                DBO_ControlesPresionLlenadora1.Correcto = If(reader("Correcto") Is Convert.DBNull, False, Convert.ToBoolean(reader("Correcto")))
                DBO_ControlesPresionLlenadora1.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ControlesPresionLlenadora1.FechaModificacion = DateTime.Now.Date 'If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ControlesPresionLlenadora1.UsuarioModificacion = BasesParaCompatibilidad.Config.User 'If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ControlesPresionLlenadora1 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ControlesPresionLlenadora1
    End Function

    Public Function ControlesPresionLlenadora1Insert(ByVal dbo_ControlesPresionLlenadora1 As DBO_ControlesPresionLlenadora2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ControlesPresionLlenadora1Insert2]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@EnvasadoID", dbo_ControlesPresionLlenadora1.EnvasadoID)
        insertCommand.Parameters.AddWithValue("@VerificadorID", If(dbo_ControlesPresionLlenadora1.VerificadorID.HasValue, dbo_ControlesPresionLlenadora1.VerificadorID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Hora", dbo_ControlesPresionLlenadora1.Hora)
        insertCommand.Parameters.AddWithValue("@Presion", If(dbo_ControlesPresionLlenadora1.Presion.HasValue, dbo_ControlesPresionLlenadora1.Presion, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Correcto", dbo_ControlesPresionLlenadora1.Correcto)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ControlesPresionLlenadora1.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ControlesPresionLlenadora1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ControlesPresionLlenadora1.UsuarioModificacion)
        'insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        'insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            If insertCommand.ExecuteNonQuery() = 0 Then Return False
            'Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            'If count > 0 Then
            Return True
            'Else
            'Return False
            'End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ControlesPresionLlenadora1Update(ByVal newDBO_ControlesPresionLlenadora1 As DBO_ControlesPresionLlenadora2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ControlesPresionLlenadora1Update2]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@EnvasadoID", newDBO_ControlesPresionLlenadora1.EnvasadoID)
        updateCommand.Parameters.AddWithValue("@VerificadorID", If(newDBO_ControlesPresionLlenadora1.VerificadorID.HasValue, newDBO_ControlesPresionLlenadora1.VerificadorID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@Hora", newDBO_ControlesPresionLlenadora1.Hora)
        updateCommand.Parameters.AddWithValue("@Presion", If(newDBO_ControlesPresionLlenadora1.Presion.HasValue, newDBO_ControlesPresionLlenadora1.Presion, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@Correcto", newDBO_ControlesPresionLlenadora1.Correcto)
        updateCommand.Parameters.AddWithValue("@Observaciones", newDBO_ControlesPresionLlenadora1.Observaciones)
        updateCommand.Parameters.AddWithValue("@FechaModificacion", newDBO_ControlesPresionLlenadora1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@UsuarioModificacion", newDBO_ControlesPresionLlenadora1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@ControlPresionLlenadora1ID", newDBO_ControlesPresionLlenadora1.ControlPresionLlenadora1ID)
        ' updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        'updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            updateCommand.ExecuteNonQuery()
            'Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            'If count > 0 Then
            Return True
            ' Else
            ' Return False
            ' End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateControlesPresionLlenadora1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ControlesPresionLlenadora1Delete(ByVal ControlPresionLlenadora1ID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ControlesPresionLlenadora1Delete2]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@ControlPresionLlenadora1ID", ControlPresionLlenadora1ID)
        'deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        'deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            deleteCommand.ExecuteNonQuery()
            'Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            ' If count > 0 Then
            Return True
            ' Else
            'Return False
            'End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function GrabarControlesPresionLlenadora1(ByVal dbo_ControlesPresionLlenadora1 As DBO_ControlesPresionLlenadora2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_ControlesPresionLlenadora1.FechaModificacion = System.DateTime.Now.Date
        dbo_ControlesPresionLlenadora1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_ControlesPresionLlenadora1.ControlPresionLlenadora1ID = 0 Then
            Return ControlesPresionLlenadora1Insert(dbo_ControlesPresionLlenadora1, dtb)
        Else
            Return ControlesPresionLlenadora1Update(dbo_ControlesPresionLlenadora1, dtb)
        End If
    End Function

End Class
