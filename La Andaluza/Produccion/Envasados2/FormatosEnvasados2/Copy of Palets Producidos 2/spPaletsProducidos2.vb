Imports BasesParaCompatibilidad.ComboBoxExtension


Class spPaletsProducidos2
    inherits BasesParaCompatibilidad.sp

    Public Shared scc As String
    Public Shared message As String

    Public Sub New()
        MyBase.New("[dbo].[PaletsProducidos5Select]", "[dbo].[PaletsProducidos5Insert]", "[dbo].[PaletsProducidos5Update]", _
                   String.Empty, "PaletsProducidos5SelectDgv", "PaletsProducidos3SelectByFormatoEnvasadoID")
    End Sub

    Public Function Select_Record(ByVal PaletProducidoID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsProducidos2
        dtb.Conectar()
        Dim Dbo_PaletsProducidos2 As DBO_PaletsProducidos2 = Dbo_PaletsProducidos2.Instance

        Dim selectProcedure As String = "[dbo].[PaletsProducidos5Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@PaletProducidoID", PaletProducidoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PaletsProducidos2.PaletProducidoID = If(reader("PaletProducidoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletProducidoID")))
                Dbo_PaletsProducidos2.SCC = If(reader("SCC") Is Convert.DBNull, 0, Convert.ToInt32(reader("SCC")))
                Dbo_PaletsProducidos2.FormatoID = If(reader("FormatoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoID")))
                Dbo_PaletsProducidos2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now, CDate(reader("FechaModificacion")))
                Dbo_PaletsProducidos2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                Dbo_PaletsProducidos2.observacionesPalets = If(reader("ObservacionesPalets") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ObservacionesPalets")))
                Dbo_PaletsProducidos2.Terminado = If(reader("Terminado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Terminado")))
                Dbo_PaletsProducidos2.EnAlmacen = If(reader("EnAlmacen") Is Convert.DBNull, False, Convert.ToBoolean(reader("EnAlmacen")))
                Dbo_PaletsProducidos2.MultiLote = If(reader("Multilote") Is Convert.DBNull, False, Convert.ToBoolean(reader("Multilote")))
                Dbo_PaletsProducidos2.Id_Estado = If(reader("id_estado") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_estado")))

                reader.Close()
                'Obtener Campos Calculados
                Select_Record_Calculado(Dbo_PaletsProducidos2, dtb)
            Else
                Dbo_PaletsProducidos2 = Nothing
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsProducidos5Select" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            dtb.Desconectar()
        End Try
        Return Dbo_PaletsProducidos2
    End Function

    Public Function Select_RecordBySSCC(ByVal SSCC As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsProducidos2
        dtb.Conectar()
        Dim Dbo_PaletsProducidos2 As DBO_PaletsProducidos2 = Dbo_PaletsProducidos2.Instance

        Dim selectProcedure As String = "[dbo].[PaletsProducidos5SelectBySSCC]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@SSCC", SSCC)
        Dim reader As System.Data.SqlClient.SqlDataReader = Nothing
        Try
            reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PaletsProducidos2.PaletProducidoID = If(reader("PaletProducidoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletProducidoID")))
                Dbo_PaletsProducidos2.SCC = If(reader("SCC") Is Convert.DBNull, 0, Convert.ToInt32(reader("SCC")))
                Dbo_PaletsProducidos2.SCC_IsDBNull = If(reader("SCC") Is Convert.DBNull, True, False)
                Dbo_PaletsProducidos2.FormatoID = If(reader("FormatoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoID")))
                Dbo_PaletsProducidos2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                Dbo_PaletsProducidos2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                Dbo_PaletsProducidos2.observacionesPalets = If(reader("ObservacionesPalets") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ObservacionesPalets")))
                Dbo_PaletsProducidos2.Terminado = If(reader("Terminado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Terminado")))
                Dbo_PaletsProducidos2.EnAlmacen = If(reader("EnAlmacen") Is Convert.DBNull, False, Convert.ToBoolean(reader("EnAlmacen")))
                Dbo_PaletsProducidos2.MultiLote = If(reader("Multilote") Is Convert.DBNull, False, Convert.ToBoolean(reader("Multilote")))
                Dbo_PaletsProducidos2.Id_Estado = If(reader("id_estado") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_estado")))

                reader.Close()
                'Obtener Campos Calculados


            Else
                Dbo_PaletsProducidos2 = Nothing
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsProducidos5SelectBySSCC" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            If Not reader Is Nothing Then If Not reader.IsClosed Then reader.Close()
            dtb.Desconectar()
        End Try

        Try
            Select_Record_Calculado(Dbo_PaletsProducidos2, dtb)
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos5SelectBySSCC" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        End Try
        Return Dbo_PaletsProducidos2
    End Function

    Public Function Select_RecordSinMachacar(ByVal PaletProducidoID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsProducidos2
        dtb.Conectar()
        'Dim Dbo_PaletsProducidos2 As DBO_PaletsProducidos2 = Dbo_PaletsProducidos2.Instance
        Dim Dbo_PaletsProducidos2 As New DBO_PaletsProducidos2

        Dim selectProcedure As String = "[dbo].[PaletsProducidos5Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@PaletProducidoID", PaletProducidoID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PaletsProducidos2.PaletProducidoID = If(reader("PaletProducidoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletProducidoID")))
                Dbo_PaletsProducidos2.SCC = If(reader("SCC") Is Convert.DBNull, 0, Convert.ToInt32(reader("SCC")))
                Dbo_PaletsProducidos2.FormatoID = If(reader("FormatoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoID")))
                Dbo_PaletsProducidos2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                Dbo_PaletsProducidos2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                Dbo_PaletsProducidos2.observacionesPalets = If(reader("ObservacionesPalets") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ObservacionesPalets")))
                Dbo_PaletsProducidos2.Terminado = If(reader("Terminado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Terminado")))
                Dbo_PaletsProducidos2.EnAlmacen = If(reader("EnAlmacen") Is Convert.DBNull, False, Convert.ToBoolean(reader("EnAlmacen")))
                Dbo_PaletsProducidos2.MultiLote = If(reader("Multilote") Is Convert.DBNull, False, Convert.ToBoolean(reader("Multilote")))
                Dbo_PaletsProducidos2.Id_Estado = If(reader("id_estado") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_estado")))

                reader.Close()
                'Obtener Campos Calculados
                Select_Record_Calculado(Dbo_PaletsProducidos2, dtb)
            Else
                Dbo_PaletsProducidos2 = Nothing
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsProducidos5Select" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            dtb.Desconectar()
        End Try
        Return Dbo_PaletsProducidos2
    End Function

    Public Function Select_RecordBySSCCSinMachacar(ByVal SSCC As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsProducidos2
        dtb.Conectar()
        'Dim Dbo_PaletsProducidos2 As DBO_PaletsProducidos2 = Dbo_PaletsProducidos2.Instance
        Dim Dbo_PaletsProducidos2 As New DBO_PaletsProducidos2

        Dim selectProcedure As String = "[dbo].[PaletsProducidos5SelectBySSCC]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@SSCC", SSCC)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PaletsProducidos2.PaletProducidoID = If(reader("PaletProducidoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletProducidoID")))
                Dbo_PaletsProducidos2.SCC = If(reader("SCC") Is Convert.DBNull, 0, Convert.ToInt32(reader("SCC")))
                Dbo_PaletsProducidos2.SCC_IsDBNull = If(reader("SCC") Is Convert.DBNull, True, False)
                Dbo_PaletsProducidos2.FormatoID = If(reader("FormatoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoID")))
                Dbo_PaletsProducidos2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                Dbo_PaletsProducidos2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                Dbo_PaletsProducidos2.observacionesPalets = If(reader("ObservacionesPalets") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ObservacionesPalets")))
                Dbo_PaletsProducidos2.Terminado = If(reader("Terminado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Terminado")))
                Dbo_PaletsProducidos2.EnAlmacen = If(reader("EnAlmacen") Is Convert.DBNull, False, Convert.ToBoolean(reader("EnAlmacen")))
                Dbo_PaletsProducidos2.MultiLote = If(reader("Multilote") Is Convert.DBNull, False, Convert.ToBoolean(reader("Multilote")))
                Dbo_PaletsProducidos2.Id_Estado = If(reader("id_estado") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_estado")))

                reader.Close()
                'Obtener Campos Calculados
                Select_Record_Calculado(Dbo_PaletsProducidos2, dtb)

            Else
                Dbo_PaletsProducidos2 = Nothing
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsProducidos5SelectBySSCC" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            dtb.Desconectar()
        End Try
        Return Dbo_PaletsProducidos2
    End Function

    Private Sub Select_Record_Calculado(ByRef PaletProducido As DBO_PaletsProducidos2, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[PaletsProducidos2PaletsPorFormato]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@FormatoID", PaletProducido.FormatoID)
        Dim reader As System.Data.SqlClient.SqlDataReader = Nothing
        Try
            reader = selectCommand.ExecuteReader(CommandBehavior.SingleResult)
            Dim encontro As Boolean = False
            While ((reader.Read) And (Not encontro))
                If ((reader("PaletProducidoID") = PaletProducido.PaletProducidoID) And (reader("SCC") = PaletProducido.SCC)) Then
                    PaletProducido.HoraInicio = If(reader(2) Is Convert.DBNull, DateTime.Now.TimeOfDay, reader(2))
                    PaletProducido.HoraFin = If(reader(4) Is Convert.DBNull, DateTime.Now.TimeOfDay, reader(4))
                    PaletProducido.NroCajas = If(reader("NroCajas") Is Convert.DBNull, 0, Convert.ToInt32(reader("NroCajas")))
                    PaletProducido.NroPalets = If(reader("NroPalet") Is Convert.DBNull, 0, Convert.ToInt32(reader("NroPalet")))
                    PaletProducido.Velocidad = If(reader("Velocidad") Is Convert.DBNull, 0, Convert.ToDouble(reader("Velocidad")))
                    PaletProducido.Terminado = If(reader("completado") Is Convert.DBNull, False, Convert.ToBoolean(reader("completado")))
                    PaletProducido.Tiempo = If(reader("Tiempo") Is Convert.DBNull, 0, Convert.ToInt32(reader("Tiempo")))
                    PaletProducido.FormatoDescripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                    encontro = True
                End If
            End While

            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsProducidos2PaletsPorFormato" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            If Not reader Is Nothing Then If Not reader.IsClosed Then reader.Close()
            dtb.Desconectar()
        End Try
    End Sub

    Public Function InsertPaletsProducidos2(ByVal dbo_PaletsProducidos2 As DBO_PaletsProducidos2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        message = String.Empty
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[PaletsProducidos5Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure

        insertCommand.Parameters.AddWithValue("@SCC", dbo_PaletsProducidos2.SCC)
        'If dbo_PaletsProducidos2.FormatoID = Nothing Or dbo_PaletsProducidos2.FormatoID = 0 Then
        '    insertCommand.Parameters.AddWithValue("@FormatoID", formatoId)
        'Else
        insertCommand.Parameters.AddWithValue("@FormatoID", dbo_PaletsProducidos2.FormatoID)
        'End If

        insertCommand.Parameters.AddWithValue("@ObservacionesPalets", dbo_PaletsProducidos2.observacionesPalets)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PaletsProducidos2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
        insertCommand.Parameters.AddWithValue("@Terminado", dbo_PaletsProducidos2.Terminado)
        insertCommand.Parameters.AddWithValue("@EnAlmacen", dbo_PaletsProducidos2.EnAlmacen)
        insertCommand.Parameters.AddWithValue("@Multilote", dbo_PaletsProducidos2.MultiLote)
        insertCommand.Parameters.AddWithValue("@id_estado", If(dbo_PaletsProducidos2.Id_Estado = Nothing, 1, dbo_PaletsProducidos2.Id_Estado))
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return count
            Else
                Return 0
            End If
        Catch ex As System.Data.SqlClient.SqlException
            If ex.Message.Contains("SSCC duplicado") Then
                message = "err0"
            Else
                MessageBox.Show("Error en PaletsProducidos2Insert" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            End If
            Return 0
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function UpdatePaletsProducidos2(ByVal PaletsProducidos2 As DBO_PaletsProducidos2, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[PaletsProducidos5Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure

        updateCommand.Parameters.AddWithValue("@NewSCC", PaletsProducidos2.SCC)
        updateCommand.Parameters.AddWithValue("@NewFormatoID", PaletsProducidos2.FormatoID)
        updateCommand.Parameters.AddWithValue("@ObservacionesPalet", PaletsProducidos2.observacionesPalets)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", PaletsProducidos2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", PaletsProducidos2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPaletProducidoID", PaletsProducidos2.PaletProducidoID)
        updateCommand.Parameters.AddWithValue("@Terminado", PaletsProducidos2.Terminado)
        updateCommand.Parameters.AddWithValue("@EnAlmacen", PaletsProducidos2.EnAlmacen)
        updateCommand.Parameters.AddWithValue("@Multilote", PaletsProducidos2.MultiLote)
        updateCommand.Parameters.AddWithValue("@Id_Estado", If(PaletsProducidos2.Id_Estado = Nothing, 1, PaletsProducidos2.Id_Estado))
        updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

        Try
            updateCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsProducidos2Update" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function isDeleteAllowed(ByVal PaletProducidoID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()


        Dim proc As String = "[dbo].[PaletsProducidos2esPermitidoBorrar]"
        Dim query As System.Data.SqlClient.SqlCommand = dtb.Comando(proc)
        query.CommandType = CommandType.StoredProcedure
        query.Parameters.AddWithValue("@PaletID", PaletProducidoID)
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

    Public Function DeletePaletsProducidos2(ByVal PaletProducidoID As Integer, ByVal borradoCompleto As Boolean, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()


        Try
            If borradoCompleto Then
                Dim deleteProcedure As String = "[dbo].[PaletsProducidos2eliminarContenidoPaletsPorPalets]"
                Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
                deleteCommand.CommandType = CommandType.StoredProcedure
                deleteCommand.Parameters.AddWithValue("@PaletID", PaletProducidoID)
                deleteCommand.Parameters.AddWithValue("@borradoCompleto", 1)
                deleteCommand.ExecuteNonQuery()
            Else
                Dim deleteProcedure As String = "[dbo].[PaletsProducidos2eliminarContenidoPaletsPorPalets]"
                Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
                deleteCommand.CommandType = CommandType.StoredProcedure
                deleteCommand.Parameters.AddWithValue("@PaletID", PaletProducidoID)
                deleteCommand.Parameters.AddWithValue("@borradoCompleto", 0)
                deleteCommand.ExecuteNonQuery()

                Dim PaletsProducidos2 As DBO_PaletsProducidos2
                PaletsProducidos2 = DBO_PaletsProducidos2.Instance
                Dim updateProcedure As String = "[dbo].[PaletsProducidos3Delete]"
                Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
                Dim mDBO_usuarios As New DBO_Usuarios
                Dim aux As New spUsuarios
                mDBO_usuarios = aux.Select_Record(BasesParaCompatibilidad.Config.User, dtb)

                updateCommand.CommandType = CommandType.StoredProcedure
                updateCommand.Parameters.AddWithValue("@OldPaletProducidoID", PaletProducidoID)
                updateCommand.Parameters.AddWithValue("@NewFechaModificacion", Now)
                updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
                updateCommand.Parameters.AddWithValue("@NewUsuarioNombre", mDBO_usuarios.Usuario)
                updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
                updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
                updateCommand.ExecuteNonQuery()

                Dim count As Integer = updateCommand.Parameters("@ReturnValue").Value

            End If
            Return True
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos2Delete" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub CompletarPaletContenido(ByRef PaletProducido As DBO_PaletsProducidos2, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Try
            Dim p1 As String = PaletProducido.FormatoID.ToString
            dtb.PrepararConsulta("PaletsProducidos2CompletarContenidoPalet @p1, @p2")
            dtb.AņadirParametroConsulta("@p1", p1)
            dtb.AņadirParametroConsulta("@p2", scc)

            Dim tabla As DataTable = dtb.Consultar()

            If Convert.ToString(tabla.Rows(0).Item("CantidadCajas")) = String.Empty Then
                PaletProducido.NroCajasCompletar = 0
            Else
                PaletProducido.NroCajasCompletar = tabla.Rows(0).Item("CantidadCajas")
            End If

            PaletProducido.SCC = scc
            PaletProducido.PartePaletContenidoID = If(Convert.ToString(tabla.Rows(0).Item("ContenidoPalets")) = String.Empty, 0, tabla.Rows(0).Item("ContenidoPalets"))
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos2CompletarContenidoPalet" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            PaletProducido.NroCajasCompletar = 0
            PaletProducido.SCC = 0
            PaletProducido.PartePaletContenidoID = 0
        End Try
    End Sub

    Public Function GetUltimoSCCmas1(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.Conectar()

        Try
            Dim res As Integer = 0
            Dim selectProcedure As String = "[dbo].[PaletsProducidos3GetMaxSCC]"
            Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
            selectCommand.CommandType = CommandType.StoredProcedure

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                res = If(reader("SCC") Is Convert.DBNull, 1, Convert.ToInt32(reader("SCC")))
            Else
                res = 0
            End If
            reader.Close()

            Return res ' + 1
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos3GetMaxSCC" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return 1
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub GetCajasPalet(ByRef PaletProducido As DBO_PaletsProducidos2, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Dim spPaletsContenidos2 As New spPaletsContenidos2
        spPaletsContenidos2.GetCajasPalet(PaletProducido.PaletProducidoID, PaletProducido.CapacidadBotellasCajas, PaletProducido.CajasPalet, dtb)
    End Sub

    Public Sub GrabarPaletProducido2(ByRef m_PaleProducido As DBO_PaletsProducidos2, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If m_PaleProducido.PaletProducidoID > 0 Then
            UpdatePaletsProducidos2(m_PaleProducido, dtb)
        Else
            m_PaleProducido.PaletProducidoID = InsertPaletsProducidos2(m_PaleProducido, dtb)
        End If
    End Sub

    Public Function marcarComoExtraviado(ByVal scc As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            Dim m_dbo As New DBO_PaletsProducidos2
            m_dbo = Me.Select_RecordBySSCC(scc, dtb)
            m_dbo.EnAlmacen = False
            m_dbo.Id_Estado = 2
            Return Me.UpdatePaletsProducidos2(m_dbo, dtb)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function estaCargado(ByVal scc As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim cuenta As Integer = 0

        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[PaletsProducidos4EstaCargado]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@SCC", scc)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                cuenta = If(reader("cuenta") Is Convert.DBNull, 0, Convert.ToInt32(reader("cuenta")))
                reader.Close()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Throw New Exception("Error en la consulta. " & ex.Message)
        Finally
            dtb.Desconectar()
        End Try

        Return If(cuenta > 0, True, False)
    End Function

    Function calcularCajasAntesExpedir(ByVal scc As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Dim cuenta As Integer = 0

        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[PaletsProducidos4CalcularCajas]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@SCC", scc)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                cuenta = If(reader("cuenta") Is Convert.DBNull, 0, Convert.ToInt32(reader("cuenta")))
                reader.Close()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Throw New Exception("Error en la consulta. " & ex.Message)
        Finally
            dtb.Desconectar()
        End Try

        Return cuenta
    End Function

    Public Sub cargar_comboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PaletsProducidosSelectCboNoConforme", False, dtb)
    End Sub

    Public Function estaEtiquetado(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("select isnull(contadorImpresiones, 0) from paletsproducidos where paletproducidoid = @id")
        dtb.AņadirParametroConsulta("@id", id)
        Dim dt As DataTable = dtb.Consultar()
        If dt Is Nothing Then Return False
        If dt.Rows.Count = 0 Then Return False
        If dt.Rows(0) Is Nothing Then Return False

        If Convert.ToInt32(dt.Rows(0).Item(0)) = 0 Then Return False

        Return True
    End Function

    Public Function Etiquetar(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            dtb.PrepararConsulta("update paletsproducidos set contadorImpresiones = isnull(ContadorImpresiones, 0)+1 where paletproducidoid = @id")
            dtb.AņadirParametroConsulta("@id", id)
            Return dtb.Execute

        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
