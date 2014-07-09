Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposCajas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposCajasSelect]", _
                      "[dbo].[TiposCajasInsert]", _
                      "[dbo].[TiposCajasUpdate]", _
                      "[dbo].[TiposCajasDelete]", _
                      "[dbo].[TiposCajasSelectDgv]", _
                      "[dbo].[TiposCajasSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal TipoCajaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposCajas
       Dim dbo As New DBO_TiposCajas
       dbo.searchKey = dbo.item("TipoCajaID")
       dbo.searchKey.value = TipoCajaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal TipoCajaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposCajas
       dbo.searchKey = dbo.item("TipoCajaID")
       dbo.searchKey.value = TipoCajaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_TiposCajas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposCajasCbo", False)
   End Sub

End Class
