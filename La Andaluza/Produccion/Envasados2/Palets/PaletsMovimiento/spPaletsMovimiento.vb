

Public Class spPaletsMovimiento
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PaletsMovimientoSelect]", "[dbo].[PaletsMovimientoInsert]", "[dbo].[PaletsMovimientoUpdate]", _
                    "[dbo].[PaletsMovimientoDelete]", "", "")
    End Sub


    Public Function SelectPaletSCC(ByVal SCC As String, dtb As BasesParaCompatibilidad.Database) As DataTable
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[PaletsProducidosSCCSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[PaletsProducidosSCCSelect]")
        selectCommand.Parameters.AddWithValue("@SCC", SCC)
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            dtb.Desconectar()
        End Try
        Return dt
    End Function
    'Public Function SelectAllPaletSCC() As DataTable
    '    dtb.Conectar 
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[PaletSCCSelectAll]"
    '    Dim selectCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(selectProcedure)
    '    Dim dt As New DataTable
    '    selectCommand.CommandType = CommandType.StoredProcedure

    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
    '        If reader.HasRows Then
    '            dt.Load(reader)
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '    Finally
    '        dtb.Desconectar 
    '    End Try
    '    Return dt
    'End Function

    'Public Function SelectAllPalets() As DataTable
    '    dtb.Conectar()

    '    Dim selectProcedure As String = "[dbo].[PaletsMovimientoSelectAll]"
    '    Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
    '    Dim dt As New DataTable
    '    selectCommand.CommandType = CommandType.StoredProcedure

    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
    '        If reader.HasRows Then
    '            dt.Load(reader)
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '    Finally
    '        dtb.Desconectar()
    '    End Try
    '    Return dt
    ' End Function

    Public Function Add(ByVal dbo_movimiento As Dbo_PaletsMovimiento, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal entrepalets As Boolean = False) As Boolean
        dtb.PrepararConsulta("select max(id) from paletsmovimiento")
        dbo_movimiento.MovimientoEntrePaletsID = dtb.Consultar().Rows(0).Item(0)

        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PaletsMovimientoInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure


        If dbo_movimiento.Tipo <> vbNullString Then
            insertCommand.Parameters.AddWithValue("@Tipo", dbo_movimiento.Tipo)
        Else
            insertCommand.Parameters.AddWithValue("@Tipo", Convert.DBNull)
        End If
        If dbo_movimiento.SubTipo <> vbNullString Then
            insertCommand.Parameters.AddWithValue("@SubTipo", dbo_movimiento.SubTipo)
        Else
            insertCommand.Parameters.AddWithValue("@SubTipo", Convert.DBNull)
        End If
        If dbo_movimiento.PaletID <> vbNullString Then
            insertCommand.Parameters.AddWithValue("@PaletID", dbo_movimiento.PaletID)
        Else
            insertCommand.Parameters.AddWithValue("@PaletID", Convert.DBNull)
        End If
        insertCommand.Parameters.AddWithValue("@Fecha", If(dbo_movimiento.Fecha_IsDBNull = True, Convert.DBNull, dbo_movimiento.Fecha))
        insertCommand.Parameters.AddWithValue("@Hora", dbo_movimiento.Hora)
        insertCommand.Parameters.AddWithValue("@Cajas", If(dbo_movimiento.Cajas_IsDBNull = True, Convert.DBNull, dbo_movimiento.Cajas))
        insertCommand.Parameters.AddWithValue("@DocumentoID", If(dbo_movimiento.DocumentoID_IsDBNull = True, Convert.DBNull, dbo_movimiento.DocumentoID))
        insertCommand.Parameters.AddWithValue("@Comentarios", If(dbo_movimiento.Comentarios_IsDBNull = True, Convert.DBNull, dbo_movimiento.Comentarios))
        insertCommand.Parameters.AddWithValue("@AutorizadoPor", If(dbo_movimiento.AutorizadoPor_IsDBNull = True, Convert.DBNull, dbo_movimiento.AutorizadoPor))
        insertCommand.Parameters.AddWithValue("@Receptor", If(dbo_movimiento.Receptor_IsDBNull = True, Convert.DBNull, dbo_movimiento.Receptor))
        insertCommand.Parameters.AddWithValue("@Motivo", If(dbo_movimiento.Motivo_IsDBNull = True, Convert.DBNull, dbo_movimiento.Motivo))
        insertCommand.Parameters.AddWithValue("@Solicitante", If(dbo_movimiento.Solicitante_IsDBNull = True, Convert.DBNull, dbo_movimiento.Solicitante))
        insertCommand.Parameters.AddWithValue("@Cliente", If(dbo_movimiento.Cliente_IsDBNull = True, Convert.DBNull, dbo_movimiento.Cliente))
        'insertCommand.Parameters.AddWithValue("@Inicial", if(dbo_movimiento.Inicial_IsDBNull = True, Convert.DBNull, dbo_movimiento.Inicial))
        'insertCommand.Parameters.AddWithValue("@Final", if(dbo_movimiento.Final_IsDBNull = True, Convert.DBNull, dbo_movimiento.Final))
        insertCommand.Parameters.AddWithValue("@id_PaletReceptor", If(dbo_movimiento.ContenidoDestinoID = Nothing, Convert.DBNull, dbo_movimiento.ContenidoDestinoID))
        insertCommand.Parameters.AddWithValue("@id_MovimientoEntrePalet", If(entrepalets, dbo_movimiento.MovimientoEntrePaletsID, Convert.DBNull))

        insertCommand.Parameters.AddWithValue("@FechaModificacion", System.DateTime.Now)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)

        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

        Try
            insertCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function update(ByVal dbo_movimiento As Dbo_PaletsMovimiento, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PaletsMovimientoUpdate]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure


        If dbo_movimiento.Tipo <> vbNullString Then
            insertCommand.Parameters.AddWithValue("@NewTipo", dbo_movimiento.Tipo)
        Else
            insertCommand.Parameters.AddWithValue("@NewTipo", Convert.DBNull)
        End If
        If dbo_movimiento.SubTipo <> vbNullString Then
            insertCommand.Parameters.AddWithValue("@NewSubTipo", dbo_movimiento.SubTipo)
        Else
            insertCommand.Parameters.AddWithValue("@NewSubTipo", Convert.DBNull)
        End If
        If dbo_movimiento.PaletID <> vbNullString Then
            insertCommand.Parameters.AddWithValue("@NewPaletID", dbo_movimiento.PaletID)
        Else
            insertCommand.Parameters.AddWithValue("@NewPaletID", Convert.DBNull)
        End If
        insertCommand.Parameters.AddWithValue("@NewFecha", If(dbo_movimiento.Fecha_IsDBNull = True, Convert.DBNull, dbo_movimiento.Fecha))
        insertCommand.Parameters.AddWithValue("@NewCajas", If(dbo_movimiento.Cajas_IsDBNull = True, Convert.DBNull, dbo_movimiento.Cajas))
        insertCommand.Parameters.AddWithValue("@NewDocumentoID", If(dbo_movimiento.DocumentoID_IsDBNull = True, Convert.DBNull, dbo_movimiento.DocumentoID))
        insertCommand.Parameters.AddWithValue("@NewComentarios", If(dbo_movimiento.Comentarios_IsDBNull = True, Convert.DBNull, dbo_movimiento.Comentarios))
        insertCommand.Parameters.AddWithValue("@NewAutorizadoPor", If(dbo_movimiento.AutorizadoPor_IsDBNull = True, Convert.DBNull, dbo_movimiento.AutorizadoPor))
        insertCommand.Parameters.AddWithValue("@NewReceptor", If(dbo_movimiento.Receptor_IsDBNull = True, Convert.DBNull, dbo_movimiento.Receptor))
        insertCommand.Parameters.AddWithValue("@NewMotivo", If(dbo_movimiento.Motivo_IsDBNull = True, Convert.DBNull, dbo_movimiento.Motivo))
        insertCommand.Parameters.AddWithValue("@NewSolicitante", If(dbo_movimiento.Solicitante_IsDBNull = True, Convert.DBNull, dbo_movimiento.Solicitante))
        insertCommand.Parameters.AddWithValue("@NewCliente", If(dbo_movimiento.Cliente_IsDBNull = True, Convert.DBNull, dbo_movimiento.Cliente))
        insertCommand.Parameters.AddWithValue("@NewInicial", Convert.DBNull)
        insertCommand.Parameters.AddWithValue("@NewFinal", Convert.DBNull)
        insertCommand.Parameters.AddWithValue("@OldID", dbo_movimiento.ID)
        ' insertCommand.Parameters.AddWithValue("@NewPaletdesctinoID", if(dbo_movimiento.PaletDestinoID = Nothing, Convert.DBNull, dbo_movimiento.PaletDestinoID))
        insertCommand.Parameters.AddWithValue("@id_PaletReceptor", If(dbo_movimiento.ContenidoDestinoID = Nothing, Convert.DBNull, dbo_movimiento.ContenidoDestinoID))
        insertCommand.Parameters.AddWithValue("@id_MovimientoEntrePalet", If(dbo_movimiento.MovimientoEntrePaletsID = Nothing, Convert.DBNull, dbo_movimiento.MovimientoEntrePaletsID))

        insertCommand.Parameters.AddWithValue("@NewFechaModificacion", System.DateTime.Now)
        insertCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)

        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

        Try
            insertCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function UpdatePaletsContenidosTerminado(ByVal PaletProducidoID As Int32, ByVal Terminado As Boolean, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PaletsContenidosTerminadoUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)

        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@PaletProducidoID", PaletProducidoID)
        updateCommand.Parameters.AddWithValue("@Terminado", Terminado)
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
            MessageBox.Show("Error en UpdatePaletsContenidosTerminado" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function UpdatePaletsContenidosEnAlmacen(ByVal PaletProducidoID As Int32, ByVal EnAlmacen As Boolean, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PaletsContenidosEnAlmacenUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure

        updateCommand.Parameters.AddWithValue("@PaletProducidoID", PaletProducidoID)
        updateCommand.Parameters.AddWithValue("@EnAlmacen", EnAlmacen)
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
            MessageBox.Show("Error en UpdatePaletsContenidosTerminado" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Delete(ByVal movimientoId As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PaletsMovimientoDelete]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@id", movimientoId)

        Try
            updateCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsMovimientoDelete" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function Select_Record(ByVal ID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Dbo_PaletsMovimiento
        dtb.Conectar()
        Dim DBO_PaletsMovimiento As New Dbo_PaletsMovimiento

        Dim selectProcedure As String = "[dbo].[PaletsMovimientoSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ID", ID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_PaletsMovimiento.ID = If(reader("ID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ID")))
                DBO_PaletsMovimiento.Tipo = If(reader("Tipo") Is Convert.DBNull, 0, Convert.ToInt32(reader("Tipo")))
                DBO_PaletsMovimiento.SubTipo = If(reader("SubTipo") Is Convert.DBNull, 0, Convert.ToInt32(reader("SubTipo")))
                DBO_PaletsMovimiento.PaletID = If(reader("PaletID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletID")))
                DBO_PaletsMovimiento.Cajas = If(reader("Cajas") Is Convert.DBNull, 0, Convert.ToInt32(reader("Cajas")))
                DBO_PaletsMovimiento.DocumentoID = If(reader("DocumentoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("DocumentoID")))
                DBO_PaletsMovimiento.Comentarios = If(reader("Comentarios") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Comentarios")))
                DBO_PaletsMovimiento.AutorizadoPor = If(reader("AutorizadoPor") Is Convert.DBNull, 0, Convert.ToInt32(reader("AutorizadoPor")))
                DBO_PaletsMovimiento.Receptor = If(reader("Receptor") Is Convert.DBNull, 0, Convert.ToInt32(reader("Receptor")))
                DBO_PaletsMovimiento.Motivo = If(reader("Motivo") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Motivo")))
                DBO_PaletsMovimiento.Solicitante = If(reader("Solicitante") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Solicitante")))
                DBO_PaletsMovimiento.Cliente = If(reader("Cliente") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Cliente")))
                DBO_PaletsMovimiento.Inicial = If(reader("Inicial") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Inicial")))
                DBO_PaletsMovimiento.Final = If(reader("Final") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Final")))
                DBO_PaletsMovimiento.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_PaletsMovimiento.ContenidoDestinoID = If(reader("id_PaletReceptor") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_PaletReceptor")))
                DBO_PaletsMovimiento.MovimientoEntrePaletsID = If(reader("id_MovimientoEntrePalet") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_MovimientoEntrePalet")))
                DBO_PaletsMovimiento.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_PaletsMovimiento.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

            Else
                DBO_PaletsMovimiento = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_PaletsMovimiento
    End Function

    Public Function comprobarFormatoEncajado(p1 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("select id_MovimentoEncajado from tiposcajas, articulosEnvasadosHistorico where articulosEnvasadosHistorico.tipocajaID = tiposcajas.tipocajaID and tipoformato = @p1")
        dtb.AñadirParametroConsulta("@p1", p1)
        Dim dt As DataTable = dtb.Consultar()
        If dt Is Nothing Then Return False
        If dt.Rows.Count = 0 Then Return False

        If Not IsDBNull(dt.Rows(0).Item(0)) Then
            Return True
        Else : Return False
        End If
    End Function

    Public Function Select_RecordByContenidoPalet(p1 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Dbo_PaletsMovimiento
        Dim spPaletsContenidos2 As New spPaletsContenidos2
        Dim aux As DBO_PaletsContenidos2 = spPaletsContenidos2.Select_Record(p1, dtb)

        Try
            dtb.PrepararConsulta("select id from paletsmovimiento where id_PaletReceptor = @id")
            dtb.AñadirParametroConsulta("@id", aux.PaletContenidoID)
            Dim id As Integer = dtb.Consultar().Rows(0).Item(0)

            Dim sp As New spPaletsMovimiento
            Return sp.Select_Record(id, dtb)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Shared Function esMovimientoEncajado(p1 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            dtb.PrepararConsulta("select count(*) from tiposcajas where id_movimentoEncajado = @id")
            dtb.AñadirParametroConsulta("@id", p1)
            Dim i As Integer = dtb.Consultar().Rows(0).Item(0)

            If i > 0 Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function ultimo_registro(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("select max(id) from paletsmovimiento")
        Dim dt As DataTable = dtb.Consultar()
        If dt Is Nothing Then Return 0
        If dt.Rows(0) Is Nothing Then Return 0
        If Convert.IsDBNull(dt.Rows(0).Item(0)) Then Return 0

        Return CInt(dt.Rows(0).Item(0))
    End Function
End Class
