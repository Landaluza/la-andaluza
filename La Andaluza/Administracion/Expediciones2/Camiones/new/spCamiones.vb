
Public Class spCamiones
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[CamionesSelect]", _
                      "[dbo].[CamionesInsert]", _
                      "[dbo].[CamionesUpdate]", _
                      "[dbo].[CamionesDelete]", _
                      "[dbo].[CamionesSelectDgv]", _
                      "[dbo].[CamionesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal CamionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Camiones
        Dim dbo As New DBO_Camiones
        dbo.searchKey = dbo.item("CamionID")
        dbo.searchKey.value = CamionID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal CamionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Camiones
        dbo.searchKey = dbo.item("CamionID")
        dbo.searchKey.value = CamionID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
