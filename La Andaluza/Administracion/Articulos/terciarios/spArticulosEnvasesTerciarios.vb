
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

   Public Overloads Function Select_Record(ByVal ArticuloEnvaseTerciarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ArticulosEnvasesTerciarios
       Dim dbo As New DBO_ArticulosEnvasesTerciarios
       dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
       dbo.searchKey.value = ArticuloEnvaseTerciarioID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ArticuloEnvaseTerciarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ArticulosEnvasesTerciarios
       dbo.searchKey = dbo.item("ArticuloEnvaseTerciarioID")
       dbo.searchKey.value = ArticuloEnvaseTerciarioID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function


    Public Function Select_RecordByArticuloID(ByVal ArticuloID As Int32, Optional ByRef trans As SqlClient.SqlTransaction = Nothing) As DBO_ArticulosEnvasesTerciarios
        Dim dbo As New DBO_ArticulosEnvasesTerciarios
        dbo.searchKey = dbo.item("ArticuloID")
        dbo.searchKey.value = ArticuloID
        MyBase.Select_proc(CType(dbo, BasesParaCompatibilidad.databussines), "ArticulosEnvasesTerciarios1SelectByArticuloID", trans)
        Return dbo
    End Function

    Public Function Select_RecordBySccEtiquetaID(ByVal ArticuloID As Int32, Optional ByRef trans As SqlClient.SqlTransaction = Nothing) As DBO_ArticulosEnvasesTerciarios
        Dim dbo As New DBO_ArticulosEnvasesTerciarios
        dbo.searchKey = dbo.item("SccEtiquetaID")
        dbo.searchKey.value = ArticuloID
        MyBase.Select_proc(CType(dbo, BasesParaCompatibilidad.databussines), "ArticulosEnvasesTerciarios1SelectByTipoFormato", trans)
        Return dbo
    End Function
End Class
