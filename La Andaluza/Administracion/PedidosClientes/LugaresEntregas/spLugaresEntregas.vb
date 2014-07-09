Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spLugaresEntregas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[LugaresEntregasSelect]", _
                      "[dbo].[LugaresEntregasInsert]", _
                      "[dbo].[LugaresEntregasUpdate]", _
                      "[dbo].[LugaresEntregasDelete]", _
                      "[dbo].[LugaresEntregasSelectDgv]", _
                      "[dbo].[LugaresEntregasSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal LugarEntregaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_LugaresEntregas
       Dim dbo As New DBO_LugaresEntregas
       dbo.searchKey = dbo.item("LugarEntregaID")
       dbo.searchKey.value = LugarEntregaID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal LugarEntregaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_LugaresEntregas
       dbo.searchKey = dbo.item("LugarEntregaID")
       dbo.searchKey.value = LugarEntregaID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_LugaresEntregas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("LugaresEntregasCbo", False)
   End Sub

End Class
