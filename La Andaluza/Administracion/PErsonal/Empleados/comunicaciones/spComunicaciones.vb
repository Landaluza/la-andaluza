
Public Class spComunicaciones
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ComunicacionesSelect]", _
                      "[dbo].[ComunicacionesInsert]", _
                      "[dbo].[ComunicacionesUpdate]", _
                      "[dbo].[ComunicacionesDelete]", _
                      "[dbo].[ComunicacionesSelectDgv]", _
                      "[dbo].[ComunicacionesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Comunicaciones
       Dim dbo As New DBO_Comunicaciones
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Comunicaciones
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
