

Public Class spFormatosEnvasados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
        MyBase.New("[dbo].[FormatosEnvasados2Select2]", _
                     "[dbo].[FormatosEnvasadosInsert]", _
                     "[dbo].[FormatosEnvasadosUpdate]", _
                     "[dbo].[FormatosEnvasados4Delete]", _
                     "[dbo].[Envasados4SelectFormatos]", _
                     "[dbo].[Envasados4SelectFormatos]")
   End Sub

    Public Overloads Function Select_Record(ByVal FormatoEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_FormatosEnvasados
        Dim dbo As New DBO_FormatosEnvasados
        dbo.searchKey = dbo.item("FormatoEnvasadoID")
        dbo.searchKey.value = FormatoEnvasadoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal FormatoEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_FormatosEnvasados
        dbo.searchKey = dbo.item("FormatoEnvasadoID")
        dbo.searchKey.value = FormatoEnvasadoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Function FormatoHabitualPorEncajadoLinea(Linea As Integer, Encajado As Object, ByRef dtb As BasesParaCompatibilidad.DataBase) As Object
        dtb.PrepararConsulta("FormatosEnvasadosSelectFormatoHabitualPorEncajadoLinea @lin, @enc")
        dtb.AņadirParametroConsulta("@lin", Linea)
        dtb.AņadirParametroConsulta("@enc", Encajado)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    'public Sub cargar_lineas_por_linea_envasado(ByRef cbo As ComboBox, linea As String)
    '    cbo.mam_DataSource("TiposFormatosLineasSelectByLineaEnvasadoID " & linea, False)
    'End Sub

    Function select_lineaPorformato(ByVal formato As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("select LineaenvasadoID from formatosEnvasados, tiposformatosLineas where formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaID and formatoEnvasadoID = @for")
        dtb.AņadirParametroConsulta("@for", formato)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Function seleccionar_id_ultimo_formato_por_envasado_y_linea(ByVal envasadoid As Integer, ByVal lineaid As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("select max(FormatoEnvasadoId) from formatosEnvasados, tiposFormatosLineas where formatosenvasados.tipoformatolineaid = tiposformatosLineas.tipoformatoLineaid and envasadoid= @env and lineaEnvasadoid= @lin")
        dtb.AņadirParametroConsulta("@env", envasadoid)
        dtb.AņadirParametroConsulta("@lin", lineaid)
        Dim dt As DataTable = dtb.Consultar()

        Return If(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Function devolver_articulos_por_envasado_y_linea(ByVal envasado As Integer, ByVal Linea_Envasado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Object
        dtb.PrepararConsulta("FormatosEnvasados_articulos_por_envasado_y_linea @env, @lin")
        dtb.AņadirParametroConsulta("@env", envasado)
        dtb.AņadirParametroConsulta("@lin", Linea_Envasado)
        Return dtb.Consultar()
    End Function

    Function seleccionar_ultimo_id(ByRef dtb As BasesParaCompatibilidad.DataBase) As Object
        dtb.PrepararConsulta("select max(formatoEnvasadoid) from formatosenvasados")
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Public Function buscar_por_envasado_articulo_formato(ByVal envasado As Integer, ByVal tipoformato As Integer, ByVal encajado As Integer, _
                                                         ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        dtb.PrepararConsulta("FormatosEnvasados_comprobar_por_articulo_envasado_y_linea @enc, @for, @env")
        dtb.AņadirParametroConsulta("@enc", encajado)
        dtb.AņadirParametroConsulta("@for", tipoformato)
        dtb.AņadirParametroConsulta("@env", envasado)
        Return Convert.ToInt32(dtb.Consultar().Rows(0).Item(0))
    End Function

    Function select_ultimo_palet_por_linea(ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select top 1 horaFin " & _
                             "from paletsproducidos, paletscontenidos, formatosEnvasados, tiposFormatosLineas " & _
                             "where paletsproducidos.paletproducidoid = paletscontenidos.paletcontenidoid " & _
                             "and paletsproducidos.formatoid = formatosEnvasados.formatoEnvasadoid " & _
                             "and formatosEnvasados.TipoFormatoLineaid =  tiposFormatosLineas.TipoFormatoLineaid " & _
                             "and lineaEnvasadoID = order by horaFin desc")

        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Function actualizar(m_DBO_FormatoEnvasado As DBO_FormatosEnvasados, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update formatosenvasados set TipoFormatoEnvasadoID= @tipo, TipoFormatoLineaID= @linea where FormatoEnvasadoID= @id")
        dtb.AņadirParametroConsulta("@tipo", m_DBO_FormatoEnvasado.TipoFormatoEnvasadoID)
        dtb.AņadirParametroConsulta("@linea", m_DBO_FormatoEnvasado.TipoFormatoLineaID)
        dtb.AņadirParametroConsulta("@id", m_DBO_FormatoEnvasado.ID)
        Return dtb.Execute
    End Function

End Class
