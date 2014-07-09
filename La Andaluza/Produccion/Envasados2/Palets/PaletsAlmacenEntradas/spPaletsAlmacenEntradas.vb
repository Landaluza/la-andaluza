

Class spPaletsAlmacenEntradas
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PaletsAlmacenEntradasSelect]", "[dbo].[PaletsAlmacenEntradasInsert]", "[dbo].[PaletsAlmacenEntradasUpdate]", _
                   "[dbo].[PaletsAlmacenEntradasDelete]", "PaletsAlmacenEntradasSelectByCajas", "PaletsAlmacenEntradasSelectByCajas")
    End Sub

    Public Function PaletsAlmacenEntradasUpdateVigente(ByVal Vigente As Boolean, ByVal PaletAlmacenEntradaID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PaletsAlmacenEntradasUpdateVigente]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewVigente", Vigente)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", System.DateTime.Now)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
        updateCommand.Parameters.AddWithValue("@OldPaletAlmacenEntradaID", PaletAlmacenEntradaID)
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
            MessageBox.Show("Error en UpdatePaletsAlmacenEntradas1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function Select_RecordBySSCC(ByVal SSCC As String) As DBO_PaletsAlmacenEntradas
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_PaletsAlmacenEntradas As New DBO_PaletsAlmacenEntradas
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsAlmacenEntradasSelectDgvBySSCC]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@SSCC", SSCC)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_PaletsAlmacenEntradas.PaletAlmacenEntradaID = If(reader("PaletAlmacenEntradaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletAlmacenEntradaID")))
                'DBO_PaletsAlmacenEntradas.SSCC = If(reader("SSCC") Is Convert.DBNull, String.Empty, reader("SSCC")))
                DBO_PaletsAlmacenEntradas.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_PaletsAlmacenEntradas.Articulo = If(reader("Articulo") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Articulo")))
                DBO_PaletsAlmacenEntradas.Cajas = If(reader("Cajas") Is Convert.DBNull, 0, Convert.ToInt32(reader("Cajas")))
                DBO_PaletsAlmacenEntradas.ComentariosCarga = If(reader("ComentariosCarga") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ComentariosCarga")))
                DBO_PaletsAlmacenEntradas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PaletsAlmacenEntradas.Vigente = If(reader("Vigente") Is Convert.DBNull, False, Convert.ToBoolean(reader("Vigente")))

            Else
                'DBO_PaletsAlmacenEntradas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_PaletsAlmacenEntradas
    End Function

    Public Function Select_Record(ByVal PaletAlmacenEntradaID As Int32) As DBO_PaletsAlmacenEntradas
        BasesParaCompatibilidad.BD.Conectar()
        Dim DBO_PaletsAlmacenEntradas As New DBO_PaletsAlmacenEntradas
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsAlmacenEntradasSelect]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PaletAlmacenEntradaID", PaletAlmacenEntradaID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_PaletsAlmacenEntradas.PaletAlmacenEntradaID = If(reader("PaletAlmacenEntradaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletAlmacenEntradaID")))
                DBO_PaletsAlmacenEntradas.SSCC = If(reader("SSCC") Is Convert.DBNull, String.Empty, Convert.ToString(reader("SSCC")))
                DBO_PaletsAlmacenEntradas.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_PaletsAlmacenEntradas.Articulo = If(reader("Articulo") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Articulo")))
                DBO_PaletsAlmacenEntradas.Cajas = If(reader("Cajas") Is Convert.DBNull, 0, Convert.ToInt32(reader("Cajas")))
                DBO_PaletsAlmacenEntradas.ComentariosCarga = If(reader("ComentariosCarga") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ComentariosCarga")))
                DBO_PaletsAlmacenEntradas.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_PaletsAlmacenEntradas.Vigente = If(reader("Vigente") Is Convert.DBNull, False, Convert.ToBoolean(reader("Vigente")))
                DBO_PaletsAlmacenEntradas.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PaletsAlmacenEntradas.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_PaletsAlmacenEntradas = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            connection.Close()
        End Try
        Return DBO_PaletsAlmacenEntradas
    End Function

    Public Function PaletsAlmacenEntradasInsert(ByVal dbo_PaletsAlmacenEntradas As DBO_PaletsAlmacenEntradas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[PaletsAlmacenEntradasInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        
        insertCommand.Parameters.AddWithValue("@SSCC", dbo_PaletsAlmacenEntradas.SSCC)
        insertCommand.Parameters.AddWithValue("@Fecha", dbo_PaletsAlmacenEntradas.Fecha)
        insertCommand.Parameters.AddWithValue("@Articulo", dbo_PaletsAlmacenEntradas.Articulo)
        insertCommand.Parameters.AddWithValue("@Cajas", If(dbo_PaletsAlmacenEntradas.Cajas.HasValue, dbo_PaletsAlmacenEntradas.Cajas, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@ComentariosCarga", dbo_PaletsAlmacenEntradas.ComentariosCarga)
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_PaletsAlmacenEntradas.Observaciones)
        insertCommand.Parameters.AddWithValue("@Vigente", dbo_PaletsAlmacenEntradas.Vigente)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PaletsAlmacenEntradas.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PaletsAlmacenEntradas.UsuarioModificacion)
        
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

    Public Function PaletsAlmacenEntradasUpdate(ByVal newDBO_PaletsAlmacenEntradas As DBO_PaletsAlmacenEntradas) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PaletsAlmacenEntradasUpdate]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewSSCC", newDBO_PaletsAlmacenEntradas.SSCC)
        updateCommand.Parameters.AddWithValue("@NewFecha", newDBO_PaletsAlmacenEntradas.Fecha)
        updateCommand.Parameters.AddWithValue("@NewArticulo", newDBO_PaletsAlmacenEntradas.Articulo)
        updateCommand.Parameters.AddWithValue("@NewCajas", If(newDBO_PaletsAlmacenEntradas.Cajas.HasValue, newDBO_PaletsAlmacenEntradas.Cajas, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewComentariosCarga", newDBO_PaletsAlmacenEntradas.ComentariosCarga)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_PaletsAlmacenEntradas.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewVigente", newDBO_PaletsAlmacenEntradas.Vigente)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_PaletsAlmacenEntradas.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_PaletsAlmacenEntradas.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPaletAlmacenEntradaID", newDBO_PaletsAlmacenEntradas.PaletAlmacenEntradaID)
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
            MessageBox.Show("Error en UpdatePaletsAlmacenEntradas" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString (ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function PaletsAlmacenEntradasDelete(ByVal PaletAlmacenEntradaID As Int32) As Boolean

        Dim connection As System.Data.SqlClient.SqlConnection = Nothing
        Dim deleteProcedure As String
        Dim deleteCommand As New System.Data.SqlClient.SqlCommand

        Try
            BasesParaCompatibilidad.BD.Conectar()
            connection = BasesParaCompatibilidad.BD.Cnx
            deleteProcedure = "[dbo].[PaletsAlmacenEntradasDelete]"
            deleteCommand = New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            deleteCommand.CommandType = CommandType.StoredProcedure
            '<Tag=[Four][Start]> -- please do not remove this line
            deleteCommand.Parameters.AddWithValue("@OldPaletAlmacenEntradaID", PaletAlmacenEntradaID)
            '<Tag=[Four][End]> -- please do not remove this line
            deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

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
            If Not connection Is Nothing Then connection.Close()
        End Try
    End Function

    Public Sub GrabarPaletsAlmacenEntradas(ByVal dbo_PaletsAlmacenEntradas As DBO_PaletsAlmacenEntradas)
        dbo_PaletsAlmacenEntradas.FechaModificacion = System.DateTime.Now.date
        dbo_PaletsAlmacenEntradas.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_PaletsAlmacenEntradas.PaletAlmacenEntradaID = 0 Then
            PaletsAlmacenEntradasInsert(dbo_PaletsAlmacenEntradas)
        Else
            PaletsAlmacenEntradasUpdate(dbo_PaletsAlmacenEntradas)
        End If
    End Sub

    Public Function EstaEnAlmacen(ByVal scc As String) As Boolean
        Dim Tabla As DataTable = dtb.Consultar("select count(* ) from PaletsAlmacenEntradas where sscc=" & scc, False)

        If Tabla.Rows(0).Item(0) = 0 Then Return False

        Return True
    End Function
End Class
