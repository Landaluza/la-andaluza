Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposUsuarios
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[TiposUsuariosSelect]", _
                      "[dbo].[TiposUsuariosInsert]", _
                      "[dbo].[TiposUsuariosUpdate]", _
                      "[dbo].[TiposUsuariosDelete]", _
                      "[dbo].[TiposUsuariosSelectDgv]", _
                      "[dbo].[TiposUsuariosSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal TipoUsuarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposUsuarios
       Dim dbo As New DBO_TiposUsuarios
       dbo.searchKey = dbo.item("TipoUsuarioID")
       dbo.searchKey.value = TipoUsuarioID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal TipoUsuarioID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TiposUsuarios
       dbo.searchKey = dbo.item("TipoUsuarioID")
       dbo.searchKey.value = TipoUsuarioID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_TiposUsuarios(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposUsuariosCbo", False)
   End Sub

End Class
