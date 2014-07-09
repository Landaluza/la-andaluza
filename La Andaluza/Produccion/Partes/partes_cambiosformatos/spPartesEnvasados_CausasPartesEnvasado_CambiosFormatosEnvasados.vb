
Public Class spPartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasadosSelect]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasadosInsert]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasadosUpdate]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasadosDelete]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasadosSelectDgv]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasados
       Dim dbo As New DBO_PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
