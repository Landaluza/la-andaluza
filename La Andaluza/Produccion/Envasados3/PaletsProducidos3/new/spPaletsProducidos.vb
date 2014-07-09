Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPaletsProducidos
Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PaletsProducidos5Select]", _
                        "[dbo].[PaletsProducidosInsert]", _
                        "[dbo].[PaletsProducidosUpdate]", _
                        "[dbo].[PaletsProducidos3Delete]", _
                        "[dbo].[PaletsProducidos6SelectDgv]", _
                        "[dbo].[PaletsProducidos6SelectByFormatoEnvasadoID]")
    End Sub

    Public Overloads Function Select_Record(ByVal PaletProducidoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PaletsProducidos
        Dim dbo As New DBO_PaletsProducidos
        dbo.searchKey = dbo.item("PaletProducidoID")
        dbo.searchKey.value = PaletProducidoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PaletProducidoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        'borrar contenidos

        'Dim dbo As New DBO_PaletsProducidos
        'dbo.searchKey = dbo.item("PaletProducidoID")
        'dbo.searchKey.value = PaletProducidoID
        'Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), trans)


        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx

        Try
            Dim deleteProcedure As String = "[dbo].[PaletsProducidos2eliminarContenidoPaletsPorPalets]"
            Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@PaletID", PaletProducidoID)
            deleteCommand.Parameters.AddWithValue("@borradoCompleto", 1)
            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos2Delete" & Environment.NewLine() & Environment.NewLine() & ex.Message, ex.GetType.ToString)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Function Delete_sin_borrado_completo(ByVal PaletProducidoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean

        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx

        Try

            Dim deleteProcedure As String = "[dbo].[PaletsProducidos2eliminarContenidoPaletsPorPalets]"
            Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@PaletID", PaletProducidoID)
            deleteCommand.Parameters.AddWithValue("@borradoCompleto", 0)
            deleteCommand.ExecuteNonQuery()

            Dim PaletsProducidos2 As New DBO_PaletsProducidos

            Dim updateProcedure As String = "[dbo].[PaletsProducidos3Delete]"
            Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
            Dim mDBO_usuarios As New DBO_Usuarios
            Dim aux As New spUsuarios
            mDBO_usuarios = aux.Select_Record(BasesParaCompatibilidad.Config.User)

            updateCommand.CommandType = CommandType.StoredProcedure
            updateCommand.Parameters.AddWithValue("@OldPaletProducidoID", PaletProducidoID)
            updateCommand.Parameters.AddWithValue("@NewFechaModificacion", Now)
            updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
            updateCommand.Parameters.AddWithValue("@NewUsuarioNombre", mDBO_usuarios.Usuario)
            updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
            updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
            updateCommand.ExecuteNonQuery()

            Dim count As Integer = updateCommand.Parameters("@ReturnValue").Value

            Return True
        Catch ex As Exception
            MessageBox.Show("Error en PaletsProducidos2Delete" & Environment.NewLine() & Environment.NewLine() & ex.Message, ex.GetType.ToString)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Public Sub cargar_PaletsProducidos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("PaletsProducidosCbo", False)
    End Sub

    Public Function devolver_palets_incompletos_por_TipoFormato(ByVal TipoFormatoId As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec PaletsProducidos3SelectPaletsIncompletos " & TipoFormatoId, False)
    End Function

    Public Function devolver_ultimo_palet(ByRef trans As System.Data.SqlClient.SqlTransaction, ByRef con As System.Data.SqlClient.SqlConnection) As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, con, trans)
        Return dtb.Consultar("select max(paletproducidoid) from paletsproducidos", False).Rows(0).Item(0)
    End Function

    Public Sub cargar_PaletsProducidosNC_byArticulo(ByRef cbo As ComboBox, ByVal TipoFormatoID As Integer)
        cbo.mam_DataSource("PaletsProducidosNC_byArticuloCbo " & TipoFormatoID, False)
    End Sub

    Public Sub cargar_PaletsProducidosEstados(ByRef cbo As ComboBox)
        cbo.mam_DataSource("PaletsProducidosEstadosCbo", False)
    End Sub

    Public Function Select_RecordBySSCC(ByVal scc As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PaletsProducidos
        Dim dbo As New DBO_PaletsProducidos
        dbo.searchKey = dbo.item("SCC")
        dbo.searchKey.value = scc
        MyBase.Select_proc(dbo, "[dbo].[PaletsProducidos5SelectBySCC]", trans)
        Return dbo
    End Function

    Public Function calcularCajasAntesExpedir(ByVal scc As Integer, Optional cnn As SqlClient.SqlConnection = Nothing, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Integer
        Dim dtb as BasesParaCompatibilidad.Database
        If trans Is Nothing Then
            dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Else
            dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, cnn, trans)
        End If

        Dim cuenta As Integer = 0
        cuenta = dtb.Consultar("exec [dbo].[PaletsProducidos4CalcularCajas] " & scc, False).Rows(0).Item(0)
        If trans Is Nothing Then dtb.Conectar()

        Return cuenta
    End Function

    Public Sub anadir_impresion_etiqueta(ByVal scc As String)
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        dtb.Consultar("update paletsproducidos set ContadorImpresion = ContadorImpresion +1 where scc =" & scc, False)
    End Sub

    Public Function SelectPaletsProducidosBySccAndReferencia() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("SelectPaletsProducidosBySccAndReferencia", True)
    End Function

    Public Function SelectPaletsProducidosSumReferencia() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("SelectPaletsProducidosSumReferencia", False)
    End Function

    Public Function DevolverPorFecha(ByVal EnvID As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)

        Dim strSELECT As String = "select Envasados.EnvasadoID, PaletsProducidos.SCC, PaletsProducidos.FormatoID, articulo Descripcion," & _
                       "DATEDIFF(minute, PaletsContenidos.HoraInicio, PaletsContenidos.HoraFin) as Duracion," & _
                       "PaletsContenidos.HoraInicio,PaletsContenidos.HoraFin, PaletsContenidos.CantidadCajas, PaletsProducidos.Terminado"

        Dim strFROM As String = " from Envasados INNER JOIN FormatosEnvasados ON Envasados.EnvasadoID = FormatosEnvasados.EnvasadoID " & _
                            "INNER JOIN PaletsProducidos ON FormatosEnvasados.FormatoEnvasadoID = PaletsProducidos.FormatoID " & _
                            "INNER JOIN articulosEnvasadoshistorico ON FormatosEnvasados.TipoFormatoEnvasadoID = TipoFormato " & _
                            "INNER JOIN PaletsContenidos ON PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID"

        Dim strWHERE As String = " where Envasados.EnvasadoID =" & EnvID.ToString

        Return dtb.Consultar(strSELECT & strFROM & strWHERE, False)
    End Function

    Public Function seleccionarTipoPaletPorScc(ByVal scc As Integer) As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable = dtb.Consultar("select palettipoid from articulosenvasesTerciarios, formatosEnvasados, paletsproducidos " & _
        "where articulosenvasesTerciarios.sccetiquetaid = tipoformatoEnvasadoid " & _
        "and formatoEnvasadoid = formatoid " & _
        "and scc = " & scc)

        If dt Is Nothing Then
            Return 0
        Else
            Return CType(dt.Rows(0).Item(0), Integer)
        End If
    End Function

    Public Function No_conforme_por_formato(ByVal formato As Integer, Optional ByRef trans As SqlClient.SqlTransaction = Nothing) As Integer
        Dim dtb as BasesParaCompatibilidad.Database
        If trans Is Nothing Then
            dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Else
            dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, trans)
        End If

        Dim dt As DataTable = dtb.Consultar("select id_paletproducidonoconforme from articulosenvasesterciarios where sccetiquetaid = " & formato.ToString, False)
        If dt Is Nothing Then Return 0
        If Convert.IsDBNull(dt.Rows(0).Item(0)) Then Return 0

        Return CInt(dt.Rows(0).Item(0))
    End Function

    Public Function estaEtiquetado(ByVal id As Integer) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable = dtb.Consultar("select isnull(contadorImpresiones, 0) from paletsproducidos where paletproducidoid = " & id, False)
        If dt Is Nothing Then Return False
        If dt.Rows(0) Is Nothing Then Return False

        If CInt(dt.Rows(0).Item(0)) = 0 Then Return False

        Return True
    End Function

    Public Function Etiquetar(ByVal id As Integer) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Try
            Return dtb.ConsultaAlteraciones("update paletsproducidos set contadorImpresiones = isnull(ContadorImpresiones, 0)+1 where paletproducidoid = " & id)

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function estaCargado(ByVal scc As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim cuenta As Integer = 0

        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[PaletsProducidos4EstaCargado]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        If Not trans Is Nothing Then selectCommand.Transaction = trans
        selectCommand.Parameters.AddWithValue("@SCC", scc)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                cuenta = System.Convert.ToInt32(If(reader("cuenta") Is Convert.DBNull, 0, reader("cuenta")))
                reader.Close()
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Throw New Exception("Error en la consulta. " & ex.Message)
        Finally
            If trans Is Nothing Then connection.Close()
        End Try

        Return If(cuenta > 0, True, False)
    End Function

    Public Function marcarComoExtraviado(ByVal scc As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Try
            Dim m_dbo As New DBO_PaletsProducidos
            m_dbo = Me.Select_RecordBySSCC(scc, trans)
            m_dbo.EnAlmacen = False
            m_dbo.Id_Estado = 2
            Return Me.UpdateProcedure(m_dbo, trans)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
