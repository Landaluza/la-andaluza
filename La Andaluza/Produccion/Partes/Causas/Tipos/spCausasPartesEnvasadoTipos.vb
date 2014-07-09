Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spCausasPartesEnvasadoTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CausasPartesEnvasadoTiposSelect]",  _
                     "[dbo].[CausasPartesEnvasadoTiposInsert]",  _
                     "[dbo].[CausasPartesEnvasadoTiposUpdate]",  _
                     "[dbo].[CausasPartesEnvasadoTiposDelete]",  _
                     "[dbo].[CausasPartesEnvasadoTiposSelectDgv]",  _
                     "[dbo].[CausasPartesEnvasadoTiposSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_CausasPartesEnvasadoTipos
       Dim dbo As New DBO_CausasPartesEnvasadoTipos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_CausasPartesEnvasadoTipos
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_CausasPartesEnvasadoTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("CausasPartesEnvasadoTiposCbo", False)
   End Sub

End Class
