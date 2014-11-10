Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposFormatosLineas_TiposFormatos
Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposFormatosLineas_TiposFormatosSelect]", _
                        "[dbo].[TiposFormatosLineas_TiposFormatosInsert]", _
                        "[dbo].[TiposFormatosLineas_TiposFormatosUpdate]", _
                        "[dbo].[TiposFormatosLineas_TiposFormatosDelete]", _
                        "[dbo].[TiposFormatosLineas_TiposFormatosSelectDgv]", _
                        "[dbo].[TiposFormatosLineas_TiposFormatosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposFormatosLineas_TiposFormatos
        Dim dbo As New DBO_TiposFormatosLineas_TiposFormatos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overloads Function Select_Id_By(ByVal foramtoLinea As Int32, ByVal tipoFormato As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        dtb.PrepararConsulta("select id from TiposFormatosLineas_TiposFormatos where TipoformatoLineaId = @linea and TipoFOrmatoID = @formato")
        dtb.AñadirParametroConsulta("@linea", foramtoLinea)
        dtb.AñadirParametroConsulta("@formato", tipoFormato)
        Return dtb.Consultar().Rows(0).Item(0)        
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposFormatosLineas_TiposFormatos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargarCombo_por_linea(ByRef comboBox As ComboBox, p2 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("TiposFormatosLineasCboByLineaEnvasado " & p2, False, dtb)
    End Sub

    Public Function modificar_velocidad(ByRef dtb as BasesParaCompatibilidad.Database, ByVal id As Integer, ByVal velocidad As Integer) As Boolean
        dtb.PrepararConsulta("update tiposformatoslineas_tiposformatos set velocidad= @vel where id= @id")
        dtb.AñadirParametroConsulta("@vel", velocidad)
        dtb.AñadirParametroConsulta("@id", id)

        Return dtb.Execute
    End Function

    Public Function modificar_personal(ByRef dtb as BasesParaCompatibilidad.Database, ByVal id As Integer, ByVal personal As Integer) As Boolean
        dtb.PrepararConsulta("update tiposformatoslineas_tiposformatos set personalrecomendado= @per where id= @id")
        dtb.AñadirParametroConsulta("@per", personal)
        dtb.AñadirParametroConsulta("@id", id)

        Return dtb.Execute
    End Function

    Public Function modificar_personal_y_velocidad(ByRef dtb as BasesParaCompatibilidad.Database, ByVal id As Integer, ByVal personal As Integer, ByVal velocidad As Integer) As Boolean
        dtb.PrepararConsulta("update tiposformatoslineas_tiposformatos set personalrecomendado= @per, velocidad= @vel  where id = @id")
        dtb.AñadirParametroConsulta("@per", personal)
        dtb.AñadirParametroConsulta("@vel", velocidad)
        dtb.AñadirParametroConsulta("@id", id)
        Return dtb.Execute
    End Function
End Class
