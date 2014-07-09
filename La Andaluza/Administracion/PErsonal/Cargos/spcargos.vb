Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spcargos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[cargosSelect]", _
                      "[dbo].[cargosInsert]", _
                      "[dbo].[cargosUpdate]", _
                      "[dbo].[cargosDelete]", _
                      "[dbo].[cargosSelectDgv]", _
                      "[dbo].[cargosSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_cargos
       Dim dbo As New DBO_cargos
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_cargos
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_cargos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("cargosCbo", False)
   End Sub

End Class
