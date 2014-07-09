

Class spArticulosUnidadesMedidas
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.new("[dbo].[ArticulosUnidadesMedidasSelect]", "[dbo].[ArticulosUnidadesMedidasInsert]", _
         "[dbo].[ArticulosUnidadesMedidasUpdate]", "[dbo].[ArticulosUnidadesMedidasDelete]", _
         "ArticulosUnidadesMedidasSelectDgv", "ArticulosUnidadesMedidasSelectDgvByArticuloUnidadMedidaID")

    End Sub

    Public Function Select_Record(ByVal ArticuloUnidadMedidaID As Int32) As DBO_ArticulosUnidadesMedidas
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosUnidadesMedidas As New DBO_ArticulosUnidadesMedidas
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosUnidadesMedidasSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloUnidadMedidaID", ArticuloUnidadMedidaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosUnidadesMedidas.ArticuloUnidadMedidaID = If(reader("ArticuloUnidadMedidaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloUnidadMedidaID")))
                DBO_ArticulosUnidadesMedidas.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosUnidadesMedidas.Abreviatura = If(reader("Abreviatura") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Abreviatura")))
                DBO_ArticulosUnidadesMedidas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosUnidadesMedidas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosUnidadesMedidas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosUnidadesMedidas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosUnidadesMedidas
    End Function

    Public Function ArticulosUnidadesMedidasInsert(ByVal dbo_ArticulosUnidadesMedidas As DBO_ArticulosUnidadesMedidas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosUnidadesMedidasInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosUnidadesMedidas.Descripcion)
        insertCommand.Parameters.AddWithValue("@Abreviatura", dbo_ArticulosUnidadesMedidas.Abreviatura)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosUnidadesMedidas.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosUnidadesMedidas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosUnidadesMedidas.UsuarioModificacion)
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

    Public Function ArticulosUnidadesMedidasUpdate(ByVal newDBO_ArticulosUnidadesMedidas As DBO_ArticulosUnidadesMedidas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosUnidadesMedidasUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosUnidadesMedidas.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewAbreviatura", newDBO_ArticulosUnidadesMedidas.Abreviatura)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosUnidadesMedidas.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosUnidadesMedidas.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosUnidadesMedidas.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloUnidadMedidaID", newDBO_ArticulosUnidadesMedidas.ArticuloUnidadMedidaID)
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
            MessageBox.Show("Error en UpdateArticulosUnidadesMedidas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosUnidadesMedidasDelete(ByVal ArticuloUnidadMedidaID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosUnidadesMedidasDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloUnidadMedidaID", ArticuloUnidadMedidaID)
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

    Public Sub GrabarArticulosUnidadesMedidas(ByVal dbo_ArticulosUnidadesMedidas As DBO_ArticulosUnidadesMedidas)
        If dbo_ArticulosUnidadesMedidas.ArticuloUnidadMedidaID = 0 Then
            ArticulosUnidadesMedidasInsert(dbo_ArticulosUnidadesMedidas)
        Else
            ArticulosUnidadesMedidasUpdate(dbo_ArticulosUnidadesMedidas)
        End If
    End Sub

End Class
