Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spCausas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CausasSelect]",  _
                     "[dbo].[CausasInsert]",  _
                     "[dbo].[CausasUpdate]",  _
                     "[dbo].[CausasDelete]",  _
                     "[dbo].[CausasSelectDgv]",  _
                     "[dbo].[CausasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Causas
        Dim dbo As New DBO_Causas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Causas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_Causas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("CausasCbo", False, dtb)
    End Sub

End Class
