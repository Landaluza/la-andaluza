
Public Class spRevisionLotes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[RevisionLotesSelect]",  _
                     "[dbo].[RevisionLotesInsert]",  _
                     "[dbo].[RevisionLotesUpdate]",  _
                     "[dbo].[RevisionLotesDelete]",  _
                     "[dbo].[RevisionLotesSelectDgv]",  _
                     "[dbo].[RevisionLotesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal LoteID As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_RevisionLotes
       Dim dbo As New DBO_RevisionLotes
       dbo.searchKey = dbo.item("LoteID")
       dbo.searchKey.value = LoteID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal LoteID As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_RevisionLotes
       dbo.searchKey = dbo.item("LoteID")
       dbo.searchKey.value = LoteID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.Databussines), trans)
   End Function

End Class
