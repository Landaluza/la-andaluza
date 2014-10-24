

Public Class spAguaPotableAnaliticasOrganolepticas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotableAnaliticasOrganolepticasSelect]",  _
                     "[dbo].[AguaPotableAnaliticasOrganolepticasInsert]",  _
                     "[dbo].[AguaPotableAnaliticasOrganolepticasUpdate]",  _
                     "[dbo].[AguaPotableAnaliticasOrganolepticasDelete]",  _
                     "[dbo].[AguaPotableAnaliticasOrganolepticasSelectDgv]",  _
                     "[dbo].[AguaPotableAnaliticasOrganolepticasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal AnaliticaOrganolepticaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AguaPotableAnaliticasOrganolepticas
        Dim dbo As New DBO_AguaPotableAnaliticasOrganolepticas
        dbo.searchKey = dbo.item("AnaliticaOrganolepticaID")
        dbo.searchKey.value = AnaliticaOrganolepticaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal AnaliticaOrganolepticaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AguaPotableAnaliticasOrganolepticas
        dbo.searchKey = dbo.item("AnaliticaOrganolepticaID")
        dbo.searchKey.value = AnaliticaOrganolepticaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
