
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

    Public Overloads Function Select_Record(ByVal ProveedorIDArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PeriodosServicio
        Dim dbo As New DBO_PeriodosServicio
        dbo.searchKey = dbo.item("ProveedorIDArticuloID")
        dbo.searchKey.value = ProveedorIDArticuloID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ProveedorIDArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PeriodosServicio
        dbo.searchKey = dbo.item("ProveedorIDArticuloID")
        dbo.searchKey.value = ProveedorIDArticuloID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
