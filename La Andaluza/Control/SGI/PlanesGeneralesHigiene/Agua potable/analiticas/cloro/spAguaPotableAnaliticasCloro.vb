

Public Class spAguaPotableAnaliticasCloro
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotableAnaliticasCloroSelect]",  _
                     "[dbo].[AguaPotableAnaliticasCloroInsert]",  _
                     "[dbo].[AguaPotableAnaliticasCloroUpdate]",  _
                     "[dbo].[AguaPotableAnaliticasCloroDelete]",  _
                     "[dbo].[AguaPotableAnaliticasCloroSelectDgv]",  _
                     "[dbo].[AguaPotableAnaliticasCloroSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal AnaliticaCloroID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AguaPotableAnaliticasCloro
       Dim dbo As New DBO_AguaPotableAnaliticasCloro
       dbo.searchKey = dbo.item("AnaliticaCloroID")
       dbo.searchKey.value = AnaliticaCloroID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal AnaliticaCloroID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AguaPotableAnaliticasCloro
       dbo.searchKey = dbo.item("AnaliticaCloroID")
       dbo.searchKey.value = AnaliticaCloroID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
