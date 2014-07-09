

Public Class spMaterialesEnvasados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MaterialesEnvasadosSelect]",  _
                     "[dbo].[MaterialesEnvasadosInsert]",  _
                     "[dbo].[MaterialesEnvasadosUpdate]",  _
                     "[dbo].[MaterialesEnvasadosDelete]",  _
                     "[dbo].[MaterialesEnvasadosSelectDgv]",  _
                     "[dbo].[MaterialesEnvasadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal MaterialEnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_MaterialesEnvasados
       Dim dbo As New DBO_MaterialesEnvasados
       dbo.searchKey = dbo.item("MaterialEnvasadoID")
       dbo.searchKey.value = MaterialEnvasadoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal MaterialEnvasadoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_MaterialesEnvasados
       dbo.searchKey = dbo.item("MaterialEnvasadoID")
       dbo.searchKey.value = MaterialEnvasadoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

End Class
