

Class spVisitasTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[VisitasTiposSelect]", "[dbo].[VisitasTiposInsert]", "[dbo].[VisitasTiposUpdate]", "[dbo].[VisitasTiposDelete]", "VisitasTiposSelectDgv", "VisitasTiposSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal VisitaTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_VisitasTipos
        dtb.Conectar()
        Dim DBO_VisitasTipos As New DBO_VisitasTipos

        Dim selectProcedure As String = "[dbo].[VisitasTiposSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand
        Dim reader As System.Data.SqlClient.SqlDataReader
        Try

            selectCommand = dtb.Comando(selectProcedure)
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@VisitaTipoID", VisitaTipoID)

            reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_VisitasTipos.VisitaTipoID = If(reader("VisitaTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("VisitaTipoID")))
                DBO_VisitasTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_VisitasTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_VisitasTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_VisitasTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_VisitasTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_VisitasTipos
    End Function

    Public Function VisitasTiposInsert(ByVal dbo_VisitasTipos As DBO_VisitasTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[VisitasTiposInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_VisitasTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_VisitasTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_VisitasTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_VisitasTipos.UsuarioModificacion)

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

    Public Function VisitasTiposUpdate(ByVal newDBO_VisitasTipos As DBO_VisitasTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[VisitasTiposUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_VisitasTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_VisitasTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_VisitasTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_VisitasTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldVisitaTipoID", newDBO_VisitasTipos.VisitaTipoID)
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
            MessageBox.Show("Error en UpdateVisitasTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function VisitasTiposDelete(ByVal VisitaTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[VisitasTiposDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldVisitaTipoID", VisitaTipoID)
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

    Public Sub GrabarVisitasTipos(ByVal dbo_VisitasTipos As DBO_VisitasTipos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_VisitasTipos.FechaModificacion = System.DateTime.Now.Date
        dbo_VisitasTipos.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_VisitasTipos.VisitaTipoID = 0 Then
            VisitasTiposInsert(dbo_VisitasTipos, dtb)
        Else
            VisitasTiposUpdate(dbo_VisitasTipos, dtb)
        End If
    End Sub

End Class
