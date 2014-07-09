

Public Class spEmpleados_competencias
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[Empleados_competenciasSelect]", _
                      "[dbo].[Empleados_competenciasInsert]", _
                      "[dbo].[Empleados_competenciasUpdate]", _
                      "[dbo].[Empleados_competenciasDelete]", _
                      "[dbo].[Empleados_competenciasSelectDgv]", _
                      "[dbo].[Empleados_competenciasSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Empleados_competencias
       Dim dbo As New DBO_Empleados_competencias
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Empleados_competencias
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
