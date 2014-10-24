Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPaletsContenidos
Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PaletsContenidosSelect3]", _
                        "[dbo].[PaletsContenidosInsert3]", _
                        "[dbo].[PaletsContenidosUpdate3]", _
                        "[dbo].[PaletsContenidos2eliminarContenidoPalet]", _
                        "[dbo].[PaletsContenidosSelectDgv]", _
                        "[dbo].[PaletsContenidos2ByPaletProducidoID]")
    End Sub

    Public Overloads Function Select_Record(ByVal PaletContenidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PaletsContenidos
        Dim dbo As New DBO_PaletsContenidos
        dbo.searchKey = dbo.item("PaletContenidoID")
        dbo.searchKey.value = PaletContenidoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PaletContenidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PaletsContenidos
        dbo.searchKey = dbo.item("PaletContenidoID")
        dbo.searchKey.value = PaletContenidoID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Function ValidarRangoHorario(ByVal PaletContenido As DBO_PaletsContenidos, ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Try
            Dim res As Integer = 0
            Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[PaletsContenidos2ValidarRangoHorario2]")
            selectCommand.CommandType = CommandType.StoredProcedure
            selectCommand.Parameters.AddWithValue("@HoraInicio", PaletContenido.HoraInicio)
            selectCommand.Parameters.AddWithValue("@HoraFin", PaletContenido.HoraFin)
            selectCommand.Parameters.AddWithValue("@PaletContenidoID", PaletContenido.ID)
            selectCommand.Parameters.AddWithValue("@LineaEnvasadoID", linea)

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                res = System.Convert.ToInt32(If(reader(0) Is Convert.DBNull, 0, reader(0)))
            End If
            reader.Close()
            Return If(res > 0, False, True)

        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Conectar()
        End Try
    End Function

    Public Sub cargarComboDetallesMonodosis(ByRef combo As ComboBox, ByVal tipoFormato As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        combo.mam_DataSource("PaletsContenidosSelectMonodosis2 " & tipoFormato, False, dtb)
    End Sub

    'Public Sub cargarDgvMonodosis(ByRef dgv As ComboBox)
    '    dgv.mam_DataSource("PaletsContenidosSelectDvgMonodosis", False)
    'End Sub

    Public Function devolver_media_creacion_contenidos(ByVal linea As Integer, ByVal tipo_formato As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Double

        dtb.PrepararConsulta("select isnull(avg(datediff(minute, horainicio, horafin)), 1) from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid and lineaEnvasadoid = @linea and tipoformatoEnvasadoID = @tf")
        dtb.AñadirParametroConsulta("@linea", linea)
        dtb.AñadirParametroConsulta("@tf", tipo_formato)
        Dim dt As DataTable = dtb.Consultar()
        'Dim dt As DataTable = dtb.Consultar("select isnull(avg(datediff(minute, horainicio, horafin)), 1) from paletsContenidos, paletsproducidos, formatosEnvasados, tiposformatosLineas where paletsproducidos.paletproducidoid = paletscontenidos.paletproducidoid and formatoid = formatoEnvasadoid and formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaid and lineaEnvasadoid = " & linea & " and tipoformatoEnvasadoID = " & tipo_formato, False)

        If dt Is Nothing Then Return 15
        If dt.Rows.Count = 0 Then Return 15
        If dt.Rows(0).Item(0) Is Convert.DBNull Then Return 15
        If dt.Rows(0).Item(0) Is Nothing Then Return 15

        Return CType(dt.Rows(0).Item(0), Double)
    End Function

    Public Function devolver_monodosis_para_doypack(ByVal FormatoEnvasado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select descripcionLa, monodosis.id_tipoFormato, cantidad " & _
                                            "from doypack, monodosis, articulos1  " & _
                                            "where  " & _
                                            "doypack.id_monodosis = monodosis.id_articuloPrimario " & _
                                            "and " & _
                                            "articulos1.articuloid = monodosis.id_articuloPrimario " & _
                                            "and " & _
                                            "doypack.id_tipoformato = @id")
        dtb.AñadirParametroConsulta("@id", FormatoEnvasado)
        Return dtb.Consultar
    End Function

    Public Function ultima_hora(ByVal linea As Integer, ByVal envasado As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As DateTime
        dtb.PrepararConsulta("PaletsProducidos2GetUltimaHoraProduccionPorLinea2 @linea, @env")
        dtb.AñadirParametroConsulta("@linea", linea)
        dtb.AñadirParametroConsulta("@env", envasado)
        Dim dt As DataTable = dtb.Consultar()

        If dt Is Nothing Then Return DateTime.Now
        If dt.Rows(0) Is Nothing Then Return DateTime.Now
        If dt.Rows(0).Item(0) Is Convert.DBNull Then Return DateTime.Now

        Return dt.Rows(0).Item(0)
    End Function

    Public Function PaletsContenidosPorPaletsProducidos(ByVal PaletProducidoID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("PaletsContenidos2ByPaletProducidoID @id")
        dtb.AñadirParametroConsulta("@id", PaletProducidoID)
        Return dtb.Consultar()
    End Function
End Class
