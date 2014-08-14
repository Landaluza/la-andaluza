


Class spArticulosGranelesTipos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosGranelesTiposSelect]", "[dbo].[ArticulosGranelesTiposInsert]", "[dbo].[ArticulosGranelesTiposUpdate]", _
                   "[dbo].[ArticulosGranelesTiposDelete]", "ArticulosGranelesTiposSelectDgv", "ArticulosGranelesTiposSelectDgvByGranelTipoID")
    End Sub

    Public Function Select_Record(ByVal GranelTipoID As Int32) As DBO_ArticulosGranelesTipos
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosGranelesTipos As New DBO_ArticulosGranelesTipos
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosGranelesTiposSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@GranelTipoID", GranelTipoID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosGranelesTipos.GranelTipoID = If(reader("GranelTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("GranelTipoID")))
                DBO_ArticulosGranelesTipos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosGranelesTipos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosGranelesTipos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosGranelesTipos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosGranelesTipos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosGranelesTipos
    End Function

    Public Function ArticulosGranelesTiposInsert(ByVal dbo_ArticulosGranelesTipos As DBO_ArticulosGranelesTipos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosGranelesTiposInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosGranelesTipos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosGranelesTipos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosGranelesTipos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosGranelesTipos.UsuarioModificacion)
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

    Public Function ArticulosGranelesTiposUpdate(ByVal newDBO_ArticulosGranelesTipos As DBO_ArticulosGranelesTipos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosGranelesTiposUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosGranelesTipos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosGranelesTipos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosGranelesTipos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosGranelesTipos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldGranelTipoID", newDBO_ArticulosGranelesTipos.GranelTipoID)
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
            MessageBox.Show("Error en UpdateArticulosGranelesTipos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosGranelesTiposDelete(ByVal GranelTipoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosGranelesTiposDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldGranelTipoID", GranelTipoID)
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

    Public Sub GrabarArticulosGranelesTipos(ByVal dbo_ArticulosGranelesTipos As DBO_ArticulosGranelesTipos)
        If dbo_ArticulosGranelesTipos.GranelTipoID = 0 Then
            ArticulosGranelesTiposInsert(dbo_ArticulosGranelesTipos)
        Else
            ArticulosGranelesTiposUpdate(dbo_ArticulosGranelesTipos)
        End If
    End Sub

End Class
