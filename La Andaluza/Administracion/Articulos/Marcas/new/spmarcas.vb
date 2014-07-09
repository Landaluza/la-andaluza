Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spmarcas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[marcasSelect]", _
                      "[dbo].[marcasInsert]", _
                      "[dbo].[marcasUpdate]", _
                      "[dbo].[marcasDelete]", _
                      "[dbo].[marcasSelectDgv]", _
                      "[dbo].[marcasSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_marcas
       Dim dbo As New DBO_marcas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_marcas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_marcas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("marcasCbo", False)
   End Sub

End Class
