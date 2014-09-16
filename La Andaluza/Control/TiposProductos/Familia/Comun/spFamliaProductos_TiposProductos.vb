
Public Class spFamliaProductos_TiposProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FamliaProductos_TiposProductosSelect]",  _
                     "[dbo].[FamliaProductos_TiposProductosInsert]",  _
                     "[dbo].[FamliaProductos_TiposProductosUpdate]",  _
                     "[dbo].[FamliaProductos_TiposProductosDelete]",  _
                     "[dbo].[FamliaProductos_TiposProductosSelectDgv]",  _
                     "[dbo].[FamliaProductos_TiposProductosSelectDgvBy]")
    End Sub

    Public Sub New(ByVal stub As Boolean)
        MyBase.New("[dbo].[FamliaProductos_TiposProductosSelect]", _
                     "[dbo].[FamliaProductos_TiposProductosInsert]", _
                     "[dbo].[FamliaProductos_TiposProductosUpdate]", _
                     "[dbo].[FamliaProductos_TiposProductosDelete]", _
                     "[dbo].[FamliaProductos_TiposProductosSelectDgv]", _
                      "[dbo].[detallePorFamiliaSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_FamliaProductos_TiposProductos
       Dim dbo As New DBO_FamliaProductos_TiposProductos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_FamliaProductos_TiposProductos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

End Class
