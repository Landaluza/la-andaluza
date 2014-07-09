

Public Class spMaterialesEnvasados2
    inherits BasesParaCompatibilidad.sp
    Public Sub New()
        MyBase.New("[dbo].[MaterialesEnvasados2Select]", "[dbo].[MaterialesEnvasados2Insert]", "[dbo].[MaterialesEnvasados2Update]", "[dbo].[MaterialesEnvasados2Delete]", "MaterialesEnvasados2SelectPorFormatoEnvasado ", "MaterialesEnvasados2SelectPorFormatoEnvasado ")
    End Sub
    Public Function Select_Record(ByVal MaterialEnvasadoID As Int32) As DBO_MaterialesEnvasados2
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_MaterialesEnvasados2 As New DBO_MaterialesEnvasados2
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[MaterialesEnvasados2Select]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@MaterialEnvasadoID", MaterialEnvasadoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_MaterialesEnvasados2.MaterialEnvasadoID = If(reader("MaterialEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MaterialEnvasadoID")))
                DBO_MaterialesEnvasados2.HoraInicio = If(reader("HoraInicio") Is Convert.DBNull, System.DateTime.Now.TimeOfDay, reader("HoraInicio"))
                DBO_MaterialesEnvasados2.HoraInicio_IsDBNull = If(reader("HoraInicio") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.HoraFin = If(reader("HoraFin") Is Convert.DBNull, System.DateTime.Now, reader("HoraFin"))

                DBO_MaterialesEnvasados2.HoraFin_IsDBNull = If(reader("HoraFin") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_MaterialesEnvasados2.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.Lote = If(reader("Lote") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Lote")))
                DBO_MaterialesEnvasados2.Lote_IsDBNull = If(reader("Lote") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.Cantidad = If(reader("Cantidad") Is Convert.DBNull, 0, Convert.ToInt32(reader("Cantidad")))
                DBO_MaterialesEnvasados2.Cantidad_IsDBNull = If(reader("Cantidad") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.TipoMaterialID = If(reader("TipoMaterialID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoMaterialID")))
                DBO_MaterialesEnvasados2.TipoMaterialID_IsDBNull = If(reader("TipoMaterialID") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                DBO_MaterialesEnvasados2.ProveedorID_IsDBNull = If(reader("ProveedorID") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.FormatoEnvasadoID = If(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoEnvasadoID")))
                DBO_MaterialesEnvasados2.FormatoEnvasadoID_IsDBNull = If(reader("FormatoEnvasadoID") Is Convert.DBNull, True, False)
                DBO_MaterialesEnvasados2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_MaterialesEnvasados2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_MaterialesEnvasados2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_MaterialesEnvasados2
    End Function

    Public Function MaterialesEnvasados2Insert(ByVal dbo_MaterialesEnvasados2 As DBO_MaterialesEnvasados2) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[MaterialesEnvasados2Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@HoraInicio", if(dbo_MaterialesEnvasados2.HoraInicio_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.HoraInicio))
        insertCommand.Parameters.AddWithValue("@HoraFin", if(dbo_MaterialesEnvasados2.HoraFin_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.HoraFin))
        insertCommand.Parameters.AddWithValue("@Observaciones", if(dbo_MaterialesEnvasados2.Observaciones_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.Observaciones))
        insertCommand.Parameters.AddWithValue("@Lote", if(dbo_MaterialesEnvasados2.Lote_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.Lote))
        insertCommand.Parameters.AddWithValue("@Cantidad", if(dbo_MaterialesEnvasados2.Cantidad_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.Cantidad))
        insertCommand.Parameters.AddWithValue("@TipoMaterialID", if(dbo_MaterialesEnvasados2.TipoMaterialID_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.TipoMaterialID))
        insertCommand.Parameters.AddWithValue("@ProveedorID", if(dbo_MaterialesEnvasados2.ProveedorID_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.ProveedorID))
        insertCommand.Parameters.AddWithValue("@FormatoEnvasadoID", if(dbo_MaterialesEnvasados2.FormatoEnvasadoID_IsDBNull = True, Convert.DBNull, dbo_MaterialesEnvasados2.FormatoEnvasadoID))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_MaterialesEnvasados2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_MaterialesEnvasados2.UsuarioModificacion)
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
            connection.Close()
        End Try
    End Function

    Public Function MaterialesEnvasados2Update(ByVal newDBO_MaterialesEnvasados2 As DBO_MaterialesEnvasados2) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[MaterialesEnvasados2Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewHoraInicio", if(newDBO_MaterialesEnvasados2.HoraInicio_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.HoraInicio))
        updateCommand.Parameters.AddWithValue("@NewHoraFin", if(newDBO_MaterialesEnvasados2.HoraFin_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.HoraFin))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", if(newDBO_MaterialesEnvasados2.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewLote", if(newDBO_MaterialesEnvasados2.Lote_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.Lote))
        updateCommand.Parameters.AddWithValue("@NewCantidad", if(newDBO_MaterialesEnvasados2.Cantidad_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.Cantidad))
        updateCommand.Parameters.AddWithValue("@NewTipoMaterialID", if(newDBO_MaterialesEnvasados2.TipoMaterialID_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.TipoMaterialID))
        updateCommand.Parameters.AddWithValue("@NewProveedorID", if(newDBO_MaterialesEnvasados2.ProveedorID_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.ProveedorID))
        updateCommand.Parameters.AddWithValue("@NewFormatoEnvasadoID", if(newDBO_MaterialesEnvasados2.FormatoEnvasadoID_IsDBNull = True, Convert.DBNull, newDBO_MaterialesEnvasados2.FormatoEnvasadoID))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_MaterialesEnvasados2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_MaterialesEnvasados2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldMaterialEnvasadoID", newDBO_MaterialesEnvasados2.MaterialEnvasadoID)
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
            MessageBox.Show("Error en UpdateMaterialesEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function MaterialesEnvasados2Delete(ByVal MaterialEnvasadoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim deleteProcedure As String = "[dbo].[MaterialesEnvasados2Delete]"
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldMaterialEnvasadoID", MaterialEnvasadoID)
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
            connection.Close()
        End Try
    End Function

    Public Function GrabarMaterialesEnvasados2(ByVal dbo_MaterialesEnvasados2 As DBO_MaterialesEnvasados2) As Boolean
        If dbo_MaterialesEnvasados2.MaterialEnvasadoID = 0 Then
            Return MaterialesEnvasados2Insert(dbo_MaterialesEnvasados2)
        Else
            Return MaterialesEnvasados2Update(dbo_MaterialesEnvasados2)
        End If
    End Function

    Public Function selectProveedorMasUsado(ByVal p1 As Integer, ByVal p2 As Integer) As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec ProveedoresSelectMasUsadoPorTipoMaterial " & p1 & "," & p2, False).Rows(0).Item(0)
    End Function

End Class
