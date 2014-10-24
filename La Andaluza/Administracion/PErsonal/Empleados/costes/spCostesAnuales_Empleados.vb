

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

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_CostesAnuales_Empleados
        Dim dbo As New DBO_CostesAnuales_Empleados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_CostesAnuales_Empleados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
