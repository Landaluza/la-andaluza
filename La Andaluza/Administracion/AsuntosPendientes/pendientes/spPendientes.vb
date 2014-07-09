
Public Class spPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PendientesSelect]", _
                      "[dbo].[PendientesInsert]", _
                      "[dbo].[PendientesUpdate]", _
                      "[dbo].[PendientesDelete]", _
                      "[dbo].[PendientesSelectDgv]", _
                      "[dbo].[PendientesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal PendienteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Pendientes
       Dim dbo As New DBO_Pendientes
       dbo.searchKey = dbo.item("PendienteID")
       dbo.searchKey.value = PendienteID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PendienteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Pendientes
       dbo.searchKey = dbo.item("PendienteID")
       dbo.searchKey.value = PendienteID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
