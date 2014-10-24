

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

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_empleados_envasados
        Dim dbo As New DBO_empleados_envasados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_empleados_envasados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
