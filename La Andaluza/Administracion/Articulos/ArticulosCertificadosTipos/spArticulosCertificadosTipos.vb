

Class spArticulosCertificadosTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosCertificadosTiposSelect]", "[dbo].[ArticulosCertificadosTiposInsert]", "[dbo].[ArticulosCertificadosTiposUpdate]", _
                "[dbo].[ArticulosCertificadosTiposDelete]", "ArticulosCertificadosTiposSelectDgv", "ArticulosCertificadosTiposSelectDgvByID")

    End Sub

    Public Function Select_Record(ByVal ArticuloCertificadoTipoID As Int32) As DBO_ArticulosCertificadosTipos
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosCertificadosTipos As New DBO_ArticulosCertificadosTipos
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosCertificadosTiposSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloCertificadoTipoID", ArticuloCertificadoTipoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosCertificadosTipos.ArticuloCertificadoTipoID = If(reader("ArticuloCertificadoTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloCertificadoTipoID")))
                DBO_ArticulosCertificadosTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosCertificadosTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosCertificadosTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosCertificadosTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosCertificadosTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosCertificadosTipos
    End Function

    Public Function ArticulosCertificadosTiposInsert(ByVal dbo_ArticulosCertificadosTipos As DBO_ArticulosCertificadosTipos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosCertificadosTiposInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosCertificadosTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosCertificadosTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosCertificadosTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosCertificadosTipos.UsuarioModificacion)
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
            connection.Close()
        End Try
    End Function

    Public Function ArticulosCertificadosTiposUpdate(ByVal newDBO_ArticulosCertificadosTipos As DBO_ArticulosCertificadosTipos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosCertificadosTiposUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosCertificadosTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosCertificadosTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosCertificadosTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosCertificadosTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloCertificadoTipoID", newDBO_ArticulosCertificadosTipos.ArticuloCertificadoTipoID)
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
            MessageBox.Show("Error en UpdateArticulosCertificadosTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosCertificadosTiposDelete(ByVal ArticuloCertificadoTipoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosCertificadosTiposDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloCertificadoTipoID", ArticuloCertificadoTipoID)
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
            connection.Close()
        End Try
    End Function

    Public Sub GrabarArticulosCertificadosTipos(ByVal dbo_ArticulosCertificadosTipos As DBO_ArticulosCertificadosTipos)
        dbo_ArticulosCertificadosTipos.FechaModificacion = System.DateTime.Now.Date
        dbo_ArticulosCertificadosTipos.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_ArticulosCertificadosTipos.ArticuloCertificadoTipoID = 0 Then
            ArticulosCertificadosTiposInsert(dbo_ArticulosCertificadosTipos)
        Else
            ArticulosCertificadosTiposUpdate(dbo_ArticulosCertificadosTipos)
        End If
    End Sub

End Class
