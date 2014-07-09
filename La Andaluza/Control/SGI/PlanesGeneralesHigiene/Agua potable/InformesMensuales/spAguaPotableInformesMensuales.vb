

Public Class spAguaPotableInformesMensuales
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotableInformesMensualesSelect]",  _
                     "[dbo].[AguaPotableInformesMensualesInsert]",  _
                     "[dbo].[AguaPotableInformesMensualesUpdate]",  _
                     "[dbo].[AguaPotableInformesMensualesDelete]",  _
                     "[dbo].[AguaPotableInformesMensualesSelectDgv]",  _
                     "[dbo].[AguaPotableInformesMensualesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal InformeMensualID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AguaPotableInformesMensuales
       Dim dbo As New DBO_AguaPotableInformesMensuales
       dbo.searchKey = dbo.item("InformeMensualID")
       dbo.searchKey.value = InformeMensualID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal InformeMensualID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AguaPotableInformesMensuales
       dbo.searchKey = dbo.item("InformeMensualID")
       dbo.searchKey.value = InformeMensualID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
