Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPedidosProveedoresEstados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PedidosProveedoresEstadosSelect]",  _
                     "[dbo].[PedidosProveedoresEstadosInsert]",  _
                     "[dbo].[PedidosProveedoresEstadosUpdate]",  _
                     "[dbo].[PedidosProveedoresEstadosDelete]",  _
                     "[dbo].[PedidosProveedoresEstadosSelectDgv]",  _
                     "[dbo].[PedidosProveedoresEstadosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal PedidoProveedorEstadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PedidosProveedoresEstados
        Dim dbo As New DBO_PedidosProveedoresEstados
        dbo.searchKey = dbo.item("PedidoProveedorEstadoID")
        dbo.searchKey.value = PedidoProveedorEstadoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PedidoProveedorEstadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PedidosProveedoresEstados
        dbo.searchKey = dbo.item("PedidoProveedorEstadoID")
        dbo.searchKey.value = PedidoProveedorEstadoID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_PedidosProveedoresEstados(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PedidosProveedoresEstadosCbo", False, dtb)
    End Sub

End Class
