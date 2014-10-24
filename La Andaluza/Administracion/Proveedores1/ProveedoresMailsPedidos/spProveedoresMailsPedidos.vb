
Public Class spProveedoresMailsPedidos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProveedoresMailsPedidosSelect]",  _
                     "[dbo].[ProveedoresMailsPedidosInsert]",  _
                     "[dbo].[ProveedoresMailsPedidosUpdate]",  _
                     "[dbo].[ProveedoresMailsPedidosDelete]",  _
                     "[dbo].[ProveedoresMailsPedidosSelectDgv]",  _
                     "[dbo].[ProveedoresMailsPedidosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ProveedorMailPedidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ProveedoresMailsPedidos
        Dim dbo As New DBO_ProveedoresMailsPedidos
        dbo.searchKey = dbo.item("ProveedorMailPedidoID")
        dbo.searchKey.value = ProveedorMailPedidoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ProveedorMailPedidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ProveedoresMailsPedidos
        dbo.searchKey = dbo.item("ProveedorMailPedidoID")
        dbo.searchKey.value = ProveedorMailPedidoID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
