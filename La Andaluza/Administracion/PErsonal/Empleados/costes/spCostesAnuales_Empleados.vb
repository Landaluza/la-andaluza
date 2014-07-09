

Public Class spCostesAnuales_Empleados
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[CostesAnuales_EmpleadosSelect]", _
                      "[dbo].[CostesAnuales_EmpleadosInsert]", _
                      "[dbo].[CostesAnuales_EmpleadosUpdate]", _
                      "[dbo].[CostesAnuales_EmpleadosDelete]", _
                      "[dbo].[CostesAnuales_EmpleadosSelectDgv]", _
                      "[dbo].[CostesAnuales_EmpleadosSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_CostesAnuales_Empleados
       Dim dbo As New DBO_CostesAnuales_Empleados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_CostesAnuales_Empleados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
