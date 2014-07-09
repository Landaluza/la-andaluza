

Class spFormatosEnvasados2    
    inherits BasesParaCompatibilidad.sp
    Private ultimoFormatoEnvasado As Integer

    Public Sub New()
        MyBase.New(String.Empty, "[dbo].[FormatosEnvasados2Insert]", "[dbo].[FormatosEnvasados2Update]", "[dbo].[FormatosEnvasados4Delete]", _
                   String.Empty, "Envasados4SelectFormatos")

    End Sub
    'Public Function Select_Record(ByVal FormatoEnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_FormatosEnvasados
    '    BasesParaCompatibilidad.BD.Conectar()
    '    Dim Dbo_FormatosEnvasados2 As New DBO_FormatosEnvasados
    '    Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
    '    Dim selectProcedure As String = "[dbo].[FormatosEnvasados2Select]"
    '    Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
    '    selectCommand.CommandType = CommandType.StoredProcedure
    '    If Not trans Is Nothing Then selectCommand.Transaction = trans
    '    selectCommand.Parameters.AddWithValue("@FormatoEnvasadoID", FormatoEnvasadoID)
    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
    '        If reader.Read Then
    '            Dbo_FormatosEnvasados2.ID = if(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, reader("FormatoEnvasadoID")))
    '            Dbo_FormatosEnvasados2.TipoFormatoEnvasadoID = if(reader("TipoFormatoEnvasadoID") Is Convert.DBNull, 0, reader("TipoFormatoEnvasadoID")))
    '            Dbo_FormatosEnvasados2.TipoFormatoLineaID = if(reader("TipoFormatoLineaID") Is Convert.DBNull, 0, reader("TipoFormatoLineaID")))
    '            Dbo_FormatosEnvasados2.EnvasadoID = if(reader("EnvasadoID") Is Convert.DBNull, 0, reader("EnvasadoID")))                
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
    '    Finally
    '        If trans Is Nothing Then connection.Close()
    '    End Try
    '    Return Dbo_FormatosEnvasados2
    'End Function



    'Public Function Select_Record(ByVal FormatoEnvasadoID As Int32, ByRef dbt as BasesParaCompatibilidad.Database) As DBO_FormatosEnvasados
    '    If dbt.Transaccion Is Nothing Then dtb.Conectar()
    '    Dim Dbo_FormatosEnvasados3 As New DBO_FormatosEnvasados
    '    Dim selectCommand As System.Data.SqlClient.SqlCommand = dbt.Comando("[dbo].[FormatosEnvasados2Select2]")
    '    selectCommand.CommandType = CommandType.StoredProcedure

    '    selectCommand.Parameters.AddWithValue("@FormatoEnvasadoID", FormatoEnvasadoID)
    '    Try
    '        Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
    '        If reader.Read Then
    '            Dbo_FormatosEnvasados3.ID = if(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, reader("FormatoEnvasadoID")))
    '            Dbo_FormatosEnvasados3.TipoFormatoEnvasadoID = if(reader("TipoFormatoEnvasadoID") Is Convert.DBNull, 0, reader("TipoFormatoEnvasadoID")))
    '            Dbo_FormatosEnvasados3.TipoFormatoLineaID = if(reader("TipoFormatoLineaID") Is Convert.DBNull, 0, reader("TipoFormatoLineaID")))
    '            Dbo_FormatosEnvasados3.EnvasadoID = if(reader("EnvasadoID") Is Convert.DBNull, 0, reader("EnvasadoID")))
    '            Dbo_FormatosEnvasados3.inicio = If(reader("inicio") Is Convert.DBNull, Today, reader("inicio")))
    '            Dbo_FormatosEnvasados3.fin = If(reader("fin") Is Convert.DBNull, Today, reader("fin")))
    '        End If
    '        reader.Close()
    '    Catch ex As System.Data.SqlClient.SqlException
    '        messagebox.show(ex.Message, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
    '    Finally
    '        If dbt.Transaccion Is Nothing Then dbt.DesBasesParaCompatibilidad.BD.Conectar()
    '    End Try
    '    Return Dbo_FormatosEnvasados3
    'End Function

    Public Function InsertFormatosEnvasados2(ByVal dbo_FormatosEnvasados2 As DBO_FormatosEnvasados) As Integer
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[FormatosEnvasados2Insert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@TipoFormatoEnvasadoID", dbo_FormatosEnvasados2.TipoFormatoEnvasadoID)
        insertCommand.Parameters.AddWithValue("@TipoFormatoLineaID", dbo_FormatosEnvasados2.TipoFormatoLineaID)
        insertCommand.Parameters.AddWithValue("@EnvasadoID", dbo_FormatosEnvasados2.EnvasadoID)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", DateTime.Now)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            Return count
        Catch ex As System.Data.SqlClient.SqlException
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function UpdateFormatosEnvasados2(ByVal FormatosEnvasados2 As DBO_FormatosEnvasados) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[FormatosEnvasados2Update]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewTipoFormatoEnvasadoID", FormatosEnvasados2.TipoFormatoEnvasadoID)
        updateCommand.Parameters.AddWithValue("@NewTipoFormatoLineaID", FormatosEnvasados2.TipoFormatoLineaID)
        updateCommand.Parameters.AddWithValue("@NewEnvasadoID", FormatosEnvasados2.EnvasadoID)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", DateTime.Now)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
        updateCommand.Parameters.AddWithValue("@OldFormatoEnvasadoID", FormatosEnvasados2.ID)
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
            MessageBox.Show("Error en UpdateFormatosEnvasados2" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function isDeleteAllowed(ByVal FormatoEnvasadoID As Int32) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx

        Dim proc As String = "[dbo].[FormatosEnvasados2esPermitidoBorrar]"
        Dim query As New System.Data.SqlClient.SqlCommand(proc, connection)
        query.CommandType = CommandType.StoredProcedure
        query.Parameters.AddWithValue("@FormatoID", FormatoEnvasadoID)
        query.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        query.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        query.ExecuteNonQuery()
        Dim resp As Integer = query.Parameters("@ReturnValue").Value

        If resp = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function DeleteFormatosEnvasados2(ByVal FormatoEnvasadoID As Int32, ByVal borradoCompleto As Boolean) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Try
            Dim response As DialogResult = DialogResult.Cancel

            Dim deleteProcedure As String = "[dbo].[FormatosEnvasados4Delete]"
            Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@OldFormatoEnvasadoID", FormatoEnvasadoID)
            deleteCommand.Parameters.AddWithValue("@fechaModificacion", System.DateTime.Now)

            deleteCommand.Parameters.AddWithValue("@borradoCompleto", If(borradoCompleto = True, 1, 0))

            deleteCommand.Parameters.AddWithValue("@usuarioModificacion", BasesParaCompatibilidad.Config.User)
            Dim m_usuario As New DBO_Usuarios
            Dim aux As New spUsuarios
            m_usuario = aux.Select_Record(BasesParaCompatibilidad.Config.User)
            deleteCommand.Parameters.AddWithValue("@usuarioNombre", m_usuario.Usuario)
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
            messagebox.show("Error en deleteFormatosEnvasados2 " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function GrabarFormatosEnvasados2(ByRef m_FormatosEnvasados As DBO_FormatosEnvasados) As Boolean
        Dim retorno As Boolean = False
        If m_FormatosEnvasados.ID = 0 Then
            m_FormatosEnvasados.ID = InsertFormatosEnvasados2(m_FormatosEnvasados)
            If m_FormatosEnvasados.ID > 0 Then retorno = True
        Else
            If UpdateFormatosEnvasados2(m_FormatosEnvasados) Then retorno = True
        End If
        Dim sp As New spFormatosEnvasados
        m_FormatosEnvasados = sp.Select_Record(m_FormatosEnvasados.ID)
        Return retorno
    End Function


    Public Function GetUltimaHoraFinPaletProducido(ByRef formato As Integer) As TimeSpan
        BasesParaCompatibilidad.BD.Conectar()
        Dim retorno As TimeSpan

        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsProducidos2UltimaHoraFin]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@FormatoID", formato)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleResult)
            Dim encontro As Boolean = False
            If reader.Read Then
                retorno = If(reader("fecha") Is Convert.DBNull, DateTime.Now.TimeOfDay, reader("fecha"))
            End If

            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            retorno = DateTime.Now.TimeOfDay
            retorno = retorno.Add(New TimeSpan(0, 15, 0))
            MessageBox.Show("Error en PaletsProducidos2UltimaHoraFin" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            connection.Close()
        End Try

        Return retorno
    End Function

    Public Function GetPrimeraHoraInicioPaletProducido(ByRef formato As Integer) As TimeSpan
        BasesParaCompatibilidad.BD.Conectar()
        Dim retorno As TimeSpan

        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsProducidos2PrimeraHoraInicio]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@FormatoID", formato)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleResult)
            Dim encontro As Boolean = False
            If reader.Read Then
                retorno = If(reader("fecha") Is Convert.DBNull, DateTime.Now.TimeOfDay, reader("fecha"))
            End If

            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            retorno = DateTime.Now.TimeOfDay
            MessageBox.Show("Error en PaletsProducidos2PrimeraHoraInicio" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            connection.Close()
        End Try

        Return retorno
    End Function

    'pedir m_dbo, a partir de la linea mirar el articulo que se envaso en el ultimo palet creado
    Public Function recuperarUltimoFormatoEnvasado(ByRef envasado As DBO_Envasados2) As Integer
        If ultimoFormatoEnvasado = Nothing Then
            BasesParaCompatibilidad.BD.Conectar()

            Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
            Dim selectProcedure As String = "[dbo].[PaletsProducidos2UltimoFormatoEnvasadoPorLinea]"
            Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@Linea", envasado.LineaID)

            Try
                Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleResult)

                If reader.Read Then
                    ultimoFormatoEnvasado = (If(reader("formato") Is Convert.DBNull, 0, reader("formato")))
                End If

                reader.Close()
            Catch ex As System.Data.SqlClient.SqlException
                ultimoFormatoEnvasado = 0
                MessageBox.Show("Error en recuperarUltimoFormatoEnvasado" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Finally
                connection.Close()
            End Try
        End If

        Return ultimoFormatoEnvasado
    End Function

    Public Sub EstablecerUltimoFormatoEnvasado(ByVal formato As Integer)
        ultimoFormatoEnvasado = formato
    End Sub

    Function select_ultimo_palet_por_linea(ByVal linea As Integer) As DBO_PaletsProducidos2
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("select top 1 horaFin " & _
                             "from paletsproducidos, paletscontenidos, formatosEnvasados, tiposFormatosLineas " & _
                             "where paletsproducidos.paletproducidoid = paletscontenidos.paletcontenidoid " & _
                             "and paletsproducidos.formatoid = formatosEnvasados.formatoEnvasadoid " & _
                             "and formatosEnvasados.TipoFormatoLineaid =  tiposFormatosLineas.TipoFormatoLineaid " & _
                             "and lineaEnvasadoID = order by horaFin desc", False).Rows(0).Item(0)
    End Function

    Public Function devolverFormatosPorEnvasadosReport(envasadoid As Integer) As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaProcedAlmacenado("devolverFormatosPorEnvasadosReport", Convert.ToString(envasadoid))
    End Function

    Public Function devolverProductosPorEnvasadosReport(envasadoid As Integer) As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaProcedAlmacenado("devolverProductosPorEnvasadosReport", Convert.ToString(envasadoid))
    End Function
End Class
