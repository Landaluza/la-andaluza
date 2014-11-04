Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spArticulosEnvasadosHistorico1

    Public Sub New()
    End Sub
    Public Function Select_Record(ByVal TipoFormatoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosEnvasadosHistorico
        dtb.Conectar()
        Dim DBO_TiposFormatos1 As New DBO_ArticulosEnvasadosHistorico

        Dim selectProcedure As String = "[dbo].[TiposFormatos1Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@TipoFormatoID", TipoFormatoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_TiposFormatos1.TipoFormatoID = If(reader("TipoFormatoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoFormatoID")))
                DBO_TiposFormatos1.CodigoQS = If(reader("CodigoQS") Is Convert.DBNull, 0, Convert.ToInt32(reader("CodigoQS")))
                DBO_TiposFormatos1.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_TiposFormatos1.Separadores = If(reader("Separadores") Is Convert.DBNull, 0, Convert.ToInt32(reader("Separadores")))
                DBO_TiposFormatos1.CajasPalet = If(reader("CajasPalet") Is Convert.DBNull, 0, Convert.ToInt32(reader("CajasPalet")))
                DBO_TiposFormatos1.Genericas = If(reader("Genericas") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Genericas")))
                DBO_TiposFormatos1.Particulares = If(reader("Particulares") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Particulares")))
                DBO_TiposFormatos1.TipoProductoID = If(reader("TipoProductoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoProductoID")))
                DBO_TiposFormatos1.TipoCajaID = If(reader("TipoCajaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoCajaID")))
                DBO_TiposFormatos1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_TiposFormatos1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_TiposFormatos1 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_TiposFormatos1
    End Function

    Public Function TiposFormatos1Insert(ByVal dbo_TiposFormatos1 As DBO_ArticulosEnvasadosHistorico, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[TiposFormatos1Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@CodigoQS", dbo_TiposFormatos1.CodigoQS)
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_TiposFormatos1.Descripcion)
        insertCommand.Parameters.AddWithValue("@Separadores", dbo_TiposFormatos1.Separadores)
        insertCommand.Parameters.AddWithValue("@CajasPalet", dbo_TiposFormatos1.CajasPalet)
        insertCommand.Parameters.AddWithValue("@Genericas", dbo_TiposFormatos1.Genericas)
        insertCommand.Parameters.AddWithValue("@Particulares", dbo_TiposFormatos1.Particulares)
        insertCommand.Parameters.AddWithValue("@TipoProductoID", If(dbo_TiposFormatos1.TipoProductoID.HasValue, dbo_TiposFormatos1.TipoProductoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@TipoCajaID", dbo_TiposFormatos1.TipoCajaID)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_TiposFormatos1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_TiposFormatos1.UsuarioModificacion)

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

    Public Function TiposFormatos1Update(ByVal newDBO_TiposFormatos1 As DBO_ArticulosEnvasadosHistorico, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean

        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[TiposFormatos1Update]")
        updateCommand.CommandType = CommandType.StoredProcedure
        If Not dtb.Transaccion Is Nothing Then updateCommand.Transaction = dtb.Transaccion
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewCodigoQS", newDBO_TiposFormatos1.CodigoQS)
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_TiposFormatos1.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewSeparadores", newDBO_TiposFormatos1.Separadores)
        updateCommand.Parameters.AddWithValue("@NewCajasPalet", newDBO_TiposFormatos1.CajasPalet)
        updateCommand.Parameters.AddWithValue("@NewGenericas", newDBO_TiposFormatos1.Genericas)
        updateCommand.Parameters.AddWithValue("@NewParticulares", newDBO_TiposFormatos1.Particulares)
        updateCommand.Parameters.AddWithValue("@NewTipoProductoID", If(newDBO_TiposFormatos1.TipoProductoID.HasValue, newDBO_TiposFormatos1.TipoProductoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewTipoCajaID", newDBO_TiposFormatos1.TipoCajaID)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_TiposFormatos1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_TiposFormatos1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldTipoFormatoID", newDBO_TiposFormatos1.TipoFormatoID)
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
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function TiposFormatos1InsertSinTransaccion(ByVal dbo_TiposFormatos1 As DBO_ArticulosEnvasadosHistorico, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean


        Dim insertProcedure As String = "[dbo].[TiposFormatos1Insert2]"
        Try
            Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
            insertCommand.CommandType = CommandType.StoredProcedure


            insertCommand.Parameters.AddWithValue("@CodigoQS", dbo_TiposFormatos1.CodigoQS)
            insertCommand.Parameters.AddWithValue("@Descripcion", dbo_TiposFormatos1.Descripcion)
            insertCommand.Parameters.AddWithValue("@Separadores", dbo_TiposFormatos1.Separadores)
            insertCommand.Parameters.AddWithValue("@CajasPalet", dbo_TiposFormatos1.CajasPalet)
            insertCommand.Parameters.AddWithValue("@Genericas", dbo_TiposFormatos1.Genericas)
            insertCommand.Parameters.AddWithValue("@Particulares", dbo_TiposFormatos1.Particulares)
            insertCommand.Parameters.AddWithValue("@TipoProductoID", If(dbo_TiposFormatos1.TipoProductoID.HasValue, dbo_TiposFormatos1.TipoProductoID, Convert.DBNull))
            insertCommand.Parameters.AddWithValue("@TipoCajaID", dbo_TiposFormatos1.TipoCajaID)
            insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_TiposFormatos1.FechaModificacion)
            insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_TiposFormatos1.UsuarioModificacion)

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

    Public Function TiposFormatos1UpdateSinTransaccion(ByVal newDBO_TiposFormatos1 As DBO_ArticulosEnvasadosHistorico, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean


        Dim updateProcedure As String = "[dbo].[TiposFormatos1Update2]"
        Try
            Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
            updateCommand.CommandType = CommandType.StoredProcedure

            '<Tag=[Three][Start]> -- please do not remove this line
            updateCommand.Parameters.AddWithValue("@NewCodigoQS", newDBO_TiposFormatos1.CodigoQS)
            updateCommand.Parameters.AddWithValue("@NewDescripcion", If(newDBO_TiposFormatos1.Descripcion Is Nothing, " ", newDBO_TiposFormatos1.Descripcion))
            updateCommand.Parameters.AddWithValue("@NewSeparadores", newDBO_TiposFormatos1.Separadores)
            updateCommand.Parameters.AddWithValue("@NewCajasPalet", newDBO_TiposFormatos1.CajasPalet)
            updateCommand.Parameters.AddWithValue("@NewGenericas", newDBO_TiposFormatos1.Genericas)
            updateCommand.Parameters.AddWithValue("@NewParticulares", newDBO_TiposFormatos1.Particulares)
            updateCommand.Parameters.AddWithValue("@NewTipoProductoID", If(newDBO_TiposFormatos1.TipoProductoID.HasValue, newDBO_TiposFormatos1.TipoProductoID, Convert.DBNull))
            updateCommand.Parameters.AddWithValue("@NewTipoCajaID", newDBO_TiposFormatos1.TipoCajaID)
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_TiposFormatos1.FechaModificacion)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_TiposFormatos1.UsuarioModificacion)
            updateCommand.Parameters.AddWithValue("@OldTipoFormatoID", newDBO_TiposFormatos1.TipoFormatoID)
            '<Tag=[Three][End]> -- please do not remove this line
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
            MessageBox.Show("Error en UpdateTiposFormatos1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        End Try
    End Function

    Public Function TiposFormatos1Delete(ByVal TipoFormatoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[TiposFormatos1Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldTipoFormatoID", TipoFormatoID)
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

    Public Function TiposFormatos1DeleteSinTransaccion(ByVal TipoFormatoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean


        Dim deleteProcedure As String = "[dbo].[TiposFormatos1Delete2]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure

        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldTipoFormatoID", TipoFormatoID)
        '<Tag=[Four][End]> -- please do not remove this line

        Try
            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        End Try
    End Function


    Public Function TiposFormatos1SelecMax(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Dim MaxID As Integer = 0

        Dim cmd As System.Data.SqlClient.SqlCommand = dtb.comando("TiposFormatos1SelectMax")

        MaxID = cmd.ExecuteScalar()

        Return MaxID
    End Function

    Public Sub GrabarTiposFormatos1(ByVal dbo_TiposFormatos1 As DBO_ArticulosEnvasadosHistorico, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dbo_TiposFormatos1.FechaModificacion = System.DateTime.Now.Date
        dbo_TiposFormatos1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_TiposFormatos1.TipoFormatoID = 0 Then
            TiposFormatos1Insert(dbo_TiposFormatos1, dtb)
        Else
            TiposFormatos1Update(dbo_TiposFormatos1, dtb)
        End If
    End Sub


    Public Function GrabarTiposFormatos1Sintransaccion(ByVal dbo_TiposFormatos1 As DBO_ArticulosEnvasadosHistorico, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_TiposFormatos1.FechaModificacion = System.DateTime.Now.date
        dbo_TiposFormatos1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_TiposFormatos1.TipoFormatoID = 0 Then
            Return TiposFormatos1InsertSinTransaccion(dbo_TiposFormatos1, dtb)
        Else
            Return TiposFormatos1UpdateSinTransaccion(dbo_TiposFormatos1, dtb)
        End If
    End Function

    Public Sub cargarComboBox(ByRef combo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("TiposFormatosCbo")
        combo.mam_DataSource(dtb.Consultar(), False)
    End Sub

    Public Sub cargarComboBoxTodos(ByRef combo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("TiposFormatosCboAll")
        combo.mam_DataSource(dtb.Consultar(), False)
    End Sub

    Public Sub cargarComboBoxTodosSinLinea(ByRef combo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("TiposFormatosCboAllSinLinea")
        combo.mam_DataSource(dtb.Consultar(), False)
    End Sub

  



End Class
