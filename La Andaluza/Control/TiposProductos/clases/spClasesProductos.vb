Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spClasesProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ClasesProductosSelect]",  _
                     "[dbo].[ClasesProductosInsert]",  _
                     "[dbo].[ClasesProductosUpdate]",  _
                     "[dbo].[ClasesProductosDelete]",  _
                     "[dbo].[ClasesProductosSelectDgv]",  _
                     "[dbo].[ClasesProductosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ClasesProductos
       Dim dbo As New DBO_ClasesProductos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ClasesProductos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

   Public Sub cargar_ClasesProductos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ClasesProductosCbo", False)
   End Sub

End Class
