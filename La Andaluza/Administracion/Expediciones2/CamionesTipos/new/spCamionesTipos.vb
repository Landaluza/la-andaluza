Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spCamionesTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[CamionesTiposSelect]",  _
                     "[dbo].[CamionesTiposInsert]",  _
                     "[dbo].[CamionesTiposUpdate]",  _
                     "[dbo].[CamionesTiposDelete]",  _
                     "[dbo].[CamionesTiposSelectDgv]",  _
                     "[dbo].[CamionesTiposSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal CamionTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_CamionesTipos
       Dim dbo As New DBO_CamionesTipos
       dbo.searchKey = dbo.item("CamionTipoID")
       dbo.searchKey.value = CamionTipoID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal CamionTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_CamionesTipos
       dbo.searchKey = dbo.item("CamionTipoID")
       dbo.searchKey.value = CamionTipoID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_CamionesTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("CamionesTiposCbo", False)
   End Sub

End Class
