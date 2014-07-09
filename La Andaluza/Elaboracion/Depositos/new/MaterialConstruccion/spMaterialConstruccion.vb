Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMaterialConstruccion
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MaterialConstruccionSelect]",  _
                     "[dbo].[MaterialConstruccionInsert]",  _
                     "[dbo].[MaterialConstruccionUpdate]",  _
                     "[dbo].[MaterialConstruccionDelete]",  _
                     "[dbo].[MaterialConstruccionSelectDgv]",  _
                     "[dbo].[MaterialConstruccionSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal MaterialConstruccionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_MaterialConstruccion
       Dim dbo As New DBO_MaterialConstruccion
       dbo.searchKey = dbo.item("MaterialConstruccionID")
       dbo.searchKey.value = MaterialConstruccionID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal MaterialConstruccionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_MaterialConstruccion
       dbo.searchKey = dbo.item("MaterialConstruccionID")
       dbo.searchKey.value = MaterialConstruccionID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_MaterialConstruccion(ByRef cbo As ComboBox)
       cbo.mam_DataSource("MaterialConstruccionCbo", False)
   End Sub

End Class
