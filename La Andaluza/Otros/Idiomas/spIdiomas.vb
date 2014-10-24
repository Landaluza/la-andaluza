Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spIdiomas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[IdiomasSelect]",  _
                     "[dbo].[IdiomasInsert]",  _
                     "[dbo].[IdiomasUpdate]",  _
                     "[dbo].[IdiomasDelete]",  _
                     "[dbo].[IdiomasSelectDgv]",  _
                     "[dbo].[IdiomasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal IdiomaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Idiomas
        Dim dbo As New DBO_Idiomas
        dbo.searchKey = dbo.item("IdiomaID")
        dbo.searchKey.value = IdiomaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal IdiomaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Idiomas
        dbo.searchKey = dbo.item("IdiomaID")
        dbo.searchKey.value = IdiomaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Idiomas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("IdiomasCbo", False, dtb)
    End Sub

End Class
