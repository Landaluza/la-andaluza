Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spArticulosEnvasadosHistoricos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposFormatos1Select]", _
                     "[dbo].[TiposFormatos1Insert3]", _
                     "[dbo].[TiposFormatosUpdate]", _
                     "[dbo].[TiposFormatosDelete]", _
                     "[dbo].[TiposFormatosSelectDgv]", _
                     "[dbo].[TiposFormatosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal TipoFormatoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ArticulosEnvasadoHistorico
        Dim dbo As New DBO_ArticulosEnvasadoHistorico
        dbo.searchKey = dbo.item("TipoFormatoID")
        dbo.searchKey.value = TipoFormatoID
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoFormatoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_ArticulosEnvasadoHistorico
        dbo.searchKey = dbo.item("TipoFormatoID")
        dbo.searchKey.value = TipoFormatoID
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

    Public Sub cargar_TiposFormatos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposFormatosCbo", False)
    End Sub

    'Public Sub usar_con_precaucion(ByRef cbo As ComboBox)
    '    cbo.mam_DataSource("select tipoformatoid, descripcion from tiposformatos order by descripcion", False)
    'End Sub

    Public Sub cargar_TiposFormatos_por_palet(ByRef cbo As ComboBox, ByVal palet As Integer)
        cbo.mam_DataSource("TiposFormatosCboPorPalet " & palet, False)
    End Sub

    Public Sub cargar_TiposFormatos_Libres(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposFormatosCboLibres", False)
    End Sub

    Public Sub cargar_TiposFormatos_Todos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposFormatosCboAll", False)
    End Sub

    Public Sub cargar_TiposFormatos_SinLinea(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposFormatosCboAllSinLinea", False)
    End Sub

    Public Sub cargar_comboByTipoFormatoLinea(ByRef cbo As ComboBox, ByVal formatoLinea As Integer)
        cbo.mam_DataSource("TiposFormatos2SelectByTipoFormatoLineaID_all2 " & formatoLinea, False)
    End Sub

    Public Sub cargar_comboByTipoFormatoLineaYtipoProducto(ByRef cbo As ComboBox, ByVal formatoLinea As Integer, ByVal tipoProducto As Integer)
        cbo.mam_DataSource("TiposFormatos2SelectByTipoFormatoLineaID_tipoProducto " & formatoLinea & ", " & tipoProducto, False)
    End Sub

    Public Sub cargar_comboByLinea_activos(ByRef cbo As ComboBox, ByVal Linea As Integer)
        cbo.mam_DataSource("[CambiosFormatosEnvasados2_TiposFormatosCbo2] " & Linea, False)
    End Sub

    Public Sub cargar_comboByLinea(ByRef cbo As ComboBox, ByVal Linea As Integer)
        cbo.mam_DataSource("[CambiosFormatosEnvasados2_TiposFormatosCbo] " & Linea, False)
    End Sub

    Public Function seleccionar_ultimo_registro(ByRef dtb as BasesParaCompatibilidad.Database) As Integer
        Return dtb.Consultar("select max(tipoformatoid) from tiposformatos", False).Rows(0).Item(0)
    End Function

    Public Sub cargar_articulos_Envasados(ByRef cbo As ComboBox)
        cbo.mam_DataSource("ArticulosEnvasadosCbo", False)
    End Sub

    Public Sub cargar_articulos_Envasados_secundarios(ByRef cbo As ComboBox)
        cbo.mam_DataSource("ArticulosEnvasadosSecundariosCbo", False)
    End Sub
End Class
