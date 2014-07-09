
Public Class spArticulosMinMax
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosMinMaxSelect]", _
                      "[dbo].[ArticulosMinMaxInsert]", _
                      "[dbo].[ArticulosMinMaxUpdate]", _
                      "[dbo].[ArticulosMinMaxDelete]", _
                      "[dbo].[ArticulosMinMaxSelectDgv]", _
                      "[dbo].[ArticulosMinMaxSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal ArticuloMinMaxID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ArticulosMinMax
       Dim dbo As New DBO_ArticulosMinMax
       dbo.searchKey = dbo.item("ArticuloMinMaxID")
       dbo.searchKey.value = ArticuloMinMaxID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ArticuloMinMaxID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ArticulosMinMax
       dbo.searchKey = dbo.item("ArticuloMinMaxID")
       dbo.searchKey.value = ArticuloMinMaxID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
