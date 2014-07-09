Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spRecuentoMaterialesAuxiliares
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[RecuentoMaterialesAuxiliaresSelect]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresInsert]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresUpdate]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresDelete]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresSelectDgv]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_RecuentoMaterialesAuxiliares
       Dim dbo As New DBO_RecuentoMaterialesAuxiliares
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_RecuentoMaterialesAuxiliares
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_RecuentoMaterialesAuxiliares(ByRef cbo As ComboBox)
       cbo.mam_DataSource("RecuentoMaterialesAuxiliaresCbo", False)
   End Sub

End Class
