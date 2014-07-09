

Public Class spDDDAccionesRealizadas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[DDDAccionesRealizadasSelect]",  _
                     "[dbo].[DDDAccionesRealizadasInsert]",  _
                     "[dbo].[DDDAccionesRealizadasUpdate]",  _
                     "[dbo].[DDDAccionesRealizadasDelete]",  _
                     "[dbo].[DDDAccionesRealizadasSelectDgv]",  _
                     "[dbo].[DDDAccionesRealizadasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal DDDAccionRealizadaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_DDDAccionesRealizadas
       Dim dbo As New DBO_DDDAccionesRealizadas
       dbo.searchKey = dbo.item("DDDAccionRealizadaID")
       dbo.searchKey.value = DDDAccionRealizadaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal DDDAccionRealizadaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_DDDAccionesRealizadas
       dbo.searchKey = dbo.item("DDDAccionRealizadaID")
       dbo.searchKey.value = DDDAccionRealizadaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
