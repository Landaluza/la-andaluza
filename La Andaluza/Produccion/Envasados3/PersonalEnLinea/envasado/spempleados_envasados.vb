

Public Class spempleados_envasados
    Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[empleados_envasadosSelect]",  _
                     "[dbo].[empleados_envasadosInsert]",  _
                     "[dbo].[empleados_envasadosUpdate]",  _
                     "[dbo].[empleados_envasadosDelete]",  _
                     "[dbo].[empleados_envasadosSelectDgv]",  _
                     "[dbo].[empleados_envasadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_empleados_envasados
       Dim dbo As New DBO_empleados_envasados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_empleados_envasados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
