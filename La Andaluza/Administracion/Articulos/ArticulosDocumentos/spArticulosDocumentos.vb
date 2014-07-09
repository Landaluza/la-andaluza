

Class spArticulosDocumentos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosDocumentosSelect]", "[dbo].[ArticulosDocumentosInsert]", "[dbo].[ArticulosDocumentosUpdate]", _
                   "[dbo].[ArticulosDocumentosDelete]", "ArticulosDocumentosSelectDgv", "ArticulosDocumentosSelectDgvByArticuloID")
    End Sub
    Public Function Select_Record(ByVal ArticuloDocumentoID As Int32) As DBO_ArticulosDocumentos
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosDocumentos As New DBO_ArticulosDocumentos
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosDocumentosSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloDocumentoID", ArticuloDocumentoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosDocumentos.ArticuloDocumentoID = If(reader("ArticuloDocumentoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloDocumentoID")))
                DBO_ArticulosDocumentos.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosDocumentos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosDocumentos.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now, CDate(reader("Fecha")))
                DBO_ArticulosDocumentos.Fuente = If(reader("Fuente") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Fuente")))
                DBO_ArticulosDocumentos.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_ArticulosDocumentos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosDocumentos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosDocumentos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosDocumentos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosDocumentos
    End Function

    Public Function ArticulosDocumentosInsert(ByVal dbo_ArticulosDocumentos As DBO_ArticulosDocumentos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosDocumentosInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        Dim retorno As Boolean = True
        Try

            insertCommand.CommandType = CommandType.StoredProcedure
            insertCommand.Parameters.AddWithValue("@ArticuloID", dbo_ArticulosDocumentos.ArticuloID)
            insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosDocumentos.Descripcion)
            insertCommand.Parameters.AddWithValue("@Fecha", dbo_ArticulosDocumentos.Fecha)
            insertCommand.Parameters.AddWithValue("@Fuente", dbo_ArticulosDocumentos.Fuente)
            insertCommand.Parameters.AddWithValue("@Ruta", dbo_ArticulosDocumentos.Ruta)
            insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosDocumentos.Observaciones)
            insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosDocumentos.FechaModificacion)
            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosDocumentos.UsuarioModificacion)
            insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

            
            insertCommand.ExecuteNonQuery()
            'Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            'If count > 0 Then
            '    Return True
            'Else
            '    Return False
            'End If
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show("Error al guardar." & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            retorno = False
        Finally
            connection.Close()
        End Try

        Return retorno
    End Function

    Public Function ArticulosDocumentosUpdate(ByVal newDBO_ArticulosDocumentos As DBO_ArticulosDocumentos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosDocumentosUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", newDBO_ArticulosDocumentos.ArticuloID)
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosDocumentos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_ArticulosDocumentos.Fecha)
        updateCommand.Parameters.AddWithValue("@NewFuente", newDBO_ArticulosDocumentos.Fuente)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_ArticulosDocumentos.Ruta)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosDocumentos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosDocumentos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosDocumentos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloDocumentoID", newDBO_ArticulosDocumentos.ArticuloDocumentoID)
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
            MessageBox.Show("Error en UpdateArticulosDocumentos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosDocumentosDelete(ByVal ArticuloDocumentoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosDocumentosDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloDocumentoID", ArticuloDocumentoID)
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

    Public Function GrabarArticulosDocumentos(ByVal dbo_ArticulosDocumentos As DBO_ArticulosDocumentos) As Boolean
        If dbo_ArticulosDocumentos.ArticuloDocumentoID = 0 Then
            Return ArticulosDocumentosInsert(dbo_ArticulosDocumentos)
        Else
            Return ArticulosDocumentosUpdate(dbo_ArticulosDocumentos)
        End If
    End Function

End Class
