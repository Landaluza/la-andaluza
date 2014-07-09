

Class spArticulosFichasPaletizados1
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosFichasPaletizados1Select]", "[dbo].[ArticulosFichasPaletizados1Insert]", _
                   "[dbo].[ArticulosFichasPaletizados1Update]", "[dbo].[ArticulosFichasPaletizados1Delete]", _
                  "ArticulosFichasPaletizados1SelectDgv", "ArticulosFichasPaletizados1SelectDgvByArticuloID")
    End Sub

    Public Function Select_Record(ByVal ArticuloFichaPaletizadoID As Int32) As DBO_ArticulosFichasPaletizados1
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ArticulosFichasPaletizados1 As New DBO_ArticulosFichasPaletizados1
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ArticulosFichasPaletizados1Select]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloFichaPaletizadoID", ArticuloFichaPaletizadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosFichasPaletizados1.ArticuloFichaPaletizadoID = If(reader("ArticuloFichaPaletizadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloFichaPaletizadoID")))
                DBO_ArticulosFichasPaletizados1.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosFichasPaletizados1.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosFichasPaletizados1.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_ArticulosFichasPaletizados1.FechaVigente = If(reader("FechaVigente") Is Convert.DBNull, System.DateTime.Now, CDate(reader("FechaVigente")))
                DBO_ArticulosFichasPaletizados1.FechaObsoleta = If(reader("FechaObsoleta") Is Convert.DBNull, System.DateTime.Now, CDate(reader("FechaObsoleta")))
                DBO_ArticulosFichasPaletizados1.Vigente = If(reader("Vigente") Is Convert.DBNull, False, Convert.ToBoolean(reader("Vigente")))
                DBO_ArticulosFichasPaletizados1.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosFichasPaletizados1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosFichasPaletizados1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosFichasPaletizados1 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ArticulosFichasPaletizados1
    End Function

    Public Function ArticulosFichasPaletizados1Insert(ByVal dbo_ArticulosFichasPaletizados1 As DBO_ArticulosFichasPaletizados1) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ArticulosFichasPaletizados1Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosFichasPaletizados1.ArticuloID.HasValue, dbo_ArticulosFichasPaletizados1.ArticuloID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosFichasPaletizados1.Descripcion)
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_ArticulosFichasPaletizados1.Ruta)
        insertCommand.Parameters.AddWithValue("@FechaVigente", If(dbo_ArticulosFichasPaletizados1.FechaVigente.HasValue, dbo_ArticulosFichasPaletizados1.FechaVigente, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaObsoleta", If(dbo_ArticulosFichasPaletizados1.FechaObsoleta.HasValue, dbo_ArticulosFichasPaletizados1.FechaObsoleta, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Vigente", dbo_ArticulosFichasPaletizados1.Vigente)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosFichasPaletizados1.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosFichasPaletizados1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosFichasPaletizados1.UsuarioModificacion)
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

    Public Function ArticulosFichasPaletizados1Update(ByVal newDBO_ArticulosFichasPaletizados1 As DBO_ArticulosFichasPaletizados1) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ArticulosFichasPaletizados1Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosFichasPaletizados1.ArticuloID.HasValue, newDBO_ArticulosFichasPaletizados1.ArticuloID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosFichasPaletizados1.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_ArticulosFichasPaletizados1.Ruta)
        updateCommand.Parameters.AddWithValue("@NewFechaVigente", If(newDBO_ArticulosFichasPaletizados1.FechaVigente.HasValue, newDBO_ArticulosFichasPaletizados1.FechaVigente, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaObsoleta", If(newDBO_ArticulosFichasPaletizados1.FechaObsoleta.HasValue, newDBO_ArticulosFichasPaletizados1.FechaObsoleta, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewVigente", newDBO_ArticulosFichasPaletizados1.Vigente)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosFichasPaletizados1.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosFichasPaletizados1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosFichasPaletizados1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloFichaPaletizadoID", newDBO_ArticulosFichasPaletizados1.ArticuloFichaPaletizadoID)
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
            MessageBox.Show("Error en UpdateArticulosFichasPaletizados1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ArticulosFichasPaletizados1Delete(ByVal ArticuloFichaPaletizadoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ArticulosFichasPaletizados1Delete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloFichaPaletizadoID", ArticuloFichaPaletizadoID)
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

    Public Sub GrabarArticulosFichasPaletizados1(ByVal dbo_ArticulosFichasPaletizados1 As DBO_ArticulosFichasPaletizados1)
        If dbo_ArticulosFichasPaletizados1.ArticuloFichaPaletizadoID = 0 Then
            ArticulosFichasPaletizados1Insert(dbo_ArticulosFichasPaletizados1)
        Else
            ArticulosFichasPaletizados1Update(dbo_ArticulosFichasPaletizados1)
        End If
    End Sub

End Class
