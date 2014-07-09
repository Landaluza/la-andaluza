Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spFrecuenciasTiposControlesLotes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FrecuenciasTiposControlesLotesSelect]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesInsert]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesUpdate]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesDelete]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesSelectDgv]",  _
                     "[dbo].[FrecuenciasTiposControlesLotesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_FrecuenciasTiposControlesLotes
       Dim dbo As New DBO_FrecuenciasTiposControlesLotes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_FrecuenciasTiposControlesLotes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_FrecuenciasTiposControlesLotes(ByRef cbo As ComboBox)
       cbo.mam_DataSource("FrecuenciasTiposControlesLotesCbo", False)
   End Sub

End Class
