

Class spProveedoresDocumentos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ProveedoresDocumentosSelect]", "[dbo].[ProveedoresDocumentosInsert]", _
                   "[dbo].[ProveedoresDocumentosUpdate]", "[dbo].[ProveedoresDocumentosDelete]", _
                   "ProveedoresDocumentosSelectDgv", "ProveedoresDocumentosSelectDgvByProveedorID")
    End Sub

    Public Function Select_Record(ByVal ProveedorDocumentoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ProveedoresDocumentos
        dtb.Conectar()
        Dim DBO_ProveedoresDocumentos As New DBO_ProveedoresDocumentos

        Dim selectProcedure As String = "[dbo].[ProveedoresDocumentosSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ProveedorDocumentoID", ProveedorDocumentoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ProveedoresDocumentos.ProveedorDocumentoID = If(reader("ProveedorDocumentoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorDocumentoID")))
                DBO_ProveedoresDocumentos.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                DBO_ProveedoresDocumentos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ProveedoresDocumentos.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_ProveedoresDocumentos.Fuente = If(reader("Fuente") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Fuente")))
                DBO_ProveedoresDocumentos.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_ProveedoresDocumentos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ProveedoresDocumentos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ProveedoresDocumentos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ProveedoresDocumentos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ProveedoresDocumentos
    End Function

    Public Function ProveedoresDocumentosInsert(ByVal dbo_ProveedoresDocumentos As DBO_ProveedoresDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ProveedoresDocumentosInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ProveedorID", dbo_ProveedoresDocumentos.ProveedorID)
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ProveedoresDocumentos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_ProveedoresDocumentos.Fecha)
        insertCommand.Parameters.AddWithValue("@Fuente", dbo_ProveedoresDocumentos.Fuente)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_ProveedoresDocumentos.Ruta)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ProveedoresDocumentos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ProveedoresDocumentos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ProveedoresDocumentos.UsuarioModificacion)
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

    Public Function ProveedoresDocumentosUpdate(ByVal newDBO_ProveedoresDocumentos As DBO_ProveedoresDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ProveedoresDocumentosUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewProveedorID", newDBO_ProveedoresDocumentos.ProveedorID)
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ProveedoresDocumentos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_ProveedoresDocumentos.Fecha)
        updateCommand.Parameters.AddWithValue("@NewFuente", newDBO_ProveedoresDocumentos.Fuente)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_ProveedoresDocumentos.Ruta)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ProveedoresDocumentos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ProveedoresDocumentos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ProveedoresDocumentos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldProveedorDocumentoID", newDBO_ProveedoresDocumentos.ProveedorDocumentoID)
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
            MessageBox.Show("Error en UpdateProveedoresDocumentos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ProveedoresDocumentosDelete(ByVal ProveedorDocumentoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ProveedoresDocumentosDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldProveedorDocumentoID", ProveedorDocumentoID)
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

    Public Sub GrabarProveedoresDocumentos(ByVal dbo_ProveedoresDocumentos As DBO_ProveedoresDocumentos, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_ProveedoresDocumentos.ProveedorDocumentoID = 0 Then
            ProveedoresDocumentosInsert(dbo_ProveedoresDocumentos, dtb)
        Else
            ProveedoresDocumentosUpdate(dbo_ProveedoresDocumentos, dtb)
        End If
    End Sub

End Class
