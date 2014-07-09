

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

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Maquinas_Lineas
       Dim dbo As New DBO_Maquinas_Lineas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Maquinas_Lineas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
