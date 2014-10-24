Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spempresas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[empresasSelect]", "[dbo].[empresasInsert]", "[dbo].[empresasUpdate]", "[dbo].[empresasDelete]", "[dbo].[empresasSelectDgv]", "[dbo].[empresasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_empresas
        Dim dbo As New DBO_empresas
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_empresas
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("empresasSelectCbo", False, dtb)
    End Sub

End Class
