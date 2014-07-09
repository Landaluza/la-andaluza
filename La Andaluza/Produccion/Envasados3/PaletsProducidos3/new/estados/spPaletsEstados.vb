Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPaletsEstados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PaletsEstadosSelect]",  _
                     "[dbo].[PaletsEstadosInsert]",  _
                     "[dbo].[PaletsEstadosUpdate]",  _
                     "[dbo].[PaletsEstadosDelete]",  _
                     "[dbo].[PaletsEstadosSelectDgv]",  _
                     "[dbo].[PaletsEstadosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_PaletsEstados
       Dim dbo As New DBO_PaletsEstados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_PaletsEstados
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_PaletsEstados(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PaletsEstadosCbo", False)
   End Sub

End Class
