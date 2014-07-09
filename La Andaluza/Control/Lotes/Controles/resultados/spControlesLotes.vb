
Public Class spControlesLotes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ControlesLotesSelect]",  _
                     "[dbo].[ControlesLotesInsert]",  _
                     "[dbo].[ControlesLotesUpdate]",  _
                     "[dbo].[ControlesLotesDelete]",  _
                     "[dbo].[ControlesLotesSelectDgv]",  _
                     "[dbo].[ControlesLotesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ControlesLotes
       Dim dbo As New DBO_ControlesLotes
       dbo.searchKey = dbo.item("ID")
       dbo.searchKey.value = ID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ControlesLotes
       dbo.searchKey = dbo.item("ID")
       dbo.searchKey.value = ID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

End Class
