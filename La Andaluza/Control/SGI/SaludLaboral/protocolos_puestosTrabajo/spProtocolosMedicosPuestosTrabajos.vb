

Public Class spProtocolosMedicosPuestosTrabajos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ProtocolosMedicosPuestosTrabajosSelect]", _
                      "[dbo].[ProtocolosMedicosPuestosTrabajosInsert]", _
                      "[dbo].[ProtocolosMedicosPuestosTrabajosUpdate]", _
                      "[dbo].[ProtocolosMedicosPuestosTrabajosDelete]", _
                      "[dbo].[ProtocolosMedicosPuestosTrabajosSelectDgv]", _
                      "[dbo].[ProtocolosMedicosPuestosTrabajosSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal ProtocoloMedicoPuestoTrabajoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ProtocolosMedicosPuestosTrabajos
       Dim dbo As New DBO_ProtocolosMedicosPuestosTrabajos
       dbo.searchKey = dbo.item("ProtocoloMedicoPuestoTrabajoID")
       dbo.searchKey.value = ProtocoloMedicoPuestoTrabajoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ProtocoloMedicoPuestoTrabajoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ProtocolosMedicosPuestosTrabajos
       dbo.searchKey = dbo.item("ProtocoloMedicoPuestoTrabajoID")
       dbo.searchKey.value = ProtocoloMedicoPuestoTrabajoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
