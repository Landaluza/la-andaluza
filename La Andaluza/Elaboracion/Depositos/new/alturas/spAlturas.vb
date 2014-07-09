Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spAlturas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AlturasSelect]",  _
                     "[dbo].[AlturasInsert]",  _
                     "[dbo].[AlturasUpdate]",  _
                     "[dbo].[AlturasDelete]",  _
                     "[dbo].[AlturasSelectDgv]",  _
                     "[dbo].[AlturasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal AlturaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Alturas
       Dim dbo As New DBO_Alturas
       dbo.searchKey = dbo.item("AlturaID")
       dbo.searchKey.value = AlturaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal AlturaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Alturas
       dbo.searchKey = dbo.item("AlturaID")
       dbo.searchKey.value = AlturaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Alturas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("AlturasCbo", False)
   End Sub

End Class
