Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class sptiposEnvases
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[tiposEnvasesSelect]", _
                      "[dbo].[tiposEnvasesInsert]", _
                      "[dbo].[tiposEnvasesUpdate]", _
                      "[dbo].[tiposEnvasesDelete]", _
                      "[dbo].[tiposEnvasesSelectDgv]", _
                      "[dbo].[tiposEnvasesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_tiposEnvases
       Dim dbo As New DBO_tiposEnvases
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_tiposEnvases
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_tiposEnvases(ByRef cbo As ComboBox)
       cbo.mam_DataSource("tiposEnvasesCbo", False)
   End Sub

End Class
