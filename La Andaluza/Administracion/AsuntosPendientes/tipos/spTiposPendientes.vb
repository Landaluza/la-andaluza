Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposPendientesSelect]", _
                      "[dbo].[TiposPendientesInsert]", _
                      "[dbo].[TiposPendientesUpdate]", _
                      "[dbo].[TiposPendientesDelete]", _
                      "[dbo].[TiposPendientesSelectDgv]", _
                      "[dbo].[TiposPendientesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposPendientes
       Dim dbo As New DBO_TiposPendientes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposPendientes
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_TiposPendientes(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposPendientesCbo", False)
   End Sub

End Class
