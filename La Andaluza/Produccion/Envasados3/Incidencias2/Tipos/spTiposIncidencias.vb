Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposIncidencias
Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposIncidenciasSelect]", _
                        "[dbo].[TiposIncidenciasInsert]", _
                        "[dbo].[TiposIncidenciasUpdate]", _
                        "[dbo].[TiposIncidenciasDelete]", _
                        "[dbo].[TiposIncidenciasSelectDgv]", _
                        "[dbo].[TiposIncidenciasSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal TipoIncidenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposIncidencias
        Dim dbo As New DBO_TiposIncidencias
        dbo.searchKey = dbo.item("TipoIncidenciaID")
        dbo.searchKey.value = TipoIncidenciaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoIncidenciaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposIncidencias
        dbo.searchKey = dbo.item("TipoIncidenciaID")
        dbo.searchKey.value = TipoIncidenciaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposIncidencias(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposIncidenciasCbo", False, dtb)
    End Sub

    Public Function devolver_TiposIncidencias(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("TiposIncidenciasCbo")
        Return dtb.Consultar()
    End Function

    Public Sub cargar_TiposIncidenciasSinIncidenciaCalidad(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal selecteditem As Integer = Nothing)
        If selecteditem = Nothing Then
            cbo.mam_DataSource("TiposIncidenciasSinAsignarCalidadCbo", False, dtb)
        Else
            dtb.PrepararConsulta("TiposIncidenciasSinAsignarCalidadCbo")
            Dim dt As DataTable = dtb.Consultar()
            Dim dbo As DBO_TiposIncidencias = Me.Select_Record(selecteditem, dtb)
            dt.Rows.Add(selecteditem, dbo.Descripcion)
        End If
    End Sub

    Public Sub cargar_TiposIncidenciasporCategoria(ByRef cbo As ComboBox, ByVal categoria As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("_Incidencias2SelectPorCategoriaIncidencia " & categoria, False, dtb)
    End Sub

    Public Sub cargar_TiposIncidenciasporMaquina(ByRef cbo As ComboBox, maquina As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("_Incidencias2SelectTiposIncidenciasPorMaquinaPorCategoriaIncidencia " & maquina & ", 8", False, dtb)
    End Sub

    Public Function devolver_TiposIncidenciasporMaquina(maquina As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("_Incidencias2SelectTiposIncidenciasPorMaquinaPorCategoriaIncidencia @maq, @tip")
        dtb.AñadirParametroConsulta("@maq", maquina)
        dtb.AñadirParametroConsulta("@tip", 8)
        Return dtb.Consultar()
    End Function

    Public Sub _Incidencias2SelectMaquinasPorLinea(ByRef cbo As ComboBox, ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("_Incidencias2SelectMaquinasPorLinea " & linea, False, dtb)
    End Sub

    Function Select_Mas_Usado_Por_Categoria_Y_Linea(ByVal categoria As Integer, ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Object
        dtb.PrepararConsulta("_TiposIncidencias2SelectMasUsadoPorCategoriaYlinea @cat, @lin")
        dtb.AñadirParametroConsulta("@cat", categoria)
        dtb.AñadirParametroConsulta("@lin", linea)
        Dim dt As DataTable = dtb.Consultar()
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else : Return 0
            End If
        Else : Return 0
        End If
    End Function

    Function Select_Mas_Usado_Por_Maquina_Y_Linea(ByVal maquina As Integer, ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Object

        dtb.PrepararConsulta("_TiposIncidencias2SelectMasUsadoPorMaquinaYlinea @maq, @linea")
        dtb.AñadirParametroConsulta("@maq", maquina)
        dtb.AñadirParametroConsulta("@linea", linea)
        Dim dt As DataTable = dtb.Consultar()
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else : Return 0
            End If
        Else : Return 0
        End If
    End Function

End Class
