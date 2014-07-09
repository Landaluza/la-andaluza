

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

   Public Overloads Function Select_Record(ByVal AnaliticaOrganolepticaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AguaPotableAnaliticasOrganolepticas
       Dim dbo As New DBO_AguaPotableAnaliticasOrganolepticas
       dbo.searchKey = dbo.item("AnaliticaOrganolepticaID")
       dbo.searchKey.value = AnaliticaOrganolepticaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal AnaliticaOrganolepticaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AguaPotableAnaliticasOrganolepticas
       dbo.searchKey = dbo.item("AnaliticaOrganolepticaID")
       dbo.searchKey.value = AnaliticaOrganolepticaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
