Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spFormatosArticulos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposFormatos1Select]", _
                     "[dbo].[TiposFormatosInsert]", _
                     "[dbo].[TiposFormatosUpdate]", _
                     "[dbo].[TiposFormatosDelete]", _
                     "[dbo].[TiposFormatosSelectDgv]", _
                     "[dbo].[TiposFormatosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal TipoFormatoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposFormatos
        Dim dbo As New DBO_TiposFormatos
        dbo.searchKey = dbo.item("TipoFormatoID")
        dbo.searchKey.value = TipoFormatoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoFormatoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dbo As New DBO_TiposFormatos
        dbo.searchKey = dbo.item("TipoFormatoID")
        dbo.searchKey.value = TipoFormatoID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), trans)
    End Function

    Public Sub cargar_TiposFormatos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposFormatosCbo", False)
    End Sub

    Public Sub cargar_TiposFormatos_por_palet(ByRef cbo As ComboBox, ByVal palet As Integer)
        cbo.mam_DataSource("TiposFormatosCboPorPalet " & palet, False)
    End Sub

    Public Sub cargar_TiposFormatosTodos(ByRef cbo As ComboBox, Optional ByVal primeraCelda As String = "")
        If primeraCelda = "" Then
            cbo.mam_DataSource("TiposFormatosCboAll", False)
        Else
            cbo.mam_DataSource("TiposFormatosCboAll", True, primeraCelda)
        End If
    End Sub

    Public Sub cargar_comboByTipoFormatoLinea(ByRef cbo As ComboBox, ByVal formatoLinea As Integer)
        cbo.mam_DataSource("TiposFormatos2SelectByTipoFormatoLineaID_all2 " & formatoLinea, False)
    End Sub

    Public Sub cargar_comboByTipoFormatoLineaYtipoProducto(ByRef cbo As ComboBox, ByVal formatoLinea As Integer, ByVal tipoProducto As Integer)
        cbo.mam_DataSource("TiposFormatos2SelectByTipoFormatoLineaID_tipoProducto " & formatoLinea & ", " & tipoProducto, False)
    End Sub

    Sub cargar_combo_por_TipoFormatoLinea_Producto_marca_palet(ByRef cbo As ComboBox, ByVal formatoLinea As Integer, ByVal tipoProducto As Integer, marca As Integer, palet As Integer)
        cbo.mam_DataSource("TiposFormatos2SelectByTipoFormatoLineaIDTipoProductoIDMarcaIDPaletID " _
                           & formatoLinea & ", " & tipoProducto & ", " & marca & "," & palet, False)
    End Sub

    Public Function seleccionar_ultimo_registro(ByRef dtb as BasesParaCompatibilidad.Database) As Integer
        Return dtb.Consultar("select max(tipoformatoid) from tiposformatos", False).Rows(0).Item(0)
    End Function


End Class
