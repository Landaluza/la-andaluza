
Public Class spTiposProductos_ClasesProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposProductos_ClasesProductosSelect]",  _
                     "[dbo].[TiposProductos_ClasesProductosInsert]",  _
                     "[dbo].[TiposProductos_ClasesProductosUpdate]",  _
                     "[dbo].[TiposProductos_ClasesProductosDelete]",  _
                     "[dbo].[TiposProductos_ClasesProductosSelectDgv]",  _
                     "[dbo].[TiposProductos_ClasesProductosSelectDgvBy]")
   End Sub

    Public ReadOnly Property SelectDgvByProducto As String
        Get
            Return "[TiposProductos_ClasesProductosSelectDgvByProducto]"
        End Get
    End Property
   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposProductos_ClasesProductos
       Dim dbo As New DBO_TiposProductos_ClasesProductos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposProductos_ClasesProductos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

End Class
