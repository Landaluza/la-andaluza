Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spFamiliaProducto
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FamiliaProductoSelect]",  _
                     "[dbo].[FamiliaProductoInsert]",  _
                     "[dbo].[FamiliaProductoUpdate]",  _
                     "[dbo].[FamiliaProductoDelete]",  _
                     "[dbo].[FamiliaProductoSelectDgv]",  _
                     "[dbo].[FamiliaProductoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_FamiliaProducto
       Dim dbo As New DBO_FamiliaProducto
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_FamiliaProducto
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

   Public Sub cargar_FamiliaProducto(ByRef cbo As ComboBox)
       cbo.mam_DataSource("FamiliaProductoCbo", False)
   End Sub

End Class
