
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

    Public Overloads Function Select_Record(ByVal LoteID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_RevisionLotes
        Dim dbo As New DBO_RevisionLotes
        dbo.searchKey = dbo.item("LoteID")
        dbo.searchKey.value = LoteID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal LoteID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_RevisionLotes
        dbo.searchKey = dbo.item("LoteID")
        dbo.searchKey.value = LoteID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

End Class
