
Public Class spGestionesPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[GestionesPendientesSelect]", _
                      "[dbo].[GestionesPendientesInsert]", _
                      "[dbo].[GestionesPendientesUpdate]", _
                      "[dbo].[GestionesPendientesDelete]", _
                      "[dbo].[GestionesPendientesSelectDgv]", _
                      "[dbo].[GestionesPendientesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal GestionPendienteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_GestionesPendientes
       Dim dbo As New DBO_GestionesPendientes
       dbo.searchKey = dbo.item("GestionPendienteID")
       dbo.searchKey.value = GestionPendienteID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal GestionPendienteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_GestionesPendientes
       dbo.searchKey = dbo.item("GestionPendienteID")
       dbo.searchKey.value = GestionPendienteID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
