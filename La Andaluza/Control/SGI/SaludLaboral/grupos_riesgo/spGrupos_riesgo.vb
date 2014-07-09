Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spGrupos_riesgo
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Grupos_riesgoSelect]",  _
                     "[dbo].[Grupos_riesgoInsert]",  _
                     "[dbo].[Grupos_riesgoUpdate]",  _
                     "[dbo].[Grupos_riesgoDelete]",  _
                     "[dbo].[Grupos_riesgoSelectDgv]",  _
                     "[dbo].[Grupos_riesgoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Grupos_riesgo
       Dim dbo As New DBO_Grupos_riesgo
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Grupos_riesgo
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_Grupos_riesgo(ByRef cbo As ComboBox)
       cbo.mam_DataSource("Grupos_riesgoCbo", False)
   End Sub

End Class
