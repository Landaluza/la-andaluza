
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

    Public Overloads Function Select_Record(ByVal ID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ControlesLotes
        Dim dbo As New DBO_ControlesLotes
        dbo.searchKey = dbo.item("ID")
        dbo.searchKey.value = ID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ControlesLotes
        dbo.searchKey = dbo.item("ID")
        dbo.searchKey.value = ID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
