Imports BasesParaCompatibilidad.ComboBoxExtension


Class spEpisTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[EpisTiposSelect]", "[dbo].[EpisTiposInsert]", "[dbo].[EpisTiposUpdate]", _
                   "[dbo].[EpisTiposDelete]", "EpisSelectDgv", String.Empty)
    End Sub
    Public Function Select_Record(ByVal EpiTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_EpisTipos
        dtb.Conectar()
        Dim DBO_EpisTipos As New DBO_EpisTipos

        Dim selectProcedure As String = "[dbo].[EpisTiposSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EpiTipoID", EpiTipoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_EpisTipos.EpiTipoID = If(reader("EpiTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EpiTipoID")))
                DBO_EpisTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_EpisTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_EpisTipos.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                DBO_EpisTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_EpisTipos.FechaModificacion_IsDBNull = If(reader("FechaModificacion") Is Convert.DBNull, True, False)
                DBO_EpisTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_EpisTipos.UsuarioModificacion_IsDBNull = If(reader("UsuarioModificacion") Is Convert.DBNull, True, False)
            Else
                DBO_EpisTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_EpisTipos
    End Function

    Public Function InsertEpisTipos(ByVal dbo_EpisTipos As DBO_EpisTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[EpisTiposInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_EpisTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", If(dbo_EpisTipos.Observaciones_IsDBNull = True, Convert.DBNull, dbo_EpisTipos.Observaciones))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", If(dbo_EpisTipos.FechaModificacion_IsDBNull = True, Convert.DBNull, dbo_EpisTipos.FechaModificacion))
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", If(dbo_EpisTipos.UsuarioModificacion_IsDBNull = True, Convert.DBNull, dbo_EpisTipos.UsuarioModificacion))
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

    Public Function UpdateEpisTipos(ByVal oldDBO_EpisTipos As DBO_EpisTipos, ByVal newDBO_EpisTipos As DBO_EpisTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[EpisTiposUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_EpisTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", If(newDBO_EpisTipos.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_EpisTipos.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", If(newDBO_EpisTipos.FechaModificacion_IsDBNull = True, Convert.DBNull, newDBO_EpisTipos.FechaModificacion))
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", If(newDBO_EpisTipos.UsuarioModificacion_IsDBNull = True, Convert.DBNull, newDBO_EpisTipos.UsuarioModificacion))
        updateCommand.Parameters.AddWithValue("@OldEpiTipoID", oldDBO_EpisTipos.EpiTipoID)
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
            MessageBox.Show("Error en UpdateEpisTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function DeleteEpisTipos(ByVal EpiTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[EpisTiposDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldEpiTipoID", EpiTipoID)
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

    Public Sub cargar_combo(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("[EPIsTiposSelectCbo]", False, dtb)
    End Sub
End Class
