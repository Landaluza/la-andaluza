Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spDepartamentos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[DepartamentosSelect]", _
                      "[dbo].[DepartamentosInsert]", _
                      "[dbo].[DepartamentosUpdate]", _
                      "[dbo].[DepartamentosDelete]", _
                      "[dbo].[DepartamentosSelectDgv]", _
                      "[dbo].[DepartamentosSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Departamentos
       Dim dbo As New DBO_Departamentos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Departamentos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_Departamentos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("DepartamentosCbo", False)
   End Sub

End Class
