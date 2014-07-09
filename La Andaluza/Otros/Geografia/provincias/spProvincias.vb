Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spProvincias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProvinciasSelect]", "[dbo].[ProvinciasInsert]", "[dbo].[ProvinciasUpdate]", "[dbo].[ProvinciasDelete]", "[dbo].[ProvinciasSelectDgv]", "[dbo].[ProvinciasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Provincias
       Dim dbo As New DBO_Provincias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Provincias
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByVal idpais As Integer)
        cbo.mam_DataSource("ProvinciasCboByPais " & idpais, False)
    End Sub

End Class
