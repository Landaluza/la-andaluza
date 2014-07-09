
Public Class spDetallesGestionesPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[DetallesGestionesPendientesSelect]", _
                      "[dbo].[DetallesGestionesPendientesInsert]", _
                      "[dbo].[DetallesGestionesPendientesUpdate]", _
                      "[dbo].[DetallesGestionesPendientesDelete]", _
                      "[dbo].[DetallesGestionesPendientesSelectDgv]", _
                      "[dbo].[DetallesGestionesPendientesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal DetalleGestionPendienteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_DetallesGestionesPendientes
       Dim dbo As New DBO_DetallesGestionesPendientes
       dbo.searchKey = dbo.item("DetalleGestionPendienteID")
       dbo.searchKey.value = DetalleGestionPendienteID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal DetalleGestionPendienteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_DetallesGestionesPendientes
       dbo.searchKey = dbo.item("DetalleGestionPendienteID")
       dbo.searchKey.value = DetalleGestionPendienteID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
