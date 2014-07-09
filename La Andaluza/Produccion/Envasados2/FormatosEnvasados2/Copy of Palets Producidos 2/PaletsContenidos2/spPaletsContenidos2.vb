Imports BasesParaCompatibilidad.ComboBoxExtension


Class spPaletsContenidos2
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[PaletsContenidosSelect2]", "[dbo].[PaletsContenidosInsert2]", "[dbo].[PaletsContenidosUpdate2]", _
                   "PaletsContenidos2eliminarContenidoPalet", "PaletsContenidos2ByPaletProducidoID", "PaletsContenidos2ByPaletProducidoID")
    End Sub

    Public Function Select_Record(ByVal PaletContenidoID As Integer) As DBO_PaletsContenidos2
        BasesParaCompatibilidad.BD.Conectar()
        Dim Dbo_PaletsContenidos2 As New DBO_PaletsContenidos2
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsContenidosSelect2]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)

        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@PaletContenidoID", PaletContenidoID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                Dbo_PaletsContenidos2.PaletContenidoID = If(reader("PaletContenidoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletContenidoID")))
                Dbo_PaletsContenidos2.HoraInicio = If(reader("HoraInicio") Is Convert.DBNull, System.DateTime.Now.TimeOfDay, reader("HoraInicio"))
                Dbo_PaletsContenidos2.HoraFin = If(reader("HoraFin") Is Convert.DBNull, System.DateTime.Now.TimeOfDay, reader("HoraFin"))
                Dbo_PaletsContenidos2.CantidadCajas = If(reader("CantidadCajas") Is Convert.DBNull, 0, Convert.ToInt32(reader("CantidadCajas")))
                Dbo_PaletsContenidos2.PaletProducidoID = If(reader("PaletProducidoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PaletProducidoID")))
                Dbo_PaletsContenidos2.Terminado = If(reader("Terminado") Is Convert.DBNull, False, Convert.ToBoolean(reader("Terminado")))
                Dbo_PaletsContenidos2.EnAlmacen = If(reader("EnAlmacen") Is Convert.DBNull, False, Convert.ToBoolean(reader("EnAlmacen")))
                Dbo_PaletsContenidos2.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                Dbo_PaletsContenidos2.FormatoEnvasadoID = If(reader("FormatoEnvasadoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormatoEnvasadoID")))
                Dbo_PaletsContenidos2.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                Dbo_PaletsContenidos2.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))

                'campos calculados
                Select_Record_Calculado(Dbo_PaletsContenidos2)
            Else
                Dbo_PaletsContenidos2 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsContenidosSelect" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            connection.Close()
        End Try

        Return Dbo_PaletsContenidos2
    End Function

    Private Sub Select_Record_Calculado(ByRef PaletContenido As DBO_PaletsContenidos2)
        If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsContenidos2GetSCCPorPalet]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)

        selectCommand.CommandType = CommandType.StoredProcedure
        If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then selectCommand.Transaction = BasesParaCompatibilidad.BD.transaction
        selectCommand.Parameters.AddWithValue("@PaletProducidoID", PaletContenido.PaletProducidoID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            Dim encontro As Boolean = False
            If reader.Read Then
                PaletContenido.SCC = (If(reader("SCC") Is Convert.DBNull, 0, reader("SCC")))
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsContenidos2GetSCCPorPalet" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally

            If BasesParaCompatibilidad.BD.transaction Is Nothing Then connection.Close()
        End Try
    End Sub

    Public Function InsertPaletsContenidos2(ByVal dbo_PaletsContenidos2 As DBO_PaletsContenidos2) As Integer
        If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[PaletsContenidosInsert2]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then insertCommand.Transaction = BasesParaCompatibilidad.BD.transaction

        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@HoraInicio", dbo_PaletsContenidos2.HoraInicio)
        insertCommand.Parameters.AddWithValue("@HoraFin", dbo_PaletsContenidos2.HoraFin)
        insertCommand.Parameters.AddWithValue("@CantidadCajas", dbo_PaletsContenidos2.CantidadCajas)
        insertCommand.Parameters.AddWithValue("@PaletProducidoID", dbo_PaletsContenidos2.PaletProducidoID)
        insertCommand.Parameters.AddWithValue("@Terminado", dbo_PaletsContenidos2.Terminado)
        insertCommand.Parameters.AddWithValue("@EnAlmacen", dbo_PaletsContenidos2.EnAlmacen)
        insertCommand.Parameters.AddWithValue("@Observaciones", If(dbo_PaletsContenidos2.Observaciones Is Nothing, String.Empty, dbo_PaletsContenidos2.Observaciones))
        insertCommand.Parameters.AddWithValue("@FormatoID", dbo_PaletsContenidos2.FormatoEnvasadoID)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_PaletsContenidos2.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_PaletsContenidos2.UsuarioModificacion)
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output

        Try
            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            Return count
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsContenidosInsert" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return Nothing
        Finally
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then connection.Close()
        End Try
    End Function

    Public Function UpdatePaletsContenidos2(ByVal dbo_PaletsContenidos2 As DBO_PaletsContenidos2) As Boolean
        If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim updateProcedure As String = "[dbo].[PaletsContenidosUpdate2]"
        Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)

        updateCommand.CommandType = CommandType.StoredProcedure
        If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then updateCommand.Transaction = BasesParaCompatibilidad.BD.transaction
        updateCommand.Parameters.AddWithValue("@NewHoraInicio", dbo_PaletsContenidos2.HoraInicio)
        updateCommand.Parameters.AddWithValue("@NewHoraFin", dbo_PaletsContenidos2.HoraFin)
        updateCommand.Parameters.AddWithValue("@NewCantidadCajas", dbo_PaletsContenidos2.CantidadCajas)
        updateCommand.Parameters.AddWithValue("@NewPaletProducidoID", dbo_PaletsContenidos2.PaletProducidoID)
        updateCommand.Parameters.AddWithValue("@NewTerminado", dbo_PaletsContenidos2.Terminado)
        updateCommand.Parameters.AddWithValue("@NewEnAlmacen", dbo_PaletsContenidos2.EnAlmacen)
        updateCommand.Parameters.AddWithValue("@NewObservaciones", If(dbo_PaletsContenidos2.Observaciones Is Nothing, Convert.DBNull, dbo_PaletsContenidos2.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewFormatoID", dbo_PaletsContenidos2.FormatoEnvasadoID)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", dbo_PaletsContenidos2.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", dbo_PaletsContenidos2.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldPaletContenidoID", dbo_PaletsContenidos2.PaletContenidoID)
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
            MessageBox.Show("Error en PaletsContenidosUpdate" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then connection.Close()
        End Try
    End Function

    Public Function PaletsContenidosPorPaletsProducidos(ByVal PaletProducidoID As Integer) As DataTable
        Return dtb.Consultar("PaletsContenidos2ByPaletProducidoID " & PaletProducidoID)
    End Function


    Public Function PaletsContenidosPorPaletsProducidos(ByVal PaletProducidoID As Integer, ByRef dtb as BasesParaCompatibilidad.Database) As DataTable

        Return dtb.Consultar("exec PaletsContenidos2ByPaletProducidoID " & PaletProducidoID, False)
    End Function

    Public Function EliminarPaletContenido(ByVal PaletContenidoID As Integer) As Boolean
        Try
            Dim tabla As DataTable = dtb.Consultar("PaletsContenidos2eliminarContenidoPalet " & Convert.ToString(PaletContenidoID))

            If Not Convert.ToBoolean(tabla.Rows(0).Item(0)) Then
                MessageBox.Show("no se puede eliminar, se encuentra en uso", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub GetCajasPalet(ByVal PaletProducidoID As Integer, ByRef CapacidadBotellasCajas As Integer, ByRef CajasPalet As Integer)
        Try
            'Dim tabla As DataTable = DataTableFill("PaletsContenidos2CapacidadCajaDePaletProducido " & PaletProducidoID)
            Dim tabla As DataTable = dtb.Consultar("exec PaletsContenidos2CapacidadCajaDePaletProducido " & Convert.ToString(PaletProducidoID))

            CapacidadBotellasCajas = Convert.ToInt32(tabla.Rows(0).Item(0))
            CajasPalet = Convert.ToInt32(tabla.Rows(0).Item(1))
        Catch ex As Exception
        End Try
    End Sub

    Public Sub DarPorTerminadoPaletContenido(ByVal dbo_PaletsContenidos2 As DBO_PaletsContenidos2)
        'obtiene los valores adicionales, el que nos interesa es el SCC
        Select_Record_Calculado(dbo_PaletsContenidos2)
        If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Try
            Dim updateProcedure As String = "[dbo].[PaletsContenidos2TerminarPorSCC]"
            Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
            updateCommand.CommandType = CommandType.StoredProcedure
            If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then updateCommand.Transaction = BasesParaCompatibilidad.BD.transaction
            updateCommand.Parameters.AddWithValue("@SCC", dbo_PaletsContenidos2.SCC)
            updateCommand.Parameters.AddWithValue("@UsuarioID", Convert.ToString(BasesParaCompatibilidad.Config.User))
            updateCommand.Parameters.AddWithValue("@FechaMod", BasesParaCompatibilidad.Calendar.ArmarFecha(Today + " " + TimeOfDay))
            updateCommand.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en PaletsContenidos2TerminarPorSCC" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
        Finally
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then connection.Close()
        End Try
    End Sub

    Public Function ValidarRangoHorario(ByVal PaletContenido As DBO_PaletsContenidos2, ByVal envasado As Integer) As Boolean
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Try
            Dim res As Integer = 0
            Dim selectProcedure As String = "[dbo].[PaletsContenidos2ValidarRangoHorario2]"
            Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@HoraInicio", PaletContenido.HoraInicio)
            selectCommand.Parameters.AddWithValue("@HoraFin", PaletContenido.HoraFin)
            selectCommand.Parameters.AddWithValue("@PaletContenidoID", PaletContenido.PaletContenidoID)
            selectCommand.Parameters.AddWithValue("@LineaEnvasadoID", PaletContenido.LineaID)
            selectCommand.Parameters.AddWithValue("@envasadoid", envasado)

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                res = If(reader(0) Is Convert.DBNull, 0, Convert.ToInt32(reader(0)))
            End If
            reader.Close()

            If res = 0 Then Return True

            Return False
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en PaletsContenidos2ValidarRangoHorario" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub cargarComboDetallesMonodosis(ByRef combo As ComboBox, ByVal tipoFormato As Integer)
        combo.mam_DataSource("PaletsContenidosSelectMonodosis " & tipoFormato, False)
    End Sub

    Public Sub cargarDgvMonodosis(ByRef dgv As ComboBox)
        dgv.mam_DataSource("PaletsContenidosSelectDvgMonodosis", False)
    End Sub
End Class
