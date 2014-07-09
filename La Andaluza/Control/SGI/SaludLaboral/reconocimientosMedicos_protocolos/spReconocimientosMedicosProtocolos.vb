

Public Class spReconocimientosMedicosProtocolos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ReconocimientosMedicosProtocolosSelect]",  _
                     "[dbo].[ReconocimientosMedicosProtocolosInsert]",  _
                     "[dbo].[ReconocimientosMedicosProtocolosUpdate]",  _
                     "[dbo].[ReconocimientosMedicosProtocolosDelete]",  _
                     "[dbo].[ReconocimientosMedicosProtocolosSelectDgv]",  _
                     "[dbo].[ReconocimientosMedicosProtocolosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ReconocimientoMedicoProtocoloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ReconocimientosMedicosProtocolos
       Dim dbo As New DBO_ReconocimientosMedicosProtocolos
       dbo.searchKey = dbo.item("ReconocimientoMedicoProtocoloID")
       dbo.searchKey.value = ReconocimientoMedicoProtocoloID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ReconocimientoMedicoProtocoloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ReconocimientosMedicosProtocolos
       dbo.searchKey = dbo.item("ReconocimientoMedicoProtocoloID")
       dbo.searchKey.value = ReconocimientoMedicoProtocoloID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
