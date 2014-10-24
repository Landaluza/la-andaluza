
Public Class spArticulosEnvasesSecundarios
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosEnvasesSecundariosSelect]", _
                      "[dbo].[ArticulosEnvasesSecundariosInsert]", _
                      "[dbo].[ArticulosEnvasesSecundariosUpdate]", _
                      "[dbo].[ArticulosEnvasesSecundariosDelete]", _
                      "[dbo].[ArticulosEnvasesSecundariosSelectDgv]", _
                      "[dbo].[ArticulosEnvasesSecundariosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal EnvaseSecundarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosEnvasesSecundarios
        Dim dbo As New DBO_ArticulosEnvasesSecundarios
        dbo.searchKey = dbo.item("EnvaseSecundarioID")
        dbo.searchKey.value = EnvaseSecundarioID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal EnvaseSecundarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ArticulosEnvasesSecundarios
        dbo.searchKey = dbo.item("EnvaseSecundarioID")
        dbo.searchKey.value = EnvaseSecundarioID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Function Select_RecordByArticuloID(ByVal articuloid As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosEnvasesSecundarios
        Dim dbo As New DBO_ArticulosEnvasesSecundarios
        dbo.searchKey = dbo.item("ArticuloID")
        dbo.searchKey.value = articuloid
        MyBase.Select_proc(CType(dbo, BasesParaCompatibilidad.databussines), "ArticulosEnvasesSecundariosSelectByArticuloID", dtb)
        Return dbo
    End Function

 
End Class
