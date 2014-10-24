

Class spArticulosTiposDocumentos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosTiposDocumentosSelect]", "[dbo].[ArticulosTiposDocumentosInsert]", "[dbo].[ArticulosTiposDocumentosUpdate]", _
                "[dbo].[ArticulosTiposDocumentosDelete]", "ArticulosTiposDocumentosSelectDgv", "ArticulosTiposDocumentosSelectDgvByArticuloTipoID")
    End Sub

    Public Function Select_Record(ByVal ArticuloTipoDocumentoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosTiposDocumentos
        dtb.Conectar()
        Dim DBO_ArticulosTiposDocumentos As New DBO_ArticulosTiposDocumentos

        Dim selectProcedure As String = "[dbo].[ArticulosTiposDocumentosSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloTipoDocumentoID", ArticuloTipoDocumentoID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosTiposDocumentos.ArticuloTipoDocumentoID = If(reader("ArticuloTipoDocumentoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloTipoDocumentoID")))
                DBO_ArticulosTiposDocumentos.ArticuloTipoID = If(reader("ArticuloTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloTipoID")))
                DBO_ArticulosTiposDocumentos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosTiposDocumentos.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now, CDate(reader("Fecha")))
                DBO_ArticulosTiposDocumentos.Fuente = If(reader("Fuente") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Fuente")))
                DBO_ArticulosTiposDocumentos.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_ArticulosTiposDocumentos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosTiposDocumentos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosTiposDocumentos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosTiposDocumentos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ArticulosTiposDocumentos
    End Function

    Public Function ArticulosTiposDocumentosInsert(ByVal dbo_ArticulosTiposDocumentos As DBO_ArticulosTiposDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ArticulosTiposDocumentosInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloTipoID", If(dbo_ArticulosTiposDocumentos.ArticuloTipoID.HasValue, dbo_ArticulosTiposDocumentos.ArticuloTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosTiposDocumentos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_ArticulosTiposDocumentos.Fecha)
        insertCommand.Parameters.AddWithValue("@Fuente", dbo_ArticulosTiposDocumentos.Fuente)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_ArticulosTiposDocumentos.Ruta)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosTiposDocumentos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosTiposDocumentos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosTiposDocumentos.UsuarioModificacion)
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

    Public Function ArticulosTiposDocumentosUpdate(ByVal newDBO_ArticulosTiposDocumentos As DBO_ArticulosTiposDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ArticulosTiposDocumentosUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloTipoID", If(newDBO_ArticulosTiposDocumentos.ArticuloTipoID.HasValue, newDBO_ArticulosTiposDocumentos.ArticuloTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosTiposDocumentos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_ArticulosTiposDocumentos.Fecha)
        updateCommand.Parameters.AddWithValue("@NewFuente", newDBO_ArticulosTiposDocumentos.Fuente)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_ArticulosTiposDocumentos.Ruta)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosTiposDocumentos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosTiposDocumentos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosTiposDocumentos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloTipoDocumentoID", newDBO_ArticulosTiposDocumentos.ArticuloTipoDocumentoID)
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
            MessageBox.Show("Error en UpdateArticulosTiposDocumentos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ArticulosTiposDocumentosDelete(ByVal ArticuloTipoDocumentoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ArticulosTiposDocumentosDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloTipoDocumentoID", ArticuloTipoDocumentoID)
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

    Public Sub GrabarArticulosTiposDocumentos(ByVal dbo_ArticulosTiposDocumentos As DBO_ArticulosTiposDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_ArticulosTiposDocumentos.ArticuloTipoDocumentoID = 0 Then
            ArticulosTiposDocumentosInsert(dbo_ArticulosTiposDocumentos, dtb)
        Else
            ArticulosTiposDocumentosUpdate(dbo_ArticulosTiposDocumentos, dtb)
        End If
    End Sub

End Class
