
Public Class spArticulosLoteados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ArticulosLoteadosSelect]",  _
                     "[dbo].[ArticulosLoteadosInsert]",  _
                     "[dbo].[ArticulosLoteadosUpdate]",  _
                     "[dbo].[ArticulosLoteadosDelete]",  _
                     "[dbo].[ArticulosLoteadosSelectDgv]",  _
                     "[dbo].[ArticulosLoteadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ArticuloEnvaseTerciarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ArticulosLoteados
       Dim dbo As New DBO_ArticulosLoteados
       dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
       dbo.searchKey.value = ArticuloEnvaseTerciarioID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ArticuloEnvaseTerciarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ArticulosLoteados
       dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
       dbo.searchKey.value = ArticuloEnvaseTerciarioID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
