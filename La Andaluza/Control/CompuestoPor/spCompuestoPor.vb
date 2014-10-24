

Class spCompuestoPor
    inherits BasesParaCompatibilidad.sp
    Public DataGridViewStoredProcedureForFilteredSelect2 As String = "CompuestoPorDgvByLoteFinal"
    Public DataGridViewStoredProcedureForFilteredSelect3 As String = "CompuestoPorDgvByLotePartida"
    Public Sub New()
        MyBase.new("[dbo].[CompuestoPorSelect]", "[dbo].[CompuestoPorInsert]", "[dbo].[CompuestoPorUpdate]", _
                   "[dbo].[CompuestoPorDelete]", "CompuestoPorSelectDgv", "CompuestoPorSelectDgvByLotePartida")
    End Sub

    Public Function Select_Record(ByVal LoteFinal As Int32, ByVal LotePartida As Int32, ByVal MovimientoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CompuestoPor
        dtb.Conectar()
        Dim DBO_CompuestoPor As New DBO_CompuestoPor

        Dim selectProcedure As String = "[dbo].[CompuestoPorSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@LoteFinal", LoteFinal)
        selectCommand.Parameters.AddWithValue("@LotePartida", LotePartida)
        selectCommand.Parameters.AddWithValue("@MovimientoID", MovimientoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_CompuestoPor.LoteFinal = If(reader("LoteFinal") Is Convert.DBNull, 0, Convert.ToInt32(reader("LoteFinal")))
                DBO_CompuestoPor.LotePartida = If(reader("LotePartida") Is Convert.DBNull, 0, Convert.ToInt32(reader("LotePartida")))
                DBO_CompuestoPor.MovimientoID = If(reader("MovimientoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MovimientoID")))
                DBO_CompuestoPor.Cantidad = System.Convert.ToDouble(If(reader("Cantidad") Is Convert.DBNull, 0, reader("Cantidad")))
                DBO_CompuestoPor.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_CompuestoPor.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_CompuestoPor = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_CompuestoPor
    End Function

    Public Function CompuestoPorInsert(ByVal dbo_CompuestoPor As DBO_CompuestoPor, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[CompuestoPorInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure


        insertCommand.Parameters.AddWithValue("@LoteFinal", dbo_CompuestoPor.LoteFinal)
        insertCommand.Parameters.AddWithValue("@LotePartida", dbo_CompuestoPor.LotePartida)
        insertCommand.Parameters.AddWithValue("@MovimientoID", dbo_CompuestoPor.MovimientoID)
        insertCommand.Parameters.AddWithValue("@Cantidad", dbo_CompuestoPor.Cantidad)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", System.DateTime.Now)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)

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
            messagebox.show(ex.Message)
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function CompuestoPorUpdate(ByVal newDBO_CompuestoPor As DBO_CompuestoPor, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[CompuestoPorUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewCantidad", newDBO_CompuestoPor.Cantidad)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_CompuestoPor.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_CompuestoPor.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldLoteFinal", newDBO_CompuestoPor.LoteFinal)
        updateCommand.Parameters.AddWithValue("@OldLotePartida", newDBO_CompuestoPor.LotePartida)
        updateCommand.Parameters.AddWithValue("@OldMovimientoID", newDBO_CompuestoPor.MovimientoID)
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
            MessageBox.Show("Error en UpdateCompuestoPor" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function CompuestoPorDelete(ByVal LoteFinal As Int32, ByVal LotePartida As Int32, ByVal MovimientoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[CompuestoPorDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldLoteFinal", LoteFinal)
        deleteCommand.Parameters.AddWithValue("@OldLotePartida", LotePartida)
        deleteCommand.Parameters.AddWithValue("@OldMovimientoID", MovimientoID)
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
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GrabarCompuestoPor(ByVal dbo_CompuestoPor As DBO_CompuestoPor, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_CompuestoPor.FechaModificacion = System.DateTime.Now.Date
        dbo_CompuestoPor.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_CompuestoPor.LoteFinal = 0 Then
            CompuestoPorInsert(dbo_CompuestoPor, dtb)
        Else
            CompuestoPorUpdate(dbo_CompuestoPor, dtb)
        End If
    End Sub

End Class
