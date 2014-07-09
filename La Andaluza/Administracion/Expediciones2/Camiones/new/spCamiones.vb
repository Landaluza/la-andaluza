
Public Class spCamiones
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[CamionesSelect]", _
                      "[dbo].[CamionesInsert]", _
                      "[dbo].[CamionesUpdate]", _
                      "[dbo].[CamionesDelete]", _
                      "[dbo].[CamionesSelectDgv]", _
                      "[dbo].[CamionesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal CamionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Camiones
       Dim dbo As New DBO_Camiones
       dbo.searchKey = dbo.item("CamionID")
       dbo.searchKey.value = CamionID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal CamionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Camiones
       dbo.searchKey = dbo.item("CamionID")
       dbo.searchKey.value = CamionID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
