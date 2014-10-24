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

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Grupos_riesgo
        Dim dbo As New DBO_Grupos_riesgo
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Grupos_riesgo
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_Grupos_riesgo(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("Grupos_riesgoCbo", False, dtb)
    End Sub

End Class
