

Public Class spAguaPotableAnaliticasAnuales
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotableAnaliticasAnualesSelect]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesInsert]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesUpdate]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesDelete]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesSelectDgv]",  _
                     "[dbo].[AguaPotableAnaliticasAnualesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal AnaliticaAnualID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AguaPotableAnaliticasAnuales
       Dim dbo As New DBO_AguaPotableAnaliticasAnuales
       dbo.searchKey = dbo.item("AnaliticaAnualID")
       dbo.searchKey.value = AnaliticaAnualID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal AnaliticaAnualID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AguaPotableAnaliticasAnuales
       dbo.searchKey = dbo.item("AnaliticaAnualID")
       dbo.searchKey.value = AnaliticaAnualID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
