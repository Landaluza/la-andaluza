Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spDDDPersonasAutorizadas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[DDDPersonasAutorizadasSelect]",  _
                     "[dbo].[DDDPersonasAutorizadasInsert]",  _
                     "[dbo].[DDDPersonasAutorizadasUpdate]",  _
                     "[dbo].[DDDPersonasAutorizadasDelete]",  _
                     "[dbo].[DDDPersonasAutorizadasSelectDgv]",  _
                     "[dbo].[DDDPersonasAutorizadasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal PersonaAutorizadaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_DDDPersonasAutorizadas
        Dim dbo As New DBO_DDDPersonasAutorizadas
        dbo.searchKey = dbo.item("PersonaAutorizadaID")
        dbo.searchKey.value = PersonaAutorizadaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PersonaAutorizadaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_DDDPersonasAutorizadas
        dbo.searchKey = dbo.item("PersonaAutorizadaID")
        dbo.searchKey.value = PersonaAutorizadaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_DDDPersonasAutorizadas(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("[DDDPersonasAutorizadasCbo]", False, dtb)
    End Sub

End Class
