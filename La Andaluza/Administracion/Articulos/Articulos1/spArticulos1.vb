Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spArticulos1
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public ReadOnly Property DatagridViewProcedureForSelectInactivos As String
        Get
            Return "[Articulos1SelectDgv2_inactivos]"
        End Get
    End Property
    Public Sub New()
        MyBase.New("[dbo].[Articulos1Select]", _
                      "[dbo].[Articulos1Insert]", _
                      "[dbo].[Articulos1Update]", _
                      "[dbo].[Articulos1Delete]", _
                      "[dbo].[Articulos1SelectDgv2]", _
                      "[dbo].[Articulos1SelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal ArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Articulos1
        Dim dbo As New DBO_Articulos1
        dbo.searchKey = dbo.item("ArticuloID")
        dbo.searchKey.value = ArticuloID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Articulos1
        dbo.searchKey = dbo.item("ArticuloID")
        dbo.searchKey.value = ArticuloID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Articulos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("Articulos1Cbo")
        cbo.mam_DataSource(dtb.Consultar, False)
    End Sub

    Public Sub cargar_Articulos_Por_Tipo(ByRef cbo As ComboBox, ByVal tipo As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("Articulos1CboByTipo @id")
        dtb.AñadirParametroConsulta("@id", tipo)
        cbo.mam_DataSource(dtb.Consultar, False)
    End Sub


    Public Function certificadosByArticuloId(ByVal articuloID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("Articulos_certificadosSelect @id")
        dtb.AñadirParametroConsulta("@id", articuloID)

        Return dtb.Consultar
    End Function

    Public Function comprobarCambioTipo(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("select count(*) from (select articuloid from articulosEnvasesterciarios union select articuloid from ArticulosEnvasesSecundarios union select articuloid from ArticulosGraneles union select articuloid from ArticulosIngredientes union select articuloid from ArticulosIngredientesIDI union select articuloid from ArticulosMateriasPrimas union select id_articulo as articulid from ArticulosPrimarios) as x where x.articuloid = @id")
        dtb.AñadirParametroConsulta("@id", id)
        Dim dt As DataTable = dtb.Consultar

        Try
            If Convert.ToInt32(dt.Rows(0).Item(0)) = 0 Then
                Return True
            End If
        Catch ex As Exception
        End Try

        Return False
    End Function
End Class
