
Public Class spArticulosEnvasesTerciarios
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosEnvasesTerciariosSelect]", _
                      "[dbo].[ArticulosEnvasesTerciariosInsert]", _
                      "[dbo].[ArticulosEnvasesTerciariosUpdate]", _
                      "[dbo].[ArticulosEnvasesTerciariosDelete]", _
                      "[dbo].[ArticulosEnvasesTerciariosSelectDgv]", _
                      "[dbo].[ArticulosEnvasesTerciariosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal ArticuloEnvaseTerciarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosEnvasesTerciarios
        Dim dbo As New DBO_ArticulosEnvasesTerciarios
        dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
        dbo.searchKey.value = ArticuloEnvaseTerciarioID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ArticuloEnvaseTerciarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ArticulosEnvasesTerciarios
        dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
        dbo.searchKey.value = ArticuloEnvaseTerciarioID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function


    Public Function Select_RecordByArticuloID(ByVal ArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosEnvasesTerciarios
        Dim dbo As New DBO_ArticulosEnvasesTerciarios
        dbo.searchKey = dbo.item("ArticuloID")
        dbo.searchKey.value = ArticuloID
        MyBase.Select_proc(CType(dbo, BasesParaCompatibilidad.databussines), "ArticulosEnvasesTerciarios1SelectByArticuloID", dtb)
        Return dbo
    End Function

    Public Function Select_RecordBySccEtiquetaID(ByVal ArticuloID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosEnvasesTerciarios
        Dim dbo As New DBO_ArticulosEnvasesTerciarios
        dbo.searchKey = dbo.item("SccEtiquetaID")
        dbo.searchKey.value = ArticuloID
        MyBase.Select_proc(CType(dbo, BasesParaCompatibilidad.databussines), "ArticulosEnvasesTerciarios1SelectByTipoFormato", dtb)
        Return dbo
    End Function
End Class
