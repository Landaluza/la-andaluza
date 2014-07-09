Imports BasesParaCompatibilidad.ComboBoxExtension


Class spArticulosGraneles
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosGranelesSelect]", "[dbo].[ArticulosGranelesInsert2]", "[dbo].[ArticulosGranelesUpdate2]", _
                   "[dbo].[ArticulosGranelesDelete]", String.Empty, String.Empty)
    End Sub

    Public Function Select_Record(ByVal GranelID As Int32) As DBO_ArticulosGraneles
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosGraneles As New DBO_ArticulosGraneles
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosGranelesSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@GranelID", GranelID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosGraneles.GranelID = If(reader("GranelID") Is Convert.DBNull, 0, Convert.ToInt32(reader("GranelID")))
                DBO_ArticulosGraneles.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosGraneles.GranelTipoID = If(reader("GranelTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("GranelTipoID")))
                DBO_ArticulosGraneles.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosGraneles.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_ArticulosGraneles.TipoProductoID = If(reader("id_TipoProducto") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_TipoProducto")))
                DBO_ArticulosGraneles.UnidadID = If(reader("id_unidadMedida") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_unidadMedida")))
                DBO_ArticulosGraneles.Densidad = If(reader("densidad") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("densidad")))
                DBO_ArticulosGraneles.Densidad = If(reader("cantidad_elaborar_defecto") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("densidad")))

            Else
                DBO_ArticulosGraneles = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosGraneles
    End Function

    Public Function Select_RecordByArticuloID(ByVal ArticuloID As Int32) As DBO_ArticulosGraneles
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosGraneles As New DBO_ArticulosGraneles
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosGranelesSelectByArticuloID]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloID", ArticuloID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosGraneles.GranelID = If(reader("GranelID") Is Convert.DBNull, 0, Convert.ToInt32(reader("GranelID")))
                DBO_ArticulosGraneles.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosGraneles.GranelTipoID = If(reader("GranelTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("GranelTipoID")))
                DBO_ArticulosGraneles.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosGraneles.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_ArticulosGraneles.TipoProductoID = If(reader("id_TipoProducto") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_TipoProducto")))
                DBO_ArticulosGraneles.UnidadID = If(reader("id_unidadMedida") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_unidadMedida")))
                DBO_ArticulosGraneles.Densidad = If(reader("densidad") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("densidad")))
                DBO_ArticulosGraneles.Cantidad_elaborar_defecto = If(reader("cantidad_elaborar_defecto") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("cantidad_elaborar_defecto")))

            Else
                'Si cambiamos el tipo no va a encontrar este ArticuloID, en lugar de igualarlo a Nothing lo dejamos sin valores
                'DBO_ArticulosGraneles = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosGraneles
    End Function

    Public Function ArticulosGranelesInsert(ByVal dbo_ArticulosGraneles As DBO_ArticulosGraneles) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosGranelesInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosGraneles.ArticuloID.HasValue, dbo_ArticulosGraneles.ArticuloID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@GranelTipoID", If(dbo_ArticulosGraneles.GranelTipoID.HasValue, dbo_ArticulosGraneles.GranelTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosGraneles.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosGraneles.UsuarioModificacion)
        insertCommand.Parameters.AddWithValue("@id_TipoProducto", dbo_ArticulosGraneles.TipoProductoID)
        insertCommand.Parameters.AddWithValue("@id_unidadMedida", dbo_ArticulosGraneles.UnidadID)
        insertCommand.Parameters.AddWithValue("@densidad", dbo_ArticulosGraneles.Densidad)
        insertCommand.Parameters.AddWithValue("@cantidad_elaborar_defecto", dbo_ArticulosGraneles.Cantidad_elaborar_defecto)
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

    Public Function ArticulosGranelesUpdate(ByVal newDBO_ArticulosGraneles As DBO_ArticulosGraneles) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosGranelesUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosGraneles.ArticuloID.HasValue, newDBO_ArticulosGraneles.ArticuloID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewGranelTipoID", If(newDBO_ArticulosGraneles.GranelTipoID.HasValue, newDBO_ArticulosGraneles.GranelTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosGraneles.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosGraneles.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@id_TipoProducto", newDBO_ArticulosGraneles.TipoProductoID)
        updateCommand.Parameters.AddWithValue("@OldGranelID", newDBO_ArticulosGraneles.GranelID)
        updateCommand.Parameters.AddWithValue("@id_unidadMedida", newDBO_ArticulosGraneles.UnidadID)
        updateCommand.Parameters.AddWithValue("@densidad", newDBO_ArticulosGraneles.Densidad)
        updateCommand.Parameters.AddWithValue("@cantidad_elaborar_defecto", newDBO_ArticulosGraneles.Cantidad_elaborar_defecto)
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
            MessageBox.Show("Error en UpdateArticulosGraneles" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosGranelesInsertSinTransaccion(ByVal dbo_ArticulosGraneles As DBO_ArticulosGraneles, ByRef mytrans As SqlClient.SqlTransaction) As Boolean

        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Try
            Dim insertProcedure As String = "[dbo].[ArticulosGranelesInsert2]"
            Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
            insertCommand.CommandType = CommandType.StoredProcedure
            insertCommand.Transaction = mytrans
            insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosGraneles.ArticuloID.HasValue, dbo_ArticulosGraneles.ArticuloID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@GranelTipoID", If(dbo_ArticulosGraneles.GranelTipoID.HasValue, dbo_ArticulosGraneles.GranelTipoID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosGraneles.FechaModificacion)
            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosGraneles.UsuarioModificacion)
            insertCommand.Parameters.AddWithValue("@id_TipoProducto", dbo_ArticulosGraneles.TipoProductoID)
            insertCommand.Parameters.AddWithValue("@id_unidadMedida", dbo_ArticulosGraneles.UnidadID)
            insertCommand.Parameters.AddWithValue("@densidad", dbo_ArticulosGraneles.Densidad)
            insertCommand.Parameters.AddWithValue("@cantidad_elaborar_defecto", dbo_ArticulosGraneles.Cantidad_elaborar_defecto)
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

    Public Function ArticulosGranelesUpdateSinTransaccion(ByVal newDBO_ArticulosGraneles As DBO_ArticulosGraneles, ByRef mytrans As SqlClient.SqlTransaction) As Boolean

        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Try 'cantidad_elaborar_defecto
            Dim updateProcedure As String = "[dbo].[ArticulosGranelesUpdate2]"
            Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
            updateCommand.CommandType = CommandType.StoredProcedure
            updateCommand.Transaction = mytrans
            updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosGraneles.ArticuloID.HasValue, newDBO_ArticulosGraneles.ArticuloID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewGranelTipoID", If(newDBO_ArticulosGraneles.GranelTipoID.HasValue, newDBO_ArticulosGraneles.GranelTipoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosGraneles.FechaModificacion)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosGraneles.UsuarioModificacion)
            updateCommand.Parameters.AddWithValue("@id_TipoProducto", newDBO_ArticulosGraneles.TipoProductoID)
            updateCommand.Parameters.AddWithValue("@OldGranelID", newDBO_ArticulosGraneles.GranelID)
            updateCommand.Parameters.AddWithValue("@id_unidadMedida", newDBO_ArticulosGraneles.UnidadID)
            updateCommand.Parameters.AddWithValue("@densidad", newDBO_ArticulosGraneles.Densidad)
            updateCommand.Parameters.AddWithValue("@cantidad_elaborar_defecto", newDBO_ArticulosGraneles.Cantidad_elaborar_defecto)
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
            MessageBox.Show("Error en UpdateArticulosGraneles" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        End Try
    End Function

    Public Function ArticulosGranelesDelete(ByVal GranelID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosGranelesDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldGranelID", GranelID)
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

    Public Sub GrabarArticulosGraneles(ByVal dbo_ArticulosGraneles As DBO_ArticulosGraneles)
        If dbo_ArticulosGraneles.GranelID = 0 Then
            ArticulosGranelesInsert(dbo_ArticulosGraneles)
        Else
            ArticulosGranelesUpdate(dbo_ArticulosGraneles)
        End If
    End Sub

    Public Function GrabarArticulosGranelesSinTransaccion(ByVal dbo_ArticulosGraneles As DBO_ArticulosGraneles, ByRef mytrans As SqlClient.SqlTransaction) As Boolean
        If dbo_ArticulosGraneles.GranelID = 0 Then
            Return ArticulosGranelesInsertSinTransaccion(dbo_ArticulosGraneles, mytrans)
        Else
            Return ArticulosGranelesUpdateSinTransaccion(dbo_ArticulosGraneles, mytrans)
        End If
    End Function

    Sub cargar_ArticulosGraneles(comboBox As ComboBox)
        comboBox.mam_DataSource("ArticulosGranelesCbo", False)
    End Sub

End Class
