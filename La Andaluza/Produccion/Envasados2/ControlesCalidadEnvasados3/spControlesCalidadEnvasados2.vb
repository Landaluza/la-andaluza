

Class spControlesCalidadEnvasados2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ControlesCalidadEnvasados2Select]", "[dbo].[ControlesCalidadEnvasados2Insert]", "[dbo].[ControlesCalidadEnvasados2Update]",
                  "[dbo].[ControlesCalidadEnvasados2Delete]", "ControlesCalidadEnvasados2SelectDgv", "ControlesCalidadEnvasados2SelectDgvByControlCalidadEnvasados2ID")
    End Sub

    Public Function Select_Record(ByVal ControlCalidadEnvasados2ID As Int32) As DBO_ControlesCalidadEnvasados2
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_ControlesCalidadEnvasados2 As New DBO_ControlesCalidadEnvasados2
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[ControlesCalidadEnvasados2Select]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ControlCalidadEnvasados2ID", ControlCalidadEnvasados2ID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                
                DBO_ControlesCalidadEnvasados2.ControlCalidadEnvasados2ID = If(reader("ControlCalidadEnvasados2ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ControlCalidadEnvasados2ID")))
                DBO_ControlesCalidadEnvasados2.Botella = If(reader("Botella") Is Convert.DBNull, False, Convert.ToBoolean(reader("Botella")))
                DBO_ControlesCalidadEnvasados2.Etiqueta = If(reader("Etiqueta") Is Convert.DBNull, False, Convert.ToBoolean(reader("Etiqueta")))
                DBO_ControlesCalidadEnvasados2.LoteadoEtiqueta = If(reader("LoteadoEtiqueta") Is Convert.DBNull, False, Convert.ToBoolean(reader("LoteadoEtiqueta")))
                DBO_ControlesCalidadEnvasados2.Caja = If(reader("Caja") Is Convert.DBNull, False, Convert.ToBoolean(reader("Caja")))
                DBO_ControlesCalidadEnvasados2.LoteadoCaja = If(reader("LoteadoCaja") Is Convert.DBNull, False, Convert.ToBoolean(reader("LoteadoCaja")))
                DBO_ControlesCalidadEnvasados2.Palet = If(reader("Palet") Is Convert.DBNull, False, Convert.ToBoolean(reader("Palet")))
                DBO_ControlesCalidadEnvasados2.Muestra = If(reader("Muestra") Is Convert.DBNull, False, Convert.ToBoolean(reader("Muestra")))
                DBO_ControlesCalidadEnvasados2.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ControlesCalidadEnvasados2.Nuevo = If(reader("Nuevo") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Nuevo")))
                DBO_ControlesCalidadEnvasados2.OtroNuevo = If(reader("OtroNuevo") Is Convert.DBNull, String.Empty, Convert.ToString(reader("OtroNuevo")))
                DBO_ControlesCalidadEnvasados2.SegundoNuevo = If(reader("SegundoNuevo") Is Convert.DBNull, String.Empty, Convert.ToString(reader("SegundoNuevo")))
                DBO_ControlesCalidadEnvasados2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ControlesCalidadEnvasados2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                
            Else
                DBO_ControlesCalidadEnvasados2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return DBO_ControlesCalidadEnvasados2
    End Function

    Public Function ControlesCalidadEnvasados2Insert(ByVal dbo_ControlesCalidadEnvasados2 As DBO_ControlesCalidadEnvasados2) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[ControlesCalidadEnvasados2Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@Botella", dbo_ControlesCalidadEnvasados2.Botella)
        insertCommand.Parameters.AddWithValue("@Etiqueta", dbo_ControlesCalidadEnvasados2.Etiqueta)
        insertCommand.Parameters.AddWithValue("@LoteadoEtiqueta", dbo_ControlesCalidadEnvasados2.LoteadoEtiqueta)
        insertCommand.Parameters.AddWithValue("@Caja", dbo_ControlesCalidadEnvasados2.Caja)
        insertCommand.Parameters.AddWithValue("@LoteadoCaja", dbo_ControlesCalidadEnvasados2.LoteadoCaja)
        insertCommand.Parameters.AddWithValue("@Palet", dbo_ControlesCalidadEnvasados2.Palet)
        insertCommand.Parameters.AddWithValue("@Muestra", dbo_ControlesCalidadEnvasados2.Muestra)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ControlesCalidadEnvasados2.Observaciones)
        insertCommand.Parameters.AddWithValue("@Nuevo", dbo_ControlesCalidadEnvasados2.Nuevo)
        insertCommand.Parameters.AddWithValue("@OtroNuevo", dbo_ControlesCalidadEnvasados2.OtroNuevo)
        insertCommand.Parameters.AddWithValue("@SegundoNuevo", dbo_ControlesCalidadEnvasados2.SegundoNuevo)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ControlesCalidadEnvasados2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ControlesCalidadEnvasados2.UsuarioModificacion)
        
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

    Public Function ControlesCalidadEnvasados2Update(ByVal newDBO_ControlesCalidadEnvasados2 As DBO_ControlesCalidadEnvasados2) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[ControlesCalidadEnvasados2Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewBotella", newDBO_ControlesCalidadEnvasados2.Botella)
        updateCommand.Parameters.AddWithValue("@NewEtiqueta", newDBO_ControlesCalidadEnvasados2.Etiqueta)
        updateCommand.Parameters.AddWithValue("@NewLoteadoEtiqueta", newDBO_ControlesCalidadEnvasados2.LoteadoEtiqueta)
        updateCommand.Parameters.AddWithValue("@NewCaja", newDBO_ControlesCalidadEnvasados2.Caja)
        updateCommand.Parameters.AddWithValue("@NewLoteadoCaja", newDBO_ControlesCalidadEnvasados2.LoteadoCaja)
        updateCommand.Parameters.AddWithValue("@NewPalet", newDBO_ControlesCalidadEnvasados2.Palet)
        updateCommand.Parameters.AddWithValue("@NewMuestra", newDBO_ControlesCalidadEnvasados2.Muestra)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ControlesCalidadEnvasados2.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewNuevo", newDBO_ControlesCalidadEnvasados2.Nuevo)
        updateCommand.Parameters.AddWithValue("@NewOtroNuevo", newDBO_ControlesCalidadEnvasados2.OtroNuevo)
        updateCommand.Parameters.AddWithValue("@NewSegundoNuevo", newDBO_ControlesCalidadEnvasados2.SegundoNuevo)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ControlesCalidadEnvasados2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ControlesCalidadEnvasados2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldControlCalidadEnvasados2ID", newDBO_ControlesCalidadEnvasados2.ControlCalidadEnvasados2ID)
        '<Tag=[Three][End]> -- please do not remove this line
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
            MessageBox.Show("Error en UpdateControlesCalidadEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function ControlesCalidadEnvasados2Delete(ByVal ControlCalidadEnvasados2ID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[ControlesCalidadEnvasados2Delete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldControlCalidadEnvasados2ID", ControlCalidadEnvasados2ID)
        '<Tag=[Four][End]> -- please do not remove this line
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

    Public Function GrabarControlesCalidadEnvasados2(ByVal dbo_ControlesCalidadEnvasados2 As DBO_ControlesCalidadEnvasados2) As Boolean
        dbo_ControlesCalidadEnvasados2.FechaModificacion = System.DateTime.Now.date
        dbo_ControlesCalidadEnvasados2.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_ControlesCalidadEnvasados2.ControlCalidadEnvasados2ID = 0 Then
            Return ControlesCalidadEnvasados2Insert(dbo_ControlesCalidadEnvasados2)
        Else
            Return ControlesCalidadEnvasados2Update(dbo_ControlesCalidadEnvasados2)
        End If
    End Function

End Class
