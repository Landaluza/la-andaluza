
Public Class spAvisosPedidos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AvisosPedidosSelect]",  _
                     "[dbo].[AvisosPedidosInsert]",  _
                     "[dbo].[AvisosPedidosUpdate]",  _
                     "[dbo].[AvisosPedidosDelete]",  _
                     "[dbo].[AvisosPedidosSelectDgv]",  _
                     "[dbo].[AvisosPedidosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, ByRef  dtb As BasesParaCompatibilidad.DataBase) As DBO_AvisosPedidos
       Dim dbo As New DBO_AvisosPedidos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), dtb)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, ByRef  dtb As BasesParaCompatibilidad.DataBase) As Boolean
       Dim dbo As New DBO_AvisosPedidos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), dtb)
   End Function

End Class
