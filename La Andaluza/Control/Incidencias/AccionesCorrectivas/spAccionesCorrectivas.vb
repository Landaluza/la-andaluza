Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spAccionesCorrectivas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AccionesCorrectivasSelect]",  _
                     "[dbo].[AccionesCorrectivasInsert]",  _
                     "[dbo].[AccionesCorrectivasUpdate]",  _
                     "[dbo].[AccionesCorrectivasDelete]",  _
                     "[dbo].[AccionesCorrectivasSelectDgv]",  _
                     "[dbo].[AccionesCorrectivasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AccionesCorrectivas
        Dim dbo As New DBO_AccionesCorrectivas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AccionesCorrectivas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_AccionesCorrectivas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("AccionesCorrectivasCbo", False, dtb)
    End Sub

End Class
