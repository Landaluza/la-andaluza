
Public Class spEnvasadosProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[EnvasadosProductosSelect]",  _
                     "[dbo].[EnvasadosProductosInsert]",  _
                     "[dbo].[EnvasadosProductosUpdate]",  _
                     "[dbo].[EnvasadosProductosDelete]",  _
                     "[dbo].[EnvasadosProductosSelectDgv]",  _
                     "[dbo].[EnvasadosProductosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal EnvasadoProductoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_EnvasadosProductos
        Dim dbo As New DBO_EnvasadosProductos
        dbo.searchKey = dbo.item("EnvasadoProductoID")
        dbo.searchKey.value = EnvasadoProductoID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal EnvasadoProductoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_EnvasadosProductos
        dbo.searchKey = dbo.item("EnvasadoProductoID")
        dbo.searchKey.value = EnvasadoProductoID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
