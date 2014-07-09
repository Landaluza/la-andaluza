
Public Class spPeriodosServicio
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PeriodosServicioSelect]",  _
                     "[dbo].[PeriodosServicioInsert]",  _
                     "[dbo].[PeriodosServicioUpdate]",  _
                     "[dbo].[PeriodosServicioDelete]",  _
                     "[dbo].[PeriodosServicioSelectDgv]",  _
                     "[dbo].[PeriodosServicioSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ProveedorIDArticuloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PeriodosServicio
       Dim dbo As New DBO_PeriodosServicio
       dbo.searchKey = dbo.item("ProveedorIDArticuloID")
       dbo.searchKey.value = ProveedorIDArticuloID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ProveedorIDArticuloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_PeriodosServicio
       dbo.searchKey = dbo.item("ProveedorIDArticuloID")
       dbo.searchKey.value = ProveedorIDArticuloID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
