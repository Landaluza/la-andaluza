Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spProvincias
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProvinciasSelect]", "[dbo].[ProvinciasInsert]", "[dbo].[ProvinciasUpdate]", "[dbo].[ProvinciasDelete]", "[dbo].[ProvinciasSelectDgv]", "[dbo].[ProvinciasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Provincias
        Dim dbo As New DBO_Provincias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Provincias
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByVal idpais As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ProvinciasCboByPais " & idpais, False, dtb)
    End Sub

End Class
