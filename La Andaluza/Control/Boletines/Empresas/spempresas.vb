Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spempresas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[empresasSelect]", "[dbo].[empresasInsert]", "[dbo].[empresasUpdate]", "[dbo].[empresasDelete]", "[dbo].[empresasSelectDgv]", "[dbo].[empresasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_empresas
       Dim dbo As New DBO_empresas
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_empresas
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ComboBox(ByRef cbo As ComboBox)
       cbo.mam_DataSource("empresasSelectCbo", False)
   End Sub

End Class
