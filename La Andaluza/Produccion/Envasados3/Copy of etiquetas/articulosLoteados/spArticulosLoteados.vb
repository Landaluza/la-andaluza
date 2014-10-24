
Public Class spArticulosLoteados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ArticulosLoteadosSelect]",  _
                     "[dbo].[ArticulosLoteadosInsert]",  _
                     "[dbo].[ArticulosLoteadosUpdate]",  _
                     "[dbo].[ArticulosLoteadosDelete]",  _
                     "[dbo].[ArticulosLoteadosSelectDgv]",  _
                     "[dbo].[ArticulosLoteadosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ArticuloEnvaseTerciarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosLoteados
        Dim dbo As New DBO_ArticulosLoteados
        dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
        dbo.searchKey.value = ArticuloEnvaseTerciarioID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ArticuloEnvaseTerciarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ArticulosLoteados
        dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
        dbo.searchKey.value = ArticuloEnvaseTerciarioID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
