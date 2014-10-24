Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spCausasPartesEnvasadoTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CausasPartesEnvasadoTiposSelect]",  _
                     "[dbo].[CausasPartesEnvasadoTiposInsert]",  _
                     "[dbo].[CausasPartesEnvasadoTiposUpdate]",  _
                     "[dbo].[CausasPartesEnvasadoTiposDelete]",  _
                     "[dbo].[CausasPartesEnvasadoTiposSelectDgv]",  _
                     "[dbo].[CausasPartesEnvasadoTiposSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CausasPartesEnvasadoTipos
        Dim dbo As New DBO_CausasPartesEnvasadoTipos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_CausasPartesEnvasadoTipos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_CausasPartesEnvasadoTipos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("CausasPartesEnvasadoTiposCbo", False, dtb)
    End Sub

End Class
