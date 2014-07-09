Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposControlesLotes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposControlesLotesSelect]",  _
                     "[dbo].[TiposControlesLotesInsert]",  _
                     "[dbo].[TiposControlesLotesUpdate]",  _
                     "[dbo].[TiposControlesLotesDelete]",  _
                     "[dbo].[TiposControlesLotesSelectDgv]",  _
                     "[dbo].[TiposControlesLotesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposControlesLotes
       Dim dbo As New DBO_TiposControlesLotes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposControlesLotes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_TiposControlesLotes(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposControlesLotesCbo", False)
   End Sub

End Class
