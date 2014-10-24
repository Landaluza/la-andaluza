Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPaises
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PaisesSelect]", "[dbo].[PaisesInsert]", "[dbo].[PaisesUpdate]", "[dbo].[PaisesDelete]", "[dbo].[PaisesSelectDgv]", "[dbo].[PaisesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal PaisID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Paises
        Dim dbo As New DBO_Paises
        dbo.searchKey = dbo.item("PaisID")
        dbo.searchKey.value = PaisID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PaisID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Paises
        dbo.searchKey = dbo.item("PaisID")
        dbo.searchKey.value = PaisID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PaisesCbo", False, dtb)
    End Sub

End Class
