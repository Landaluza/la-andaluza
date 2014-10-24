

Class spPagosFormas
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PagosFormasSelect]", "[dbo].[PagosFormasInsert]", "[dbo].[PagosFormasUpdate]", _
                   "[dbo].[PagosFormasDelete]", "PagosFormasSelectDgv", "PagosFormasSelectDgvByID")
    End Sub
    Public Function Select_Record(ByVal PagoFormaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PagosFormas
        dtb.Conectar()
        Dim DBO_PagosFormas As New DBO_PagosFormas

        Dim selectProcedure As String = "[dbo].[PagosFormasSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PagoFormaID", PagoFormaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_PagosFormas.PagoFormaID = If(reader("PagoFormaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PagoFormaID")))
                DBO_PagosFormas.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_PagosFormas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PagosFormas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PagosFormas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_PagosFormas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_PagosFormas
    End Function

    Public Function PagosFormasInsert(ByVal dbo_PagosFormas As DBO_PagosFormas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PagosFormasInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_PagosFormas.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PagosFormas.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PagosFormas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PagosFormas.UsuarioModificacion)
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

    Public Function PagosFormasUpdate(ByVal newDBO_PagosFormas As DBO_PagosFormas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PagosFormasUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_PagosFormas.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PagosFormas.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PagosFormas.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PagosFormas.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPagoFormaID", newDBO_PagosFormas.PagoFormaID)
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
            MessageBox.Show("Error en UpdatePagosFormas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function PagosFormasDelete(ByVal PagoFormaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[PagosFormasDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPagoFormaID", PagoFormaID)
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

    Public Sub GrabarPagosFormas(ByVal dbo_PagosFormas As DBO_PagosFormas, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_PagosFormas.PagoFormaID = 0 Then
            PagosFormasInsert(dbo_PagosFormas, dtb)
        Else
            PagosFormasUpdate(dbo_PagosFormas, dtb)
        End If
    End Sub

End Class
