
Public Class spArticulosMinMax
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosMinMaxSelect]", _
                      "[dbo].[ArticulosMinMaxInsert]", _
                      "[dbo].[ArticulosMinMaxUpdate]", _
                      "[dbo].[ArticulosMinMaxDelete]", _
                      "[dbo].[ArticulosMinMaxSelectDgv]", _
                      "[dbo].[ArticulosMinMaxSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal ArticuloMinMaxID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosMinMax
        Dim dbo As New DBO_ArticulosMinMax
        dbo.searchKey = dbo.item("ArticuloMinMaxID")
        dbo.searchKey.value = ArticuloMinMaxID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ArticuloMinMaxID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ArticulosMinMax
        dbo.searchKey = dbo.item("ArticuloMinMaxID")
        dbo.searchKey.value = ArticuloMinMaxID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
