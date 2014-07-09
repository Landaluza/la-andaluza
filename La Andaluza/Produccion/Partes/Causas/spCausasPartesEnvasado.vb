Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spCausasPartesEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CausasPartesEnvasadoSelect]",  _
                     "[dbo].[CausasPartesEnvasadoInsert]",  _
                     "[dbo].[CausasPartesEnvasadoUpdate]",  _
                     "[dbo].[CausasPartesEnvasadoDelete]",  _
                     "[dbo].[CausasPartesEnvasadoSelectDgv]",  _
                     "[dbo].[CausasPartesEnvasadoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_CausasPartesEnvasado
       Dim dbo As New DBO_CausasPartesEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_CausasPartesEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_CausasPartesEnvasado(ByRef cbo As ComboBox)
       cbo.mam_DataSource("CausasPartesEnvasadoCbo", False)
   End Sub

End Class
