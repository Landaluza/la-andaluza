Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spCausasPartesEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CausasPartesEnvasadoSelect]",  _
                     "[dbo].[CausasPartesEnvasadoInsert]",  _
                     "[dbo].[CausasPartesEnvasadoUpdate]",  _
                     "[dbo].[CausasPartesEnvasadoDelete]",  _
                     "[dbo].[CausasPartesEnvasadoSelectDgv]",  _
                     "[dbo].[CausasPartesEnvasadoSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CausasPartesEnvasado
        Dim dbo As New DBO_CausasPartesEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_CausasPartesEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_CausasPartesEnvasado(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("CausasPartesEnvasadoCbo", False, dtb)
    End Sub

End Class
