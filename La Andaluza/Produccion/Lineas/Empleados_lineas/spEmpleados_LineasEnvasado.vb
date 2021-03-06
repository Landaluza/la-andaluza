

Public Class spEmpleados_LineasEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Empleados_LineasEnvasadoSelect]",  _
                     "[dbo].[Empleados_LineasEnvasadoInsert]",  _
                     "[dbo].[Empleados_LineasEnvasadoUpdate]",  _
                     "[dbo].[Empleados_LineasEnvasadoDelete]",  _
                     "[dbo].[Empleados_LineasEnvasadoSelectDgv]",  _
                     "[dbo].[Empleados_LineasEnvasadoSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Empleados_LineasEnvasado
        Dim dbo As New DBO_Empleados_LineasEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Empleados_LineasEnvasado
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
