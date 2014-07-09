Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spNaves
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[NavesSelect]",  _
                     "[dbo].[NavesInsert]",  _
                     "[dbo].[NavesUpdate]",  _
                     "[dbo].[NavesDelete]",  _
                     "[dbo].[NavesSelectDgv]",  _
                     "[dbo].[NavesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal NaveID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Naves
       Dim dbo As New DBO_Naves
       dbo.searchKey = dbo.item("NaveID")
       dbo.searchKey.value = NaveID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal NaveID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Naves
       dbo.searchKey = dbo.item("NaveID")
       dbo.searchKey.value = NaveID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Naves(ByRef cbo As ComboBox)
       cbo.mam_DataSource("NavesCbo", False)
   End Sub

End Class
