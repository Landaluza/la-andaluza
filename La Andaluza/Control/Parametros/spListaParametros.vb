Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spListaParametros
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ListaParametrosSelect]",  _
                     "[dbo].[ListaParametrosInsert]",  _
                     "[dbo].[ListaParametrosUpdate]",  _
                     "[dbo].[ListaParametrosDelete]",  _
                     "[dbo].[ListaParametrosSelectDgv]",  _
                     "[dbo].[ListaParametrosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ParametroID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ListaParametros
       Dim dbo As New DBO_ListaParametros
       dbo.searchKey = dbo.item("ParametroID")
       dbo.searchKey.value = ParametroID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ParametroID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ListaParametros
       dbo.searchKey = dbo.item("ParametroID")
       dbo.searchKey.value = ParametroID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ListaParametros(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ListaParametrosCbo", False)
   End Sub

End Class
