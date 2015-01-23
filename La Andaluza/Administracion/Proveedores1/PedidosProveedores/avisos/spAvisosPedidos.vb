Imports BasesParaCompatibilidad.ComboBoxExtension


Namespace Proveedores
    Public Class spAvisosPedidos
        Inherits BasesParaCompatibilidad.StoredProcedure

        Public Sub New()
            MyBase.New("[dbo].[AvisosPedidosSelect]", _
                          "[dbo].[AvisosPedidosInsert]", _
                          "[dbo].[AvisosPedidosUpdate]", _
                          "[dbo].[AvisosPedidosDelete]", _
                          "[dbo].[AvisosPedidosSelectDgv]", _
                          "[dbo].[AvisosPedidosSelectDgvBy]")
        End Sub

        Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AvisosPedidos
            Dim dbo As New DBO_AvisosPedidos
            dbo.searchKey = dbo.item("Id")
            dbo.searchKey.value = Id
            MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
            Return dbo
        End Function

        Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
            Dim dbo As New DBO_AvisosPedidos
            dbo.searchKey = dbo.item("Id")
            dbo.searchKey.value = Id
            Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
        End Function

        Public Sub cargar_articulos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
            dtb.PrepararConsulta("select articuloid, descripcionla from articulos1 order by descripcionla")
            cbo.mam_DataSource(dtb.Consultar, False)
        End Sub

        Public Sub cargar_proveedores(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
            dtb.PrepararConsulta("select proveedorid, nombre from proveedores order by nombre")
            cbo.mam_DataSource(dtb.Consultar, False)
        End Sub

        Public Function comprobarAvisosNoLeidosPorArticulo(ByVal articulo As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
            dtb.PrepararConsulta("select count(*) from avisospedidos where leido = 0 and id_articulo = @id")
            dtb.AñadirParametroConsulta("@id", articulo)
            Return If(dtb.Consultar().Rows(0).Item(0) > 0, True, False)
        End Function
    End Class

End Namespace