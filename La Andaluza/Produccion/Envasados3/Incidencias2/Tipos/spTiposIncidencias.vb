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

    Public Overloads Function Select_Record(ByVal TipoIncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposIncidencias
        Dim dbo As New DBO_TiposIncidencias
        dbo.searchKey = dbo.item("TipoIncidenciaID")
        dbo.searchKey.value = TipoIncidenciaID
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoIncidenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_TiposIncidencias
        dbo.searchKey = dbo.item("TipoIncidenciaID")
        dbo.searchKey.value = TipoIncidenciaID
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

    Public Sub cargar_TiposIncidencias(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposIncidenciasCbo", False)
    End Sub

    Public Function devolver_TiposIncidencias() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("TiposIncidenciasCbo", True)
    End Function

    Public Sub cargar_TiposIncidenciasSinIncidenciaCalidad(ByRef cbo As ComboBox, Optional ByVal selecteditem As Integer = Nothing)
        If selecteditem = Nothing Then
            cbo.mam_DataSource("TiposIncidenciasSinAsignarCalidadCbo", False)
        Else
            Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
            Dim dt As DataTable = dtb.Consultar("TiposIncidenciasSinAsignarCalidadCbo", True)
            Dim dbo As DBO_TiposIncidencias = Me.Select_Record(selecteditem)
            dt.Rows.Add(selecteditem, dbo.Descripcion)
        End If
    End Sub

    Public Sub cargar_TiposIncidenciasporCategoria(ByRef cbo As ComboBox, ByVal categoria As Integer)
        cbo.mam_DataSource("_Incidencias2SelectPorCategoriaIncidencia " & categoria, False)
    End Sub

    Public Sub cargar_TiposIncidenciasporMaquina(ByRef cbo As ComboBox, maquina As Integer)
        cbo.mam_DataSource("_Incidencias2SelectTiposIncidenciasPorMaquinaPorCategoriaIncidencia " & maquina & ", 8", False)
    End Sub

    Public Function devolver_TiposIncidenciasporMaquina(maquina As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("_Incidencias2SelectTiposIncidenciasPorMaquinaPorCategoriaIncidencia " & maquina & ", 8", True)
    End Function

    Public Sub _Incidencias2SelectMaquinasPorLinea(ByRef cbo As ComboBox, ByVal linea As Integer)
        cbo.mam_DataSource("_Incidencias2SelectMaquinasPorLinea " & linea, False)
    End Sub

    Function Select_Mas_Usado_Por_Categoria_Y_Linea(ByVal categoria As Integer, ByVal linea As Integer) As Object
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable = dtb.Consultar("_TiposIncidencias2SelectMasUsadoPorCategoriaYlinea " & categoria & "," & linea, False)
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else : Return 0
            End If
        Else : Return 0
        End If
    End Function

    Function Select_Mas_Usado_Por_Maquina_Y_Linea(ByVal maquina As Integer, ByVal linea As Integer) As Object
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)

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
