Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPersonalCompetencias
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PersonalCompetenciasSelect]", _
                      "[dbo].[PersonalCompetenciasInsert]", _
                      "[dbo].[PersonalCompetenciasUpdate]", _
                      "[dbo].[PersonalCompetenciasDelete]", _
                      "[dbo].[PersonalCompetenciasSelectDgv]", _
                      "[dbo].[PersonalCompetenciasSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal PersonalCompetenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_PersonalCompetencias
       Dim dbo As New DBO_PersonalCompetencias
       dbo.searchKey = dbo.item("PersonalCompetenciaID")
       dbo.searchKey.value = PersonalCompetenciaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PersonalCompetenciaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_PersonalCompetencias
       dbo.searchKey = dbo.item("PersonalCompetenciaID")
       dbo.searchKey.value = PersonalCompetenciaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_PersonalCompetencias(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PersonalCompetenciasCbo", False)
   End Sub

End Class
