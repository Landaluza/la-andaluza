

Class spArticulos_ArticulosCertificadosTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[Articulos_ArticulosCertificadosTiposSelect]", "[dbo].[Articulos_ArticulosCertificadosTiposInsert2]", _
                   "[dbo].[Articulos_ArticulosCertificadosTiposUpdate2]", "[dbo].[Articulos_ArticulosCertificadosTiposDelete]", _
                   "Articulos_ArticulosCertificadosTiposSelectDgv", "Articulos_ArticulosCertificadosTiposSelectDgvByArticuloID")
    End Sub

    Public Function Select_Record(ByVal Articulo_ArticuloCertificadoTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Articulos_ArticulosCertificadosTipos
        dtb.Conectar()
        Dim DBO_Articulos_ArticulosCertificadosTipos As New DBO_Articulos_ArticulosCertificadosTipos

        Dim selectProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@Articulo_ArticuloCertificadoTipoID", Articulo_ArticuloCertificadoTipoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_Articulos_ArticulosCertificadosTipos.Articulo_ArticuloCertificadoTipoID = If(reader("Articulo_ArticuloCertificadoTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("Articulo_ArticuloCertificadoTipoID")))
                DBO_Articulos_ArticulosCertificadosTipos.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID = If(reader("ArticuloCertificadoTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloCertificadoTipoID")))
                DBO_Articulos_ArticulosCertificadosTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_Articulos_ArticulosCertificadosTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Articulos_ArticulosCertificadosTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_Articulos_ArticulosCertificadosTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_Articulos_ArticulosCertificadosTipos
    End Function

    Public Function Articulos_ArticulosCertificadosTiposInsert(ByVal dbo_Articulos_ArticulosCertificadosTipos As DBO_Articulos_ArticulosCertificadosTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_Articulos_ArticulosCertificadosTipos.ArticuloID.HasValue, dbo_Articulos_ArticulosCertificadosTipos.ArticuloID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@ArticuloCertificadoTipoID", If(dbo_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID.HasValue, dbo_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_Articulos_ArticulosCertificadosTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", Today.Date)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
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

    Public Function Articulos_ArticulosCertificadosTiposUpdate(ByVal newDBO_Articulos_ArticulosCertificadosTipos As DBO_Articulos_ArticulosCertificadosTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_Articulos_ArticulosCertificadosTipos.ArticuloID.HasValue, newDBO_Articulos_ArticulosCertificadosTipos.ArticuloID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewArticuloCertificadoTipoID", If(newDBO_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID.HasValue, newDBO_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_Articulos_ArticulosCertificadosTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", Today.Date)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
        updateCommand.Parameters.AddWithValue("@OldArticulo_ArticuloCertificadoTipoID", newDBO_Articulos_ArticulosCertificadosTipos.Articulo_ArticuloCertificadoTipoID)
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
            MessageBox.Show("Error en UpdateArticulos_ArticulosCertificadosTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Articulos_ArticulosCertificadosTiposInsertSinTransaccion(ByVal dbo_Articulos_ArticulosCertificadosTipos As DBO_Articulos_ArticulosCertificadosTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean


        Try
            Dim insertProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposInsert2]"
            Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
            insertCommand.CommandType = CommandType.StoredProcedure

            insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_Articulos_ArticulosCertificadosTipos.ArticuloID.HasValue, dbo_Articulos_ArticulosCertificadosTipos.ArticuloID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@ArticuloCertificadoTipoID", If(dbo_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID.HasValue, dbo_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@Observaciones", dbo_Articulos_ArticulosCertificadosTipos.Observaciones)
            insertCommand.Parameters.AddWithValue("@FechaModificacion", Today.Date)
            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
            insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        End Try
    End Function

    Public Function Articulos_ArticulosCertificadosTiposUpdateSinTransaccion(ByVal newDBO_Articulos_ArticulosCertificadosTipos As DBO_Articulos_ArticulosCertificadosTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean


        Try

            Dim updateProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposUpdate2]"
            Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
            updateCommand.CommandType = CommandType.StoredProcedure

            updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_Articulos_ArticulosCertificadosTipos.ArticuloID.HasValue, newDBO_Articulos_ArticulosCertificadosTipos.ArticuloID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewArticuloCertificadoTipoID", If(newDBO_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID.HasValue, newDBO_Articulos_ArticulosCertificadosTipos.ArticuloCertificadoTipoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_Articulos_ArticulosCertificadosTipos.Observaciones)
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", Today.Date)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
            updateCommand.Parameters.AddWithValue("@OldArticulo_ArticuloCertificadoTipoID", newDBO_Articulos_ArticulosCertificadosTipos.Articulo_ArticuloCertificadoTipoID)
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
            MessageBox.Show("Error en UpdateArticulos_ArticulosCertificadosTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        End Try
    End Function

    Public Function Articulos_ArticulosCertificadosTiposDelete(ByVal Articulo_ArticuloCertificadoTipoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticulo_ArticuloCertificadoTipoID", Articulo_ArticuloCertificadoTipoID)
        deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            deleteCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Articulos_ArticulosCertificadosTiposDeleteByArticuloID(ByVal ArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposDeleteByArticuloID]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticulo_ArticuloID", ArticuloID)
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

    Public Function Articulos_ArticulosCertificadosTiposDeleteByArticuloIDSinTransaccion(ByVal ArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Try
            Dim deleteProcedure As String = "[dbo].[Articulos_ArticulosCertificadosTiposDeleteByArticuloID2]"
            Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@OldArticulo_ArticuloID", ArticuloID)
            deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Sub GrabarArticulos_ArticulosCertificadosTipos(ByVal dbo_Articulos_ArticulosCertificadosTipos As DBO_Articulos_ArticulosCertificadosTipos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_Articulos_ArticulosCertificadosTipos.FechaModificacion = System.DateTime.Now.Date
        dbo_Articulos_ArticulosCertificadosTipos.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_Articulos_ArticulosCertificadosTipos.Articulo_ArticuloCertificadoTipoID = 0 Then
            Articulos_ArticulosCertificadosTiposInsert(dbo_Articulos_ArticulosCertificadosTipos, dtb)
        Else
            Articulos_ArticulosCertificadosTiposUpdate(dbo_Articulos_ArticulosCertificadosTipos, dtb)
        End If
    End Sub

    Function GrabarArticulos_ArticulosCertificadosTiposSinTransaccion(ByVal dbo_Articulos_ArticulosCertificadosTipos As DBO_Articulos_ArticulosCertificadosTipos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_Articulos_ArticulosCertificadosTipos.FechaModificacion = System.DateTime.Now.Date
        dbo_Articulos_ArticulosCertificadosTipos.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_Articulos_ArticulosCertificadosTipos.Articulo_ArticuloCertificadoTipoID = 0 Then
            Return Articulos_ArticulosCertificadosTiposInsertSinTransaccion(dbo_Articulos_ArticulosCertificadosTipos, dtb)
        Else
            Return Articulos_ArticulosCertificadosTiposUpdateSinTransaccion(dbo_Articulos_ArticulosCertificadosTipos, dtb)
        End If
    End Function

End Class
