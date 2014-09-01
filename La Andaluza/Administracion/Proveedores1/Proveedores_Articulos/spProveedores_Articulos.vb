

Public Class spProveedores_Articulos
Inherits BasesParaCompatibilidad.StoredProcedure


    Public Sub New(ByVal procedure2 As Boolean)
        MyBase.New("[dbo].[Proveedores_ArticulosSelect]", _
                        "[dbo].[Proveedores_ArticulosInsert]", _
                        "[dbo].[Proveedores_ArticulosUpdate]", _
                        "[dbo].[Proveedores_ArticulosDelete]", _
                        "[dbo].[Proveedores_ArticulosSelectDgv]", _
                        If(procedure2, "Proveedores_ArticulosSelectDgvByArticulo", "[dbo].[Proveedores_ArticulosSelectDgvBy]"))
    End Sub

    Public Overloads Function Select_Record(ByVal ProveedorArticuloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Proveedores_Articulos
        Dim dbo As New DBO_Proveedores_Articulos
        dbo.searchKey = dbo.item("ProveedorArticuloID")
        dbo.searchKey.value = ProveedorArticuloID
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ProveedorArticuloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_Proveedores_Articulos
        dbo.searchKey = dbo.item("ProveedorArticuloID")
        dbo.searchKey.value = ProveedorArticuloID
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

    Public Function SelectDgvByArticulo(ByVal articulo As Integer) As DataTable
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("[dbo].[Proveedores_ArticulosSelectDgvByArticulo] @id")
        dtb.AñadirParametroConsulta("@id", articulo)
        Return dtb.Consultar
    End Function
End Class
