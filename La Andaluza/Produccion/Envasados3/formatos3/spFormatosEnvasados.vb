

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
        Return dtb.Consultar("FormatosEnvasadosSelectFormatoHabitualPorEncajadoLinea " & Linea & ", " & Encajado, False).Rows(0).Item(0)
    End Function

    'public Sub cargar_lineas_por_linea_envasado(ByRef cbo As ComboBox, linea As String)
    '    cbo.mam_DataSource("TiposFormatosLineasSelectByLineaEnvasadoID " & linea, False)
    'End Sub

    Function select_lineaPorformato(ByVal formato As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Return dtb.Consultar("select LineaenvasadoID from formatosEnvasados, tiposformatosLineas where formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaID and formatoEnvasadoID = " & formato, False).Rows(0).Item(0)
    End Function

    Function seleccionar_id_ultimo_formato_por_envasado_y_linea(ByVal envasadoid As Integer, ByVal lineaid As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Dim dt As DataTable = dtb.Consultar("select max(FormatoEnvasadoId) from formatosEnvasados, tiposFormatosLineas where formatosenvasados.tipoformatolineaid = tiposformatosLineas.tipoformatoLineaid and envasadoid=" & envasadoid & " and lineaEnvasadoid=" & lineaid, False)

        Return If(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Function devolver_articulos_por_envasado_y_linea(ByVal envasado As Integer, ByVal Linea_Envasado As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Object
        Return dtb.Consultar("FormatosEnvasados_articulos_por_envasado_y_linea " & envasado & ", " & Linea_Envasado, True)
    End Function

    Function seleccionar_ultimo_id(ByRef dtb As BasesParaCompatibilidad.DataBase) As Object
        Return dtb.Consultar("select max(formatoEnvasadoid) from formatosenvasados", False).Rows(0).Item(0)
    End Function

    Public Function buscar_por_envasado_articulo_formato(ByVal envasado As Integer, ByVal tipoformato As Integer, ByVal encajado As Integer, _
                                                         ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Return Convert.ToInt32(dtb.Consultar("FormatosEnvasados_comprobar_por_articulo_envasado_y_linea " & encajado & ", " & tipoformato & ", " & envasado, True).Rows(0).Item(0))
    End Function

    Function select_ultimo_palet_por_linea(ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("select top 1 horaFin " & _
                             "from paletsproducidos, paletscontenidos, formatosEnvasados, tiposFormatosLineas " & _
                             "where paletsproducidos.paletproducidoid = paletscontenidos.paletcontenidoid " & _
                             "and paletsproducidos.formatoid = formatosEnvasados.formatoEnvasadoid " & _
                             "and formatosEnvasados.TipoFormatoLineaid =  tiposFormatosLineas.TipoFormatoLineaid " & _
                             "and lineaEnvasadoID = order by horaFin desc", False).Rows(0).Item(0)
    End Function

End Class
