Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposFormatosLineas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposFormatosLineasSelect]",  _
                     "[dbo].[TiposFormatosLineasInsert]",  _
                     "[dbo].[TiposFormatosLineasUpdate]",  _
                     "[dbo].[TiposFormatosLineasDelete]",  _
                     "[dbo].[TiposFormatosLineasSelectDgv]",  _
                     "[dbo].[TiposFormatosLineasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal TipoFormatoLineaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposFormatosLineas
        Dim dbo As New DBO_TiposFormatosLineas
        dbo.searchKey = dbo.item("TipoFormatoLineaID")
        dbo.searchKey.value = TipoFormatoLineaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoFormatoLineaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposFormatosLineas
        dbo.searchKey = dbo.item("TipoFormatoLineaID")
        dbo.searchKey.value = TipoFormatoLineaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposFormatosLineas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposFormatosLineasCbo", False, dtb)
    End Sub

    Public Sub cargar_TiposFormatosLineas_por_linea_envasado(ByRef cbo As ComboBox, linea As String, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposFormatosLineasSelectByLineaEnvasadoID " & linea, False, dtb)
    End Sub

    Public Sub cargar_TiposFormatosLineas_por_linea_envasado_tipoProducto(ByRef cbo As ComboBox, linea As Integer, tipoProducto As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposFormatosLineasSelectByLineaEnvasadoIDTipoProductoID " & linea & "," & tipoProducto, False, dtb)
    End Sub
End Class
