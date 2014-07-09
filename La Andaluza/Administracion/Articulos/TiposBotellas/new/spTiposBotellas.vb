Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposBotellas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposBotellasSelect]", _
                      "[dbo].[TiposBotellasInsert]", _
                      "[dbo].[TiposBotellasUpdate]", _
                      "[dbo].[TiposBotellasDelete]", _
                      "[dbo].[TiposBotellasSelectDgv]", _
                      "[dbo].[TiposBotellasSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal TipoBotellaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposBotellas
       Dim dbo As New DBO_TiposBotellas
       dbo.searchKey = dbo.item("TipoBotellaID")
       dbo.searchKey.value = TipoBotellaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal TipoBotellaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposBotellas
       dbo.searchKey = dbo.item("TipoBotellaID")
       dbo.searchKey.value = TipoBotellaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

    Public Sub cargar_TiposBotellas(ByRef cbo As ComboBox)
        cbo.mam_DataSource("TiposBotellasCbo", False)
    End Sub
End Class
