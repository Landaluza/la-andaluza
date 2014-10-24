

Class spVisitasMotivos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[VisitasMotivosSelect]", "[dbo].[VisitasMotivosInsert]", _
                   "[dbo].[VisitasMotivosUpdate]", "[dbo].[VisitasMotivosDelete]", _
                   "VisitasMotivosSelectDgv", "VisitasMotivosSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal VisitaMotivoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_VisitasMotivos
        dtb.Conectar()
        Dim DBO_VisitasMotivos As New DBO_VisitasMotivos

        Dim selectProcedure As String = "[dbo].[VisitasMotivosSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@VisitaMotivoID", VisitaMotivoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_VisitasMotivos.VisitaMotivoID = If(reader("VisitaMotivoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaMotivoID")))
                DBO_VisitasMotivos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_VisitasMotivos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_VisitasMotivos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_VisitasMotivos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_VisitasMotivos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_VisitasMotivos
    End Function

    Public Function VisitasMotivosInsert(ByVal dbo_VisitasMotivos As DBO_VisitasMotivos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[VisitasMotivosInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_VisitasMotivos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_VisitasMotivos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_VisitasMotivos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_VisitasMotivos.UsuarioModificacion)

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

    Public Function VisitasMotivosUpdate(ByVal newDBO_VisitasMotivos As DBO_VisitasMotivos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[VisitasMotivosUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_VisitasMotivos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_VisitasMotivos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_VisitasMotivos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_VisitasMotivos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldVisitaMotivoID", newDBO_VisitasMotivos.VisitaMotivoID)
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
            MessageBox.Show("Error en UpdateVisitasMotivos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function VisitasMotivosDelete(ByVal VisitaMotivoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[VisitasMotivosDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldVisitaMotivoID", VisitaMotivoID)
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

    Public Sub GrabarVisitasMotivos(ByVal dbo_VisitasMotivos As DBO_VisitasMotivos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_VisitasMotivos.FechaModificacion = System.DateTime.Now.Date
        dbo_VisitasMotivos.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_VisitasMotivos.VisitaMotivoID = 0 Then
            VisitasMotivosInsert(dbo_VisitasMotivos, dtb)
        Else
            VisitasMotivosUpdate(dbo_VisitasMotivos, dtb)
        End If
    End Sub

End Class
