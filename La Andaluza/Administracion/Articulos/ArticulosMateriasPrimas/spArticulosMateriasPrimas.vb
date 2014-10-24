

Class spArticulosMateriasPrimas
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosMateriasPrimasSelect]", "[dbo].[ArticulosMateriasPrimasInsert2]", _
                  "[dbo].[ArticulosMateriasPrimasUpdate2]", "[dbo].[ArticulosMateriasPrimasDelete]", _
                  String.Empty, String.Empty)
    End Sub

    Public Function Select_Record(ByVal MateriaPrimaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosMateriasPrimas
        dtb.Conectar()
        Dim DBO_ArticulosMateriasPrimas As New DBO_ArticulosMateriasPrimas

        Dim selectProcedure As String = "[dbo].[ArticulosMateriasPrimasSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@MateriaPrimaID", MateriaPrimaID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosMateriasPrimas.MateriaPrimaID = If(reader("MateriaPrimaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MateriaPrimaID")))
                DBO_ArticulosMateriasPrimas.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosMateriasPrimas.MateriaPrimaTipoID = If(reader("MateriaPrimaTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MateriaPrimaTipoID")))
                DBO_ArticulosMateriasPrimas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosMateriasPrimas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosMateriasPrimas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ArticulosMateriasPrimas
    End Function


    Public Function Select_RecordByArticuloID(ByVal ArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosMateriasPrimas
        dtb.Conectar()
        Dim DBO_ArticulosMateriasPrimas As New DBO_ArticulosMateriasPrimas

        Dim selectProcedure As String = "[dbo].[ArticulosMateriasPrimasSelectByArticuloID]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloID", ArticuloID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosMateriasPrimas.MateriaPrimaID = If(reader("MateriaPrimaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MateriaPrimaID")))
                DBO_ArticulosMateriasPrimas.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosMateriasPrimas.MateriaPrimaTipoID = If(reader("MateriaPrimaTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MateriaPrimaTipoID")))
                DBO_ArticulosMateriasPrimas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosMateriasPrimas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                'Si cambiamos el tipo no va a encontrar este ArticuloID, en lugar de igualarlo a Nothing lo dejamos sin valores
                'DBO_ArticulosMateriasPrimas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ArticulosMateriasPrimas
    End Function




    Public Function ArticulosMateriasPrimasInsert(ByVal dbo_ArticulosMateriasPrimas As DBO_ArticulosMateriasPrimas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ArticulosMateriasPrimasInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosMateriasPrimas.ArticuloID.HasValue, dbo_ArticulosMateriasPrimas.ArticuloID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@MateriaPrimaTipoID", If(dbo_ArticulosMateriasPrimas.MateriaPrimaTipoID.HasValue, dbo_ArticulosMateriasPrimas.MateriaPrimaTipoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosMateriasPrimas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosMateriasPrimas.UsuarioModificacion)
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

    Public Function ArticulosMateriasPrimasUpdate(ByVal newDBO_ArticulosMateriasPrimas As DBO_ArticulosMateriasPrimas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ArticulosMateriasPrimasUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosMateriasPrimas.ArticuloID.HasValue, newDBO_ArticulosMateriasPrimas.ArticuloID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewMateriaPrimaTipoID", If(newDBO_ArticulosMateriasPrimas.MateriaPrimaTipoID.HasValue, newDBO_ArticulosMateriasPrimas.MateriaPrimaTipoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosMateriasPrimas.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosMateriasPrimas.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldMateriaPrimaID", newDBO_ArticulosMateriasPrimas.MateriaPrimaID)
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
            MessageBox.Show("Error en UpdateArticulosMateriasPrimas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function


    Public Function ArticulosMateriasPrimasInsertSinTransaccion(ByVal dbo_ArticulosMateriasPrimas As DBO_ArticulosMateriasPrimas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Try
            Dim insertProcedure As String = "[dbo].[ArticulosMateriasPrimasInsert2]"
            Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
            insertCommand.CommandType = CommandType.StoredProcedure

            insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosMateriasPrimas.ArticuloID.HasValue, dbo_ArticulosMateriasPrimas.ArticuloID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@MateriaPrimaTipoID", If(dbo_ArticulosMateriasPrimas.MateriaPrimaTipoID.HasValue, dbo_ArticulosMateriasPrimas.MateriaPrimaTipoID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosMateriasPrimas.FechaModificacion)
            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosMateriasPrimas.UsuarioModificacion)
            insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        End Try
    End Function

    Public Function ArticulosMateriasPrimasUpdateSinTransaccion(ByVal newDBO_ArticulosMateriasPrimas As DBO_ArticulosMateriasPrimas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean


        Try
            Dim updateProcedure As String = "[dbo].[ArticulosMateriasPrimasUpdate2]"
            Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
            updateCommand.CommandType = CommandType.StoredProcedure

            updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosMateriasPrimas.ArticuloID.HasValue, newDBO_ArticulosMateriasPrimas.ArticuloID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewMateriaPrimaTipoID", If(newDBO_ArticulosMateriasPrimas.MateriaPrimaTipoID.HasValue, newDBO_ArticulosMateriasPrimas.MateriaPrimaTipoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosMateriasPrimas.FechaModificacion)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosMateriasPrimas.UsuarioModificacion)
            updateCommand.Parameters.AddWithValue("@OldMateriaPrimaID", newDBO_ArticulosMateriasPrimas.MateriaPrimaID)
            updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output


            updateCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateArticulosMateriasPrimas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        End Try
    End Function

    Public Function ArticulosMateriasPrimasDelete(ByVal MateriaPrimaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ArticulosMateriasPrimasDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldMateriaPrimaID", MateriaPrimaID)
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

    Public Sub GrabarArticulosMateriasPrimas(ByVal dbo_ArticulosMateriasPrimas As DBO_ArticulosMateriasPrimas, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_ArticulosMateriasPrimas.MateriaPrimaID = 0 Then
            ArticulosMateriasPrimasInsert(dbo_ArticulosMateriasPrimas, dtb)
        Else
            ArticulosMateriasPrimasUpdate(dbo_ArticulosMateriasPrimas, dtb)
        End If
    End Sub


    Public Function GrabarArticulosMateriasPrimasSinTransaccion(ByVal dbo_ArticulosMateriasPrimas As DBO_ArticulosMateriasPrimas, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If dbo_ArticulosMateriasPrimas.MateriaPrimaID = 0 Then
            Return ArticulosMateriasPrimasInsertSinTransaccion(dbo_ArticulosMateriasPrimas, dtb)
        Else
            Return ArticulosMateriasPrimasUpdateSinTransaccion(dbo_ArticulosMateriasPrimas, dtb)
        End If
    End Function

End Class
