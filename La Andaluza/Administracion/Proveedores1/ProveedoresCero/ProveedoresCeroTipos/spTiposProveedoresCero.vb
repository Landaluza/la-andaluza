Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposProveedoresCero
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposProveedoresCeroSelect]", "[dbo].[TiposProveedoresCeroInsert]", "[dbo].[TiposProveedoresCeroUpdate]", "[dbo].[TiposProveedoresCeroDelete]", "[dbo].[TiposProveedoresCeroSelectDgv]", "[dbo].[TiposProveedoresCeroSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposProveedoresCero
       Dim dbo As New DBO_TiposProveedoresCero
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TiposProveedoresCero
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ComboBox(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposProveedoresCeroCbo", False)
   End Sub

End Class
