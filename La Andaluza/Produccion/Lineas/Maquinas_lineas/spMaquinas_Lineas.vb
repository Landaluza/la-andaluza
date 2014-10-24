

Public Class spMaquinas_Lineas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Maquinas_LineasSelect]",  _
                     "[dbo].[Maquinas_LineasInsert]",  _
                     "[dbo].[Maquinas_LineasUpdate]",  _
                     "[dbo].[Maquinas_LineasDelete]",  _
                     "[dbo].[Maquinas_LineasSelectDgv]",  _
                     "[dbo].[Maquinas_LineasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Maquinas_Lineas
        Dim dbo As New DBO_Maquinas_Lineas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Maquinas_Lineas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

End Class
