

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

   Public Overloads Function Select_Record(ByVal FormatoEnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_FormatosEnvasados
       Dim dbo As New DBO_FormatosEnvasados
       dbo.searchKey = dbo.item("FormatoEnvasadoID")
       dbo.searchKey.value = FormatoEnvasadoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal FormatoEnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_FormatosEnvasados
       dbo.searchKey = dbo.item("FormatoEnvasadoID")
       dbo.searchKey.value = FormatoEnvasadoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Public Function FormatoHabitualPorEncajadoLinea(Linea As Integer, Encajado As Object) As Object
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("FormatosEnvasadosSelectFormatoHabitualPorEncajadoLinea " & Linea & ", " & Encajado, False).Rows(0).Item(0)
    End Function

    'public Sub cargar_lineas_por_linea_envasado(ByRef cbo As ComboBox, linea As String)
    '    cbo.mam_DataSource("TiposFormatosLineasSelectByLineaEnvasadoID " & linea, False)
    'End Sub

    Function select_lineaPorformato(ByVal formato As Integer) As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("select LineaenvasadoID from formatosEnvasados, tiposformatosLineas where formatosEnvasados.tipoformatoLineaid = tiposformatosLineas.tipoformatoLineaID and formatoEnvasadoID = " & formato, False).Rows(0).Item(0)
    End Function

    Function seleccionar_id_ultimo_formato_por_envasado_y_linea(ByVal envasadoid As Integer, ByVal lineaid As Integer) As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable = dtb.Consultar("select max(FormatoEnvasadoId) from formatosEnvasados, tiposFormatosLineas where formatosenvasados.tipoformatolineaid = tiposformatosLineas.tipoformatoLineaid and envasadoid=" & envasadoid & " and lineaEnvasadoid=" & lineaid, False)

        Return if(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Function devolver_articulos_por_envasado_y_linea(ByVal envasado As Integer, ByVal Linea_Envasado As Integer) As Object
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec FormatosEnvasados_articulos_por_envasado_y_linea " & envasado & ", " & Linea_Envasado, False)
    End Function

    Function seleccionar_ultimo_id(ByRef trans As SqlClient.SqlTransaction, ByRef con As SqlClient.SqlConnection) As Object
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, con, trans)
        Return dtb.Consultar("select max(formatoEnvasadoid) from formatosenvasados", False).Rows(0).Item(0)
    End Function

    Public Function buscar_por_envasado_articulo_formato(ByVal envasado As Integer, ByVal tipoformato As Integer, ByVal encajado As Integer, _
                                                         ByRef trans As SqlClient.SqlTransaction, ByRef con As SqlClient.SqlConnection) As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, con, trans)
        Return Convert.ToInt32(dtb.Consultar("exec FormatosEnvasados_comprobar_por_articulo_envasado_y_linea " & encajado & ", " & tipoformato & ", " & envasado, False).Rows(0).Item(0))
    End Function

    Function select_ultimo_palet_por_linea(ByVal linea As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("select top 1 horaFin " & _
                             "from paletsproducidos, paletscontenidos, formatosEnvasados, tiposFormatosLineas " & _
                             "where paletsproducidos.paletproducidoid = paletscontenidos.paletcontenidoid " & _
                             "and paletsproducidos.formatoid = formatosEnvasados.formatoEnvasadoid " & _
                             "and formatosEnvasados.TipoFormatoLineaid =  tiposFormatosLineas.TipoFormatoLineaid " & _
                             "and lineaEnvasadoID = order by horaFin desc", False).Rows(0).Item(0)
    End Function

End Class
