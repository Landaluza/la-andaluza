Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spRecipientesSalidas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[RecipientesSalidasSelect]",  _
                     "[dbo].[RecipientesSalidasInsert]",  _
                     "[dbo].[RecipientesSalidasUpdate]",  _
                     "[dbo].[RecipientesSalidasDelete]",  _
                     "[dbo].[RecipientesSalidasSelectDgv]",  _
                     "[dbo].[RecipientesSalidasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal RecipienteSalidaID As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_RecipientesSalidas
       Dim dbo As New DBO_RecipientesSalidas
       dbo.searchKey = dbo.item("RecipienteSalidaID")
       dbo.searchKey.value = RecipienteSalidaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal RecipienteSalidaID As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_RecipientesSalidas
       dbo.searchKey = dbo.item("RecipienteSalidaID")
       dbo.searchKey.value = RecipienteSalidaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

   Public Sub cargar_RecipientesSalidas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("RecipientesSalidasCbo", False)
   End Sub

End Class
