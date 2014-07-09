

Class spPagosPlazos
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PagosPlazosSelect]", "[dbo].[PagosPlazosInsert]", "[dbo].[PagosPlazosUpdate]", _
                   "[dbo].[PagosPlazosDelete]", "PagosPlazosSelectDgv", "PagosPlazosSelectDgvByID")
    End Sub

    Public Function Select_Record(ByVal PagoPlazoID As Int32) As DBO_PagosPlazos
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_PagosPlazos As New DBO_PagosPlazos
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PagosPlazosSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PagoPlazoID", PagoPlazoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_PagosPlazos.PagoPlazoID = If(reader("PagoPlazoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PagoPlazoID")))
                DBO_PagosPlazos.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_PagosPlazos.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PagosPlazos.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PagosPlazos.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_PagosPlazos = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            DBO_PagosPlazos = Nothing
        Finally
            connection.Close()
        End Try
        Return DBO_PagosPlazos
    End Function

    Public Function PagosPlazosInsert(ByVal dbo_PagosPlazos As DBO_PagosPlazos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[PagosPlazosInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_PagosPlazos.Descripcion)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PagosPlazos.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PagosPlazos.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PagosPlazos.UsuarioModificacion)
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

    Public Function PagosPlazosUpdate(ByVal newDBO_PagosPlazos As DBO_PagosPlazos) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PagosPlazosUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_PagosPlazos.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PagosPlazos.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PagosPlazos.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PagosPlazos.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPagoPlazoID", newDBO_PagosPlazos.PagoPlazoID)
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
            MessageBox.Show("Error en UpdatePagosPlazos" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function PagosPlazosDelete(ByVal PagoPlazoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[PagosPlazosDelete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldPagoPlazoID", PagoPlazoID)
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

    Public Sub GrabarPagosPlazos(ByVal dbo_PagosPlazos As DBO_PagosPlazos)
        If dbo_PagosPlazos.PagoPlazoID = 0 Then
            PagosPlazosInsert(dbo_PagosPlazos)
        Else
            PagosPlazosUpdate(dbo_PagosPlazos)
        End If
    End Sub

End Class
