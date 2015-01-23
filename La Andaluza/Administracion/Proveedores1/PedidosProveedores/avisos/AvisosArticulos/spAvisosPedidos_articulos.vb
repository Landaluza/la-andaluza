Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class spAvisosPedidos_articulos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
        MyBase.New("[dbo].[AvisosPedidosSelect]", _
                      "[dbo].[AvisosPedidosInsert]", _
                      "[dbo].[AvisosPedidosUpdate]", _
                      "[dbo].[AvisosPedidosDelete]", _
                      "", _
                      "[dbo].[AvisosPedidos_articulosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Proveedores.DBO_AvisosPedidos_articulos
        Dim dbo As New Proveedores.DBO_AvisosPedidos_articulos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.DataBussines), dtb)
        Return dbo
    End Function

   Public Overrides Function Delete(ByVal Id As Integer, ByRef  dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New Proveedores.DBO_AvisosPedidos_articulos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), dtb)
   End Function

    Public Sub cargar_proveedores(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select proveedorid, nombre from proveedores order by nombre")
        cbo.mam_DataSource(dtb.Consultar, False)
    End Sub
End Class
